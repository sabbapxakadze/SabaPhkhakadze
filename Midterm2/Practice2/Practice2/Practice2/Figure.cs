public abstract class Figure
{
    public bool white;
    public Board board;

    public int XPosition { get; set; }
    public int YPosition { get; set; }
    public Figure(bool _white, Board b, int x, int y)
    {
        white = _white;
        board = b;
        XPosition = x;
        YPosition = y;
        board.mainBoard[XPosition, YPosition] = this;
    }
    public abstract void Move();
    public abstract void Kill();
}
// Xposition considered as ROW NUMBER
// YPosition considered as COLUMN NUMBER
// sorry it was mistake!