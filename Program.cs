using C__MathGameProject;

var menu = new Menu();        //object of menu class

var date = DateTime.UtcNow;

string name = GetName();

menu.showMenu(name,date);

string GetName()
{
    Console.WriteLine("Please type your name");
    var name = Console.ReadLine();
    return name;
}


