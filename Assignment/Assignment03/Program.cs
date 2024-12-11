#region Q1
//1 - Write a program that takes a number from the user then print yes
//    if that number can be divided by 3 and 4 otherwise print no.

//int number =Convert.ToInt32(Console.ReadLine());
//if (number %3==0 && number % 4 == 0)
//    Console.WriteLine("yes");
//else
//    Console.WriteLine("no"); 
#endregion

#region Q2
//2 - Write a program that allows the user to insert an integer then print negative if
//    it is negative number otherwise print positive.


//int number = Convert.ToInt32(Console.ReadLine());
//if (number < 0)
//    Console.WriteLine("Negative");
//else
//    Console.WriteLine("Positive");
#endregion

#region Q3
//3- Write a program that takes 3 integers from the
//user then prints the max element and the min element

//int number1 = Convert.ToInt32(Console.ReadLine());
//int number2 = Convert.ToInt32(Console.ReadLine());
//int number3 = Convert.ToInt32(Console.ReadLine());
//int max =0 , min =0 ;

//if (number1 > number2 && number1 > number2)
//    max = number1;
//else if (number2 > number1 && number2 > number3)
//    max = number2;
//else if (number3 > number2 && number3 > number2)
//    max = number3;

//if (number1 < number2 && number1 < number2)
//    min = number1;
//else if (number2 < number1 && number2 < number3)
//    min = number2;
//else if (number3 < number2 && number3 < number2)
//    min = number3;

//Console.WriteLine($"Max number is : {max}");
//Console.WriteLine($"Min number is : {max}"); 
#endregion

#region Q4

//4 - Write a program that allows the user to insert an integer 
//    number then check If a number is even or odd.


//Console.WriteLine("PLZ enter any number to check");
//int number = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine((number % 2 == 0) ? "Even" : "Odd"); 
#endregion

#region Q5
//Write a program that takes character from the user then if it is a vowel chars 
//(a, e, I, o, u) then print (vowel) otherwise print (consonant).

//Console.WriteLine("Enter Char To Check");
//char c = Convert.ToChar(Console.ReadLine());
//c = char.ToLower(c);
//if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
//    Console.WriteLine("vowel");
//else 
//    Console.WriteLine("consonant"); 
#endregion

#region Q6
//Write a program that allows the user to insert an integer then
//print all numbers between 1 to that number

//Console.WriteLine("PLZ enter any number");
//int number = Convert.ToInt32(Console.ReadLine());
//for (int i = 1; i <= number; i++)
//{
//    Console.Write((i != number)? $"{i}, " : $"{i}"); 
//} 
#endregion

#region Q7
//Write a program that allows the user to insert an integer then 
//print a multiplication table up to 12.



//Console.WriteLine("PLZ enter any number");
//int number = Convert.ToInt32(Console.ReadLine());
//for (int i = 1; i <= 12; i++)
//{
//    Console.Write(number*i);
//    Console.Write(" ");
//} 
#endregion

#region Q8
//Write a program that allows to user to insert number then print 
//all even numbers between 1 to this number

//Console.WriteLine("PLZ enter any number");
//int number = Convert.ToInt32(Console.ReadLine());
//for (int i = 1; i <= number; i++)
//{
//    if (i % 2 == 0)
//    {
//        Console.Write(i);
//        Console.Write(" ");
//    }
//    else
//        continue;
//} 
#endregion

#region Q9
//Write a program that takes two integers then prints the power.

//Console.WriteLine("PLZ enter 2 numbers: ");
//int number1 = Convert.ToInt32(Console.ReadLine());
//int number2=Convert.ToInt32(Console.ReadLine());
//int multi = 1;
//for (int i = number2; i >= 1; i--)
//{
//    multi *= number1;
//}
//Console.WriteLine(multi); 
#endregion

#region Q10
//Write a program to enter marks of five subjects
//and calculate total, average and percentage

//int mark1, mark2, mark3, mark4, mark5;
//Console.WriteLine("Enter Marks of five subjects:");

//mark1 = Convert.ToInt32(Console.ReadLine());
//mark2 = Convert.ToInt32(Console.ReadLine());
//mark3 = Convert.ToInt32(Console.ReadLine());
//mark4 = Convert.ToInt32(Console.ReadLine());
//mark5 = Convert.ToInt32(Console.ReadLine());
//int sum = mark1 + mark2 + mark3 + mark4 + mark5;
//int avg = sum / 5, percentage = (sum / 500) * 100;
//Console.WriteLine($"Average Marks = {avg}");
//Console.WriteLine($"Percentage = {percentage}");
   
#endregion

#region Q11
//Console.Write("Enter the month number: ");
//int month = Convert.ToInt32(Console.ReadLine());
//int days=0;
//switch (month)
//{
//    case 1:  case 3:  case 5:  case 7:  case 8:  case 10: case 12:
//        days = 31; break;
//    case 4:  case 6: case 9: case 11:
//        days = 30; break;
//    case 2: 
//        days = 29; break;
//    default:
//        Console.WriteLine("Invalid month number.");
//        return;
//}

//Console.WriteLine($"The number of days in month {month} is: {days}");

#endregion

#region Q12
//12 - Write a program to create a Simple Calculator.

//double num1, num2, res;
//int operation;

//Console.WriteLine("===================Simple Calculator==================");
//Console.WriteLine("Please Select an operation:");
//Console.WriteLine("1. Add");
//Console.WriteLine("2. Subtract");
//Console.WriteLine("3. Multiply");
//Console.WriteLine("4. Divide");

//Console.Write("Chose The Operation based on The Numbers above: ");
//operation = Convert.ToInt32(Console.ReadLine());

//Console.Write("Enter the first number: ");
//num1 = Convert.ToDouble(Console.ReadLine());

//Console.Write("Enter the second number: ");
//num2 = Convert.ToDouble(Console.ReadLine());

//switch (operation)
//{
//    case 1:
//        res = num1 + num2;
//        Console.WriteLine($"The result of addition is: {res}");
//        break;
//    case 2:
//        res = num1 - num2;
//        Console.WriteLine($"The result of subtraction is: {res}");
//        break;
//    case 3:
//        res = num1 * num2;
//        Console.WriteLine($"The result of multiplication is: {res}");
//        break;
//    case 4:
//        if (num2 == 0)
//        {
//            Console.WriteLine("Cannot divide by zero.");
//        }
//        else
//        {
//            res = num1 / num2;
//            Console.WriteLine($"The result of division is: {res}");
//        }
//        break;
//    default:
//        Console.WriteLine("Invalid operation selection.");
//        break;
//} 
#endregion


