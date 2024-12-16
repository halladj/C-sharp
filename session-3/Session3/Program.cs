

// 20 iteration, start from 4.
// for(var i =4; i<24; i++){
//     Console.WriteLine(i);
// }


// Console.Write("\n");
// // first 10 even number.
// int j =1;
// int evenCounter = 0;
// while(true){

//     if (j>9 && j <15){
//         j++;
//         continue;
//     }

//     if(j % 2 == 0){
//         Console.Write(j+" ");
//         evenCounter+=1;
//     }

//     if(evenCounter == 10){
//         break;
//     }


//     Thread.Sleep(500);
//     j++;
// }
// Console.Write("\n");






// s = s.Trim();
// var a = s.Split(" ");
// Console.WriteLine(a.Length);


// string s = "     this is a string    ";
// int WordCount(string str){
//     str = str.Trim();
//     var a = str.Split(" ");

//    return a;   
// }

// Console.WriteLine(WordCount(s));


// int number = 10;
// int f = 0;


// try{
//     number = number/f;
//     Console.WriteLine(number);
// }
// catch(DivideByZeroException)
// {
//     Console.WriteLine("can not divide by zero");
// }
// catch(Exception exp)
// {
//     Console.WriteLine("Can not do this instruction"+ exp.GetType());
// }







// while(true)
// {
//     try
//     {
//         Console.Write("Please enter a number: ");
//         string n = Console.ReadLine();
//         int number = int.Parse(n);
//         Console.WriteLine("this is your number : "+ number);
//         break;
//     }
//     catch(FormatException)
//     {
//         Console.ForegroundColor = ConsoleColor.Red;
//         Console.WriteLine("You entered a string, please enter a number");
//         Console.ResetColor();
//     }

// }



// short b = 10;
// byte s = (byte)b;


// var x = Convert.ToByte(278.4);
// Console.WriteLine(x);



// sum method-defintion

// int CalculateSum(int a, int b)
// {
//     int result = a+b;
//     return result;
// }

// // method invocation:

// try
// {
//     Console.Write("Please Enter the first number: ");
//     int a = int.Parse(Console.ReadLine());


//     Console.Write("Please Enter the second number: ");
//     int b = int.Parse(Console.ReadLine());

//     var x= CalculateSum(a, b);
//     Console.WriteLine($"{a} + {b} = {x}");
// }
// catch(FormatException)
// {
//     Console.ForegroundColor = ConsoleColor.Red;
//     Console.WriteLine("Please enter a valid number !!");
//     Console.ResetColor();
// }

// using System.Globalization;

// string operation;
// int number1 = 0;
// int number2 = 0;
// try{
//     Console.Write("Inter an operation: +, -, *, /, % : ");
//     operation = Console.ReadLine();

//     if (operation != "+" && operation != "-" && 
//         operation != "/" && operation != "%" && operation != "*"){

//             throw new InvalidOperationException();
//     }
//     Console.Write("Enter the first number: ");
//     number1 = int.Parse(Console.ReadLine());

//     Console.Write("Enter the second number: ");
//     number2 = int.Parse(Console.ReadLine());
// }
// catch(FormatException){
//     Console.WriteLine("Ops, Enter a valid Number");
// }
// catch(InvalidOperationException){
//     Console.WriteLine("Invalid Operation");
// }

// int result;
// if( operation.Equals("+") ){
//     result = number1 + number2;
// }else if(operation.Equals("-")){
//     result = number1 - number2;

// }else if(operation.Equals("*")){
//     result = number1 * number2;

// }else if(operation.Equals("/")){
//     result = number1 / number2;

// }else if(operation.Equals("%")){
//     result = number1 % number2;
// } else{
//     Console.WriteLine("Invalis Operation");
// }




// (string, int, int) GetParams(){
//     try{
//         Console.Write("Enter an operation: +, -, *, /, % : ");
//         operation = Console.ReadLine();
    
//         if (operation != "+" && operation != "-" && 
//             operation != "/" && operation != "%" && operation != "*"){
//         throw new InvalidOperationException();
//     }

//         Console.Write("Enter the first number: ");
//         number1 = int.Parse(Console.ReadLine());

//         Console.Write("Enter the second number: ");
//         number2 = int.Parse(Console.ReadLine());
//     }
//     catch(FormatException)
//     {
//         Console.WriteLine("Ops, Enter a valid Number");
//     }
//     catch(InvalidOperationException)
//     {
//         Console.WriteLine("Invalid Operation");
//     }
//     return (operation, number1, number2 );
// }






// int calculator() {
//     string operation="";
//     int number1 = 0;
//     int number2 =0;

//     (operation, number1, number2) = GetParams();

//     int result = 0;
//     if( operation.Equals("+") ){
//         result = number1 + number2;
//     }else if(operation.Equals("-")){
//         result = number1 - number2;

//     }else if(operation.Equals("*")){
//         result = number1 * number2;

//     }else if(operation.Equals("/")){
//         result = number1 / number2;

//     }else if(operation.Equals("%")){
//         result = number1 % number2;
//     } 
//     return result;
// }

// Console.WriteLine(calculator());
// int vowelCount(string str)
// {
//     str = str.ToLower();  
//     int count = 0;
    
//     for (int i = 0; i < str.Length; i++)  
//     {
//         char c = str[i];  

//         if (char.IsDigit(c)){
//             throw new FormatException();
//         }

//         if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
//         {
//             count++;
//         }
//     }
        
//     return count;
// }
// Console.Write("Please enter something, but not a numbers!! : ");
// string s = Console.ReadLine();

// try
// {
    

//     Console.WriteLine(vowelCount(s));
// }
// catch (FormatException)
// {
//     Console.ForegroundColor = ConsoleColor.DarkRed;
//     Console.WriteLine("Ops, you entered a number, TRY AGAIN!!");
//     Console.ResetColor();
// }


// bool isPalindrom(string str){

//     if (string.IsNullOrWhiteSpace(str)){
//         throw new FormatException();
//     }

//     for (var i = 0; i < str.Length/2; i++){
//         var j = str.Length -i - 1;

//         if (str[i] == str[j]){
//             continue;
//         }else if (! str[i].Equals(str[j]) ){
//             return false;
//         }
//     }
//     return true;
// }


// Console.Write("Enter a string: ");
// var str = Console.ReadLine();

// try{
//     if (isPalindrom(str)){
//         Console.BackgroundColor = ConsoleColor.Green;
//         Console.WriteLine("It is palindrom");
//     } else{
//         Console.BackgroundColor = ConsoleColor.Red;
//         Console.WriteLine("It is NOT a palindrom");
//     }
// }catch(FormatException){
//     Console.BackgroundColor = ConsoleColor.Red;
//     Console.WriteLine("GIVE ME A PROPER STRING");
// }
// Console.ResetColor();


// Console.Write("Give me a number : ");
// int day=0;
// try{
//     day = int.Parse(Console.ReadLine());
// }catch(FormatException){
//     Console.ForegroundColor = ConsoleColor.Red;
//     Console.Write("This is not a number");
// }

// switch (day)
// {
//     case(1):

//         break;
    
//     default:
//         break;
// }

void ChangeName(Person p){
    p.Name = "Houssam";
}
class Person{
    string Name {get; set;}
}



Person p = new Person{
    Name= "hamza"
};
Console.WriteLine(p.Name);
ChangeName(p);
Console.WriteLine(p.Name);

