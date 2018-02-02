using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luiz_teste
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Carro c1 = new Carro();
            Motor m1 = new Motor();

            Console.WriteLine("Definindo dados do veiculo:");
            c1.Atribuir();
            Console.WriteLine("Dados do veiculo");
            c1.Mostrar();

            Console.WriteLine("Definindo dados do Motor:");
            Console.WriteLine("Digite o modelo do motor:");
            m1.Modelo = Console.ReadLine();
            m1.DefCilindrada();
            Console.WriteLine("Digite o tipo do motor:");
            m1.Tipo = Console.ReadLine();
            Console.WriteLine("Dados do motor");
            Console.WriteLine(m1.Modelo);
            Console.WriteLine(m1.Cilindradas);
            Console.WriteLine(m1.Tipo);





            //Console.WriteLine(c1.marca);

            Console.ReadKey();
        }
    }
}
