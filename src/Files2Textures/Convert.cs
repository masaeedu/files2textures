using System;
using System.Collections.Generic;
using System.Text;
using ImageMagick;
using System.IO;

namespace Files2Textures
{
    public struct Png
    {
        public byte[] Data { get; }
        public int Height { get; }
        public int Width { get; }
        
        internal Png(byte[] data, int height, int width)
        {
            Data = data;
            Height = height;
            Width = width;
        }
    }

    public static class Convert
    {
        public static Png FromPDF(string file)
        {
            if (!File.Exists(file))
                throw new FileNotFoundException($"Could not find PDF file {file}");

            using (var page = new MagickImage(file))
            {
                var data = page.ToByteArray(MagickFormat.Png);
                return new Png(data, page.Height, page.Width);
            }
        }
    }
}
