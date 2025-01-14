﻿namespace DrawTool
{
    partial class PropertiesVIew
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
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.combobox_PenWidth = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_SelectColor = new System.Windows.Forms.Button();
            this.label_Color = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_SelectBackgroudColor = new System.Windows.Forms.Button();
            this.label_BackgroundColor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.tb = new System.Windows.Forms.TrackBar();
            this.lblnum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tb)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Cancel
            // 
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Location = new System.Drawing.Point(146, 167);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(93, 25);
            this.button_Cancel.TabIndex = 15;
            this.button_Cancel.Text = "취 소";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.Transparent;
            this.button_Save.Location = new System.Drawing.Point(31, 167);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(93, 25);
            this.button_Save.TabIndex = 14;
            this.button_Save.Text = "저 장";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // combobox_PenWidth
            // 
            this.combobox_PenWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_PenWidth.FormattingEnabled = true;
            this.combobox_PenWidth.Location = new System.Drawing.Point(88, 76);
            this.combobox_PenWidth.Name = "combobox_PenWidth";
            this.combobox_PenWidth.Size = new System.Drawing.Size(82, 20);
            this.combobox_PenWidth.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "Pen 두께";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_SelectColor
            // 
            this.button_SelectColor.Location = new System.Drawing.Point(185, 12);
            this.button_SelectColor.Name = "button_SelectColor";
            this.button_SelectColor.Size = new System.Drawing.Size(38, 25);
            this.button_SelectColor.TabIndex = 10;
            this.button_SelectColor.Text = "...";
            this.button_SelectColor.UseVisualStyleBackColor = true;
            this.button_SelectColor.Click += new System.EventHandler(this.button_SelectColor_Click);
            // 
            // label_Color
            // 
            this.label_Color.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Color.Location = new System.Drawing.Point(88, 13);
            this.label_Color.Name = "label_Color";
            this.label_Color.Size = new System.Drawing.Size(82, 22);
            this.label_Color.TabIndex = 9;
            this.label_Color.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "테두리 색";
            // 
            // button_SelectBackgroudColor
            // 
            this.button_SelectBackgroudColor.Location = new System.Drawing.Point(185, 45);
            this.button_SelectBackgroudColor.Name = "button_SelectBackgroudColor";
            this.button_SelectBackgroudColor.Size = new System.Drawing.Size(38, 25);
            this.button_SelectBackgroudColor.TabIndex = 18;
            this.button_SelectBackgroudColor.Text = "...";
            this.button_SelectBackgroudColor.UseVisualStyleBackColor = true;
            this.button_SelectBackgroudColor.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // label_BackgroundColor
            // 
            this.label_BackgroundColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_BackgroundColor.Location = new System.Drawing.Point(88, 45);
            this.label_BackgroundColor.Name = "label_BackgroundColor";
            this.label_BackgroundColor.Size = new System.Drawing.Size(82, 22);
            this.label_BackgroundColor.TabIndex = 17;
            this.label_BackgroundColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "배경 색";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "투명도";
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(68, 110);
            this.tb.Maximum = 255;
            this.tb.Minimum = 1;
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(155, 45);
            this.tb.TabIndex = 20;
            this.tb.Value = 1;
            this.tb.Scroll += new System.EventHandler(this.tb_Scroll);
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.ForeColor = System.Drawing.Color.White;
            this.lblnum.Location = new System.Drawing.Point(229, 122);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(11, 12);
            this.lblnum.TabIndex = 21;
            this.lblnum.Text = "0";
            // 
            // PropertiesVIew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(278, 204);
            this.Controls.Add(this.lblnum);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_SelectBackgroudColor);
            this.Controls.Add(this.label_BackgroundColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.combobox_PenWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_SelectColor);
            this.Controls.Add(this.label_Color);
            this.Controls.Add(this.label1);
            this.Name = "PropertiesVIew";
            this.Text = "속성";
            ((System.ComponentModel.ISupportInitialize)(this.tb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.ComboBox combobox_PenWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_SelectColor;
        private System.Windows.Forms.Label label_Color;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_SelectBackgroudColor;
        private System.Windows.Forms.Label label_BackgroundColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tb;
        private System.Windows.Forms.Label lblnum;
    }
}