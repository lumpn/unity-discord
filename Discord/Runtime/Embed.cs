//----------------------------------------
// MIT License
// Copyright(c) 2021 Jonas Boetel
//----------------------------------------
using System;

namespace Lumpn.Discord
{
    [Serializable]
    public struct Embed
    {
        public string title;
        public string description;
        public int color;
        public Thumbnail thumbnail;
        public Footer footer;
        public Author author;
        public Field[] fields;
    }
}
