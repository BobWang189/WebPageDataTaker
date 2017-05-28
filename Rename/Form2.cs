using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Rename
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            this.txtDirPath.Text = path.SelectedPath;
        }

        private void btnBrowserKeyword_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "文本文件(*.txt)|*.txt";

            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = this.openFileDialog1.FileName;

                try
                {
                    StreamReader sr = new StreamReader(filePath, Encoding.Default);
                    String line = sr.ReadLine();
                    if (!string.IsNullOrEmpty(line))
                    {
                        this.listboxKeyword.Items.Clear();

                        string[] arrKeyword = line.Split(',');
                        if (arrKeyword.Length > 1)
                        {
                            for (int i = 0; i < arrKeyword.Length; i++)
                            {
                                this.listboxKeyword.Items.Add(arrKeyword.GetValue(i).ToString().Trim());
                            }
                        }
                        else
                        {
                            this.listboxKeyword.Items.Add(line.ToString().Trim());
                            while ((line = sr.ReadLine()) != null)
                            {
                                this.listboxKeyword.Items.Add(line.ToString().Trim());
                            }
                        }
                        this.lblKeywordMcount.Text = "共 " + this.listboxKeyword.Items.Count + " 个关键字";
                    }
                    else
                    {
                        MessageBox.Show("你选择的为空文本文件，请重新选择");
                    }
                    sr.Dispose();
                }
                catch (Exception)
                {
                    MessageBox.Show("关键字编写规则不符合要求，请以\"逗号\"或\"回车\"分隔你的关键字");
                }
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            if (this.txtDirPath.Text.Trim() == "")
            {
                MessageBox.Show("文件目录不能为空");
                return;
            }

            if (this.listboxKeyword.Items.Count == 0)
            {
                MessageBox.Show("关键字不能为空");
                return;
            }

            try
            {
                string[] arrFiles = Directory.GetFiles(this.txtDirPath.Text.Trim());

                int txtCount = 0;

                for (int i = 0; i < arrFiles.Length; i++)
                {
                    string filePath = arrFiles.GetValue(i).ToString();//获取文件目录

                    string dirPath = filePath.Substring(0, filePath.LastIndexOf("\\") + 1);//获取文件目录,不包含文件名

                    string filePostfixName = filePath.Substring(filePath.LastIndexOf("."), filePath.Length - filePath.LastIndexOf("."));//获取文件后缀名

                    if (filePostfixName.ToLower() == ".txt")
                    {
                        txtCount++;

                        ListBox.ObjectCollection listKeyword = this.listboxKeyword.Items;

                        if (listboxKeyword.Items.Count >= i + 1)
                        {
                            string keyword = listboxKeyword.Items[i].ToString();

                            string newFilePath = dirPath + keyword + ".txt";//重命名后的文件全路径

                            File.Move(filePath, newFilePath);

                            StreamReader sr = new StreamReader(newFilePath, Encoding.GetEncoding("gb2312"));

                            String allText = sr.ReadToEnd();

                            sr.Dispose();//关闭文件流

                            FileStream fs = new FileStream(newFilePath, FileMode.Open);

                            StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding("gb2312"));

                            //写入文件名
                            sw.Write(listboxKeyword.Items[i].ToString() + "\r\n");

                            //写入原有的文本内容
                            sw.Write(allText);

                            //清空缓冲区
                            sw.Flush();

                            //关闭流
                            sw.Close();
                            fs.Close();

                        }
                        else
                        {
                            MessageBox.Show("共重命名 " + i + " 个文件，关键字已用完，请补充关键字以进行剩余文件的重命名");
                        }
                    }

                }

                if (txtCount == 0)
                    MessageBox.Show("你选择的文件目录中不包含txt文件，请重新选择文件目录");
                else
                    MessageBox.Show("重命名成功，共完成 " + txtCount + " 个文件的重命名");
            }
            catch (Exception ex)
            {
                //当文件已存在时，无法创建该文件。
                if (ex.Message == "当文件已存在时，无法创建该文件。")
                {
                    MessageBox.Show("你选择的文件目录中已存在与将要命名的文件名重名的文件");
                }
                else
                {
                    MessageBox.Show("系统出错，请联系软件编写者");
                }
            }
        }




    }
}
