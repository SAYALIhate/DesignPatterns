namespace SingletonDesignPattern1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Singleton s1 = Singleton.GetInstance();
            //Singleton s2 = Singleton.GetInstance();

            //if (s1 != s2)
            //{
            //    Console.WriteLine("Not sharing the same resources"); 
            //}
            //else
            //{
            //    Console.WriteLine("Sharing the same resources");
            //}

            Singleton s1 = Singleton.GetInstance();
            s1.getDatabaseObject().StringSet("person", "cleverPerson");

            Singleton s2 = Singleton.GetInstance();
           string value =  s2.getDatabaseObject().StringGet("person");
            Console.WriteLine(value);
            Console.ReadLine();
        }
    }
}

