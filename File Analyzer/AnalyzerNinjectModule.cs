using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Convert_Item_To_String.Parameters_Converter;
using File_Analyzer.Analyzer;
using File_Analyzer.Analyzer_Param;
using File_Analyzer.ConverterAnalyzerResult;
using File_Analyzer.Result_Analyzer;
using Ninject.Modules;

namespace File_Analyzer
{
    class AnalyzerNinjectModule : NinjectModule
    {

        public string Parameters { get; set; }
        public override void Load()
        {
            if (Parameters == "LinesAnalyzer")
            {
                this.Bind<IFileAnaluzer<ResultLinesAnalyzer>>().To<LinesAnalyzer>();
                this.Bind<IConvertorAnalyzerResult<StringBuilder>>().To<ConverterResultLinesAnalyzer>();
            }
            if (Parameters == "AnalyzerByWeightCoefficients")
            {
                this.Bind<IFileAnaluzer<ResultAnalyzerByWeightingCoefficients>>().To<AnalyzerByWeightingCoefficients>();
                this.Bind<IConvertorAnalyzerResult<StringBuilder>>().To<ConverterResultByWeightingCoefficients>();

            }
            if (Parameters == "AnalyzerByIp")
            {
               
                this.Bind<IFileAnaluzer<ResultAnalyzerByIp>>().To<AnalyzerByIp>();
                this.Bind<IConvertorAnalyzerResult<StringBuilder>>().To<ConverterResultByIp>();
            }
            if (Parameters == "AnalyzerByDate")
            {
                this.Bind<IFileAnaluzer<ResultAnalyzerByDate>>().To<AnalyzerByDate>();
                this.Bind<IConvertorAnalyzerResult<StringBuilder>>().To<ConverterResultAnalyzerByDate>();
                
            }
            

        }
    }
}
