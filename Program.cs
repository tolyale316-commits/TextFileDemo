using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Демонстрация работы класса TextFile ===\n");
        
        // Создание объектов через разные конструкторы
        Console.WriteLine("1. Создание объектов:");
        TextFile file1 = new TextFile(); // конструктор по умолчанию
        TextFile file2 = new TextFile("документ", "docx", 150.5, "Windows-1251"); // конструктор с параметрами
        
        // Демонстрация метода ShowInfo с out параметром
        Console.WriteLine("\n2. Информация о файле 2:");
        string detailedInfo;
        file2.ShowInfo(out detailedInfo);
        
        // Демонстрация метода Rename (обычный параметр)
        Console.WriteLine("\n3. Переименовываем файл:");
        file2.Rename("новый_документ");
        
        // Демонстрация метода ChangeEncoding с ref параметром
        Console.WriteLine("\n4. Изменяем кодировку:");
        bool success = false;
        file2.ChangeEncoding("UTF-16", ref success);
        Console.WriteLine($"Операция успешна: {success}");
        
        // Демонстрация метода ApplyUpdates с params параметром
        Console.WriteLine("\n5. Применяем обновления:");
        file2.ApplyUpdates("Обновление метаданных", "Проверка орфографии", "Индексация");
        
        Console.WriteLine("\nПрограмма завершена. Нажмите любую клавишу...");
        Console.ReadKey();
    }
}
