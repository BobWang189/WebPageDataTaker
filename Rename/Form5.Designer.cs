namespace Rename
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.listboxKeyword = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowserKeyword = new System.Windows.Forms.Button();
            this.listboxIllegalKeyword = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listboxLegalKeyword = new System.Windows.Forms.ListBox();
            this.btnExportIllegalKeyword = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblKeywordMcount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExportLegalKeyword = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lblIllegalInfo = new System.Windows.Forms.Label();
            this.lblLegalInfo = new System.Windows.Forms.Label();
            this.rdobtnBaidu = new System.Windows.Forms.RadioButton();
            this.rdobtnHaosou = new System.Windows.Forms.RadioButton();
            this.rdobtnSogou = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listboxKeyword
            // 
            this.listboxKeyword.FormattingEnabled = true;
            this.listboxKeyword.ItemHeight = 12;
            this.listboxKeyword.Location = new System.Drawing.Point(15, 32);
            this.listboxKeyword.Name = "listboxKeyword";
            this.listboxKeyword.Size = new System.Drawing.Size(292, 340);
            this.listboxKeyword.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "导入要搜索关键字:";
            // 
            // btnBrowserKeyword
            // 
            this.btnBrowserKeyword.Location = new System.Drawing.Point(232, 6);
            this.btnBrowserKeyword.Name = "btnBrowserKeyword";
            this.btnBrowserKeyword.Size = new System.Drawing.Size(75, 23);
            this.btnBrowserKeyword.TabIndex = 16;
            this.btnBrowserKeyword.Text = "浏  览";
            this.btnBrowserKeyword.UseVisualStyleBackColor = true;
            this.btnBrowserKeyword.Click += new System.EventHandler(this.btnBrowserKeyword_Click);
            // 
            // listboxIllegalKeyword
            // 
            this.listboxIllegalKeyword.FormattingEnabled = true;
            this.listboxIllegalKeyword.ItemHeight = 12;
            this.listboxIllegalKeyword.Location = new System.Drawing.Point(322, 32);
            this.listboxIllegalKeyword.Name = "listboxIllegalKeyword";
            this.listboxIllegalKeyword.Size = new System.Drawing.Size(292, 340);
            this.listboxIllegalKeyword.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(319, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "不合法关键字:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(627, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "合法关键字:";
            // 
            // listboxLegalKeyword
            // 
            this.listboxLegalKeyword.FormattingEnabled = true;
            this.listboxLegalKeyword.ItemHeight = 12;
            this.listboxLegalKeyword.Location = new System.Drawing.Point(630, 32);
            this.listboxLegalKeyword.Name = "listboxLegalKeyword";
            this.listboxLegalKeyword.Size = new System.Drawing.Size(292, 340);
            this.listboxLegalKeyword.TabIndex = 19;
            // 
            // btnExportIllegalKeyword
            // 
            this.btnExportIllegalKeyword.Location = new System.Drawing.Point(495, 6);
            this.btnExportIllegalKeyword.Name = "btnExportIllegalKeyword";
            this.btnExportIllegalKeyword.Size = new System.Drawing.Size(119, 23);
            this.btnExportIllegalKeyword.TabIndex = 16;
            this.btnExportIllegalKeyword.Text = "导出不合法关键字";
            this.btnExportIllegalKeyword.UseVisualStyleBackColor = true;
            this.btnExportIllegalKeyword.Click += new System.EventHandler(this.btnExportIllegalKeyword_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.Location = new System.Drawing.Point(370, 397);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(205, 40);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "执 行 搜 索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblKeywordMcount
            // 
            this.lblKeywordMcount.AutoSize = true;
            this.lblKeywordMcount.Location = new System.Drawing.Point(19, 382);
            this.lblKeywordMcount.Name = "lblKeywordMcount";
            this.lblKeywordMcount.Size = new System.Drawing.Size(0, 12);
            this.lblKeywordMcount.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(15, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 12);
            this.label4.TabIndex = 21;
            this.label4.Text = "关键字请以逗号和回号符分隔后存放于txt文件中";
            // 
            // btnExportLegalKeyword
            // 
            this.btnExportLegalKeyword.Location = new System.Drawing.Point(799, 6);
            this.btnExportLegalKeyword.Name = "btnExportLegalKeyword";
            this.btnExportLegalKeyword.Size = new System.Drawing.Size(119, 23);
            this.btnExportLegalKeyword.TabIndex = 16;
            this.btnExportLegalKeyword.Text = "导出合法关键字";
            this.btnExportLegalKeyword.UseVisualStyleBackColor = true;
            this.btnExportLegalKeyword.Click += new System.EventHandler(this.btnExportLegalKeyword_Click);
            // 
            // lblIllegalInfo
            // 
            this.lblIllegalInfo.AutoSize = true;
            this.lblIllegalInfo.Location = new System.Drawing.Point(326, 382);
            this.lblIllegalInfo.Name = "lblIllegalInfo";
            this.lblIllegalInfo.Size = new System.Drawing.Size(0, 12);
            this.lblIllegalInfo.TabIndex = 20;
            // 
            // lblLegalInfo
            // 
            this.lblLegalInfo.AutoSize = true;
            this.lblLegalInfo.Location = new System.Drawing.Point(635, 382);
            this.lblLegalInfo.Name = "lblLegalInfo";
            this.lblLegalInfo.Size = new System.Drawing.Size(0, 12);
            this.lblLegalInfo.TabIndex = 20;
            // 
            // rdobtnBaidu
            // 
            this.rdobtnBaidu.AutoSize = true;
            this.rdobtnBaidu.Checked = true;
            this.rdobtnBaidu.Location = new System.Drawing.Point(49, 13);
            this.rdobtnBaidu.Name = "rdobtnBaidu";
            this.rdobtnBaidu.Size = new System.Drawing.Size(47, 16);
            this.rdobtnBaidu.TabIndex = 22;
            this.rdobtnBaidu.TabStop = true;
            this.rdobtnBaidu.Text = "百度";
            this.rdobtnBaidu.UseVisualStyleBackColor = true;
            // 
            // rdobtnHaosou
            // 
            this.rdobtnHaosou.AutoSize = true;
            this.rdobtnHaosou.Location = new System.Drawing.Point(122, 14);
            this.rdobtnHaosou.Name = "rdobtnHaosou";
            this.rdobtnHaosou.Size = new System.Drawing.Size(47, 16);
            this.rdobtnHaosou.TabIndex = 22;
            this.rdobtnHaosou.Text = "好搜";
            this.rdobtnHaosou.UseVisualStyleBackColor = true;
            // 
            // rdobtnSogou
            // 
            this.rdobtnSogou.AutoSize = true;
            this.rdobtnSogou.Location = new System.Drawing.Point(193, 14);
            this.rdobtnSogou.Name = "rdobtnSogou";
            this.rdobtnSogou.Size = new System.Drawing.Size(47, 16);
            this.rdobtnSogou.TabIndex = 22;
            this.rdobtnSogou.Text = "搜狗";
            this.rdobtnSogou.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdobtnHaosou);
            this.panel1.Controls.Add(this.rdobtnSogou);
            this.panel1.Controls.Add(this.rdobtnBaidu);
            this.panel1.Location = new System.Drawing.Point(630, 398);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 40);
            this.panel1.TabIndex = 23;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 458);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblLegalInfo);
            this.Controls.Add(this.lblIllegalInfo);
            this.Controls.Add(this.lblKeywordMcount);
            this.Controls.Add(this.listboxLegalKeyword);
            this.Controls.Add(this.listboxIllegalKeyword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listboxKeyword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExportLegalKeyword);
            this.Controls.Add(this.btnExportIllegalKeyword);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnBrowserKeyword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "百度,好搜,搜狗关键字非法合法判断";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listboxKeyword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowserKeyword;
        private System.Windows.Forms.ListBox listboxIllegalKeyword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listboxLegalKeyword;
        private System.Windows.Forms.Button btnExportIllegalKeyword;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblKeywordMcount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExportLegalKeyword;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lblIllegalInfo;
        private System.Windows.Forms.Label lblLegalInfo;
        private System.Windows.Forms.RadioButton rdobtnBaidu;
        private System.Windows.Forms.RadioButton rdobtnHaosou;
        private System.Windows.Forms.RadioButton rdobtnSogou;
        private System.Windows.Forms.Panel panel1;
    }
}