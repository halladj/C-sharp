// See https://aka.ms/new-console-template for more information

using System.Drawing;

(int sum, int square) sum_and_square(int a){
    var r1 = a + a;
    var r2 = a * a;
    
    return (r1, r2);
}

var (sum, sqaure) = sum_and_square(5);

// Console.WriteLine(sum);
// Console.WriteLine(sqaure);


void Greetings(string name){
    Console.WriteLine("Hello, "+name);
}


// Greetings("roanldo");
// Greetings("Zizou");
// Greetings("Marcelo");







// plain-string:
var name  = " ronaldo and messi";

// Console.WriteLine(name.Length);
// Console.WriteLine(name.ToLower());
// Console.WriteLine(name.ToUpper());
// Console.WriteLine(String.Join(" ", [name, "and zlatan"]));
// Console.WriteLine(name.Contains("haha"));
// var strings_list  = name.Split(" ");
// Console.WriteLine(strings_list[0]);
// Console.WriteLine(strings_list[1]);
// Console.WriteLine(strings_list[2]);
// Console.WriteLine(name.StartsWith(" "));


// string q = "ronaldo";
// string p = "RONALDO";

// Console.WriteLine(p.ToLower() == q.ToLower());
// Console.WriteLine(String.Equals(p,q, 
//     StringComparison.OrdinalIgnoreCase));


// Arithmetic
// int a = 5; int b = 15;

// Console.WriteLine(a+b); // addition.
// Console.WriteLine(a-b); // subtraction.
// Console.WriteLine(a/b); // division.
// Console.WriteLine(a%b); // modular division

// Console.WriteLine(b++); // short-hand notation a = a + 1;
// Console.WriteLine(++b); // short-hand notation a = a + 1;
// Console.WriteLine(b);   // short-hand notation a = a + 1;

// Console.WriteLine(b--); // short-hand notation a = a - 1;
// Console.WriteLine(--b); // short-hand notation a = a - 1;
// Console.WriteLine(b);   // short-hand notation a = a - 1;


// comparition operators
// int a = 5; int b = 15;


// bool isEqual = a == b;
// bool notEqual= a != b;

// bool isGreater= a > b;
// bool isLess   = a < b;

// bool isGreaterOrEqual = a >= b;
// bool isLessOrEqual    = a <= b;



// Logical Operations. 0 -> false, 1 -> true
// bool a = false | false & true;
// bool b = false;
// // logical and -> && , & 
// Console.WriteLine(a & b);

// // logical or -> ||, |
// Console.WriteLine(a | b);

// // logical not -> !
// Console.WriteLine(!!a);





 





// !5 = 5 x 4 x 3 x 2 x 1
// !8 = 8 x 7 x 6 x 5 x 4 x 3 x 2 x 1

