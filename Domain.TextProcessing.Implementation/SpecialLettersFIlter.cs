using System.Linq;
using SubtitlesConverter.Domain.TextProcessing.Implementation.LineProcessing;

namespace SubtitlesConverter.Domain.TextProcessing.Implementation
{
    public class SpecialLettersFilter
    {
        public static ITextProcessor ReplaceSpecialLetters() =>
            new (string search, string replace)[]
            {
                ("’", "'"),
                ("…", "..."),
                ("“", "\""),
                ("”", "\""),
                ("–", "-"),
            }
            .Select(tuple => new Replace(tuple.search, tuple.replace))
            .AppendAll()
            .AsTextProcessor();
    }
}
