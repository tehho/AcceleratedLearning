namespace Modul6
{
    public abstract class Shape
    {
        public string Name { get; set; }
        public virtual double Area { get; }
        public virtual double Circumfrens { get; }

        public Shape()
        {
            Name = "Unknown";
        }
        public Shape(string name)
        {
            Name = name;
        }


        public abstract void SayHello();
        public abstract void WriteArea();
        public abstract void WriteCircumfrens();


    }
}
