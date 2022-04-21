using System;

namespace FactoryMethodExample
{

    public interface IProduct
    {
        string Hello();
    }

    abstract class Creator
    {
        public abstract IProduct FactoryMethod();
        public string SayHello()
        {
            var product = FactoryMethod();
            var result = "Creator:" + product.Hello();
            return result;
        }

    }
//----------------------------------------------------------------------------------------------------
    class ConcreteCreator1 : Creator
    {

        public override IProduct FactoryMethod()
        {
            return new ConcreateProduct1();
        }

    }

    class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreateProduct2();
        }
    }

    class ConcreateProduct1 : IProduct
    {
        public string Hello()
        {
            return "Hello from Concreate Product1";
        }
    }

    class ConcreateProduct2 : IProduct
    {
        public string Hello()
        {
            return "Hello from Concreate Product2";
        }
    }

// ----------------------------------------------------------------------------------------------------
    class Client
    {
        public void Main(int tp)
        {
            if (tp == 1)
            {
                Console.WriteLine("Calling ConcreteCreator1");
                ClientCode(new ConcreteCreator1());
            }
            else
            {
                Console.WriteLine("Calling ConcreteCreator2");

                ClientCode(new ConcreteCreator2());
            }
        }

        public void ClientCode(Creator creator)
        {
            Console.WriteLine("Client" + creator.SayHello());
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i <= 50; i++)
            {
                Random rnd = new Random();
                int num = rnd.Next();
                new Client().Main(num % 2);
            }
        }
    }
}
