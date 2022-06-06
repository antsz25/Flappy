
namespace Flappy
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
            this.upipeline = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.dpipeline = new System.Windows.Forms.PictureBox();
            this.pbbase = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.lbscore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.upipeline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpipeline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbbase)).BeginInit();
            this.SuspendLayout();
            // 
            // upipeline
            // 
            this.upipeline.BackColor = System.Drawing.Color.Transparent;
            this.upipeline.Image = global::Flappy.Properties.Resources.tubo_arriba;
            this.upipeline.Location = new System.Drawing.Point(180, 296);
            this.upipeline.Name = "upipeline";
            this.upipeline.Size = new System.Drawing.Size(100, 250);
            this.upipeline.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.upipeline.TabIndex = 0;
            this.upipeline.TabStop = false;
            // 
            // bird
            // 
            this.bird.BackColor = System.Drawing.Color.Transparent;
            this.bird.Image = global::Flappy.Properties.Resources.bird;
            this.bird.Location = new System.Drawing.Point(45, 225);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(41, 36);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 1;
            this.bird.TabStop = false;
            // 
            // dpipeline
            // 
            this.dpipeline.BackColor = System.Drawing.Color.Transparent;
            this.dpipeline.Image = global::Flappy.Properties.Resources.tubo_abajo;
            this.dpipeline.Location = new System.Drawing.Point(192, -89);
            this.dpipeline.Name = "dpipeline";
            this.dpipeline.Size = new System.Drawing.Size(100, 301);
            this.dpipeline.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dpipeline.TabIndex = 2;
            this.dpipeline.TabStop = false;
            // 
            // pbbase
            // 
            this.pbbase.BackColor = System.Drawing.Color.Transparent;
            this.pbbase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbbase.Image = global::Flappy.Properties.Resources._base;
            this.pbbase.Location = new System.Drawing.Point(-274, 443);
            this.pbbase.Name = "pbbase";
            this.pbbase.Size = new System.Drawing.Size(779, 30);
            this.pbbase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbbase.TabIndex = 3;
            this.pbbase.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1;
            // 
            // lbscore
            // 
            this.lbscore.AutoSize = true;
            this.lbscore.BackColor = System.Drawing.Color.Transparent;
            this.lbscore.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbscore.Location = new System.Drawing.Point(52, 198);
            this.lbscore.Name = "lbscore";
            this.lbscore.Size = new System.Drawing.Size(27, 25);
            this.lbscore.TabIndex = 4;
            this.lbscore.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Flappy.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(292, 464);
            this.Controls.Add(this.lbscore);
            this.Controls.Add(this.pbbase);
            this.Controls.Add(this.dpipeline);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.upipeline);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.upipeline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpipeline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbbase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox upipeline;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox dpipeline;
        private System.Windows.Forms.PictureBox pbbase;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label lbscore;
    }
}

