using UnityEngine;

namespace Lumpn.Discord.Demo
{
    [AddComponentMenu("")]
    public sealed class DiscordNotifier : MonoBehaviour
    {
        [SerializeField] private WebhookData webhookData;

        void Start()
        {
            var webhook = webhookData.CreateWebhook();
            webhook.Send("Starting a new game");
        }
    }
}
