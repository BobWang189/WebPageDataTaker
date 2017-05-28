namespace Rename
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label2 = new System.Windows.Forms.Label();
            this.btnRename = new System.Windows.Forms.Button();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.txtDirPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowserKeyword = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listboxKeyword = new System.Windows.Forms.ListBox();
            this.lblKeywordMcount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(69, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "关键字:";
            // 
            // btnRename
            // 
            this.btnRename.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRename.Location = new System.Drawing.Point(185, 366);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(174, 37);
            this.btnRename.TabIndex = 14;
            this.btnRename.Text = "重 命 名";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(433, 24);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnBrowser.TabIndex = 7;
            this.btnBrowser.Text = "浏  览";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // txtDirPath
            // 
            this.txtDirPath.Location = new System.Drawing.Point(135, 25);
            this.txtDirPath.Name = "txtDirPath";
            this.txtDirPath.Size = new System.Drawing.Size(292, 21);
            this.txtDirPath.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(54, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "文件目录:";
            // 
            // btnBrowserKeyword
            // 
            this.btnBrowserKeyword.Location = new System.Drawing.Point(433, 67);
            this.btnBrowserKeyword.Name = "btnBrowserKeyword";
            this.btnBrowserKeyword.Size = new System.Drawing.Size(75, 23);
            this.btnBrowserKeyword.TabIndex = 7;
            this.btnBrowserKeyword.Text = "浏  览";
            this.btnBrowserKeyword.UseVisualStyleBackColor = true;
            this.btnBrowserKeyword.Click += new System.EventHandler(this.btnBrowserKeyword_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listboxKeyword
            // 
            this.listboxKeyword.FormattingEnabled = true;
            this.listboxKeyword.ItemHeight = 12;
            this.listboxKeyword.Location = new System.Drawing.Point(135, 66);
            this.listboxKeyword.Name = "listboxKeyword";
            this.listboxKeyword.Size = new System.Drawing.Size(292, 256);
            this.listboxKeyword.TabIndex = 15;
            // 
            // lblKeywordMcount
            // 
            this.lblKeywordMcount.AutoSize = true;
            this.lblKeywordMcount.Location = new System.Drawing.Point(133, 334);
            this.lblKeywordMcount.Name = "lblKeywordMcount";
            this.lblKeywordMcount.Size = new System.Drawing.Size(0, 12);
            this.lblKeywordMcount.TabIndex = 16;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 412);
            this.Controls.Add(this.lblKeywordMcount);
            this.Controls.Add(this.listboxKeyword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.btnBrowserKeyword);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.txtDirPath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文本文件批量重命名";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.TextBox txtDirPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowserKeyword;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listboxKeyword;
        private System.Windows.Forms.Label lblKeywordMcount;
    }
}