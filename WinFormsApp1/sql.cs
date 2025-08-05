using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace styleinbanknotes
{
    public partial class WinFormsApp1 : telacc
    {
        // Declare a string de conexão aqui para usar em todo o formulário
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=sbn;User ID=aluno;Password=aluno";

        public WinFormsApp1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        // Agora você pode usar 'connectionString' em qualquer método desse Form
    }
}

