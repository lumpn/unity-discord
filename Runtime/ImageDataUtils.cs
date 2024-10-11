//----------------------------------------
// MIT License
// Copyright(c) 2024 Jonas Boetel
//----------------------------------------
using System.Collections.Generic;

namespace Lumpn.Discord
{
    public static class ImageDataUtils
    {
        internal static string Bake(string url, ImageData image, List<ImageData> outImages)
        {
            if (image)
            {
                url = image.CreateURL(outImages.Count);
                outImages.Add(image);
            }
            return url;
        }
    }
}
