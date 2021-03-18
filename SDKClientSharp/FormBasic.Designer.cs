
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBasic));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBoxLiveVideo = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCaptureEvent = new System.Windows.Forms.TabPage();
            this.dataGridViewCaptureResult = new System.Windows.Forms.DataGridView();
            this.ColumnSeqNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCapTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageCameraSearchResult = new System.Windows.Forms.TabPage();
            this.dataGridViewCameraList = new System.Windows.Forms.DataGridView();
            this.ColumnIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAddFace = new System.Windows.Forms.Button();
            this.buttonQueryFace = new System.Windows.Forms.Button();
            this.buttonRemoveFace = new System.Windows.Forms.Button();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSearchDevice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLiveVideo)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageCaptureEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCaptureResult)).BeginInit();
            this.tabPageCameraSearchResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCameraList)).BeginInit();
            this.tabPageLog.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            resources.ApplyResources(this.splitContainer1.Panel1, "splitContainer1.Panel1");
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(this.splitContainer1.Panel2, "splitContainer1.Panel2");
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            // 
            // splitContainer2
            // 
            resources.ApplyResources(this.splitContainer2, "splitContainer2");
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            resources.ApplyResources(this.splitContainer2.Panel1, "splitContainer2.Panel1");
            this.splitContainer2.Panel1.Controls.Add(this.groupBox3);
            // 
            // splitContainer2.Panel2
            // 
            resources.ApplyResources(this.splitContainer2.Panel2, "splitContainer2.Panel2");
            this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.pictureBoxLiveVideo);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // pictureBoxLiveVideo
            // 
            resources.ApplyResources(this.pictureBoxLiveVideo, "pictureBoxLiveVideo");
            this.pictureBoxLiveVideo.Name = "pictureBoxLiveVideo";
            this.pictureBoxLiveVideo.TabStop = false;
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPageCaptureEvent);
            this.tabControl1.Controls.Add(this.tabPageCameraSearchResult);
            this.tabControl1.Controls.Add(this.tabPageLog);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPageCaptureEvent
            // 
            resources.ApplyResources(this.tabPageCaptureEvent, "tabPageCaptureEvent");
            this.tabPageCaptureEvent.Controls.Add(this.dataGridViewCaptureResult);
            this.tabPageCaptureEvent.Name = "tabPageCaptureEvent";
            this.tabPageCaptureEvent.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCaptureResult
            // 
            resources.ApplyResources(this.dataGridViewCaptureResult, "dataGridViewCaptureResult");
            this.dataGridViewCaptureResult.AllowUserToAddRows = false;
            this.dataGridViewCaptureResult.AllowUserToDeleteRows = false;
            this.dataGridViewCaptureResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCaptureResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCaptureResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSeqNo,
            this.ColumnCapTime,
            this.ColumnId,
            this.ColumnName,
            this.ColumnMatch,
            this.ColumnScore,
            this.ColumnType});
            this.dataGridViewCaptureResult.Name = "dataGridViewCaptureResult";
            this.dataGridViewCaptureResult.ReadOnly = true;
            // 
            // ColumnSeqNo
            // 
            resources.ApplyResources(this.ColumnSeqNo, "ColumnSeqNo");
            this.ColumnSeqNo.Name = "ColumnSeqNo";
            this.ColumnSeqNo.ReadOnly = true;
            // 
            // ColumnCapTime
            // 
            resources.ApplyResources(this.ColumnCapTime, "ColumnCapTime");
            this.ColumnCapTime.Name = "ColumnCapTime";
            this.ColumnCapTime.ReadOnly = true;
            // 
            // ColumnId
            // 
            resources.ApplyResources(this.ColumnId, "ColumnId");
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            // 
            // ColumnName
            // 
            resources.ApplyResources(this.ColumnName, "ColumnName");
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnMatch
            // 
            resources.ApplyResources(this.ColumnMatch, "ColumnMatch");
            this.ColumnMatch.Name = "ColumnMatch";
            this.ColumnMatch.ReadOnly = true;
            // 
            // ColumnScore
            // 
            resources.ApplyResources(this.ColumnScore, "ColumnScore");
            this.ColumnScore.Name = "ColumnScore";
            this.ColumnScore.ReadOnly = true;
            // 
            // ColumnType
            // 
            resources.ApplyResources(this.ColumnType, "ColumnType");
            this.ColumnType.Name = "ColumnType";
            this.ColumnType.ReadOnly = true;
            // 
            // tabPageCameraSearchResult
            // 
            resources.ApplyResources(this.tabPageCameraSearchResult, "tabPageCameraSearchResult");
            this.tabPageCameraSearchResult.Controls.Add(this.dataGridViewCameraList);
            this.tabPageCameraSearchResult.Name = "tabPageCameraSearchResult";
            this.tabPageCameraSearchResult.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCameraList
            // 
            resources.ApplyResources(this.dataGridViewCameraList, "dataGridViewCameraList");
            this.dataGridViewCameraList.AllowUserToAddRows = false;
            this.dataGridViewCameraList.AllowUserToDeleteRows = false;
            this.dataGridViewCameraList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCameraList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCameraList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIP,
            this.ColumnMac});
            this.dataGridViewCameraList.Name = "dataGridViewCameraList";
            this.dataGridViewCameraList.ReadOnly = true;
            this.dataGridViewCameraList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCameraList_CellDoubleClick);
            // 
            // ColumnIP
            // 
            resources.ApplyResources(this.ColumnIP, "ColumnIP");
            this.ColumnIP.Name = "ColumnIP";
            this.ColumnIP.ReadOnly = true;
            // 
            // ColumnMac
            // 
            resources.ApplyResources(this.ColumnMac, "ColumnMac");
            this.ColumnMac.Name = "ColumnMac";
            this.ColumnMac.ReadOnly = true;
            // 
            // tabPageLog
            // 
            resources.ApplyResources(this.tabPageLog, "tabPageLog");
            this.tabPageLog.Controls.Add(this.listBoxLog);
            this.tabPageLog.Name = "tabPageLog";
            this.tabPageLog.UseVisualStyleBackColor = true;
            // 
            // listBoxLog
            // 
            resources.ApplyResources(this.listBoxLog, "listBoxLog");
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.Name = "listBoxLog";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.buttonAddFace);
            this.groupBox1.Controls.Add(this.buttonQueryFace);
            this.groupBox1.Controls.Add(this.buttonRemoveFace);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // buttonAddFace
            // 
            resources.ApplyResources(this.buttonAddFace, "buttonAddFace");
            this.buttonAddFace.Name = "buttonAddFace";
            this.buttonAddFace.UseVisualStyleBackColor = true;
            this.buttonAddFace.Click += new System.EventHandler(this.buttonAddFace_Click);
            // 
            // buttonQueryFace
            // 
            resources.ApplyResources(this.buttonQueryFace, "buttonQueryFace");
            this.buttonQueryFace.Name = "buttonQueryFace";
            this.buttonQueryFace.UseVisualStyleBackColor = true;
            this.buttonQueryFace.Click += new System.EventHandler(this.buttonQueryFace_Click);
            // 
            // buttonRemoveFace
            // 
            resources.ApplyResources(this.buttonRemoveFace, "buttonRemoveFace");
            this.buttonRemoveFace.Name = "buttonRemoveFace";
            this.buttonRemoveFace.UseVisualStyleBackColor = true;
            this.buttonRemoveFace.Click += new System.EventHandler(this.buttonRemoveFace_Click);
            // 
            // buttonConnect
            // 
            resources.ApplyResources(this.buttonConnect, "buttonConnect");
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // textBoxPort
            // 
            resources.ApplyResources(this.textBoxPort, "textBoxPort");
            this.textBoxPort.Name = "textBoxPort";
            // 
            // textBoxIp
            // 
            resources.ApplyResources(this.textBoxIp, "textBoxIp");
            this.textBoxIp.Name = "textBoxIp";
            // 
            // textBoxUserName
            // 
            resources.ApplyResources(this.textBoxUserName, "textBoxUserName");
            this.textBoxUserName.Name = "textBoxUserName";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // textBoxPassword
            // 
            resources.ApplyResources(this.textBoxPassword, "textBoxPassword");
            this.textBoxPassword.Name = "textBoxPassword";
            // 
            // textBoxSDKPassword
            // 
            resources.ApplyResources(this.textBoxSDKPassword, "textBoxSDKPassword");
            this.textBoxSDKPassword.Name = "textBoxSDKPassword";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Name = "panel1";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
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
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // buttonSearchDevice
            // 
            resources.ApplyResources(this.buttonSearchDevice, "buttonSearchDevice");
            this.buttonSearchDevice.Name = "buttonSearchDevice";
            this.buttonSearchDevice.UseVisualStyleBackColor = true;
            this.buttonSearchDevice.Click += new System.EventHandler(this.buttonSearchDevice_Click);
            // 
            // FormBasic
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "FormBasic";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBasic_FormClosing);
            this.Load += new System.EventHandler(this.FormBasic_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLiveVideo)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageCaptureEvent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCaptureResult)).EndInit();
            this.tabPageCameraSearchResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCameraList)).EndInit();
            this.tabPageLog.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.DataGridView dataGridViewCaptureResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSeqNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCapTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
    }
}