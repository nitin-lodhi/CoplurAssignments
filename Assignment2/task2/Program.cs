// using System;
// 1. Using Abstract (Runtime Polymorphism)
abstract class Logger{
      public abstract void Log();
}

class Database: Logger{
      public override void Log(){
        Console.WriteLine("Log Written to Database.");
      }
}

class File: Logger{
      public override void Log(){
        Console.WriteLine("Log Written to File.");
      }
}

class Cloud: Logger{
      public override void Log(){
        Console.WriteLine("Log Written to Cloud.");
      }
}


class Program{

      
    static void Main(){

        Logger log1 = new Database();
        Logger log2 = new File();
        Logger log3 = new Cloud();

        log1.Log();
        log2.Log();
        log3.Log(); 
    }
}
