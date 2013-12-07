
namespace File_Generator.Generator
{
    interface IFileGenerator<out T, in TL>
    {
        T Generator(TL parameters);
    }
}
