# Task Manager

A simple terminal-based task manager built in C#.

---

## How to use

When you start the program, a menu appears with 4 options:

=== TASK MANAGER ===
1 - View tasks
2 - Add task
3 - Remove task
4 - Exit

**View tasks** — displays all saved tasks.

**Add task** — prompts for a task name and saves it.

**Remove task** — shows the numbered list and asks for the task number to remove.

**Exit** — closes the program. Tasks are saved for next time.

---

## For developers

### How it works

Tasks are saved in a `tasks.txt` file in the project folder.

- On startup, checks if the file exists — creates it automatically if not
- When adding, uses `File.AppendAllText()` to write to the file
- When removing, loads all lines into a `List<string>`, removes the item and rewrites the file with `File.WriteAllLines()`

### Project structure

- `Program.cs` — all program logic
- `tasks.txt` — automatically generated file containing the tasks

### Requirements

- .NET SDK 9.0 or higher

### Run locally

```bash
git clone https://github.com/martimfm1/gestor-tarefas
cd gestor-tarefas
dotnet run
```

### Build to .exe

```bash
dotnet publish -c Release -r win-x64 --self-contained true
```

The `.exe` file will be in `bin/Release/net10.0/win-x64/publish/`.