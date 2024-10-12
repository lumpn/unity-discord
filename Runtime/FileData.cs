//----------------------------------------
// MIT License
// Copyright(c) 2024 Jonas Boetel
//----------------------------------------
using System.Globalization;

namespace Lumpn.Discord
{
    public struct FileData
    {
        public MediaType type;
        public byte[] bytes;

        public static FileData Create(MediaType fileType, byte[] fileBytes)
        {
            return new FileData
            {
                type = fileType,
                bytes = fileBytes,
            };
        }

        public static implicit operator bool(FileData file)
        {
            return (file.type != MediaType.None);
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
