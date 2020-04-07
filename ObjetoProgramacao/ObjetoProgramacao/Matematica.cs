using System;

namespace ObjetoProgramacao
{
    class Matematica
    {

        public int A { get; set;}
        public int B { get; set; }

        public int Calcular()
        {
            return this.A + this.B;
        }
        static void Main(string[] args)
        {
            Matematica m = new Matematica();
            m.A = 5;
            m.B = 10;
            Console.WriteLine(m.Calcular());
        }
    }
}
