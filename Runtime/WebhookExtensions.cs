//----------------------------------------
// MIT License
// Copyright(c) 2021 Jonas Boetel
//----------------------------------------
using System.Collections;
using UnityEngine;

namespace Lumpn.Discord
{
    public static class WebhookExtensions
    {
        public static IEnumerator Send(this Webhook webhook, string text)
        {
            return Send(webhook, text, null);
        }

        public static IEnumerator Send(this Webhook webhook, ImageData image)
        {
            return Send(webhook, string.Empty, image);
        }

        public static IEnumerator Send(this Webhook webhook, string text, ImageData image)
        {
            return Send(webhook, text, new[] { image });
        }

        public static IEnumerator Send(this Webhook webhook, string text, ImageData[] images)
        {
            var message = new Message
            {
                username = webhook.name,
                content = text,
                images = images,
            };
            return Send(webhook, message);
        }

        public static IEnumerator Send(this Webhook webhook, Embed embed)
        {
            var message = new Message
            {
                username = webhook.name,
                embeds = new[] { embed },
            };
            return Send(webhook, message);
        }

        public static IEnumerator Send(this Webhook webhook, Message message)
        {
            using (var request = webhook.CreateWebRequest(message))
            {
                yield return request.SendWebRequest();

                Debug.AssertFormat(request.responseCode < 300, "{0}: {1}", request.error, request.downloadHandler.text);
            }
        }
    }
}
