//Variables
using CSharpIntro;
using System.Collections.Generic;

int x = 3;
string s = "Hello World";
char c = 'a';
bool b = true;
float f = 3.5f;
double d = 3.5;

//I/O
//System.out.println("Bla");
Console.WriteLine("Bla");
Console.WriteLine();
Console.Write("Hihi");
//string input = Console.ReadLine();

//string[] lines = File.ReadAllLines(input);
//string allLines = File.ReadAllText(input);
//File.WriteAllLines(input, lines);

//Collections
int[] intArray = new int[8];
intArray[3] = 4;
List<string> stringList = new List<string>();
//stringList[3] = "He";
Dictionary<string, int> stringInDict = new Dictionary<string, int>();
HashSet<string> stringSet = new HashSet<string>();
Console.WriteLine(Add(3,5));
Multiply(3.5, 5.2);
Multiply(3.5);
//MyCoolNumber nr1 = new MyCoolNumber(3);
//MyCoolNumber nr2 = new MyCoolNumber(5);
//nr1.add(nr2);
//nr1.multiply(nr2);
//MyCoolNumber nr3 = nr1 + nr2;
//nr1* nr2;

//Methods
int Add(int nr1, int nr2)
{
    return nr1 + nr2;
}

double Multiply(double nr1, double nr2 = 1)
{
    return nr1 * nr2;
}
//Classes
Dog dog = new Dog();
dog.Name = "Wuffi";
Console.WriteLine(dog.Name);


//Conventions


//Extenstionmethods
Console.WriteLine(('c'.TakeOften(5)));

//Delegates
void OnDownloadFinished(string s)
{
    Console.WriteLine("This is the named version");
    Console.WriteLine(s);
    Console.WriteLine();
}

Downloader downloader = new();
downloader.RegisterForDownloadFinished((string s) =>
{
    Console.WriteLine("This is the lambda version");
    Console.WriteLine(s);
    Console.WriteLine();
});
downloader.RegisterForDownloadFinished(OnDownloadFinished);

downloader.StartDownload();