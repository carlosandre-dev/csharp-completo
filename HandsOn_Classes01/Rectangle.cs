namespace HandsOn_Classes01
{
    internal class Rectangle
    {
        public double Width;
        public double Height;

        public double Area()
        {
            return Width * Height;
        }

        public double Perimeter()
        {
            return (2 * (Width + Height));
        }

        public double Diagonal()
        {
            double diagonal = (Width * Width) + (Height * Height);
            return Math.Sqrt(diagonal);
        }

    }
}
