//----------------------------------------
// MIT License
// Copyright(c) 2021 Jonas Boetel
//----------------------------------------
using UnityEditor;
using UnityEngine;

namespace Lumpn.Discord
{
    [CustomEditor(typeof(WebhookData))]
    public sealed class WebhookDataEditor : Editor<WebhookData>
    {
        private const string helpText = "Please see Discord's documentation for details on how to use webhooks.\n" +
            "The Webhook URL should look something like this:\n\n" +
            "https://discord.com/api/webhooks/000000000000000000/abcdefghijklmnopqrstuvwxyz_ABCDEFGHIJKLMNOPQRSTUVWXYZ_0123456789____";

        private const string helpUrl = "https://support.discord.com/hc/en-us/articles/228383668-Intro-to-Webhooks";

        public sealed override void OnInspectorGUI(WebhookData data)
        {
            EditorGUILayout.HelpBox(helpText, MessageType.Info);

            if (GUILayout.Button("Open documentation"))
            {
                Application.OpenURL(helpUrl);
            }
        }
    }
}
