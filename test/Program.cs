namespace test;
class Program
{
    static void Main(string[] args)
    {
        int[] numArray = new int[50];
        string path = @"C:\Users\edgar\source\repos\LeerFactura\Articulo.txt";

        //using (StreamReader sr = new StreamReader(path))
        //{
        //    string words;
        //    int index = 0;
        //    while (!sr.EndOfStream)
        //    {
        //        words = sr.ReadLine();
        //        int readnum = int.Parse(words);

        //        numArray[index] = readnum;
        //    }
        //}
        numArray[0] = 2;
        numArray[1] = 3;
        numArray[2] = 1;
        numArray[3] = 5;

        int BinarySearch(int[] arr, int x)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] == x)
                {
                    return mid;
                }
                else if (arr[mid] < x)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }

        foreach(int item in numArray)
        {
            Console.WriteLine(item);
        }

    }
}
