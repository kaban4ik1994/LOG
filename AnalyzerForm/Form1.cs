using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Convert_Item_To_String.Converter;
using Convert_Item_To_String.Converter_Parameters;
using File_Analyzer;
using LOG;

namespace AnalyzerForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private LogReader _logReader;


        private void button1_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            var filePath = string.Empty;

            richTextBox1.ResetText();
            if (result == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;

            }

            _logReader = new LogReader(filePath);
            var converterIp = new ConverterIp();
            var converterDate = new ConverterDate();
            dataGridView1.RowCount = _logReader.EventList.Count();
            for (var i = 0; i < _logReader.EventList.Count(); i++)
            {
                dataGridView1[0, i].Value = converterIp.Convert(new ConverterParametersIp { Ip = _logReader.EventList.ElementAt(i).Ip });
                dataGridView1[1, i].Value = "-";
                dataGridView1[2, i].Value =
                    converterDate.Convert(new ConverterParametersDate
                    {
                        DateTime = _logReader.EventList.ElementAt(i).Date
                    });
                dataGridView1[3, i].Value = _logReader.EventList.ElementAt(i).Method;
                dataGridView1[4, i].Value = _logReader.EventList.ElementAt(i).Protocol;
                dataGridView1[5, i].Value = _logReader.EventList.ElementAt(i).FileName;
                dataGridView1[6, i].Value = _logReader.EventList.ElementAt(i).FileExtension;
                dataGridView1[7, i].Value = _logReader.EventList.ElementAt(i).StatusCode;
                dataGridView1[8, i].Value = _logReader.EventList.ElementAt(i).NumberOfBytes;

            }
           
            startDate.Text = @"2009-12-29T12:54:59";
            endDate.Text = @"2009-12-29T12:54:59";
        }



        private void button2_Click(object sender, EventArgs e)
        {
           
            var fileAnalyzer = new FileAnalyzer
            {
                RecordList = _logReader.EventList.ToList(),
                Parameters = new Dictionary<string, string>
                {
                    
                    {"startDate", startDate.Text.Length == 0 ? null : startDate.Text},
                    {"endDate", endDate.Text.Length == 0 ? null : endDate.Text}
                }
            };

            if (reportDate.Checked)
            {
               fileAnalyzer.Parameters.Add("report", "AnalyzerByDate");
            }

            if (reportUniqueIp.Checked)
            {
                fileAnalyzer.Parameters.Add("report", "AnalyzerByIp"); 
            }
            if (reportWeightingCoefficient.Checked)
            {
                fileAnalyzer.Parameters.Add("report", "AnalyzerByWeightCoefficients"); 
                fileAnalyzer.Parameters.Add("Value", value.Text); 

            }
            if (reportSpecifiedNumberOfRows.Checked)
            {
                fileAnalyzer.Parameters.Add("report", "LinesAnalyzer");
                fileAnalyzer.Parameters.Add("startLine", startLine.Text);
                fileAnalyzer.Parameters.Add("numberLine", numberLines.Text);
            }

            if (getSum.Checked)
            {
                fileAnalyzer.Parameters.Add("report", "SumOfWeightingCoefficients");
            }

            richTextBox1.ResetText();
            richTextBox1.AppendText(string.Format("{0}\n",
                fileAnalyzer.GetResultsAnalyzer()));
            fileAnalyzer.Parameters.Clear();
            fileAnalyzer.RecordList.Clear();

        }
    }
}
