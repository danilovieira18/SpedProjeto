using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SpedProjeto.Projeto {
    class OpArquivos {

        public string _diretorioArquivo { get; set; }
        private List<string> arquivo = new List<string>();

        public List<string> CarregaArquivo(string diretorioArquivo) {
            this._diretorioArquivo = diretorioArquivo;

            string[] temp = File.ReadAllLines(diretorioArquivo);
            for (int i = 0; i < temp.Length; i++) {
                arquivo.Add(temp[i]);

            }

            return arquivo;
        } // ler arquivo e devolve Lista preenchida

        public string IdentificaBloco(string linha) {
            string[] parteLinha = new string[4];

            if (linha[0].Equals('|')) {
                int j = 0;

                for (int i = 1; i < parteLinha.Length + 1; i++) {
                    parteLinha[j] = linha[i].ToString();
                    j++;
                }
            }
            string retorno = String.Concat(parteLinha);
            return retorno;
        } // analisa os 5 primeiros caracteres para identificar o bloco a que a linha pertence

        public string AlteraItemLinha(string linha, string novoValor, string antigoValor) {
            return linha.Replace(antigoValor, novoValor);

        } //Localiza item em linha e substitui por parametro 
        public int ContaPipe(string linha) {
            int qtd = 0;

            for (int i = 0; i < linha.Length; i++) {
                if (linha[i].Equals('|')) {
                    qtd++;
                }
                else {
                    continue;
                }
            }
            return qtd;
        } // contador de pipes por linha
    }
}
