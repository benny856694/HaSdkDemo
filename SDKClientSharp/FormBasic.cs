﻿using HaSdkWrapper;
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
            HaSdkWrapper.HaCamera.DeviceDiscovered += HaCamera_DeviceDiscovered;
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
            var suc = _cam.Connect(pictureBoxLiveVideo.Handle);
            LogMessage("connect to camera {0}",  suc ? "success" : "fail");
            

        }

        private void dataGridViewCameraList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                textBoxIp.Text = dataGridViewCameraList.Rows[e.RowIndex].Cells[0].Value as string;
            }
        }

        private void LogMessage(string format, params object[] arguments)
        {
            var msg = DateTime.Now.ToString() + ": " + string.Format(format, arguments);
            listBoxLog.Items.Insert(0, msg);
        }
    }
}
