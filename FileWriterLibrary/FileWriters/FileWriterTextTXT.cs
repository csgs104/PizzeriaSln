namespace FileWriterLibrary.FileWriters;

// 4
public class FileWriterTextTXT : FileWriterText
{
    public const string txt = ".txt";

    public FileWriterTextTXT(string basepath, string name, string content)
    : base(basepath, name, content) 
    { }

    public override string FilePath()
    {
        return $"{base.FilePath()}{txt}";
    }
}