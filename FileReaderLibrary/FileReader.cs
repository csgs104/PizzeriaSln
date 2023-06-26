namespace FileReaderLibrary;

// 2
public abstract class FileReader : BaseFile, IFileReader
{
    private string _content = null!;

    public string Content { get => _content; set => _content = value; }

    public FileReader(string name, string basepath, string content) 
	: base(name, basepath)
    {
        _content = content;
    }

	public abstract bool FileRead();
}