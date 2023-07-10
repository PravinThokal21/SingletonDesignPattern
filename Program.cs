using SingletonDesignPattern;

Console.WriteLine("Singleton Desing Pattern");

Singleton singleton = Singleton.GetInstance();

Console.WriteLine(singleton.Calculate(5, 6));