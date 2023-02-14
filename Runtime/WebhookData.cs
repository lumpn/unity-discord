//----------------------------------------
// MIT License
// Copyright(c) 2021 Jonas Boetel
//----------------------------------------
using UnityEngine;

namespace Lumpn.Discord
{
    [HelpURL("https://support.discord.com/hc/en-us/articles/228383668-Intro-to-Webhooks")]
    [CreateAssetMenu(menuName = "Data/Discord/WebhookData")]
    public sealed class WebhookData : ScriptableObject
    {
        [Tooltip("Discord webhook URL. https://discord.com/api/webhooks/000000000000000000/abcdefghijklmnopqrstuvwxyz_ABCDEFGHIJKLMNOPQRSTUVWXYZ_0123456789____")]
        [SerializeField] private string webhookUrl;

        [Tooltip("Optional user name override")]
        [SerializeField] private string webhookName;

        public Webhook CreateWebhook()
        {
            return new Webhook(webhookUrl, webhookName);
        }
    }
}
