//----------------------------------------
// MIT License
// Copyright(c) 2021 Jonas Boetel
//----------------------------------------
using System;

namespace Lumpn.Discord
{
    [Serializable]
    public struct Message
    {
        public string username;
        public string content;
        public Embed[] embeds;
    }
}
