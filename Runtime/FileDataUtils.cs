//----------------------------------------
// MIT License
// Copyright(c) 2024 Jonas Boetel
//----------------------------------------
using System.Collections.Generic;

namespace Lumpn.Discord
{
    public static class FileDataUtils
    {
        internal static string Bake(string url, FileData file, List<FileData> outFiles)
        {
            if (file)
            {
                url = file.CreateURL(outFiles.Count);
                outFiles.Add(file);
            }
            return url;
        }
    }
}
