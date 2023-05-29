public class TicTacToe
{
    public TicTacToe()
    {
        
    }

    public bool IsSolved (int[,] board)
    {
        var dimension = board.Length;

        if (dimension <= 0)
            return false;

        
        // check Rows
        for (int i = 0; i < dimension; i++)
        {
            var arrayToCheck = board.
            if (board[0].All(b => b == 2 || b == 1))
                return true;
        }
        // check Columns

// check Diagonale
        )

        
        return false;
    }
}
