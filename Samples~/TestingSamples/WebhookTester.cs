//----------------------------------------
// MIT License
// Copyright(c) 2021 Jonas Boetel
//----------------------------------------
using System.Collections;
using System.Text;
using UnityEngine;

namespace Lumpn.Discord.Samples
{
    public sealed class WebhookTester : MonoBehaviour
    {
        [Header("Webhook")]
        [SerializeField] private WebhookData webhookData;

        [Header("Testing")]
        [SerializeField] private Message message;

        public IEnumerator Run()
        {
            var webhook = webhookData.CreateWebhook();

            using (var request = webhook.CreateWebRequest(message))
            {
                yield return request.SendWebRequest();

                var responseHeaders = new StringBuilder();
                foreach (var header in request.GetResponseHeaders())
                {
                    responseHeaders.AppendFormat("{0}: {1}\n", header.Key, header.Value);
                }
                Debug.Log(responseHeaders);

                Debug.LogFormat("HTTP response {0} ({1}):\n{2}", request.responseCode, request.error, request.downloadHandler.text);
            }
        }
    }
}
