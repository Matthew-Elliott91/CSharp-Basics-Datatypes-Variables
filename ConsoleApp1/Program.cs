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
char myFavCharacter = 'B';  

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
//Console.WriteLine("Enter a number please");

/*double firstNumber = 0;
double secondNumber = 0;

string userInput = Console.ReadLine();
firstNumber = double.Parse(userInput);

Console.WriteLine("You entered " + firstNumber);
Console.WriteLine("Enter another number please");


string userInput2 = Console.ReadLine();
secondNumber = double.Parse(userInput2);
double addedNumbers = firstNumber + secondNumber;
Console.WriteLine($"{firstNumber} + {secondNumber} = {addedNumbers}" );*/

// Implicit Conversion

int myInt = 32;
double myDouble = myInt;
long myLong = 1234567898312345678;

float myFloat = 123.123f;

myDouble = myFloat;

//myFloat = myDouble;

// explicit converstion you cant cast to a smaller data type without getting errors

/*int myInt2 = (int)myLong;
Console.WriteLine(myInt2);*/

// Convert Class and Method to convert data types

string myBoolString = "true";

bool myBool = Convert.ToBoolean(myBoolString);


// Conversion Helpers Parse and Convert

string NumberString = "123";
int result = int.Parse(NumberString);


// Implicit and Explicit Variables

var myFavTeam = "Liverpook";

var myFavNumber = 11;

int num1 = 10;
int num2 = 20;
int num3 = 30;
int average = (num1 + num2 + num3) / 3;

// String Formating

int num = 10;
double price = 19.95;
string name = "Matthew";

// Interpolation
Console.WriteLine($"The Number is {num}");

// Concatination
Console.WriteLine("The Number is " + num);

// String Formating
Console.WriteLine("The Number is {0}, and the price is {1}, and my name is {2}", num, price, name);


// Special Characters in strings

string str1 = "This is a \"string\" with \na slash \\ and a colon:";

Console.WriteLine(str1);

string str2 = "Hello\n\tWorld!";
Console.WriteLine(str2);
// Stops Console closing
Console.ReadKey();