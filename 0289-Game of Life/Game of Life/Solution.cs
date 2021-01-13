using System;

namespace Game_of_Life
{
    /// <summary>
    /// According to Wikipedia's article: "The Game of Life, also known simply as Life, is a cellular automaton devised by the British mathematician John Horton Conway in 1970."
    /// The board is made up of an m x n grid of cells, where each cell has an initial state: live(represented by a 1) or dead(represented by a 0). Each cell interacts with its eight neighbors(horizontal, vertical, diagonal) using the following four rules(taken from the above Wikipedia article) :
    /// Any live cell with fewer than two live neighbors dies as if caused by under-population.
    /// Any live cell with two or three live neighbors lives on to the next generation.
    /// Any live cell with more than three live neighbors dies, as if by over-population.
    /// Any dead cell with exactly three live neighbors becomes a live cell, as if by reproduction.
    /// The next state is created by applying the above rules simultaneously to every cell in the current state, where births and deaths occur simultaneously. Given the current state of the m x n grid board, return the next state.
    /// </summary>
    public class Solution
    {
        public void GameOfLife(int[][] board)
        {
            // Neighbors array to find 8 neighboring cells for a given cell
            int[] neighbors = { 0, 1, -1 };

            int rows = board.Length;
            int cols = board[0].Length;

            // Iterate through board cell by cell.
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {

                    // For each cell count the number of live neighbors.
                    int liveNeighbors = 0;

                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {

                            if (!(neighbors[i] == 0 && neighbors[j] == 0))
                            {
                                int r = (row + neighbors[i]);
                                int c = (col + neighbors[j]);

                                // Check the validity of the neighboring cell.
                                // and whether it was originally a live cell.
                                if (r < rows && r >= 0 && (c < cols && c >= 0) && (Math.Abs(board[r][c]) == 1))
                                {
                                    liveNeighbors += 1;
                                }
                            }
                        }
                    }

                    // Rule 1 or Rule 3
                    if ((board[row][col] == 1) && (liveNeighbors < 2 || liveNeighbors > 3))
                    {
                        // -1 signifies the cell is now dead but originally was live.
                        board[row][col] = -1;
                    }
                    // Rule 4
                    if (board[row][col] == 0 && liveNeighbors == 3)
                    {
                        // 2 signifies the cell is now live but was originally dead.
                        board[row][col] = 2;
                    }
                }
            }

            // Get the final representation for the newly updated board.
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    board[row][col] = board[row][col] > 0 ? 1 : 0;
                }
            }
        }
    }
}
