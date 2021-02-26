using SpedProjeto.Projeto;
using System;
using System.Collections.Generic;
using System.IO;

namespace SpedProjeto {
    class Program {
        static void Main(string[] args) {
            List<string> arquivo = new List<string>(); //lista que receberá o arquivo
            string localArquivo = @"D:\mesclado1.txt"; //variavel temporaria que aponta para o arquivo



            OpArquivos ma = new OpArquivos(); //instancia da classe que manipula o arquivo

            arquivo = ma.CarregaArquivo(localArquivo);
            string y = arquivo[0];
            string x = ma.IdentificaBloco(arquivo[0]);
            



        }
    }
}