using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioBanco
{
    internal class Produto
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data_validade { get; set; }
        public double Preco { get; set; }
        public int Quantidade  { get; set; }

        public Produto(int codigo, string descricao, DateTime data_validade, double preco, int quantidade)
        {
           this.Codigo = codigo;
           this.Descricao = descricao;
           this.Data_validade = data_validade;
           this.Preco = preco;
          this.Quantidade = quantidade;
        }
    }
}
