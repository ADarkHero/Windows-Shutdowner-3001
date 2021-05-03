namespace WindowsShutdown
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.shutdownOneHour = new System.Windows.Forms.Button();
            this.pickShutdownTime = new System.Windows.Forms.DateTimePicker();
            this.shutdownThreeHours = new System.Windows.Forms.Button();
            this.cancelShutdown = new System.Windows.Forms.Button();
            this.shutdownSixHours = new System.Windows.Forms.Button();
            this.shutdownSpecificTime = new System.Windows.Forms.Button();
            this.shutdownXHours = new System.Windows.Forms.Button();
            this.pickShutdownHourTime = new System.Windows.Forms.NumericUpDown();
            this.shutdownPlanned = new System.Windows.Forms.Button();
            this.shutdownTwelveHours = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pickShutdownHourTime)).BeginInit();
            this.SuspendLayout();
            // 
            // shutdownOneHour
            // 
            this.shutdownOneHour.Location = new System.Drawing.Point(13, 13);
            this.shutdownOneHour.Name = "shutdownOneHour";
            this.shutdownOneHour.Size = new System.Drawing.Size(350, 50);
            this.shutdownOneHour.TabIndex = 0;
            this.shutdownOneHour.Text = "Shutdown in 1 hour";
            this.shutdownOneHour.UseVisualStyleBackColor = true;
            this.shutdownOneHour.Click += new System.EventHandler(this.shutdownOneHour_Click);
            // 
            // pickShutdownTime
            // 
            this.pickShutdownTime.CustomFormat = "dd.MM.yyyy - HH:mm";
            this.pickShutdownTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickShutdownTime.Location = new System.Drawing.Point(641, 82);
            this.pickShutdownTime.Name = "pickShutdownTime";
            this.pickShutdownTime.Size = new System.Drawing.Size(131, 20);
            this.pickShutdownTime.TabIndex = 1;
            this.pickShutdownTime.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // shutdownThreeHours
            // 
            this.shutdownThreeHours.Location = new System.Drawing.Point(13, 69);
            this.shutdownThreeHours.Name = "shutdownThreeHours";
            this.shutdownThreeHours.Size = new System.Drawing.Size(350, 50);
            this.shutdownThreeHours.TabIndex = 2;
            this.shutdownThreeHours.Text = "Shutdown in 3 hours";
            this.shutdownThreeHours.UseVisualStyleBackColor = true;
            this.shutdownThreeHours.Click += new System.EventHandler(this.shutdownThreeHours_Click);
            // 
            // cancelShutdown
            // 
            this.cancelShutdown.BackColor = System.Drawing.Color.DarkRed;
            this.cancelShutdown.Cursor = System.Windows.Forms.Cursors.Default;
            this.cancelShutdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelShutdown.ForeColor = System.Drawing.SystemColors.Control;
            this.cancelShutdown.Location = new System.Drawing.Point(11, 324);
            this.cancelShutdown.Name = "cancelShutdown";
            this.cancelShutdown.Size = new System.Drawing.Size(760, 75);
            this.cancelShutdown.TabIndex = 3;
            this.cancelShutdown.Text = "Cancel Shutdown";
            this.cancelShutdown.UseVisualStyleBackColor = false;
            this.cancelShutdown.Click += new System.EventHandler(this.button3_Click);
            // 
            // shutdownSixHours
            // 
            this.shutdownSixHours.Location = new System.Drawing.Point(13, 125);
            this.shutdownSixHours.Name = "shutdownSixHours";
            this.shutdownSixHours.Size = new System.Drawing.Size(350, 50);
            this.shutdownSixHours.TabIndex = 6;
            this.shutdownSixHours.Text = "Shutdown in 6 hours";
            this.shutdownSixHours.UseVisualStyleBackColor = true;
            this.shutdownSixHours.Click += new System.EventHandler(this.shutdownSixHours_Click);
            // 
            // shutdownSpecificTime
            // 
            this.shutdownSpecificTime.Location = new System.Drawing.Point(413, 69);
            this.shutdownSpecificTime.Name = "shutdownSpecificTime";
            this.shutdownSpecificTime.Size = new System.Drawing.Size(222, 50);
            this.shutdownSpecificTime.TabIndex = 7;
            this.shutdownSpecificTime.Text = "Shutdown @ ";
            this.shutdownSpecificTime.UseVisualStyleBackColor = true;
            this.shutdownSpecificTime.Click += new System.EventHandler(this.shutdownSpecificTime_Click);
            // 
            // shutdownXHours
            // 
            this.shutdownXHours.Location = new System.Drawing.Point(413, 13);
            this.shutdownXHours.Name = "shutdownXHours";
            this.shutdownXHours.Size = new System.Drawing.Size(222, 50);
            this.shutdownXHours.TabIndex = 8;
            this.shutdownXHours.Text = "Shutdown in X hours";
            this.shutdownXHours.UseVisualStyleBackColor = true;
            this.shutdownXHours.Click += new System.EventHandler(this.shutdownXHours_Click);
            // 
            // pickShutdownHourTime
            // 
            this.pickShutdownHourTime.DecimalPlaces = 2;
            this.pickShutdownHourTime.Location = new System.Drawing.Point(641, 30);
            this.pickShutdownHourTime.Name = "pickShutdownHourTime";
            this.pickShutdownHourTime.Size = new System.Drawing.Size(131, 20);
            this.pickShutdownHourTime.TabIndex = 9;
            this.pickShutdownHourTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pickShutdownHourTime.ValueChanged += new System.EventHandler(this.pickShutdownHourTime_ValueChanged);
            // 
            // shutdownPlanned
            // 
            this.shutdownPlanned.BackColor = System.Drawing.Color.DarkGreen;
            this.shutdownPlanned.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shutdownPlanned.ForeColor = System.Drawing.SystemColors.Control;
            this.shutdownPlanned.Location = new System.Drawing.Point(11, 283);
            this.shutdownPlanned.Name = "shutdownPlanned";
            this.shutdownPlanned.Size = new System.Drawing.Size(760, 35);
            this.shutdownPlanned.TabIndex = 10;
            this.shutdownPlanned.Text = "There is no shutdown planned currently!";
            this.shutdownPlanned.UseVisualStyleBackColor = false;
            this.shutdownPlanned.Click += new System.EventHandler(this.shutdownPlanned_Click);
            // 
            // shutdownTwelveHours
            // 
            this.shutdownTwelveHours.Location = new System.Drawing.Point(13, 181);
            this.shutdownTwelveHours.Name = "shutdownTwelveHours";
            this.shutdownTwelveHours.Size = new System.Drawing.Size(350, 50);
            this.shutdownTwelveHours.TabIndex = 11;
            this.shutdownTwelveHours.Text = "Shutdown in 12 hours";
            this.shutdownTwelveHours.UseVisualStyleBackColor = true;
            this.shutdownTwelveHours.Click += new System.EventHandler(this.shutdownTwelveHours_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.shutdownTwelveHours);
            this.Controls.Add(this.shutdownPlanned);
            this.Controls.Add(this.pickShutdownHourTime);
            this.Controls.Add(this.shutdownXHours);
            this.Controls.Add(this.shutdownSpecificTime);
            this.Controls.Add(this.shutdownSixHours);
            this.Controls.Add(this.cancelShutdown);
            this.Controls.Add(this.shutdownThreeHours);
            this.Controls.Add(this.pickShutdownTime);
            this.Controls.Add(this.shutdownOneHour);
            this.Name = "Form1";
            this.Text = "Windows Shutdowner 3001";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pickShutdownHourTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button shutdownOneHour;
        private System.Windows.Forms.DateTimePicker pickShutdownTime;
        private System.Windows.Forms.Button shutdownThreeHours;
        private System.Windows.Forms.Button cancelShutdown;
        private System.Windows.Forms.Button shutdownSixHours;
        private System.Windows.Forms.Button shutdownSpecificTime;
        private System.Windows.Forms.Button shutdownXHours;
        private System.Windows.Forms.NumericUpDown pickShutdownHourTime;
        private System.Windows.Forms.Button shutdownPlanned;
        private System.Windows.Forms.Button shutdownTwelveHours;
    }
}

