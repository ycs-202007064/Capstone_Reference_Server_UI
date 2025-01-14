﻿using Main.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Main.View.Attachment
{
    public partial class FormAnswerGameSetting : Form
    {
        public FormAnswerGameSetting()
        {
            InitializeComponent();
            this.InitializeAttachment();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (tbQuestion.Text.Trim() == String.Empty)
            {
                MessageBox.Show("질문을 입력하세요.", "알림");
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(cbTimeLimit.Text, "[^0-9]") && cbTimeLimit.Text != "없음")
            {
                MessageBox.Show("제한시간을 입력해주세요.");
            }
            else
            {
                OpenGame();
            }
        }

        private void OpenGame()
        {
            //문제
            string question = tbQuestion.Text;


            //시간제한
            int time;
            if (cbTimeLimit.Text == "없음")
            { time = 0; }
            else
            { int.TryParse(cbTimeLimit.Text, out time); }

            //주관식 게임 실행 함수
            Game game = new();
            game.StartAnswerQuiz(question, time);

            var f = Application.OpenForms["FormGamePopup"];
            if (f != null)
            {
                f.Close();
            }
            this.Close();
        }

        private void cbTimeLimit_TextUpdate(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(cbTimeLimit.Text, "[^0-9]"))
            {
                MessageBox.Show("제한시간에는 숫자만 입력할 수 있습니다.","알림");
                cbTimeLimit.Text = cbTimeLimit.Text.Remove(cbTimeLimit.Text.Length - 1);
            }
        }
    }
}
