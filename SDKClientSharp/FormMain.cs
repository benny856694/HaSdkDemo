using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HaSdkWrapper;
using System.IO;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;

namespace SDKClientSharp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
          

            InitializeComponent();

       

        }

        private void FormMain_Load(object sender, EventArgs e)

        {
            //Console.Write("ss" + System.DateTime.Now.ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds);
            HaCamera.DeviceDiscovered += new EventHandler<DeviceDiscoverdEventArgs>(HaCamera_DeviceDiscovered);
            _cam = new HaCamera();
            _cam.ConnectStateChanged += new EventHandler<ConnectEventArgs>(_cam_ConnectStateChanged);
            _cam.FaceCaptured += new EventHandler<FaceCapturedEventArgs>(_cam_FaceCaptured);
            _cam.AlarmRecordReceived += new EventHandler<AlarmRecordEventArgs>(_cam_AlarmRecordReceived);
            _cam.AlarmRequestReceived += new EventHandler<AlarmRequestEventArgs>(_cam_AlarmRequestReceived);

            _cam.egGpioInput += new EventHandler<WeiGangno>(_cam_egGpioInput);
            _cam.egQRcodeInput += new EventHandler<Qrcode>(_cam_egQRcodeInput);



          

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            combTime_a.SelectedIndex = 0;
            combTime_m.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 1;   
        }
        HaCamera[] _cams = null;
        int camscount = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            //HaCamera.InitEnvironment(uint.Parse(textBox1.Text));
            HaCamera.InitEnvironment();
           
            _cams = new HaCamera[9];
            
            //label2.Text = "SDK版本：" + HaCamera.GetEnvironmentVersion();
            //tabControl1.SelectedIndex = 1;
            //button2.Focus();
        }

        void HaCamera_DeviceDiscovered(object sender, DeviceDiscoverdEventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() =>
                {
                    int rowIdx = dataGridView1.Rows.Add();
                    dataGridView1.Rows[rowIdx].Cells[0].Value = e.IP;
                    dataGridView1.Rows[rowIdx].Cells[1].Value = e.Mac;
                    dataGridView1.Rows[rowIdx].Cells[2].Value = e.NetMask;
                    dataGridView1.Rows[rowIdx].Cells[3].Value = e.Manufacturer;
                    dataGridView1.Rows[rowIdx].Cells[4].Value = e.Plateform;
                    dataGridView1.Rows[rowIdx].Cells[5].Value = e.System;
                    dataGridView1.Rows[rowIdx].Cells[6].Value = e.Version;
                }));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            HaCamera.DiscoverDevice();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string ip = dataGridView1.Rows[e.RowIndex].Cells[0].Value as string;
            textBox11.Text = ip;
            tabControl1.SelectedIndex = 2;
            button21.Focus();
        }


        private HaCamera _cam;
        private void button21_Click(object sender, EventArgs e)
        {
            _cam.Ip = textBox11.Text;
            _cam.Port = int.Parse(textBox12.Text);
            _cam.Username = textBox13.Text;
            _cam.Password = textBox14.Text;
            bool ret = _cam.Connect(pictureBox11.Handle);

           // bool ret = _cam.Connect(default(IntPtr));
            if (ret)
            {
                textBox2.AppendText("连接设备成功！");
                textBox2.AppendText(Environment.NewLine);
                checkBox5.Checked = _cam.RecorderEnable;
                checkBox6.Checked = _cam.RecorderResumeEnable;
            }
            else
            {
                textBox2.AppendText("连接设备失败！" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
                textBox2.AppendText(Environment.NewLine);
            }
        }

        void _cam_egGpioInput(object sender, WeiGangno e)
        {

            if (InvokeRequired)
            {
                BeginInvoke(new Action(() =>
                {
                    label124.Text = e.type + "";
                    label126.Text = e.data + "";

                }));

            }

        }
        void _cam_egQRcodeInput(object sender, Qrcode e)
        {

            if (InvokeRequired)
            {
                BeginInvoke(new Action(() =>
                {
                    label129.Text = e.code;

                }));

            }

        }

      


        void _cam_FaceCaptured(object sender, FaceCapturedEventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() =>
                {
                   

                    textBox2.AppendText("收到人脸抓拍！");
                    textBox2.AppendText(Environment.NewLine);
                    /*if (e.FeatureData != null)
                    {
                        foreach (var f in e.FeatureData)
                        {
                            textBox2.AppendText(f.ToString());
                            textBox2.AppendText(",");
                        }
                        textBox2.AppendText(Environment.NewLine);
                    }*/
                    if (e.FeatureImageData != null)
                    {
                        pictureBox1.Image = Image.FromStream(new MemoryStream(e.FeatureImageData));
                    }
                    label8.Text = "收录时间：" + e.CaptureTime.ToString("g");
                    label9.Text = "陌生人";
                    label10.Text = "";
                    label22.Text = "年龄：";
                    label40.Text = "人像质量：";
                    label127.Text = "伟根:" + e.wgCardNO;
                    label130.Text = "体温" + e.temperature;
                    label133.Text = "口罩" + e.hasMask;
                    if (e.Age == 0)
                        label22.Text += "未知";
                    else
                        label22.Text += e.Age;
                    label22.Text += " 性别：";
                    if (e.Sex == 0)
                        label22.Text += "未知";
                    else if (e.Sex == 1)
                        label22.Text += "男";
                    else if (e.Sex == 2)
                        label22.Text += "女";
                    if (e.QValue == 0)
                    {
                        label40.Text += "未知";
                    }
                    else
                    {
                        label40.Text += e.QValue;
                    }
                    if (e.IsPersonMatched)
                    {
                        label9.Text = e.PersonName;
                        switch (e.PersonRole)
                        {
                            case 0:
                                label9.Text += "[普通人员]";
                                break;
                            case 1:
                                label9.Text += "[白名单]";
                                break;
                            case 2:
                                label9.Text += "[黑名单]";
                                break;
                            default:
                                break;
                        }
                        label10.Text = e.MatchScore.ToString();
                    }
                }));
            }
        }

        void _cam_ConnectStateChanged(object sender, ConnectEventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() =>
                {
                    textBox2.AppendText("连接连接状态改变：" + (e.Connected?"已重连":"已断开"));
                    textBox2.AppendText(Environment.NewLine);
                }));
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            _cam.DisConnect();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*bool ret = _cam.Trigger();
            if (ret)
            {
                textBox2.AppendText("软触发成功！");
                textBox2.AppendText(Environment.NewLine);
            }
            else
            {
                textBox2.AppendText("软触发失败！" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
                textBox2.AppendText(Environment.NewLine);
            }*/
            _cam.StartDrawRecoRect();
        }

        private void textBox5_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                (sender as TextBox).Text = openFileDialog1.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!File.Exists(textBox5.Text)) return;
            bool ret = false;
            uint effectTime = 0;
            uint effectStartTime = 0;
            if (combTime_a.SelectedIndex == 0)
                effectTime = uint.MaxValue;
            else if (combTime_a.SelectedIndex == 1)
                effectTime = 0;
            else
            {
                effectTime = (uint)dateTimePicker1.Value.ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
            }
            effectStartTime = (uint)dateTimePicker10.Value.ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;

            String userParam = "自定义字段";
            //int rets = _cam.HA_FaceJpgLegal(File.ReadAllBytes(textBox5.Text));
            
            //if (textBox5.Text.EndsWith("jpg") || textBox5.Text.EndsWith("JPG"))
            //{
            ret = _cam.AddFace(textBox3.Text, textBox4.Text, comboBox1.SelectedIndex, textBox5.Text, uint.Parse(txtwg_a.Text), effectTime, effectStartTime, (byte)comboBox13.SelectedIndex, userParam);
            //}
            //else
            //{
            //    ret = _cam.AddFace(textBox3.Text, textBox4.Text, comboBox1.SelectedIndex, new Bitmap(Image.FromFile(textBox5.Text)), uint.Parse(txtwg_a.Text), effectTime);
            //}
            if (ret)
            {
                MessageBox.Show("录入成功！");
            }
            else
            {
                MessageBox.Show("录入失败！" + HaCamera.GetErrorDescribe(_cam.GetLastError()) + "," + _cam.GetLastError());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!File.Exists(textBox6.Text)) return;
            bool ret = false;
            uint effectTime = 0;
            uint effectStartTime = 0;
            if (combTime_m.SelectedIndex == 0)
                effectTime = uint.MaxValue;
            else if (combTime_m.SelectedIndex == 1)
                effectTime = 0;
            else
            {
                effectTime = (uint)dateTimePicker2.Value.ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
            }
            effectStartTime = (uint)dateTimePicker11.Value.ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;

            //if (textBox5.Text.EndsWith("jpg") || textBox5.Text.EndsWith("JPG"))
            //{
                ret = _cam.ModifyFace(textBox7.Text, textBox8.Text, comboBox2.SelectedIndex, textBox6.Text, uint.Parse(txtwg_m.Text), effectTime,effectStartTime,(byte)comboBox14.SelectedIndex);
            //}
            //else
            //{
            //    ret = _cam.ModifyFace(textBox7.Text, textBox8.Text, comboBox2.SelectedIndex, new Bitmap(Image.FromFile(textBox6.Text)), uint.Parse(txtwg_m.Text), effectTime);
            //}
            if (ret)
            {
                MessageBox.Show("修改成功!(Update Success!)");
            }
            else
            {
                MessageBox.Show("修改失败！(Update Failed!)" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除特征值吗？", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
            bool ret = _cam.DeleteFace(textBox9.Text);
            if (ret)
            {
                MessageBox.Show("删除成功！");
            }
            else
            {
                MessageBox.Show("删除失败！" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要清空特征值吗？", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
            bool ret = _cam.DeleteAllFace();
            if (ret)
            {
                MessageBox.Show("清空成功！");
            }
            else
            {
                MessageBox.Show("清空失败！" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
            }
        }

        /*private void button8_Click(object sender, EventArgs e)
        {
            int count = _cam.GetFaceCount();
            if (count < 1)
            {
                if (_cam.GetLastError() != NativeConstants.ERR_NONE)
                {
                    MessageBox.Show("获取失败！" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
                    return;
                }
            }
            MessageBox.Show("当前库中共有" + count + "条数据！");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FaceEntity fe = _cam.GetFace(int.Parse(textBox10.Text), false, false);
            if (fe == null)
            {
                MessageBox.Show("获取失败！" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
                return;
            }
            MessageBox.Show("获取成功！人员姓名为：" + fe.PersonName);
        }*/

        private void button10_Click(object sender, EventArgs e)
        {
            int totalCount = 0;
            RecordQueryCondition condition = new RecordQueryCondition();
            condition.ById = checkBox18.Checked;
            condition.PersonId = textBox62.Text;
            condition.ByName = checkBox19.Checked;
            condition.PersonName = textBox63.Text;
            condition.WgNo = checkBox20.Checked;
            if (checkBox20.Checked)
            {
                condition.WgNoc = int.Parse(textBox64.Text);
            }
            condition.ByCaptureTime2 = checkBox21.Checked;
            condition.TimeStart2 = dateTimePicker6.Value;
            condition.TimeEnd2 = dateTimePicker7.Value;
            condition.ByCaptureTime1 = checkBox22.Checked;
            condition.Time1Start = dateTimePicker8.Value;
            condition.Time1End = dateTimePicker9.Value;

            short query_mode=(short)comboBox11.SelectedIndex;


            FaceEntity[] fes = _cam.QueryFaces(int.Parse(textBox15.Text), int.Parse(textBox16.Text), comboBox3.SelectedIndex, checkBox1.Checked, false, ref totalCount, 7000, condition ,query_mode);
            label69.Text = totalCount.ToString();
            if (fes == null)
            {
                if (_cam.GetLastError() != NativeConstants.ERR_NONE)
                {
                    MessageBox.Show("获取失败！" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
                    return;
                }
            }
            if (fes == null || fes.Length == 0)
            {
                MessageBox.Show("没有获取到人员列表！");
                return;
            }
            dataGridView2.Rows.Clear();
            foreach (var fe in fes)
            {
                int rowIdx = dataGridView2.Rows.Add();
                dataGridView2.Rows[rowIdx].Cells[0].Value = fe.PersonID;
                dataGridView2.Rows[rowIdx].Cells[1].Value = fe.PersonName;
                dataGridView2.Rows[rowIdx].Cells[2].Value = comboBox3.Items[fe.PersonRole];
                dataGridView2.Rows[rowIdx].Cells[3].Value = fe.FeatureData == null ? 0 : fe.FeatureData.Length;
                dataGridView2.Rows[rowIdx].Cells[4].Value = fe.WiegandNo;
                if (fe.EffectTime == uint.MaxValue)
                {
                    dataGridView2.Rows[rowIdx].Cells[5].Value = "永久有效";
                }
                else if (fe.EffectTime == 0)
                {
                    dataGridView2.Rows[rowIdx].Cells[5].Value = "永久失效";
                }
                else
                {
                    dataGridView2.Rows[rowIdx].Cells[5].Value = Converter.ConvertToDateTime(fe.EffectTime, 0).ToString("g");
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int count = _cam.GetFaceCount(comboBox3.SelectedIndex);
            if (count < 1)
            {
                if (_cam.GetLastError() != NativeConstants.ERR_NONE)
                {
                    MessageBox.Show("获取失败！" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
                    return;
                }
            }
            MessageBox.Show("当前库中共有" + count + "条["+(comboBox3.SelectedIndex == -1?"所有人员":comboBox3.Items[comboBox3.SelectedIndex])+"]据！");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string ip, mac, netmask, gateway;
            if (_cam.GetNetInfo(out ip, out mac, out netmask, out gateway))
            {
                textBox10.Text = ip;
                textBox17.Text = mac;
                textBox18.Text = netmask;
                textBox19.Text = gateway;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (_cam.SetIp(textBox10.Text, textBox18.Text, textBox19.Text))
            {
                MessageBox.Show("设置IP成功！");
            }
            else MessageBox.Show("设置IP失败！");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (_cam.WhiteListAlarm())
            {
                MessageBox.Show("操作成功，1号IO继电器信号会持续闭合1秒");
            }
            else
            {
                MessageBox.Show("获取失败！" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (_cam.BlackListAlarm())
            {
                MessageBox.Show("操作成功，2号IO继电器信号会持续闭合1秒");
            }
            else
            {
                MessageBox.Show("获取失败！" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string did, aid, aname;
            if (_cam.GetDeviceInfo(out did, out aid, out aname))
            {
                textBox20.Text = did;
                textBox21.Text = aid;
                textBox22.Text = aname;
            }
            else
            {
                MessageBox.Show("获取失败！" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (_cam.SetDeviceInfo(textBox20.Text, textBox21.Text, textBox22.Text))
            {
                MessageBox.Show("设置成功！");
            }
            else
            {
                MessageBox.Show("设置失败！" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
            }
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            var cell = dataGridView1.CurrentCell;
            if (cell == null) return;
            var row = dataGridView1.Rows[cell.RowIndex];
            if (row == null || row.Cells[0].Value == null) return;
            textBox23.Text = row.Cells[1].Value.ToString();
            textBox24.Text = row.Cells[0].Value.ToString();
            textBox25.Text = row.Cells[2].Value.ToString();
            textBox26.Text = textBox24.Text.Substring(0, textBox24.Text.LastIndexOf('.') + 1) + "1";            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox23.Text)) return;
            NativeMethods.HA_SetIpBymac(textBox23.Text, textBox24.Text, textBox25.Text, textBox26.Text);
            MessageBox.Show("设置成功！");
        }

        private DateTime? camTime;
        private void button17_Click(object sender, EventArgs e)
        {
            string time;
            if (_cam.GetTime(out time))
            {
                textBox27.Text = time;
                textBox29.Text = time;
                camTime = DateTime.ParseExact(time, "yyyy/MM/dd HH:mm:ss", CultureInfo.InvariantCulture);
            }
            else
            {
                MessageBox.Show("获取设备时间失败：" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox29.Text))
            {
                if (_cam.SetTime(textBox29.Text))
                {
                    MessageBox.Show("设置设备时间成功！");
                    textBox27.Text = textBox29.Text;
                    camTime = DateTime.ParseExact(textBox29.Text, "yyyy/MM/dd HH:mm:ss", CultureInfo.InvariantCulture);
                }
                else
                {
                    MessageBox.Show("设置设备时间失败：" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (_cam.SetTime(textBox28.Text))
            {
                MessageBox.Show("设置设备时间成功！");
                textBox27.Text = textBox28.Text;
                textBox29.Text = textBox28.Text;
                camTime = DateTime.ParseExact(textBox28.Text, "yyyy/MM/dd HH:mm:ss", CultureInfo.InvariantCulture);
            }
            else
            {
                MessageBox.Show("设置设备时间失败：" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox28.Text = DateTime.Now.ToString("yyyy'/'MM'/'dd HH:mm:ss");
            if (camTime != null)
            {
                camTime = camTime.Value.AddSeconds(1);
                textBox27.Text = camTime.Value.ToString("yyyy'/'MM'/'dd HH:mm:ss");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox30.Text))
            {
                MessageBox.Show("请输入原始用户名");
                return;
            }
            if (string.IsNullOrEmpty(textBox31.Text))
            {
                MessageBox.Show("请输入原始密码");
                return;
            }
            if (_cam.SetAuthInfo(textBox30.Text, textBox31.Text, textBox32.Text, textBox33.Text, checkBox2.Checked))
            {
                MessageBox.Show("设置登陆验证信息成功！");
                if (checkBox2.Checked && (!textBox30.Text.Equals(textBox32.Text) || !textBox31.Text.Equals(textBox33.Text)))
                {
                    MessageBox.Show("检测到您修改了登陆信息，请断开设备并使用新密码重新连接！");
                }
            }
            else
            {
                MessageBox.Show("设置登陆验证信息失败：" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
            }            
        }

        private void button23_Click(object sender, EventArgs e)
        {
            int camMode = _cam.GetCamMode();
            if (camMode == 0)
            {
                MessageBox.Show("获取相机工作模式失败！" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
                return;
            }
            comboBox4.SelectedIndex = camMode - 1;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            bool ret = _cam.SetCamMode(comboBox4.SelectedIndex + 1);
            if (ret)
            {
                MessageBox.Show("设置相机工作模式成功！");
            }
            else
            {
                MessageBox.Show("设置相机工作模式失败！" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
            }
        }

        void _cam_AlarmRequestReceived(object sender, AlarmRequestEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    textBox34.AppendText(string.Format("收到开闸请求 设备编号：{0} 人员编号：{1} 当前通行规则：{2}", e.CameraID, e.PersonID, comboBox5.SelectedItem));
                    textBox34.AppendText(Environment.NewLine);
                    if (comboBox5.SelectedIndex == 1)
                        e.Cancel = true;
                    else if (comboBox5.SelectedIndex == 2)
                    {
                        e.Cancel = MessageBox.Show(string.Format("检测到在库人员通过，是否允许通行？设备编号：{0} 人员编号：{1}", e.CameraID, e.PersonID), "是否放行", MessageBoxButtons.OKCancel) != DialogResult.OK;
                    }
                }));
            }
            else
            {
                textBox34.AppendText(string.Format("收到开闸请求 设备编号：{0} 人员编号：{1} 当前通行规则：{2}", e.CameraID, e.PersonID, comboBox5.SelectedItem));
                textBox34.AppendText(Environment.NewLine);
                if (comboBox5.SelectedIndex == 1)
                    e.Cancel = true;
                else if (comboBox5.SelectedIndex == 2)
                {
                    e.Cancel = MessageBox.Show(string.Format("检测到在库人员通过，是否允许通行？设备编号：{0} 人员编号：{1}", e.CameraID, e.PersonID), "是否放行", MessageBoxButtons.OKCancel) != DialogResult.OK;
                }
            }
        }

        void _cam_AlarmRecordReceived(object sender, AlarmRecordEventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() =>
                {
                    string infoTxt = string.Format("收到设备开闸记录：设备编号 {0} 人员编号 {1} 经过时间 {2} 开闸类型 {3} 卡号（或GPIO端口号） {4}", e.CameraID, e.PersonID, e.AlarmTime, e.AlarmDeviceType, e.AlarmDeviceId);
                    textBox34.AppendText(infoTxt);
                    textBox34.AppendText(Environment.NewLine);
                }));
            }
            else
            {
                string infoTxt = string.Format("收到设备开闸记录：设备编号 {0} 人员编号 {1} 经过时间 {2} 开闸类型 {3} 卡号（或GPIO端口号） {4}", e.CameraID, e.PersonID, e.AlarmTime, e.AlarmDeviceType, e.AlarmDeviceId);
                textBox34.AppendText(infoTxt);
                textBox34.AppendText(Environment.NewLine);
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            
            uint effectTime = 0;
            if (comboBox6.SelectedIndex == 0)
                effectTime = uint.MaxValue;
            else if (comboBox6.SelectedIndex == 1)
                effectTime = 0;
            else
            {
                effectTime = (uint)dateTimePicker3.Value.ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
            }
            if (checkBox3.Checked)
            {
                List<HaCamera> camerasToAdd = new List<HaCamera>();
                string[] ips = new string[]{textBox43.Text,
                textBox44.Text,
                textBox45.Text,
                textBox46.Text,
                textBox47.Text}.Where(s => !string.IsNullOrEmpty(s)).ToArray();
                foreach (string ip in ips)
                {
                    HaCamera cam = new HaCamera();
                    cam.Ip = ip;
                    cam.Username = "admin";
                    cam.Password = "admin";
                    cam.Connect();
                    camerasToAdd.Add(cam);
                }
                int lastErrorCode = 0;
                bool[] rets = HaCamera.AddFace(camerasToAdd.ToArray(), ref lastErrorCode, true, textBox37.Text, textBox38.Text, comboBox7.SelectedIndex, new string[]{
                textBox36.Text,
                textBox39.Text,
                textBox40.Text,
                textBox41.Text,
                textBox42.Text
            }.Where(s => File.Exists(s)).ToArray(), uint.Parse(textBox35.Text), effectTime);
                if (lastErrorCode != 0)
                {
                    MessageBox.Show("添加人脸失败，" + HaCamera.GetErrorDescribe(lastErrorCode));
                }
                else
                {
                    StringBuilder ret_str = new StringBuilder();
                    foreach(bool ret__ in rets)
                    {
                        ret_str.Append(ret__);
                        ret_str.Append(",");
                    }
                    MessageBox.Show("添加人脸成功 [" + ret_str.ToString() + "]");
                }
                foreach(HaCamera cam in camerasToAdd)
                {
                    cam.DisConnect();
                }
                return;
            }
            bool ret = false;
            int[] err_codes = new int[5];
            ret = _cam.AddFaceEx(textBox37.Text, textBox38.Text, comboBox7.SelectedIndex, new string[]{
                textBox36.Text,
                textBox39.Text,
                textBox40.Text,
                textBox41.Text,
                textBox42.Text
            }.Where(s => File.Exists(s)).ToArray(), uint.Parse(textBox35.Text), effectTime, err_codes);
            if (!ret)
            {
                MessageBox.Show("添加人脸失败，" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
            }
            else
            {
                MessageBox.Show("添加人脸成功！");
                for (int i = 0; i < 5; ++i)
                {
                    if (err_codes[i] != 0)
                    {
                        MessageBox.Show("第" + (i+1) + "幅图片下放失败，" + HaCamera.GetErrorDescribe(err_codes[i]));
                    }
                }
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            bool? trans = (sender as Button).Tag as bool?;
            if (trans == null)
            {
                trans = true;
            }
            (sender as Button).Tag = !trans;
            if (_cam.SwitchStreamTrans(!trans.Value))
            {
                if(!trans.Value)
                    MessageBox.Show("连接视频流成功！");
                else
                    MessageBox.Show("断开视频流成功！");
            }
            else
            {
                if (!trans.Value)
                    MessageBox.Show("连接视频流失败，" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
                else
                    MessageBox.Show("断开视频流失败，" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            HaCamera.SetFaceCheckEnable(checkBox4.Checked);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            _cam.RecorderEnable = checkBox5.Checked;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            _cam.RecorderResumeEnable = checkBox5.Checked;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要清空所有抓拍数据吗？", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                bool ret = _cam.DeleteFaceRecord(null);
                if (ret)
                {
                    MessageBox.Show("清空抓拍数据成功！");
                }
                else
                {
                    MessageBox.Show("清空抓拍数据失败！" + HaCamera.GetErrorDescribe(_cam.GetLastError()) + "(" + _cam.GetLastError() + ")");
                }
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            RecordQueryCondition rqc = new RecordQueryCondition();
            rqc.ByCaptureTime = checkBox7.Checked;
            if (rqc.ByCaptureTime)
            {
                rqc.TimeStart = dateTimePicker4.Value;
                rqc.TimeEnd = dateTimePicker5.Value;
            }
            rqc.ByMatchScore = checkBox8.Checked;
            if (rqc.ByMatchScore)
            {
                if (!string.IsNullOrEmpty(textBox50.Text))
                {
                    rqc.MatchScoreStart = int.Parse(textBox50.Text);
                }
                if (!string.IsNullOrEmpty(textBox51.Text))
                {
                    rqc.MatchScoreEnd = int.Parse(textBox51.Text);
                }
            }
            rqc.BySex = checkBox9.Checked;
            if (rqc.BySex)
            {
                rqc.Sex = comboBox8.SelectedIndex + 1;
            }
            rqc.ByAge = checkBox10.Checked;
            if (rqc.ByAge)
            {
                if (!string.IsNullOrEmpty(textBox53.Text))
                {
                    rqc.AgeStart = int.Parse(textBox53.Text);
                }
                if (!string.IsNullOrEmpty(textBox52.Text))
                {
                    rqc.AgeEnd = int.Parse(textBox52.Text);
                }
            }
            rqc.FuzzyMode = checkBox15.Checked;
            rqc.ById = checkBox11.Checked;
            rqc.PersonId = textBox54.Text;
            rqc.ByName = checkBox12.Checked;
            rqc.PersonName = textBox55.Text;
            rqc.ByQValue = checkBox13.Checked;
            if (rqc.ByQValue)
            {
                if (!string.IsNullOrEmpty(textBox56.Text))
                {
                    rqc.QValueStart = int.Parse(textBox56.Text);
                }
                if (!string.IsNullOrEmpty(textBox57.Text))
                {
                    rqc.QValueEnd = int.Parse(textBox57.Text);
                }
            }
            rqc.ByUploadState = checkBox14.Checked;
            if (rqc.ByUploadState)
            {
                rqc.UploadState = comboBox9.SelectedIndex + 1;
            }
            int totalCount = 0;
            RecordDataEntity[] rds = _cam.QueryRecords(int.Parse(textBox49.Text), int.Parse(textBox48.Text), rqc, ref totalCount, 5000);
            label68.Text = totalCount + "";
            if (rds == null)
            {
                if (_cam.GetLastError() != NativeConstants.ERR_NONE)
                {
                    MessageBox.Show("获取失败！" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
                    return;
                }
            }
            if (rds == null || rds.Length == 0)
            {
                MessageBox.Show("没有获取到历史数据列表！");
                return;
            }
            dataGridView3.Rows.Clear();
            foreach (var rd in rds)
            {
                int rowIdx = dataGridView3.Rows.Add();
                dataGridView3.Rows[rowIdx].Cells[0].Value = rd.SequenceID;
                dataGridView3.Rows[rowIdx].Cells[1].Value = rd.CaptureTime.ToString("g");
                dataGridView3.Rows[rowIdx].Cells[2].Value = rd.PersonID;
                dataGridView3.Rows[rowIdx].Cells[3].Value = rd.PersonName;
                dataGridView3.Rows[rowIdx].Cells[4].Value = rd.Age;
                switch (rd.Sex)
                {
                    case 1:
                        dataGridView3.Rows[rowIdx].Cells[5].Value = "男";
                        break;
                    case 2:
                        dataGridView3.Rows[rowIdx].Cells[5].Value = "女";
                        break;
                    default:
                        dataGridView3.Rows[rowIdx].Cells[5].Value = "未知";
                        break;
                }
                dataGridView3.Rows[rowIdx].Cells[6].Value = rd.MatchScore;
                dataGridView3.Rows[rowIdx].Cells[7].Value = rd.PersonRole;
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            string[] ids = _cam.GetAllPersonId();
            if (ids == null)
            {
                MessageBox.Show("查询所有人员编号失败！" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
            }
            else if (ids.Length == 0)
            {
                MessageBox.Show("相机没有注册人员！");
            }
            textBox58.Text = "";
            foreach (string id in ids)
            {
                textBox58.Text += id;
                textBox58.Text += Environment.NewLine;
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
           
                var snapshots = _cam.Snapshot(3000);
                if (snapshots.Item1 == null && snapshots.Item2 == null)
                {
                    MessageBox.Show("从设备截图失败！" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
                    return;
                }

                pictureBox2.Image = snapshots.Item2 ?? snapshots.Item1;

                Console.WriteLine("截图成功");
           
        }

        private void button30_Click(object sender, EventArgs e)
        {
            bool ret = _cam.Reboot();
            if (ret)
            {
                MessageBox.Show("重启设备成功！设备会自动重新连接");
            }
            else
            {
                MessageBox.Show("重启设备失败！" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
            }
        }

        
        private void button31_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                _cam.StartRecoVideo(sfd.FileName);
                FormClosing += new FormClosingEventHandler(StopVideoReco);
            }
        }

        void StopVideoReco(object sender, FormClosingEventArgs e)
        {
            _cam.StopRecoVideo();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            _cam.StopRecoVideo();
            FormClosing -= new FormClosingEventHandler(StopVideoReco);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (_cam.SetSDKPassword(textBox59.Text))
            {
                MessageBox.Show("设置设备二级密码成功！");
            }
            else
            {
                MessageBox.Show("设置设备二级密码失败！" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (HaCamera.SetSDKPazzword(textBox60.Text))
            {
                MessageBox.Show("设置SDK二级密码成功！");
            }
            else
            {
                MessageBox.Show("设置SDK二级密码失败！" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            int matchMode = (int)_cam.GetMatchMode();
            if (matchMode == 0)
            {
                MessageBox.Show("获取相机对比模式失败！" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
                return;
            }
            if (matchMode == 20)
            {
                comboBox10.SelectedIndex = 9;
            }
            else
            {

                comboBox10.SelectedIndex = matchMode;
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            bool ret = _cam.SetMatchMode((MatchMode)(comboBox10.SelectedIndex == 9 ? 20 : comboBox10.SelectedIndex));
            if (ret)
            {
                MessageBox.Show("设置相机对比模式成功！");
            }
            else
            {
                MessageBox.Show("设置相机对比模式失败！" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            string autoCode = _cam.ReadCustomerAuthCode();
            if (autoCode == null)
            {
                MessageBox.Show("读取设备用户校验码失败！" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
                return;
            }
            textBox61.Text = autoCode;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            bool ret = _cam.WriteCustomerAuthCode(textBox61.Text);
            if (ret)
            {
                MessageBox.Show("写入设备用户校验码成功！");
            }
            else
            {
                MessageBox.Show("写入设备用户校验码失败！" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                bool ret = _cam.PlayAudio(File.ReadAllBytes(ofd.FileName));
                if (ret)
                {
                    MessageBox.Show("播放音频成功！");
                }
                else
                {
                    MessageBox.Show("播放音频失败！" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
                }
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            checkBox16.Checked = _cam.GetAliveDetectEnable();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            bool ret = _cam.SetAliveDetectEnable(checkBox16.Checked);
            if (ret)
            {
                MessageBox.Show("设置活体检测开关成功！");
            }
            else
            {
                MessageBox.Show("设置活体检测开关失败！" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            checkBox17.Checked = _cam.GetHatDetectEnable();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            bool ret = _cam.SetHatDetectEnable(checkBox17.Checked);
            if (ret)
            {
                MessageBox.Show("设置安全帽检测开关成功！");
            }
            else
            {
                MessageBox.Show("设置安全帽检测开关失败！" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
           // KindSchedule[] kin = _cam.GetScheduleModeCfg();
            Formsched fr = new Formsched(_cam);
            fr.ShowDialog();
        }

        private void button45_Click(object sender, EventArgs e)
        {

            if (_cam.SetAutoCleanEnable(checkBox23.Checked == true ? 1 : 0))
            {

                MessageBox.Show("设置过期自动清理开关成功！");

            }
            else {

                MessageBox.Show("设置过期自动清理开关失败！");
            
            }

        }

      

        private void button46_Click(object sender, EventArgs e)
        {
            checkBox23.Checked = _cam.GetAutoCleanEnable();
        }

        private void button48_Click(object sender, EventArgs e)
        {
            checkBox24.Checked = _cam.GetProhibitSafetyhat();

        }

        private void button47_Click(object sender, EventArgs e)
        {

            if (_cam.SetProhibitSafetyhat(checkBox24.Checked == true ? 1 : 0))
            {

                MessageBox.Show("设置未带安全帽禁止通行成功！");

            }
            else
            {

                MessageBox.Show("设置未带安全帽禁止通行失败！");

            }

        }

        private void button49_Click(object sender, EventArgs e)
        {
            if (_cam.WhiteListAlarm())
            {
                MessageBox.Show("操作成功");
            }
            else
            {
                MessageBox.Show("操作失败"+_cam.GetLastError());
            }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            byte enable = 0;
            HourSchedule hor = new HourSchedule();
            _cam.GetWDR(ref enable, ref hor);
            comboBox12.SelectedIndex = enable;

            textBox65.Text = hor.start.hour+"";
            textBox66.Text = hor.start.minute+"";

            textBox67.Text = hor.end.hour + "";
            textBox68.Text = hor.end.minute + "";




        }

        private void button51_Click(object sender, EventArgs e)
        {
            HourSchedule hor = new HourSchedule();
            hor.start.hour =Convert.ToByte( textBox65.Text);
            hor.start.minute = Convert.ToByte(textBox66.Text);
            hor.end.hour = Convert.ToByte(textBox67.Text);
            hor.end.minute = Convert.ToByte(textBox68.Text);
            byte enable = (byte)comboBox12.SelectedIndex;
            if (_cam.SetWDR(enable, hor))
            {
                MessageBox.Show("操作成功");
            }
            else {
                MessageBox.Show("操作失败");
            
            }


        }

        private void button52_Click(object sender, EventArgs e)
        {

            if (_cam.SetScreenOsdTitle(textBox69.Text))
            {
                MessageBox.Show("操作成功");
            }
            else
            {
                MessageBox.Show("操作失败");

            }

        }

        private void button53_Click(object sender, EventArgs e)
        {
            if (_cam.TTSPlayAudio(textBox69.Text))
            {
                MessageBox.Show("操作成功");
            }
            else
            {
                MessageBox.Show("操作失败");

            }
        }

        private void button55_Click(object sender, EventArgs e)
        {
            ClientParam client=new ClientParam();
            byte[] domain = new byte[128];
            string domain1 = "";

            if (_cam.GetUploadConfig(ref client))
            {
                _cam.HA_GetUploadDomain( domain);//获取上传域名
                domain1= Encoding.Default.GetString(Converter.ConvertStringToDefault(domain));

                if (client.mode == 0)
                {
                    tabControl2.SelectedTab = tabPage12;


                }
                else if (client.mode == 1)
                {
                    tabControl2.SelectedTab = tabPage13;

                    TcpClientParam1 tcpcl = (TcpClientParam1)HaCamera.BytesToStruct(client.ClientParams, typeof(TcpClientParam1), client.ClientParams.Length);
                    checkBox25.Checked = tcpcl.enable_verify == 0 ? false : true;
                    textBox70.Text = tcpcl.user_name;
                    textBox71.Text = tcpcl.passwd;
                    textBox72.Text = tcpcl.ip == "" ? domain1 : tcpcl.ip;
                    textBox73.Text = tcpcl.port + "";


                }
                else if (client.mode == 2) {
                    tabControl2.SelectedTab = tabPage14;
                    FtpClientParam1 tcpcl = (FtpClientParam1)HaCamera.BytesToStruct(client.ClientParams, typeof(FtpClientParam1), client.ClientParams.Length);

                    textBox74.Text = tcpcl.ip == "" ? domain1 : tcpcl.ip;
                    textBox75.Text = tcpcl.port+"";
                    textBox76.Text = tcpcl.user;
                    textBox77.Text = tcpcl.password;
                    textBox78.Text = tcpcl.pattern;

                }
                else if (client.mode == 3) {
                    tabControl2.SelectedTab = tabPage15;
                    HttpClientParam1 tcpcl = (HttpClientParam1)HaCamera.BytesToStruct(client.ClientParams, typeof(HttpClientParam1), client.ClientParams.Length);
                    checkBox26.Checked = client.enable_heart == 0 ? false : true;
                    textBox79.Text = tcpcl.ip==""?domain1:tcpcl.ip;
                    textBox80.Text = tcpcl.port+"";
                    textBox81.Text = tcpcl.url;



                }
                else if (client.mode == 4) {

                    tabControl2.SelectedTab = tabPage16;
                    HttpClientParam1 tcpcl = (HttpClientParam1)HaCamera.BytesToStruct(client.ClientParams, typeof(HttpClientParam1), client.ClientParams.Length);

                    textBox82.Text = tcpcl.ip == "" ? domain1 : tcpcl.ip;
                    textBox83.Text = tcpcl.port + "";
                    textBox84.Text = tcpcl.url;
                
                
                }





                MessageBox.Show("操作成功");

            }
            else {



                MessageBox.Show("操作失败" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
            }


        }

        private static bool issuz(string text) {
            Regex reg = new Regex("^[0-9]+$");
            Match ma = reg.Match(text);

            if (ma.Success)
            {
                return true;
            }
          
                return false;
          

        }


        private void button54_Click(object sender, EventArgs e)
        {
            ClientParam client=new ClientParam();
            byte[] domain = new byte[1];//设置域名

           

            if (tabControl2.SelectedTab == tabPage12) {
                client.mode = 0;



            }
             
            else if (tabControl2.SelectedTab == tabPage13) {

                

                client.mode = 1;
                TcpClientParam1 tcp = new TcpClientParam1();
                tcp.enable_verify = (byte) (checkBox25.Checked==true?1:0);
                tcp.user_name = textBox70.Text;
                tcp.passwd = textBox71.Text;
                if ("".Equals(textBox72.Text)||issuz(textBox72.Text.Substring(0, 1)))
                {
                    tcp.ip = textBox72.Text;
                }
                else {
                    tcp.ip = "";
                    UTF8Encoding utf8 = new UTF8Encoding();
                   Byte[] encodedBytes = utf8.GetBytes(textBox72.Text);
                   domain = encodedBytes;
                }
                tcp.port =Convert.ToInt32(textBox73.Text);
                client.ClientParams = HaCamera.StructToBytes(tcp, 120);

                ;


            }
            else if (tabControl2.SelectedTab == tabPage14) {
                client.mode = 2;
                FtpClientParam1 ftp = new FtpClientParam1();
               

                if ("".Equals(textBox74.Text) || issuz(textBox74.Text.Substring(0, 1)))
                {
                    ftp.ip = textBox74.Text;
                }
                else
                {
                    ftp.ip = "";
                    UTF8Encoding utf8 = new UTF8Encoding();
                    Byte[] encodedBytes = utf8.GetBytes(textBox74.Text);
                    domain = encodedBytes;
                }

                ftp.port =Convert.ToInt32( textBox75.Text);
                ftp.user = textBox76.Text;
                ftp.password = textBox77.Text;
                ftp.pattern = textBox78.Text;

                client.ClientParams = HaCamera.StructToBytes(ftp, 120);


            }
            else if (tabControl2.SelectedTab == tabPage15) {
                client.mode = 3;
                HttpClientParam1 http = new HttpClientParam1();
                client.enable_heart =(byte) (checkBox26.Checked == true ? 1 : 0);
             
                if ("".Equals(textBox79.Text) || issuz(textBox79.Text.Substring(0, 1)))
                {
                    http.ip = textBox79.Text;
                }
                else
                {
                    http.ip = "";
                    UTF8Encoding utf8 = new UTF8Encoding();
                    Byte[] encodedBytes = utf8.GetBytes(textBox79.Text);
                    domain = encodedBytes;
                }

                http.port =Convert.ToUInt16( textBox80.Text);
                http.url = textBox81.Text;
                client.ClientParams = HaCamera.StructToBytes(http, 120);

            }
            else if (tabControl2.SelectedTab == tabPage16) {
                client.mode = 4;
                HttpClientParam1 http = new HttpClientParam1();
              
               
                if ("".Equals(textBox82.Text) || issuz(textBox82.Text.Substring(0, 1)))
                {
                    http.ip = textBox82.Text;
                }
                else
                {
                    http.ip = "";
                    UTF8Encoding utf8 = new UTF8Encoding();
                    Byte[] encodedBytes = utf8.GetBytes(textBox82.Text);
                    domain = encodedBytes;
                }

                http.port = Convert.ToUInt16(textBox83.Text);
                http.url = textBox84.Text;
                client.ClientParams = HaCamera.StructToBytes(http, 120);
            
            
            }



            if (_cam.SetUploadConfig(ref client))
            {
                MessageBox.Show("操作成功");
            }
            else
            {
                MessageBox.Show("操作失败" + HaCamera.GetErrorDescribe(_cam.GetLastError()));

            }

            //设置域名
            if (_cam.HA_SetUploadDomain(domain))
            {
                MessageBox.Show("设置域名成功");
            }
            else {

                MessageBox.Show("设置域名失败" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
            }


        }

        private void button56_Click(object sender, EventArgs e)
        {
            SystemVersionInfo sy = new SystemVersionInfo();

            if (_cam.HA_GetFaceSystemVersionEx(ref sy))
            {
                MessageBox.Show("操作成功");
                textBox85.Text = System.Text.Encoding.Default.GetString (  sy.dev_id);
            }
            else
            {
                MessageBox.Show("操作失败" + HaCamera.GetErrorDescribe(_cam.GetLastError()));

            }
        }

        private void textBox86_DoubleClick(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                (sender as TextBox).Text = openFileDialog1.FileName;
            }

        }

        private void button57_Click(object sender, EventArgs e)
        {

           MessageBox.Show(_cam.HA_FaceJpgLegal(File.ReadAllBytes(textBox86.Text))+"");

        }

        private void button58_Click(object sender, EventArgs e)
        {
          
                DirectoryInfo root = new DirectoryInfo(textBox87.Text);
                foreach (FileInfo f in root.GetFiles())
                {
                      Console.WriteLine(textBox87.Text+"/" + f.Name);
                    byte[][] tz=  HaCamera.TwistImage (File.ReadAllBytes(textBox87.Text+"/" + f.Name));

                    if (tz != null)
                    {
                        File.WriteAllText(@"" + textBox88.Text + "/" + f.Name.Replace(".jpg","") + "jpg.txt", Encoding.ASCII.GetString(tz[0]));
                        File.WriteAllText(@"" + textBox88.Text + "/" + f.Name.Replace(".jpg", "") + ".txt", Encoding.ASCII.GetString(tz[1]));
                    }
                  
                }
            
        }

        private void textBox87_DoubleClick(object sender, EventArgs e)
        {
            if (folder1.ShowDialog()  ==System.Windows.Forms.DialogResult.OK)
            {
                (sender as TextBox).Text = folder1.SelectedPath;
            }
        }

        private void textBox88_DoubleClick(object sender, EventArgs e)
        {
            if (folder1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                (sender as TextBox).Text = folder1.SelectedPath;
            }
        }

        private void button59_Click(object sender, EventArgs e)
        {

            if (_cam.HA_SetDereplicationEnable(checkBox27.Checked==true?1:0,Convert.ToInt32(textBox89.Text)))
            {
                MessageBox.Show("操作成功");
               
            }
            else
            {
                MessageBox.Show("操作失败" + HaCamera.GetErrorDescribe(_cam.GetLastError()));

            }

        }

        private void button60_Click(object sender, EventArgs e)

        {
            int enable=0;
            int timeout=0;


            if (_cam.HA_GetDereplicationgConfig(ref enable, ref timeout))
            {
                textBox89.Text = timeout+"";

                checkBox27.Checked = enable == 0 ? false : true;


                MessageBox.Show("操作成功");

            }
            else
            {
                MessageBox.Show("操作失败" + HaCamera.GetErrorDescribe(_cam.GetLastError()));

            }
        }

        private void button61_Click(object sender, EventArgs e)
        {
            ExtranetParam extr = new ExtranetParam();
             byte[] domain = new byte[128];
             string domain1 = "";
            if (_cam.HA_GetExtranetParam(ref extr))
            {
                checkBox29.Checked = extr.enable == 0 ? false : true;
                _cam.HA_GetExtranetDomain(domain);//获取上传域名
                 domain1 = Encoding.Default.GetString(Converter.ConvertStringToDefault(domain));
                if (extr.mode == 0) {

                    tabControl3.SelectedTab = tabPage18;

                    TcpClientParam1 tcpcl = (TcpClientParam1)HaCamera.BytesToStruct(extr.ExtranetParams, typeof(TcpClientParam1), extr.ExtranetParams.Length);
                    checkBox28.Checked = tcpcl.enable_verify == 0 ? false : true;
                    textBox93.Text = tcpcl.user_name;
                    textBox92.Text = tcpcl.passwd;
                    textBox91.Text = tcpcl.ip==""?domain1:tcpcl.ip;
                    textBox90.Text = tcpcl.port + "";


                }
                else if (extr.mode == 1)
                {
                    tabControl3.SelectedTab = tabPage19;
                    HttpClientParam1 tcpcl = (HttpClientParam1)HaCamera.BytesToStruct(extr.ExtranetParams, typeof(HttpClientParam1), extr.ExtranetParams.Length);
                   
                    textBox98.Text = tcpcl.ip==""?domain1:tcpcl.ip;
                    textBox97.Text = tcpcl.port + "";
                    textBox94.Text = tcpcl.url;

                }
                else {

                    tabControl3.SelectedTab = tabPage20;
                    HttpClientParam1 tcpcl = (HttpClientParam1)HaCamera.BytesToStruct(extr.ExtranetParams, typeof(HttpClientParam1), extr.ExtranetParams.Length);

                    textBox101.Text = tcpcl.ip==""?domain1:tcpcl.ip;
                    textBox100.Text = tcpcl.port + "";
                    textBox99.Text = tcpcl.url;
                
                }
                MessageBox.Show("操作成功");

            }
            else {

                MessageBox.Show("操作失败" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
            }


        }

        private void button62_Click(object sender, EventArgs e)
        {
            ExtranetParam extr = new ExtranetParam();
            extr.enable = (byte)(checkBox29.Checked == true ? 1 : 0);
            byte[] domain = new byte[1];//设置域名
            if (tabControl3.SelectedTab == tabPage18) {
                extr.mode = 0;
              

                TcpClientParam1 tcp = new TcpClientParam1();
                tcp.enable_verify = (byte)(checkBox28.Checked == true ? 1 : 0);
                tcp.user_name = textBox93.Text;
                tcp.passwd = textBox92.Text;
              
                if ("".Equals(textBox91.Text) || issuz(textBox91.Text.Substring(0, 1)))
                {
                    tcp.ip = textBox91.Text;
                }
                else
                {
                    tcp.ip = "";
                    UTF8Encoding utf8 = new UTF8Encoding();
                    Byte[] encodedBytes = utf8.GetBytes(textBox91.Text);
                    domain = encodedBytes;
                }

                tcp.enable = (byte)(checkBox29.Checked == true ? 1 : 0);
                tcp.port = Convert.ToInt32(textBox90.Text);
                extr.ExtranetParams = HaCamera.StructToBytes(tcp, 120);

            }
            else if (tabControl3.SelectedTab == tabPage19) {
                extr.mode = 1;
                HttpClientParam1 http = new HttpClientParam1();
          
               
                if ("".Equals(textBox98.Text) || issuz(textBox98.Text.Substring(0, 1)))
                {
                    http.ip = textBox98.Text;
                }
                else
                {
                    http.ip = "";
                    UTF8Encoding utf8 = new UTF8Encoding();
                    Byte[] encodedBytes = utf8.GetBytes(textBox98.Text);
                    domain = encodedBytes;
                }

                http.port = Convert.ToUInt16(textBox97.Text);
                http.url = textBox94.Text;
                extr.ExtranetParams = HaCamera.StructToBytes(http, 120);


            }
            else if (tabControl3.SelectedTab == tabPage20)
            {
                extr.mode = 2;
                HttpClientParam1 http = new HttpClientParam1();

             
                if ("".Equals(textBox101.Text) || issuz(textBox101.Text.Substring(0, 1)))
                {
                    http.ip = textBox101.Text;
                }
                else
                {
                    http.ip = "";
                    UTF8Encoding utf8 = new UTF8Encoding();
                    Byte[] encodedBytes = utf8.GetBytes(textBox101.Text);
                    domain = encodedBytes;
                }


                http.port = Convert.ToUInt16(textBox100.Text);
                http.url = textBox99.Text;
                extr.ExtranetParams = HaCamera.StructToBytes(http, 120);

            }


            if (_cam.HA_GetExtranetParam(extr))
            {
                MessageBox.Show("操作成功");
            }
            else {
                MessageBox.Show("操作失败" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
            }


            //设置域名
            if (_cam.HA_SetExtranetDomain(domain))
            {
                MessageBox.Show("设置域名成功");
            }
            else
            {

                MessageBox.Show("设置域名失败" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
            }





        }

        private void button63_Click(object sender, EventArgs e)
        {
            int audio_volume = 0;
            if (_cam.HA_GetAudioVolume(ref audio_volume))
            {
                textBox95.Text = audio_volume+"";
                MessageBox.Show("操作成功");
            }
            else
            {
                MessageBox.Show("操作失败" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
            }


        }

        private void button64_Click(object sender, EventArgs e)
        {
            if (_cam.HA_SetAudioVolume( Convert.ToInt32( textBox95.Text)))
            {
              
                MessageBox.Show("操作成功");
            }
            else
            {
                MessageBox.Show("操作失败" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
            }
        }


        
        private void button65_Click(object sender, EventArgs e)
        {
            if (camscount < 9)
            {
                _cams[camscount] = new HaCamera();
                _cams[camscount].Ip = textBox11.Text;
                _cams[camscount].Port = int.Parse(textBox12.Text);
                _cams[camscount].Username = textBox13.Text;
                _cams[camscount].Password = textBox14.Text;
                //bool ret = _cam.Connect(pictureBox11.Handle);

                bool ret = _cams[camscount].Connect(default(IntPtr));
                if (ret)
                {
                    _cams[camscount].FaceCaptured += new EventHandler<FaceCapturedEventArgs>(_cam_FaceCaptured);
                    textBox2.AppendText("连接设备成功！");
                    textBox2.AppendText(Environment.NewLine);
                    camscount++;

                }
                else
                {
                    textBox2.AppendText("连接设备失败！" + HaCamera.GetErrorDescribe(_cams[camscount].GetLastError()));
                    textBox2.AppendText(Environment.NewLine);
                }
            }
            else {
                textBox2.AppendText("连接设备已经满9个！");
            
            }
          

        }

        private void button66_Click(object sender, EventArgs e)
        {


            int itemNum=0;//相机音频总数

             AudioItem[] audio= _cam.HA_GetAudioList( ref itemNum);//获取内置音频
            if (itemNum>0)
            {
                //随便播放个音频
                if (_cam.HA_TestAudioItemByName(ref audio[0]))
                {
                    MessageBox.Show("播放音频操作成功");

                }
                else {
                    MessageBox.Show("操作失败" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
                }
               


            }
            else {

                MessageBox.Show("操作失败" + (_cam.GetLastError() == 0 ? "相机无音频" : HaCamera.GetErrorDescribe(_cam.GetLastError())));
            }

        }

        private void button67_Click(object sender, EventArgs e)
        {
            int duration = 0;
            if (_cam.HA_GetAlarmDuration(ref duration))
            {
                textBox96.Text = duration+"";
                MessageBox.Show("播放音频操作成功");

            }
            else
            {
                MessageBox.Show("操作失败" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
            }
        }

        private void button68_Click(object sender, EventArgs e)
        {

            if (_cam.HA_SetAlarmDuration(Convert.ToInt32( textBox96.Text)))
            {
              
                MessageBox.Show("播放音频操作成功");

            }
            else
            {
                MessageBox.Show("操作失败" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
            }
        }

        private void button69_Click(object sender, EventArgs e)
        {
            int item = 0;
            if (_cam.HA_GetLcdDisplayItems(ref item))
            {


                checkBox32.Checked = (item & (int)LcdDisplayItem.LCD_DISPLAY_ITEM_IP) == (int)LcdDisplayItem.LCD_DISPLAY_ITEM_IP;

                checkBox30.Checked = (item & (int)LcdDisplayItem.LCD_DISPLAY_ITEM_TITILE) == (int)LcdDisplayItem.LCD_DISPLAY_ITEM_TITILE;
                checkBox31.Checked = (item & (int)LcdDisplayItem.LCD_DISPLAY_ITEM_TIME) == (int)LcdDisplayItem.LCD_DISPLAY_ITEM_TIME;
                checkBox33.Checked = (item & (int)LcdDisplayItem.LCD_DISPLAY_ITEM_PERSON_NUM) == (int)LcdDisplayItem.LCD_DISPLAY_ITEM_PERSON_NUM;




            }
            else {

                MessageBox.Show("获取显示项失败" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
            }

            int Options = 0;
            if (_cam.HA_GetPersonDisplayOptions(ref Options))
            {

                checkBox34.Checked = (Options & (int)LcdPersonDisplayItem.LCD_PERSON_DISPLAY_ITEM_PERSON_NAME) == (int)LcdPersonDisplayItem.LCD_PERSON_DISPLAY_ITEM_PERSON_NAME;

                checkBox35.Checked = (Options & (int)LcdPersonDisplayItem.LCD_PERSON_DISPLAY_ITEM_PERSON_IMAGE) == (int)LcdPersonDisplayItem.LCD_PERSON_DISPLAY_ITEM_PERSON_IMAGE;

                checkBox36.Checked = (Options & (int)LcdPersonDisplayItem.LCD_PERSON_DISPLAY_ITEM_PERSON_MATCH_TIME) == (int)LcdPersonDisplayItem.LCD_PERSON_DISPLAY_ITEM_PERSON_MATCH_TIME;
                checkBox37.Checked = (Options & (int)LcdPersonDisplayItem.LCD_PERSON_DISPLAY_ITEM_PERSON_TEXT) == (int)LcdPersonDisplayItem.LCD_PERSON_DISPLAY_ITEM_PERSON_TEXT;



            }
            else {

                MessageBox.Show("获取比对显示项失败" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
            }

            byte enable = 0;
            if (_cam.HA_GetflipEnable(ref enable))
            {
                checkBox38.Checked = enable == 0 ? false : true;

            }
            else {
                MessageBox.Show("获取lcd镜像失败" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
            }


            byte led_level = 0;
            if (_cam.HA_GetLedLevel(ref led_level)) {


                textBox102.Text = led_level+"";

            }
            else
            {
                MessageBox.Show("获取屏显亮度失败失败" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
            }





        }

        private void button70_Click(object sender, EventArgs e)
        {
            ///设置显示项部分
            int item = 0;

            if (checkBox30.Checked) {
                item |= (int)LcdDisplayItem.LCD_DISPLAY_ITEM_TITILE;
            
            }

            if (checkBox31.Checked) {
                item |=(int) LcdDisplayItem.LCD_DISPLAY_ITEM_TIME;
            }
            if (checkBox32.Checked) {
                item |=(int) LcdDisplayItem.LCD_DISPLAY_ITEM_IP;
            }

            if (checkBox33.Checked) {
                item |=(int) LcdDisplayItem.LCD_DISPLAY_ITEM_PERSON_NUM;
            }


            if (_cam.HA_SetLcdDisplayItems(item))
            {
                MessageBox.Show("设置显示项成功");
            }
            else {
                MessageBox.Show("设置显示项失败" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
            }

            ///设置对比显示项部分

            int Options = 0;
            if (checkBox34.Checked) {
                Options |= (int)LcdPersonDisplayItem.LCD_PERSON_DISPLAY_ITEM_PERSON_NAME;
            }

            if (checkBox35.Checked)
            {
                Options |= (int)LcdPersonDisplayItem.LCD_PERSON_DISPLAY_ITEM_PERSON_IMAGE;
            }

            if (checkBox36.Checked)
            {
                Options |= (int)LcdPersonDisplayItem.LCD_PERSON_DISPLAY_ITEM_PERSON_MATCH_TIME;
            }

            if (checkBox37.Checked)
            {
                Options |= (int)LcdPersonDisplayItem.LCD_PERSON_DISPLAY_ITEM_PERSON_TEXT;
            }

            if (_cam.HA_SetPersonDisplayOptions(Options))
            {
                MessageBox.Show("设置对比显示项成功");
            }
            else
            {
                MessageBox.Show("设置对比显示项失败" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
            }

            ///设置lcd镜像部分
           
            if (_cam.HA_SetflipEnable((byte)(checkBox38.Checked == true ? 1 : 0))) {
                MessageBox.Show("设置lcd镜像成功");

            }
            else
            {
                MessageBox.Show("设置lcd镜像失败" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
            }

            ///屏幕亮度部分

            if (_cam.HA_SetLedLevel(Convert.ToByte(textBox102.Text)))
            {

                MessageBox.Show("设置屏幕亮度成功");
            }
            else {

                MessageBox.Show("设置屏幕亮度失败" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
            
            }


        }

        private void label126_Click(object sender, EventArgs e)
        {

        }

        private void button71_Click(object sender, EventArgs e)
        {
            int enable = 0;
            if (_cam.HA_GetTemperaturEnable(ref enable))
            {
                checkBox39.Checked = enable == 0 ? false : true;

                MessageBox.Show("获取成功");
            }
            else
            {

                MessageBox.Show("获取失败" + HaCamera.GetErrorDescribe(_cam.GetLastError()));

            }


        }

        private void button72_Click(object sender, EventArgs e)
        {
            if (_cam.HA_SetTemperaturEnable(checkBox39.Checked==true?1:0))
            {
                

                MessageBox.Show("设置成功");
            }
            else
            {

                MessageBox.Show("设置失败" + HaCamera.GetErrorDescribe(_cam.GetLastError()));

            }

        }

        private void button73_Click(object sender, EventArgs e)
        {
            float temperatur = 0;
            int enable = 0;

            if (_cam.HA_GetTemperaturLimit(ref temperatur, ref enable))
            {
                checkBox40.Checked = enable == 0 ? false : true;
                textBox103.Text = temperatur+"";
                MessageBox.Show("获取成功");
            }
            else
            {

                MessageBox.Show("获取失败" + HaCamera.GetErrorDescribe(_cam.GetLastError()));

            }


        }

        private void button74_Click(object sender, EventArgs e)
        {
            if (_cam.HA_SetTemperaturLimit(Convert.ToSingle(textBox103.Text), checkBox39.Checked == true ? 1 : 0))
            {
             
                MessageBox.Show("设置成功");
            }
            else
            {

                MessageBox.Show("设置失败" + HaCamera.GetErrorDescribe(_cam.GetLastError()));

            }
        }

        private void button75_Click(object sender, EventArgs e)
        {
            String cmd="request date time";
            String json = "{\"version\": \"0.15\",\"cmd\":\"request date time\", \"cammand_id\":\"dummy\"}";
            String rejson = "";

            if (_cam.HA_SendJson(cmd,json,ref rejson))
            {

                MessageBox.Show("发送成功"+rejson);
            }
            else
            {

                MessageBox.Show("设置失败" + HaCamera.GetErrorDescribe(_cam.GetLastError()));

            }

        }

        private void button76_Click(object sender, EventArgs e)
        {
            int enable = 0;

            if (_cam.HA_GetMaskInspectEnable(ref enable))
            {

                checkBox41.Checked = enable == 1 ? true : false;
                MessageBox.Show("获取成功");
            }
            else {

                MessageBox.Show("获取失败" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
            
            }



        }

        private void button77_Click(object sender, EventArgs e)
        {

            if (_cam.HA_SetMaskInspectEnable(checkBox41.Checked==true?1:0))
            {

               
                MessageBox.Show("设置成功");
            }
            else
            {

                MessageBox.Show("设置失败" + HaCamera.GetErrorDescribe(_cam.GetLastError()));

            }


        }

        private void button78_Click(object sender, EventArgs e)
        {

            byte enable = 0;

            if (_cam.HA_GetGpioWorkState(ref enable))
            {

                checkBox42.Checked = enable == 1 ? true : false;
                MessageBox.Show("获取成功");
            }
            else
            {

                MessageBox.Show("获取失败" + HaCamera.GetErrorDescribe(_cam.GetLastError()));

            }


        }

        private void button79_Click(object sender, EventArgs e)
        {

            if (_cam.HA_SetGpioWorkState((byte)(checkBox42.Checked == true ? 1 : 0)))
            {


                MessageBox.Show("设置成功");
            }
            else
            {

                MessageBox.Show("设置失败" + HaCamera.GetErrorDescribe(_cam.GetLastError()));

            }
        }

        private void button80_Click(object sender, EventArgs e)
        {

            byte filter_not_match = 0;

            if (_cam.HA_GetFaceSystemCfgmatch(ref filter_not_match))
            {

                checkBox43.Checked = filter_not_match != 0 ? true : false;
                MessageBox.Show("获取成功");
            }
            else
            {

                MessageBox.Show("获取失败" + HaCamera.GetErrorDescribe(_cam.GetLastError()));

            }

        }

        private void button81_Click(object sender, EventArgs e)
        {

            if (_cam.HA_SetFaceSystemCfgmatch((byte)(checkBox43.Checked == true ? 1 : 0)))
            {


                MessageBox.Show("设置成功");
            }
            else
            {

                MessageBox.Show("设置失败" + HaCamera.GetErrorDescribe(_cam.GetLastError()));

            }


        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button82_Click(object sender, EventArgs e)
        {
            byte gpio_enable_white = 0;

            if (_cam.HA_Getgpio_enable_white(ref gpio_enable_white))
            {

                checkBox44.Checked = gpio_enable_white != 0 ? true : false;
                MessageBox.Show("获取成功");
            }
            else
            {

                MessageBox.Show("获取失败" + HaCamera.GetErrorDescribe(_cam.GetLastError()));

            }


        }

        private void button83_Click(object sender, EventArgs e)
        {

            if (_cam.HA_Setgpio_enable_white((byte)(checkBox44.Checked == true ? 1 : 0)))
            {


                MessageBox.Show("设置成功");
            }
            else
            {

                MessageBox.Show("设置失败" + HaCamera.GetErrorDescribe(_cam.GetLastError()));

            }

        }

        private void button84_Click(object sender, EventArgs e)
        {

            if (_cam.HA_SetFaceCheckRotate(1))
            {


                MessageBox.Show("设置成功");
            }
            else
            {

                MessageBox.Show("设置失败" + HaCamera.GetErrorDescribe(_cam.GetLastError()));

            }
        }

        private void button85_Click(object sender, EventArgs e)
        {
            HaSdkVersion version = new HaSdkVersion();

            if (_cam.HA_GetVersion(ref version))
            {


                MessageBox.Show("获取成功");
            }
            else
            {

                MessageBox.Show("获取失败" + HaCamera.GetErrorDescribe(_cam.GetLastError()));

            }

        }

        private void textBox104_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                (sender as TextBox).Text = openFileDialog1.FileName;
            }


        }

        private void button86_Click(object sender, EventArgs e)
        {
            //版本传HV10或以上是提取新归一化，反之旧版本归一化
            //re[0]是微缩图 re[1]是归一化
            byte[][]  re= HaCamera.HA_GetJpgFeatureImageNew(File.ReadAllBytes(textBox104.Text),"HV10");

            if (re[2][0]!= 0)
            {
                MessageBox.Show("提取失败" + re[2][0]);
            
            }
            else {


                MessageBox.Show("提取成功");
            }


        }

        private void button87_Click(object sender, EventArgs e)
        {
            KindSchedule[] kind = new KindSchedule[17];
            int k = 0;
            for (int i = 0; i < kind.Length; i++)
            {
               
                    kind[k].ScheduleNameCode = Convert.ToUInt16(i+1);
                    byte[] idStrBytes = Encoding.UTF8.GetBytes("name_"+i+1);
                    byte[] name = new byte[16];
                    Array.Copy(idStrBytes, name, Math.Min(idStrBytes.Length, 20));

                    kind[k].ScheduleName = name;

                    if (true)
                    {
                        kind[k].Mode = ScheduleMode.SCHEDULE_MODE_DAILY;

                    }
                    else
                    {
                        kind[k].Mode = ScheduleMode.SCHEDULE_MODE_WEEKLY;

                    }
                    DailySchedule[] dail = new DailySchedule[7];
                    for (int j = 0; j < 7; j++)
                    {

                        int Sector = 0;
                        HourSchedule[] ho = new HourSchedule[6];
                        for (int y = 0; y < 6; y++)
                        {
                            if (true)
                            {

                                MinuteSchedule start = new MinuteSchedule();

                                start.hour = Convert.ToByte(4);
                                start.minute = Convert.ToByte(4);
                                ho[y].start.hour = start.hour;
                                ho[y].start.minute = start.minute;

                                start.hour = Convert.ToByte(5);
                                start.minute = Convert.ToByte(5);
                                ho[y].end.hour = start.hour;
                                ho[y].end.minute = start.minute;

                                Sector++;
                                dail[j].Sector = Convert.ToUInt32(Sector);

                                dail[j].SchTime = ho;
                                kind[k].Schedule = dail;
                            }
                            

                        }






                        if (kind[k].Mode == ScheduleMode.SCHEDULE_MODE_DAILY)
                        {
                            break;
                        }



                    




                  



                }

                    k++;






            }



            if (_cam.SetScheduleModeCfg(kind))
            {
                MessageBox.Show("设置成功");
            }
            else {

                MessageBox.Show("设置失败" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
            }


        }

        private void button88_Click(object sender, EventArgs e)
        {

            bool ret = false;
            uint effectTime = 0;
            uint effectStartTime = 0;
            if (combTime_a.SelectedIndex == 0)
                effectTime = uint.MaxValue;
            else if (combTime_a.SelectedIndex == 1)
                effectTime = 0;
            else
            {
                effectTime = (uint)dateTimePicker1.Value.ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
            }
            effectStartTime = (uint)dateTimePicker10.Value.ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;

            String userParam = "自定义字段";
            //int rets = _cam.HA_FaceJpgLegal(File.ReadAllBytes(textBox5.Text));



            //if (textBox5.Text.EndsWith("jpg") || textBox5.Text.EndsWith("JPG"))
            //{
            ret = _cam.HA_AddFaceFlags(textBox3.Text, textBox4.Text, comboBox1.SelectedIndex, uint.Parse(txtwg_a.Text), effectTime, effectStartTime, (byte)comboBox13.SelectedIndex, userParam, (byte)1);
            //}
            //else
            //{
            //    ret = _cam.AddFace(textBox3.Text, textBox4.Text, comboBox1.SelectedIndex, new Bitmap(Image.FromFile(textBox5.Text)), uint.Parse(txtwg_a.Text), effectTime);
            //}
            if (ret)
            {
                MessageBox.Show("录入成功！");
            }
            else
            {
                MessageBox.Show("录入失败！" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
            }
        }

        private void button89_Click(object sender, EventArgs e)
        {
            //注意这里是与运算  更新姓名。 0x1, 更新角色。  0x1 << 1, 更新韦根卡号。  0x1 << 2, 更新有效截止时间。 0x1 << 3,更新有效起始时间。 0x1 << 4,更新调度模式。 0x1 << 5, 更新用户自定义字段。  0x1 << 6,
            //我这里的写法就是更新上面所有,需要更新几个字段就用 | 与运算符连接
            uint update_flags = 0x1 | (0x1 << 1) | (0x1 << 2) | (0x1 << 3) | (0x1 << 4) | (0x1 << 5) | (0x1 << 6);
            //例如只修改名字
            //update_flags = 0x1;


            bool ret = false;
            uint effectTime = 0;
            uint effectStartTime = 0;
            if (combTime_m.SelectedIndex == 0)
                effectTime = uint.MaxValue;
            else if (combTime_m.SelectedIndex == 1)
                effectTime = 0;
            else
            {
                effectTime = (uint)dateTimePicker2.Value.ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
            }
            effectStartTime = (uint)dateTimePicker11.Value.ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
            String userParam = "自定义字段";

            ret = _cam.HA_updateFaceFlags(textBox7.Text, textBox8.Text, comboBox2.SelectedIndex, uint.Parse(txtwg_m.Text), effectTime, effectStartTime, (byte)comboBox13.SelectedIndex, userParam, update_flags);
            if (ret)
            {
                MessageBox.Show("修改成功！");
            }
            else
            {
                MessageBox.Show("修改失败！" + HaCamera.GetErrorDescribe(_cam.GetLastError()));
            }
        }


      
       
    }
}
