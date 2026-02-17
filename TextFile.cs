using System;

public class TextFile
{
    // Приватные поля
    private string _name;
    private string _extension;
    private double _sizeInKb;
    private DateTime _lastModified;
    private string _encoding;

    // Конструктор по умолчанию
    public TextFile()
    {
        _name = "Новый файл";
        _extension = "txt";
        _sizeInKb = 0;
        _lastModified = DateTime.Now;
        _encoding = "UTF-8";
    }

    // Конструктор с параметрами
    public TextFile(string name, string extension, double sizeInKb, string encoding)
    {
        _name = name;
        _extension = extension;
        _sizeInKb = sizeInKb;
        _lastModified = DateTime.Now;
        _encoding = encoding;
    }

    // Свойства
    public string Name
    {
        get { return _name; }
        set { if (!string.IsNullOrWhiteSpace(value)) _name = value; }
    }

    public string Extension
    {
        get { return _extension; }
        set { if (!string.IsNullOrWhiteSpace(value)) _extension = value; }
    }

    public double SizeInKb
    {
        get { return _sizeInKb; }
        set { if (value >= 0) _sizeInKb = value; }
    }

    public DateTime LastModified
    {
        get { return _lastModified; }
        private set { _lastModified = value; }
    }

    public string Encoding
    {
        get { return _encoding; }
        set { if (!string.IsNullOrWhiteSpace(value)) _encoding = value; }
    }

    public string FullName
    {
        get { return $"{_name}.{_extension}"; }
    }

    // Методы
    public void Rename(string newName)
    {
        if (!string.IsNullOrWhiteSpace(newName))
        {
            _name = newName;
            _lastModified = DateTime.Now;
            Console.WriteLine($"Файл переименован в: {FullName}");
        }
    }

    public void ChangeEncoding(string newEncoding, ref bool success)
    {
        if (!string.IsNullOrWhiteSpace(newEncoding))
        {
            _encoding = newEncoding;
            _lastModified = DateTime.Now;
            success = true;
            Console.WriteLine($"Кодировка изменена на: {_encoding}");
        }
        else
        {
            success = false;
        }
    }

    public void ShowInfo(out string detailedInfo)
    {
        string info = $"Имя: {FullName}\nРазмер: {_sizeInKb} Кб\nДата: {_lastModified}\nКодировка: {_encoding}";
        Console.WriteLine(info);

        detailedInfo = $"Детально: {_name}, {_extension}, {_sizeInKb} Кб, {_encoding}";
    }

    public void ApplyUpdates(params string[] updates)
    {
        if (updates != null && updates.Length > 0)
        {
            Console.WriteLine($"Применяем {updates.Length} обновлений");
            _lastModified = DateTime.Now;
        }
    }
}