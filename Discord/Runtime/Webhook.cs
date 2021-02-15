//----------------------------------------
// MIT License
// Copyright(c) 2021 Jonas Boetel
//----------------------------------------
using System;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;

namespace Lumpn.Discord
{
    public sealed class DiscordWebhook
    {
        private const string discordUrl = "https://discord.com/api/webhooks";

        private readonly Uri uri;

        private DiscordWebhook(Uri uri)
        {
            this.uri = uri;
        }

        public UnityWebRequestAsyncOperation Send(Message message)
        {
            var json = JsonUtility.ToJson(message);

            var uploadHandler = new UploadHandlerRaw(Encoding.UTF8.GetBytes(json));
            uploadHandler.contentType = "application/json";

            var request = new UnityWebRequest(uri, UnityWebRequest.kHttpVerbPOST, null, uploadHandler);
            var op = request.SendWebRequest();
            return op;
        }

        public static DiscordWebhook Create(string webhookId, string webhookToken)
        {
            var url = $"{discordUrl}/{webhookId}/{webhookToken}";
            var uri = new Uri(url, UriKind.Absolute);

            return new DiscordWebhook(uri);
        }
    }
}
