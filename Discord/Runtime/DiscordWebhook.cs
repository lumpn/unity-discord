//----------------------------------------
// MIT License
// Copyright(c) 2021 Jonas Boetel
//----------------------------------------
using System;
using System.Text;
using Lumpn.Discord.Utils;
using UnityEngine.Networking;

namespace Lumpn.Discord
{
    public sealed class DiscordWebhook
    {
        private const string discordUrl = "https://discord.com/api/webhooks";

        private readonly StringBuilder stringBuilder = new StringBuilder();
        private readonly Uri uri;

        public static DiscordWebhook Create(string webhookId, string webhookToken)
        {
            var url = $"{discordUrl}/{webhookId}/{webhookToken}";
            var uri = new Uri(url, UriKind.Absolute);

            return new DiscordWebhook(uri);
        }

        private DiscordWebhook(Uri uri)
        {
            this.uri = uri;
        }

        public UnityWebRequestAsyncOperation Send(string username, string message)
        {
            var json = BuildJson(username, message);
            var uploadHandler = new UploadHandlerRaw(Encoding.UTF8.GetBytes(json));
            uploadHandler.contentType = "application/json";

            var request = new UnityWebRequest(uri, UnityWebRequest.kHttpVerbPOST, null, uploadHandler);
            var op = request.SendWebRequest();
            return op;
        }

        private string BuildJson(string username, string message)
        {
            stringBuilder.Clear();

            stringBuilder.Append("{\"username\": \"");
            JsonUtils.AppendJson(stringBuilder, username);
            stringBuilder.Append("\", \"content\": \"");
            JsonUtils.AppendJson(stringBuilder, message);
            stringBuilder.Append("\"}");

            var json = stringBuilder.ToString();
            stringBuilder.Clear();

            return json;
        }
    }
}
