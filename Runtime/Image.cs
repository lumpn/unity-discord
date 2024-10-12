//----------------------------------------
// MIT License
// Copyright(c) 2021 Jonas Boetel
//----------------------------------------
using System;
using System.Collections.Generic;

namespace Lumpn.Discord
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#embed-object-embed-image-structure
    /// </summary>
    [Serializable]
    public struct Image
    {
        /// <summary>
        /// Source URL of the image. (required)
        /// </summary>
        public string url;

        [NonSerialized] public FileData file;

        internal Image Bake(List<FileData> outFiles)
        {
            url = FileDataUtils.Bake(url, file, outFiles);
            return this;
        }
    }
}
