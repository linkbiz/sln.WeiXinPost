namespace WeiXinPost
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.radText = new System.Windows.Forms.RadioButton();
            this.radVoice = new System.Windows.Forms.RadioButton();
            this.btnPost = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtToUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtFromUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResponseXml = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtText2 = new System.Windows.Forms.TextBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.radMenu = new System.Windows.Forms.RadioButton();
            this.lblText2 = new System.Windows.Forms.Label();
            this.radCancel = new System.Windows.Forms.RadioButton();
            this.radFollow = new System.Windows.Forms.RadioButton();
            this.radLocation = new System.Windows.Forms.RadioButton();
            this.radPic = new System.Windows.Forms.RadioButton();
            this.lblText = new System.Windows.Forms.Label();
            this.txtBuildXml = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbUrl = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClearResponse = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.chkUseWeiXin = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tmrSecond = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuWeixinMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radText
            // 
            this.radText.AutoSize = true;
            this.radText.Checked = true;
            this.radText.Location = new System.Drawing.Point(12, 7);
            this.radText.Name = "radText";
            this.radText.Size = new System.Drawing.Size(47, 16);
            this.radText.TabIndex = 0;
            this.radText.TabStop = true;
            this.radText.Text = "文本";
            this.radText.UseVisualStyleBackColor = true;
            this.radText.CheckedChanged += new System.EventHandler(this.raddio_CheckedChanged);
            // 
            // radVoice
            // 
            this.radVoice.AutoSize = true;
            this.radVoice.Location = new System.Drawing.Point(65, 7);
            this.radVoice.Name = "radVoice";
            this.radVoice.Size = new System.Drawing.Size(47, 16);
            this.radVoice.TabIndex = 1;
            this.radVoice.Text = "语音";
            this.radVoice.UseVisualStyleBackColor = true;
            this.radVoice.CheckedChanged += new System.EventHandler(this.raddio_CheckedChanged);
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(0, 0);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(205, 21);
            this.btnPost.TabIndex = 2;
            this.btnPost.Text = "提交";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtResponseXml, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtBuildXml, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(945, 518);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtToUserName);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(3, 69);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(927, 27);
            this.panel4.TabIndex = 11;
            // 
            // txtToUserName
            // 
            this.txtToUserName.Location = new System.Drawing.Point(86, 3);
            this.txtToUserName.Name = "txtToUserName";
            this.txtToUserName.Size = new System.Drawing.Size(355, 21);
            this.txtToUserName.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtToUserName, "这里填上由微信生成的ToUserName");
            this.txtToUserName.TextChanged += new System.EventHandler(this.txtToUserName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "ToUserName：";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtFromUserName);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(3, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(930, 27);
            this.panel3.TabIndex = 10;
            // 
            // txtFromUserName
            // 
            this.txtFromUserName.Location = new System.Drawing.Point(86, 3);
            this.txtFromUserName.Name = "txtFromUserName";
            this.txtFromUserName.Size = new System.Drawing.Size(355, 21);
            this.txtFromUserName.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtFromUserName, "这里填上由微信服务器生成的FromUserName");
            this.txtFromUserName.TextChanged += new System.EventHandler(this.txtFromUserName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "FromUserName：";
            // 
            // txtResponseXml
            // 
            this.txtResponseXml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResponseXml.Location = new System.Drawing.Point(3, 267);
            this.txtResponseXml.Multiline = true;
            this.txtResponseXml.Name = "txtResponseXml";
            this.txtResponseXml.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResponseXml.Size = new System.Drawing.Size(939, 227);
            this.txtResponseXml.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtText2);
            this.panel1.Controls.Add(this.txtText);
            this.panel1.Controls.Add(this.radMenu);
            this.panel1.Controls.Add(this.lblText2);
            this.panel1.Controls.Add(this.radCancel);
            this.panel1.Controls.Add(this.radFollow);
            this.panel1.Controls.Add(this.radLocation);
            this.panel1.Controls.Add(this.radPic);
            this.panel1.Controls.Add(this.lblText);
            this.panel1.Controls.Add(this.radVoice);
            this.panel1.Controls.Add(this.radText);
            this.panel1.Location = new System.Drawing.Point(3, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 27);
            this.panel1.TabIndex = 4;
            // 
            // txtText2
            // 
            this.txtText2.Location = new System.Drawing.Point(730, 3);
            this.txtText2.Name = "txtText2";
            this.txtText2.Size = new System.Drawing.Size(197, 21);
            this.txtText2.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtText2, "默认都是使用内容1，如果是位置内容2就是Y");
            this.txtText2.TextChanged += new System.EventHandler(this.txtText2_TextChanged);
            this.txtText2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtText2_KeyUp);
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(478, 3);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(182, 21);
            this.txtText.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtText, "默认都是使用内容1，如果是位置内容1就是X");
            this.txtText.TextChanged += new System.EventHandler(this.txtText_TextChanged);
            this.txtText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtText_KeyUp);
            // 
            // radMenu
            // 
            this.radMenu.AutoSize = true;
            this.radMenu.Location = new System.Drawing.Point(354, 7);
            this.radMenu.Name = "radMenu";
            this.radMenu.Size = new System.Drawing.Size(47, 16);
            this.radMenu.TabIndex = 10;
            this.radMenu.Text = "菜单";
            this.radMenu.UseVisualStyleBackColor = true;
            // 
            // lblText2
            // 
            this.lblText2.Location = new System.Drawing.Point(678, 9);
            this.lblText2.Name = "lblText2";
            this.lblText2.Size = new System.Drawing.Size(58, 12);
            this.lblText2.TabIndex = 9;
            this.lblText2.Text = "内容2：";
            this.lblText2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radCancel
            // 
            this.radCancel.AutoSize = true;
            this.radCancel.Location = new System.Drawing.Point(277, 6);
            this.radCancel.Name = "radCancel";
            this.radCancel.Size = new System.Drawing.Size(71, 16);
            this.radCancel.TabIndex = 7;
            this.radCancel.Text = "取消关注";
            this.radCancel.UseVisualStyleBackColor = true;
            this.radCancel.CheckedChanged += new System.EventHandler(this.raddio_CheckedChanged);
            // 
            // radFollow
            // 
            this.radFollow.AutoSize = true;
            this.radFollow.Location = new System.Drawing.Point(224, 6);
            this.radFollow.Name = "radFollow";
            this.radFollow.Size = new System.Drawing.Size(47, 16);
            this.radFollow.TabIndex = 6;
            this.radFollow.Text = "关注";
            this.radFollow.UseVisualStyleBackColor = true;
            this.radFollow.CheckedChanged += new System.EventHandler(this.raddio_CheckedChanged);
            // 
            // radLocation
            // 
            this.radLocation.AutoSize = true;
            this.radLocation.Location = new System.Drawing.Point(171, 7);
            this.radLocation.Name = "radLocation";
            this.radLocation.Size = new System.Drawing.Size(47, 16);
            this.radLocation.TabIndex = 5;
            this.radLocation.Text = "位置";
            this.radLocation.UseVisualStyleBackColor = true;
            this.radLocation.CheckedChanged += new System.EventHandler(this.raddio_CheckedChanged);
            // 
            // radPic
            // 
            this.radPic.AutoSize = true;
            this.radPic.Location = new System.Drawing.Point(118, 7);
            this.radPic.Name = "radPic";
            this.radPic.Size = new System.Drawing.Size(47, 16);
            this.radPic.TabIndex = 4;
            this.radPic.Text = "图片";
            this.radPic.UseVisualStyleBackColor = true;
            this.radPic.CheckedChanged += new System.EventHandler(this.raddio_CheckedChanged);
            // 
            // lblText
            // 
            this.lblText.Location = new System.Drawing.Point(407, 8);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(77, 12);
            this.lblText.TabIndex = 3;
            this.lblText.Text = "内容1：";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBuildXml
            // 
            this.txtBuildXml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBuildXml.Location = new System.Drawing.Point(3, 135);
            this.txtBuildXml.Multiline = true;
            this.txtBuildXml.Name = "txtBuildXml";
            this.txtBuildXml.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBuildXml.Size = new System.Drawing.Size(939, 93);
            this.txtBuildXml.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbUrl);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(930, 27);
            this.panel2.TabIndex = 9;
            // 
            // cbUrl
            // 
            this.cbUrl.FormattingEnabled = true;
            this.cbUrl.Location = new System.Drawing.Point(86, 4);
            this.cbUrl.Name = "cbUrl";
            this.cbUrl.Size = new System.Drawing.Size(826, 20);
            this.cbUrl.TabIndex = 9;
            this.toolTip1.SetToolTip(this.cbUrl, "请注意，这里要自己带上签名参数，或者带上特殊的参数让WEB程序不要验签");
            this.cbUrl.SelectedIndexChanged += new System.EventHandler(this.cbUrl_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "请求网址：";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnClearResponse, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 234);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(939, 27);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // btnClearResponse
            // 
            this.btnClearResponse.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClearResponse.Location = new System.Drawing.Point(841, 3);
            this.btnClearResponse.Name = "btnClearResponse";
            this.btnClearResponse.Size = new System.Drawing.Size(95, 21);
            this.btnClearResponse.TabIndex = 3;
            this.btnClearResponse.Text = "清除回应内容";
            this.btnClearResponse.UseVisualStyleBackColor = true;
            this.btnClearResponse.Click += new System.EventHandler(this.btnClearResponse_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.chkUseWeiXin);
            this.panel5.Controls.Add(this.btnPost);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(426, 21);
            this.panel5.TabIndex = 4;
            // 
            // chkUseWeiXin
            // 
            this.chkUseWeiXin.AutoSize = true;
            this.chkUseWeiXin.Checked = true;
            this.chkUseWeiXin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseWeiXin.Location = new System.Drawing.Point(212, 2);
            this.chkUseWeiXin.Name = "chkUseWeiXin";
            this.chkUseWeiXin.Size = new System.Drawing.Size(90, 16);
            this.chkUseWeiXin.TabIndex = 3;
            this.chkUseWeiXin.Text = "5秒自动断开";
            this.toolTip1.SetToolTip(this.chkUseWeiXin, "微信服务器规定5秒没有返回自动断开");
            this.chkUseWeiXin.UseVisualStyleBackColor = true;
            // 
            // tmrSecond
            // 
            this.tmrSecond.Enabled = true;
            this.tmrSecond.Interval = 1000;
            this.tmrSecond.Tick += new System.EventHandler(this.tmrSecond_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuWeixinMenu,
            this.mnuAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(945, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuWeixinMenu
            // 
            this.mnuWeixinMenu.Name = "mnuWeixinMenu";
            this.mnuWeixinMenu.Size = new System.Drawing.Size(140, 20);
            this.mnuWeixinMenu.Text = "微信菜单管理(&M)";
            this.mnuWeixinMenu.Click += new System.EventHandler(this.mnuWeixinMenu_Click);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(108, 20);
            this.mnuAbout.Text = "关于我们(&A)";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 542);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "微信开发调试小工具";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radText;
        private System.Windows.Forms.RadioButton radVoice;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtToUserName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtFromUserName;
        private System.Windows.Forms.TextBox txtResponseXml;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBuildXml;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.RadioButton radLocation;
        private System.Windows.Forms.RadioButton radPic;
        private System.Windows.Forms.RadioButton radCancel;
        private System.Windows.Forms.RadioButton radFollow;
        private System.Windows.Forms.Label lblText2;
        private System.Windows.Forms.TextBox txtText2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RadioButton radMenu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnClearResponse;
        private System.Windows.Forms.ComboBox cbUrl;
        protected System.Windows.Forms.Timer tmrSecond;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.CheckBox chkUseWeiXin;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuWeixinMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
    }
}

