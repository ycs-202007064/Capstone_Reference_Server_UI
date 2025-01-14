﻿using Main.Class;
using Main.View.Popup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.View.Professor
{
    public partial class FormProfessor : Form
    {
        //레이블의 기본 문자열
        private string lblNameDef = "";         //교수명
        private string lblClassNameDef = "";    //수업명
        private string lblIPDef = "";         //IP
        private int chat_move = 0; //chat 이동방향 1:아래  2:위  3:아래->위
        private int quiz_move = 0; //quiz 이동방향 1:아래  2:위  3:아래->위
        private int chat_num = 0; //chat 이동범위
        private int quiz_num = 0; //quiz 이동범위
        private int check = 0;

        //48, 56, 80
        public FormProfessor()
        {
            InitializeComponent();
            this.InitializeMain();
            //레이블의 기본 문자열 설정
            lblNameDef = lblName.Text + " ";
            lblClassNameDef = lblClassName.Text + " ";
            lblIPDef = lblIP.Text + " " ;


        


            if (ConnectInfo.user != null)
            {
                lblName.Text = lblNameDef + ConnectInfo.user.name;
            }
            lblClassName.Text = lblClassNameDef + ConnectInfo.ClassName;
            lblIP.Text = lblIPDef + GetLocalIP();
        }

        private string GetLocalIP()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            string IP = string.Empty;
            foreach (var i in host.AddressList)
            {
                if (i.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    IP = i.ToString();
                    break;
                }
            }
            return IP;
        }
      
        private void openChat()
        {
            var form = Application.OpenForms["FormChatPopup"];
            if (form == null)
            {
                form = new FormChatPopup();
            }
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            form.Focus();
        }
		private void openGame()
		{
            var form1 = Application.OpenForms["GameServerForm"];
            if (form1 != null)
            {
                MessageBox.Show("게임 서버가 구동 중입니다.", "알림");
                return;
            }

            var form = Application.OpenForms["FormGamePopup"];
			if (form == null)
			{
				form = new FormGamePopup();
			}
			form.StartPosition = FormStartPosition.CenterScreen;
			form.Show();
			form.Focus();
		}

		private void FormProfessor_FormClosed(object sender, FormClosedEventArgs e)
		{
            ServerSystem.ServerSystem.Stop();
		}


        //Chat 부분
        private void timer1_Tick(object sender, EventArgs e)
        {
            //아래로
            if (chat_move ==1)
            {              
                if (chat_num - 100 < -75)
                {
                    chat_num+=2;
                    pbChat.Location = new Point(108, -75 + chat_num);
                }
            }

            //위로
            if (chat_move == 2)
            {
              
                if (chat_num - 100 > -100)
                {
                    chat_num-=2;
                    pbChat.Location = new Point(108, -75 + chat_num);
                }
                else { timer1.Enabled = false; }
            }

            if (chat_move == 3)
            {
                if ((chat_num - 100 < -50) && check == 0)//아래로
                {
                    chat_num +=3;
                    pbChat.Location = new Point(108, -75 + chat_num);
                    if((chat_num - 100) >= -50) { check = 1; }
                }
                else if ((chat_num - 100 > -490) && check == 1)//위로
                {
                    chat_num -=10;
                    pbChat.Location = new Point(108, -75 + chat_num);
                }
                else
                {
                    timer1.Enabled = false;
                    chat_move = 0;
                    check = 0;
                    chat_num = 0;
                    openChat();
                }
            }

        }







        private void timer2_Tick(object sender, EventArgs e)
        {
            //아래로
            if (quiz_move == 1)
            {             
                if (quiz_num - 151 < -126)
                {
                    quiz_num+=2;
                    pbQuiz.Location = new Point(348, -113 + quiz_num);
                }
            }


            //위로
            if (quiz_move == 2)
            {
                if (quiz_num - 151 > -151)
                {
                    quiz_num-=2;
                    pbQuiz.Location = new Point(348, -113 + quiz_num);
                }
                else { timer2.Enabled = false; }
            }

            if (quiz_move == 3)
            {
                if ((quiz_num - 151 < -91) && check == 0)//아래로
                {
                    quiz_num += 3;
                    pbQuiz.Location = new Point(348, -113 + quiz_num);
                    if ((quiz_num - 151) >= -91) { check = 1; }
                }
                else if ((quiz_num - 151 > -490) && check == 1)//위로
                {
                    quiz_num -= 10;
                    pbQuiz.Location = new Point(348, -113 + quiz_num);
                }
                else
                {
                    timer2.Enabled =  false;
                    quiz_move = 0;
                    check = 0;
                    quiz_num = 0;
                    openGame();
                }
            }
        }
       

        private void pbChat_MouseEnter(object sender, EventArgs e)
        {
            //아래로
            if (chat_move != 3 && quiz_move != 3)
            {
                chat_move = 1;
                timer1.Enabled = true;
            }
        }

        private void pbChat_MouseLeave(object sender, EventArgs e)
        {
            //위로
            if (chat_move != 3 && quiz_move != 3)
            {
                chat_move = 2;
                timer1.Enabled = true;
            }
        }

        private void pbChat_Click(object sender, EventArgs e)
        {
            //아래 ->위
            if (chat_move != 3 && quiz_move != 3)
            {
                chat_move = 3;
                timer1.Enabled = true;
            }
        }

        private void pbQuiz_MouseEnter(object sender, EventArgs e)
        {
       
            //아래로
            if (chat_move != 3 && quiz_move != 3)
            {
                quiz_move = 1;
                timer2.Enabled = true;
            }
        }

        private void pbQuiz_MouseLeave(object sender, EventArgs e)
        {
            //위로
            if (chat_move != 3 && quiz_move != 3)
            {
                quiz_move = 2;
                timer2.Enabled = true;
            }
        }

        private void pbQuiz_Click(object sender, EventArgs e)
        {
            //아래->위
            if (chat_move != 3 && quiz_move != 3)
            {
                quiz_move = 3;
                timer2.Enabled = true;
            }
        }



        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            //채팅 원위치
            if (chat_move ==0)
            {
                pbChat.Location = new Point(108, -75);             
            }
            //퀴즈 원위치
            if ( quiz_move ==0)
            {
                
                pbQuiz.Location = new Point(348, -113);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openUserList();
        }

        private void openUserList()
        {
            var form = Application.OpenForms["FormUserListPopup"];
            if (form == null)
            {
                form = new FormUserListPopup();
            }
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            form.Focus();
        }
    }
}
