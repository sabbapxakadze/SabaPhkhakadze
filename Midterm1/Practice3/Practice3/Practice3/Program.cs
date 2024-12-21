/*
 იქსიკი და ნოლიკი (tic tac toe) 15 ქულა შექმენით კონსოლური აპლიკაციია, რომელიც
დააინიცირებს სათამაშო მაგიდას (ორ განზომილებიანი მასივი), კონსოლიდან
შეიყვანეთ მაგიდის სიგრძე: მაგ 3x3-ზე, 4x4-ზე ანუ კვადრატულს და უნდა შევქმათ
თამაშის სიმულაცია რომელიც გვათამაშებს, მანამ სანამ ერთ-ერთი არ მოიგებს ან არ
ამოიწურება სვლები, თვალსაჩინოებისათვის ციკლების დახამრებით ლამაზად
ვაჩვენოთ სათამაშო მაგიდა, მოთამაშე შეიყვანს სტრიქონს და სვეტს და თუკი
პირველი მოთამაშეა დაიხატება x, თუ მეორეა დაიბეჭდება O, როდესაც მომხმარებლის
ინფუთს მიიღებთ განაახლეთ სათამაშო მაგიდა, თუკი რომელიმე მოიგებს
გამოიტანეთ შესაბამისი შეტყობინება, ანალოგიურად უნდა მოხდეს ფრის
შემთხვევაშიც. მოგების კრიტერიუმები - შეამოწმეთ სვეტებში თუა ყველა
ერთიდაიგივე ელემენტი ვერტიკალზე, ჰორიზონტალზე, დიაგონალზე
*/

static void TicTacToe()
{
    Console.Write("Enter a matrix size: ");
    int x = int.Parse(Console.ReadLine());
    while (x <= 1)
    {
        Console.Write("Enter a valid number: ");
        x = int.Parse(Console.ReadLine());
    }

    string[,] matrix = new string[x,x];

    int count = 0;
    bool player1turn = true;

    while (count < (x*x) - 1)
    {
        if (player1turn)
        {
            Console.Write("Player1, Where do you put X on x axis?: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Player1, Where do you put X on y axis?: ");
            int y1 = int.Parse(Console.ReadLine());
            while (x1 > x - 1 || y1 > x - 1 || matrix[x1,y1] != null )
            {
                Console.WriteLine("Please enter a valid x,y");
                x1 = int.Parse(Console.ReadLine());
                y1 = int.Parse(Console.ReadLine());
            }

            matrix[x1, y1] = "X";

            player1turn = false;
            DrawMatrix(matrix);

            bool hor = Horizontal(matrix, "X");
            bool ver = Vertical(matrix, "X");
            bool d1 = Diagonal1(matrix, "X");
            bool d2 = Diagonal2(matrix, "X");

            if (hor == true || ver == true || d1 == true || d2 == true)
            {
                Console.WriteLine("Player 1 Won <3");
                break;
            }


            
            count++;
        }

        else
        {
            Console.Write("Player2, Where do you put 0 on x axis?: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Player2, Where do you put 0 on y axis?: ");
            int y1 = int.Parse(Console.ReadLine());
            while (x1 > x - 1 || y1 > x - 1 || matrix[x1, y1] != null)
            {
                Console.WriteLine("Please enter a valid x,y");
                x1 = int.Parse(Console.ReadLine());
                y1 = int.Parse(Console.ReadLine());
            
            }

            matrix[x1, y1] = "0";
            DrawMatrix(matrix);

            player1turn = true;

            bool hor = Horizontal(matrix, "0");
            bool ver = Vertical(matrix, "0");
            bool d1 = Diagonal1(matrix, "0");
            bool d2 = Diagonal2(matrix, "0");

            if (hor == true || ver == true || d1 == true || d2 == true)
            {
                Console.WriteLine("Player 2 Won <3");
                break;
            }

            count++;
        }
    }


}


static void DrawMatrix(string[,] x)
{
    Console.WriteLine("____________________________");
    for(int i = 0; i < x.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < x.GetLength(1); j++)
        {
            string t = x[i, j] == null ? " " : $"{x[i, j]}";
            Console.Write($"|{t}");
            if (j == x.GetLength(1)-1) Console.Write("");
        }
        Console.Write("|");
        Console.WriteLine();
    }
}

static bool VerticalOnIndex(string[,] arr, int i, string comp)
{
    int cnt = 0;
    bool res = true;

    while(cnt < arr.GetLength(0))
    {
        if (arr[cnt, i] == comp)
            cnt++;
        else return false;
    }
    return res;

}

static bool Vertical(string[,] arr, string comp)
{
    for (int i = 0; i <= arr.GetLength(0); i++)
    {
        if (!VerticalOnIndex(arr, i, comp)) return false;
    }
    return true;
}

static bool HorizontalOnIndex(string[,] arr, int i, string comp)
{
    int cnt = 0;
    bool res = true;

    while (cnt < arr.GetLength(0))
    {
        if (arr[i, cnt] == comp)
            cnt++;
        else return false;
    }
    return res;
}
static bool Horizontal(string[,] arr, string comp)
{
    for (int i = 0; i <= arr.GetLength(0); i++)
    {
        if (!HorizontalOnIndex(arr, i, comp)) return false;
    }
    return true;
}

static bool Diagonal1(string[,] arr, string comp)
{
    int cnt = 0;
    
    while (cnt < arr.GetLength(0))
    {
        if (arr[cnt, cnt] != comp) return false;
        cnt++;
    }
    return true;
}

static bool Diagonal2(string[,] arr, string comp)
{
    int cnt = arr.GetLength(0)-1;

    while (cnt >= 0)
    {
        if (arr[cnt, cnt] != comp) return false;
        cnt--;
    }
    return true;
}




TicTacToe();