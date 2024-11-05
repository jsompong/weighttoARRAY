namespace Cinema
{
    partial class CinemaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CinemaForm));
            this.cinemaSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.cinemaPictureBox = new System.Windows.Forms.PictureBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.sendRead = new System.Windows.Forms.TextBox();
            this.zm510 = new System.Windows.Forms.Label();
            this.STARTbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CONSecutiveBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FINconsecBox = new System.Windows.Forms.TextBox();
            this.CONSECtimer = new System.Windows.Forms.Timer(this.components);
            this.RESULT = new System.Windows.Forms.Label();
            this.WtBox = new System.Windows.Forms.TextBox();
            this.SIMUtimer = new System.Windows.Forms.Timer(this.components);
            this.Ymovetimer = new System.Windows.Forms.Timer(this.components);
            this.WTlistBox = new System.Windows.Forms.ListBox();
            this.LeDBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeDBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cinemaPictureBox
            // 
            this.cinemaPictureBox.Location = new System.Drawing.Point(12, 12);
            this.cinemaPictureBox.Name = "cinemaPictureBox";
            this.cinemaPictureBox.Size = new System.Drawing.Size(1252, 556);
            this.cinemaPictureBox.TabIndex = 0;
            this.cinemaPictureBox.TabStop = false;
            this.cinemaPictureBox.Click += new System.EventHandler(this.cinemaPictureBox_Click);
            this.cinemaPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.cinemaPictureBox_Paint);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(448, 634);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(49, 39);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "weight get";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // sendRead
            // 
            this.sendRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sendRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendRead.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.sendRead.Location = new System.Drawing.Point(40, 637);
            this.sendRead.Multiline = true;
            this.sendRead.Name = "sendRead";
            this.sendRead.Size = new System.Drawing.Size(394, 36);
            this.sendRead.TabIndex = 2;
            this.sendRead.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // zm510
            // 
            this.zm510.AutoSize = true;
            this.zm510.BackColor = System.Drawing.Color.Transparent;
            this.zm510.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zm510.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.zm510.Location = new System.Drawing.Point(304, 603);
            this.zm510.Name = "zm510";
            this.zm510.Size = new System.Drawing.Size(86, 15);
            this.zm510.TabIndex = 7;
            this.zm510.Text = "zm510string";
            // 
            // STARTbutton
            // 
            this.STARTbutton.BackColor = System.Drawing.Color.Gold;
            this.STARTbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("STARTbutton.BackgroundImage")));
            this.STARTbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.STARTbutton.Cursor = System.Windows.Forms.Cursors.Cross;
            this.STARTbutton.Font = new System.Drawing.Font("AngsanaUPC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.STARTbutton.ForeColor = System.Drawing.Color.Red;
            this.STARTbutton.Location = new System.Drawing.Point(580, 634);
            this.STARTbutton.Name = "STARTbutton";
            this.STARTbutton.Size = new System.Drawing.Size(176, 47);
            this.STARTbutton.TabIndex = 8;
            this.STARTbutton.Text = "เริ่มจับค่าน้ำหนัก ใน  1 วินาที";
            this.STARTbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.STARTbutton.UseVisualStyleBackColor = true;
            this.STARTbutton.Click += new System.EventHandler(this.STARTbutton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("AngsanaUPC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(35, 571);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 29);
            this.label5.TabIndex = 19;
            this.label5.Text = "เลขลำดับ เริ่ม";
            this.label5.Visible = false;
            // 
            // CONSecutiveBox
            // 
            this.CONSecutiveBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CONSecutiveBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONSecutiveBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CONSecutiveBox.Location = new System.Drawing.Point(40, 603);
            this.CONSecutiveBox.Multiline = true;
            this.CONSecutiveBox.Name = "CONSecutiveBox";
            this.CONSecutiveBox.Size = new System.Drawing.Size(136, 28);
            this.CONSecutiveBox.TabIndex = 20;
            this.CONSecutiveBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CONSecutiveBox.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("AngsanaUPC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(175, 571);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 29);
            this.label6.TabIndex = 21;
            this.label6.Text = "เลขลำดับ จบ";
            this.label6.Visible = false;
            // 
            // FINconsecBox
            // 
            this.FINconsecBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FINconsecBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FINconsecBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FINconsecBox.Location = new System.Drawing.Point(177, 603);
            this.FINconsecBox.Multiline = true;
            this.FINconsecBox.Name = "FINconsecBox";
            this.FINconsecBox.Size = new System.Drawing.Size(121, 28);
            this.FINconsecBox.TabIndex = 22;
            this.FINconsecBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FINconsecBox.Visible = false;
            // 
            // CONSECtimer
            // 
            this.CONSECtimer.Interval = 1000;
            this.CONSECtimer.Tick += new System.EventHandler(this.CONSECtimer_Tick);
            // 
            // RESULT
            // 
            this.RESULT.AllowDrop = true;
            this.RESULT.AutoSize = true;
            this.RESULT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RESULT.ForeColor = System.Drawing.Color.Red;
            this.RESULT.Location = new System.Drawing.Point(302, 571);
            this.RESULT.Name = "RESULT";
            this.RESULT.Size = new System.Drawing.Size(132, 25);
            this.RESULT.TabIndex = 23;
            this.RESULT.Text = "ผลการทดสอบ";
            // 
            // WtBox
            // 
            this.WtBox.Location = new System.Drawing.Point(792, 575);
            this.WtBox.Name = "WtBox";
            this.WtBox.Size = new System.Drawing.Size(71, 20);
            this.WtBox.TabIndex = 26;
            this.WtBox.TextChanged += new System.EventHandler(this.WtBox_TextChanged);
            // 
            // SIMUtimer
            // 
            this.SIMUtimer.Tick += new System.EventHandler(this.SIMUtimer_Tick);
            // 
            // Ymovetimer
            // 
            this.Ymovetimer.Interval = 200;
            this.Ymovetimer.Tick += new System.EventHandler(this.Ymovetimer_Tick);
            // 
            // WTlistBox
            // 
            this.WTlistBox.FormattingEnabled = true;
            this.WTlistBox.Location = new System.Drawing.Point(1187, 47);
            this.WTlistBox.Name = "WTlistBox";
            this.WTlistBox.Size = new System.Drawing.Size(66, 511);
            this.WTlistBox.TabIndex = 27;
            this.WTlistBox.SelectedIndexChanged += new System.EventHandler(this.WTlistBox_SelectedIndexChanged);
            // 
            // LeDBox
            // 
            this.LeDBox.BackColor = System.Drawing.Color.Red;
            this.LeDBox.Location = new System.Drawing.Point(1171, 546);
            this.LeDBox.Name = "LeDBox";
            this.LeDBox.Size = new System.Drawing.Size(10, 12);
            this.LeDBox.TabIndex = 28;
            this.LeDBox.TabStop = false;
            this.LeDBox.Click += new System.EventHandler(this.LeDBox_Click);
            // 
            // CinemaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 685);
            this.Controls.Add(this.LeDBox);
            this.Controls.Add(this.WTlistBox);
            this.Controls.Add(this.WtBox);
            this.Controls.Add(this.RESULT);
            this.Controls.Add(this.FINconsecBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CONSecutiveBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.STARTbutton);
            this.Controls.Add(this.zm510);
            this.Controls.Add(this.sendRead);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cinemaPictureBox);
            this.Name = "CinemaForm";
            this.Text = "C# Graphics";
            this.Load += new System.EventHandler(this.CinemaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cinemaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeDBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog cinemaSaveFileDialog;
        private System.Windows.Forms.PictureBox cinemaPictureBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox sendRead;
        private System.Windows.Forms.Label zm510;
        private System.Windows.Forms.Button STARTbutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CONSecutiveBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FINconsecBox;
        private System.Windows.Forms.Timer CONSECtimer;
        private System.Windows.Forms.Label RESULT;
        private System.Windows.Forms.TextBox WtBox;
        private System.Windows.Forms.Timer SIMUtimer;
        private System.Windows.Forms.Timer Ymovetimer;
        private System.Windows.Forms.ListBox WTlistBox;
        private System.Windows.Forms.PictureBox LeDBox;
    }
}

