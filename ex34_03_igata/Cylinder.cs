namespace ShapeSolid
{
    internal class Cylinder:Column
    {
        public Cylinder(float radius, float height):base(new Circle(radius), height)
        {
        }
    }
}