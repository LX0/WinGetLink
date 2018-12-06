namespace WinGetLink
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtold = new System.Windows.Forms.TextBox();
            this.txtnew = new System.Windows.Forms.TextBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.btnfile = new System.Windows.Forms.Button();
            this.cbpwd = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsp = new System.Windows.Forms.TextBox();
            this.labtip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "将文本复制到待转换区";
            // 
            // txtold
            // 
            this.txtold.Location = new System.Drawing.Point(12, 48);
            this.txtold.Multiline = true;
            this.txtold.Name = "txtold";
            this.txtold.Size = new System.Drawing.Size(732, 330);
            this.txtold.TabIndex = 1;
            // 
            // txtnew
            // 
            this.txtnew.Location = new System.Drawing.Point(12, 433);
            this.txtnew.Multiline = true;
            this.txtnew.Name = "txtnew";
            this.txtnew.Size = new System.Drawing.Size(732, 165);
            this.txtnew.TabIndex = 1;
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(307, 385);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(98, 42);
            this.buttonChange.TabIndex = 2;
            this.buttonChange.Text = "获取链接";
            this.buttonChange.UseVisualStyleBackColor = true;
            // 
            // btnfile
            // 
            this.btnfile.Location = new System.Drawing.Point(557, 385);
            this.btnfile.Name = "btnfile";
            this.btnfile.Size = new System.Drawing.Size(98, 42);
            this.btnfile.TabIndex = 2;
            this.btnfile.Text = "生成文件";
            this.btnfile.UseVisualStyleBackColor = true;
            // 
            // cbpwd
            // 
            this.cbpwd.AutoSize = true;
            this.cbpwd.Checked = true;
            this.cbpwd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbpwd.Location = new System.Drawing.Point(207, 23);
            this.cbpwd.Name = "cbpwd";
            this.cbpwd.Size = new System.Drawing.Size(240, 16);
            this.cbpwd.TabIndex = 3;
            this.cbpwd.Text = "提取密码（仅支持链接和密码在同一行）";
            this.cbpwd.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "分隔符";
            // 
            // txtsp
            // 
            this.txtsp.Location = new System.Drawing.Point(555, 20);
            this.txtsp.Name = "txtsp";
            this.txtsp.Size = new System.Drawing.Size(100, 21);
            this.txtsp.TabIndex = 5;
            this.txtsp.Text = "----";
            // 
            // labtip
            // 
            this.labtip.AutoSize = true;
            this.labtip.Location = new System.Drawing.Point(34, 611);
            this.labtip.Name = "labtip";
            this.labtip.Size = new System.Drawing.Size(11, 12);
            this.labtip.TabIndex = 0;
            this.labtip.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 643);
            this.Controls.Add(this.txtsp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbpwd);
            this.Controls.Add(this.btnfile);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.txtnew);
            this.Controls.Add(this.txtold);
            this.Controls.Add(this.labtip);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "批量获取网盘链接";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtold;
        private System.Windows.Forms.TextBox txtnew;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button btnfile;
        private System.Windows.Forms.CheckBox cbpwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsp;
        private System.Windows.Forms.Label labtip;
    }
}

