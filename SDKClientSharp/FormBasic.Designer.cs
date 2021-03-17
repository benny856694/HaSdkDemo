
namespace SDKClientSharp
{
    partial class FormBasic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonConnect = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxIp = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxSDKPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxLiveVideo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCaptureEvent = new System.Windows.Forms.TabPage();
            this.buttonAddFace = new System.Windows.Forms.Button();
            this.buttonRemoveFace = new System.Windows.Forms.Button();
            this.buttonModifyFace = new System.Windows.Forms.Button();
            this.buttonQueryFace = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonSearchDevice = new System.Windows.Forms.Button();
            this.dataGridViewCameraList = new System.Windows.Forms.DataGridView();
            this.ColumnMac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageCameraSearchResult = new System.Windows.Forms.TabPage();
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLiveVideo)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCameraList)).BeginInit();
            this.tabPageCameraSearchResult.SuspendLayout();
            this.tabPageLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonConnect.Location = new System.Drawing.Point(924, 20);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 25);
            this.buttonConnect.TabIndex = 54;
            this.buttonConnect.Text = "连接";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(183, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(29, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "IP端口：";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(201, 22);
            this.textBoxPort.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(108, 20);
            this.textBoxPort.TabIndex = 52;
            this.textBoxPort.Text = "9527";
            // 
            // textBoxIp
            // 
            this.textBoxIp.Location = new System.Drawing.Point(90, 22);
            this.textBoxIp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIp.Name = "textBoxIp";
            this.textBoxIp.Size = new System.Drawing.Size(85, 20);
            this.textBoxIp.TabIndex = 53;
            this.textBoxIp.Text = "192.168.5.101";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(432, 22);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(89, 20);
            this.textBoxUserName.TabIndex = 58;
            this.textBoxUserName.Text = "admin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(345, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "用户名密码：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(529, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = ":";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(547, 22);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(108, 20);
            this.textBoxPassword.TabIndex = 57;
            this.textBoxPassword.Text = "admin";
            // 
            // textBoxSDKPassword
            // 
            this.textBoxSDKPassword.Location = new System.Drawing.Point(788, 22);
            this.textBoxSDKPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSDKPassword.Name = "textBoxSDKPassword";
            this.textBoxSDKPassword.Size = new System.Drawing.Size(101, 20);
            this.textBoxSDKPassword.TabIndex = 60;
            this.textBoxSDKPassword.Text = "admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(715, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "SDK密码：";
            // 
            // pictureBoxLiveVideo
            // 
            this.pictureBoxLiveVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLiveVideo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBoxLiveVideo.Location = new System.Drawing.Point(3, 16);
            this.pictureBoxLiveVideo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLiveVideo.Name = "pictureBoxLiveVideo";
            this.pictureBoxLiveVideo.Size = new System.Drawing.Size(931, 330);
            this.pictureBoxLiveVideo.TabIndex = 61;
            this.pictureBoxLiveVideo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 61);
            this.panel1.TabIndex = 62;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCaptureEvent);
            this.tabControl1.Controls.Add(this.tabPageCameraSearchResult);
            this.tabControl1.Controls.Add(this.tabPageLog);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(937, 253);
            this.tabControl1.TabIndex = 64;
            // 
            // tabPageCaptureEvent
            // 
            this.tabPageCaptureEvent.Location = new System.Drawing.Point(4, 22);
            this.tabPageCaptureEvent.Name = "tabPageCaptureEvent";
            this.tabPageCaptureEvent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCaptureEvent.Size = new System.Drawing.Size(929, 227);
            this.tabPageCaptureEvent.TabIndex = 0;
            this.tabPageCaptureEvent.Text = "抓拍事件";
            this.tabPageCaptureEvent.UseVisualStyleBackColor = true;
            // 
            // buttonAddFace
            // 
            this.buttonAddFace.Location = new System.Drawing.Point(15, 29);
            this.buttonAddFace.Name = "buttonAddFace";
            this.buttonAddFace.Size = new System.Drawing.Size(75, 23);
            this.buttonAddFace.TabIndex = 0;
            this.buttonAddFace.Text = "添加人脸";
            this.buttonAddFace.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveFace
            // 
            this.buttonRemoveFace.Location = new System.Drawing.Point(112, 29);
            this.buttonRemoveFace.Name = "buttonRemoveFace";
            this.buttonRemoveFace.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveFace.TabIndex = 1;
            this.buttonRemoveFace.Text = "删除人脸";
            this.buttonRemoveFace.UseVisualStyleBackColor = true;
            // 
            // buttonModifyFace
            // 
            this.buttonModifyFace.Location = new System.Drawing.Point(15, 58);
            this.buttonModifyFace.Name = "buttonModifyFace";
            this.buttonModifyFace.Size = new System.Drawing.Size(75, 23);
            this.buttonModifyFace.TabIndex = 2;
            this.buttonModifyFace.Text = "修改人脸";
            this.buttonModifyFace.UseVisualStyleBackColor = true;
            // 
            // buttonQueryFace
            // 
            this.buttonQueryFace.Location = new System.Drawing.Point(112, 58);
            this.buttonQueryFace.Name = "buttonQueryFace";
            this.buttonQueryFace.Size = new System.Drawing.Size(75, 23);
            this.buttonQueryFace.TabIndex = 3;
            this.buttonQueryFace.Text = "查询人脸";
            this.buttonQueryFace.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 61);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1148, 606);
            this.splitContainer1.SplitterDistance = 937;
            this.splitContainer1.TabIndex = 65;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer2.Size = new System.Drawing.Size(937, 606);
            this.splitContainer2.SplitterDistance = 349;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAddFace);
            this.groupBox1.Controls.Add(this.buttonQueryFace);
            this.groupBox1.Controls.Add(this.buttonRemoveFace);
            this.groupBox1.Controls.Add(this.buttonModifyFace);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 606);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "人像管理";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSearchDevice);
            this.groupBox2.Controls.Add(this.textBoxSDKPassword);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxUserName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxPassword);
            this.groupBox2.Controls.Add(this.buttonConnect);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxPort);
            this.groupBox2.Controls.Add(this.textBoxIp);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1148, 61);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "连接相机";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBoxLiveVideo);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(937, 349);
            this.groupBox3.TabIndex = 62;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "实时视频";
            // 
            // buttonSearchDevice
            // 
            this.buttonSearchDevice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSearchDevice.Location = new System.Drawing.Point(1021, 20);
            this.buttonSearchDevice.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearchDevice.Name = "buttonSearchDevice";
            this.buttonSearchDevice.Size = new System.Drawing.Size(75, 25);
            this.buttonSearchDevice.TabIndex = 61;
            this.buttonSearchDevice.Text = "搜索";
            this.buttonSearchDevice.UseVisualStyleBackColor = true;
            this.buttonSearchDevice.Click += new System.EventHandler(this.buttonSearchDevice_Click);
            // 
            // dataGridViewCameraList
            // 
            this.dataGridViewCameraList.AllowUserToAddRows = false;
            this.dataGridViewCameraList.AllowUserToDeleteRows = false;
            this.dataGridViewCameraList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCameraList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIP,
            this.ColumnMac});
            this.dataGridViewCameraList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCameraList.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewCameraList.Name = "dataGridViewCameraList";
            this.dataGridViewCameraList.ReadOnly = true;
            this.dataGridViewCameraList.Size = new System.Drawing.Size(923, 221);
            this.dataGridViewCameraList.TabIndex = 0;
            this.dataGridViewCameraList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCameraList_CellDoubleClick);
            // 
            // ColumnMac
            // 
            this.ColumnMac.HeaderText = "MAC";
            this.ColumnMac.Name = "ColumnMac";
            this.ColumnMac.ReadOnly = true;
            // 
            // ColumnIP
            // 
            this.ColumnIP.HeaderText = "IP";
            this.ColumnIP.Name = "ColumnIP";
            this.ColumnIP.ReadOnly = true;
            // 
            // tabPageCameraSearchResult
            // 
            this.tabPageCameraSearchResult.Controls.Add(this.dataGridViewCameraList);
            this.tabPageCameraSearchResult.Location = new System.Drawing.Point(4, 22);
            this.tabPageCameraSearchResult.Name = "tabPageCameraSearchResult";
            this.tabPageCameraSearchResult.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCameraSearchResult.Size = new System.Drawing.Size(929, 227);
            this.tabPageCameraSearchResult.TabIndex = 1;
            this.tabPageCameraSearchResult.Text = "相机搜索";
            this.tabPageCameraSearchResult.UseVisualStyleBackColor = true;
            // 
            // tabPageLog
            // 
            this.tabPageLog.Controls.Add(this.listBoxLog);
            this.tabPageLog.Location = new System.Drawing.Point(4, 22);
            this.tabPageLog.Name = "tabPageLog";
            this.tabPageLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLog.Size = new System.Drawing.Size(929, 227);
            this.tabPageLog.TabIndex = 2;
            this.tabPageLog.Text = "日志";
            this.tabPageLog.UseVisualStyleBackColor = true;
            // 
            // listBoxLog
            // 
            this.listBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.Location = new System.Drawing.Point(3, 3);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(923, 221);
            this.listBoxLog.TabIndex = 0;
            // 
            // FormBasic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 667);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "FormBasic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "基础演示";
            this.Load += new System.EventHandler(this.FormBasic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLiveVideo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCameraList)).EndInit();
            this.tabPageCameraSearchResult.ResumeLayout(false);
            this.tabPageLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.TextBox textBoxIp;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxSDKPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxLiveVideo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAddFace;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCaptureEvent;
        private System.Windows.Forms.Button buttonRemoveFace;
        private System.Windows.Forms.Button buttonQueryFace;
        private System.Windows.Forms.Button buttonModifyFace;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonSearchDevice;
        private System.Windows.Forms.TabPage tabPageCameraSearchResult;
        private System.Windows.Forms.DataGridView dataGridViewCameraList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMac;
        private System.Windows.Forms.TabPage tabPageLog;
        private System.Windows.Forms.ListBox listBoxLog;
    }
}