using System;
using System.Collections.Generic;

namespace SubtitlesConverter.Domain.Models
{
    public class Subtitles
    {
        private IList<SubtitleLine> Lines { get; } = new List<SubtitleLine>();

        public void Append(IEnumerable<TimedLine> lines, TimeSpan offset)
        {
            TimeSpan begin = offset;
            foreach (TimedLine line in lines)
            {
                TimeSpan end = begin + line.Duration;
                this.Lines.Add(new SubtitleLine(begin, end, line.Content));
                begin = end;
            }
        }

        public void Accept(ISubtitlesVisitor visitor)
        {
            foreach (SubtitleLine line in this.Lines)
            {
                visitor.Visit(line);
            }
        }
    }
}
