namespace MyDelegate
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
            this.BtnDelegate = new System.Windows.Forms.Button();
            this.BtnCalDelegate = new System.Windows.Forms.Button();
            this.BtnCircle = new System.Windows.Forms.Button();
            this.BtnClickEvent = new System.Windows.Forms.Button();
            this.DgvFiles = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAddRow = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnSelection = new System.Windows.Forms.Button();
            this.BtnDeleteMulti = new System.Windows.Forms.Button();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtPath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDelegate
            // 
            this.BtnDelegate.Location = new System.Drawing.Point(12, 15);
            this.BtnDelegate.Name = "BtnDelegate";
            this.BtnDelegate.Size = new System.Drawing.Size(114, 43);
            this.BtnDelegate.TabIndex = 0;
            this.BtnDelegate.Text = "Delegate";
            this.BtnDelegate.UseVisualStyleBackColor = true;
            this.BtnDelegate.Click += new System.EventHandler(this.BtnDelegate_Click);
            // 
            // BtnCalDelegate
            // 
            this.BtnCalDelegate.Location = new System.Drawing.Point(12, 64);
            this.BtnCalDelegate.Name = "BtnCalDelegate";
            this.BtnCalDelegate.Size = new System.Drawing.Size(182, 43);
            this.BtnCalDelegate.TabIndex = 1;
            this.BtnCalDelegate.Text = "Calc Delegate";
            this.BtnCalDelegate.UseVisualStyleBackColor = true;
            this.BtnCalDelegate.Click += new System.EventHandler(this.BtnCalDelegate_Click);
            // 
            // BtnCircle
            // 
            this.BtnCircle.Location = new System.Drawing.Point(12, 113);
            this.BtnCircle.Name = "BtnCircle";
            this.BtnCircle.Size = new System.Drawing.Size(182, 43);
            this.BtnCircle.TabIndex = 2;
            this.BtnCircle.Text = "Circle";
            this.BtnCircle.UseVisualStyleBackColor = true;
            this.BtnCircle.Click += new System.EventHandler(this.BtnCircle_Click);
            // 
            // BtnClickEvent
            // 
            this.BtnClickEvent.Location = new System.Drawing.Point(12, 162);
            this.BtnClickEvent.Name = "BtnClickEvent";
            this.BtnClickEvent.Size = new System.Drawing.Size(182, 43);
            this.BtnClickEvent.TabIndex = 3;
            this.BtnClickEvent.Text = "Click event";
            this.BtnClickEvent.UseVisualStyleBackColor = true;
            this.BtnClickEvent.Click += new System.EventHandler(this.Xuly);
            // 
            // DgvFiles
            // 
            this.DgvFiles.AllowUserToAddRows = false;
            this.DgvFiles.AllowUserToDeleteRows = false;
            this.DgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColName,
            this.ColPath});
            this.DgvFiles.Location = new System.Drawing.Point(209, 15);
            this.DgvFiles.Name = "DgvFiles";
            this.DgvFiles.ReadOnly = true;
            this.DgvFiles.RowHeadersVisible = false;
            this.DgvFiles.RowHeadersWidth = 51;
            this.DgvFiles.RowTemplate.Height = 24;
            this.DgvFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvFiles.Size = new System.Drawing.Size(402, 364);
            this.DgvFiles.TabIndex = 4;
            this.DgvFiles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFiles_CellClick);
            // 
            // ColId
            // 
            this.ColId.HeaderText = "Id";
            this.ColId.MinimumWidth = 6;
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Width = 50;
            // 
            // ColName
            // 
            this.ColName.HeaderText = "File name";
            this.ColName.MinimumWidth = 6;
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            this.ColName.Width = 150;
            // 
            // ColPath
            // 
            this.ColPath.HeaderText = "Path";
            this.ColPath.MinimumWidth = 6;
            this.ColPath.Name = "ColPath";
            this.ColPath.ReadOnly = true;
            this.ColPath.Width = 200;
            // 
            // BtnAddRow
            // 
            this.BtnAddRow.Location = new System.Drawing.Point(641, 206);
            this.BtnAddRow.Name = "BtnAddRow";
            this.BtnAddRow.Size = new System.Drawing.Size(117, 37);
            this.BtnAddRow.TabIndex = 5;
            this.BtnAddRow.Text = "Add Row";
            this.BtnAddRow.UseVisualStyleBackColor = true;
            this.BtnAddRow.Click += new System.EventHandler(this.BtnAddRow_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(641, 255);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(194, 37);
            this.BtnClear.TabIndex = 6;
            this.BtnClear.Text = "Clear Rows";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnSelection
            // 
            this.BtnSelection.Location = new System.Drawing.Point(641, 298);
            this.BtnSelection.Name = "BtnSelection";
            this.BtnSelection.Size = new System.Drawing.Size(194, 37);
            this.BtnSelection.TabIndex = 7;
            this.BtnSelection.Text = "Get Selection";
            this.BtnSelection.UseVisualStyleBackColor = true;
            this.BtnSelection.Click += new System.EventHandler(this.BtnSelection_Click);
            // 
            // BtnDeleteMulti
            // 
            this.BtnDeleteMulti.Location = new System.Drawing.Point(641, 341);
            this.BtnDeleteMulti.Name = "BtnDeleteMulti";
            this.BtnDeleteMulti.Size = new System.Drawing.Size(194, 37);
            this.BtnDeleteMulti.TabIndex = 8;
            this.BtnDeleteMulti.Text = "Delete";
            this.BtnDeleteMulti.UseVisualStyleBackColor = true;
            this.BtnDeleteMulti.Click += new System.EventHandler(this.BtnDeleteMulti_Click);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(641, 19);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(240, 22);
            this.TxtId.TabIndex = 9;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(641, 47);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(240, 22);
            this.TxtName.TabIndex = 10;
            // 
            // TxtPath
            // 
            this.TxtPath.Location = new System.Drawing.Point(641, 75);
            this.TxtPath.Name = "TxtPath";
            this.TxtPath.Size = new System.Drawing.Size(240, 22);
            this.TxtPath.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 448);
            this.Controls.Add(this.TxtPath);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.BtnDeleteMulti);
            this.Controls.Add(this.BtnSelection);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnAddRow);
            this.Controls.Add(this.DgvFiles);
            this.Controls.Add(this.BtnClickEvent);
            this.Controls.Add(this.BtnCircle);
            this.Controls.Add(this.BtnCalDelegate);
            this.Controls.Add(this.BtnDelegate);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DgvFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDelegate;
        private System.Windows.Forms.Button BtnCalDelegate;
        private System.Windows.Forms.Button BtnCircle;
        private System.Windows.Forms.Button BtnClickEvent;
        private System.Windows.Forms.DataGridView DgvFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPath;
        private System.Windows.Forms.Button BtnAddRow;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnSelection;
        private System.Windows.Forms.Button BtnDeleteMulti;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtPath;
    }
}

