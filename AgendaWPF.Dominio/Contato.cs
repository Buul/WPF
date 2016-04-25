using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaWPF.Dominio
{
    public class Contato : Entidade
    {
        private string _nome = string.Empty;
        public string Nome
        {
            get { return _nome; }
            set
            {
                _nome = value;
            }
        }
        private IList<Telefone> _telefones = new List<Telefone>();
        public IList<Telefone> Telefones
        {
            get { return _telefones; }
            set
            {
                _telefones = value;
            }
        }
    }