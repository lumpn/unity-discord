//----------------------------------------
// MIT License
// Copyright(c) 2024 Jonas Boetel
//----------------------------------------
using System;

namespace Lumpn.Discord
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/message#attachment-object
    /// </summary>
    [Serializable]
    public struct Attachment
    {
        /// <summary>
        /// Attachment id. (required)
        /// </summary>
        public int id;

        /// <summary>
        /// Name of file attached. (required)
        /// </summary>
        public string filename;

        /// <summary>
        /// Description for the file (max 1024 characters). (optional)
        /// </summary>
        public string description;

        /// <summary>
        /// The attachment's media type. (optional)
        /// https://en.wikipedia.org/wiki/Media_type
        /// </summary>
        public string content_type; 
    }
}
