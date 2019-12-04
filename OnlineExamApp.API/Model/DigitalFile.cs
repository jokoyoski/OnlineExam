using System;
using System.Collections.Generic;
using OnlineExamApp.API.Interfaces;

namespace OnlineExamApp.API.Model
{
    public class DigitalFile : IDigitalFile
    {
        public int DigitalFileId { get; set; }
        public byte[] TheDigitalFile { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public DateTime DateCreated { get; set; }
        public string ContentType { get; set; }
    }
}