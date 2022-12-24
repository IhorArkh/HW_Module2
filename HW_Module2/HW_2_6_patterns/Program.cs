namespace HW_2_6_patterns
{
    class Car
    {

    }
    class CarBuilder
    {
        private Car car; 
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Singleton
            Singleton singleton1 = Singleton.GetInstance();
            Singleton singleton2 = Singleton.GetInstance();

            
            if (singleton1 == singleton2)
            {
                singleton1.ShowInfo();
            }

            // 
        }
    }
}