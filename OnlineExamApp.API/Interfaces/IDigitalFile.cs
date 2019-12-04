using System;
using System.Collections.Generic;
using OnlineExamApp.API.Model;

namespace OnlineExamApp.API.Interfaces
{
    public interface IDigitalFile
    {
        int DigitalFileId { get; set; }
        byte[] TheDigitalFile { get; set; }
        string FileName { get; set; }
        string FileExtension { get; set; }
        DateTime DateCreated { get; set; }
        string ContentType { get; set; }
        
    }
}