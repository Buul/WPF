using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaWPF.Dominio
{
    public class Telefone
    {
        private TipoTelefoneEnum _tipo = TipoTelefoneEnum.Residencial;

        public TipoTelefoneEnum Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        private string _numero = string.Empty;

        public string Numero
        {
            get
            {
                return _numero;
                
            }
            set
            {
                _numero = value;
            }
        }
    }
    public enum TipoTelefoneEnum
    {
        Residencial,
        Comercial,
        Celular,
        Recado
    }
}