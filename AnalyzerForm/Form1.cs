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
            contentsLogFiles.ResetText();
            richTextBox1.ResetText();
            if (result == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;

            }

          var  _logReader = new LogReader(filePath);
           var converter = new ConvertItemToString();
            AnalyzerFactory.RecordList = _logReader.EventList.ToList();
            foreach (var record in _logReader.EventList)
            {
                contentsLogFiles.AppendText(string.Format("{0}\n", converter.ConvertToString(record)));
            }

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
