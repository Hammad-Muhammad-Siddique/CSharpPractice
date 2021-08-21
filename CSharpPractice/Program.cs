using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //---Activity1---//==============================================================================

            //int Mark1 = 40;
            //int Mark2 = 90;

            //Console.ReadKey()

            //---Activity2---//==============================================================================

            //double radius;
            //double height;
            //double volume;

            //Console.Write("Enter the radius of the cylinder: ");
            //radius = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the height of the cylinder: ");
            //height = Convert.ToInt32(Console.ReadLine());

            //volume = radius * height * Math.PI;
            //Math.Truncate(volume);

            //Console.WriteLine("The volume of the cylinder is: " + volume);

            //Console.ReadKey();

            //---Activity3---//==============================================================================

            //int mark;

            //Console.Write("Enter your marks: ");
            //mark = Convert.ToInt32(Console.ReadLine());

            //if (mark < 40)
            //{
            //    Console.WriteLine("Fail");
            //} else
            //{
            //    Console.WriteLine("Pass");
            //}

            //Console.ReadKey();

            //---Activity4---//==============================================================================

            //Console.Write("Enter your marks: ");
            //int marks = Convert.ToInt32(Console.ReadLine());

            //if (marks > 100 || marks < 0)
            //{
            //    Console.WriteLine("Enter valid marks between 0 and 100");
            //}  
            //else if (marks >= 0 && marks <= 59)
            //{
            //    Console.WriteLine("Your grade is U");
            //}
            //else if (marks >= 60 && marks <= 69)
            //{
            //    Console.WriteLine("Your grade is E");
            //}
            //else if (marks >= 70 && marks <= 74)
            //{
            //    Console.WriteLine("Your grade is D");
            //}
            //else if (marks >= 75 && marks <= 79)
            //{
            //    Console.WriteLine("Your grade is C");
            //}
            //else if (marks >= 80 && marks <= 84)
            //{
            //    Console.WriteLine("Your grade is B");
            //}
            //else if (marks >= 85 && marks <= 89)
            //{
            //    Console.WriteLine("Your grade is A");
            //}
            //else
            //{
            //    Console.WriteLine("Your grade is A*");
            //}

            //Console.ReadKey();

            //---Activity5---//==============================================================================

            //Console.Write("Enter the temperature: ");
            //int temp = Convert.ToInt32(Console.ReadLine());

            //if (temp > 40)
            //{
            //    Console.WriteLine("High");
            //}
            //else
            //{
            //    Console.WriteLine("Low");
            //}

            //Console.ReadKey();

            //---Activity6---//==============================================================================

            //Console.Write("Whih animal do you want to hear the voice of: ");
            //string animal = Console.ReadLine();

            //animal.ToLower();

            //if (animal == "pig")
            //{
            //    Console.WriteLine("The voice of " + animal + " is Oink");
            //}
            //else if (animal == "cow")
            //{
            //    Console.WriteLine("The voice of cow is moo");
            //}
            //else if (animal == "bear")
            //{
            //    Console.WriteLine("The voice of bear is grr");
            //}
            //else if (animal == "sheep")
            //{
            //    Console.WriteLine("The voice of sheep is baa");
            //}
            //else if (animal == "tiger")
            //{
            //    Console.WriteLine("The voice of tiger is grr");
            //}
            //else
            //{
            //    Console.WriteLine("The voice of " + animal + " is meow");
            //}

            //Console.ReadKey();

            //---Activity7---//==============================================================================

            //int i;
            //int square;

            //Console.Write("Enter the number of integers you want the square of: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //for (i = 1; i <= n; i++)
            //{
            //    square = i * i;
            //    Console.WriteLine(square);
            //}

            //Console.ReadKey();

            //---Activity8---//==============================================================================

            //string employeeName;
            //double numberOfHoursWorked;
            //double payRate;
            //double totalPay;
            //int i;

            //for (i = 1; i <= 50; i++)
            //{
            //    Console.Write("Enter employee name: ");
            //    employeeName = Console.ReadLine();
            //    if (employeeName != "END")
            //    {
            //        Console.Write("Enter number of hours worked: ");
            //        numberOfHoursWorked = Convert.ToDouble(Console.ReadLine());
            //        Console.Write("Enter the pay rate: ");
            //        payRate = Convert.ToDouble(Console.ReadLine());

            //        totalPay = payRate * numberOfHoursWorked;

            //        Console.WriteLine("The name of the employee is " + employeeName);
            //        Console.WriteLine("The total pay of the employee is " + totalPay);

            //        Console.ReadKey();
            //    }

            //}

            //---Activity9---//==============================================================================

            //string name;
            //int count = 1;

            //do
            //{
            //    Console.Write("Enter student " + count + " name: " );
            //    name = Console.ReadLine();
            //    Console.WriteLine("The name of student " + count + " is " + name);
            //    count++;
            //}
            //while (name != "End");

            //Console.ReadKey();

            //---Activity10---//=============================================================================

            //string itemName;
            //int itemNumber;

            //Console.Write("Enter the number of items: ");
            //itemNumber = Convert.ToInt32(Console.ReadLine());

            //while (itemNumber != 100)
            //{
            //    Console.Write("Enter item name: ");
            //    itemName = Console.ReadLine();
            //    Console.WriteLine(itemName);
            //}

            //Console.ReadKey();

            //---Activity10---//=============================================================================

            //int i;
            //int j;
            //int n;

            //Console.Write("Enter length of the matrix: ");
            //n = Convert.ToInt32(Console.ReadLine());

            //for (i = 1; i < n; i++)
            //{
            //    Console.Write("1 0 0 0");
            //    Console.WriteLine();
            //    for (j = 1; j < n; j++)
            //    {
            //        Console.WriteLine("1 0 0 0");
            //    }
            //}

            //Console.ReadKey();

            //---Activity11---//=============================================================================

            //string name = "Fawad Khan";

            //Console.WriteLine(name[6]);

            //Console.ReadKey();

            //---Activity12---//=============================================================================

            //char[] letters = { 'I', '_', 'a', 'm', '_', 'L', 'e', 'g', 'e', 'n', 'd' };
            //Console.WriteLine(letters);
            //Console.ReadKey();

            //---Activity13---//=============================================================================

            //string message = "Hello World";
            //Console.WriteLine(message.Length);
            //Console.ReadKey();

            //---Activity14---//=============================================================================

            //string sentence = "I am Legend";
            //Console.WriteLine(sentence.IndexOf('e'));
            //Console.ReadKey();

            //---Activity15---//=============================================================================

            //string word = "Just do it";
            //Console.Write("Enter the word: ");
            //string message = Console.ReadLine();

            //if (message.Contains(word))
            //{
            //    Console.WriteLine("The index number of from where it starts is " + message.IndexOf(word));
            //}
            //else
            //{
            //    Console.WriteLine("The word hasn't been found");
            //}

            //Console.ReadKey();

            //---Activity16---//=============================================================================

            //string name = "Mr Fawad Khan";
            //Console.WriteLine(name.Substring(9, 4));
            //Console.ReadKey();

            //---Activity17---//=============================================================================

            //string firstWord;
            //string secondWord;

            //Console.Write("Enter the first word: ");
            //firstWord = Console.ReadLine();
            //Console.Write("Enter the second word: ");
            //secondWord = Console.ReadLine();

            //Console.WriteLine(firstWord + " " + secondWord);

            //Console.ReadKey();

            //---Activity18---//=============================================================================

            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("You have input the integer: " + number);
            //Console.ReadKey();

            //---Activity19---//=============================================================================

            //string name = "Mr Fawad Khan";
            //Console.WriteLine(name.Substring(3, 5));
            //Console.ReadKey();

            //---Activity20---//=============================================================================

            //string name = "Mr Fawad Khan";
            //Console.WriteLine(name.Substring(0, 8));
            //Console.ReadKey();

            //---Activity21---//=============================================================================

            //string[] Electronics = new string[4];
            //Console.ReadKey();

            //---Activity22---//=============================================================================

            //string[] Electronics = { "Computer", "TV", "Watch" };
            //Console.ReadKey();

            //---Activity23---//=============================================================================

            //string[] Electronics = { "Computer", "TV", "Watch" };
            //Console.WriteLine(Electronics[1]);
            //Console.ReadKey();

            //---Activity24---//=============================================================================

            //string[] Electronics = { "Computer", "TV", "Watch" };
            //int i;

            //for (i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(Electronics[i]);
            //}

            //Console.ReadKey();

            //---Activity25---//=============================================================================

            //int[] numbers = new int[5];
            //int i;
            //double average;
            //int total;

            //for (i = 0; i < 5; i++)
            //{
            //    Console.Write("Enter a number: ");
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //total = numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4];
            //average = total / 5;
            //Console.WriteLine("The average of the five numbers is: " + average);

            //Console.ReadKey();

            //---Activity26---//=============================================================================

            //int[] Digits = new int[5];
            //Digits[0] = 1;

            //Console.ReadKey();

            //---Activity27---//=============================================================================

            //string[] Furniture = { "chair", "table", "bed"};
            //Console.ReadKey();

            //---Activity28---//=============================================================================

            //string[] Furniture = {"chair", "table", "bed"};
            //string item;
            //int i;
            //bool state;

            //state = false;

            //Console.Write("Enter the name of a furniture item: ");
            //item = Console.ReadLine();

            //for (i = 0; i < 3; i++)
            //{
            //    if (Furniture[i] == item)
            //    {
            //        Console.WriteLine("The index number of the furniture item is " + i);
            //        state = true;
            //    }
            //}

            //if (state == false)
            //{
            //    Console.WriteLine("Item not found");
            //}

            //Console.ReadKey();

            //---Activity29---//=============================================================================

            //int[] marks = new int[10];
            //int i;

            //for (i = 0; i < 10; i++)
            //{
            //    Console.Write("Enter marks: ");
            //    marks[i] = Convert.ToInt32(Console.ReadLine());

            //}

            //Console.ReadKey();

            //---Activity30---//=============================================================================

            // int[,] arrayTest2D =
            //{
            //     { 1, 2 },
            //     { 3, 4 }
            // };
            // Console.WriteLine(arrayTest2D[0, 0]);
            // Console.WriteLine(arrayTest2D[0, 1]);
            // Console.WriteLine(arrayTest2D[1, 0]);
            // Console.WriteLine(arrayTest2D[1, 1]);

            // Console.ReadKey();

            //---Activity31---//=============================================================================

            //string[,] array2D = new string[2, 3];
            //Console.ReadKey();

            //---Activity32---//=============================================================================

            //int[,] arrayTest2D =
            //{
            //    {10,10},
            //    {20,20},
            //    {30,30}
            //};
            //Console.ReadKey();

            //---Activity33---//=============================================================================

            //int[,] myArray = new int[3, 4];

            //myArray[0, 0] = 0;
            //myArray[0, 1] = 1;
            //myArray[0, 2] = 2;
            //myArray[0, 3] = 3;
            //myArray[1, 0] = 4;
            //myArray[1, 1] = 5;
            //myArray[1, 2] = 6;
            //myArray[1, 3] = 7;
            //myArray[2, 0] = 8;
            //myArray[2, 1] = 9;
            //myArray[2, 2] = 10;
            //myArray[2, 3] = 11;

            //Console.ReadKey();

            //---Activity34---//=============================================================================

            //int[,] myArray =
            //{
            //    {1,2},
            //    {3,4}
            //};

            //Console.WriteLine(myArray[0, 1]);

            //Console.ReadKey();

            //---Activity35---//=============================================================================

            //DEBUGGING IN PROGRESS//

            // int[,] myArray =
            // {
            //     {1,5},
            //     {2,10},
            //     {3,15}
            // };

            // int r = 0;
            // int c = 0;

            //for (int j = 0; j < 3; j++)
            // {
            //     for (int i = 0; i < 3; i++)
            //     {
            //         if (myArray[r, c] == 10)
            //         {
            //             Console.WriteLine("Found at " + myArray[r,c]);
            //         }
            //         else
            //         {
            //             Console.WriteLine("Not Found");
            //         }
            //         r++;
            //     }
            //     c++;
            // }


            //Console.ReadKey();

            //---Activity36---//=============================================================================

            //DEBUGGING IN PROGRESS//

            //int[,] multiplicationArray =
            //{
            //    {0,0},
            //    {1,1},
            //    {2,2},
            //    {3,3},
            //    {4,4},
            //    {5,5},
            //    {6,6},
            //    {7,7},
            //    {8,8},
            //    {9,9},
            //    {10,10}
            //};

            //Console.WriteLine(multiplicationArray[0, 0] * multiplicationArray[0, 1]);
            //Console.WriteLine(multiplicationArray[0, 0] * multiplicationArray[0, 2]);
            //Console.WriteLine(multiplicationArray[0, 0] * multiplicationArray[0, 3]);
            //Console.WriteLine(multiplicationArray[0, 0] * multiplicationArray[0, 4]);
            //Console.WriteLine(multiplicationArray[0, 0] * multiplicationArray[0, 5]);
            //Console.WriteLine(multiplicationArray[0, 0] * multiplicationArray[0, 6]);
            //Console.WriteLine(multiplicationArray[0, 0] * multiplicationArray[0, 7]);
            //Console.WriteLine(multiplicationArray[0, 0] * multiplicationArray[0, 8]);
            //Console.WriteLine(multiplicationArray[0, 0] * multiplicationArray[0, 9]);
            //Console.WriteLine(multiplicationArray[0, 0] * multiplicationArray[0, 10]);

            //Console.ReadKey();

            //---Activity37---//=============================================================================

            //try
            //{
            //    Console.WriteLine("Hello and welcome to this program! It will ask you to input two numbers and then on the basics of the menu we will ask you for operations");

            //    int number1;
            //    int number2;
            //    string opletter;

            //    Console.WriteLine();

            //    Console.Write("Enter first number: ");
            //    number1 = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Enter second number: ");
            //    number2 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine();

            //    Console.Write("To 'Add' the two numbers, enter 'a'" +
            //        "To 'Subtract' the two numbers, enter 's' " +
            //        "To 'Multiply the two numbers, enter 'm'" +
            //        "To 'Divide the two numbers, enter 'd'");
            //    Console.WriteLine();
            //    opletter = Console.ReadLine();

            //    opletter.ToLower();

            //    if (opletter == "a")
            //    {
            //        Console.WriteLine("The sum of the two numbers is " + (number1 + number2));
            //    }
            //    else if (opletter == "s")
            //    {
            //        Console.WriteLine("The difference between the two numbers is " + (number1 - number2));
            //    }
            //    else if (opletter == "m")
            //    {
            //        Console.WriteLine("The product of the two numbers is " + (number1 * number2));
            //    }
            //    else if (opletter == "d")
            //    {
            //        Console.WriteLine("The ratio of the numbers is " + (number1 / number2));
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invaid letter");
            //    }
            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //Console.ReadKey();

            //---Activity38---//=============================================================================

            //House houseOne = new House();
            //houseOne.gateColour = "Blue";
            //houseOne.size = "2 Kanal";
            //houseOne.storeys = 2;
            //houseOne.rooms = 13;
            //houseOne.washrooms = 4;
            //houseOne.price = "$100,000";
            //houseOne.IsBasement = false;

            //House houseTwo = new House();
            //houseTwo.number = 410;
            //houseTwo.street = 17;
            //houseTwo.sector = "J-6";
            //houseTwo.area = "Hayatabad";
            //houseTwo.city = "Peshawar";
            //houseTwo.country = "Pakistan";

            //Console.ReadKey();

            //---Activity39---//=============================================================================

            //Students RMS = new Students("Hammad", "Huzaifa", "Asad");
            //Console.WriteLine(RMS.studentOne);

            //Console.ReadKey();

            //---Activity40---//=============================================================================

            Chef Chef = new Chef();
            Chef.MakesSpecialDish();

            ItalianChef ItalianChef = new ItalianChef();
            ItalianChef.MakesSpecialDish();

            Console.ReadKey();

        }
    }
}