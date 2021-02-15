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

            if (GUILayout.Button("Send test message"))
            {
                var embed = CreateTestMessage();
                var webhook = data.CreateWebhook();
                webhook.Send(embed);
            }

            EditorGUILayout.EndVertical();
        }

        private static Embed CreateTestMessage()
        {
            return new Embed()
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
        }
    }
}
