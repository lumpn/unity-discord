//----------------------------------------
// MIT License
// Copyright(c) 2021 Jonas Boetel
//----------------------------------------
using System;

namespace Lumpn.Discord
{
    [Serializable]
    public struct Field
    {
        public string name;
        public string value;
        public bool inline;
    }
}
