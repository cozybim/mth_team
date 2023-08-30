namespace Practise_1
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
            this.Ckb_Width = new System.Windows.Forms.CheckBox();
            this.Ckb_Height = new System.Windows.Forms.CheckBox();
            this.Txt_Width = new System.Windows.Forms.TextBox();
            this.Txt_Height = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_XMax = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ckb_Width
            // 
            this.Ckb_Width.AutoSize = true;
            this.Ckb_Width.Checked = true;
            this.Ckb_Width.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Ckb_Width.Location = new System.Drawing.Point(12, 12);
            this.Ckb_Width.Name = "Ckb_Width";
            this.Ckb_Width.Size = new System.Drawing.Size(63, 20);
            this.Ckb_Width.TabIndex = 0;
            this.Ckb_Width.Text = "Width";
            this.Ckb_Width.UseVisualStyleBackColor = true;
            // 
            // Ckb_Height
            // 
            this.Ckb_Height.AutoSize = true;
            this.Ckb_Height.Checked = true;
            this.Ckb_Height.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Ckb_Height.Location = new System.Drawing.Point(12, 38);
            this.Ckb_Height.Name = "Ckb_Height";
            this.Ckb_Height.Size = new System.Drawing.Size(68, 20);
            this.Ckb_Height.TabIndex = 0;
            this.Ckb_Height.Text = "Height";
            this.Ckb_Height.UseVisualStyleBackColor = true;
            // 
            // Txt_Width
            // 
            this.Txt_Width.Location = new System.Drawing.Point(93, 10);
            this.Txt_Width.Name = "Txt_Width";
            this.Txt_Width.Size = new System.Drawing.Size(60, 22);
            this.Txt_Width.TabIndex = 1;
            this.Txt_Width.Text = "105.5";
            // 
            // Txt_Height
            // 
            this.Txt_Height.Location = new System.Drawing.Point(93, 38);
            this.Txt_Height.Name = "Txt_Height";
            this.Txt_Height.Size = new System.Drawing.Size(60, 22);
            this.Txt_Height.TabIndex = 1;
            this.Txt_Height.Text = "125.5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Rectangular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_XMax
            // 
            this.Btn_XMax.Location = new System.Drawing.Point(166, 154);
            this.Btn_XMax.Name = "Btn_XMax";
            this.Btn_XMax.Size = new System.Drawing.Size(115, 30);
            this.Btn_XMax.TabIndex = 3;
            this.Btn_XMax.Text = "Max/ Min/ Sort";
            this.Btn_XMax.UseVisualStyleBackColor = true;
            this.Btn_XMax.Click += new System.EventHandler(this.Btn_XMax_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 196);
            this.Controls.Add(this.Btn_XMax);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Txt_Height);
            this.Controls.Add(this.Txt_Width);
            this.Controls.Add(this.Ckb_Height);
            this.Controls.Add(this.Ckb_Width);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Ckb_Width;
        private System.Windows.Forms.CheckBox Ckb_Height;
        private System.Windows.Forms.TextBox Txt_Width;
        private System.Windows.Forms.TextBox Txt_Height;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btn_XMax;
    }
}

