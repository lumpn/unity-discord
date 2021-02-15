//----------------------------------------
// MIT License
// Copyright(c) 2021 Jonas Boetel
//----------------------------------------
using UnityEngine.Networking;

namespace Lumpn.Discord.Utils
{
    public static class DiscordWebhookExtensions
    {
        public static UnityWebRequestAsyncOperation Send(this DiscordWebhook webhook, Embed embed)
        {
            var message = new Message
            {
                embeds = new[] { embed }
            };

            return webhook.Send(message);
        }
    }
}
