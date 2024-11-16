
/*
წყვილები (35 ქულა)
მოცემულია მთელი რიცხვების დალაგებული მასივი, რომლის ყველა ელემენტი
უნიკალურია.
დაწერეთ ფუნქცია ShowPairs(int number, int[] array) რომელსაც გადაეცემა მთელი
რიცხვი და მასივი,
ფუნქციამ უნდა დაბეჭდოს ყველა ისეთი წყვილი ელემენტებისა რომელთა ჯამი
უდრის გადმოცემულ რიცხვს.
მაქსიმალური ქულა - სწორი შედეგი, 1 ციკლი, პარამეტრად მიღებული მასივის
გამოყენება მხოლოდ.
 */


void ShowPairs(int number, int[] array)
{

    int i = 0;
    int j = array.Length - 1;
    int cnt = 0;

    while (i < array.Length)
    {
        if (array[i] + array[j] == number)
            Console.WriteLine($"{array[i]},{array[j]}");

        j--;

        if (j == -1)
        {
            i++;
            j = array.Length - 1;
        }
    }
}

int[] x = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

ShowPairs(5, x);