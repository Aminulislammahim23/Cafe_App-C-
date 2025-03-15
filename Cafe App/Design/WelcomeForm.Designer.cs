namespace Cafe_App
{
    partial class WelcomeForm
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
            this.StartingProgress = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSplashForm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartingProgress
            // 
            this.StartingProgress.Location = new System.Drawing.Point(-1, 394);
            this.StartingProgress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartingProgress.Name = "StartingProgress";
            this.StartingProgress.Size = new System.Drawing.Size(689, 26);
            this.StartingProgress.TabIndex = 0;
            this.StartingProgress.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblSplashForm
            // 
            this.lblSplashForm.AutoSize = true;
            this.lblSplashForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblSplashForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSplashForm.Location = new System.Drawing.Point(99, 193);
            this.lblSplashForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSplashForm.Name = "lblSplashForm";
            this.lblSplashForm.Size = new System.Drawing.Size(513, 54);
            this.lblSplashForm.TabIndex = 1;
            this.lblSplashForm.Text = "Welcome to C# C@FE";
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cafe_App.Properties.Resources.pngtree_restaurant_menu_background_material_picture_image_10527972;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(688, 419);
            this.Controls.Add(this.lblSplashForm);
            this.Controls.Add(this.StartingProgress);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar StartingProgress;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSplashForm;
    }
}