using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class Program
    {
       
       
        static async Task Main(string[] args)
        {
            String url = "http://homologacao.8quali.com.br/api/NomeUsuarioByLogin?login=atendimento@8idea.com.br";

            UriBuilder builder = new UriBuilder();
            builder.Path = url;
         
                HttpClient client = new HttpClient();

                HttpResponseMessage response = await client.GetAsync(url);

                //verifica se a solicitação foi bem sucedida
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();


                }

            








          

        }

        private static string ByteArrayToString(byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];
            Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }
    }




    public class Ocorrencias
    {
        public string Codigo { get; set; }

        public string Chave { get; set; }
        public string Descricao { get; set; }

        public String UsuarioIncluiuLogin { get; set; }
        public DateTime DataInclusao { get; set; }
        public DTODisposicaoInicial[] DisposicaoInicials;
        public DTOAnexo[] Anexos;
    }


    public class DTODisposicaoInicial
    {
        public String Descricao { get; set; }
        public String LoginDoResponsavel { get; set; }//nome completo
    }
    public class DTOAnexo
    {
        public string ImageBytes { get; set; } //passa os bytes em encode 64, acredito que esse método vai funcionar System.Text.Encoding.UTF8.GetBytes(plainText);
        public string NomeAnexo { get; set; }
        public string ExtencaoAnexo { get; set; }
    }
}
