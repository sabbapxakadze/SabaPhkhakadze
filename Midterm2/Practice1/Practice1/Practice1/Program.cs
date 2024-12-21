

Board board1 = new Board();
board1.StartFillBoard();

Board board2 = new Board();


Player p1 = new Player(board1);

Player p2 = new Player(board2);

p1.PutFiguresOnBoard();

p2.PutFiguresOnBoard();


bool p1Turn = true;
while (p1.lifeCount != 0 && p2.lifeCount != 0)
{
    if (p1Turn)
    {
        p1.ShootEnemy(p2);
        p1Turn = false;
        if (p2.lifeCount == 0)
        {
            Console.WriteLine("congrats, p1 won the game!");
            break;
        }
    }
    else
    {
        p2.ShootEnemy(p1);
        p1Turn = true;
        if (p1.lifeCount == 0)
        {
            Console.WriteLine("congrats, p2 won the game!");
            break;
        }
    }
}


// right go down
// down go left
//left go up
//up go right