using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Convert_Item_To_String;
using File_Analyzer.Analyzer_Param;
using File_Analyzer.Result_Analyzer;
using Journal_Record;

namespace File_Analyzer.Analyzer
{
    class AnalyzerByDate : IFileAnaluzer<ResultAnalyzerByDate>
    {
        public List<JournalRecord> RecordList { get; set; }

        public DateTime GetMinimumDate()
        {
            var result = RecordList[0].Date;
            for (var i = 1; i < RecordList.Count; i++)
            {
                if (DateTime.Compare(result, RecordList[i].Date) > 0)
                {
                    result = RecordList[i].Date;
                }
            }

            return result;
        }

        public DateTime GetMaximumDate()
        {
            var result = RecordList[0].Date;
            for (var i = 1; i < RecordList.Count; i++)
            {
                if (DateTime.Compare(result, RecordList[i].Date) < 0)
                {
                    result = RecordList[i].Date;
                }
            }

            return result;
        }

        public ResultAnalyzerByDate Analyz(IParametersAnalyzer parameters)
        {
            var parameter = (ParametersAnalyzerByDate)parameters;
            var result = new ResultAnalyzerByDate
            {
                Result = new List<JournalRecord>()
            };
            if (parameter.StartDate == Convert.ToDateTime(null) && parameter.EndDate == Convert.ToDateTime(null))
                return result;
            if (parameter.StartDate == Convert.ToDateTime(null)) parameter.StartDate = GetMinimumDate();
            if (parameter.EndDate == Convert.ToDateTime(null)) parameter.EndDate = GetMaximumDate();
            var converter = new ConvertItemToString();
            foreach (var record in RecordList.Where(record => ((DateTime.Compare(parameter.StartDate, record.Date) < 0) ||
                                                                (DateTime.Compare(parameter.StartDate, record.Date) == 0)) &&
                                                               ((DateTime.Compare(parameter.EndDate, record.Date) > 0) ||
                                                                (DateTime.Compare(parameter.EndDate, record.Date) == 0))))
            {
                result.Result.Add(record);
            }

            return result;
        }
    }
}
