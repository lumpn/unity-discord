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
                case MediaType.Text: return "txt";
                case MediaType.Zip: return "zip";
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
                case MediaType.Text: return "text/plain";
                case MediaType.Zip: return "application/zip";
            }
            return "application/octet-stream";
        }

        public static bool IsImage(MediaType type)
        {
            switch (type)
            {
                case MediaType.JPEG:
                case MediaType.PNG:
                case MediaType.WebP:
                case MediaType.GIF:
                    return true;
            }
            return false;
        }
    }
}
