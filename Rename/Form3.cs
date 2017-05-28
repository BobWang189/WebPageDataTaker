using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Management;

namespace Rename
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //生成一组公钥和私钥，公钥用于你发布程序，私钥属于注册码生成。
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                // 公钥   
                string pubkey = rsa.ToXmlString(false);

                // 私钥   
                string prikey = rsa.ToXmlString(true);

                //如果是webForm就Response.Write(pubkey + ”<br/>” + prikey); 下  
                MessageBox.Show("公钥:" + pubkey + "\r\n私钥:" + prikey);
            }

            //第三步：编写注册码生成WinForm程序，使用CUP的编号来生成注册码，当然你也可以用 WebForm来写。
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString("私钥");
                // 加密对象   
                RSAPKCS1SignatureFormatter f = new RSAPKCS1SignatureFormatter(rsa);
                f.SetHashAlgorithm("SHA1");
                byte[] source = System.Text.ASCIIEncoding.ASCII.GetBytes("CUP的编号");
                SHA1Managed sha = new SHA1Managed();
                byte[] result = sha.ComputeHash(source);

                byte[] b = f.CreateSignature(result);

                msg.Text = Convert.ToBase64String(b); //这里就得到了string形式的注册码  

                //再接下来你可以把生成的注册码保存成license.lic文件，license.lic文件也没什么特别的格式就是相当于把注册吗保存到一个txt文件中，无非这个txt文件的后缀改成了lic，你要高兴也可保存成其它多种格式。  
                //也可以保存在注册表中或是web.config中，总之能让你的发布的应用程序能读的到就行。  
            }

            //第四步：在发布的程序相关地方添加对注册码有效性的验证。如添加在程序启动的时候，程序执行特定操作的时候等等，总之看你的需要做有效性的验证。
            //相关注册码获取代码……  
            //以下代码是发布程序使用公钥对注册码进行验证  
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString("公钥");
                RSAPKCS1SignatureDeformatter f = new RSAPKCS1SignatureDeformatter(rsa);

                f.SetHashAlgorithm("SHA1");

                byte[] key = Convert.FromBase64String("注册码");

                SHA1Managed sha = new SHA1Managed();
                byte[] name = sha.ComputeHash(ASCIIEncoding.ASCII.GetBytes("注册码"));
                if (f.VerifySignature(name, key))
                    msg.Text = "验证成功"; //可以return true;等方式返回相应的状态  
                else
                    msg.Text = "不成功";
            }

        }

        //第二步：取得机器硬件编码。我选用CUP的编号
        /// <summary>  
        /// 获取CPU编号  
        /// </summary>  
        /// <returns></returns>  
        public string GetCpuId()
        {

            ManagementClass mc = new ManagementClass("Win32_Processor");
            ManagementObjectCollection moc = mc.GetInstances();

            String strCpuID = null;
            foreach (ManagementObject mo in moc)
            {
                strCpuID = mo.Properties["ProcessorId"].Value.ToString();
                break;
            }
            return strCpuID;

        }
    }
}
