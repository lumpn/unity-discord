//----------------------------------------
// MIT License
// Copyright(c) 2021 Jonas Boetel
//----------------------------------------
using UnityEngine;
using UnityEngine.UI;

namespace Lumpn.Discord.Samples
{
    public sealed class FeedbackForm : MonoBehaviour
    {
        [System.Serializable]
        private struct FeedbackType
        {
            public string name;
            public Color color;
        }

        [Header("UI")]
        [SerializeField] private Canvas canvas;
        [SerializeField] private Dropdown dropdown;
        [SerializeField] private InputField inputField;

        [Header("Feedback")]
        [SerializeField] private FeedbackType[] feedbackTypes;

        [Header("Webhook")]
        [SerializeField] private WebhookData webhookData;

        [ContextMenu(nameof(Show))]
        public void Show()
        {
            canvas.enabled = true;
        }

        [ContextMenu(nameof(Hide))]
        public void Hide()
        {
            dropdown.value = 0;
            inputField.text = null;
            canvas.enabled = false;
        }

        public void Submit()
        {
            var webhook = webhookData.CreateWebhook();

            var type = feedbackTypes[dropdown.value];
            var message = inputField.text;

            var embed = new Embed()
                .SetTitle(type.name)
                .SetColor(type.color)
                .SetDescription(message);

            StartCoroutine(webhook.Send(embed));

            Hide();
        }

        public void Cancel()
        {
            Hide();
        }
    }
}
