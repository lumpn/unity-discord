//----------------------------------------
// MIT License
// Copyright(c) 2021 Jonas Boetel
//----------------------------------------
using System.Collections;
using UnityEditor;
using UnityEngine;
using UnityEngine.Networking;

namespace Lumpn.Discord
{
    [CustomEditor(typeof(WebhookData))]
    public sealed class WebhookDataEditor : Editor
    {
        private const string webhooksUrl = "https://support.discord.com/hc/en-us/articles/228383668-Intro-to-Webhooks";
        private const string embedsUrl = "https://discordjs.guide/popular-topics/embeds.html";

        private string message = "simple text message";
        private string description = "embed description here";
        private bool fold1 = true;
        private Color color = Color.yellow;

        public sealed override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            EditorGUILayout.Separator();

            EditorGUILayout.BeginVertical(GUI.skin.box);
            EditorGUILayout.EndVertical();
            EditorGUILayout.HelpBox("Please see Discord's documentation for details on how to use embeds.", MessageType.Info);

            var data = (WebhookData)target;

            if (GUILayout.Button("Open documentation"))
            {
                Application.OpenURL(embedsUrl);
            }
            EditorGUILayout.Separator();

            EditorGUILayout.LabelField("Test the webhook URL");

            using (new EditorGUILayout.VerticalScope(GUI.skin.box))
            {
                EditorGUILayout.LabelField("Plain message", GUI.skin.box);
                message = EditorGUILayout.TextField("Message", message);
                if (GUILayout.Button("Send plain text message"))
                {
                    var webhook = data.CreateWebhook();
                    var op = webhook.Send(message);
                    var go = new GameObject();
                    //var script = go.AddComponent<WebhookRunner>();
                    //script.StartCoroutine(LogReply(op));
                }
            }
            EditorGUILayout.Separator();

            fold1 = EditorGUILayout.BeginFoldoutHeaderGroup(fold1, "Plain message");
            if (fold1)
            {
                using (new EditorGUILayout.VerticalScope(GUI.skin.box))
                {
                    message = EditorGUILayout.TextField("Message", message);
                    if (GUILayout.Button("Send plain text message"))
                    {
                        var webhook = data.CreateWebhook();
                        webhook.Send(message);
                    }
                }
                EditorGUILayout.Separator();
            }
            EditorGUILayout.EndFoldoutHeaderGroup();

            fold1 = EditorGUILayout.BeginFoldoutHeaderGroup(fold1, "Simple embed");
            if (fold1)
            {
                using (new EditorGUILayout.VerticalScope(GUI.skin.box))
                {
                    color = EditorGUILayout.ColorField("Color", color);
                    description = EditorGUILayout.TextField("Description", description);
                    if (GUILayout.Button("Send simple embed message"))
                    {
                        var embed = new Embed()
                            .SetColor(color)
                            .SetDescription("Simple embed message with a colored border.");

                        var webhook = data.CreateWebhook();
                        webhook.Send(embed);
                    }
                }
                EditorGUILayout.Separator();
            }
            EditorGUILayout.EndFoldoutHeaderGroup();

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
        }

        private static IEnumerator LogReply(UnityWebRequestAsyncOperation op)
        {
            yield return op;
            Debug.Assert(op.isDone);
            Debug.Log(op.webRequest.responseCode);
            foreach (var header in op.webRequest.GetResponseHeaders())
            {
                Debug.LogFormat("{0}: {1}", header.Key, header.Value);
            }
            Debug.Log(op.webRequest.downloadHandler.text);
        }
    }
}
