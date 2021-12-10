
using FactoryPatternExercise2;

Console.WriteLine("What kind of database would you like to work with?");
Console.WriteLine("Type: SQL or Mongo or List");

var userInput = Console.ReadLine();


var db = DataAccessFactory.GetDataAccessType(userInput);

var products = db.LoadData();

Console.WriteLine("#*#*#*#*#*#*#*#*#*#*");

db.SaveData();


foreach ( var item in products )
{
    Console.WriteLine($"Name: {item.Name}    Price: {item.Price}");

}


