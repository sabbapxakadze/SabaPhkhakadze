

/*
 გაუჩინარებული ელემენტი (35 ქულა)
მოცემულია მთელი რიცხვების N ელემენტიანი მასივი. მისი მაქსიმალური ელემენტია
N+1, რაც იმას ნიშნავს, რომ რომელიღაც ელემენტი გაუჩინარდა. დაწერეთ ფუნქცია, 
რომელიც იპოვნის გაუჩინარებულ ელემენტს.
მაქსიმალური ქულა - სწორი შედეგი, 1 ციკლი, პარამეტრად მიღებული მასივის
გამოყენება მხოლოდ
 */

//  [ 4,6,2,1,5 ]  --> 3
//4 6 2 1 5
//1 6 2 4 5
//1 2 6 4 5


static int[] MergeSort(int[] x)
{
    if (x.Length == 1) return x;

    int half = x.Length / 2;
    int[] arr1 = new int[half];
    int[] arr2;

    if (x.Length % 2 == 0) 
        arr2 = new int[half];
    else 
        arr2 = new int[half+1];

    for (int i = 0; i < half-1; i++)
    {
        arr1[i] = x[i];
    }
    for (int i = half+1, cnt = 0; i < x.Length; i++, cnt++)
    {
        arr2[cnt] = x[i];
    }

    arr1 = MergeSort(arr1);
    arr2 = MergeSort(arr2);

    return Merge(arr1, arr2);
}

static int[] Merge(int[] x, int[] y)
{
    int i = 0;
    int j = 0;

    int[] res = new int[x.Length + y.Length];

    while (i < x.Length && j < y.Length)
    {
        if (x[i] < y[j])
        {
            res[i + j] = x[i++];
        }
        else if (x[i] > y[j])
        {
            res[i + j] = y[j++];
        }
        else
        {
            res[i+j] = x[i++];
            res[i+j] = y[j++];
        }
    }
    while (i < x.Length)
    {
        res[i + j] = x[i++];
    }
    while (j < y.Length)
    {
        res[i + j] = y[j++];
    }
    return res;
}

static void FindLostNum(int[] arr)
{

    int[] x = MergeSort(arr);

    int res = 0;

    int f = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] - f != 1)
        {
            Console.WriteLine($"The lost number is {arr[i]-1}");
            return;
        }
        else
        {
            f = arr[i];
        }
    }   
}

FindLostNum(new int[] { 1,2,3,5 });