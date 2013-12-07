
using System;
using File_Generator.Generator;
using File_Generator.Generator_Param;
using Ninject.Modules;

namespace File_Generator
{
    class GeneratorNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IFileGenerator<Ip.Ip, CreationOptionsIp>>().To<GeneratorIp>();
            Bind<IFileGenerator<DateTime, DateOfCreationOptions>>().To<GeneratorDate>();
            Bind<IFileGenerator<string, CreationOptionsOfTheMethod>>().To<GeneratorMethod>();
            Bind<IFileGenerator<string, CreationOptionsProtocol>>().To<GeneratorProtocol>();
            Bind<IFileGenerator<string, CreationOptionsFileName>>().To<GeneratorFileName>();
            Bind<IFileGenerator<string, CreationOptionsFileExtension>>().To<GeneratorFileExtension>();
            Bind<IFileGenerator<string, CreationOptionsOfTheStatusCode>>().To<GeneratorStatusCode>();
            Bind<IFileGenerator<int, CreationOptionsNumberOfBytes>>().To<GeneratorNumberOfBytes>();
        }
    }
}
