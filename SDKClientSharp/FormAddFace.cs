using HaSdkWrapper;
using System;
using System.Drawing;
using System.IO;
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
                buttonVerifyFaceImg.Visible =
                    pathToPic.EndsWith(".jpg", StringComparison.InvariantCultureIgnoreCase) ||
                    pathToPic.EndsWith(".png", StringComparison.InvariantCultureIgnoreCase);

            }
        }

        private void buttonAddFace_Click(object sender, EventArgs e)
        {
            var res = Cam.AddFace(
                 textBoxId.Text,
                 textBoxName.Text,
                 (int)comboBoxFaceType.SelectedValue,
                 pathToPic,
                 uint.Parse(textBoxWiegandCardNo.Text),
                 Utils.GetUtcSecondsBasedOnValidToType((int)comboBoxValidToType.SelectedValue, dateTimePickerValidTo.Value),
                 dateTimePickerValidFrom.Value.ToUtcSecondsFromEpochTime(),
                 (byte)comboBoxScheduleMode.SelectedValue,
                 ""
                 );

            var errorCode = 0;
            string errorMsg = null;
            if (!res)
            {
                errorCode = Cam.GetLastError();
                errorMsg = HaCamera.GetErrorDescribe(errorCode);
            }

            Utils.ShowMsg(strings.AddFaceAction, res, errorCode, errorMsg);

        }

        private void FormAddFace_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonVerifyFaceImg_Click(object sender, EventArgs e)
        {
            var suc = Cam.HA_FaceJpgLegal(File.ReadAllBytes(pathToPic));
            var msg = suc == 0 ? strings.Success : strings.Fail;
            MessageBox.Show(string.Format(strings.ValidateImageMsg, msg));
        }

        private async void buttonAddFaceByHttp_Click(object sender, EventArgs e)
        {
            var client = new HaSdkWrapper.Api.Client(Cam.Ip) { UserName = Cam.Username, Password = Cam.Password };

            var res = await client.AddFaceAsync(textBoxId.Text,
                 textBoxName.Text,
                 (int)comboBoxFaceType.SelectedValue,
                 pathToPic,
                 uint.Parse(textBoxWiegandCardNo.Text),
                 Utils.GetUtcSecondsBasedOnValidToType((int)comboBoxValidToType.SelectedValue, dateTimePickerValidTo.Value),
                 dateTimePickerValidFrom.Value.ToUtcSecondsFromEpochTime(),
                 (byte)comboBoxScheduleMode.SelectedValue,
                 "");

            MessageBox.Show(res.ToString(), this.Text, MessageBoxButtons.OK, res.code == 0 ? MessageBoxIcon.None : MessageBoxIcon.Error);


        }
    }
}
