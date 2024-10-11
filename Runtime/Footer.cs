//----------------------------------------
// MIT License
// Copyright(c) 2021 Jonas Boetel
//----------------------------------------
using System;
using System.Collections.Generic;

namespace Lumpn.Discord
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#embed-object-embed-footer-structure
    /// </summary>
    [Serializable]
    public struct Footer
    {
        /// <summary>
        /// Text of the footer. (required)
        /// </summary>
        public string text;

        /// <summary>
        /// URL of the footer icon. (optional)
        /// </summary>
        public string icon_url;

        [NonSerialized] public ImageData icon;

        internal Footer Bake(List<ImageData> outImages)
        {
            icon_url = ImageDataUtils.Bake(icon_url, icon, outImages);
            return this;
        }
    }
}
