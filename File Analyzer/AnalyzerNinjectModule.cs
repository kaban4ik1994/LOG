using System.Text;
using File_Analyzer.Analyzer;
using File_Analyzer.Analyzer_Param;
using File_Analyzer.ConverterAnalyzerResult;
using File_Analyzer.Result_Analyzer;
using Ninject.Modules;

namespace File_Analyzer
{
    class AnalyzerNinjectModule : NinjectModule
    {

        public override void Load()
        {

                Bind<IFileAnaluzer<ResultLinesAnalyzer,ParametersOfAnalyzerLine>>().To<LinesAnalyzer>();
                Bind<IConvertorAnalyzerResult<StringBuilder,ResultLinesAnalyzer>>().To<ConverterResultLinesAnalyzer>();
                Bind<IFileAnaluzer<ResultAnalyzerByWeightingCoefficients,ParametersAnalyzerByWeightingCoefficients>>().To<AnalyzerByWeightingCoefficients>();
                Bind<IConvertorAnalyzerResult<StringBuilder,ResultAnalyzerByWeightingCoefficients>>().To<ConverterResultByWeightingCoefficients>();

               
                Bind<IFileAnaluzer<ResultAnalyzerByIp,ParametersAnalyzerByIp>>().To<AnalyzerByIp>();
                Bind<IConvertorAnalyzerResult<StringBuilder,ResultAnalyzerByIp>>().To<ConverterResultByIp>();

                Bind<IFileAnaluzer<ResultAnalyzerByDate,ParametersAnalyzerByDate>>().To<AnalyzerByDate>();
                Bind<IConvertorAnalyzerResult<StringBuilder,ResultAnalyzerByDate>>().To<ConverterResultAnalyzerByDate>();

            Bind<IFileAnaluzer<int, ParametersSumOfWeightingCoefficients>>().To<SumOfWeightingCoefficients>();
            Bind<IConvertorAnalyzerResult<StringBuilder, int>>().To<ConverterResultSumOfWeightingCoefficients>();


        }
    }
}
