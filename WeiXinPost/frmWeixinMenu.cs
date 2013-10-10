using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LitJson;

namespace WeiXinPost
{
    public partial class frmWeixinMenu : Form
    {
        public frmWeixinMenu()
        {
            InitializeComponent();
        }


        private void btnCreateMenu_Click(object sender, EventArgs e)
        {
            if(!CheckAppSetting())
                return;

            if (String.IsNullOrEmpty(txtMenuString.Text.Trim()))
            {
                MessageBox.Show("请填写菜单信息");
                return;
            }
            if (MessageBox.Show("您确定要创建或更新菜单吗？", "确定更新", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            //1:获得token
            MyHttpWebRequest request = new MyHttpWebRequest();
            string token = GetToken();
            if(String.IsNullOrEmpty(token)){
                MessageBox.Show("获取Token失败!");
                return;
            }
            //2:删除当前菜单
           string rtn =  request.getPage("https://api.weixin.qq.com/cgi-bin/menu/delete?access_token="+token);

            ShowLog("清除菜单返回：\r\n"+rtn);

            //3:创建菜单
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("", txtMenuString.Text);
            rtn =  request.post("https://api.weixin.qq.com/cgi-bin/menu/create?access_token=" + token, nvc, Encoding.UTF8);
            this.ShowLog("提交菜单返回："+rtn);
        }

        private bool  CheckAppSetting()
        {
            if (String.IsNullOrEmpty(txtAppid.Text.Trim()))
            {
                MessageBox.Show("请填写AppId");
                return false;
            }
            if (String.IsNullOrEmpty(txtKey.Text.Trim()))
            {
                MessageBox.Show("请填写AppSecret");
                return false;
            }
            return true;
        }

        private string Token = "";
        private DateTime TokenTime;
        private int expires = 0;
        /// <summary>
        /// 获取Token
        /// </summary>
        /// <returns></returns>
        private string GetToken()
        {
            if (!String.IsNullOrEmpty(Token)) {
                if (DateTime.Now.Subtract(TokenTime).TotalSeconds < expires) return Token;
            }
            MyHttpWebRequest request = new MyHttpWebRequest();
            string rtn = request.getPage(String.Format("https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid={0}&secret={1}", txtAppid.Text, txtKey.Text));
            ShowLog("获取Token返回:"+rtn);
            try
            {
                LitJson.JsonData data = LitJson.JsonMapper.ToObject(rtn);
                Token = data["access_token"].ToString();
                TokenTime = DateTime.Now;
                expires = Convert.ToInt32(data["expires_in"].ToString());
                return Token;
            }
            catch (Exception ex)
            {
                ShowLog(ex.Message);
            }
            return "";
        }

        private void frmWeixinMenu_Load(object sender, EventArgs e)
        {
            string txt = Properties.Settings.Default.WeixinMenuString;
            if(!String.IsNullOrEmpty(txt))
                txtMenuString.Text = txt;
        }

        private void btnGetMenu_Click(object sender, EventArgs e)
        {
            if (!CheckAppSetting())
                return;

            if (MessageBox.Show("您确定要获菜单数据吗？获取后将会覆盖现在的菜单结构体内容!", "确定更新", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            MyHttpWebRequest request = new MyHttpWebRequest();
            string token = this.GetToken();
            if (String.IsNullOrEmpty(token))
            {
                MessageBox.Show("获取Token失败!");
                return;
            }

            string rtn = request.getPage(String.Format("https://api.weixin.qq.com/cgi-bin/menu/get?access_token={0}", token));
            
            try
            {
                LitJson.JsonData data = LitJson.JsonMapper.ToObject(rtn);
                if (!String.IsNullOrEmpty(data["errcode"].ToString())){
                    ShowLog("获取菜单返回:\r\n" + rtn);
                }
                else {
                    txtMenuString.Text = rtn;
                }
            }
            catch (Exception ex){
                txtMenuString.Text = rtn;
            }
            

        }

        private void ShowLog(string msg)
        {
            txtLog.AppendText(msg);
            txtLog.AppendText("\r\n");
            txtLog.AppendText("----------------------------------------------------------------------------------\r\n");
            txtLog.ScrollToCaret();
        }

        private void frmWeixinMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.WeixinMenuString = txtMenuString.Text;
            Properties.Settings.Default.Save();

        }

        private void btnClearMenu_Click(object sender, EventArgs e)
        {
            if (!CheckAppSetting())
                return;
            if (MessageBox.Show("您确定清除微信菜单吗？清除后您还可以重建菜单!", "确定清除", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            MyHttpWebRequest request = new MyHttpWebRequest();
            string token = this.GetToken();
            if (String.IsNullOrEmpty(token))
            {
                MessageBox.Show("获取Token失败!");
                return;
            }

            string rtn = request.getPage("https://api.weixin.qq.com/cgi-bin/menu/delete?access_token=" + token);

            ShowLog("清除菜单返回：\r\n" + rtn);
           
            
        }


    }
}
