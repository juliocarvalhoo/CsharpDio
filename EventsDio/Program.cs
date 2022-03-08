using static System.Console;
var path = @"C:\Users\julio\Desktop\Estudos\C#Dio\EventsDio\Testevents";

using var fsw = new FileSystemWatcher(path);
fsw.Created += OnCreated;
fsw.Renamed += OnRenamed;
fsw.Deleted += OnDeleted;

fsw.EnableRaisingEvents = true;
fsw.IncludeSubdirectories = true;

WriteLine("MONITORANDO EVENTOS:");
WriteLine("Pressione enter para finalizar.......");
ReadLine();

void OnCreated(object sender, FileSystemEventArgs e)
{
    WriteLine($"Foi criado o arquivo {e.Name}");
}

void OnDeleted(object sender, FileSystemEventArgs e)
{
    WriteLine($"Foi deletado o arquivo {e.Name}");
}

void OnRenamed(object sender, RenamedEventArgs e)
{
    WriteLine($"Foi renomeado {e.OldName} para {e.Name}");
}

