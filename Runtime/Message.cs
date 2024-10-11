//----------------------------------------
// MIT License
// Copyright(c) 2021 Jonas Boetel
//----------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Lumpn.Discord
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/webhook#execute-webhook-jsonform-params
    /// </summary>
    [Serializable]
    public struct Message
    {
        /// <summary>
        /// Overrides the username of the webhook. (required)
        /// </summary>
        public string username;

        /// <summary>
        /// Overrides the avatar of the webhook. Recommended to leave blank. (optional)
        /// </summary>
        public string avatar_url;

        /// <summary>
        /// Message text. Recommended to use embeds instead. (optional)
        /// </summary>
        public string content;

        /// <summary>
        /// Embedded messages. (optional)
        /// </summary>
        public Embed[] embeds;

        /// <summary>
        /// Attachments. (optional)
        /// </summary>
        [SerializeField] private Attachment[] attachments;

        /// <summary>
        /// Attached images. (optional)
        /// </summary>
        [NonSerialized] public ImageData[] images;

        private static readonly Embed[] emptyEmbeds = new Embed[0];
        private static readonly ImageData[] emptyImages = new ImageData[0];

        internal Message Bake(List<ImageData> outImages)
        {
            var sourceEmbeds = embeds ?? emptyEmbeds;
            var sourceImages = images ?? emptyImages;

            outImages.AddRange(sourceImages);
            embeds = sourceEmbeds.Select(p => p.Bake(outImages)).ToArray();
            attachments = outImages.Select(CreateAttachment).ToArray();
            return this;
        }

        private static Attachment CreateAttachment(ImageData source, int id)
        {
            return source.CreateAttachment(id);
        }
    }
}
