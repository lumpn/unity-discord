//----------------------------------------
// MIT License
// Copyright(c) 2021 Jonas Boetel
//----------------------------------------
using System;

namespace Lumpn.Discord
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#embed-object-embed-field-structure
    /// </summary>
    [Serializable]
    public struct Field
    {
        /// <summary>
        /// Name of the field. (required)
        /// </summary>
        public string name;

        /// <summary>
        /// Value of the field. (required)
        /// </summary>
        public string value;

        /// <summary>
        /// Whether or not this field should display inline. Recommended <c>true</c>. (optional)
        /// </summary>
        public bool inline;
    }
}
