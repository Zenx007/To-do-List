using System;
using System.Collections.Generic;

class Program
{
    static List<string> tarefas = new List<string>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1. Adicionar tarefa");
            Console.WriteLine("2. Ver tarefas");
            Console.WriteLine("3. Remover tarefa");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha: ");

            string opcao = Console.ReadLine();

            if (opcao == "1")
            {
                Console.Write("Digite a tarefa: ");
                string novaTarefa = Console.ReadLine();
                tarefas.Add(novaTarefa);
                Console.WriteLine("Tarefa adicionada!");
            }
            else if (opcao == "2")
            {
                Console.WriteLine("\n--- TAREFAS ---");
                for (int i = 0; i < tarefas.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tarefas[i]}");
                }
            }
            else if (opcao == "3")
            {
                Console.Write("Digite o número da tarefa a remover: ");
                int indice = Convert.ToInt32(Console.ReadLine()) - 1;
                tarefas.RemoveAt(indice);
                Console.WriteLine("Tarefa removida!");
            }
            else if (opcao == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Opção inválida!");
            }
        }
    }
}