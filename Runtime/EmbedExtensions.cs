//----------------------------------------
// MIT License
// Copyright(c) 2021 Jonas Boetel
//----------------------------------------
using Lumpn.Discord.Utils;
using UnityEngine;
using System;

namespace Lumpn.Discord
{
    public static class EmbedExtensions
    {
        public static Embed SetTitle(this Embed embed, string title)
        {
            embed.title = title;
            return embed;
        }

        public static Embed SetDescription(this Embed embed, string description)
        {
            embed.description = description;
            return embed;
        }

        public static Embed SetColor(this Embed embed, Color32 color)
        {
            embed.color = ColorUtils.ToColorCode(color);
            return embed;
        }

        public static Embed SetColor(this Embed embed, string color)
        {
            embed.color = ColorUtils.ToColorCode(color);
            return embed;
        }

        public static Embed SetAuthor(this Embed embed, string name, string icon_url = null, string url = null)
        {
            embed.author = new Author { name = name, icon_url = icon_url, url = url };
            return embed;
        }

        public static Embed SetThumbnail(this Embed embed, string url)
        {
            embed.thumbnail = new Thumbnail { url = url };
            return embed;
        }

        public static Embed SetImage(this Embed embed, string url)
        {
            embed.image = new Image { url = url };
            return embed;
        }

        public static Embed SetVideo(this Embed embed, string url)
        {
            embed.video = new Video { url = url };
            return embed;
        }

        public static Embed SetFooter(this Embed embed, string text, string icon_url = null)
        {
            embed.footer = new Footer { text = text, icon_url = icon_url };
            return embed;
        }

        public static Embed AddField(this Embed embed, string name, string value, bool inline = true)
        {
            var len = embed.fields?.Length ?? 0;
            Array.Resize(ref embed.fields, len + 1);
            embed.fields[len] = new Field { name = name, value = value, inline = inline };
            return embed;
        }
    }
}
