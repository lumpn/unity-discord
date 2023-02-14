//----------------------------------------
// MIT License
// Copyright(c) 2021 Jonas Boetel
//----------------------------------------
using UnityEditor;
using UnityEngine;

namespace Lumpn.Discord.Samples
{
    [CustomEditor(typeof(ComplexMessageSender))]
    public sealed class ComplexMessageSenderEditor : Editor<ComplexMessageSender>
    {
        public override void OnInspectorGUI(ComplexMessageSender sender)
        {
            if (GUILayout.Button("Send message to Discord"))
            {
                sender.StartCoroutine(sender.Run());
            }
        }
    }
}
