using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luiz_teste
{
    class Motor
    {                     
        public string Modelo { get; set; }
        public string Cilindradas { get; set; }
        public string Tipo { get; set; }

        public void DefCilindrada()
        {
            if (this.Modelo == "1.0")
            {
                this.Cilindradas = "90cc";
            }
            else if (this.Modelo == "1.4")
            {
                this.Cilindradas = "100cc";
            }
            else if (this.Modelo == "2.0")
            {
                this.Cilindradas = "150cc";
            }
            else
            {
                Console.WriteLine("Motor Inválido!");
            }
        }
    }
}
