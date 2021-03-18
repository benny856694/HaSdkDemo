using HaSdkWrapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SDKClientSharp
{
    public partial class FormFaceQuery : Form
    {
        private int _curPage = 1;
        public FormFaceQuery()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            comboBoxType.InitAsFaceQueryType();
            comboBoxQueryMode.InitAsMathingMode();
        }

        public HaCamera Cam { get; set; }
        public int CurPage
        { 
            get => _curPage; 
            set  {
                _curPage = value;
                UpdatePageIndicator(int.Parse(textBoxPageSize.Text), _curPage);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormFaceQuery_Load(object sender, EventArgs e)
        {

        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            CurPage = 1;
            DoQuery();
        }


        private void DoQuery()
        {
            var condition = new RecordQueryCondition();
            condition.ById = checkBoxId.Checked;
            condition.PersonId = textBoxId.Text;
            condition.ByName = checkBoxName.Checked;
            condition.PersonName = textBoxName.Text;
            condition.WgNo = checkBoxWiegandNo.Checked;
            if (checkBoxWiegandNo.Checked)
            {
                condition.WgNoc = int.Parse(textBoxWiegandNo.Text);
            }
            condition.ByCaptureTime2 = checkBoxValidTo.Checked;
            condition.TimeStart2 = dateTimePickerValidToRangeStart.Value;
            condition.TimeEnd2 = dateTimePickerValidToRangeEnd.Value;
            condition.ByCaptureTime1 = checkBoxValidFrom.Checked;
            condition.Time1Start = dateTimePickerValidFromRangeStart.Value;
            condition.Time1End = dateTimePickerValidFromRangeEnd.Value;
            var total = 0;
            var pageSize = int.Parse(textBoxPageSize.Text);
            var result = Cam?.QueryFaces(
                CurPage,
                pageSize,
                (int)comboBoxType.SelectedValue,
                checkBoxOutputFeature.Checked,
                ref total, 
                1000 * 10,
                condition,
                (short)comboBoxQueryMode.SelectedValue);

            if (result == null)
            {
                var lastError = Cam.GetLastError();
                if (lastError != NativeConstants.ERR_NONE)
                {
                    var msg = string.Format(strings.ErrorWithErrorMsg, HaCamera.GetErrorDescribe(lastError));
                    MessageBox.Show(msg);

                }
                return;

            }

            UpdatePageIndicator(pageSize, total);

            dataGridViewFaceQueryResult.Rows.Clear();
            foreach (var item in result)
            {
                dataGridViewFaceQueryResult.Rows.Add(
                    item.PersonID,
                    item.PersonName,
                    item.PersonRole);
            }


        }

        private void UpdatePageIndicator(int pageSize, int total)
        {
            var pageCount = (total + pageSize - 1) / pageSize;
            labelPageIndicator.Text = $"{CurPage}/{pageCount}";
        }

        private void buttonPrevPage_Click(object sender, EventArgs e)
        {
            CurPage--;
            DoQuery();
        }

        private void buttonNextPage_Click(object sender, EventArgs e)
        {
            CurPage++;
            DoQuery();
        }
    }
}
