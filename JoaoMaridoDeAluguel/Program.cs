using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using System.Text.RegularExpressions;
using System.Linq.Expressions;
// 1 linha e a ordem de serviço

namespace JoaoMaridoDeAluguel
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Caminho do txt
            string path = "E:\\CURSOS\\SENAI\\Desafio-txt\\JoaoMaridoDeAluguel\\JoaoMaridoDeAluguel\\bin\\Debug\\dados.txt";

            // Lista de campos presentes no arquivo
            List<string> campos = new List<string>()
        {
            "Solicitação:", "Produto:", "Aceito em:", "Serviço:", "Prazo:", "Local:", "Complemento:", "Bairro:",
            "Região:", "Cidade:", "Estado:", "CEP:", "Referências:", "Problema:", "Importante:","FONE:", "Segurado:",
            "Solicitante:", "Telefone:", "Destino:", "Referência:", "Equipamento:", "Marca:", "Ano:"
        }; //itens repetidos: Local, complemento, bairro, região, cidade, estado, referencia/referencias,

            List<string> valores;

            // Le o txt com codiicação utf 8 e armazena na variavel Dados
            string Dados = File.ReadAllText(path, Encoding.UTF8);
            string infoCampo = Dados;

            // Procura os itens da lista campos no texto e substitui por ";"
            foreach (string campo in campos)
            {
                infoCampo = infoCampo.Replace(campo, ";");
                infoCampo = Regex.Replace(infoCampo, campo, ";");
  
            }

            // Cria uma lista somente com os valores separados por ";"
            valores = new List<string>(infoCampo.Split(';'));

            // Descobre onde estão o index de cada item printando no terminal
            //for (int i = 0; i < valores.Count; i++)
            //{
            //    try
            //    {
            //        valores[i] = valores[i].Trim();
            //        
            //        Console.WriteLine("index de valores: " + i);
            //        Console.WriteLine("Campo: " + campos[i] + " -  " + valores[i+1]);
            //    }
            //    catch (System.ArgumentOutOfRangeException)
            //    {
            //        break;
            //    }
            //}

            IDictionary<string, string> DadosDic = new Dictionary<string, string>();
            DadosDic.Add("OS:", valores[0].Trim());

            IDictionary<string, string> DadosDicRepetidos = new Dictionary<string, string>();

            int c = 0;

            while (c <= campos.Count)
            {
                try
                {
                    DadosDic.Add(campos[c].Trim(), valores[c + 1].Trim());
                }
                catch (System.ArgumentException) // O txt tem campos repetidos,  esta tentando sobrescrever item existente no dicionario e dando ArgumentException
                {
                    //Console.WriteLine("System.ArgumentException");
                    try
                    {
                        DadosDicRepetidos.Add(campos[c].Trim(), valores[c + 1].Trim());
                    }
                    catch (System.ArgumentOutOfRangeException)
                    {
                        //Console.WriteLine("ArgumentOutOfRangeException");
                        break; // encerra o loop quando acaba os valores para adicioanr ao dicionario
                    }
                }
                c = c + 1;
            }

            DadosDic.Select(i => $"{i.Key} {i.Value}").ToList().ForEach(Console.WriteLine);
            //Console.WriteLine("\nDADOS REPETIDOS: \n");
            //DadosDicRepetidos.Select(i => $"{i.Key} {i.Value}").ToList().ForEach(Console.WriteLine);
            Console.ReadKey();
        }
    }
}


// passos
// Criar lista com os campos
// Substituir os campos por ";" e criar um arquivo só com os valores dos campos separados por ";"
// Criar um dicionario relacionando os campos com seus respectivos valores

