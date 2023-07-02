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

        public static byte[] ConvertImageToByte(Image img)
        {
            using MemoryStream ms = new MemoryStream();
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            };
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
