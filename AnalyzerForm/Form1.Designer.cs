﻿namespace AnalyzerForm
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
            this.contentsLogFiles = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.value = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.startLine = new System.Windows.Forms.TextBox();
            this.numberLines = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
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
            // contentsLogFiles
            // 
            this.contentsLogFiles.Location = new System.Drawing.Point(12, 41);
            this.contentsLogFiles.Name = "contentsLogFiles";
            this.contentsLogFiles.Size = new System.Drawing.Size(786, 125);
            this.contentsLogFiles.TabIndex = 1;
            this.contentsLogFiles.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(12, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 96);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose report";
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
            this.reportSpecifiedNumberOfRows.Location = new System.Drawing.Point(603, 19);
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
            this.reportWeightingCoefficient.Location = new System.Drawing.Point(343, 19);
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
            this.reportUniqueIp.Location = new System.Drawing.Point(203, 19);
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
            this.reportDate.Location = new System.Drawing.Point(6, 19);
            this.reportDate.Name = "reportDate";
            this.reportDate.Size = new System.Drawing.Size(81, 17);
            this.reportDate.TabIndex = 0;
            this.reportDate.TabStop = true;
            this.reportDate.Text = "Report date";
            this.reportDate.UseVisualStyleBackColor = true;
            this.reportDate.CheckedChanged += new System.EventHandler(this.reportDate_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 331);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(779, 78);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // value
            // 
            this.value.Location = new System.Drawing.Point(440, 39);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(74, 20);
            this.value.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(350, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 52);
            this.label3.TabIndex = 9;
            this.label3.Text = "Method or\r\nFileExtension or \r\nProtocol or \r\nStatusCode: ";
            // 
            // startLine
            // 
            this.startLine.Location = new System.Drawing.Point(720, 42);
            this.startLine.Name = "startLine";
            this.startLine.Size = new System.Drawing.Size(60, 20);
            this.startLine.TabIndex = 10;
            // 
            // numberLines
            // 
            this.numberLines.Location = new System.Drawing.Point(720, 65);
            this.numberLines.Name = "numberLines";
            this.numberLines.Size = new System.Drawing.Size(59, 20);
            this.numberLines.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 438);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.contentsLogFiles);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox contentsLogFiles;
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
    }
}
