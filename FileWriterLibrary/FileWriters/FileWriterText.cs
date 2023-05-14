using System;
using System.IO;

using FileWriterLibrary;

// 3
namespace FileWriterLibrary.FileWriters;

public class FileWriterText : FileWriter
{
    public FileWriterText(string name, string basepath, string content) 
	: base(name, basepath, content)
    { }


	public override bool FileWrite() 
    {
		try
		{
			File.WriteAllText(FilePath(), Content);
			return true;
		}
		catch (Exception /*ex*/)
		{
			// Console.WriteLine(ex.Message);
			return false;
		}
	}
}