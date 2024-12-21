public class Mxedari : Figure
{
    public Mxedari(Board b, bool white, int x, int y) : base(white, b,x,y)
    {

    }
    public override void Kill()
    {
        Console.WriteLine("you have killed a figure!");
    }

    public override void Move()
    {
        (int x, int y) move = ChooseMove();

        int xp = move.x + XPosition;
        int yp = move.y + YPosition;

        if (board.mainBoard[xp, yp] != null)
        {
            if (board.mainBoard[xp, yp] is Figure f && f.white != white)
            {
                Kill();
                if (f.white) board.whiteFigureCount--;
                else board.blackFigureCount--;
                board.mainBoard[XPosition, YPosition] = null;
                XPosition = xp;
                YPosition = yp;
                board.mainBoard[XPosition, YPosition] = this;
            }
            Console.WriteLine("You cant move there! try again!");
            board.DrawBoard();
            Move();
        }
        else
        {
            board.mainBoard[XPosition, YPosition] = null;
            XPosition = xp;
            YPosition = yp;

            board.mainBoard[XPosition, YPosition] = this;
        }

        board.DrawBoard();
    }

    public (int x,int y) ChooseMove()
    {
        List<MxedariMove> lst = new List<MxedariMove> { MxedariMove.Up2Left1, MxedariMove.Up2Right1
        , MxedariMove.Down2Left1, MxedariMove.Down2Right1,
        MxedariMove.Up1Left2, MxedariMove.Up1Right2, MxedariMove.Down1Left2, MxedariMove.Down1Right2
        };
        int cnt = 1;
        var x = typeof(MxedariMove);
        
        Console.WriteLine("Choose your move by typing correct index!");
        foreach (var item in lst)
        {
            Console.WriteLine($"{item}: {(int)item}");
        }

        int res = 0;
        try
        {
            res = int.Parse(Console.ReadLine());
            while (res > 8 || res < 1)
            {
                Console.Write("Please enter a correct index: ");
                res = int.Parse(Console.ReadLine());
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Give correct input!");
            return ChooseMove();
        }
        
        switch (res)
        {
            case 1:
                return (2, -1);
            case 2:
                return (2, 1);
            case 3:
                return (-2, -1);
            case 4:
                return (-2, 1);
            case 5:
                return (1, -2);
            case 6:
                return (1, 2);
            case 7:
                return (-1, -2);
            case 8:
                return (-1, 2);
        }
        return (0, 0);
    }
}

public enum MxedariMove
{
    Up2Left1 = 1, Up2Right1 = 2, Down2Left1 = 3, Down2Right1 = 4,
    Up1Left2 = 5, Up1Right2 = 6, Down1Left2 = 7, Down1Right2 = 8
}