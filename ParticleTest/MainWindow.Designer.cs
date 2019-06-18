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
            this.pbColor = new System.Windows.Forms.PictureBox();
            this.txtMassUpper = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMassLower = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtForce = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.particleTimer = new System.Windows.Forms.Timer(this.components);
            this.panMain = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLiveTime = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.txtLiveTime);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pbColor);
            this.panel1.Controls.Add(this.txtMassUpper);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnColor);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMassLower);
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
            // pbColor
            // 
            this.pbColor.BackColor = System.Drawing.Color.Blue;
            this.pbColor.Location = new System.Drawing.Point(1088, 12);
            this.pbColor.Name = "pbColor";
            this.pbColor.Size = new System.Drawing.Size(53, 50);
            this.pbColor.TabIndex = 10;
            this.pbColor.TabStop = false;
            // 
            // txtMassUpper
            // 
            this.txtMassUpper.Location = new System.Drawing.Point(435, 12);
            this.txtMassUpper.Name = "txtMassUpper";
            this.txtMassUpper.Size = new System.Drawing.Size(51, 20);
            this.txtMassUpper.TabIndex = 9;
            this.txtMassUpper.Text = "15";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(382, 15);
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
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mass: (Lower)";
            // 
            // txtMassLower
            // 
            this.txtMassLower.Location = new System.Drawing.Point(325, 12);
            this.txtMassLower.Name = "txtMassLower";
            this.txtMassLower.Size = new System.Drawing.Size(51, 20);
            this.txtMassLower.TabIndex = 4;
            this.txtMassLower.Text = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(281, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Force:";
            // 
            // txtForce
            // 
            this.txtForce.Location = new System.Drawing.Point(325, 38);
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
            // txtLiveTime
            // 
            this.txtLiveTime.Location = new System.Drawing.Point(159, 38);
            this.txtLiveTime.Name = "txtLiveTime";
            this.txtLiveTime.Size = new System.Drawing.Size(51, 20);
            this.txtLiveTime.TabIndex = 12;
            this.txtLiveTime.Text = "4000";
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
        private System.Windows.Forms.TextBox txtMassLower;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtForce;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.TextBox txtMassUpper;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbColor;
        private System.Windows.Forms.TextBox txtLiveTime;
        private System.Windows.Forms.Label label4;
    }
}

