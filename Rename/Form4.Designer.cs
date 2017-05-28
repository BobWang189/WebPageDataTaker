namespace Rename
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.txtDirPath = new System.Windows.Forms.TextBox();
            this.txtTargetName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listboxKeyword = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtReplaceDir = new System.Windows.Forms.TextBox();
            this.btnBrowseReplace = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(34, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "目标目录:";
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(488, 12);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnBrowser.TabIndex = 9;
            this.btnBrowser.Text = "浏  览";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // txtDirPath
            // 
            this.txtDirPath.Location = new System.Drawing.Point(119, 13);
            this.txtDirPath.Name = "txtDirPath";
            this.txtDirPath.Size = new System.Drawing.Size(361, 21);
            this.txtDirPath.TabIndex = 8;
            // 
            // txtTargetName
            // 
            this.txtTargetName.Location = new System.Drawing.Point(119, 51);
            this.txtTargetName.Name = "txtTargetName";
            this.txtTargetName.Size = new System.Drawing.Size(361, 21);
            this.txtTargetName.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(18, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "定位文件名:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(488, 50);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "查  找";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(34, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "查找结果:";
            // 
            // listboxKeyword
            // 
            this.listboxKeyword.FormattingEnabled = true;
            this.listboxKeyword.ItemHeight = 12;
            this.listboxKeyword.Location = new System.Drawing.Point(119, 98);
            this.listboxKeyword.Name = "listboxKeyword";
            this.listboxKeyword.Size = new System.Drawing.Size(361, 136);
            this.listboxKeyword.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(19, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(544, 2);
            this.label4.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(34, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "替换目录:";
            // 
            // txtReplaceDir
            // 
            this.txtReplaceDir.Location = new System.Drawing.Point(120, 290);
            this.txtReplaceDir.Name = "txtReplaceDir";
            this.txtReplaceDir.Size = new System.Drawing.Size(361, 21);
            this.txtReplaceDir.TabIndex = 8;
            // 
            // btnBrowseReplace
            // 
            this.btnBrowseReplace.Location = new System.Drawing.Point(489, 289);
            this.btnBrowseReplace.Name = "btnBrowseReplace";
            this.btnBrowseReplace.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseReplace.TabIndex = 9;
            this.btnBrowseReplace.Text = "浏  览";
            this.btnBrowseReplace.UseVisualStyleBackColor = true;
            this.btnBrowseReplace.Click += new System.EventHandler(this.btnBrowseReplace_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReplace.Location = new System.Drawing.Point(214, 333);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(161, 35);
            this.btnReplace.TabIndex = 9;
            this.btnReplace.Text = "替  换";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.ForeColor = System.Drawing.Color.Red;
            this.lblInfo.Location = new System.Drawing.Point(119, 248);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 12);
            this.lblInfo.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(123, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "比如aa目录下的bb目录,目录格式为：aa\\bb";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 384);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listboxKeyword);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtTargetName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnBrowseReplace);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.txtReplaceDir);
            this.Controls.Add(this.txtDirPath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件夹查找与替换工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.TextBox txtDirPath;
        private System.Windows.Forms.TextBox txtTargetName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listboxKeyword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtReplaceDir;
        private System.Windows.Forms.Button btnBrowseReplace;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label label6;
    }
}