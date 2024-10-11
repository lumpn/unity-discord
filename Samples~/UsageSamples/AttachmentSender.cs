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
        [SerializeField] private TextAsset image1;
        [SerializeField] private TextAsset image2;

        public IEnumerator Run()
        {
            var img1 = ImageData.Create(MediaType.PNG, image1.bytes);
            var img2 = ImageData.Create(MediaType.PNG, image2.bytes);

            var webhook = webhookData.CreateWebhook();
            return webhook.Send(text, new[] { img1, img2 });
        }
    }
}
