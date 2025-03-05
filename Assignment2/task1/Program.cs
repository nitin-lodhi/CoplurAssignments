using System;
// Using interface 
interface ILogger{
      public void Log();
}

class DatabaseLogger: ILogger{
      public void Log(){
        Console.WriteLine("Log Written to Database.");
      }
}

class FileLogger: ILogger{
      public void Log(){
        Console.WriteLine("Log Written to File.");
      }
}

class CloudLogger: ILogger{
      public void Log(){
        Console.WriteLine("Log Written to Cloud.");
      }
}


class Program{

    static ILogger GetLogger(string userLog){
        if(userLog == "Database"){
             return new DatabaseLogger();
        }else if(userLog == "File"){
             return new FileLogger();
        }else if(userLog == "Cloud"){
              return  new CloudLogger();
        }
        return null;
    }

    static void Main(){

        ILogger log;
        
        Console.WriteLine("Enter the Log type(Database,File,Cloud): ");
        string userLog = Console.ReadLine();

        log =  GetLogger(userLog);

        if(log != null){
            log.Log();
        }else{
            Console.WriteLine("Invalid Log");
        }
        
    }
}

