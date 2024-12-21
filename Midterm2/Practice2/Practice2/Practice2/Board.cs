public class Board
{
    public string[,] boardString = new string[8, 8];

    public Figure[,] mainBoard = new Figure[8, 8];
    public int whiteFigureCount = 0;
    public int blackFigureCount = 0;
    public bool whiteTurn = true;
    public void DrawBoard()
    {
        Console.WriteLine("This is updated board!\n\n\n");
        for (int i = 0; i < mainBoard.GetLength(0); i++)
        {
            Console.WriteLine();
            for (int j = 0; j < mainBoard.GetLength(1); j++)
            {
                if (mainBoard[i, j] == null)
                    Console.Write("|" + "     " + "|");
                else
                {
                    string name = GetGoodName(mainBoard[i, j]);
                    Console.Write($"| {name} |");
                }
            }

            Console.Write("  " + i + " Row");
            
        }
        Console.WriteLine("\n");
        for (int i = 0; i < 8; i++)
        {
            Console.Write($" {i} Col ");
        }
        Console.WriteLine();
    }

    public string GetGoodName(Figure f)
    {
        if (f is Mxedari m)
        {
            return f.white ? "wMx" : "bMx"; // bMx means black Mxedari or wMx white Mxedari
        }
        else if (f is Paiki p)
        {
            return f.white ? "wPk" : "bPk"; // bPk means black Paiki or wMx white Paiki
        }
        else if (f is Mefe mf)
        {
            return f.white ? "wMf" : "bMf"; // bMf means black Mefe or wMx white Mefe
        }
        else if (f is Ku k)
        {
            return f.white ? "wKu" : "bKu"; // bKu means black Ku or wKu white Ku
        }
        return null;

    }

    public void GenerateWhites()
    {
        for (int i = 0; i < 8; i++)
        {
            Paiki p = new Paiki(this, true, 1, i); //paikebi tetri
            whiteFigureCount++;

        }
        Mefe m = new Mefe(this, true, 0, 4); // mefe tetri
        whiteFigureCount++;


        Mxedari mx1 = new Mxedari(this, true, 0, 1);
        whiteFigureCount++;

        Mxedari mx2 = new Mxedari(this, true, 0, 6);
        whiteFigureCount++;


    }

    public void GenerateBlacks()
    {
        for (int i = 0; i < 8; i++)
        {
            Paiki p = new Paiki(this, false, 6, i); // paikebi shavi
            blackFigureCount++;
        }
        Mefe m = new Mefe(this, false, 7, 4); // mefe shavi
        blackFigureCount++;

        Mxedari mx1 = new Mxedari(this, false, 7, 1);
        blackFigureCount++;

        Mxedari mx2 = new Mxedari(this, false, 7, 6);
        blackFigureCount++;
    }

    public void Start()
    {
        while (blackFigureCount != 0 || whiteFigureCount != 0)
        {
            try
            {
                Turn();
                whiteTurn = !whiteTurn;
            }
            catch (Exception e)
            {
                Console.WriteLine("Try again!");
            }
        }
    }

    public void Turn()
    {
        if (whiteTurn)
        {
            Console.WriteLine("enter row and col for your choosing white figure!");
            try
            {
                Console.Write("X: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Y: ");
                int y = int.Parse(Console.ReadLine());

                while (x < 0)
                {
                    Console.Write("please choose correct x: ");
                }

                while (y < 0)
                {
                    Console.Write("please choose correct x: ");
                }

                var fig = mainBoard[x, y];
                if (fig.white == false)
                {
                    Console.WriteLine("you did not choose correctly!");
                    return;
                }
                Console.WriteLine($"Now you can move with you {fig}");
                fig.Move();
                    
                    
            }
            catch { }
            //whiteTurn = false;
        }
        else
        {
            Console.WriteLine("enter row and col for your choosing black figure!");
            try
            {
                Console.Write("X: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Y: ");
                int y = int.Parse(Console.ReadLine());

                while (x < 0)
                {
                    Console.Write("please choose correct x: ");
                }

                while (y < 0)
                {
                    Console.Write("please choose correct x: ");
                }

                var fig = mainBoard[x, y];
                if (fig.white == true)
                {
                    Console.WriteLine("you did not choose correctly!");
                    return;
                }
                Console.WriteLine($"Now you can move with you {fig}");
                fig.Move();
                //whiteTurn = true;
            }
            catch { }
        }
    }
}
