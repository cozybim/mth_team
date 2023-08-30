namespace MyProperties
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
            this.BtnVector = new System.Windows.Forms.Button();
            this.TxtInput01 = new System.Windows.Forms.TextBox();
            this.TxtInput02 = new System.Windows.Forms.TextBox();
            this.BtnPoint2d = new System.Windows.Forms.Button();
            this.BtnPoint3d = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnVector
            // 
            this.BtnVector.Location = new System.Drawing.Point(12, 12);
            this.BtnVector.Name = "BtnVector";
            this.BtnVector.Size = new System.Drawing.Size(123, 36);
            this.BtnVector.TabIndex = 0;
            this.BtnVector.Text = "Vector";
            this.BtnVector.UseVisualStyleBackColor = true;
            this.BtnVector.Click += new System.EventHandler(this.BtnVector_Click);
            // 
            // TxtInput01
            // 
            this.TxtInput01.Location = new System.Drawing.Point(430, 94);
            this.TxtInput01.Name = "TxtInput01";
            this.TxtInput01.Size = new System.Drawing.Size(210, 22);
            this.TxtInput01.TabIndex = 1;
            // 
            // TxtInput02
            // 
            this.TxtInput02.Location = new System.Drawing.Point(430, 137);
            this.TxtInput02.Name = "TxtInput02";
            this.TxtInput02.Size = new System.Drawing.Size(210, 22);
            this.TxtInput02.TabIndex = 2;
            // 
            // BtnPoint2d
            // 
            this.BtnPoint2d.Location = new System.Drawing.Point(12, 54);
            this.BtnPoint2d.Name = "BtnPoint2d";
            this.BtnPoint2d.Size = new System.Drawing.Size(123, 36);
            this.BtnPoint2d.TabIndex = 3;
            this.BtnPoint2d.Text = "Point2d";
            this.BtnPoint2d.UseVisualStyleBackColor = true;
            this.BtnPoint2d.Click += new System.EventHandler(this.BtnPoint2d_Click);
            // 
            // BtnPoint3d
            // 
            this.BtnPoint3d.Location = new System.Drawing.Point(12, 96);
            this.BtnPoint3d.Name = "BtnPoint3d";
            this.BtnPoint3d.Size = new System.Drawing.Size(123, 36);
            this.BtnPoint3d.TabIndex = 4;
            this.BtnPoint3d.Text = "Point3d";
            this.BtnPoint3d.UseVisualStyleBackColor = true;
            this.BtnPoint3d.Click += new System.EventHandler(this.BtnPoint3d_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 455);
            this.Controls.Add(this.BtnPoint3d);
            this.Controls.Add(this.BtnPoint2d);
            this.Controls.Add(this.TxtInput02);
            this.Controls.Add(this.TxtInput01);
            this.Controls.Add(this.BtnVector);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnVector;
        private System.Windows.Forms.TextBox TxtInput01;
        private System.Windows.Forms.TextBox TxtInput02;
        private System.Windows.Forms.Button BtnPoint2d;
        private System.Windows.Forms.Button BtnPoint3d;
    }
}

