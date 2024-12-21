public class Board
{
    public string[,] board = new string[10, 10];

    public void StartFillBoard()
    {
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                board[i, j] = string.Empty;
            }
        }
        DrawBoard();
    }

    public void DrawBoard()
    {
        Console.WriteLine("Your Board \n\n");

        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                Console.Write(board[i,j] + " . ");
            }
            Console.WriteLine();
        }

    }

    public void CanPutShipOnBoardUp
        (int shipSize, int x, int y, string shipLet)
    {
        int shipSize1 = shipSize;
        bool res = false;

        while (shipSize != 0)
        {

            if (!string.IsNullOrEmpty(board[x, y]))
            {
                Console.WriteLine("Cant put ship there!");
                return;
            }
            y--;
            shipSize--;
        }
        res = true;
        
        if (res)
            PutShipUp(shipSize1, x, y, shipLet);
    }

    public void PutShipUp(int shipSize, int x, int y, string shipLetter)
    {
        while (shipSize != 0)
        {
            board[x, y--] = shipLetter + shipSize;
            shipSize--;
        }
    }

    public void CanPutShipOnBoardDown
        (int shipSize, int x, int y, string shipLet)
    {
        int shipSize1 = shipSize;
        bool res = false;

        while (shipSize != 0)
        {

            if (!string.IsNullOrEmpty(board[x, y]))
            {
                Console.WriteLine("Cant put ship there!");
                return;
            }

        y++;
        shipSize--;
    }
        res = true;
        
        if (res)
            PutShipDown(shipSize1, x, y, shipLet);

    }

    public void PutShipDown(int shipSize, int x, int y, string shipLetter)
    {
        while (shipSize != 0)
        {
            board[x, y++] = shipLetter + shipSize;
            shipSize--;
        }
    }
    public void CanPutShipOnBoardLeft
        (int shipSize, int x, int y, string shipLet)
    {
        int shipSize1 = shipSize;
        bool res = false;

        while (shipSize != 0)
        {

            if (!string.IsNullOrEmpty(board[x, y]))
            {
                res = false;
                Console.WriteLine("Cant put ship there!");
                return;
            }
        

        x--;
        shipSize--;
    }
        res = true;
       
        if (res)
            PutShipLeft(shipSize1, x, y, shipLet);
    }

    public void PutShipLeft(int shipSize, int x, int y, string shipLetter)
    {
        while (shipSize != 0)
        {
            board[x--, y] = shipLetter + shipSize;
            shipSize--;
        }
    }
    public void CanPutShipOnBoardRight
        (int shipSize, int x, int y, string shipLet)
    {
        int shipSize1 = shipSize;
        bool res = false;

        while (shipSize != 0)
        {
            
                if (!string.IsNullOrEmpty(board[x, y]))
                {
                    res = false;
                    Console.WriteLine("Cant put ship there!");
                    return;
                }
            
            x++;
            shipSize--;

        }
        res = true;

        if (res)
            PutShipRight(shipSize1, x, y, shipLet);

    }

    public void PutShipRight(int shipSize, int x, int y, string shipLetter)
    {
        while (shipSize != 0)
        {
            board[x++, y] = shipLetter + shipSize;
            shipSize--;
        }
    }

}