using System;
using System.IO;
using ImageMagick;
using System.Drawing;
using System.Net.Mime;

namespace FlipPic.Models
{
    public class ReadImages
    {
//        private static MemoryStream LoadMemoryStreamImage()
//        {
//            return new MemoryStream(LoadImageBytes());
//        }
//
//        private static byte[] LoadImageBytes()
//        {
//            return File.ReadAllBytes(Images.SnakewareJpg);
//        }

        public static void ReadImage()
        {
            // Read from file.
            using (MagickImage image = new MagickImage(Images.SnakewareJpg))
            {
            }

/*            // Read from stream.
            using (MemoryStream memStream = LoadMemoryStreamImage())
            {
                using (MagickImage image = new MagickImage(memStream))
                {
                }
            }

            // Read from byte array.
            byte[] data = LoadImageBytes();
            using (MagickImage image = new MagickImage(data))
            {
            }

            // Read image that has no predefined dimensions.
            MagickReadSettings settings = new MagickReadSettings();
            settings.Width = 800;
            settings.Height = 600;
            using (MagickImage image = new MagickImage("xc:yellow", settings))
            {
            }

            using (MagickImage image = new MagickImage())
            {
                image.Read(Images.SnakewareJpg);
                image.Read(data);
                image.Read("xc:yellow", settings);

                using (MemoryStream memStream = LoadMemoryStreamImage())
                {
                    image.Read(memStream);
                }
            }*/
        }

        public static void ReadBasicImageInformation()
        {
            // Read from file
            MagickImageInfo info = new MagickImageInfo(Images.SnakewarePng);

/*            // Read from stream
            using (MemoryStream memStream = LoadMemoryStreamImage())
            {
                info = new MagickImageInfo(memStream);
            }

            // Read from byte array
            byte[] data = LoadImageBytes();
            info = new MagickImageInfo(data);

            info = new MagickImageInfo();
            info.Read(Images.SnakewarePng);
            using (MemoryStream memStream = LoadMemoryStreamImage())
            {
                info.Read(memStream);
            }
            info.Read(data);*/

            Console.WriteLine(info.Width);
            Console.WriteLine(info.Height);
            Console.WriteLine(info.ColorSpace);
            Console.WriteLine(info.Format);
            Console.WriteLine(info.Density.X);
            Console.WriteLine(info.Density.Y);
            Console.WriteLine(info.Density.Units);
        }

        public static void ReadImageWithMultipleFrames()
        {
            // Read from file
            using (MagickImageCollection collection = new MagickImageCollection(Images.SnakewareJpg))
            {
            }

            /*// Read from stream
            using (MemoryStream memStream = LoadMemoryStreamImage())
            {
                using (MagickImageCollection collection = new MagickImageCollection(memStream))
                {
                }
            }

            // Read from byte array
            byte[] data = LoadImageBytes();
            using (MagickImageCollection collection = new MagickImageCollection(data))
            {
            }

            // Read pdf with custom density.
            MagickReadSettings settings = new MagickReadSettings();
            settings.Density = new Density(144);

            using (MagickImageCollection collection = new MagickImageCollection(Images.SnakewarePdf, settings))
            {
            }

            using (MagickImageCollection collection = new MagickImageCollection())
            {
                collection.Read(Images.SnakewareJpg);
                using (MemoryStream memStream = LoadMemoryStreamImage())
                {
                    collection.Read(memStream);
                }
                collection.Read(data);
                collection.Read(Images.SnakewarePdf, settings);
            }*/
        }
    }
}