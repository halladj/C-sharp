// Object Type.
object x = "hamza";

x = 10;

x= 'c';

Console.WriteLine(x);

// char, string.
char c = 'c';                   // value-type
string s = "This is a string";  // reference-type
Console.WriteLine(s);

//boolean value-type.
bool correctness = true;
correctness = false;
Console.WriteLine(correctness);

//int,flout

// Interger.
byte b   = 12;
short so = 12;
int i    = 12;
long l   = 12;

Console.WriteLine(l);

// Floating-Point numbers.
float   f  = 12.5f;
double  d  = 12.5; 
decimal de = 12.5m;

Console.WriteLine(f + b);

// Array.
int num1 = 10;
int num2 = 10;
int num3 = 10;
int num4 = 10;
int num5 = 10;

int[] numbers = [12,1,0,1050,100];
Console.WriteLine(numbers[0]);



/*
1. Declare an Object, and assign it to an Array of Strings. That array
   holds 5 names, print the 3rd name.

2. Now assign that Object to a floating point number, add 5 to it. and 
   Print the result.
*/

object nu= 12.5f;

Console.WriteLine((float)nu + 5);


// Date.Time (reference-type):

TimeOnly mydateTime  = TimeOnly.FromDateTime(DateTime.Now);
DateOnly mydateTime2 = DateOnly.FromDateTime(DateTime.Now);
DateTime mydateTime3 = DateTime.UtcNow;
Console.WriteLine(mydateTime3);


// Tuple: value-type

var myTuple = (12, "hamza", 'c', 12.5f);
Console.WriteLine(myTuple.ToString());
Console.WriteLine(myTuple.Item1 + myTuple.Item4);

// >> More Arrays
var numbers2 = numbers.Append(22).Append(55);
Console.WriteLine(numbers2.ToArray()[6]);


// ReadLine
