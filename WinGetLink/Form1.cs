using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace WinGetLink
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtold.TextChanged += txtold_TextChanged;
            btnfile.Click += btnfile_Click;
            buttonChange.Click += txtold_TextChanged;
        }

        void btnfile_Click(object sender, EventArgs e)
        {
            var nw = txtnew.Text.Trim();
            if (string.IsNullOrEmpty(nw))
            {
                MessageBox.Show(this, "内容为空,无法保存!");
                return;
            }

            var savepath = Application.StartupPath + "\\tmp_" + DateTime.Now.ToString("yyyy_MM_dd_mm_HH_ss") + ".txt";
            File.WriteAllText(savepath, nw, Encoding.UTF8);
            WriteTip("保存成功," + savepath);
        }
        private readonly string KeyWord = "https:";
        void txtold_TextChanged(object sender, EventArgs e)
        {
            WriteTip("");
            txtnew.Text = "";
            var context = txtold.Text;


            if (string.IsNullOrEmpty(context)) return;

            context += "  ";
            var sps = context.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = sps.Length - 1; i >= 0; i--)
            {
                if (!sps[i].Contains(KeyWord))
                    sps[i].Remove(i);
            }
            var ispwd = cbpwd.Checked;
            var spStr = txtsp.Text.Trim();

            Dictionary<string, string> dict = new Dictionary<string, string>();
            foreach (var item in sps)
            {
                var rg = new Regex(@"(?=https).*?(?=\s)");
                var mc = rg.Matches(item);
                if (mc.Count <= 0) continue;
                foreach (Match im in mc)
                {
                    var url = im.Value;
                    if (ispwd)
                    {
                        //获取密码，密码一般在url的后面
                        string pwdStr = GetPWD(item, url);
                        dict.Add(url, pwdStr);

                    }
                    else
                        dict.Add(url, "");
                }
            }
            var strlast = new StringBuilder();
            foreach (var item in dict)
            {
                if (ispwd)
                    strlast.AppendFormat("{0}{1}{2}", item.Key, spStr, item.Value);
                else
                    strlast.AppendFormat("{0}", item.Key);
                strlast.AppendLine();
            }

            txtnew.Text = strlast.ToString();

        }

        private string GetPWD(string item, string url)
        {
            var lastLen = item.IndexOf(url) + url.Length;
            var laststr = item.Substring(lastLen);
            var rg = new Regex(@"\w{4}");
            var mc = rg.Match(laststr);
            if (!mc.Success) return "";
            return mc.Value;
        }
        private void WriteTip(string msg)
        {
            labtip.Text = msg;
        }
    }
}
