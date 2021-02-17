//----------------------------------------
// MIT License
// Copyright(c) 2021 Jonas Boetel
//----------------------------------------
using UnityEngine;

namespace Lumpn.Discord
{
    [CreateAssetMenu(menuName = "Data/Discord/WebhookData")]
    public sealed class WebhookData : ScriptableObject
    {
        private const string discordUrl = "https://discord.com/api/webhooks";

        [Tooltip("Discord webhook URL.")]
        [SerializeField] private string webhookUrl = "https://discord.com/api/webhooks/000000000000000000/abcdefghijklmnopqrstuvwxyz_ABCDEFGHIJKLMNOPQRSTUVWXYZ_0123456789____";

        public Webhook CreateWebhook()
        {
            return new Webhook(webhookUrl);
        }

        [ContextMenu("Send test message")]
        private void SendTestMessage()
        {

        }
    }
}
