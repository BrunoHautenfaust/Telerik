namespace Task1___ClassSize
{
    using System;
    public class Size
    {
        private double width, height;
        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width {
            get
            {
                return this.width;
            }
            private set
            {
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                this.height = value;
            }
        }

        public static Size GetRotatedSize(Size size, double rotatedFigureAngle)
        {
            double cosAngle = Math.Cos(rotatedFigureAngle);
            double sinAngle = Math.Sin(rotatedFigureAngle);
            double sizeWidth = size.width;
            double sizeHeight = size.height;
            double rotatedSizeWidth = Math.Abs(cosAngle) * sizeWidth + Math.Abs(sinAngle) * sizeHeight;
            double rotatedSizeHeight = Math.Abs(sinAngle) * sizeWidth + Math.Abs(cosAngle) * sizeHeight;
            Size rotatedFigure = new Size(rotatedSizeWidth, rotatedSizeHeight);

            return rotatedFigure;
        }

    }
}