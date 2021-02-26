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




            List<string> codigos = new List<string>();


            string linha = ma.IdentificaBloco(arquivo[0]);
            codigos.Add(linha);

            for (int i = 0; i < arquivo.Count; i++) {
                if (codigos[i].Equals(linha)) {
                    continue;
                }
                else {
                    codigos[i] = ma.IdentificaBloco(arquivo[i]);
                }
            }




            string y = arquivo[0];
            string x = ma.IdentificaBloco(arquivo[0]);

            string linhaTeste = "|0005||50790640|Rodovia ROD BR CENTO E UM|550|KM 70 LOJA 03 04 05 06 07 GALPAO GV III BLOCO 76|CURADO|8132733130||brunogalegolaticinios@gmail.com|";
            string linhaalterada = ma.AlteraItemLinha(linhaTeste, "eduardo@emc.tec.br", "brunogalegolaticinios@gmail.com");
            Console.WriteLine(linhaalterada);

        }
    }
}