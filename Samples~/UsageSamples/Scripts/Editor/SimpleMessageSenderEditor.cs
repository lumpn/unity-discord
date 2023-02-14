//----------------------------------------
// MIT License
// Copyright(c) 2021 Jonas Boetel
//----------------------------------------
using UnityEditor;
using UnityEngine;

namespace Lumpn.Discord.Samples
{
    [CustomEditor(typeof(SimpleMessageSender))]
    public sealed class SimpleMessageSenderEditor : Editor<SimpleMessageSender>
    {
        public override void OnInspectorGUI(SimpleMessageSender sender)
        {
            if (GUILayout.Button("Send message to Discord"))
            {
                sender.StartCoroutine(sender.Run());
            }
        }
    }
}
