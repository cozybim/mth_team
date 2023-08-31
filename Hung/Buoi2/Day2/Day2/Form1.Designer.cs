namespace Day2
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
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnMaxMinX = new System.Windows.Forms.Button();
            this.btnMaxMinY = new System.Windows.Forms.Button();
            this.btnSortX = new System.Windows.Forms.Button();
            this.btnSortY = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(98, 121);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(85, 23);
            this.btnProfile.TabIndex = 0;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnMaxMinX
            // 
            this.btnMaxMinX.Location = new System.Drawing.Point(433, 121);
            this.btnMaxMinX.Name = "btnMaxMinX";
            this.btnMaxMinX.Size = new System.Drawing.Size(75, 23);
            this.btnMaxMinX.TabIndex = 1;
            this.btnMaxMinX.Text = "MaxMinX";
            this.btnMaxMinX.UseVisualStyleBackColor = true;
            this.btnMaxMinX.Click += new System.EventHandler(this.btnMaxMinX_Click);
            // 
            // btnMaxMinY
            // 
            this.btnMaxMinY.Location = new System.Drawing.Point(433, 165);
            this.btnMaxMinY.Name = "btnMaxMinY";
            this.btnMaxMinY.Size = new System.Drawing.Size(75, 23);
            this.btnMaxMinY.TabIndex = 2;
            this.btnMaxMinY.Text = "MaxMinY";
            this.btnMaxMinY.UseVisualStyleBackColor = true;
            this.btnMaxMinY.Click += new System.EventHandler(this.btnMaxMinY_Click);
            // 
            // btnSortX
            // 
            this.btnSortX.Location = new System.Drawing.Point(433, 218);
            this.btnSortX.Name = "btnSortX";
            this.btnSortX.Size = new System.Drawing.Size(75, 23);
            this.btnSortX.TabIndex = 3;
            this.btnSortX.Text = "SortX";
            this.btnSortX.UseVisualStyleBackColor = true;
            this.btnSortX.Click += new System.EventHandler(this.btnSortX_Click);
            // 
            // btnSortY
            // 
            this.btnSortY.Location = new System.Drawing.Point(433, 265);
            this.btnSortY.Name = "btnSortY";
            this.btnSortY.Size = new System.Drawing.Size(75, 23);
            this.btnSortY.TabIndex = 4;
            this.btnSortY.Text = "SortY";
            this.btnSortY.UseVisualStyleBackColor = true;
            this.btnSortY.Click += new System.EventHandler(this.btnSortY_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSortY);
            this.Controls.Add(this.btnSortX);
            this.Controls.Add(this.btnMaxMinY);
            this.Controls.Add(this.btnMaxMinX);
            this.Controls.Add(this.btnProfile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnMaxMinX;
        private System.Windows.Forms.Button btnMaxMinY;
        private System.Windows.Forms.Button btnSortX;
        private System.Windows.Forms.Button btnSortY;
    }
}

