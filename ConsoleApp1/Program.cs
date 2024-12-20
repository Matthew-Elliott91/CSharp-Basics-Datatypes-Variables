// See https://aka.ms/new-console-template for more information

// DATA TYPES

/// You need to define data types in typed languages
/// declare a (string) and assign a value to it

string myFriendsName = "Matthew";
int iAmANumber = 32;
double pi = 3.14;
byte age = 255;
short linkedinConnections = 32550;
long phoneNumber = 07307891642;
float pi2 = 3.14f;

myFriendsName = "John";



//Nullable versions are declared with a ?

int? nullInt = null;
double? nullDouble = null;

//Defining a variable
string petsName;


//initialising variable

petsName = "Daisy";

// String interpolation
/*Console.WriteLine($"My pets name is {petsName}");*/

petsName = "Sparky";

/* Console.WriteLine($"My pets name is {petsName}");*/

/* string strOne = "I am string one";
string strTwo = "I am str Two";
string holdingPlace = "I am holding";

holdingPlace = strOne; // str1 + holding place "I am string one" 
strOne = strTwo;

strTwo = holdingPlace;

Console.WriteLine(strOne);
Console.WriteLine(strTwo); */

// Small Calculator app

// Addition
Console.WriteLine("Enter a number please");

double firstNumber = 0;
double secondNumber = 0;

string userInput = Console.ReadLine();
firstNumber = double.Parse(userInput);

Console.WriteLine("You entered " + firstNumber);
Console.WriteLine("Enter another number please");


string userInput2 = Console.ReadLine();
secondNumber = double.Parse(userInput2);
double addedNumbers = firstNumber + secondNumber;
Console.WriteLine($"{firstNumber} + {secondNumber} = {addedNumbers}" );
// Stops Console closing
Console.ReadKey();