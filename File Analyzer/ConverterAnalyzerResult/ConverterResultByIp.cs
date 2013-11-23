﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using File_Analyzer.Result_Analyzer;

namespace File_Analyzer.ConverterAnalyzerResult
{
    class ConverterResultByIp : IConvertorAnalyzerResult<StringBuilder>
    {
        public StringBuilder Convert(IResultAnalyzer resultAnalyzer)
        {

            var conversion = (ResultAnalyzerByIp)resultAnalyzer;
            var resultConvertor = new StringBuilder();
            foreach (var result in conversion.Result)
            {
                resultConvertor.AppendLine((string.Format("{0}.{1}.{2}.{3}", result.IpByte1, result.IpByte2, result.IpByte3,
                   result.IpByte4)));
            }

            return resultConvertor;
        }
    }
}
