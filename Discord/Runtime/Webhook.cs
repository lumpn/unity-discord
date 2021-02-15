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
    public sealed class Webhook
    {
        private readonly Uri uri;

        public Webhook(string url)
        {
            this.uri = new Uri(url, UriKind.Absolute);
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
    }
}
