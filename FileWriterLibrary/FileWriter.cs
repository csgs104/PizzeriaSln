namespace FileWriterLibrary;

// 2
public abstract class FileWriter : BaseFile, IFileWriter
{
	private string _content = null!;

    public string Content { get => _content; set => _content = value; }

    public FileWriter(string name, string basepath, string content) 
	: base(name, basepath)
    {
        _content = content;
    }
	
	public abstract bool FileWrite();
}