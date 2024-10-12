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
        /// Attached files. (optional)
        /// </summary>
        [NonSerialized] public FileData[] files;

        private static readonly Embed[] emptyEmbeds = new Embed[0];
        private static readonly FileData[] emptyFiles = new FileData[0];

        internal Message Bake(List<FileData> outFiles)
        {
            var sourceEmbeds = embeds ?? emptyEmbeds;
            var sourceFiles = files ?? emptyFiles;

            outFiles.AddRange(sourceFiles);
            embeds = sourceEmbeds.Select(p => p.Bake(outFiles)).ToArray();
            attachments = outFiles.Select(CreateAttachment).ToArray();
            return this;
        }

        private static Attachment CreateAttachment(FileData source, int id)
        {
            return source.CreateAttachment(id);
        }
    }
}
