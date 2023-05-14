using System;
using System.IO;

using FileReaderLibrary;

// 2
namespace FileReaderLibrary.FileReaders;

public class FileReaderText : FileReader
{
	public FileReaderText(string name, string basepath) 
	: base(name, basepath, string.Empty)
	{ }


	public override bool FileRead() 
    {
		try
		{
			Content = File.ReadAllText(FilePath());
			return true;
		}
		catch (Exception /*ex*/)
		{
			// Console.WriteLine(ex.Message);
			return false;
		}
	}
}