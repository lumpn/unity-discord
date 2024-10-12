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

        public static IEnumerator Send(this Webhook webhook, FileData file)
        {
            return Send(webhook, string.Empty, file);
        }

        public static IEnumerator Send(this Webhook webhook, string text, FileData file)
        {
            return Send(webhook, text, new[] { file });
        }

        public static IEnumerator Send(this Webhook webhook, string text, FileData[] files)
        {
            var message = new Message
            {
                username = webhook.name,
                content = text,
                files = files,
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
