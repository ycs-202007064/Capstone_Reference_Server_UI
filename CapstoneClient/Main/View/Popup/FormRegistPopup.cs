﻿using Main.Class;
using Main.View.Professor;
using Main.View.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.View.Popup
{
    public partial class FormRegistPopup : Form
    {
        private int connectType = 0;

        //connectType은 CONNECTTYPE.PROFESSOR 혹은 CONNECTTYPE.STUDENT
        //CONNECTTYPE.PROFESSOR일 경우 tbClass는 수업명, tbName은 교수명
        //CONNECTTYPE.STUDENT일 경우 tbClass는 학번, tbName 학생명, tbIP는 IP

        public FormRegistPopup(int connectType)
        {
            InitializeComponent();
            this.InitializePopup();

            this.connectType = connectType;

            if (CONNECTTYPE.PROFESSOR == this.connectType)
            {
                lblIP.Visible = false;
                panIP.Visible = false;
            }
            else if (CONNECTTYPE.STUDENT == this.connectType)
            {
                this.Text = "학생으로 접속";
                lblClass.Text = "학번";
                lblName.Text = "학생명";
            }

            //접속 정보 수신 시 호출할 이벤트 등록
            //Event+=OnConnected;
        }

        private void OnConnected()
        {
            //static 클래스인 ConnectInfo의 값을 설정함
            ConnectInfo.Type = CONNECTTYPE.STUDENT;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (CONNECTTYPE.PROFESSOR == this.connectType)
            {
                //과목명 혹은 교수명이 공백일 때 알림
                if (tbName.Text.Trim() == "")
                {
                    MessageBox.Show("교수명을 입력하세요!", "알림");
                    return;
                }
                else if (tbClass.Text.Trim() == "")
                {
                    MessageBox.Show("과목명을 입력하세요!", "알림");
                    return;
                }

                //테스트용, 접속 정보를 교수로 설정함
                ConnectInfo.Type = CONNECTTYPE.PROFESSOR;

                //접속 정보를 송신하고 대기, 응답이 오면 새 창을 띄움
                if (!SendConnectRequestAndWait())
                {
                    MessageBox.Show("연결에 실패했습니다.", "알림");
                    return;
                }

                FormProfessor form = new();
                form.Load += new EventHandler(CloseWindow);
                form.FormClosed += new FormClosedEventHandler(CloseMainWindow);
                form.Show();
                return;
            }
            else //(CONNECTTYPE.STUDENT == this.connectType)
            {
                //학생명 또는 과목코드가 공백일 때 알림
                if (tbName.Text.Trim() == "")
                {
                    MessageBox.Show("학생명을 입력하세요!", "알림");
                    return;
                }
                else if (tbClass.Text.Trim() == "")
                {
                    MessageBox.Show("학번을 입력하세요!", "알림");
                    return;
                }
                else if (tbIP.Text.Trim() == "")
                {
                    MessageBox.Show("IP를 입력하세요!", "알림");
                    return;
                }

                int i;
                if (int.TryParse(tbClass.Text, out i) == false)
                {
                    MessageBox.Show("학번에는 숫자만 입력할 수 있습니다.", "알림");
                    return;
                }
                else if (i < 0)
                {
                    MessageBox.Show("유효한 학번을 입력하세요.", "알림");
                    return;
                }

                //테스트용, 접속 정보를 교수로 설정함
                ConnectInfo.Type = CONNECTTYPE.STUDENT;

                //접속 정보를 송신하고 대기, 응답이 오면 새 창을 띄움
                if (!SendConnectRequestAndWait())
                {
                    MessageBox.Show("연결에 실패했습니다.", "알림");
                    return;
                }

                FormStudent form = new();
                form.Load += new EventHandler(CloseWindow);
                form.FormClosed += new FormClosedEventHandler(CloseMainWindow);
                form.Show();
                return;
            }
        }

        private void CloseWindow(object? sender, EventArgs e)
        {
            FormRegist.Instance.Visible = false;
            this.Close();
        }

        private void CloseMainWindow(object? sender, EventArgs e)
        {
            FormRegist.Instance.Close();
        }

        private bool SendConnectRequestAndWait()
        {
            btnConnect.Enabled = false;
            if (CONNECTTYPE.PROFESSOR == this.connectType)
            {
                ServerSystem.ServerSystem server = new();
                //ClientContainer.Instance.setOwner();
                Task.Delay(50).Wait();
                ConnectInfo.user = new ClientSystem.ClientSystem();
                //ConnectInfo.user.Login(-1, tbName.Text, String.Empty);
                ConnectInfo.InitializeProfessor(tbClass.Text, tbName.Text);
            }
            else //(CONNECTTYPE.STUDENT == this.connectType)
            {
                int i = 0;
                if (int.TryParse(tbClass.Text, out i))
                    ConnectInfo.ID = i;
                else
                    return false;

                ConnectInfo.user = new ClientSystem.ClientSystem();
                Task.Delay(50).Wait();
                ConnectInfo.user.Login(ConnectInfo.ID, tbName.Text, string.Empty);
                ConnectInfo.InitializeStudent(i, tbName.Text);
            }
            //응답 대기
            btnConnect.Enabled = true;
            return true;
        }
    }
}
