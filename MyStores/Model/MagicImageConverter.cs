using System.Drawing.Imaging;

namespace MyStores.Model
{
    public class MagicImageConverter
    {
        public static Image ConvertByteToImage(byte[] data)
        {
            using MemoryStream ms = new MemoryStream(data);
            {
                return Image.FromStream(ms);
            }
        }

        public static byte[] ConvertImageToByte(Image img, int jpegQuality)
        {
            using MemoryStream ms = new MemoryStream();
            {
                var jpegEncoder = GetEncoder(ImageFormat.Jpeg);
                var encoderParameters = new EncoderParameters(1);
                encoderParameters.Param[0] = new EncoderParameter(Encoder.Quality, (long)jpegQuality);
                img.Save(ms, jpegEncoder, encoderParameters);
                return ms.ToArray();
            };
        }

        private static ImageCodecInfo GetEncoder(ImageFormat format)
        {
            var codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }

            return null;
        }

        public static byte[] GetBytesFromStream(Stream imageStream)
        {
            using MemoryStream ms = new MemoryStream();
            {
                imageStream.CopyTo(ms);
                return ms.ToArray();
            }
        }
    }
}
