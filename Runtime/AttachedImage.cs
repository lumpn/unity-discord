//----------------------------------------
// MIT License
// Copyright(c) 2024 Jonas Boetel
//----------------------------------------
using System.Globalization;

namespace Lumpn.Discord
{
    public struct AttachedImage
    {
        public MediaType type;
        public byte[] bytes;

        public static AttachedImage Create(MediaType imageType, byte[] imageBytes)
        {
            return new AttachedImage
            {
                type = imageType,
                bytes = imageBytes,
            };
        }

        public Attachment CreateAttachment(int id)
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
