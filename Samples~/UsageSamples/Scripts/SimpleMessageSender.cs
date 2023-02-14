//----------------------------------------
// MIT License
// Copyright(c) 2021 Jonas Boetel
//----------------------------------------
using System.Collections;
using UnityEngine;

namespace Lumpn.Discord.Samples
{
    public sealed class SimpleMessageSender : MonoBehaviour
    {
        [Header("Webhook")]
        [SerializeField] private WebhookData webhookData;

        [Header("Message")]
        [SerializeField] private string text;

        public IEnumerator Run()
        {
            var webhook = webhookData.CreateWebhook();
            return webhook.Send(text);
        }
    }
}
