using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
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

            string Dados = File.ReadAllText(path);
            int i= 0;
            string infoCampos = null;

            while (i <= Dados.Length )
            {
                infoCampos = Dados.Replace(Dados, campos[i]);
                i++;
            }
            
            

           
        File.WriteAllText("infoCampos.txt", infoCampos);
            
            
            
            
            //try
            //{
            //    // Open the text file using a stream reader
            //    using (StreamReader sr = new StreamReader(path))
            //    {
            //        string line;

            //        // Read the file line by line
            //        while ((line = sr.ReadLine()) != null)
            //        {
            //            // Loop through each item in the list and look for it in the current line
            //            foreach (string campo in campos)
            //            {
            //                if (line.Contains(campo))
            //                {
            //                    Console.WriteLine("Item encontrado \"{0}\" ", campo);
            //                }
            //            }
            //        }
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Error reading file: " + e.Message);
            //}

            //Console.ReadKey();



        }
    }
}


// passos
// Procurar ":", gravar : e os caracteres anteriores ate chegar em um "espaço", gravar campos em um array
// procurar informações entre um array e outro, criar um dicionario com o campo do array e com a informação correspondente


// CHAT GPT  -> CRIOU LISTA DE PALAVRAS ENTRE ":" E " "
//string[] Campos = { "Solicitação:", "Produto:", "Aceito em:", "Serviço:", "Prazo:", "Local:", "Complemento:", "Bairro:", "Região:", "Cidade:", "Estado:", "CEP:", "Referências:", "Problema:", "Importante:", "Segurado:", "Solicitante:", "Telefone:", "Destino:", "Local:", "Complemento:", "Referência:", "Bairro:", "Região:", "Cidade:", "Estado:", "Equipamento:", "Marca:", "Ano:"};

//string path = "C:\\Users\\ALUNO\\source\\repos\\Tarefa3\\JoaoMaridoDeAluguel\\dados.txt";

//try
//{
//    // Open the text file using a stream reader
//    using (StreamReader sr = new StreamReader(path))
//    {
//        string line;

//        // Read the file line by line
//        while ((line = sr.ReadLine()) != null)
//        {
//            // Find the ":" character in the line
//            int colonIndex = line.IndexOf(":");

//            while (colonIndex >= 0)
//            {
//                // Go backwards until a space is found
//                int spaceIndex = colonIndex - 1;
//                while (spaceIndex >= 0 && line[spaceIndex] != ' ')
//                {
//                    spaceIndex--;
//                }

//                // Get the word between the space and the ":" and print it to the console
//                string word = line.Substring(spaceIndex + 1, colonIndex - spaceIndex - 1);
//                Console.WriteLine(word);

//                // Find the next ":" character in the line
//                colonIndex = line.IndexOf(":", colonIndex + 1);
//            }
//        }
//    }
//}
//catch (Exception e)
//{
//    Console.WriteLine("Error reading file: " + e.Message);
//}

//Console.ReadKey();



//string path = "C:\\Users\\ALUNO\\source\\repos\\Tarefa3\\JoaoMaridoDeAluguel\\dados.txt";

//try
//{
//    // Open the text file using a stream reader
//    using (StreamReader sr = new StreamReader(path))
//    {
//        string line;

//        // Read the file line by line
//        while ((line = sr.ReadLine()) != null)
//        {
//            // Check if the line contains ":"
//            if (line.Contains(":"))
//            {
//                Console.WriteLine("Found ':' in line: " + line);
//            }
//        }
//    }
//}
//catch (Exception e)
//{
//    Console.WriteLine("Error reading file: " + e.Message);
//}

//Console.ReadKey();