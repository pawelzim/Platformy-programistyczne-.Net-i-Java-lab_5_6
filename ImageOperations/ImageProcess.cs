using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageOperations
{
    internal class ImageProcess
    {
        public static Bitmap createGrayscale(Bitmap originalImage)
        {
            Bitmap grayscaleImage = new Bitmap(originalImage.Width, originalImage.Height);
            for (int y = 0; y < originalImage.Height; y++)
            {
                for (int x = 0; x < originalImage.Width; x++)
                {
                    Color originalColor = originalImage.GetPixel(x, y);
                    int grayScaleValue = (int)((originalColor.R * 0.3) + (originalColor.G * 0.59) + (originalColor.B * 0.11));
                    Color grayColor = Color.FromArgb(grayScaleValue, grayScaleValue, grayScaleValue);
                    grayscaleImage.SetPixel(x, y, grayColor);
                }
            }
            return grayscaleImage;
        }

        public static Bitmap createNegative(Bitmap originalImage)
        {
            Bitmap negativeImage = new Bitmap(originalImage.Width, originalImage.Height);
            for (int y = 0; y < originalImage.Height; y++)
            {
                for (int x = 0; x < originalImage.Width; x++)
                {
                    Color originalColor = originalImage.GetPixel(x, y);
                    Color negativeColor = Color.FromArgb(255 - originalColor.R, 255 - originalColor.G, 255 - originalColor.B);
                    negativeImage.SetPixel(x, y, negativeColor);
                }
            }
            return negativeImage;
        }
        
        public static Bitmap createMirror(Bitmap originalImage)
        {
            Bitmap mirrorImage = new Bitmap(originalImage.Width, originalImage.Height);
            for (int y = 0; y < originalImage.Height; y++)
            {
                for (int x = 0; x < originalImage.Width; x++)
                {
                    mirrorImage.SetPixel(originalImage.Width - 1 - x, y, originalImage.GetPixel(x, y));
                }
            }
            return mirrorImage;
        }

        public static Bitmap createThreshold(Bitmap originalImage, int threshold = 128)
        {
            Bitmap grayscaleImage = ImageProcess.createGrayscale(originalImage);
            Bitmap thresholdImage = new Bitmap(grayscaleImage.Width, grayscaleImage.Height);
            for (int y = 0; y < grayscaleImage.Height; y++)
            {
                for (int x = 0; x < grayscaleImage.Width; x++)
                {
                    Color originalColor = grayscaleImage.GetPixel(x, y);
                    int intensity = originalColor.R;
                    Color newColor = (intensity >= threshold) ? Color.White : Color.Black;
                    thresholdImage.SetPixel(x, y, newColor);
                }
            }
            return thresholdImage;
        }
    }
}
