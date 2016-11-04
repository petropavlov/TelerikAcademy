using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DecimalToBinary
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int number = input;
        int counter = 0;

        //Getting array length
        while (number != 0)
        {
            number = number / 2;
            counter++;
        }

        int[] array = new int[counter];

        //Getting binary representation
        for (int i = 0; i < array.Length; i++)
        {

            if (input % 2 == 1)
            {
                array[i] = 1;
            }
            else
            {
                array[i] = 0;
            }

            if (input == 1 || input == 0)
            {
                array[i] = 1;
                break;
            }

            input = input / 2;
        }

        //Reverse the original array
        Array.Reverse(array);

        //Printing the reversed array
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
        }
    }
}

