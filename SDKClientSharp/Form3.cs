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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private HaCamera _cam1 = new HaCamera();
        private void button1_Click(object sender, EventArgs e)
        {
            _cam1.Ip = textBox1.Text;
            MessageBox.Show(_cam1.Connect().ToString());
        }

        private HaCamera _cam2 = new HaCamera();
        private void button2_Click(object sender, EventArgs e)
        {
            _cam2.Ip = textBox2.Text;
            MessageBox.Show(_cam2.Connect().ToString());
        }

        private HaCamera _cam3 = new HaCamera();
        private void button3_Click(object sender, EventArgs e)
        {
            _cam3.Ip = textBox3.Text;
            MessageBox.Show(_cam3.Connect().ToString());
        }

        private HaCamera _cam4 = new HaCamera();
        private void button4_Click(object sender, EventArgs e)
        {
            _cam4.Ip = textBox4.Text;
            MessageBox.Show(_cam4.Connect().ToString());
        }

        private HaCamera _cam5 = new HaCamera();
        private void button5_Click(object sender, EventArgs e)
        {
            _cam5.Ip = textBox5.Text;
            MessageBox.Show(_cam5.Connect().ToString());
        }

        private HaCamera _cam6 = new HaCamera();
        private void button6_Click(object sender, EventArgs e)
        {
            _cam6.Ip = textBox6.Text;
            MessageBox.Show(_cam6.Connect().ToString());
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            HaCamera.InitEnvironment();
            _cam1.ConnectStateChanged += new EventHandler<ConnectEventArgs>(_cam_ConnectStateChanged);
            _cam2.ConnectStateChanged += new EventHandler<ConnectEventArgs>(_cam_ConnectStateChanged);
            _cam3.ConnectStateChanged += new EventHandler<ConnectEventArgs>(_cam_ConnectStateChanged);
            _cam4.ConnectStateChanged += new EventHandler<ConnectEventArgs>(_cam_ConnectStateChanged);
            _cam5.ConnectStateChanged += new EventHandler<ConnectEventArgs>(_cam_ConnectStateChanged);
            _cam6.ConnectStateChanged += new EventHandler<ConnectEventArgs>(_cam_ConnectStateChanged);
        }

        void _cam_ConnectStateChanged(object sender, ConnectEventArgs e)
        {
            Console.WriteLine((sender as HaCamera).Ip + "=>" + e.Connected);
        }

        private bool cam1Play = false;
        private void button7_Click(object sender, EventArgs e)
        {
            if (!cam1Play)
                _cam1.StartPlay(pictureBox1.Handle);
            else
                _cam1.StopPlay();
            cam1Play = !cam1Play;
        }

        private bool cam2Play = false;
        private void button8_Click(object sender, EventArgs e)
        {
            if (!cam2Play)
                _cam2.StartPlay(pictureBox2.Handle);
            else
                _cam2.StopPlay();
            cam2Play = !cam2Play;
        }

        private bool cam3Play = false;
        private void button9_Click(object sender, EventArgs e)
        {
            if (!cam3Play)
                _cam3.StartPlay(pictureBox3.Handle);
            else
                _cam3.StopPlay();
            cam3Play = !cam3Play;
        }

        private bool cam4Play = false;
        private void button10_Click(object sender, EventArgs e)
        {
            if (!cam4Play)
                _cam4.StartPlay(pictureBox4.Handle);
            else
                _cam4.StopPlay();
        }

        private bool cam5Play = false;
        private void button11_Click(object sender, EventArgs e)
        {
            if (!cam5Play)
                _cam5.StartPlay(pictureBox5.Handle);
            else
                _cam5.StopPlay();
        }

        private bool cam6Play = false;
        private void button12_Click(object sender, EventArgs e)
        {
            if (!cam6Play)
                _cam6.StartPlay(pictureBox6.Handle);
            else
                _cam6.StopPlay();
        }
    }
}
