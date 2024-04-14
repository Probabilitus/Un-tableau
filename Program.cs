

namespace Un_tableau
{
    internal class Program
    {
        static void Main()
        {
            string[] fruits = { "pommes", "poires", "bananes", "cerises" };
            string[] legumes = { "carottes", "radis", "courgettes", "poivrons" };
            string[] fruitsEtLegumes = new string[fruits.Length + legumes.Length]; 
            Array.Copy(fruits, fruitsEtLegumes, fruits.Length);
            Array.Copy(legumes,0, fruitsEtLegumes, fruits.Length, legumes.Length);

            foreach (string element in fruitsEtLegumes)
            {
                Console.WriteLine(element);
            }

            
        }
    }
}
