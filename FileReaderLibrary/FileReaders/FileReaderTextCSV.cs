using System;


namespace FileReaderLibrary.FileReaders;

public class FileReaderTextCSV : FileReaderText
{
    public const string csv = ".csv";


    public FileReaderTextCSV(string name, string basepath) 
	: base(name, basepath) 
    { }


    public override string FilePath()
    {
	    return $"{base.FilePath()}{csv}";
    }
}