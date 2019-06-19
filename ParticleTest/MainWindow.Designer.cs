namespace ParticleTest
{
    partial class MainWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLiveTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbColor = new System.Windows.Forms.PictureBox();
            this.txtVolumeUpper = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVolumeLower = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtForce = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.particleTimer = new System.Windows.Forms.Timer(this.components);
            this.panMain = new System.Windows.Forms.Panel();
            this.txtDensityUpper = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDensityLower = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSpeedDecay = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtSpeedDecay);
            this.panel1.Controls.Add(this.txtDensityUpper);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtDensityLower);
            this.panel1.Controls.Add(this.txtLiveTime);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pbColor);
            this.panel1.Controls.Add(this.txtVolumeUpper);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnColor);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtVolumeLower);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtForce);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1153, 75);
            this.panel1.TabIndex = 0;
            // 
            // txtLiveTime
            // 
            this.txtLiveTime.Location = new System.Drawing.Point(159, 38);
            this.txtLiveTime.Name = "txtLiveTime";
            this.txtLiveTime.Size = new System.Drawing.Size(51, 20);
            this.txtLiveTime.TabIndex = 12;
            this.txtLiveTime.Text = "4000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Live Time (milliseconds):";
            // 
            // pbColor
            // 
            this.pbColor.BackColor = System.Drawing.Color.Blue;
            this.pbColor.Location = new System.Drawing.Point(1088, 12);
            this.pbColor.Name = "pbColor";
            this.pbColor.Size = new System.Drawing.Size(53, 50);
            this.pbColor.TabIndex = 10;
            this.pbColor.TabStop = false;
            // 
            // txtVolumeUpper
            // 
            this.txtVolumeUpper.Location = new System.Drawing.Point(444, 12);
            this.txtVolumeUpper.Name = "txtVolumeUpper";
            this.txtVolumeUpper.Size = new System.Drawing.Size(51, 20);
            this.txtVolumeUpper.TabIndex = 9;
            this.txtVolumeUpper.Text = "15";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(391, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "(Upper)";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(1007, 12);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 6;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColorOnClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(239, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Volume: (Lower)";
            // 
            // txtVolumeLower
            // 
            this.txtVolumeLower.Location = new System.Drawing.Point(334, 12);
            this.txtVolumeLower.Name = "txtVolumeLower";
            this.txtVolumeLower.Size = new System.Drawing.Size(51, 20);
            this.txtVolumeLower.TabIndex = 4;
            this.txtVolumeLower.Text = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(513, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Force:";
            // 
            // txtForce
            // 
            this.txtForce.Location = new System.Drawing.Point(557, 12);
            this.txtForce.Name = "txtForce";
            this.txtForce.Size = new System.Drawing.Size(51, 20);
            this.txtForce.TabIndex = 2;
            this.txtForce.Text = "50";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(100, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Amount:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(159, 12);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(51, 20);
            this.txtAmount.TabIndex = 0;
            this.txtAmount.Text = "10";
            // 
            // particleTimer
            // 
            this.particleTimer.Enabled = true;
            this.particleTimer.Interval = 25;
            this.particleTimer.Tick += new System.EventHandler(this.ParticleTimer_Tick);
            // 
            // panMain
            // 
            this.panMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMain.Location = new System.Drawing.Point(0, 75);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(1153, 620);
            this.panMain.TabIndex = 1;
            this.panMain.Paint += new System.Windows.Forms.PaintEventHandler(this.PanMain_Paint);
            this.panMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanMain_MouseDown);
            // 
            // txtDensityUpper
            // 
            this.txtDensityUpper.Location = new System.Drawing.Point(444, 42);
            this.txtDensityUpper.Name = "txtDensityUpper";
            this.txtDensityUpper.Size = new System.Drawing.Size(51, 20);
            this.txtDensityUpper.TabIndex = 16;
            this.txtDensityUpper.Text = "5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(391, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "(Upper)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(239, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Density: (Lower)";
            // 
            // txtDensityLower
            // 
            this.txtDensityLower.Location = new System.Drawing.Point(334, 42);
            this.txtDensityLower.Name = "txtDensityLower";
            this.txtDensityLower.Size = new System.Drawing.Size(51, 20);
            this.txtDensityLower.TabIndex = 13;
            this.txtDensityLower.Text = "5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(642, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Speed Decay (1 is no decay):";
            // 
            // txtSpeedDecay
            // 
            this.txtSpeedDecay.Location = new System.Drawing.Point(802, 12);
            this.txtSpeedDecay.Name = "txtSpeedDecay";
            this.txtSpeedDecay.Size = new System.Drawing.Size(51, 20);
            this.txtSpeedDecay.TabIndex = 17;
            this.txtSpeedDecay.Text = "1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 695);
            this.Controls.Add(this.panMain);
            this.Controls.Add(this.panel1);
            this.Name = "MainWindow";
            this.Text = "Particle Engine";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Timer particleTimer;
        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVolumeLower;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtForce;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.TextBox txtVolumeUpper;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbColor;
        private System.Windows.Forms.TextBox txtLiveTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDensityUpper;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDensityLower;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSpeedDecay;
    }
}

