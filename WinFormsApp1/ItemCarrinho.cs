using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace styleinbanknotes
{
    public class ItemCarrinho
    {
        public int IdProduto { get; set; }
    public string Nome { get; set; }
    public decimal PrecoUnitario { get; set; }
    public int Quantidade { get; set; }

    // Uma propriedade "calculada" para facilitar a vida
    public decimal Subtotal
    {
        get { return PrecoUnitario * Quantidade; }
    }
    }
}
