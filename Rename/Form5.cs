using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace Rename
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.listboxKeyword.Items.Count == 0)
            {
                MessageBox.Show("请选导入要搜索的关键字");
                return;
            }

            this.btnSearch.Enabled = false;//禁用搜索按钮

            try
            {
                WebClient MyWebClient = new WebClient();

                MyWebClient.Credentials = CredentialCache.DefaultCredentials;//获取或设置用于向Internet资源的请求进行身份验证的网络凭据

                ListBox.ObjectCollection listKeywords = this.listboxKeyword.Items;
                this.listboxIllegalKeyword.Items.Clear();
                this.listboxLegalKeyword.Items.Clear();

                //http://www.haosou.com/s?ie=utf-8&shb=1&src=360sou_newhome&q=你好
                //http://www.sogou.com/sogou?pid=sogou-site-e16e74a63567ecb4-3009&ie=utf-8&query=北京通州积分落户

                string tempUrl = "";

                if (this.rdobtnBaidu.Checked)
                {
                    tempUrl = "http://www.baidu.com/s?wd={0}&ie=utf-8";
                }
                else if (this.rdobtnHaosou.Checked)
                {
                    tempUrl = "http://www.haosou.com/s?ie=utf-8&shb=1&src=360sou_newhome&q={0}";
                }
                else if (this.rdobtnSogou.Checked)
                {
                    tempUrl = "http://www.sogou.com/sogou?pid=sogou-site-e16e74a63567ecb4-3009&ie=utf-8&query={0}";
                }

                foreach (var item in listKeywords)
                {
                    string url = String.Format(tempUrl, item.ToString());
                    Byte[] pageData = MyWebClient.DownloadData(url); //从指定网站下载数据
                    //string pageHtml = Encoding.Default.GetString(pageData);  //如果获取网站页面采用的是GB2312，则使用这句            

                    string pageHtml = Encoding.UTF8.GetString(pageData); //如果获取网站页面采用的是UTF-8，则使用这句

                    if (pageHtml.Contains("根据相关法律法规和政策，部分搜索结果未予显示"))
                    {
                        this.listboxIllegalKeyword.Items.Add(item);
                    }
                    else
                    {
                        this.listboxLegalKeyword.Items.Add(item);
                    }
                }

                this.lblIllegalInfo.Text = "不合法 " + this.listboxIllegalKeyword.Items.Count + " 个";
                this.lblIllegalInfo.ForeColor = Color.Red;

                this.lblLegalInfo.Text = "合法 " + this.listboxLegalKeyword.Items.Count + " 个";
                this.lblLegalInfo.ForeColor = Color.Green;

                MessageBox.Show("搜索完成");
            }
            catch (WebException webEx)
            {
                Console.WriteLine(webEx.Message.ToString());
            }

            this.btnSearch.Enabled = true;//启用搜索按钮
        }

        private void btnExportIllegalKeyword_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.Filter = "文本文件(*.txt)|*.txt";
            //this.openFileDialog1.Title = "导出不合法关键字";
            //this.openFileDialog1.FileName = "文本文件";

            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = this.saveFileDialog1.FileName;

                    if (!File.Exists(filePath))
                    {
                        FileStream fsFile = File.Create(filePath);
                        fsFile.Close();
                    }
                    else
                    {
                        File.Delete(filePath);
                        FileStream fsFile = File.Create(filePath);
                        fsFile.Close();
                    }

                    StreamReader sr = new StreamReader(filePath, Encoding.GetEncoding("gb2312"));

                    String allText = sr.ReadToEnd();

                    sr.Dispose();//关闭文件流

                    FileStream fs = new FileStream(filePath, FileMode.Open);

                    StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding("gb2312"));

                    ListBox.ObjectCollection listIllegalKeywords = this.listboxIllegalKeyword.Items;

                    foreach (var item in listIllegalKeywords)
                    {
                        //写入关键字
                        sw.Write(item.ToString() + "\r\n");
                    }

                    //清空缓冲区
                    sw.Flush();

                    //关闭流
                    sw.Close();
                    fs.Close();

                    MessageBox.Show("导出成功");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btnExportLegalKeyword_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.Filter = "文本文件(*.txt)|*.txt";
            //this.openFileDialog1.Title = "导出不合法关键字";
            //this.openFileDialog1.FileName = "文本文件";

            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = this.saveFileDialog1.FileName;

                    if (!File.Exists(filePath))
                    {
                        FileStream fsFile = File.Create(filePath);
                        //fs.Dispose();
                        fsFile.Close();
                    }
                    else
                    {
                        File.Delete(filePath);
                        FileStream fsFile = File.Create(filePath);
                        fsFile.Close();
                    }

                    StreamReader sr = new StreamReader(filePath, Encoding.GetEncoding("gb2312"));

                    String allText = sr.ReadToEnd();

                    sr.Dispose();//关闭文件流

                    FileStream fs = new FileStream(filePath, FileMode.Open);

                    StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding("gb2312"));

                    ListBox.ObjectCollection listIllegalKeywords = this.listboxLegalKeyword.Items;

                    foreach (var item in listIllegalKeywords)
                    {
                        //写入关键字
                        sw.Write(item.ToString() + "\r\n");
                    }

                    //清空缓冲区
                    sw.Flush();

                    //关闭流
                    sw.Close();
                    fs.Close();

                    MessageBox.Show("导出成功");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }


    }
}
