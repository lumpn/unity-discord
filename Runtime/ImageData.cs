//----------------------------------------
// MIT License
// Copyright(c) 2024 Jonas Boetel
//----------------------------------------
using System.Globalization;

namespace Lumpn.Discord
{
    public struct ImageData
    {
        public MediaType type;
        public byte[] bytes;

        public static ImageData Create(MediaType imageType, byte[] imageBytes)
        {
            return new ImageData
            {
                type = imageType,
                bytes = imageBytes,
            };
        }

        public static implicit operator bool(ImageData image)
        {
            return (image.type != MediaType.None);
        }

        internal string CreateURL(int id)
        {
            return string.Format(CultureInfo.InvariantCulture, "attachment://file{0}.{1}", id, MediaTypeUtils.GetFileExtension(type));
        }

        internal Attachment CreateAttachment(int id)
        {
            var filename = string.Format(CultureInfo.InvariantCulture, "file{0}.{1}", id, MediaTypeUtils.GetFileExtension(type));

            return new Attachment
            {
                id = id,
                filename = filename,
                content_type = MediaTypeUtils.GetContentType(type),
            };
        }
    }
}
