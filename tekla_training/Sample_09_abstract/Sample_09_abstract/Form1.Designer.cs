namespace Sample_09_abstract
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
<<<<<<< HEAD
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSelectedFile = new System.Windows.Forms.TextBox();
            this.BtnChonFile = new System.Windows.Forms.Button();
            this.TxtPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtFullName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtExtension = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "File:";
            // 
            // TxtSelectedFile
            // 
            this.TxtSelectedFile.Location = new System.Drawing.Point(114, 37);
            this.TxtSelectedFile.Name = "TxtSelectedFile";
            this.TxtSelectedFile.Size = new System.Drawing.Size(413, 22);
            this.TxtSelectedFile.TabIndex = 1;
            // 
            // BtnChonFile
            // 
            this.BtnChonFile.Location = new System.Drawing.Point(570, 30);
            this.BtnChonFile.Name = "BtnChonFile";
            this.BtnChonFile.Size = new System.Drawing.Size(98, 37);
            this.BtnChonFile.TabIndex = 2;
            this.BtnChonFile.Text = "Chọn file";
            this.BtnChonFile.UseVisualStyleBackColor = true;
            this.BtnChonFile.Click += new System.EventHandler(this.BtnChonFile_Click);
            // 
            // TxtPath
            // 
            this.TxtPath.Location = new System.Drawing.Point(114, 84);
            this.TxtPath.Name = "TxtPath";
            this.TxtPath.Size = new System.Drawing.Size(413, 22);
            this.TxtPath.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Path:";
            // 
            // TxtFullName
            // 
            this.TxtFullName.Location = new System.Drawing.Point(114, 112);
            this.TxtFullName.Name = "TxtFullName";
            this.TxtFullName.Size = new System.Drawing.Size(413, 22);
            this.TxtFullName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Full file name:";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(114, 140);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(413, 22);
            this.TxtName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "file name:";
            // 
            // TxtExtension
            // 
            this.TxtExtension.Location = new System.Drawing.Point(114, 168);
            this.TxtExtension.Name = "TxtExtension";
            this.TxtExtension.Size = new System.Drawing.Size(413, 22);
            this.TxtExtension.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "extension:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 301);
            this.Controls.Add(this.TxtExtension);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtFullName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnChonFile);
            this.Controls.Add(this.TxtSelectedFile);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

=======
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
>>>>>>> 2fae0023c926c17a6fe79f7d2197e0a45ce989b5
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSelectedFile;
        private System.Windows.Forms.Button BtnChonFile;
        private System.Windows.Forms.TextBox TxtPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtFullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtExtension;
        private System.Windows.Forms.Label label5;
    }
}

