﻿namespace Main.View.Popup
{
    partial class FormUserListPopup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.chID = new System.Windows.Forms.ColumnHeader();
            this.chName = new System.Windows.Forms.ColumnHeader();
            this.lblChatable = new System.Windows.Forms.Label();
            this.btnChatable = new System.Windows.Forms.Button();
            this.btnPrtUserList = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chName});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(15, 16);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(639, 453);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // chID
            // 
            this.chID.Text = "학번";
            this.chID.Width = 120;
            // 
            // chName
            // 
            this.chName.Text = "이름";
            this.chName.Width = 80;
            // 
            // lblChatable
            // 
            this.lblChatable.AutoSize = true;
            this.lblChatable.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChatable.Location = new System.Drawing.Point(663, 16);
            this.lblChatable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChatable.Name = "lblChatable";
            this.lblChatable.Size = new System.Drawing.Size(89, 20);
            this.lblChatable.TabIndex = 1;
            this.lblChatable.Text = "채팅 허용됨";
            // 
            // btnChatable
            // 
            this.btnChatable.Location = new System.Drawing.Point(663, 40);
            this.btnChatable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChatable.Name = "btnChatable";
            this.btnChatable.Size = new System.Drawing.Size(149, 31);
            this.btnChatable.TabIndex = 2;
            this.btnChatable.Text = "채팅 허용/금지";
            this.btnChatable.UseVisualStyleBackColor = true;
            this.btnChatable.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPrtUserList
            // 
            this.btnPrtUserList.Location = new System.Drawing.Point(663, 79);
            this.btnPrtUserList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrtUserList.Name = "btnPrtUserList";
            this.btnPrtUserList.Size = new System.Drawing.Size(149, 31);
            this.btnPrtUserList.TabIndex = 3;
            this.btnPrtUserList.Text = "콘솔 출력";
            this.btnPrtUserList.UseVisualStyleBackColor = true;
            this.btnPrtUserList.Click += new System.EventHandler(this.btnPrtUserList_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(663, 440);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "강제 퇴장";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(663, 416);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(77, 20);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "선택 학번:";
            // 
            // FormUserListPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 600);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPrtUserList);
            this.Controls.Add(this.btnChatable);
            this.Controls.Add(this.lblChatable);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormUserListPopup";
            this.Text = "FormUserListPopup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listView1;
        private ColumnHeader chID;
        private ColumnHeader chName;
        private Label lblChatable;
        private Button btnChatable;
        private Button btnPrtUserList;
        private Button button1;
        private Label lblID;
    }
}