//----------------------------------------
// MIT License
// Copyright(c) 2021 Jonas Boetel
//----------------------------------------
using System;

namespace Lumpn.Discord
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#embed-object-embed-structure
    /// </summary>
    [Serializable]
    public struct Embed
    {
        /// <summary>
        /// Title of the message. (optional)
        /// </summary>
        public string title;

        /// <summary>
        /// Message text. (optional)
        /// </summary>
        public string description;

        /// <summary>
        /// Border color code. (required)
        /// </summary>
        /// <see cref="Lumpn.Discord.Utils.ColorUtils.ToColorCode(UnityEngine.Color32)"/>
        public int color;

        /// <summary>
        /// Author of the message. (optional)
        /// </summary>
        public Author author;

        /// <summary>
        /// Thumbnail. (optional)
        /// </summary>
        public Thumbnail thumbnail;

        /// <summary>
        /// Image. (optional)
        /// </summary>
        public Image image;

        /// <summary>
        /// Video. (optional)
        /// </summary>
        public Video video;

        /// <summary>
        /// Footer. (optional)
        /// </summary>
        public Footer footer;

        /// <summary>
        /// Additional fields. (optional)
        /// </summary>
        public Field[] fields;
    }
}
