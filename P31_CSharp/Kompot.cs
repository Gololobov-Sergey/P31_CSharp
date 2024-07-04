namespace P31_CSharp
{
    internal class Kompot
    {
        Apple[] Apples;
        public int Sugar { get; private set; } = 100;

        public Kompot(Apple[] apples)
        {
            Apples = apples;
        }

        public void AddSugar(int sugar)
        {
            Sugar += sugar;
        }

        public static Kompot operator +(Kompot k, Apple a)
        {
            Apple[] newApples = new Apple[k.Apples.Length + 1];
            System.Array.Copy(k.Apples, newApples, k.Apples.Length);
            newApples[k.Apples.Length] = a;
            return new Kompot(newApples);
        }

        public Apple this[int index]
        {
            get
            {
                if (index >= 0 && index < Apples.Length)
                    return Apples[index];
                throw new System.IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < Apples.Length)
                    Apples[index] = value;
                else
                    throw new System.IndexOutOfRangeException();
            }
        }


        public int this[string param]
        {
            get
            {
                switch (param)
                {
                    case "Apples":
                        return Apples.Length;
                    case "Sugar":
                        return Sugar;
                    default:
                        throw new System.ArgumentException($"Not patam {param}");
                }
            }
        }




        public void Print()
        {
            Console.WriteLine($"Sugar = {Sugar}");
            foreach (var apple in Apples)
            {
                apple.Print();
            }
        }
    }
}