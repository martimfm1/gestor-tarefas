string ficheiro = "tarefas.txt";

if (!File.Exists(ficheiro))
    {
        Console.WriteLine("ficheiro de tarefas não encontrado.");
        Console.WriteLine("Criando um novo ficheiro de tarefas...");
        File.Create(ficheiro).Close();
    }

int opcao = 0;

while (opcao != 3)
{
    Console.WriteLine("=== GESTOR DE TAREFAS ===");
    Console.WriteLine("1 - Ver tarefas");
    Console.WriteLine("2 - Adicionar tarefa");
    Console.WriteLine("3 - Remover tarefa");
    Console.WriteLine("4 - Sair");

    opcao = int.Parse(Console.ReadLine() ?? "0");

    if (opcao == 1)
    {
        if (File.Exists(ficheiro))
        {
            string[] linhas = File.ReadAllLines(ficheiro);
            List<string> tarefas = new List<string>(linhas);
            Console.WriteLine("Tarefas:");
            foreach (string tarefa in tarefas)
            {
                Console.WriteLine(tarefa);
            }
        }   
    }

    if (opcao == 2)
    {
        Console.WriteLine("Digite a nova tarefa:");
        string novaTarefa = Console.ReadLine() ?? "";
        File.AppendAllText(ficheiro, novaTarefa + Environment.NewLine);
        Console.WriteLine("Tarefa adicionada com sucesso.");
    }

    if (opcao == 3)
    {
        Console.WriteLine("Digite o número da tarefa a remover:");
        Console.WriteLine("Tarefas:");
        Console.WriteLine(File.ReadAllText(ficheiro));
        
        int numeroTarefa = int.Parse(Console.ReadLine() ?? "0");
        if (File.Exists(ficheiro))
        {
            string[] linhas = File.ReadAllLines(ficheiro);
            List<string> tarefas = new List<string>(linhas);
            if (numeroTarefa > 0 && numeroTarefa <= tarefas.Count)
            {
                tarefas.RemoveAt(numeroTarefa - 1);
                File.WriteAllLines(ficheiro, tarefas);
                Console.WriteLine("Tarefa removida com sucesso.");
            }
            else
            {
                Console.WriteLine("Número de tarefa inválido.");
            }
        }
    }

    if (opcao == 4)
    {
        Console.WriteLine("A sair do programa...");
    }

    if (opcao > 4 || opcao < 1)
    {
        Console.WriteLine("Opção inválida!");
    }
}