namespace FileWriterLibrary.FileWriters;

// 4
public class FileWriterTextCSV : FileWriterText
{
    public const string csv = ".csv";

    public FileWriterTextCSV(string basepath, string name, string content)
    : base(basepath, name, content) 
    { }

    public override string FilePath()
    {
	    return $"{base.FilePath()}{csv}";
    }
}