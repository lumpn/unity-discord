//----------------------------------------
// MIT License
// Copyright(c) 2021 Jonas Boetel
//----------------------------------------
using System;

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
    }
}
