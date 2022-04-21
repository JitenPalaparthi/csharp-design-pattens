using System;

namespace SingletonExample
{ 
    public sealed class Singleton{
    private Singleton(){
        Console.WriteLine("Calling the private constructer");
    }

public string constr {get;set;}
      private static Singleton _instance;
      public static Singleton GetInstance(string cstr){

          if(_instance==null){
              _instance = new Singleton();
              _instance.ccstronstr= cstr;
          }

          return _instance;
      }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance("dbconnection");
            Console.WriteLine(s1.constr);
            Singleton s2 = Singleton.GetInstance("sqlconnection");
            Console.WriteLine(s2.constr);
            Singleton s3 = Singleton.GetInstance("mysqlconnection");
            Console.WriteLine(s3.constr);

            if(s1==s2){
                Console.WriteLine("Both the instances are same, hence they are Singleton");
            }else{
                Console.WriteLine("Not a single ton instance");

            }
        }
    }
}

// Thread safe single ton pattern