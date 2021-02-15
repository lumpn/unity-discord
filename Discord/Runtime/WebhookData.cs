//----------------------------------------
// MIT License
// Copyright(c) 2021 Jonas Boetel
//---------------------------------------- 
using UnityEngine;

namespace Lumpn.Discord
{
    [CreateAssetMenu(menuName = "Data/Discord/DiscordWebhookData")]
    public sealed class DiscordWebhookData : ScriptableObject
    {
        [Tooltip("Discord webhook id. Should be an 18 digit number.")]
        [SerializeField] private string webhookId = "000000000000000000";

        [Tooltip("Discord webhook token. A long string of letters and numbers.")]
        [SerializeField] private string webhookToken = "abcdefghijklmnopqrstuvwxyz_ABCDEFGHIJKLMNOPQRSTUVWXYZ_0123456789____";

        public DiscordWebhook CreateWebhook()
        {
            return DiscordWebhook.Create(webhookId, webhookToken);
        }
    }
}
