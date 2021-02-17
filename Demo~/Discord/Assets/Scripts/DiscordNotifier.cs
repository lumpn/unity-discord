using UnityEngine;

namespace Lumpn.Discord.Demo
{
    public sealed class DiscordNotifier : MonoBehaviour
    {
        [SerializeField] private WebhookData webhookData;

        void Start()
        {
            var webhook = webhookData.CreateWebhook();

            var embed = new Embed()
                .SetColor("#0099ff")
                .SetDescription("Starting a new game");

            webhook.Send(embed);
        }
    }
}
