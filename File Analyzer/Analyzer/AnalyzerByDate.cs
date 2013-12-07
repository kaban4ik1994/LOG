using System;
using System.Collections.Generic;
using System.Linq;
using File_Analyzer.Analyzer_Param;
using File_Analyzer.Result_Analyzer;
using Journal_Record;

namespace File_Analyzer.Analyzer
{
    class AnalyzerByDate : IFileAnaluzer<ResultAnalyzerByDate,ParametersAnalyzerByDate>
    {
        public List<JournalRecord> RecordList { private get; set; }

        public DateTime GetMinimumDate()
        {
            var result = RecordList.Count != 0 ? RecordList[0].Date : Convert.ToDateTime(null);
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
            var result = RecordList.Count != 0 ? RecordList[0].Date : Convert.ToDateTime(null);
            for (var i = 1; i < RecordList.Count; i++)
            {
                if (DateTime.Compare(result, RecordList[i].Date) < 0)
                {
                    result = RecordList[i].Date;
                }
            }

            return result;
        }

        public ResultAnalyzerByDate Analyz(ParametersAnalyzerByDate parameters)
        {
          
            var result = new ResultAnalyzerByDate
            {
                Result = new List<JournalRecord>()
            };

            if (parameters.StartDate == Convert.ToDateTime(null) && parameters.EndDate == Convert.ToDateTime(null))
            {
                parameters.StartDate = GetMinimumDate();
                parameters.EndDate = GetMaximumDate();
            }
            if (parameters.StartDate == Convert.ToDateTime(null)) parameters.StartDate = GetMinimumDate();
            if (parameters.EndDate == Convert.ToDateTime(null)) parameters.EndDate = GetMaximumDate();
            
            foreach (var record in RecordList.Where(record => ((DateTime.Compare(parameters.StartDate, record.Date) <= 0)
                                                                &&
                                                               ((DateTime.Compare(parameters.EndDate, record.Date) >= 0)))))
                                                               
            {
                result.Result.Add(record);
            }

            return result;
        }
    }
}
