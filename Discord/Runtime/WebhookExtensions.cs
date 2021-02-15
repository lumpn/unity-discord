//----------------------------------------
// MIT License
// Copyright(c) 2021 Jonas Boetel
//----------------------------------------
using UnityEngine.Networking;

namespace Lumpn.Discord
{
    public static class WebhookExtensions
    {
        public static UnityWebRequestAsyncOperation Send(this Webhook webhook, Embed embed)
        {
            var message = new Message
            {
                embeds = new[] { embed }
            };

            return webhook.Send(message);
        }
    }
}
