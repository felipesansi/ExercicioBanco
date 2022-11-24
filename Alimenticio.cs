using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioBanco
{
    internal class Alimenticio: Produto
    {
        public int Medida { get; set; }
        public string Tipo { get; set; }

        public Alimenticio(int codigo, string descricao, DateTime data_validade, double preco, int quantidade, int medida, string tipo): base(codigo, descricao, data_validade, preco, quantidade)
        {
           this. Tipo = tipo;
            this.Medida = medida;
        }
    }
}
