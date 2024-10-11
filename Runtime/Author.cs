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

        [NonSerialized] public ImageData icon;

        internal Author Bake(List<ImageData> outImages)
        {
            icon_url = ImageDataUtils.Bake(icon_url, icon, outImages);
            return this;
        }
    }
}
