using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FR_Informatica
{
    class Perfil
    {
        private string nome;
        private string telefone;
        private string aparelho;
        private string endereco;
        private string defeito;
        private DateTime data;
        private decimal valor;

        public Perfil(string nome, string telefone, string aparelho, string endereco, string defeito, DateTime data, decimal valor)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.Aparelho = aparelho;
            this.Endereco = endereco;
            this.Defeito = defeito;
            this.Data = data;
            this.Valor = valor;
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }

        public string Aparelho
        {
            get
            {
                return aparelho;
            }

            set
            {
                aparelho = value;
            }
        }

        public string Endereco
        {
            get
            {
                return endereco;
            }

            set
            {
                endereco = value;
            }
        }

        public string Defeito
        {
            get
            {
                return defeito;
            }

            set
            {
                defeito = value;
            }
        }

        public DateTime Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        public decimal Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }
    }
}
