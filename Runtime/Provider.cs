//----------------------------------------
// MIT License
// Copyright(c) 2021 Jonas Boetel
//----------------------------------------
using System;

namespace Lumpn.Discord
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#embed-object-embed-provider-structure
    /// </summary>
    [Serializable]
    public struct Provider
    {
        /// <summary>
        /// Name of provider. (optional)
        /// </summary>
        public string name;

        /// <summary>
        /// URL of provider. (optional)
        /// </summary>
        public string url;
    }
}
