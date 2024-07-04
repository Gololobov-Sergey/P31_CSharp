namespace P31_CSharp
{
    internal class Apple
    {
        public int Weight { get; set; }
        public string Color { get; set; }

        public Apple(string color, int weight)
        {
            Weight = weight;
            Color = color;
        }

        public void Print()
        {
            Console.WriteLine($"Weight = {Weight}, Color = {Color}");
        }

        static public Kompot operator +(Apple a1, Apple a2)
        {
            return new Kompot(new Apple[]{ a1, a2 });
        }
        
    }
}