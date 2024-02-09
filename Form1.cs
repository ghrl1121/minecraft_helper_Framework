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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //실행
            if (Directory.Exists(@"C:\XboxGames\Minecraft Launcher\Content"))
            {
                //xboxGames
                Process.Start(@"C:\XboxGames\Minecraft Launcher\Content\gamelaunchhelper.exe");
            }
            else if (Directory.Exists(@"C:\Program Files (x86)\Minecraft Launcher"))
            {
                //Program Files (x86)
                Process.Start(@"C:\Program Files (x86)\Minecraft Launcher\MinecraftLauncher.exe");
            }
            else
            {
                //파일이 없을경우
                MessageBox.Show("마인크래프트를 설치 하셔아 합니다!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //맵
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\saves"))
            {
                MessageBox.Show("맵 파일 입니다!");
                Process.Start(new ProcessStartInfo { FileName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\saves", UseShellExecute = true });
            }
            else
            {
                MessageBox.Show("실행 먼저 해주세요!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //모드
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\mods"))
            {
                //있을경우
                Process.Start(new ProcessStartInfo { FileName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\mods", UseShellExecute = true });
            }
            else
            {
                //없을경우 폴더 생성 + 경고 (forge 설치 또는 Fabric 설치 알림)
                MessageBox.Show("포지 또는 패브릭 을 설치하셔야 됩니다!");
                string mesps = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\mods";
                File.Create(mesps);
                Process.Start(new ProcessStartInfo { FileName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\mods", UseShellExecute = true });
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //스크린샷
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\screenshots"))
            {
                Process.Start(new ProcessStartInfo { FileName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\screenshots", UseShellExecute = true });
            }
            else
            {
                MessageBox.Show("스크린샷(F2) 하시거나 실행 먼저 해 주세요!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //리소스팩
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //로그
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\logs"))
            {
                Process.Start(new ProcessStartInfo { FileName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\logs", UseShellExecute = true });
            }
            else
            {
                MessageBox.Show("로그파일이 없습니다!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //세이더
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\shaderpacks"))
            {
                Process.Start(new ProcessStartInfo { FileName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\shaderpacks", UseShellExecute = true });
            }
            //파일이 없을경우 옵티파인 또는 나트륨 필요 알림
            else
            {
                MessageBox.Show("옵티파인(모드) 또는 나트륨(모드)을 설치하셔야 합니다!\n\r또는 실행이 필요합니다!");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/ghrl1121/minecraft_helper_Framework");
        }
    }
}
