using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Демонстрация работы класса TextFile ===\n");

        // Создание объектов
        TextFile file1 = new TextFile();
        TextFile file2 = new TextFile("документ", "docx", 150.5, "Windows-1251");

        // Показ информации
        Console.WriteLine("Информация о файле 2:");
        string info;
        file2.ShowInfo(out info);

        // Переименование
        Console.WriteLine("\nПереименовываем файл:");
        file2.Rename("новый_документ");

        // Изменение кодировки
        Console.WriteLine("\nМеняем кодировку:");
        bool success = false;
        file2.ChangeEncoding("UTF-16", ref success);
        Console.WriteLine($"Успешно: {success}");

        // Применение обновлений
        Console.WriteLine("\nПрименяем обновления:");
        file2.ApplyUpdates("Обновление 1", "Обновление 2");

        Console.WriteLine("\nНажмите любую клавишу...");
        Console.ReadKey();
    }
}