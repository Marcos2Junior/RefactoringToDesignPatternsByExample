using System.Collections.Generic;
using SubtitlesConverter.Domain.Models;

namespace SubtitlesConverter.Domain
{
    public interface ITextReader
    {
        IEnumerable<TimedText> Read();
    }
}