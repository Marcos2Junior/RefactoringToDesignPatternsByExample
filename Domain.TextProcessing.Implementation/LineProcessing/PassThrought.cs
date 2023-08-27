using System.Collections.Generic;

namespace SubtitlesConverter.Domain.TextProcessing.Implementation.LineProcessing
{
    internal class PassThrought : ILineProcessor
    {
        public IEnumerable<string> Execute(string line)
        {
            yield return line;
        }
    }
}
