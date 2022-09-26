//import statements
using CSharpIntro;
using System.Collections.Generic;

//Variables
int x = 3;
string s = "Hello World";
char c = 'a';
bool b = true;
float f = 3.5f;
double d = 3.5;

//I/O

//Console
Console.WriteLine("Bla");
Console.WriteLine();
Console.Write("Hihi");
string input = Console.ReadLine();

//File
string[] lines = File.ReadAllLines(input);
string allLines = File.ReadAllText(input);
File.WriteAllLines(input, lines);

//Collections
int[] intArray = new int[8];
intArray[3] = 4;

List<string> stringList = new List<string>();
stringList[3] = "He";

//Same as Map
Dictionary<string, int> stringInDict = new Dictionary<string, int>();

HashSet<string> stringSet = new HashSet<string>();

//Methods
int Add(int nr1, int nr2)
{
    return nr1 + nr2;
}

//nr2 has a default value of one. Means the parameter is optional
double Multiply(double nr1, double nr2 = 1)
{
    return nr1 * nr2;
}


Console.WriteLine(Add(3, 5));
Multiply(3.5, 5.2);
Multiply(3.5);

//Classes
//See Pets.cs for class definition
Dog dog = new Dog();
//Using property as a setter
dog.Name = "Wuffi";
//Using property as a getter
Console.WriteLine(dog.Name);


//Conventions
//variablesAreWrittenLikeThis
//ButPropertiesArePascalCase
//MethodsAreNamedLikeThis
//AndClassesToo

//Extenstionmethods
//See ExtensionMethods.cs for definition.
//They allow us to extend the functionality of classes that already exist
Console.WriteLine(('c'.TakeOften(5)));

//Delegates
//See Downloader.cs for definition.
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