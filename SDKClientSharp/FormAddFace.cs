using HaSdkWrapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SDKClientSharp
{
    public partial class FormAddFace : Form
    {
        public HaCamera Cam { get; set; }


        private string pathToPic;

        public FormAddFace()
        {
            InitializeComponent();
            InitUi();
        }

        private void InitUi()
        {
            this.comboBoxFaceType.InitAsFaceType();
            this.comboBoxScheduleMode.InitAsScheduleMode();
            this.comboBoxValidToType.InitAsValidToMode();
        }

        private void buttonChoosePic_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                pathToPic = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromStream(
                    new MemoryStream(File.ReadAllBytes(openFileDialog1.FileName))
                    );

            }
        }

        private void buttonAddFace_Click(object sender, EventArgs e)
        {
           var res =  Cam.AddFace(
                textBoxId.Text,
                textBoxName.Text,
                (int)comboBoxFaceType.SelectedValue,
                pathToPic,
                uint.Parse(textBoxWiegandCardNo.Text),
                Utils.GetUtcSecondsBasedOnValidToType((int)comboBoxValidToType.SelectedValue, dateTimePickerValidTo.Value),
                dateTimePickerValidFrom.Value.ToUtcSecondsFromEpochTime(),
                (byte)comboBoxScheduleMode.SelectedValue,
                null
                );

            var msg = string.Format(strings.AddFaceMsg,  res ? strings.Success : strings.Fail);
            MessageBox.Show(msg);
        }

        private void FormAddFace_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
