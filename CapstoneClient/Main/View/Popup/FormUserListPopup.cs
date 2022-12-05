﻿using Main.Class;
using ServerSystem;
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
    public partial class FormUserListPopup : Form
    {
        public FormUserListPopup()
        {
            InitializeComponent();
            this.InitializePopup();

            foreach (var item in ClientContainer.Instance.loginDict)
            {
                string[] items = new string[] { item.Key.ToString(), item.Value.name}; 
                ListViewItem lvitem = new(items);
                listView1.Items.Add(lvitem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ClientContainer.Instance.blockSend == false)
            {
                DisableChat();
            }
            else
            {
                EnableChat();
            }
        }

        private void EnableChat()
        {
            lblChatable.Text = "채팅 허용됨";
            lblChatable.ForeColor = Color.Black;
            if (ConnectInfo.server!=null)
                ConnectInfo.server.SetMessageBlock(false);
        }

        private void DisableChat()
        {
            lblChatable.Text = "채팅 금지됨";
            lblChatable.ForeColor = Color.Red;
            if (ConnectInfo.server != null)
                ConnectInfo.server.SetMessageBlock(true);
        }
    }
}
