using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using WeiXinPost.Properties;

namespace WeiXinPost
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        int CbUrlLastIndex = 0;
        private void btnPost_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtBuildXml.Text))
                CreateXml();

            if (txtBuildXml.Text.Trim() != "")
            {
               StartWork();
            }
            SaveLastParmeters();
        }

        /// <summary>
        /// 保存最后使用的参数
        /// </summary>
        private void SaveLastParmeters()
        {
            if (CbUrlLastIndex < 0) CbUrlLastIndex = 0;
            if (radText.Checked)
                CurrentSetting.LastText = txtText.Text;
            if (radVoice.Checked)
                CurrentSetting.LastVoice = txtText.Text;
            if (radPic.Checked)
                CurrentSetting.LastPic = txtText.Text;
            if (radLocation.Checked)
            {
                CurrentSetting.LastPositionX = txtText.Text;
                CurrentSetting.LastPositionY = txtText2.Text;
            }
            if(radMenu.Checked)
                CurrentSetting.LastMenu = txtText.Text;

            CurrentSetting.LastUrl = cbUrl.Text;
            cbUrl.Items[CbUrlLastIndex] = cbUrl.Text;
            CurrentSetting.LastFromName = txtFromUserName.Text;
            CurrentSetting.LastToName = txtToUserName.Text;
            CurrentSetting.Save();
        }

        /// <summary>
        /// 装载默认参数
        /// </summary>
        /// <param name="onlyRadio"></param>
        private void LoadLastParmeters(bool onlyRadio)
        {

            if (!onlyRadio)
            {
                cbUrl.Text = CurrentSetting.LastUrl;
                cbUrl.Text = CurrentSetting.LastUrl;
                txtFromUserName.Text = CurrentSetting.LastFromName;
                txtToUserName.Text = CurrentSetting.LastToName;
            }

            if (radText.Checked)
                txtText.Text = CurrentSetting.LastText;
            if (radVoice.Checked)
                txtText.Text = CurrentSetting.LastVoice;
            if (radPic.Checked)
                txtText.Text = CurrentSetting.LastPic;
            if (radMenu.Checked)
                txtText.Text = CurrentSetting.LastMenu;
            if (radLocation.Checked)
            {
                txtText.Text = CurrentSetting.LastPositionX;
                txtText2.Text = CurrentSetting.LastPositionY;
            }

        }

        private ISetting CurrentSetting
        {
            get {
                switch (CbUrlLastIndex)
                {
                    case 1:
                        return Properties.SecondSettings.Default;
                    case 2:
                        return Properties.ThirdSettings.Default;
                    default:
                        return Properties.Settings.Default;
                }
                
            }
        }

         /// <summary>
        /// 创建要发送的XML
        /// </summary>
        private void CreateXml(bool hideInput)
        {
            if (hideInput)
            {
                lblText.Visible = false;
                lblText2.Visible = false;
                txtText.Visible = false;
                txtText2.Visible = false;
            }
            if (radText.Checked)
            {
                txtBuildXml.Text = TextXml();
                EnableTextInput("内容：");
            }
            if (radVoice.Checked)
            {
                txtBuildXml.Text = VoiceXml();
                EnableTextInput("语音：");
            }
            if (radPic.Checked)
            {
                txtBuildXml.Text = PicXml();
                EnableTextInput("图片：");
            }
            if (radLocation.Checked)
            {
                txtBuildXml.Text = LocationXml();
                EnableTextInput("X：");
                EnableText2Input("Y：");
            }
            if (radFollow.Checked)
                txtBuildXml.Text = SubcribleXml();
            if (radCancel.Checked)
                txtBuildXml.Text = DecribleXml();
            if (radMenu.Checked)
            {
                txtBuildXml.Text = MenuClickXml();
                EnableTextInput("EventKey：");
            }
        }

        /// <summary>
        /// 创建要发送的XML
        /// </summary>
        private void CreateXml()
        {
            CreateXml(true);
        }

        /// <summary>
        /// 显示第一个参数
        /// </summary>
        /// <param name="title"></param>
        private void EnableTextInput(string title)
        {
            lblText.Text    = title;
            lblText.Visible = true;
            txtText.Visible = true;
        }

        /// <summary>
        /// 显示第二个参数
        /// </summary>
        /// <param name="title"></param>
        private void EnableText2Input(string title)
        {
            lblText2.Text   = title;
            lblText2.Visible = true;
            txtText2.Visible = true;
        }

        /// <summary>
        /// 创建文本XML
        /// </summary>
        /// <returns></returns>
        private string TextXml()
        {
            StringBuilder txt = new StringBuilder();
            txt.Append("<xml>").Append("\r\n");
            txt.Append("<ToUserName><![CDATA[").Append(txtToUserName.Text).Append("]]></ToUserName>").Append("\r\n");
            txt.Append("<FromUserName><![CDATA[").Append(txtFromUserName.Text).Append("]]></FromUserName>").Append("\r\n");
            txt.Append("<CreateTime>").Append(GetTimestamp()).Append("</CreateTime>").Append("\r\n");
            txt.Append("<MsgType><![CDATA[text]]></MsgType>").Append("\r\n");
            txt.Append("<Content><![CDATA[").Append(txtText.Text).Append("]]></Content>").Append("\r\n");
            txt.Append("<MsgId>1234567890123456</MsgId>").Append("\r\n");
            txt.Append("</xml>");
            return txt.ToString();
        }

        /// <summary>
        /// 创建语音XML
        /// </summary>
        /// <returns></returns>
        private string VoiceXml()
        {
            StringBuilder txt = new StringBuilder();
            txt.Append("<xml>").Append("\r\n");
            txt.Append("<ToUserName><![CDATA[").Append(txtToUserName.Text).Append("]]></ToUserName>").Append("\r\n");
            txt.Append("<FromUserName><![CDATA[").Append(txtFromUserName.Text).Append("]]></FromUserName>").Append("\r\n");
            txt.Append("<CreateTime>").Append(GetTimestamp()).Append("</CreateTime>").Append("\r\n");
            txt.Append("<MsgType><![CDATA[voice]]></MsgType>").Append("\r\n");
            txt.Append("<Content><![CDATA[").Append(txtText.Text).Append("]]></Content>").Append("\r\n");
            txt.Append("<MsgId>1234567890123456</MsgId>").Append("\r\n");
            txt.Append("</xml>");
            return txt.ToString();
        }
        /// <summary>
        /// 创建图片XML
        /// </summary>
        /// <returns></returns>
        private string PicXml()
        {
            StringBuilder txt = new StringBuilder();
            txt.Append("<xml>").Append("\r\n");
            txt.Append("<ToUserName><![CDATA[").Append(txtToUserName.Text).Append("]]></ToUserName>").Append("\r\n");
            txt.Append("<FromUserName><![CDATA[").Append(txtFromUserName.Text).Append("]]></FromUserName>").Append("\r\n");
            txt.Append("<CreateTime>").Append(GetTimestamp()).Append("</CreateTime>").Append("\r\n");
            txt.Append("<MsgType><![CDATA[image]]></MsgType>").Append("\r\n");
            txt.Append("<PicUrl><![CDATA[").Append(txtText.Text).Append("]]></PicUrl>").Append("\r\n");
            txt.Append("<MsgId>1234567890123456</MsgId>").Append("\r\n");
            txt.Append("</xml>");
            return txt.ToString();
        }

        /// <summary>
        /// 位置XML
        /// </summary>
        /// <returns></returns>
        private string LocationXml()
        {
            StringBuilder txt = new StringBuilder();
            txt.Append("<xml>").Append("\r\n");
            txt.Append("<ToUserName><![CDATA[").Append(txtToUserName.Text).Append("]]></ToUserName>").Append("\r\n");
            txt.Append("<FromUserName><![CDATA[").Append(txtFromUserName.Text).Append("]]></FromUserName>").Append("\r\n");
            txt.Append("<CreateTime>").Append(GetTimestamp()).Append("</CreateTime>").Append("\r\n");
            txt.Append("<MsgType><![CDATA[location]]></MsgType>").Append("\r\n");
            txt.Append("<Location_X>").Append(txtText.Text).Append("</Location_X>").Append("\r\n");
            txt.Append("<Location_Y>").Append(txtText2.Text).Append("</Location_Y>").Append("\r\n");
            txt.Append("<Scale>20</Scale>").Append("\r\n");
            txt.Append("<Label><![CDATA[]]></Label>").Append("\r\n");
            txt.Append("<MsgId>1234567890123456</MsgId>").Append("\r\n");
            txt.Append("</xml>");
            return txt.ToString();
        }

        /// <summary>
        /// 订阅XML
        /// </summary>
        /// <returns></returns>
        private string SubcribleXml()
        {
            StringBuilder txt = new StringBuilder();
            txt.Append("<xml>").Append("\r\n");
            txt.Append("<ToUserName><![CDATA[").Append(txtToUserName.Text).Append("]]></ToUserName>").Append("\r\n");
            txt.Append("<FromUserName><![CDATA[").Append(txtFromUserName.Text).Append("]]></FromUserName>").Append("\r\n");
            txt.Append("<CreateTime>").Append(GetTimestamp()).Append("</CreateTime>").Append("\r\n");
            txt.Append("<MsgType><![CDATA[event]]></MsgType>").Append("\r\n");
            txt.Append("<Event><![CDATA[subscribe]]></Event>").Append("\r\n");
            txt.Append("</xml>");
            return txt.ToString();
        }

        /// <summary>
        /// 取消订阅
        /// </summary>
        /// <returns></returns>
        private string DecribleXml()
        {
            StringBuilder txt = new StringBuilder();
            txt.Append("<xml>").Append("\r\n");
            txt.Append("<ToUserName><![CDATA[").Append(txtToUserName.Text).Append("]]></ToUserName>").Append("\r\n");
            txt.Append("<FromUserName><![CDATA[").Append(txtFromUserName.Text).Append("]]></FromUserName>").Append("\r\n");
            txt.Append("<CreateTime>").Append(GetTimestamp()).Append("</CreateTime>").Append("\r\n");
            txt.Append("<MsgType><![CDATA[event]]></MsgType>").Append("\r\n");
            txt.Append("<Event><![CDATA[unsubscribe]]></Event>").Append("\r\n");
            txt.Append("</xml>");
            return txt.ToString();
        }

        private string MenuClickXml()
        {
            StringBuilder txt = new StringBuilder();
            txt.Append("<xml>").Append("\r\n");
            txt.Append("<ToUserName><![CDATA[").Append(txtToUserName.Text).Append("]]></ToUserName>").Append("\r\n");
            txt.Append("<FromUserName><![CDATA[").Append(txtFromUserName.Text).Append("]]></FromUserName>").Append("\r\n");
            txt.Append("<CreateTime>").Append(GetTimestamp()).Append("</CreateTime>").Append("\r\n");
            txt.Append("<MsgType><![CDATA[event]]></MsgType>").Append("\r\n");
            txt.Append("<Event><![CDATA[CLICK]]></Event>").Append("\r\n");
            txt.Append("<EventKey><![CDATA[").Append(txtText.Text).Append("]]></EventKey>").Append("\r\n");
            txt.Append("</xml>");
            return txt.ToString();
        }

        private void raddio_CheckedChanged(object sender, EventArgs e)
        {
            LoadLastParmeters(true);
            CreateXml();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tmrSecond.Enabled = false;
            if(!String.IsNullOrEmpty(Properties.Settings.Default.LastUrl))
                this.cbUrl.Items.Add(Properties.Settings.Default.LastUrl);
            else
                this.cbUrl.Items.Add("http://");
            if (!String.IsNullOrEmpty(Properties.SecondSettings.Default.LastUrl))
                this.cbUrl.Items.Add(Properties.SecondSettings.Default.LastUrl);
            else
                this.cbUrl.Items.Add("http://");
            if (!String.IsNullOrEmpty(Properties.ThirdSettings.Default.LastUrl))
                this.cbUrl.Items.Add(Properties.ThirdSettings.Default.LastUrl);
            else
                this.cbUrl.Items.Add("http://");
            
            this.cbUrl_SelectedIndexChanged(null,e);
        }

        private void txtText_KeyUp(object sender, KeyEventArgs e)
        {
            this.CreateXml(false);
            txtText.Focus();
        }

        private void txtText2_KeyUp(object sender, KeyEventArgs e)
        {
            this.CreateXml(false);
            txtText2.Focus();
        }

        private Int64 GetTimestamp()
        {
            TimeSpan span = (DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime());
            return (Int64)span.TotalSeconds;
        }

        private void btnClearResponse_Click(object sender, EventArgs e)
        {
            txtResponseXml.Text = "";
        }

        private void txtText_TextChanged(object sender, EventArgs e)
        {
            this.CreateXml(false);
            txtText.Focus();
        }

        private void txtText2_TextChanged(object sender, EventArgs e)
        {
            this.CreateXml(false);
            txtText2.Focus();
        }

        private void cbUrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbUrlLastIndex == cbUrl.SelectedIndex) return;
            CbUrlLastIndex = cbUrl.SelectedIndex;

            this.LoadLastParmeters(false);
            this.CreateXml(true);
            cbUrl.Focus();
        }

        private void txtFromUserName_TextChanged(object sender, EventArgs e)
        {
            this.CreateXml(false);
            txtFromUserName.Focus();
        }

        private void txtToUserName_TextChanged(object sender, EventArgs e)
        {
            this.CreateXml(true);
            txtToUserName.Focus();
        }

        int Seconds = 0;
        private void tmrSecond_Tick(object sender, EventArgs e)
        {
            Seconds++;
            ShowBtnPostText(String.Format("提交({0})", Seconds));
            if (Seconds == 0)
                tmrSecond.Enabled = false;
        }

       
        string url = "";
        string text = "";
        bool useFiveSecond = false;
        private void StartWork()
        {
            Seconds = 0;
            btnPost.Text = String.Format("提交({0})", Seconds);
            btnPost.Enabled = false;
            tmrSecond.Enabled = true;
            url = cbUrl.Text;
            text = txtBuildXml.Text;
            useFiveSecond = chkUseWeiXin.Checked;
            Thread thread = new Thread(new ThreadStart(ThreadTimer));
            thread.Start(); 
        }


        private void ThreadTimer()
        {
            MyHttpWebRequest req = new MyHttpWebRequest();
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("", text);
            btnPost.Enabled = false;
            if(useFiveSecond)req.SetTimeOut(5);
            string rtn = req.post(url, nvc, Encoding.UTF8);
            ShowMessage(rtn);
            ShowBtnPostText("提交");
        }

        delegate void SetBtnTextCallback(string msg);
        private void ShowBtnPostText(string msg)
        {
            try
            {
                if (btnPost.InvokeRequired)
                {
                    SetBtnTextCallback d = new SetBtnTextCallback(ShowBtnPostText);
                    Invoke(d, new object[] { msg });
                }
                else
                {
                    
                    if (msg == "提交")
                    {
                        tmrSecond.Enabled = false;
                        btnPost.Enabled = true;
                        return;
                    }
                    btnPost.Text = msg;
                }
            }
            catch
            {
            }
        }

        delegate void SetTextCallback(string msg);
        private void ShowMessage(string msg)
        {
            try
            {
                if (txtResponseXml.InvokeRequired)
                {
                    SetTextCallback d = new SetTextCallback(ShowMessage);
                    Invoke(d, new object[] { msg });
                }
                else
                {
          
                    if (txtResponseXml.Text.Length > 0)
                        txtResponseXml.AppendText("\r\n--------------------------------------------------------分割线--------------------------------------------------------\r\n");

                    txtResponseXml.AppendText(msg);
                    txtResponseXml.ScrollToCaret();
                }
            }
            catch
            {
            }
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            new frmAbout().ShowDialog();
        }

        private void mnuWeixinMenu_Click(object sender, EventArgs e)
        {
            new frmWeixinMenu().ShowDialog();
        }


    }
}
