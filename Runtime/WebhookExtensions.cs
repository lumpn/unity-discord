//----------------------------------------
// MIT License
// Copyright(c) 2021 Jonas Boetel
//----------------------------------------
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

namespace Lumpn.Discord
{
    public static class WebhookExtensions
    {
        public static IEnumerator Send(this Webhook webhook, string text)
        {
            var message = new Message
            {
                username = webhook.name,
                content = text,
            };

            return webhook.Send(message);
        }

        public static IEnumerator Send(this Webhook webhook, Embed embed)
        {
            var message = new Message
            {
                username = webhook.name,
                embeds = new[] { embed },
            };

            return webhook.Send(message);
        }

        public static IEnumerator Send(this Webhook webhook, Message message)
        {
            using (var request = webhook.CreateWebRequest(message))
            {
                yield return request.SendWebRequest();
                CheckResponse(request);
            }
        }

        public static IEnumerator Send(this Webhook webhook, AttachedImage image)
        {
            return Send(webhook, string.Empty, image);
        }

        public static IEnumerator Send(this Webhook webhook, string text, AttachedImage image)
        {
            var message = new Message
            {
                username = webhook.name,
                content = text,
                attachments = new[] { image.CreateAttachment(0) },
            };

            using (var request = webhook.CreateWebRequest(message, image.bytes))
            {
                yield return request.SendWebRequest();
                CheckResponse(request);
            }
        }

        private static void CheckResponse(UnityWebRequest request)
        {
            Debug.AssertFormat(request.responseCode < 300, "{0}: {1}", request.error, request.downloadHandler.text);
        }
    }
}
