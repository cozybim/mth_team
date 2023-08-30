namespace Props
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnVector = new System.Windows.Forms.Button();
            this.BtnPoint2d = new System.Windows.Forms.Button();
            this.BtnTach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnVector
            // 
            this.BtnVector.Location = new System.Drawing.Point(12, 12);
            this.BtnVector.Name = "BtnVector";
            this.BtnVector.Size = new System.Drawing.Size(125, 40);
            this.BtnVector.TabIndex = 0;
            this.BtnVector.Text = "Vector";
            this.BtnVector.UseVisualStyleBackColor = true;
            this.BtnVector.Click += new System.EventHandler(this.BtnVector_Click);
            // 
            // BtnPoint2d
            // 
            this.BtnPoint2d.Location = new System.Drawing.Point(12, 77);
            this.BtnPoint2d.Name = "BtnPoint2d";
            this.BtnPoint2d.Size = new System.Drawing.Size(125, 40);
            this.BtnPoint2d.TabIndex = 1;
            this.BtnPoint2d.Text = "Point2d";
            this.BtnPoint2d.UseVisualStyleBackColor = true;
            this.BtnPoint2d.Click += new System.EventHandler(this.BtnPoint2d_Click);
            // 
            // BtnTach
            // 
            this.BtnTach.Location = new System.Drawing.Point(12, 139);
            this.BtnTach.Name = "BtnTach";
            this.BtnTach.Size = new System.Drawing.Size(125, 35);
            this.BtnTach.TabIndex = 2;
            this.BtnTach.Text = "Tách";
            this.BtnTach.UseVisualStyleBackColor = true;
            this.BtnTach.Click += new System.EventHandler(this.BtnTach_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 296);
            this.Controls.Add(this.BtnTach);
            this.Controls.Add(this.BtnPoint2d);
            this.Controls.Add(this.BtnVector);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnVector;
        private System.Windows.Forms.Button BtnPoint2d;
        private System.Windows.Forms.Button BtnTach;
    }
}

