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
    public partial class FormDeleteFace : Form
    {
        public HaCamera Cam { get; set; }
        public FormDeleteFace()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var res = Cam.DeleteFace(textBoxFaceId.Text);
            if (res) textBoxFaceId.Clear();

            int errorCode = 0;
            string errorMsg = null;
            if (!res)
            {
                errorCode = Cam.GetLastError();
                errorMsg = HaCamera.GetErrorDescribe(errorCode);
            }

            Utils.ShowMsg(strings.DeleteFaceAction, res, errorCode, errorMsg);
           
        }
    }
}
