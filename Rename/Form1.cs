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
    public partial class Rename : Form
    {
        public Rename()
        {
            InitializeComponent();
        }

        private void Rename_Load(object sender, EventArgs e)
        {
            this.txtQian.Text = "例如:Love";
            this.txtXu.Text = "例如:100";
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            this.txtDirPath.Text = path.SelectedPath;
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            string strQian = this.txtQian.Text.Trim();
            string strXu = this.txtXu.Text.Trim();

            if (this.txtDirPath.Text.Trim() == "")
            {
                MessageBox.Show("文件目录不能为空");
                return;
            }

            if (!Directory.Exists(this.txtDirPath.Text.Trim()))
            {
                MessageBox.Show("文件目录不存在");
                return;
            }

            if (strXu == "" || strXu == "例如:100")
            {
                MessageBox.Show("前缀和起始序号必须填写一个");
                return;
            }

            int index;
            if (isNumberic(strXu, out index) == false)
            {
                MessageBox.Show("起始序号必须为数字");
                return;
            }

            try
            {
                string[] arrFiles = Directory.GetFiles(this.txtDirPath.Text.Trim());

                for (int i = 0; i < arrFiles.Length; i++)
                {
                    string filePath = arrFiles.GetValue(i).ToString();

                    string dirPath = filePath.Substring(0, filePath.LastIndexOf("\\") + 1);

                    string fileName = filePath.Substring(filePath.LastIndexOf("\\"), filePath.Length - filePath.LastIndexOf("\\"));

                    if (strQian != "" && strXu != "")
                    {
                        if (strQian == "例如:Love")
                            strQian = "";

                        File.Move(filePath, dirPath + strQian + index + ".txt");
                        index++;
                    }
                    else if ((strQian == "" || strQian == "例如:Love") && strXu != "")
                    {
                        strQian = "";
                        File.Move(filePath, dirPath + index + ".txt");
                        index++;
                    }
                }

                MessageBox.Show("重命名成功");
            }
            catch (Exception)
            {
                MessageBox.Show("新文件名与现有目录中的文件名称重名，请更换其它前缀和起始序号");
            }
        }

        protected bool isNumberic(string message, out int result)
        {
            //判断是否为整数字符串
            //是的话则将其转换为数字并将其设为out类型的输出值、返回true, 否则为false
            result = -1;   //result 定义为out 用来输出值
            try
            {
                //当数字字符串的为是少于4时，以下三种都可以转换，任选一种
                //如果位数超过4的话，请选用Convert.ToInt32() 和int.Parse()

                //result = int.Parse(message);
                //result = Convert.ToInt16(message);
                result = Convert.ToInt32(message);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>   
        /// 重命名文件夹内的所有子文件夹   
        /// </summary>   
        /// <param name="directoryName">文件夹名称</param>   
        /// <param name="newDirectoryName">新子文件夹名称格式字符串</param>   
        public void RenameDirectories(string directoryName, string newDirectoryName)
        {
            int i = 1;
            string[] sDirectories = Directory.GetDirectories(directoryName);
            foreach (string sDirectory in sDirectories)
            {
                string sDirectoryName = Path.GetFileName(sDirectory);
                string sNewDirectoryName = string.Format(newDirectoryName, i++);
                string sNewDirectory = Path.Combine(directoryName, sNewDirectoryName);
                Directory.Move(sDirectory, sNewDirectory);
            }
        }

        private void txtQian_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.txtQian.Text.Trim() == "例如:Love")
            {
                this.txtQian.Text = "";
            }
        }

        private void txtXu_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.txtXu.Text.Trim() == "例如:100")
            {
                this.txtXu.Text = "";
            }
        }


    }
}
