namespace project2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pAUSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rESUMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.levelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelTwoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.dESCRIPTIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAVETXTINYOURCOMPUTERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.background = new System.Windows.Forms.Panel();
            this.danger3 = new System.Windows.Forms.PictureBox();
            this.danger2 = new System.Windows.Forms.PictureBox();
            this.danger1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.roundButton5 = new WindowsFormsApplication1.RoundButton();
            this.roundButton4 = new WindowsFormsApplication1.RoundButton();
            this.roundButton3 = new WindowsFormsApplication1.RoundButton();
            this.roundButton2 = new WindowsFormsApplication1.RoundButton();
            this.roundButton1 = new WindowsFormsApplication1.RoundButton();
            this.menuStrip1.SuspendLayout();
            this.background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danger3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danger2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danger1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.levelToolStripMenuItem,
            this.dESCRIPTIONToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(307, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.pAUSEToolStripMenuItem,
            this.rESUMEToolStripMenuItem,
            this.toolStripSeparator1,
            this.eXITToolStripMenuItem,
            this.toolStripSeparator2});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fileToolStripMenuItem.Text = "FILE";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.newGameToolStripMenuItem.Text = "NEW GAME";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // pAUSEToolStripMenuItem
            // 
            this.pAUSEToolStripMenuItem.Name = "pAUSEToolStripMenuItem";
            this.pAUSEToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.pAUSEToolStripMenuItem.Text = "PAUSE";
            this.pAUSEToolStripMenuItem.Click += new System.EventHandler(this.pAUSEToolStripMenuItem_Click);
            // 
            // rESUMEToolStripMenuItem
            // 
            this.rESUMEToolStripMenuItem.Name = "rESUMEToolStripMenuItem";
            this.rESUMEToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.rESUMEToolStripMenuItem.Text = "RESUME";
            this.rESUMEToolStripMenuItem.Click += new System.EventHandler(this.rESUMEToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(133, 6);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(133, 6);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem1,
            this.toolStripSeparator3});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.settingToolStripMenuItem.Text = "SETTING";
            // 
            // settingToolStripMenuItem1
            // 
            this.settingToolStripMenuItem1.Name = "settingToolStripMenuItem1";
            this.settingToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.settingToolStripMenuItem1.Text = "SETTING";
            this.settingToolStripMenuItem1.Click += new System.EventHandler(this.settingToolStripMenuItem1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(117, 6);
            // 
            // levelToolStripMenuItem
            // 
            this.levelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.levelTwoToolStripMenuItem,
            this.toolStripSeparator4});
            this.levelToolStripMenuItem.Name = "levelToolStripMenuItem";
            this.levelToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.levelToolStripMenuItem.Text = "LEVEL";
            this.levelToolStripMenuItem.Click += new System.EventHandler(this.levelToolStripMenuItem_Click);
            // 
            // levelTwoToolStripMenuItem
            // 
            this.levelTwoToolStripMenuItem.Name = "levelTwoToolStripMenuItem";
            this.levelTwoToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.levelTwoToolStripMenuItem.Text = "NEXT LEVEL";
            this.levelTwoToolStripMenuItem.Click += new System.EventHandler(this.levelTwoToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(134, 6);
            // 
            // dESCRIPTIONToolStripMenuItem
            // 
            this.dESCRIPTIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sAVETXTINYOURCOMPUTERToolStripMenuItem,
            this.toolStripSeparator5});
            this.dESCRIPTIONToolStripMenuItem.Name = "dESCRIPTIONToolStripMenuItem";
            this.dESCRIPTIONToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.dESCRIPTIONToolStripMenuItem.Text = "DESCRIPTION";
            // 
            // sAVETXTINYOURCOMPUTERToolStripMenuItem
            // 
            this.sAVETXTINYOURCOMPUTERToolStripMenuItem.Name = "sAVETXTINYOURCOMPUTERToolStripMenuItem";
            this.sAVETXTINYOURCOMPUTERToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.sAVETXTINYOURCOMPUTERToolStripMenuItem.Text = "SHOW DETAILS OF THE GAME";
            this.sAVETXTINYOURCOMPUTERToolStripMenuItem.Click += new System.EventHandler(this.sAVETXTINYOURCOMPUTERToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(232, 6);
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.Black;
            this.background.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.background.Controls.Add(this.danger3);
            this.background.Controls.Add(this.danger2);
            this.background.Controls.Add(this.danger1);
            this.background.Controls.Add(this.player);
            this.background.Location = new System.Drawing.Point(33, 27);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(262, 291);
            this.background.TabIndex = 1;
            this.background.Paint += new System.Windows.Forms.PaintEventHandler(this.background_Paint);
            // 
            // danger3
            // 
            this.danger3.BackColor = System.Drawing.Color.Transparent;
            this.danger3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.danger3.Image = global::project2.Properties.Resources.وحش;
            this.danger3.Location = new System.Drawing.Point(213, -4);
            this.danger3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.danger3.Name = "danger3";
            this.danger3.Size = new System.Drawing.Size(44, 40);
            this.danger3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.danger3.TabIndex = 3;
            this.danger3.TabStop = false;
            this.danger3.Click += new System.EventHandler(this.danger3_Click);
            // 
            // danger2
            // 
            this.danger2.BackColor = System.Drawing.Color.Transparent;
            this.danger2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.danger2.Image = global::project2.Properties.Resources.وحش;
            this.danger2.Location = new System.Drawing.Point(101, -4);
            this.danger2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.danger2.Name = "danger2";
            this.danger2.Size = new System.Drawing.Size(44, 40);
            this.danger2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.danger2.TabIndex = 2;
            this.danger2.TabStop = false;
            // 
            // danger1
            // 
            this.danger1.BackColor = System.Drawing.Color.Transparent;
            this.danger1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.danger1.Image = global::project2.Properties.Resources.وحش;
            this.danger1.Location = new System.Drawing.Point(3, -4);
            this.danger1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.danger1.Name = "danger1";
            this.danger1.Size = new System.Drawing.Size(44, 40);
            this.danger1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.danger1.TabIndex = 1;
            this.danger1.TabStop = false;
            this.danger1.Click += new System.EventHandler(this.danger_Click);
            // 
            // player
            // 
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.player.Image = global::project2.Properties.Resources.ش;
            this.player.Location = new System.Drawing.Point(101, 255);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(44, 35);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.progressBar1.Location = new System.Drawing.Point(0, 24);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(23, 463);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(30, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "score :";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(91, 327);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 18);
            this.textBox1.TabIndex = 6;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(23, 465);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(284, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // roundButton5
            // 
            this.roundButton5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton5.Location = new System.Drawing.Point(22, 357);
            this.roundButton5.Name = "roundButton5";
            this.roundButton5.Size = new System.Drawing.Size(273, 24);
            this.roundButton5.TabIndex = 13;
            this.roundButton5.Text = "START";
            this.roundButton5.UseVisualStyleBackColor = true;
            this.roundButton5.Click += new System.EventHandler(this.roundButton5_Click);
            // 
            // roundButton4
            // 
            this.roundButton4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton4.Location = new System.Drawing.Point(99, 387);
            this.roundButton4.Name = "roundButton4";
            this.roundButton4.Size = new System.Drawing.Size(90, 24);
            this.roundButton4.TabIndex = 11;
            this.roundButton4.Text = "RESUME";
            this.roundButton4.UseVisualStyleBackColor = true;
            this.roundButton4.Click += new System.EventHandler(this.roundButton4_Click);
            // 
            // roundButton3
            // 
            this.roundButton3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton3.Location = new System.Drawing.Point(29, 422);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Size = new System.Drawing.Size(266, 24);
            this.roundButton3.TabIndex = 10;
            this.roundButton3.Text = "EXIT";
            this.roundButton3.UseVisualStyleBackColor = true;
            this.roundButton3.Click += new System.EventHandler(this.roundButton3_Click);
            // 
            // roundButton2
            // 
            this.roundButton2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton2.Location = new System.Drawing.Point(195, 387);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(100, 24);
            this.roundButton2.TabIndex = 9;
            this.roundButton2.Text = "SETTING";
            this.roundButton2.UseVisualStyleBackColor = true;
            this.roundButton2.Click += new System.EventHandler(this.roundButton2_Click);
            // 
            // roundButton1
            // 
            this.roundButton1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton1.Location = new System.Drawing.Point(29, 387);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(66, 24);
            this.roundButton1.TabIndex = 8;
            this.roundButton1.Text = "PAUSE";
            this.roundButton1.UseVisualStyleBackColor = true;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(307, 487);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.roundButton5);
            this.Controls.Add(this.roundButton4);
            this.Controls.Add(this.roundButton3);
            this.Controls.Add(this.roundButton2);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.background);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FIRE GAME";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.background.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.danger3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danger2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danger1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Panel background;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox danger1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox danger2;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripMenuItem levelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem levelTwoToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pAUSEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rESUMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem1;
        private System.Windows.Forms.PictureBox danger3;
        private WindowsFormsApplication1.RoundButton roundButton1;
        private WindowsFormsApplication1.RoundButton roundButton2;
        private WindowsFormsApplication1.RoundButton roundButton3;
        private WindowsFormsApplication1.RoundButton roundButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private WindowsFormsApplication1.RoundButton roundButton5;
        private System.Windows.Forms.ToolStripMenuItem dESCRIPTIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAVETXTINYOURCOMPUTERToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

