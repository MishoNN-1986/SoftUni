namespace P01._DrawingShape_Before
{
    using Contracts;

    public class Rectangle : IShape //не е работа да знае къде се рисува, метода най-долу е излишен
    {
        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width { get; set; }

        public double Height { get; set; }

        public double Area
        {
            get { return this.Width * this.Height; }
        }

        public void Draw(IRenderer render, IDrawingContext context)
        {
            render.Render(context, this);
        }
    }
}
