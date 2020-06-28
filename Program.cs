using System;

namespace Aula26Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product("Iphone 11",1812,4000.99f);
            Product p2 = new Product("Playstation 4",15120,1600.70f);
            Product p3 = new Product("Alexa",1523,250f);

        
            Carrinho c = new Carrinho();
            c.Create(p1);
            c.Create(p2);
            c.Create(p3);

            c.Read();

            c.ShowSubtotal();
        }
    }
}
