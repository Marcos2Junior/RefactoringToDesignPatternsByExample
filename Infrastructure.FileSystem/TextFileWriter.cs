﻿using System.Collections.Generic;
using System.IO;
using System.Text;
using SubtitlesConverter.Domain;

namespace SubtitlesConverter.Infrastructure.FileSystem
{
    public class TextFileWriter : ITextWriter
    {
        private FileInfo Destination { get; }
        
        public TextFileWriter(FileInfo destination)
        {
            this.Destination = destination;
            Truncate(destination);
        }

        private static void Truncate(FileInfo file)
        {
            using (File.Open(file.FullName, FileMode.Create)) { }
        }

        public void Write(IEnumerable<string> lines) => 
            File.WriteAllLines(this.Destination.FullName, lines, Encoding.UTF8);

        public void AppendLines(params string[] lines) =>
            File.AppendAllLines(this.Destination.FullName, lines);
    }
}
