namespace AnalyzerForm
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.getSum = new System.Windows.Forms.RadioButton();
            this.numberLines = new System.Windows.Forms.TextBox();
            this.startLine = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.value = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.TextBox();
            this.startDate = new System.Windows.Forms.TextBox();
            this.reportSpecifiedNumberOfRows = new System.Windows.Forms.RadioButton();
            this.reportWeightingCoefficient = new System.Windows.Forms.RadioButton();
            this.reportUniqueIp = new System.Windows.Forms.RadioButton();
            this.reportDate = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Method = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Protocol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileExtension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfBytes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open event file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.getSum);
            this.groupBox1.Controls.Add(this.numberLines);
            this.groupBox1.Controls.Add(this.startLine);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.value);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.endDate);
            this.groupBox1.Controls.Add(this.startDate);
            this.groupBox1.Controls.Add(this.reportSpecifiedNumberOfRows);
            this.groupBox1.Controls.Add(this.reportWeightingCoefficient);
            this.groupBox1.Controls.Add(this.reportUniqueIp);
            this.groupBox1.Controls.Add(this.reportDate);
            this.groupBox1.Location = new System.Drawing.Point(12, 378);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1012, 96);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose report";
            // 
            // getSum
            // 
            this.getSum.AutoSize = true;
            this.getSum.Location = new System.Drawing.Point(347, 19);
            this.getSum.Name = "getSum";
            this.getSum.Size = new System.Drawing.Size(92, 17);
            this.getSum.TabIndex = 12;
            this.getSum.TabStop = true;
            this.getSum.Text = "Get sum bytes";
            this.getSum.UseVisualStyleBackColor = true;
            // 
            // numberLines
            // 
            this.numberLines.Location = new System.Drawing.Point(946, 70);
            this.numberLines.Name = "numberLines";
            this.numberLines.Size = new System.Drawing.Size(59, 20);
            this.numberLines.TabIndex = 11;
            // 
            // startLine
            // 
            this.startLine.Location = new System.Drawing.Point(946, 45);
            this.startLine.Name = "startLine";
            this.startLine.Size = new System.Drawing.Size(60, 20);
            this.startLine.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(627, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 52);
            this.label3.TabIndex = 9;
            this.label3.Text = "Method or\r\nFileExtension or \r\nProtocol or \r\nStatusCode: ";
            // 
            // value
            // 
            this.value.Location = new System.Drawing.Point(717, 39);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(74, 20);
            this.value.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "End date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Start date:";
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(66, 65);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(131, 20);
            this.endDate.TabIndex = 5;
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(66, 39);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(131, 20);
            this.startDate.TabIndex = 4;
            // 
            // reportSpecifiedNumberOfRows
            // 
            this.reportSpecifiedNumberOfRows.AutoSize = true;
            this.reportSpecifiedNumberOfRows.Location = new System.Drawing.Point(829, 19);
            this.reportSpecifiedNumberOfRows.Name = "reportSpecifiedNumberOfRows";
            this.reportSpecifiedNumberOfRows.Size = new System.Drawing.Size(177, 17);
            this.reportSpecifiedNumberOfRows.TabIndex = 3;
            this.reportSpecifiedNumberOfRows.TabStop = true;
            this.reportSpecifiedNumberOfRows.Text = "Report specified number of rows";
            this.reportSpecifiedNumberOfRows.UseVisualStyleBackColor = true;
            // 
            // reportWeightingCoefficient
            // 
            this.reportWeightingCoefficient.AutoSize = true;
            this.reportWeightingCoefficient.Location = new System.Drawing.Point(620, 19);
            this.reportWeightingCoefficient.Name = "reportWeightingCoefficient";
            this.reportWeightingCoefficient.Size = new System.Drawing.Size(171, 17);
            this.reportWeightingCoefficient.TabIndex = 2;
            this.reportWeightingCoefficient.TabStop = true;
            this.reportWeightingCoefficient.Text = "Report weighting coefficient by";
            this.reportWeightingCoefficient.UseVisualStyleBackColor = true;
            // 
            // reportUniqueIp
            // 
            this.reportUniqueIp.AutoSize = true;
            this.reportUniqueIp.Location = new System.Drawing.Point(481, 19);
            this.reportUniqueIp.Name = "reportUniqueIp";
            this.reportUniqueIp.Size = new System.Drawing.Size(103, 17);
            this.reportUniqueIp.TabIndex = 1;
            this.reportUniqueIp.TabStop = true;
            this.reportUniqueIp.Text = "Report unique ip";
            this.reportUniqueIp.UseVisualStyleBackColor = true;
            // 
            // reportDate
            // 
            this.reportDate.AutoSize = true;
            this.reportDate.Location = new System.Drawing.Point(224, 19);
            this.reportDate.Name = "reportDate";
            this.reportDate.Size = new System.Drawing.Size(81, 17);
            this.reportDate.TabIndex = 0;
            this.reportDate.TabStop = true;
            this.reportDate.Text = "Report date";
            this.reportDate.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 480);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1015, 135);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 506);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Analyzer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ip,
            this.UserName,
            this.Date,
            this.Method,
            this.Protocol,
            this.fileName,
            this.FileExtension,
            this.StatusCode,
            this.NumberOfBytes});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1009, 312);
            this.dataGridView1.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1015, 331);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // Ip
            // 
            this.Ip.HeaderText = "Ip";
            this.Ip.Name = "Ip";
            // 
            // UserName
            // 
            this.UserName.HeaderText = "User name";
            this.UserName.Name = "UserName";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.Width = 150;
            // 
            // Method
            // 
            this.Method.HeaderText = "Method";
            this.Method.Name = "Method";
            // 
            // Protocol
            // 
            this.Protocol.HeaderText = "Protocol";
            this.Protocol.Name = "Protocol";
            this.Protocol.Width = 110;
            // 
            // fileName
            // 
            this.fileName.HeaderText = "File name";
            this.fileName.Name = "fileName";
            this.fileName.Width = 150;
            // 
            // FileExtension
            // 
            this.FileExtension.HeaderText = "File Extension";
            this.FileExtension.Name = "FileExtension";
            this.FileExtension.Width = 80;
            // 
            // StatusCode
            // 
            this.StatusCode.HeaderText = "Status Code";
            this.StatusCode.Name = "StatusCode";
            // 
            // NumberOfBytes
            // 
            this.NumberOfBytes.HeaderText = "Number Of Bytes";
            this.NumberOfBytes.Name = "NumberOfBytes";
            this.NumberOfBytes.Width = 75;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 627);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton reportSpecifiedNumberOfRows;
        private System.Windows.Forms.RadioButton reportWeightingCoefficient;
        private System.Windows.Forms.RadioButton reportUniqueIp;
        private System.Windows.Forms.RadioButton reportDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox endDate;
        private System.Windows.Forms.TextBox startDate;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.TextBox numberLines;
        private System.Windows.Forms.TextBox startLine;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton getSum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Method;
        private System.Windows.Forms.DataGridViewTextBoxColumn Protocol;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileExtension;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfBytes;
    }
}

