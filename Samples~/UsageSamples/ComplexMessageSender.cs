﻿//----------------------------------------
// MIT License
// Copyright(c) 2021 Jonas Boetel
//----------------------------------------
using System.Collections;
using UnityEngine;

namespace Lumpn.Discord.Samples
{
    public sealed class ComplexMessageSender : MonoBehaviour
    {
        [Header("Webhook")]
        [SerializeField] private WebhookData webhookData;

        [Header("Message")]
        [SerializeField] private Color color;
        [SerializeField] private string title;
        [SerializeField] private string author;
        [SerializeField, TextArea] private string description;
        [SerializeField] private TextAsset image;
        [SerializeField] private string thumbnailUrl;
        [SerializeField] private string footer;

        public IEnumerator Run()
        {
            var embed = new Embed()
                    .SetColor(color)
                    .SetTitle(title)
                    .SetAuthor(author, thumbnailUrl)
                    .SetDescription(description)
                    .SetThumbnail(thumbnailUrl)
                    .SetImage(MediaType.PNG, image.bytes)
                    .SetFooter(footer, thumbnailUrl);

            var webhook = webhookData.CreateWebhook();
            return webhook.Send(embed);
        }
    }
}
