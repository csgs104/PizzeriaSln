namespace FileWriterLibrary;

// 1
public class BaseFile
{
	private readonly string _name = null!;
	private readonly string _basepath = null!;

	public string Name { get => _name; }
	public string BasePath { get => _basepath; }

    public BaseFile(string name, string basepath) 
    {
        _name = name;
        _basepath = basepath;
    }
	
	public virtual string FilePath()
	{
		return Path.Combine(BasePath, Name);
	}
}