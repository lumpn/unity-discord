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

        public UnityWebRequest CreateWebRequest(Message message)
        {
            var json = JsonUtility.ToJson(message);

            var downloadHandler = new DownloadHandlerBuffer();
            var uploadHandler = new UploadHandlerRaw(Encoding.UTF8.GetBytes(json))
            {
                contentType = "application/json",
            };

            var request = new UnityWebRequest(uri, UnityWebRequest.kHttpVerbPOST, downloadHandler, uploadHandler);
            return request;
        }
    }
}
