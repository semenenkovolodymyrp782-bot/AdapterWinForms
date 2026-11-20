namespace AdapterWinForms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.ComboBox cmbFormat;
        private System.Windows.Forms.Label lblFormatInfo;
        private System.Windows.Forms.Label lblFileCaption;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnClear;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblContent = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblFile = new System.Windows.Forms.Label();
            this.lblFileCaption = new System.Windows.Forms.Label();
            this.lblFormatInfo = new System.Windows.Forms.Label();
            this.cmbFormat = new System.Windows.Forms.ComboBox();
            this.lblFormat = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.pnlMain.Controls.Add(this.btnClear);
            this.pnlMain.Controls.Add(this.btnRead);
            this.pnlMain.Controls.Add(this.btnSave);
            this.pnlMain.Controls.Add(this.lblContent);
            this.pnlMain.Controls.Add(this.btnOpen);
            this.pnlMain.Controls.Add(this.lblFile);
            this.pnlMain.Controls.Add(this.lblFileCaption);
            this.pnlMain.Controls.Add(this.lblFormatInfo);
            this.pnlMain.Controls.Add(this.cmbFormat);
            this.pnlMain.Controls.Add(this.lblFormat);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(28, 22, 28, 18);
            this.pnlMain.Size = new System.Drawing.Size(760, 720);
            this.pnlMain.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(376, 561);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 42);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Очистити";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.Color.White;
            this.btnRead.FlatAppearance.BorderSize = 0;
            this.btnRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRead.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnRead.ForeColor = System.Drawing.Color.Black;
            this.btnRead.Location = new System.Drawing.Point(200, 561);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(150, 42);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Прочитати";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(24, 561);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 42);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.lblContent.Location = new System.Drawing.Point(34, 239);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(126, 19);
            this.lblContent.TabIndex = 4;
            this.lblContent.Text = "Вміст документа";
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.White;
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnOpen.ForeColor = System.Drawing.Color.Black;
            this.btnOpen.Location = new System.Drawing.Point(34, 183);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(145, 38);
            this.btnOpen.TabIndex = 5;
            this.btnOpen.Text = "Відкрити файл";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lblFile
            // 
            this.lblFile.AutoEllipsis = true;
            this.lblFile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.lblFile.Location = new System.Drawing.Point(34, 151);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(620, 22);
            this.lblFile.TabIndex = 6;
            this.lblFile.Text = "Файл ще не вибрано";
            // 
            // lblFileCaption
            // 
            this.lblFileCaption.AutoSize = true;
            this.lblFileCaption.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFileCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.lblFileCaption.Location = new System.Drawing.Point(34, 126);
            this.lblFileCaption.Name = "lblFileCaption";
            this.lblFileCaption.Size = new System.Drawing.Size(119, 19);
            this.lblFileCaption.TabIndex = 7;
            this.lblFileCaption.Text = "Поточний файл";
            // 
            // lblFormatInfo
            // 
            this.lblFormatInfo.AutoSize = true;
            this.lblFormatInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFormatInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.lblFormatInfo.Location = new System.Drawing.Point(34, 88);
            this.lblFormatInfo.Name = "lblFormatInfo";
            this.lblFormatInfo.Size = new System.Drawing.Size(50, 15);
            this.lblFormatInfo.TabIndex = 8;
            this.lblFormatInfo.Text = "Формат";
            // 
            // cmbFormat
            // 
            this.cmbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFormat.Items.AddRange(new object[] {
            "Word (.docx)",
            "Excel (.xlsx)",
            "Звичайний текст (.txt)"});
            this.cmbFormat.Location = new System.Drawing.Point(34, 54);
            this.cmbFormat.Name = "cmbFormat";
            this.cmbFormat.Size = new System.Drawing.Size(285, 25);
            this.cmbFormat.TabIndex = 9;
            this.cmbFormat.SelectedIndexChanged += new System.EventHandler(this.cmbFormat_SelectedIndexChanged);
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFormat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.lblFormat.Location = new System.Drawing.Point(30, 25);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(144, 19);
            this.lblFormat.TabIndex = 10;
            this.lblFormat.Text = "Формат документа";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(760, 720);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(700, 680);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adapter";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
