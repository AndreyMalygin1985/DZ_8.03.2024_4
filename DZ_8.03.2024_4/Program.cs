// Создать абстрактный базовый класс Worker (работника) с методом Print(). Создайте четыре
// производных класса: President, Security, Manager, Engineer. Переопределите метод
// Print() для вывода информации, соответствующей каждому типу работника.

using static System.Console;

abstract class Worker
{
    public abstract void Print();
}

class President : Worker
{
    public override void Print()
    {
        WriteLine("President: Высший руководитель предприятия");
    }
}

class Security : Worker
{
    public override void Print()
    {
        WriteLine("Security: Охранник, обеспечивающий безопасность предприятия");
    }
}

class Manager : Worker
{
    public override void Print()
    {
        WriteLine("Manager: Менеджер, управляющий отделом или проектом");
    }
}

class Engineer : Worker
{
    public override void Print()
    {
        WriteLine("Engineer: Инженер, специалист по теническим вопросам");
    }
}

class Program
{
    static void Main()
    {
        Worker president = new President();
        Worker security = new Security();
        Worker manager = new Manager();
        Worker engineer = new Engineer();

        president.Print();
        security.Print();
        manager.Print();
        engineer.Print();
    }
}