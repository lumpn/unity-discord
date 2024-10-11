//----------------------------------------
// MIT License
// Copyright(c) 2024 Jonas Boetel
//----------------------------------------
namespace Lumpn.Discord
{
    public static class MediaTypeUtils
    {
        public static string GetFileExtension(MediaType type)
        {
            switch (type)
            {
                case MediaType.JPEG: return "jpg";
                case MediaType.PNG: return "png";
                case MediaType.WebP: return "webp";
                case MediaType.GIF: return "gif";
            }
            return string.Empty;
        }

        public static string GetContentType(MediaType type)
        {
            switch (type)
            {
                case MediaType.JPEG: return "image/jpeg";
                case MediaType.PNG: return "image/png";
                case MediaType.WebP: return "image/webp";
                case MediaType.GIF: return "image/gif";
            }
            return "application/octet-stream";
        }
    }
}
