

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


static void FindLostNum(int[] arr)
{
    int i = 0;
    int j = arr.Length - 1;
    int temp = 0;
    bool f = false;

    while (i <= j)
    {
        if (arr[i] > arr[j])
        {
            temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
            //i = 0;
            //j = arr.Length - 1;
        }
        else
        {
            if (f) j--;
            else i++;
        }
        
    }

    foreach (var item in arr)
    {
        Console.WriteLine(item);
    }
        
    
}

FindLostNum(new int[] { 8, 4, 2, 5, 6, 10, 7,712,98,12, 199 });