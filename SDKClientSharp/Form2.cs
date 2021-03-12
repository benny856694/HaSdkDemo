using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HaSdkWrapper;

namespace SDKClientSharp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            HaCamera.InitEnvironment();
        }

        private HaCamera _cam0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (_cam0 == null)
            {
                _cam0 = new HaCamera();
                _cam0.Ip = textBox1.Text;
                _cam0.Connect(pictureBox1.Handle);
                _cam0.FaceCaptured += new EventHandler<FaceCapturedEventArgs>(_cam0_FaceCaptured);
                _cam0.ConnectStateChanged += new EventHandler<ConnectEventArgs>(_cam0_ConnectStateChanged);
            }
        }

        void _cam0_ConnectStateChanged(object sender, ConnectEventArgs e)
        {
            //Console.WriteLine(e.Connected);
        }

        void _cam0_FaceCaptured(object sender, FaceCapturedEventArgs e)
        {
            //Console.WriteLine(e.CaptureTime);
        }

        private HaCamera _cam1;
        private void button2_Click(object sender, EventArgs e)
        {
            if (_cam1 == null)
            {
                _cam1 = new HaCamera();
                _cam1.Ip = textBox2.Text;
                _cam1.Connect(pictureBox2.Handle);
                _cam1.FaceCaptured += new EventHandler<FaceCapturedEventArgs>(_cam1_FaceCaptured);
                _cam1.ConnectStateChanged += new EventHandler<ConnectEventArgs>(_cam1_ConnectStateChanged);
            }
        }

        void _cam1_ConnectStateChanged(object sender, ConnectEventArgs e)
        {
            Console.WriteLine(e.Connected);
        }

        void _cam1_FaceCaptured(object sender, FaceCapturedEventArgs e)
        {
            Console.WriteLine(e.CaptureTime);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_cam0 != null)
            {
                _cam0.DisConnect();
                _cam0 = null;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_cam1 != null)
            {
                _cam1.DisConnect();
                _cam1 = null;
            }
        }

        private ConfigTemplate configTemplate;

        private void button7_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                configTemplate = new ConfigTemplate(openFileDialog1.FileName);
                textBox3.Text = configTemplate.DeviceNo;
                textBox4.Text = configTemplate.AddrID;
                textBox5.Text = configTemplate.AddrName;
            }
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            configTemplate = new ConfigTemplate(_cam0);
            textBox3.Text = configTemplate.DeviceNo;
            textBox4.Text = configTemplate.AddrID;
            textBox5.Text = configTemplate.AddrName;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            configTemplate = new ConfigTemplate(_cam1);
            textBox3.Text = configTemplate.DeviceNo;
            textBox4.Text = configTemplate.AddrID;
            textBox5.Text = configTemplate.AddrName;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(configTemplate != null && saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                configTemplate.SaveToFile(saveFileDialog1.FileName);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(configTemplate != null)
            {
                configTemplate.UpdateToCamera(_cam0);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (configTemplate != null)
            {
                configTemplate.UpdateToCamera(_cam1);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (configTemplate != null)
                configTemplate.DeviceNo = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (configTemplate != null)
                configTemplate.AddrID = textBox4.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (configTemplate != null)
                configTemplate.AddrName = textBox5.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (_cam0 == null)
            {
                _cam0 = new HaCamera();
                _cam0.Ip = textBox1.Text;
                _cam0.Connect(pictureBox1.Handle);
                _cam0.FaceCaptured += new EventHandler<FaceCapturedEventArgs>(_cam0_FaceCaptured);
                _cam0.ConnectStateChanged += new EventHandler<ConnectEventArgs>(_cam0_ConnectStateChanged);
                _cam0.SwitchStreamTrans(false);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (_cam1 == null)
            {
                _cam1 = new HaCamera();
                _cam1.Ip = textBox2.Text;
                _cam1.Connect(pictureBox2.Handle);
                _cam1.FaceCaptured += new EventHandler<FaceCapturedEventArgs>(_cam1_FaceCaptured);
                _cam1.ConnectStateChanged += new EventHandler<ConnectEventArgs>(_cam1_ConnectStateChanged);
                _cam1.SwitchStreamTrans(false);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (_cam0 != null)
                _cam0.Reboot();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (_cam1 != null)
                _cam1.Reboot();
        }
    }
}
