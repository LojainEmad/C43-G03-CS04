using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Assignment4
{
    internal class Program
    {
        #region the function of :1- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
        //static int[] sortWithMerge(int[] a1, int[] a2)
        //{
        //    int size1 = a1.Length;
        //    int size2 = a2.Length;
        //    int totalsize = size1 + size2;
        //    int[] result = new int[totalsize];
        //    int k = 0;
        //    for (int i = 0; i < a1.Length; i++)
        //    {
        //        result[k++] = a1[i];
        //    }
        //    for (int i = 0; i < a2.Length; i++)
        //    {
        //        result[k++] = a2[i];
        //    }
        //    for (int i = 0; i < totalsize - 1; i++)
        //    {
        //        for (int j = 0; j < totalsize - i - 1; j++)
        //        {
        //            if (result[j] > result[j + 1])
        //            {
        //                int temp = result[j];
        //                result[j] = result[j + 1];
        //                result[j + 1] = temp;
        //            }
        //        }
        //    }

        //    return result;
        //}
        #endregion
        #region the function of : 2- Write a program in C# Sharp to count the frequency of each element of an array.
        //static void CountFrequency(int[] arr)
        //{
        //    for (int i = 0; i < arr.Length - 1; i++)
        //    {
        //        for (int j = 0; j < arr.Length - i - 1; j++)
        //        {
        //            if (arr[j] > arr[j + 1])
        //            {
        //                int temp = arr[j];
        //                arr[j] = arr[j + 1];
        //                arr[j + 1] = temp;
        //            }
        //        }
        //    }
        //    int count = 1;
        //    for (int i = 1; i <= arr.Length; i++)
        //    {
        //        if (i < arr.Length && arr[i] == arr[i - 1])
        //        {
        //            count++;
        //        }
        //        else
        //        {
        //            Console.WriteLine($"element {arr[i - 1]} appears {count} times");
        //            count = 1;
        //        }
        //    }
        //}

        #endregion
        #region the function of 3- Write a program in C# Sharp to find maximum and minimum element in an array
        //static void MaxAndMin(int[] arr)
        //{
        //    if (arr is not null)
        //    {
        //        int min = arr[0], max = arr[0];
        //        for (int i = 1; i < arr.Length; i++)
        //        {
        //            if (arr[i] < min)
        //            {
        //                min = arr[i];
        //            }
        //            if (arr[i] > max)
        //            {
        //                max = arr[i];
        //            }
        //        }
        //        Console.WriteLine($"min num is: {min}");
        //        Console.WriteLine($"max num is: {max}");
        //    }
        //}
        #endregion
        #region the function of 4- Write a program in C# Sharp to find the second largest element in an array.
        static void secondLargest(int[] arr)
        {
            if (arr.Length < 2)
            {
                Console.WriteLine("array must has at least 2 numbers to calculate the second largest");
                return;
            }
            int largestNum = arr[0];
            int secLarg = int.MinValue;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > largestNum)
                {
                    secLarg = largestNum;
                    largestNum = arr[i];
                }
                else if (arr[i] < largestNum && arr[i] > secLarg)
                {
                    secLarg = arr[i];
                }
            }
                Console.WriteLine($"second largest number is: {secLarg}");
        }
        #endregion
        #region the function of  5-. Consider an Array of Integer values with size N
        //static int LongestDist(int[] arr)
        //{
        //    int maxDist= 0;
        //    for (int i = 0; i < arr.Length - 1; i++)
        //    {
        //        for (int j = i + 1; j < arr.Length; j++)
        //        {
        //            if (arr[i] == arr[j])
        //            {
        //                int dist = j - i - 1;
        //                if (dist > maxDist)
        //                {
        //                    maxDist = dist;
        //                }
        //            }
        //        }
        //    }
        //    return maxDist;
        //}
        #endregion
        #region the function of 6- Given a list of space separated words, reverse the order of the words.
        //static string ReverseWords(string input)
        //{
        //    string[] words = input.Split(' ');
        //    string[] rev = new string[words.Length];
        //    int j = 0;
        //    for (int i = words.Length - 1; i >= 0; i--)
        //    {
        //        rev[j] = words[i];
        //        j++;
        //    }
        //    return string.Join(" ", rev);
        //}
        #endregion
        #region the function of 7- 7- Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.
        //public static int[,] CopyArray(int[,] sourceArr)
        //{
        //    int rows = sourceArr.GetLength(0);
        //    int cols = sourceArr.GetLength(1);
        //    int[,] dest = new int[rows, cols];

        //    for (int i = 0; i < rows; i++)
        //    {
        //        for (int j = 0; j < cols; j++)
        //        {
        //            dest[i, j] = sourceArr[i, j];
        //        }
        //    }

        //    return dest;
        //}
        #endregion
        #region the function of 9-Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
        public static void FunctioOfPassByValue_forValueType(int num)
        {
            // This change affects only the copy of num within the method
            num++;
        }

        public static void FunctioOfPassByRef_forValueType(ref int[] arr)
        {
            // This change affects the original array
            arr[0] = 100;
        }
        #endregion
        #region the function of 10-Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
        //public static void ModifyByValue_ForRefType(string str)
        //{
        //    str = "New String"; 
        //}
        //public static void ModifyByReference_ForRefType(ref string str)
        //{
        //    str = "New String";
        //}
        #endregion
        #region the function of 11-Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
        //public static void Calculate(int n1, int n2, out int sum, out int subtract)
        //{
        //    sum = n1 + n2;
        //    subtract = n1 - n2;
        //}
        #endregion
        #region the function of 12-Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number
        //public static int CalcSumOfDigits(int num)
        //{
        //    int sum = 0;

        //    while (num > 0)
        //    {
        //        int digit = num % 10;
        //        sum += digit;
        //        num /= 10; 
        //    }

        //    return sum;
        //}
        #endregion
        #region the function of 13-Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
        //public static bool IsPrime(int num)
        //{
        //    if (num <= 1)
        //    {
        //        return false;
        //    }
        //    for (int i = 2; i <= Math.Sqrt(num); i++)
        //    {
        //        if (num % i == 0)
        //        {
        //            return false; 
        //        }
        //    }
        //    return true; 
        //}

        #endregion
        #region the function of 14-Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
        //public static void MinMaxArray(int[] arr, ref int min, ref int max)
        //{
        //  if (arr.Length is not 0)
        //    {

        //        min = arr[0];
        //        max = arr[0];

        //        for (int i = 1; i < arr.Length; i++)
        //        {
        //            if (arr[i] < min)
        //            {
        //                min = arr[i];
        //            }

        //            if (arr[i] > max)
        //            {
        //                max = arr[i];
        //            }
        //        }
        //    }

        //}

        #endregion
        #region the function of 15-Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
        //public static int CalcFactorial(int number)
        //{

        //    int factorial = 1;

        //    for (int i = 1; i <= number; i++)
        //    {
        //        factorial *= i;
        //    }

        //    return factorial;
        //}
        #endregion
        #region the function of   16-Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
        //public static string ChangeChar(string str, int idx, char newChar)
        //{
        //    if (idx >= 0 && idx < str.Length)
        //    {
        //        char[] charArray = str.ToCharArray();
        //        charArray[idx] = newChar;
        //        return new string(charArray);
        //    }
        //    else
        //    {
        //        return str; 
        //    }
        //}
        #endregion 
        static void Main(string[] args)
        {
            #region 1- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //int[] arr1 = {1,6,3,4,7 };
            //int[] arr2 = {4,5,2,9,8};
            //int[] mergeAndSortAsc= sortWithMerge(arr1, arr2);
            //Console.WriteLine("final arrat result :");
            //foreach (int i in mergeAndSortAsc)
            //{
            //    Console.Write(i + " ");
            //}
            #endregion
            #region 2- Write a program in C# Sharp to count the frequency of each element of an array.
            //int[] arr = { 2, 5, 6, 6, 6, 3, 2, 1 };
            //Console.WriteLine("frequency of each element:");
            //CountFrequency(arr);
            #endregion
            #region 3- Write a program in C# Sharp to find maximum and minimum element in an array
            //int[] arr = { 8, 9, 19, 3, 2, 6, 7 };
            //MaxAndMin(arr);
            #endregion
            #region 4- Write a program in C# Sharp to find the second largest element in an array.
            //int[] arr = {20,6,7,4,18,2};
            //secondLargest(arr);
            #endregion
            #region 5-. Consider an Array of Integer values with size N
            //bool f1;
            //int size;
            //do
            //{
            //    Console.Write("enter the size of array (N): ");
            //    f1 = int.TryParse(Console.ReadLine(), out size);
            //} while (!f1);
            //int[] arr = new int[size];

            //bool f2;

            //Console.WriteLine("enter array numberss:");
            //for (int i = 0; i < size;)
            //{
            //    Console.Write($"Element {i}: ");
            //    f2=int.TryParse(Console.ReadLine(), out arr[i]);
            //    if (f2)
            //        i++;
            //}
            //int longestD = LongestDist(arr);
            //Console.WriteLine($"\n\nlongest distance between equal elements: {longestD}");
            #endregion
            #region 6- Given a list of space separated words, reverse the order of the words.
            //Console.WriteLine("Enter a sentence:");
            //string input = Console.ReadLine();
            //if (input is not null)
            //{
            //    string reverseOutput = ReverseWords(input);
            //    Console.WriteLine($"Reversed sentence: {reverseOutput}");
            //}

            #endregion
            #region 7- Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.

            //bool f;
            //bool ff;
            //int r;
            //do
            //{
            //    Console.WriteLine("Enter the number of rows:");
            //    f = int.TryParse(Console.ReadLine(), out r);
            //} while (!f);

            //int c;
            //do
            //{
            //    Console.WriteLine("Enter the number of Columns:");
            //    ff = int.TryParse(Console.ReadLine(), out c);
            //} while (!ff);


            //int[,]arr1 = new int[r,c];
            //int[,]arr2 = new int[r, c];
            //bool f2;
            //Console.WriteLine("Enter elements for the first array:");
            //for (int i = 0; i < r; i++)
            //{
            //    for (int j = 0; j < c;)
            //    {
            //        Console.Write($"Enter element at [{i},{j}]: ");
            //        f2 = int.TryParse(Console.ReadLine(), out arr1[i, j]);
            //        if (f2)
            //            j++;

            //    }
            //}
            //arr2 = CopyArray(arr1);
            //Console.WriteLine("Second array:");
            //for (int i = 0; i < r; i++)
            //{
            //    for (int j = 0; j < c; j++)
            //    {
            //        Console.Write($"{arr2[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region 8- Write a Program to Print One Dimensional Array in Reverse Order
            //bool f;
            //bool f2;
            //int size;
            //do
            //{
            //    Console.WriteLine("Enter size of array");
            //    f = int.TryParse(Console.ReadLine(), out size);
            //} while (!f);
            //int[] arr = new int[size];

            //Console.WriteLine("enter array numberss:");
            //for (int i = 0; i < size;)
            //{
            //    Console.Write($"Element {i}: ");
            //    f2 = int.TryParse(Console.ReadLine(), out arr[i]);
            //    if (f2)
            //        i++;
            //}
            //Console.WriteLine("Array in reverse order:");
            //for (int i = size - 1; i >= 0; i--)
            //{
            //    Console.Write($"{arr[i]} ");
            //}

            #endregion
            #region 9-Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            //passing(Value type parameters) by value, it pass only a copy and change donot affect the original
            //passing(Value type parameters) by reference, it pass the references themselves not just a copy and the change is affect the original
            //int n = 5;
            //FunctioOfPassByValue_forValueType(n);
            //Console.WriteLine("num after FunctioOfPassByValue_forValueType : " + n); //5

            //int[] arr = { 5, 6, 7 };
            //FunctioOfPassByRef_forValueType(ref arr);
            //Console.WriteLine("arr[0] after FunctioOfPassByRef_forValueType: " + arr[0]); //100 
            #endregion
            #region 10-Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            //passing (Reference type parameters) by value , this has 2 ref and 1 obj if i change the something in the obj and the change will adjust the original. but if we change the object totally inside the function , we will have new object and the change will not affect the original , and we will have 2 ref and 2 obj 
            //passing(Reference type parameters) by reference , this has 1 ref and 1 obj , if the change something in the obj , or change the object totally , the change will affect the original 

            //string origStr = "original";
            //ModifyByValue_ForRefType(origStr);
            //Console.WriteLine("originalString after ModifyByValue: " + origStr); 
            //ModifyByReference_ForRefType(ref origStr);
            //Console.WriteLine("originalString after ModifyByReference: " + origStr); 
            #endregion
            #region 11-Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

            //bool f;
            //int n1;
            //int n2;
            //do
            //{
            //    Console.WriteLine("Enter first num:");
            //    f = int.TryParse(Console.ReadLine(), out n1);

            //} while (!f);
            //do
            //{
            //    Console.WriteLine("Enter sec num:");
            //    f = int.TryParse(Console.ReadLine(), out n2);
            //} while (!f);

            //int sum, subtract;
            //Calculate(n1, n2, out sum, out subtract);

            //Console.WriteLine($"Sum: {sum}");
            //Console.WriteLine($"Difference: {subtract}");
            #endregion
            #region 12-Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number
            //bool f;
            //int n1;
            //do
            //{
            //    Console.WriteLine("Enter the num:");
            //    f = int.TryParse(Console.ReadLine(), out n1);

            //} while (!f);
            //int sumOfDigits = CalcSumOfDigits(n1);

            //Console.WriteLine($"The sum of the digits of the number {n1} is: {sumOfDigits}");
            #endregion
            #region 13 - Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
            //bool f;
            //int n;
            //do
            //{
            //    Console.WriteLine("Enter the num:");
            //    f = int.TryParse(Console.ReadLine(), out n);

            //} while (!f);

            //if (IsPrime(n))
            //{
            //    Console.WriteLine($"{n} is a prime num");
            //}
            //else
            //{
            //    Console.WriteLine($"{n} is not a prime num");
            //}


            #endregion
            #region 14-Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //int[] numbers = {4,7,6,4,3};
            //int min = 0;
            //int max = 0;
            //MinMaxArray(numbers, ref min, ref max);
            //Console.WriteLine($"min val: {min}");
            //Console.WriteLine($"max val: {max}");
            #endregion
            #region 15-Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter

            //int number;
            //bool f = false;
            //do
            //{
            //    Console.Write("Enter a number: ");
            //    string input = Console.ReadLine();

            //    if (int.TryParse(input, out number) && number >= 0)
            //    {
            //        f = true;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input. Please enter a non-negative integer");
            //    }

            //} while (!f);

            //int res = CalcFactorial(number);
            //Console.WriteLine($"Factorial of {number} is: {res}");
            #endregion
            #region   16-Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
            //string strOrginal = "Lojain";
            //int index = 3;
            //char newChar = 'g';
            //string strModify = ChangeChar(strOrginal, index, newChar);

            //Console.WriteLine($"Original string: {strOrginal}");
            //Console.WriteLine($"Modified string: {strModify}");

            //index = 10;
            //strModify = ChangeChar(strOrginal, index, newChar);
            //Console.WriteLine($"original string: {strOrginal}");
            //Console.WriteLine($"modified string: {strModify}");
            //// in this case i handle if the index in out of the range , will return the original string without error 
            #endregion
        }
    }
}
