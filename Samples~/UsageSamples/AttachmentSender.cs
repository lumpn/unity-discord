//----------------------------------------
// MIT License
// Copyright(c) 2021 Jonas Boetel
//----------------------------------------
using System.Collections;
using UnityEngine;

namespace Lumpn.Discord.Samples
{
    public sealed class AttachmentSender : MonoBehaviour
    {
        [Header("Webhook")]
        [SerializeField] private WebhookData webhookData;

        [Header("Message")]
        [SerializeField] private string text;
        [SerializeField] private TextAsset image;

        public IEnumerator Run()
        {
            var img = AttachedImage.Create(MediaType.PNG, image.bytes);

            var webhook = webhookData.CreateWebhook();
            return webhook.Send(text, img);
        }
    }
}
