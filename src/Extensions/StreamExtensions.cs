using System;
using System.Collections.Generic;

namespace Extensions
{
    public static class StreamExtensions
    {
        public static async IAsyncEnumerable<string?> ReadLinesAsync(this Stream stream)
        {
            using var reader = new StreamReader(stream);

            while (!reader.EndOfStream)
                yield return await reader.ReadLineAsync();
        }
    }
}
