public class Mefe : Figure
{
    public Mefe(Board b, bool white, int x, int y) : base(white, b, x, y)
    {

    }
    public override void Kill()
    {
        Console.WriteLine("you killed them easy!");
    }

    public override void Move()
    {
        Console.WriteLine("you can move left l, right r, up u, down d," +
            "left up lu, left down ld, right up ru, right down rd ");
        Console.Write("type one of these: ");
        string res = Console.ReadLine().ToLower();
        while (res != "l" && res != "r" && res != "u" && res != "d" &&
            res != "lu" && res != "ld" && res != "ru" && res != "rd")
        {
            Console.WriteLine("Please enter a valid move: ");
            res = Console.ReadLine().ToLower();
        }
        switch (res)
        {
            case "l":
                if (board.mainBoard[XPosition, --YPosition] != null)
                {
                    if (board.mainBoard[XPosition, --YPosition] is Figure f && f.white != this.white)
                    {
                        Kill();
                        if (f.white) board.whiteFigureCount--;
                        else board.blackFigureCount--;
                        board.mainBoard[XPosition, YPosition] = null;
                        YPosition--;
                        board.mainBoard[XPosition, YPosition] = this;
                        break;
                    }
                    Console.WriteLine("you cant go on occupied position!");
                    Console.WriteLine("Try again!");
                    Move();
                }
                else
                {
                    board.mainBoard[XPosition, YPosition] = null;
                    YPosition--;
                    board.mainBoard[XPosition, YPosition] = this;
                }
                break;

            case "r":
                if (board.mainBoard[XPosition, ++YPosition] != null)
                {
                    if (board.mainBoard[XPosition, ++YPosition] is Figure f && f.white != this.white)
                    {
                        Kill();
                        if (f.white) board.whiteFigureCount--;
                        else board.blackFigureCount--;
                        board.mainBoard[XPosition, YPosition] = null;
                        YPosition++;
                        board.mainBoard[XPosition, YPosition] = this;
                        break;
                    }
                    Console.WriteLine("you cant go on occupied position!");
                    Console.WriteLine("Try again!");
                    Move();
                }
                else
                {
                    board.mainBoard[XPosition, YPosition] = null;
                    YPosition++;
                    board.mainBoard[XPosition, YPosition] = this;
                }
                break;
            case "u":
                if (board.mainBoard[--XPosition, YPosition] != null)
                {
                    if (board.mainBoard[--XPosition, YPosition] is Figure f && f.white != this.white)
                    {
                        Kill();
                        if (f.white) board.whiteFigureCount--;
                        else board.blackFigureCount--;
                        board.mainBoard[XPosition, YPosition] = null;
                        XPosition--;
                        board.mainBoard[XPosition, YPosition] = this;
                        break;
                    }
                    Console.WriteLine("you cant go on occupied position!");
                    Console.WriteLine("Try again!");
                    Move();
                }
                else
                {
                    board.mainBoard[XPosition, YPosition] = null;
                    XPosition--;
                    board.mainBoard[XPosition, YPosition] = this;
                }
                break;

            case "d":
                if (board.mainBoard[++XPosition, YPosition] != null)
                {
                    if (board.mainBoard[++XPosition, YPosition] is Figure f && f.white != this.white)
                    {
                        Kill();
                        if (f.white) board.whiteFigureCount--;
                        else board.blackFigureCount--;
                        board.mainBoard[XPosition, YPosition] = null;
                        XPosition++;
                        board.mainBoard[XPosition, YPosition] = this;
                        break;
                    }
                    Console.WriteLine("you cant go on occupied position!");
                    Console.WriteLine("Try again!");
                    Move();
                }
                else
                {
                    board.mainBoard[XPosition, YPosition] = null;
                    XPosition++;
                    board.mainBoard[XPosition, YPosition] = this;
                }
                break;

            case "lu":
                if (board.mainBoard[++XPosition, --YPosition] != null)
                {
                    if (board.mainBoard[++XPosition, --YPosition] is Figure f && f.white != this.white)
                    {
                        Kill();
                        if (f.white) board.whiteFigureCount--;
                        else board.blackFigureCount--;
                        board.mainBoard[XPosition, YPosition] = null;
                        XPosition++;
                        YPosition--;
                        board.mainBoard[XPosition, YPosition] = this;
                        break;
                    }
                    Console.WriteLine("you cant go on occupied position!");
                    Console.WriteLine("Try again!");
                    Move();
                }
                else
                {
                    board.mainBoard[XPosition, YPosition] = null;
                    XPosition++;
                    YPosition--;
                    board.mainBoard[XPosition, YPosition] = this;
                }
                break;

            case "ld":
                if (board.mainBoard[--XPosition, ++YPosition] != null)
                {
                    if (board.mainBoard[--XPosition, ++YPosition] is Figure f && f.white != this.white)
                    {
                        Kill();
                        if (f.white) board.whiteFigureCount--;
                        else board.blackFigureCount--;
                        board.mainBoard[XPosition, YPosition] = null;
                        XPosition--;
                        YPosition++;
                        board.mainBoard[XPosition, YPosition] = this;
                        break;
                    }
                    Console.WriteLine("you cant go on occupied position!");
                    Console.WriteLine("Try again!");
                    Move();
                }
                else
                {
                    board.mainBoard[XPosition, YPosition] = null;
                    XPosition--;
                    YPosition++;
                    board.mainBoard[XPosition, YPosition] = this;
                }
                break;

            case "ru":
                if (board.mainBoard[++XPosition, ++YPosition] != null)
                {
                    if (board.mainBoard[++XPosition, ++YPosition] is Figure f && f.white != this.white)
                    {
                        Kill();
                        if (f.white) board.whiteFigureCount--;
                        else board.blackFigureCount--;
                        board.mainBoard[XPosition, YPosition] = null;
                        XPosition++;
                        YPosition++;
                        board.mainBoard[XPosition, YPosition] = this;
                        break;
                    }
                    Console.WriteLine("you cant go on occupied position!");
                    Console.WriteLine("Try again!");
                    Move();
                }
                else
                {
                    board.mainBoard[XPosition, YPosition] = null;
                    XPosition++;
                    YPosition++;
                    board.mainBoard[XPosition, YPosition] = this;
                }
                break;

            case "rd":
                if (board.mainBoard[--XPosition, ++YPosition] != null)
                {
                    if (board.mainBoard[--XPosition, ++YPosition] is Figure f && f.white != this.white)
                    {
                        Kill();
                        if (f.white) board.whiteFigureCount--;
                        else board.blackFigureCount--;
                        board.mainBoard[XPosition, YPosition] = null;
                        XPosition--;
                        YPosition++;
                        board.mainBoard[XPosition, YPosition] = this;
                        break;
                    }
                    Console.WriteLine("you cant go on occupied position!");
                    Console.WriteLine("Try again!");
                    Move();
                }
                else
                {
                    board.mainBoard[XPosition, YPosition] = null;
                    XPosition--;
                    YPosition++;
                    board.mainBoard[XPosition, YPosition] = this;
                }
                break;
        }
        board.DrawBoard();
    }
}