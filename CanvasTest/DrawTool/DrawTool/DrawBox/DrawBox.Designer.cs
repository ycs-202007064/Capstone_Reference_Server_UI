﻿namespace DrawTool.DrawBox
{
    partial class DrawBox
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawBox));
            this.pictureBox_ReSize = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SelectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UnselectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.PropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.UndoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RedoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ReSize)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_ReSize
            // 
            this.pictureBox_ReSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_ReSize.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox_ReSize.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.pictureBox_ReSize.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_ReSize.Image")));
            this.pictureBox_ReSize.Location = new System.Drawing.Point(201, 103);
            this.pictureBox_ReSize.Name = "pictureBox_ReSize";
            this.pictureBox_ReSize.Size = new System.Drawing.Size(17, 17);
            this.pictureBox_ReSize.TabIndex = 0;
            this.pictureBox_ReSize.TabStop = false;
            this.pictureBox_ReSize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_ReSize_MouseDown);
            this.pictureBox_ReSize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_ReSize_MouseMove);
            this.pictureBox_ReSize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_ReSize_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectAllToolStripMenuItem,
            this.UnselectAllToolStripMenuItem,
            this.DeleteToolStripMenuItem,
            this.DeleteAllToolStripMenuItem,
            this.toolStripSeparator1,
            this.UndoToolStripMenuItem,
            this.RedoToolStripMenuItem,
            this.toolStripSeparator2,
            this.PropertiesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 192);
            // 
            // 전체선택ToolStripMenuItem
            // 
            this.SelectAllToolStripMenuItem.Name = "전체선택ToolStripMenuItem";
            this.SelectAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SelectAllToolStripMenuItem.Text = "전체 선택";
            this.SelectAllToolStripMenuItem.Click += new System.EventHandler(this.SelectAllToolStripMenuItem_Click);
            // 
            // 전체해제ToolStripMenuItem
            // 
            this.UnselectAllToolStripMenuItem.Name = "전체해제ToolStripMenuItem";
            this.UnselectAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.UnselectAllToolStripMenuItem.Text = "전체 해제";
            this.UnselectAllToolStripMenuItem.Click += new System.EventHandler(this.UnselectAllToolStripMenuItem_Click);
            // 
            // 삭제하기ToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "삭제하기ToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.DeleteToolStripMenuItem.Text = "삭제하기";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // 전체삭제하기ToolStripMenuItem
            // 
            this.DeleteAllToolStripMenuItem.Name = "전체삭제하기ToolStripMenuItem";
            this.DeleteAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.DeleteAllToolStripMenuItem.Text = "전체 삭제하기";
            this.DeleteAllToolStripMenuItem.Click += new System.EventHandler(this.DeleteAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // 속성설정하기ToolStripMenuItem
            // 
            this.PropertiesToolStripMenuItem.Name = "속성설정하기ToolStripMenuItem";
            this.PropertiesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.PropertiesToolStripMenuItem.Text = "속성 설정하기";
            this.PropertiesToolStripMenuItem.Click += new System.EventHandler(this.PropertiesToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // UndoToolStripMenuItem
            // 
            this.UndoToolStripMenuItem.Enabled = false;
            this.UndoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("UndoToolStripMenuItem.Image")));
            this.UndoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Silver;
            this.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem";
            this.UndoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.UndoToolStripMenuItem.Text = "실행 취소";
            this.UndoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            // 
            // RedoToolStripMenuItem
            // 
            this.RedoToolStripMenuItem.Enabled = false;
            this.RedoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("RedoToolStripMenuItem.Image")));
            this.RedoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Silver;
            this.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem";
            this.RedoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.RedoToolStripMenuItem.Text = "다시 실행";
            this.RedoToolStripMenuItem.Click += new System.EventHandler(this.RedoToolStripMenuItem_Click);
            // 
            // DrawBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.pictureBox_ReSize);
            this.Name = "DrawBox";
            this.Size = new System.Drawing.Size(218, 120);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawBox_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawBox_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawBox_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawBox_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ReSize)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_ReSize;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SelectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UnselectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem PropertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem UndoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RedoToolStripMenuItem;
    }
}
