namespace LicentaV._1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackBary = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.yLabel = new System.Windows.Forms.Label();
            this.zLabel = new System.Windows.Forms.Label();
            this.trackBarz = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.trackBarx = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarx)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(362, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(426, 426);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // trackBary
            // 
            this.trackBary.Location = new System.Drawing.Point(794, 63);
            this.trackBary.Maximum = 360;
            this.trackBary.Minimum = 1;
            this.trackBary.Name = "trackBary";
            this.trackBary.Size = new System.Drawing.Size(233, 45);
            this.trackBary.TabIndex = 1;
            this.trackBary.Value = 45;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(898, 95);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(35, 13);
            this.yLabel.TabIndex = 2;
            this.yLabel.Text = "label1";
            // 
            // zLabel
            // 
            this.zLabel.AutoSize = true;
            this.zLabel.Location = new System.Drawing.Point(898, 146);
            this.zLabel.Name = "zLabel";
            this.zLabel.Size = new System.Drawing.Size(35, 13);
            this.zLabel.TabIndex = 4;
            this.zLabel.Text = "label2";
            // 
            // trackBarz
            // 
            this.trackBarz.Location = new System.Drawing.Point(794, 114);
            this.trackBarz.Maximum = 360;
            this.trackBarz.Minimum = 1;
            this.trackBarz.Name = "trackBarz";
            this.trackBarz.Size = new System.Drawing.Size(233, 45);
            this.trackBarz.TabIndex = 3;
            this.trackBarz.Value = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(877, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "x:";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(898, 44);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(35, 13);
            this.xLabel.TabIndex = 7;
            this.xLabel.Text = "label4";
            // 
            // trackBarx
            // 
            this.trackBarx.Location = new System.Drawing.Point(794, 12);
            this.trackBarx.Maximum = 360;
            this.trackBarx.Minimum = 1;
            this.trackBarx.Name = "trackBarx";
            this.trackBarx.Size = new System.Drawing.Size(233, 45);
            this.trackBarx.TabIndex = 6;
            this.trackBarx.Value = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(877, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(877, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "z:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.zLabel);
            this.Controls.Add(this.trackBarz);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.trackBary);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.trackBarx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackBary;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label zLabel;
        private System.Windows.Forms.TrackBar trackBarz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.TrackBar trackBarx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

