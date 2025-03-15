namespace Cafe_App.Admin
{
    partial class NoticeForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.publishButton = new System.Windows.Forms.Button();
            this.noticeTxt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.publishButton);
            this.panel1.Controls.Add(this.noticeTxt);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 350);
            this.panel1.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(406, 248);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(90, 39);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(153, 248);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(90, 39);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // publishButton
            // 
            this.publishButton.Location = new System.Drawing.Point(48, 248);
            this.publishButton.Name = "publishButton";
            this.publishButton.Size = new System.Drawing.Size(90, 39);
            this.publishButton.TabIndex = 1;
            this.publishButton.Text = "Publish";
            this.publishButton.UseVisualStyleBackColor = true;
            this.publishButton.Click += new System.EventHandler(this.publishButton_Click);
            // 
            // noticeTxt
            // 
            this.noticeTxt.Location = new System.Drawing.Point(48, 22);
            this.noticeTxt.Multiline = true;
            this.noticeTxt.Name = "noticeTxt";
            this.noticeTxt.Size = new System.Drawing.Size(448, 205);
            this.noticeTxt.TabIndex = 0;
            // 
            // NoticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 350);
            this.Controls.Add(this.panel1);
            this.Name = "NoticeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoticeForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NoticeForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button publishButton;
        private System.Windows.Forms.TextBox noticeTxt;
        private System.Windows.Forms.Button backButton;
    }
}