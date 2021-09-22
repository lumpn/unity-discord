//----------------------------------------
// MIT License
// Copyright(c) 2021 Jonas Boetel
//----------------------------------------
using System;

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
    }
}
