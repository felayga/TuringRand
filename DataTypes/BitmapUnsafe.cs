using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApplication2.DataTypes
{
    public unsafe class BitmapUnsafe
    {
        private Bitmap image;
        System.Drawing.Imaging.BitmapData bitmapdata;
        int* data;

        public BitmapUnsafe(Bitmap image)
        {
            this.image = image;
        }

        public void Lock()
        {
            bitmapdata = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), System.Drawing.Imaging.ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            IntPtr ptr = bitmapdata.Scan0;

            data = (int*)ptr.ToInt32();
        }

        public int Width { get { return image.Width; } }
        public int Height { get { return image.Height; } }

        public void Unlock()
        {
            image.UnlockBits(bitmapdata);
        }

        public void SetPixel(int x, int y, int color)
        {
            data[x + y * image.Width] = color;
        }

        public int GetPixel(int x, int y)
        {
            return data[x + y * image.Width];
        }

        private static System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
        public System.Numerics.BigInteger IsBoring()
        {
            byte[] data = new byte[image.Width * image.Height * 4];
            System.Runtime.InteropServices.Marshal.Copy(bitmapdata.Scan0, data, 0, data.Length);

            return new System.Numerics.BigInteger(md5.ComputeHash(data));
        }

    }
}
