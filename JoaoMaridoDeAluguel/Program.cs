using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using System.Text.RegularExpressions;
// 1 linha e a ordem de serviço

namespace JoaoMaridoDeAluguel
{
    internal class Program
    {
        static void Main(string[] args)
        {

        //    List<string> Campos = new List<string>()
        //{
        //    "Solicitação:", "Produto:", "Aceito em:", "Serviço:", "Prazo:", "Local:", "Complemento:", "Bairro:",
        //    "Região:", "Cidade:", "Estado:", "CEP:", "Referências:", "Problema:", "Importante:", "Segurado:",
        //    "Solicitante:", "Telefone:", "Destino:", "Local:", "Complemento:", "Referência:", "Bairro:", "Região:",
        //    "Cidade:", "Estado:", "Equipamento:", "Marca:", "Ano:"
        //};

            //int i = 0;

            //while (i < Campos.Count)
            //{
            //    Console.WriteLine(Campos[i]);
            //    i++;
            //}
            //Console.ReadKey();

            // Replace "file.txt" with the path to your text file
            
            string path = "C:\\Users\\ALUNO\\source\\repos\\Tarefa3\\JoaoMaridoDeAluguel\\dados.txt";

            // Define the list of items to look for in the text file
            List<string> campos = new List<string>()
        {
            "Solicitação:", "Produto:", "Aceito em:", "Serviço:", "Prazo:", "Local:", "Complemento:", "Bairro:",
            "Região:", "Cidade:", "Estado:", "CEP:", "Referências:", "Problema:", "Importante:", "Segurado:",
            "Solicitante:", "Telefone:", "Destino:", "Local:", "Complemento:", "Referência:", "Bairro:", "Região:",
            "Cidade:", "Estado:", "Equipamento:", "Marca:", "Ano:"
        };

            List<string> valores;

            // Le o txt com codiicação utf 8 e armazena na variavel Dados

            string Dados = File.ReadAllText(path, Encoding.UTF8);
            string infoCampo = Dados;

            // Procura os itens da lista campos no texto e substitui por ","
            foreach (string campo in campos)
            {
                infoCampo = infoCampo.Replace(campo, ",");
                infoCampo = Regex.Replace(infoCampo, campo, ",");
  
            }

            //File.WriteAllText("infoCampos.txt", infoCampo);
            //Console.WriteLine(infoCampo);
            //Console.ReadKey();
            //Console.Clear();

            // Cria uma lista somente com os valores separados por ","
            valores = new List<string>(infoCampo.Split(','));

            for (int i = 0; i < valores.Count; i++)
            {
                valores[i] = valores[i].Trim();
                // Descobrir onde estã os index de cada item printando no terminal
                Console.WriteLine(valores[i]);
                Console.WriteLine("index nr: " + i);
            }

            Console.ReadKey();

            //foreach (string valor in valores)
            //{
            //    Console.WriteLine(valor);
            //}
            //Console.ReadKey();

        }
    }
}


// passos
// Criar lista com os campos
// Substituir os campos por "," e criar um arquivo só com os valores dos campos separados por ","
// Criar um dicionario relacionando os campos com seus respectivos valores

