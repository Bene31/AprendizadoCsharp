﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.model
{
    class Veiculo
    {
        public string marca;
        public string modelo;
        public int qtdpassageiros;
        public int ano;

        public virtual void Mover()
        {
            Console.WriteLine("Mover dentro de veiculo");
        }
    }
}
