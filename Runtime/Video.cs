//----------------------------------------
// MIT License
// Copyright(c) 2021 Jonas Boetel
//----------------------------------------
using System;

namespace Lumpn.Discord
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#embed-object-embed-video-structure
    /// </summary>
    [Serializable]
    public struct Video
    {
        /// <summary>
        /// Source URL of the video. (required)
        /// </summary>
        public string url;
    }
}
