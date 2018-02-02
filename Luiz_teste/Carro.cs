using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// teste

namespace Luiz_teste
{
    class Carro
    {
        private string marca;
        private string modelo;
        private int ano;
        private string cor;

        public void Atribuir()
        {
            Console.WriteLine("Digite a marca:");
            this.marca = Console.ReadLine();
            Console.WriteLine("Digite o modelo:");
            this.modelo = Console.ReadLine();
            Console.WriteLine("Digite o ano:");
            this.ano = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a cor:");
            this.cor = Console.ReadLine();
        }
        public void Mostrar()
        {
            Console.WriteLine(this.marca);
            Console.WriteLine(this.modelo);
            Console.WriteLine(this.ano);
            Console.WriteLine(this.cor);
        }

    }
}
