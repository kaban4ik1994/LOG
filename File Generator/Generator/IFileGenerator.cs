using File_Generator.Generator_Param;

namespace File_Generator.Generator
{
    interface IFileGenerator<out T>
    {
        T Generator(CreationOptionsValue parameters);
    }
}
