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
            var type = new Tuple<int, string>[]
            {
                new Tuple<int, string>(0, "普通"),
                new Tuple<int, string>(1, "白名单"),
                new Tuple<int, string>(2, "黑名单"),
                new Tuple<int, string>(-1, "所有"),
            };

            comboBoxType.DataSource = type;
            comboBoxType.ValueMember = "Item1";
            comboBoxType.DisplayMember = "Item2";

            var queryMode = new Tuple<short, string>[]
            {
                new Tuple<short, string>(0, "精确"),
                new Tuple<short, string>(1, "模糊"),
            };

            comboBoxQueryMode.DataSource = queryMode;
            comboBoxQueryMode.ValueMember = "Item1";
            comboBoxQueryMode.DisplayMember = "Item2";
        }

        public HaCamera Cam { get; set; } 

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormFaceQuery_Load(object sender, EventArgs e)
        {

        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            _curPage = 1;
            DoQuery();
        }


        private void DoQuery()
        {
            var condition = new RecordQueryCondition();
            var total = 0;
            var pageSize = int.Parse(textBoxPageSize.Text);
            var result = Cam?.QueryFaces(
                _curPage,
                pageSize,
                (int)comboBoxType.SelectedValue,
                checkBoxOutputFeature.Checked,
                ref total, 
                1000 * 10,
                condition,
                (short)comboBoxQueryMode.SelectedValue);

            if (result == null)
            {
                MessageBox.Show("Failed");
                return;

            }

            CalcPageCount(pageSize, total);

            dataGridViewFaceQueryResult.Rows.Clear();
            foreach (var item in result)
            {
                dataGridViewFaceQueryResult.Rows.Add(
                    item.PersonID,
                    item.PersonName,
                    item.PersonRole);
            }


        }

        private void CalcPageCount(int pageSize, int total)
        {
            var pageCount = (total + pageSize - 1) / pageSize;
            labelPageIndicator.Text = $"{_curPage}/{pageCount}";
        }
    }
}
