using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookYourself.Model
{
    class ModelMensagens
    {
        int mensagemCodigo;
        string mensagemAutor;
        string mensagemEmail;
        string mensagemConteudo;

        public int MensagemCodigo
        {
            get
            {
                return mensagemCodigo;
            }

            set
            {
                mensagemCodigo = value;
            }
        }

        public string MensagemAutor
        {
            get
            {
                return mensagemAutor;
            }

            set
            {
                mensagemAutor = value;
            }
        }

        public string MensagemEmail
        {
            get
            {
                return mensagemEmail;
            }

            set
            {
                mensagemEmail = value;
            }
        }

        public string MensagemConteudo
        {
            get
            {
                return mensagemConteudo;
            }

            set
            {
                mensagemConteudo = value;
            }
        }
    }
}
