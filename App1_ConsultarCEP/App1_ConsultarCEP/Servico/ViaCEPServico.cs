using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using App1_ConsultarCEP.Servico.Modelo;
using Newtonsoft.Json;


namespace App1_ConsultarCEP.Servico
{

    
        public class ViaCEPServico
        {
            private static string EnderecoURL = "https://viacep.com.br/ws/{0}/json/";

            public static Endereco BuscarEnderecoViaCep(string cep)
            {
                string NovoEnderecoURL = string.Format(EnderecoURL, cep);

                WebClient wc = new WebClient();
                string conteudo = wc.DownloadString(NovoEnderecoURL);

                Endereco end = JsonConvert.DeserializeObject<Endereco>(conteudo);

                if (end.cep == null)
                return null;

                return end;
            }
        }
    
}
