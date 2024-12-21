public class Paiki : Figure
{


    public bool firstMove = false;

    public Paiki(Board b, bool white, int x, int y) : base(white, b, x, y)
    {

    }

    public override void Kill()
    {
        if (white)
        {
            if (board.mainBoard[XPosition + 1, YPosition - 1] is Figure f)
            {
                if (!f.white)
                {
                    board.mainBoard[XPosition, YPosition] = null;
                    board.mainBoard[XPosition + 1, YPosition - 1] = this;
                    Console.WriteLine("Succesfully killed!");
                    board.blackFigureCount--;
                }
            }
            else if (board.mainBoard[XPosition + 1, YPosition + 1] is Figure f1)
            {
                if (!f1.white)
                {
                    board.mainBoard[XPosition, YPosition] = null;
                    board.mainBoard[XPosition + 1, YPosition + 1] = this;
                    Console.WriteLine("Succesfully killed!");
                    board.whiteFigureCount--;
                }
            }
        }
    }

    public override void Move()
    {
        Console.Write("enter 1 or 2 step for pawn: ");
        int x = 0;
        try
        {
            x = int.Parse(Console.ReadLine());
            while (x != 1 && x != 2)
            {
                Console.WriteLine("give correct input: ");
                x = int.Parse(Console.ReadLine());
            }
            if (firstMove == true && x == 2)
            {
                Console.WriteLine("can't move with 2 so move with 1 on this pawn!");
                Move();
            }
            else if (firstMove == false && x == 2)
            {
                //for white:
                if (white)
                {
                    if (board.mainBoard[XPosition + 2, YPosition] != null)
                        Console.WriteLine("Cant move here!");
                    else
                    {
                        board.mainBoard[XPosition, YPosition] = null;
                        XPosition = XPosition + 2;
                        board.mainBoard[XPosition, YPosition] = this;
                        Console.WriteLine("move done!");
                        board.DrawBoard();
                        return;
                    }
                }
                else // for black:
                {
                    if (board.mainBoard[XPosition - 2, YPosition] != null)
                        Console.WriteLine("Cant move here!");
                    else
                    {
                        board.mainBoard[XPosition, YPosition] = null;
                        XPosition = XPosition - 2;
                        board.mainBoard[XPosition, YPosition] = this;
                        Console.WriteLine("move done!");
                        board.DrawBoard();
                        return;
                    }
                }
                
            }
            else
            {
                //for white:
                if (white)
                {
                    if (board.mainBoard[XPosition + 1, YPosition] != null)
                        Console.WriteLine("Cant move here!");
                    else
                    {
                        board.mainBoard[XPosition, YPosition] = null;
                        XPosition = XPosition + 1;
                        board.mainBoard[XPosition, YPosition] = this;
                        Console.WriteLine("move done!");
                        board.DrawBoard();
                        return;
                    }
                }
                else // for black:
                {
                    if (board.mainBoard[XPosition - 1, YPosition] != null)
                        Console.WriteLine("Cant move here!");
                    else
                    {
                        board.mainBoard[XPosition, YPosition] = null;
                        XPosition = XPosition - 1;
                        board.mainBoard[XPosition, YPosition] = this;
                        Console.WriteLine("move done!");
                        board.DrawBoard();
                        return;
                    }
                }
            }
            
        }
        catch
        { }
    }
}