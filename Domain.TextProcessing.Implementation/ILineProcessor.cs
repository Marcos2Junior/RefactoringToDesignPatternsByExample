using System.Collections.Generic;

namespace SubtitlesConverter.Domain.TextProcessing.Implementation
{
    interface ILineProcessor
    {
        IEnumerable<string> Execute(string line);
    }
}
