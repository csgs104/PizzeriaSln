using System;

using FileWriterLibrary;

// 4
namespace FileWriterLibrary.FileWriters;

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