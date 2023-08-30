namespace Sample_05_overload
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
            this.BtnOverload = new System.Windows.Forms.Button();
            this.BtnMoRong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnOverload
            // 
            this.BtnOverload.Location = new System.Drawing.Point(12, 12);
            this.BtnOverload.Name = "BtnOverload";
            this.BtnOverload.Size = new System.Drawing.Size(147, 51);
            this.BtnOverload.TabIndex = 0;
            this.BtnOverload.Text = "Overload";
            this.BtnOverload.UseVisualStyleBackColor = true;
            this.BtnOverload.Click += new System.EventHandler(this.BtnOverload_Click);
            // 
            // BtnMoRong
            // 
            this.BtnMoRong.Location = new System.Drawing.Point(12, 69);
            this.BtnMoRong.Name = "BtnMoRong";
            this.BtnMoRong.Size = new System.Drawing.Size(147, 51);
            this.BtnMoRong.TabIndex = 1;
            this.BtnMoRong.Text = "Mở rộng";
            this.BtnMoRong.UseVisualStyleBackColor = true;
            this.BtnMoRong.Click += new System.EventHandler(this.BtnMoRong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 320);
            this.Controls.Add(this.BtnMoRong);
            this.Controls.Add(this.BtnOverload);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnOverload;
        private System.Windows.Forms.Button BtnMoRong;
    }
}

