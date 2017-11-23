namespace SmartScopeControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_A_audio = new System.Windows.Forms.Button();
            this.button_A_wfm = new System.Windows.Forms.Button();
            this.button_A_picture = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_b_audio = new System.Windows.Forms.Button();
            this.button_b_wfm = new System.Windows.Forms.Button();
            this.button_b_picture = new System.Windows.Forms.Button();
            this.textBox_msg = new System.Windows.Forms.TextBox();
            this.button_send = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.button_A_audio);
            this.groupBox1.Controls.Add(this.button_A_wfm);
            this.groupBox1.Controls.Add(this.button_A_picture);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 185);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Left";
            // 
            // button_A_audio
            // 
            this.button_A_audio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_A_audio.Location = new System.Drawing.Point(6, 122);
            this.button_A_audio.Name = "button_A_audio";
            this.button_A_audio.Size = new System.Drawing.Size(189, 40);
            this.button_A_audio.TabIndex = 2;
            this.button_A_audio.Text = "Audio";
            this.button_A_audio.UseVisualStyleBackColor = true;
            this.button_A_audio.Click += new System.EventHandler(this.a_audio_Click);
            // 
            // button_A_wfm
            // 
            this.button_A_wfm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_A_wfm.Location = new System.Drawing.Point(6, 76);
            this.button_A_wfm.Name = "button_A_wfm";
            this.button_A_wfm.Size = new System.Drawing.Size(189, 40);
            this.button_A_wfm.TabIndex = 1;
            this.button_A_wfm.Text = "Waveform RGB";
            this.button_A_wfm.UseVisualStyleBackColor = true;
            this.button_A_wfm.Click += new System.EventHandler(this.a_wfm_Click);
            // 
            // button_A_picture
            // 
            this.button_A_picture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_A_picture.Location = new System.Drawing.Point(6, 30);
            this.button_A_picture.Name = "button_A_picture";
            this.button_A_picture.Size = new System.Drawing.Size(189, 40);
            this.button_A_picture.TabIndex = 0;
            this.button_A_picture.Text = "Picture";
            this.button_A_picture.UseVisualStyleBackColor = true;
            this.button_A_picture.Click += new System.EventHandler(this.a_picture_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_b_audio);
            this.groupBox2.Controls.Add(this.button_b_wfm);
            this.groupBox2.Controls.Add(this.button_b_picture);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(220, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 185);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Right";
            // 
            // button_b_audio
            // 
            this.button_b_audio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_b_audio.Location = new System.Drawing.Point(5, 122);
            this.button_b_audio.Name = "button_b_audio";
            this.button_b_audio.Size = new System.Drawing.Size(188, 40);
            this.button_b_audio.TabIndex = 2;
            this.button_b_audio.Text = "Audio";
            this.button_b_audio.UseVisualStyleBackColor = true;
            this.button_b_audio.Click += new System.EventHandler(this.b_audio_Click);
            // 
            // button_b_wfm
            // 
            this.button_b_wfm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_b_wfm.Location = new System.Drawing.Point(5, 76);
            this.button_b_wfm.Name = "button_b_wfm";
            this.button_b_wfm.Size = new System.Drawing.Size(188, 40);
            this.button_b_wfm.TabIndex = 1;
            this.button_b_wfm.Text = "Waveform RGB";
            this.button_b_wfm.UseVisualStyleBackColor = true;
            this.button_b_wfm.Click += new System.EventHandler(this.b_wfm_Click);
            // 
            // button_b_picture
            // 
            this.button_b_picture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_b_picture.Location = new System.Drawing.Point(6, 30);
            this.button_b_picture.Name = "button_b_picture";
            this.button_b_picture.Size = new System.Drawing.Size(188, 40);
            this.button_b_picture.TabIndex = 0;
            this.button_b_picture.Text = "Picture";
            this.button_b_picture.UseVisualStyleBackColor = true;
            this.button_b_picture.Click += new System.EventHandler(this.b_picture_Click);
            // 
            // textBox_msg
            // 
            this.textBox_msg.Location = new System.Drawing.Point(18, 218);
            this.textBox_msg.Multiline = true;
            this.textBox_msg.Name = "textBox_msg";
            this.textBox_msg.Size = new System.Drawing.Size(314, 23);
            this.textBox_msg.TabIndex = 6;
            this.textBox_msg.Visible = false;
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(338, 216);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(75, 23);
            this.button_send.TabIndex = 7;
            this.button_send.Text = "send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Visible = false;
            this.button_send.Click += new System.EventHandler(this.button9_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(432, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem1,
            this.debugToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem2});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.exitToolStripMenuItem.Text = "Scopes";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem1.Text = "Settings";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.debugToolStripMenuItem.Text = "Debug";
            this.debugToolStripMenuItem.Click += new System.EventHandler(this.debugToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem2
            // 
            this.exitToolStripMenuItem2.Name = "exitToolStripMenuItem2";
            this.exitToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem2.Text = "Exit";
            this.exitToolStripMenuItem2.Click += new System.EventHandler(this.exitToolStripMenuItem2_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 257);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.textBox_msg);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SmartScope Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_A_audio;
        private System.Windows.Forms.Button button_A_wfm;
        private System.Windows.Forms.Button button_A_picture;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_b_audio;
        private System.Windows.Forms.Button button_b_wfm;
        private System.Windows.Forms.Button button_b_picture;
        private System.Windows.Forms.TextBox textBox_msg;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
    }
}

