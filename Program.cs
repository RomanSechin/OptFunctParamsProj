internal class Program
{
    private static void Main(string[] args)
    {
        string message = "Значения подходят для среднего человека";
        CheckTemperature(message, 101.3);
        message = "Температура собаки от 100.5 до 102.5 по Фаренгейту";
        CheckTemperature(message, 101.3, 102.5, 100.5);
        message = "Температура Боба всегда ниже обычной, задаем tooLow значение 95.5";
        CheckTemperature(message, 96.2, tooLow: 95.5);
    }
    static void CheckTemperature(string message, double temp, double tooHigh = 99.5, double tooLow = 96.5)
    {
        Console.WriteLine(message);
        if (temp < tooHigh && temp > tooLow)
        {
            Console.WriteLine("{0} degrees F - feeling good!", temp);
        }
        else 
        {
            Console.WriteLine("Uh-oh {0} degrees F -- better see a doctor!", temp);
        }
    }
}

