# Gestor de Tarefas

Gestor de tarefas simples no terminal feito em C#.

---

## Como usar

Ao iniciar o programa aparece um menu com 4 opções:

=== GESTOR DE TAREFAS ===
1 - Ver tarefas
2 - Adicionar tarefa
3 - Remover tarefa
4 - Sair

**Ver tarefas** — mostra todas as tarefas guardadas.

**Adicionar tarefa** — pede o nome da tarefa e guarda-a.

**Remover tarefa** — mostra a lista numerada e pede o número da tarefa a remover.

**Sair** — fecha o programa. As tarefas ficam guardadas para a próxima vez.

---

## Para programadores

### Como funciona

O programa guarda as tarefas num ficheiro `tarefas.txt` na pasta do projeto.

- Ao iniciar verifica se o ficheiro existe — se não existir cria-o automaticamente
- Ao adicionar usa `File.AppendAllText()` para escrever no ficheiro
- Ao remover carrega todas as linhas para uma `List<string>`, remove o item e reescreve o ficheiro com `File.WriteAllLines()`

### Estrutura do código

- `Program.cs` — toda a lógica do programa
- `tarefas.txt` — ficheiro gerado automaticamente com as tarefas

### Requisitos

- .NET SDK 9.0 ou superior

### Correr localmente

```bash
git clone https://github.com/martimfm1/gestor-tarefas
cd gestor-tarefas
dotnet run
```

### Compilar para .exe

```bash
dotnet publish -c Release -r win-x64 --self-contained true
```

O ficheiro `.exe` aparece em `bin/Release/net9.0/win-x64/publish/`.