//----------------------------------------
// MIT License
// Copyright(c) 2021 Jonas Boetel
//----------------------------------------
using System;
using System.Collections.Generic;

namespace Lumpn.Discord
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#embed-object-embed-author-structure
    /// </summary>
    [Serializable]
    public struct Author
    {
        /// <summary>
        /// Name of the author. (required)
        /// </summary>
        public string name;

        /// <summary>
        /// URL of the author icon. (optional)
        /// </summary>
        public string icon_url;

        /// <summary>
        /// URL of the author. (optional)
        /// </summary>
        public string url;

        [NonSerialized] public FileData iconFile;

        internal Author Bake(List<FileData> outFiles)
        {
            icon_url = FileDataUtils.Bake(icon_url, iconFile, outFiles);
            return this;
        }
    }
}
