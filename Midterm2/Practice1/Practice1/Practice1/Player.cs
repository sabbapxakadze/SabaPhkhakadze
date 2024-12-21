using System.Reflection;

public class Player
{
    List<Ship> ships = new List<Ship> { Ship.Cruiser, Ship.Submarine, Ship.Destroyer, Ship.BattleShip, Ship.AirCraft };
    Board board {  get; set; }  
    public Player(Board b)
    {
        board = b;
    }

    public int shipSize = 5;

    public int lifeCount = 5 + 4 + 3 + 2 + 1;

    public void PutFiguresOnBoard()
    {
        Console.WriteLine("Put all ships on the board!");

        var shipForEach = ships;

        foreach (var ship in shipForEach)
        {
            var p = ship.GetType();
            Console.WriteLine($"Choose x and y for {p.Name} with {shipSize} length");

            
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());
                while (x < 0)
                {
                    Console.Write("Try again for x: ");
                    x = int.Parse(Console.ReadLine());
                }
                while (y < 0)
                {
                    Console.Write("Try again for y: ");
                    y = int.Parse(Console.ReadLine());
                }
                
                    Console.WriteLine("choose direction up with u, down with d, left with l and right with r key");
                    string key = char.Parse(Console.ReadLine()).ToString().ToLower();
                    while (key != "l" && key != "r" && key != "d" && key != "u")
                    {
                        Console.Write("Please give a correct input!");
                    key = char.Parse(Console.ReadLine()).ToString().ToLower();
                }

                    switch (key)
                    {
                        case "l":
                            board.CanPutShipOnBoardDown(shipSize, x, y, "P");
                            board.DrawBoard();
                            break;
                        case "r":
                            board.CanPutShipOnBoardUp(shipSize, x, y, "P");
                            board.DrawBoard();
                            break;
                        case "d":
                            board.CanPutShipOnBoardRight(shipSize, x, y, "P");
                            board.DrawBoard();
                            break;
                        case "u":
                            board.CanPutShipOnBoardLeft(shipSize, x, y, "P");
                            board.DrawBoard();
                            break;
                    }

                    shipSize--;
            // right go down
            // down go left
            //left go up
            //up go right
        }
    }

    public void ShootEnemy(Player player)
    {
        Console.WriteLine("Choose x and y:");
        Console.Write("x: ");
        int x = 0, y = 0;
        try
        {
            x = int.Parse(Console.ReadLine());
            while (x < 0)
            {
                Console.WriteLine("correct input please: ");
            }
        }
        catch (Exception e) { }


        try
        {
            y = int.Parse(Console.ReadLine());
            while (y < 0)
            {
                Console.WriteLine("correct input please: ");
            }
        }
        catch (Exception e) { }


        if (player.board.board[x,y] != null)
        {
            player.board.board = null;

            Console.WriteLine("Nice, you hit him!");
            player.lifeCount--;

            if (player.lifeCount == 0)
            {
                Console.WriteLine("Congrats you won the game");
            }
        }
    }

}
public enum Ship
{
    AirCraft = 5,
    BattleShip = 4,
    Cruiser = 3,
    Submarine = 2,
    Destroyer = 1
}