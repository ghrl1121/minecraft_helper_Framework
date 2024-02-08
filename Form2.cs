using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 마인크래프트도우미_Framework
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //리소스팩
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\resourcepacks"))
            {
                Process.Start(new ProcessStartInfo { FileName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\resourcepacks", UseShellExecute = true });
            }
            else
            {
                //없을경우
                string mames = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\resourcepacks";                          
                MessageBox.Show("리소스팩이 없습니다!");
                File.Create(mames);
                Process.Start(mames);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //서버리소스팩 리셋
            MessageBox.Show("클릭시 서버 리소스팩 리샛 합니다 삭제해도 무관");
            string pathfile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\server-resource-packs";
            if (!Directory.Exists(pathfile))
            {
                File.SetAttributes(pathfile, FileAttributes.Normal);
                File.Delete(pathfile);
            }
        }
    }
}
