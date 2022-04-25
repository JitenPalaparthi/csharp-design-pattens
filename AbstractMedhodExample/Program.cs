using System;

namespace AbstractMedhodExample
{

    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();
        IAbstractProductB CreateProductB();
    }

    public interface IAbstractProductA
    {
        string SayHelloProductA();
    }

    public interface IAbstractProductB
    {
        string SayHelloProductB();
    }

    class ConcreteFactory1 : IAbstractFactory
    {

        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA1();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB1();
        }
    }

    class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }

    class ConcreteProductA1 : IAbstractProductA
    {
        public string SayHelloProductA()
        {
            return "Hello from product A1";
        }
    }

    class ConcreteProductA2 : IAbstractProductA
    {
        public string SayHelloProductA()
        {
            return "Hello from product A2";
        }
    }

    class ConcreteProductB1 : IAbstractProductB
    {
        public string SayHelloProductB()
        {
            return "Hello from product B1";
        }
    }

    class ConcreteProductB2 : IAbstractProductB
    {
        public string SayHelloProductB()
        {
            return "Hello from product B2";
        }
    }

    class Client
    {


        public void Main(string productName)
        {
            if(productName=="factory1"){
            Console.WriteLine("First Set of products");
            ClientMethod(new ConcreteFactory1());
            }else if(productName=="factory2"){
            Console.WriteLine("Second Set of products");
            ClientMethod(new ConcreteFactory2());
            }else{
                Console.WriteLine("No products to execute");
            }
        }

        public void ClientMethod(IAbstractFactory factory)
        {

            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();

            Console.WriteLine(productA.SayHelloProductA());
            Console.WriteLine(productB.SayHelloProductB());

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            new Client().Main("factory");
            //Console.WriteLine("Hello World!");
        }
    }
}
