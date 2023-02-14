//----------------------------------------
// MIT License
// Copyright(c) 2021 Jonas Boetel
//----------------------------------------
using UnityEditor;
using UnityEngine;

namespace Lumpn.Discord.Samples
{
    [CustomEditor(typeof(WebhookTester))]
    public sealed class WebhookTesterEditor : Editor<WebhookTester>
    {
        public sealed override void OnInspectorGUI(WebhookTester tester)
        {
            if (GUILayout.Button("Send"))
            {
                tester.StartCoroutine(tester.Run());
            }
        }
    }
}
