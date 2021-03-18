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
    public partial class FormBasic : Form
    {
        private HaCamera _cam;

        public FormBasic()
        {
            InitializeComponent();
        }

        private void FormBasic_Load(object sender, EventArgs e)
        {
            HaCamera.InitEnvironment();
            HaCamera.DeviceDiscovered += HaCamera_DeviceDiscovered;
        }

        private void HaCamera_DeviceDiscovered(object sender, HaSdkWrapper.DeviceDiscoverdEventArgs e)
        {
            
                BeginInvoke(new Action(() =>
                {
                    int rowIdx = dataGridViewCameraList.Rows.Add();
                    dataGridViewCameraList.Rows[rowIdx].Cells[0].Value = e.IP;
                    dataGridViewCameraList.Rows[rowIdx].Cells[1].Value = e.Mac;
                    //dataGridView1.Rows[rowIdx].Cells[2].Value = e.NetMask;
                    //dataGridView1.Rows[rowIdx].Cells[3].Value = e.Manufacturer;
                    //dataGridView1.Rows[rowIdx].Cells[4].Value = e.Plateform;
                    //dataGridView1.Rows[rowIdx].Cells[5].Value = e.System;
                    //dataGridView1.Rows[rowIdx].Cells[6].Value = e.Version;

                    tabControl1.SelectedTab = tabPageCameraSearchResult;
                }));
            
        }

        private void buttonSearchDevice_Click(object sender, EventArgs e)
        {
            dataGridViewCameraList.Rows.Clear();
            HaCamera.DiscoverDevice();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            _cam?.DisConnect();

            _cam = new HaCamera();
            _cam.Ip = textBoxIp.Text;
            _cam.Port = int.Parse(textBoxPort.Text);
            _cam.Username = textBoxUserName.Text;
            _cam.Password = textBoxPassword.Text;

            _cam.FaceCaptured += _cam_FaceCaptured;
            var suc = _cam.Connect(pictureBoxLiveVideo.Handle);
            LogMessage(strings.ConnectCamMsg, _cam.Ip,  suc ? strings.Success : strings.Fail);
            

        }

        private void _cam_FaceCaptured(object sender, FaceCapturedEventArgs e)
        {
            BeginInvoke(
                new Action(() =>
                {
                    dataGridViewCaptureResult.Rows.Insert(0,
                        e.SequenceID,
                        e.CaptureTime,
                        e.PersonID, 
                        e.PersonName,
                        e.IsPersonMatched,
                        e.MatchScore, 
                        e.PersonRole
                        );
                })
           );
                
        }

        private void dataGridViewCameraList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                textBoxIp.Text = dataGridViewCameraList.Rows[e.RowIndex].Cells[0].Value as string;
                buttonConnect.PerformClick();
            }
        }

        private void LogMessage(string format, params object[] arguments)
        {
            var msg = DateTime.Now.ToString() + ": " + string.Format(format, arguments);
            listBoxLog.Items.Insert(0, msg);
        }

        private void FormBasic_FormClosing(object sender, FormClosingEventArgs e)
        {
            HaCamera.DeviceDiscovered -= HaCamera_DeviceDiscovered;

            if (_cam != null)
            {
                _cam.FaceCaptured -= _cam_FaceCaptured;
                _cam?.DisConnect();

            }
        }

        private void buttonQueryFace_Click(object sender, EventArgs e)
        {
            using (var form = new FormFaceQuery())
            {
                form.Cam = _cam;
                form.ShowDialog();
            }
        }

        private void buttonAddFace_Click(object sender, EventArgs e)
        {
            using (var form = new FormAddFace())
            {
                form.Cam = _cam;
                form.ShowDialog();
            }
        }

        private void buttonRemoveFace_Click(object sender, EventArgs e)
        {
            using (var form = new FormDeleteFace())
            {
                form.Cam = _cam;
                form.ShowDialog();
            }
        }
    }
}
