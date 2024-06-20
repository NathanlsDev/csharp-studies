namespace Rectangle
{
    internal class Rectangle
    {
        public double Width;
        public double Height;

        public double Area(double width, double height)
        { 
            return width * height;
        }

        public double Perimeter(double width, double height)
        {
            return (width + height) * 2;
        }

        public double Diagonal(double width, double height)
        {
            return Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));
        }

        public override string ToString()
        {
            return $"\nAREA = {Area(Width, Height).ToString("F2")}"
                + $"\nPERIMETER = {Perimeter(Width, Height).ToString("F2")}"
                + $"\nDIAGONAL = {Diagonal(Width, Height).ToString("F2")}";
        }
    }
}
