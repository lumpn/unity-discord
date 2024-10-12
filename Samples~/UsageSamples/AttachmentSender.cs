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
        [SerializeField] private TextAsset file1;

        public IEnumerator Run()
        {
            var attachment1 = FileData.Create(MediaType.PNG, image1.bytes);
            var attachment2 = FileData.Create(MediaType.PNG, image2.bytes);
            var attachment3 = FileData.Create(MediaType.Text, file1.bytes);

            var webhook = webhookData.CreateWebhook();
            return webhook.Send(text, new[] { attachment1, attachment2, attachment3 });
        }
    }
}
