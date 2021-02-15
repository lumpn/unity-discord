//----------------------------------------
// MIT License
// Copyright(c) 2021 Jonas Boetel
//----------------------------------------
using UnityEngine;

namespace Lumpn.Discord.Utils
{
    public static class ColorUtils
    {
        /// <summary>
        /// Converts Unity colors to Discord colors.
        /// </summary>
        public static int ToColorCode(Color32 color)
        {
            return (color.r * 256 * 256) + (color.g * 256) + color.b;
        }

        /// <summary>
        /// Converts HTML colors to Discord colors.
        /// </summary>
        public static int ToColorCode(string htmlColor)
        {
            var color = ParseHtmlString(htmlColor, Color.magenta);
            return ToColorCode(color);
        }

        private static Color ParseHtmlString(string htmlColor, Color fallback)
        {
            if (ColorUtility.TryParseHtmlString(htmlColor, out Color color))
            {
                return color;
            }
            return fallback;
        }
    }
}
