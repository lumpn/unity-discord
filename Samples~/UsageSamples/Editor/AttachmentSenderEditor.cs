//----------------------------------------
// MIT License
// Copyright(c) 2021 Jonas Boetel
//----------------------------------------
using UnityEditor;
using UnityEngine;

namespace Lumpn.Discord.Samples
{
    [CustomEditor(typeof(AttachmentSender))]
    public sealed class AttachmentSenderEditor : Editor<AttachmentSender>
    {
        public override void OnInspectorGUI(AttachmentSender sender)
        {
            if (GUILayout.Button("Send message to Discord"))
            {
                sender.StartCoroutine(sender.Run());
            }
        }
    }
}
