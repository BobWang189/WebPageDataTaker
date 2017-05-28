using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Collections;

namespace Rename
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();

            //string url = "http://www.lightfair.com/V40/exhibitor_list/displayEx.cvn?exbid={0}&printfr=true&popup=1";
            //url = String.Format(url, "25736");

            //WebClient MyWebClient = new WebClient();
            //MyWebClient.Credentials = CredentialCache.DefaultCredentials;//获取或设置用于向Internet资源的请求进行身份验证的网络凭据
            //Byte[] pageData = MyWebClient.DownloadData(url); //从指定网站下载数据
            //string pageHtml = Encoding.UTF8.GetString(pageData); //如果获取网站页面采用的是UTF-8，则使用这句

            //int indexFirst = pageHtml.IndexOf("ALPHALITE, INC.");
            //string strFirst = "ALPHALITE, INC.";
            //string strLast = "<td class=\"normal\" valign=\"vertical-align: top;\" style=\"color:black;\">";
            //int indexLast = pageHtml.IndexOf(strLast);

            //string strKeyword = pageHtml.Substring(indexFirst + strFirst.Length + 10, indexLast - indexFirst);

            //strKeyword = strKeyword.Replace("<br />", "");
            //strKeyword = strKeyword.Replace("<td style=\"vertical-align: top;\">", "");
            //strKeyword = strKeyword.Replace("<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" style=\"width: 100%;\">", "");
            //strKeyword = strKeyword.Replace("</td>", "");
            //strKeyword = strKeyword.Replace("</table>", "");
            //strKeyword = strKeyword.Replace("</tr>", "");
            //strKeyword = strKeyword.Replace("<tr>", "");
            //strKeyword = strKeyword.Replace(", &nbsp;", "");
        }

        private void btnBrowserKeyword_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "文本文件(*.txt)|*.txt";

            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = this.openFileDialog1.FileName;

                try
                {
                    Dictionary<string, string> listKeyword = new Dictionary<string, string>();
                    StreamReader sr = new StreamReader(filePath, Encoding.Default);
                    String line = sr.ReadLine();
                    if (!string.IsNullOrEmpty(line))
                    {
                        while ((line = sr.ReadLine()) != null)
                        {
                            string strLine = line.Trim();
                            string str = "javascript:dispEx('";
                            int index = strLine.LastIndexOf("javascript:dispEx('");
                            if (index > 0)
                            {
                                string strKeyword = strLine.Substring(index + str.Length, 5);//编号
                                int strNameIndex = strLine.IndexOf(">");
                                int strNameIndex2 = strLine.LastIndexOf("<");
                                string strName = strLine.Substring(strNameIndex + 1, strNameIndex2 - strNameIndex - 1);//公司名称
                                listKeyword.Add(strKeyword, strName);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("你选择的为空文本文件，请重新选择");
                    }
                    sr.Dispose();

                    if (listKeyword.Count > 0)
                    {
                        ReadKeyword(listKeyword);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("关键字编写规则不符合要求，请以\"逗号\"或\"回车\"分隔你的关键字");
                }
            }
        }
        ArrayList arrarList = new ArrayList();
        DataTable table = new DataTable();
        public void ReadKeyword(Dictionary<string, string> listKeyword)
        {

            string url = "http://www.lightfair.com/V40/exhibitor_list/displayEx.cvn?exbid={0}&printfr=true&popup=1";

            //创建table的第一列 
            DataColumn companyColumn = new DataColumn();
            companyColumn.DataType = System.Type.GetType("System.String");//该列的数据类型 
            companyColumn.ColumnName = "公司名";//该列得名称 
            // 创建table的第二列 
            DataColumn addressColumn = new DataColumn();
            addressColumn.DataType = System.Type.GetType("System.String");
            addressColumn.ColumnName = "地址";//列名 
            // 创建table的第三列 
            DataColumn phoneColumn = new DataColumn();
            phoneColumn.DataType = System.Type.GetType("System.String");
            phoneColumn.ColumnName = "电话";
            // 创建table的第三列 
            DataColumn faxColumn = new DataColumn();
            faxColumn.DataType = System.Type.GetType("System.String");
            faxColumn.ColumnName = "传真";
            // 创建table的第三列 
            DataColumn boothColumn = new DataColumn();
            boothColumn.DataType = System.Type.GetType("System.String");
            boothColumn.ColumnName = "展位号";
            // 将所有的列添加到table上 
            table.Columns.Add(companyColumn);
            table.Columns.Add(addressColumn);
            table.Columns.Add(phoneColumn);
            table.Columns.Add(faxColumn);
            table.Columns.Add(boothColumn);

            foreach (KeyValuePair<string, string> dic in listKeyword)
            {

                string pageUrl = String.Format(url, dic.Key);//Key为编号

                WebClient MyWebClient = new WebClient();
                MyWebClient.Credentials = CredentialCache.DefaultCredentials;//获取或设置用于向Internet资源的请求进行身份验证的网络凭据
                Byte[] pageData = MyWebClient.DownloadData(pageUrl); //从指定网站下载数据
                string pageHtml = Encoding.UTF8.GetString(pageData); //如果获取网站页面采用的是UTF-8，则使用这句

                //int indexFirst = pageHtml.IndexOf(dic.Value);//Value为公司名称
                //string strFirst = "ALPHALITE, INC.";
                //string strLast = "<td class=\"normal\" valign=\"vertical-align: top;\" style=\"color:black;\">";
                //int indexLast = pageHtml.IndexOf(strLast);

                //string strKeyword = pageHtml.Substring(indexFirst + strFirst.Length + 10, indexLast - indexFirst);

                //strKeyword = strKeyword.Replace("<br />", "");
                //strKeyword = strKeyword.Replace("<td style=\"vertical-align: top;\">", "");
                //strKeyword = strKeyword.Replace("<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" style=\"width: 100%;\">", "");
                //strKeyword = strKeyword.Replace("</td>", "");
                //strKeyword = strKeyword.Replace("</table>", "");
                //strKeyword = strKeyword.Replace("</tr>", "");
                //strKeyword = strKeyword.Replace("<tr>", "");
                //strKeyword = strKeyword.Replace(", &nbsp;", "");

                WriteAndReadText(pageHtml, dic.Value);
            }
            //excelHelper.ArrayListToExcel(arrarList, "Company Infomation");
            string folderPath = System.IO.Directory.GetCurrentDirectory() + "\\ReportPostExport\\" + DateTime.Now.ToString("yyyyMMdd") + "\\"; //导出的Excel保存的路径
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            NPOIExcelHelper.DataTableToExcel(table, "公司信息", folderPath + "CompanyInfo.xls");

            MessageBox.Show("提取完成");

            //string filePath = System.AppDomain.CurrentDomain.BaseDirectory + "CompanyInfo.txt";
            //FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);

            //StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding("gb2312"));
            //for (int i = 0; i < arrarList.Count; i++)
            //{
            //    //写入关键字
            //    sw.WriteLine(arrarList[i]);
            //}
            ////清空缓冲区
            //sw.Flush();
            ////关闭流
            //sw.Close();
            //fs.Close();
        }

        private void WriteAndReadText(string info, string companyName)
        {
            //创建一行 
            DataRow row = table.NewRow();
            string filePath = System.AppDomain.CurrentDomain.BaseDirectory + "CompanyInfo.txt";

            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);

            StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding("gb2312"));

            //写入关键字
            sw.WriteLine(info);
            //清空缓冲区
            sw.Flush();
            //关闭流
            sw.Close();
            fs.Close();


            StreamReader sr = new StreamReader(filePath, Encoding.Default);
            String line = sr.ReadLine();
            if (!string.IsNullOrEmpty(line))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    //string strLine = line.Replace("<b>", "");
                    //strLine = line.Replace("</b>", "");
                    string strLine = line.Trim();
                    //string str = "javascript:dispEx('";
                    //int index = strLine.LastIndexOf("javascript:dispEx('");
                    //if (index > 0)
                    //{
                    //    string strKeyword = strLine.Substring(index + str.Length, 5);//编号
                    //    int strNameIndex = strLine.IndexOf(">");
                    //    int strNameIndex2 = strLine.LastIndexOf("<");
                    //    string strName = strLine.Substring(strNameIndex + 1, strNameIndex2 - strNameIndex - 1);//公司名称
                    //    //listKeyword.Add(strKeyword, strName);
                    //}

                    if (strLine == "<b>" + companyName + "</b>")
                    {
                        strLine = strLine.Replace("<b>", "");
                        strLine = strLine.Replace("</b>", "");
                        strLine = strLine.Trim();
                        string rowCompanyName = strLine;//以竖线分隔

                        row["公司名"] = rowCompanyName;
                        //sr.ReadLine();//读取一行，相当于跳过一行
                        //rowInfo += sr.ReadLine().Trim();//详细地址
                        //sr.ReadLine();//读取一行，相当于跳过一行
                        //rowInfo += sr.ReadLine().Trim().Replace(", &nbsp;", "") + " ," + sr.ReadLine().Trim() + " ,";//地址:所在地区+所在州
                        //sr.ReadLine();//读取一行，相当于跳过一行
                        //rowInfo += sr.ReadLine().Trim() + "|";//国家
                        string rowAddress = "";
                        for (int i = 0; i < 10; i++)
                        {
                            if ((strLine = sr.ReadLine().Trim()) == "</td>")
                            {
                                row["地址"] = rowAddress;
                                break;
                            }
                            strLine = strLine.Replace("<br />", "").Replace("&nbsp;", "").Trim();
                            rowAddress += strLine != "" ? ", " + strLine : "";//详细地址
                        }

                    }
                    if (strLine == "Phone")
                    {
                        string rowPhone = sr.ReadLine().Trim();//电话
                        row["电话"] = rowPhone;
                    }
                    if (strLine == "Fax")
                    {
                        string rowFax = sr.ReadLine().Trim();//传值
                        row["传真"] = rowFax;
                    }
                    if (strLine == "<b> BOOTH NUMBERS: </b>")
                    {
                        sr.ReadLine();//读取一行，相当于跳过一行
                        sr.ReadLine();//读取一行，相当于跳过一行
                        string rowBooth = sr.ReadLine().Trim();//展位号
                        row["展位号"] = rowBooth;
                    }
                }
            }
            else
            {
                MessageBox.Show("你选择的为空文本文件，请重新选择");
            }
            sr.Dispose();
            FileInfo fileInfo = new FileInfo(filePath);
            fileInfo.Delete();
            //arrarList.Add(rowInfo);
            table.Rows.Add(row);//将此行添加到table中 
        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            string url = this.txtURL.Text.Trim();

            WebClient MyWebClient = new WebClient();

            MyWebClient.Credentials = CredentialCache.DefaultCredentials;//获取或设置用于向Internet资源的请求进行身份验证的网络凭据

            Byte[] pageData = MyWebClient.DownloadData(url); //从指定网站下载数据
            //string pageHtml = Encoding.Default.GetString(pageData);  //如果获取网站页面采用的是GB2312，则使用这句            

            string pageHtml = Encoding.UTF8.GetString(pageData); //如果获取网站页面采用的是UTF-8，则使用这句


        }
    }
}
