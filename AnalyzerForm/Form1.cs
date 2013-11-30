using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Convert_Item_To_String;
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




        private void button1_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            var filePath = string.Empty;

            richTextBox1.ResetText();
            if (result == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;

            }

            var logReader = new LogReader(filePath);
            var converterIp = new ConverterIp();
            var converterDate = new ConverterDate();
            AnalyzerFactory.RecordList = logReader.EventList.ToList();
            dataGridView1.RowCount = logReader.EventList.Count();
            for (var i = 0; i < logReader.EventList.Count(); i++)
            {
                dataGridView1[0, i].Value = converterIp.Convert(new ConverterParametersIp { Ip = logReader.EventList.ElementAt(i).Ip });
                dataGridView1[1, i].Value = "-";
                dataGridView1[2, i].Value =
                    converterDate.Convert(new ConverterParametersDate
                    {
                        DateTime = logReader.EventList.ElementAt(i).Date
                    });
                dataGridView1[3, i].Value = logReader.EventList.ElementAt(i).Method;
                dataGridView1[4, i].Value = logReader.EventList.ElementAt(i).Protocol;
                dataGridView1[5, i].Value = logReader.EventList.ElementAt(i).FileName;
                dataGridView1[6, i].Value = logReader.EventList.ElementAt(i).FileExtension;
                dataGridView1[7, i].Value = logReader.EventList.ElementAt(i).StatusCode;
                dataGridView1[8, i].Value = logReader.EventList.ElementAt(i).NumberOfBytes;

            }
         //   dataGridView1.AutoResizeColumns();

        }



        private void reportDate_CheckedChanged(object sender, EventArgs e)
        {
            if (reportDate.Checked)
            {
                endDate.Enabled = true;
                startDate.Enabled = true;
                endDate.Text = @"2013-12-30T23:59:59";
                startDate.Text = @"2013-12-30T23:59:59";

            }
            else
            {
                endDate.Enabled = false;
                startDate.Enabled = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var fileAnalyzer = new FileAnalyzer();
            if (reportDate.Checked)
            {
                AnalyzerFactory.CommandLineParameters = new Dictionary<string, string>
                {
                    {"report", "AnalyzerByDate"},
                    {"startDate", startDate.Text.Length == 0 ? null : startDate.Text},
                    {"endDate", endDate.Text.Length == 0 ? null : endDate.Text}
                };
            }

            if (reportUniqueIp.Checked)
            {
                AnalyzerFactory.CommandLineParameters = new Dictionary<string, string>
                {
                    {"report", "AnalyzerByIp"},

                };
            }
            if (reportWeightingCoefficient.Checked)
            {
                AnalyzerFactory.CommandLineParameters = new Dictionary<string, string>
                {
                    {"report", "AnalyzerByWeightCoefficients"},
                    {"Value", value.Text},

                };
            }
            if (reportSpecifiedNumberOfRows.Checked)
            {
                AnalyzerFactory.CommandLineParameters = new Dictionary<string, string>
                {
                    {"report", "LinesAnalyzer"},
                    {"startLine", startLine.Text},
                    {"numberLine", numberLines.Text}

                };
            }

            richTextBox1.ResetText();
            richTextBox1.AppendText(string.Format("{0}\n",
                fileAnalyzer.Analyz(AnalyzerFactory.GetResultsAnalyzerFactory())));

        }
    }
}
