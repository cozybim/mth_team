namespace Sample_07_BoKhoiTao
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
            this.BtnPoint = new System.Windows.Forms.Button();
            this.BtnDisstanceTo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnPoint
            // 
            this.BtnPoint.Location = new System.Drawing.Point(45, 24);
            this.BtnPoint.Name = "BtnPoint";
            this.BtnPoint.Size = new System.Drawing.Size(144, 45);
            this.BtnPoint.TabIndex = 0;
            this.BtnPoint.Text = "Point";
            this.BtnPoint.UseVisualStyleBackColor = true;
            this.BtnPoint.Click += new System.EventHandler(this.BtnPoint_Click);
            // 
            // BtnDisstanceTo
            // 
            this.BtnDisstanceTo.Location = new System.Drawing.Point(45, 89);
            this.BtnDisstanceTo.Name = "BtnDisstanceTo";
            this.BtnDisstanceTo.Size = new System.Drawing.Size(144, 45);
            this.BtnDisstanceTo.TabIndex = 1;
            this.BtnDisstanceTo.Text = "Distance To";
            this.BtnDisstanceTo.UseVisualStyleBackColor = true;
            this.BtnDisstanceTo.Click += new System.EventHandler(this.BtnDisstanceTo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 353);
            this.Controls.Add(this.BtnDisstanceTo);
            this.Controls.Add(this.BtnPoint);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnPoint;
        private System.Windows.Forms.Button BtnDisstanceTo;
    }
}

