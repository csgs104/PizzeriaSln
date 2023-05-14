using System;


namespace FileReaderLibrary.FileReaders;

public class FileReaderTextTXT : FileReaderText
{
    public const string txt = ".txt";


    public FileReaderTextTXT(string name, string basepath)
    : base(name, basepath) 
    { }


    public override string FilePath()
    {
        return $"{base.FilePath()}{txt}";
    }
}