﻿namespace Main.View.Popup
{
    partial class FormChatListPopup
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panChatMemberList = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 50);
            this.panel1.TabIndex = 0;
            // 
            // panChatMemberList
            // 
            this.panChatMemberList.AutoScroll = true;
            this.panChatMemberList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panChatMemberList.Location = new System.Drawing.Point(0, 50);
            this.panChatMemberList.Name = "panChatMemberList";
            this.panChatMemberList.Size = new System.Drawing.Size(239, 410);
            this.panChatMemberList.TabIndex = 1;
            // 
            // FormChatListPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 460);
            this.Controls.Add(this.panChatMemberList);
            this.Controls.Add(this.panel1);
            this.Name = "FormChatListPopup";
            this.Text = "FormChatListPopup";
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panChatMemberList;
    }
}