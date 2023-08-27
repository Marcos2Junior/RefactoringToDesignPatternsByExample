using SubtitlesConverter.Domain.TextProcessing.Implementation.LineProcessing;

namespace SubtitlesConverter.Domain.TextProcessing.Implementation
{
    public class LinesTrimmer
    {
        public static ITextProcessor RemoveWhiteSpace() =>
            new Trim()
                .AsTextProcessor();

        public static ITextProcessor RemoveLineEndings() =>
            new Trim()
                .Append(RegexRule.LineExtractor(@"^(?<line>.*)\.(?<!\.\.)$"))
                .Append(RegexRule.LineExtractor(@"^(?<line>.*)(?:[\:\;\,]|\s*-)$"))
                .AsTextProcessor();
    }
}