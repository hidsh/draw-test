namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdButtonSelect = new System.Windows.Forms.ToolStripButton();
            this.cmdButtonLine = new System.Windows.Forms.ToolStripButton();
            this.cmdButtonBox = new System.Windows.Forms.ToolStripButton();
            this.cmdButtonOval = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.label_pos = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cmdButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.cmdButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 207);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // cmdButtonSelect
            // 
            this.cmdButtonSelect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdButtonSelect.BackgroundImage")));
            this.cmdButtonSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdButtonSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdButtonSelect.Name = "cmdButtonSelect";
            this.cmdButtonSelect.Size = new System.Drawing.Size(23, 22);
            this.cmdButtonSelect.Tag = "0";
            this.cmdButtonSelect.Text = "toolStripButton1";
            this.cmdButtonSelect.Click += new System.EventHandler(this.cmdButtonSelect_Click);
            // 
            // cmdButtonLine
            // 
            this.cmdButtonLine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdButtonLine.BackgroundImage")));
            this.cmdButtonLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdButtonLine.Image = ((System.Drawing.Image)(resources.GetObject("cmdButtonLine.Image")));
            this.cmdButtonLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdButtonLine.Name = "cmdButtonLine";
            this.cmdButtonLine.Size = new System.Drawing.Size(23, 22);
            this.cmdButtonLine.Tag = "1";
            this.cmdButtonLine.Text = "toolStripButton2";
            this.cmdButtonLine.Click += new System.EventHandler(this.cmdButtonLine_Click);
            // 
            // cmdButtonBox
            // 
            this.cmdButtonBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdButtonBox.BackgroundImage")));
            this.cmdButtonBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdButtonBox.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cmdButtonBox.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdButtonBox.Name = "cmdButtonBox";
            this.cmdButtonBox.Size = new System.Drawing.Size(23, 22);
            this.cmdButtonBox.Tag = "2";
            this.cmdButtonBox.Text = "toolStripButton2";
            this.cmdButtonBox.Click += new System.EventHandler(this.cmdButtonBox_Click);
            // 
            // cmdButtonOval
            // 
            this.cmdButtonOval.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdButtonOval.BackgroundImage")));
            this.cmdButtonOval.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdButtonOval.Image = ((System.Drawing.Image)(resources.GetObject("cmdButtonOval.Image")));
            this.cmdButtonOval.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cmdButtonOval.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdButtonOval.Name = "cmdButtonOval";
            this.cmdButtonOval.Size = new System.Drawing.Size(23, 22);
            this.cmdButtonOval.Tag = "3";
            this.cmdButtonOval.Text = "toolStripButton1";
            this.cmdButtonOval.Click += new System.EventHandler(this.cmdButtonOval_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // label_pos
            // 
            this.label_pos.Name = "label_pos";
            this.label_pos.Size = new System.Drawing.Size(96, 18);
            this.label_pos.Text = "toolStripLabel1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdButtonOpen,
            this.cmdButtonSave,
            this.toolStripSeparator2,
            this.cmdButtonSelect,
            this.cmdButtonLine,
            this.cmdButtonBox,
            this.cmdButtonOval,
            this.toolStripSeparator1,
            this.label_pos});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(259, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cmdButtonOpen
            // 
            this.cmdButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("cmdButtonOpen.Image")));
            this.cmdButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdButtonOpen.Name = "cmdButtonOpen";
            this.cmdButtonOpen.Size = new System.Drawing.Size(23, 22);
            this.cmdButtonOpen.Text = "toolStripButton1";
            this.cmdButtonOpen.Click += new System.EventHandler(this.cmdButtonOpen_Click);
            // 
            // cmdButtonSave
            // 
            this.cmdButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("cmdButtonSave.Image")));
            this.cmdButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdButtonSave.Name = "cmdButtonSave";
            this.cmdButtonSave.Size = new System.Drawing.Size(23, 22);
            this.cmdButtonSave.Text = "toolStripButton2";
            this.cmdButtonSave.Click += new System.EventHandler(this.cmdButtonSave_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 232);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton cmdButtonSelect;
        private System.Windows.Forms.ToolStripButton cmdButtonLine;
        private System.Windows.Forms.ToolStripButton cmdButtonBox;
        private System.Windows.Forms.ToolStripButton cmdButtonOval;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel label_pos;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton cmdButtonOpen;
        private System.Windows.Forms.ToolStripButton cmdButtonSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;


    }
}

