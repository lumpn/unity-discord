//----------------------------------------
// MIT License
// Copyright(c) 2021 Jonas Boetel
//----------------------------------------
using System;
using System.Collections.Generic;

namespace Lumpn.Discord
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#embed-object-embed-thumbnail-structure
    /// </summary>
    [Serializable]
    public struct Thumbnail
    {
        /// <summary>
        /// URL of the thumbnail image. (required)
        /// </summary>
        public string url;

        [NonSerialized] public FileData file;

        internal Thumbnail Bake(List<FileData> outFiles)
        {
            url = FileDataUtils.Bake(url, file, outFiles);
            return this;
        }
    }
}
