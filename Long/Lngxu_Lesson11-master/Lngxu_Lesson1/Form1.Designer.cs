namespace Lngxu_Lesson1
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
            this.Btn_RecProfile = new System.Windows.Forms.Button();
            this.FindMaxPointX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_RecProfile
            // 
            this.Btn_RecProfile.Location = new System.Drawing.Point(12, 12);
            this.Btn_RecProfile.Name = "Btn_RecProfile";
            this.Btn_RecProfile.Size = new System.Drawing.Size(154, 57);
            this.Btn_RecProfile.TabIndex = 0;
            this.Btn_RecProfile.Text = "ProfileRectange";
            this.Btn_RecProfile.UseVisualStyleBackColor = true;
            this.Btn_RecProfile.Click += new System.EventHandler(this.Btn_RecProfile_Click);
            // 
            // FindMaxPointX
            // 
            this.FindMaxPointX.Location = new System.Drawing.Point(12, 75);
            this.FindMaxPointX.Name = "FindMaxPointX";
            this.FindMaxPointX.Size = new System.Drawing.Size(154, 57);
            this.FindMaxPointX.TabIndex = 1;
            this.FindMaxPointX.Text = "ShowPoint";
            this.FindMaxPointX.UseVisualStyleBackColor = true;
            this.FindMaxPointX.Click += new System.EventHandler(this.FindMaxPointX_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 186);
            this.Controls.Add(this.FindMaxPointX);
            this.Controls.Add(this.Btn_RecProfile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_RecProfile;
        private System.Windows.Forms.Button FindMaxPointX;
    }
}

