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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            this.txtDirPath.Text = path.SelectedPath;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string directoryName = this.txtDirPath.Text.Trim();
            string targetDirName = this.txtTargetName.Text.Trim();
            if (directoryName == "")
            {
                MessageBox.Show("目标目录不能为空");
                return;
            }
            if (!Directory.Exists(directoryName))
            {
                MessageBox.Show("目标目录不存在");
                return;
            }
            if (targetDirName == "")
            {
                MessageBox.Show("定位文件名不能为空");
                return;
            }

            this.listboxKeyword.Items.Clear();

            string[] sDirectories = Directory.GetDirectories(directoryName);
            foreach (string sDirectory in sDirectories)
            {
                string sTargetDirName = sDirectory + "\\" + targetDirName;

                DirectoryInfo direInfo = new DirectoryInfo(sTargetDirName);

                if (direInfo.Attributes != FileAttributes.Hidden && Directory.Exists(sTargetDirName))
                {
                    this.listboxKeyword.Items.Add(sTargetDirName);
                }
            }

            this.lblInfo.Text = "共查找到 " + this.listboxKeyword.Items.Count + " 个目录";
        }

        private void btnBrowseReplace_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            this.txtReplaceDir.Text = path.SelectedPath;
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            string replaceDir = this.txtReplaceDir.Text.Trim();
            string targetDir = this.txtTargetName.Text.Trim();
            if (replaceDir == "")
            {
                MessageBox.Show("替换目录不能为空");
                return;
            }
            if (!Directory.Exists(replaceDir))
            {
                MessageBox.Show("替换目录不存在");
                return;
            }
            if (this.listboxKeyword.Items.Count == 0)
            {
                MessageBox.Show("请先点击\"查找按钮\"查找目录");
                return;
            }

            try
            {
                string replaceDirName = replaceDir.Substring(replaceDir.LastIndexOf("\\") + 1, replaceDir.Length - replaceDir.LastIndexOf("\\") - 1);
                string targetDirName = targetDir.Substring(targetDir.LastIndexOf("\\") + 1, targetDir.Length - targetDir.LastIndexOf("\\") - 1);
                if (replaceDirName != targetDirName)
                {
                    MessageBox.Show("目标目录与查找出的目录不一致");
                    return;
                }

                foreach (var item in this.listboxKeyword.Items)
                {
                    //拷贝文件
                    //string[] arrFile = Directory.GetFiles(replaceDir);

                    //for (int i = 0; i < arrFile.Length; i++)
                    //{
                    //    string filePath = arrFile.GetValue(i).ToString();
                    //    string fileName = filePath.Substring(filePath.LastIndexOf("\\") + 1, filePath.Length - filePath.LastIndexOf("\\") - 1);
                    //    File.Copy(filePath, item.ToString() + "\\" + fileName, true);
                    //}

                    //拷贝文件夹
                    //CopyDirectory(replaceDir, item.ToString());

                    //删除查找到的根目录文件夹后，再拷贝文件夹过去
                    //Directory.Delete(item.ToString(), true);
                    string[] arrFiles = Directory.GetFiles(item.ToString());
                    for (int i = 0; i < arrFiles.Length; i++)
                    {
                        File.Delete(arrFiles.GetValue(i).ToString());
                    }

                    CopyDirectory(replaceDir, item.ToString().Substring(0, item.ToString().LastIndexOf("\\")));
                }

                MessageBox.Show("替换完成");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        /// <summary>
        /// 拷贝文件夹
        ///By Wang Hw  www.pegete.com.cn 
        /// </summary>
        /// <param name="srcdir"></param>
        /// <param name="desdir"></param>
        private void CopyDirectory(string srcdir, string desdir)
        {
            string folderName = srcdir.Substring(srcdir.LastIndexOf("\\") + 1);

            string desfolderdir = desdir + "\\" + folderName;

            //D:\\bb
            if (desdir.LastIndexOf("\\") == (desdir.Length - 1))
            {
                desfolderdir = desdir + folderName;
            }
            string[] filenames = Directory.GetFileSystemEntries(srcdir);

            foreach (string file in filenames)// 遍历所有的文件和目录
            {
                if (Directory.Exists(file))// 先当作目录处理如果存在这个目录就递归Copy该目录下面的文件
                {

                    string currentdir = desfolderdir + "\\" + file.Substring(file.LastIndexOf("\\") + 1);
                    if (!Directory.Exists(currentdir))
                    {
                        Directory.CreateDirectory(currentdir);
                    }

                    CopyDirectory(file, desfolderdir);
                }
                else // 否则直接copy文件
                {
                    string srcfileName = file.Substring(file.LastIndexOf("\\") + 1);

                    srcfileName = desfolderdir + "\\" + srcfileName;

                    if (!Directory.Exists(desfolderdir))
                    {
                        Directory.CreateDirectory(desfolderdir);
                    }

                    File.Copy(file, srcfileName, true);
                }
            }//foreach
        }//function end


    }
}
