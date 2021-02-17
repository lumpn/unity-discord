//----------------------------------------
// MIT License
// Copyright(c) 2021 Jonas Boetel
//----------------------------------------
using UnityEditor;
using UnityEngine;

namespace Lumpn.Discord
{
    [CustomEditor(typeof(WebhookData))]
    public sealed class WebhookDataEditor : Editor
    {
        private const string documentationUrl = "https://discordjs.guide/popular-topics/embeds.html";

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            var data = (WebhookData)target;

            EditorGUILayout.Separator();
            EditorGUILayout.BeginVertical(GUI.skin.box);

            EditorGUILayout.HelpBox("Please see Discord's documentation for details on how to use embeds.", MessageType.Info);
            if (GUILayout.Button("Open documentation"))
            {
                Application.OpenURL(documentationUrl);
            }

            EditorGUILayout.Separator();
            EditorGUILayout.LabelField("Test the webhook URL");

            if (GUILayout.Button("Send plain text message"))
            {
                var webhook = data.CreateWebhook();
                webhook.Send("Plain text message here.");
            }

            if (GUILayout.Button("Send simple embed message"))
            {
                var embed = new Embed()
                    .SetColor("#0099ff")
                    .SetDescription("Simple embed message with a colored border.");

                var webhook = data.CreateWebhook();
                webhook.Send(embed);
            }

            if (GUILayout.Button("Send fancy embed message"))
            {
                var embed = new Embed()
                    .SetColor("#0099ff")
                    .SetTitle("Some title")
                    .SetAuthor("Some name", "https://i.imgur.com/wSTFkRM.png", "https://discord.js.org")
                    .SetDescription("Some description here. There can be a lot of text.")
                    .SetThumbnail("https://i.imgur.com/wSTFkRM.png")
                    .AddField("Regular field title", "Some value here", false)
                    .AddField("Inline field title", "Some value here")
                    .AddField("Inline field title", "Some value here")
                    .AddField("Inline field title", "Some value here")
                    .SetFooter("Some footer text here", "https://i.imgur.com/wSTFkRM.png");

                var webhook = data.CreateWebhook();
                webhook.Send(embed);
            }

            EditorGUILayout.EndVertical();
        }
    }
}
