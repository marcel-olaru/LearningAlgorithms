using System;



namespace _1D_Peak_Finding
{
    class Program
    {

        static void Main()

        {
            int[] array = { 1, 2, 6, 5, 3, 7, 4, 9, 12, 8 };

            foreach (int i in array)
            {
                Console.Write($"{i}, ");
            }


            // This is my take on the implementation of the peak finding algorithm
            // FindPeaks(array) is the implementation of a direct search that scans the whole array from the second position to the end.

            FindPeaks(array);
            FindPeaksAlgo(array, array.Length - 1);

            Console.ReadKey();



        }


        public static void FindPeaks(int[] array)
        {
            int counter = 1;


            while (counter != array.Length-1)
            {


                if (array[counter] >= array[counter - 1] && array[counter] >= array[counter + 1])
                {
                    Console.WriteLine($" \n {array[counter]} is a local peak ");
                    break;
                    

                }
                else counter++;
                

            }
        }

        public static int FindPeaksAlgo(int[] array, int n)
        {
           var low = 0;
           var high = n;

            while (true)
            {
                n = (high + low) / 2;

                if (array[n] >= array[n - 1] && array[n] >= array[n + 1])
                {
                    Console.WriteLine($" \n {array[n]} is a local peak ");
                    return n;

                }
                else if (array[n] <= array[n - 1])
                {

                    high = n - 1;

                }

                else if (array[n] <= array[n + 1])
                {
                    low = n + 1;

                }

            }


        }


    }
}


   

     
    

