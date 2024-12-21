Board board = new Board();

board.GenerateBlacks();
board.GenerateWhites();



var item = board.mainBoard;
board.DrawBoard();
Console.WriteLine();




board.Start();