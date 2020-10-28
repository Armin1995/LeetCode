using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 794 有效的井字游戏
/// </summary>
namespace LeetCode794
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] board = new string[3];
            board[0] = "XXX";
            board[1] = "XOO";
            board[2] = "OO ";

            Solution s = new Solution();
            bool result = s.ValidTicTacToe(board);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public bool ValidTicTacToe(string[] board)
        {
            if (board == null)
            {
                return false;
            }
            var xboard = new bool[9];
            var oboard = new bool[9];
            int i = 0;
            foreach (var b in board)
            {
                foreach (var c in b)
                {
                    if (c == 'X')
                    {
                        xboard[i] = true;
                        oboard[i] = false;
                    }
                    else if (c == 'O')
                    {
                        xboard[i] = false;
                        oboard[i] = true;
                    }
                    else
                    {
                        xboard[i] = false;
                        oboard[i] = false;
                    }
                    i++;
                }
            }
            var xCount = xboard.Where(o => o == true).Count();
            var oCount = oboard.Where(o => o == true).Count();
            if (xCount < oCount || xCount - oCount > 1)
            {
                return false;
            }
            bool c1 = CanExist(xboard, out bool xWin);
            bool c2 = CanExist(oboard, out bool oWin);
            if (xWin == true && oWin == true)
            {
                return false;
            }
            if (xWin && xCount - oCount != 1)
            {
                return false;
            }
            if (oWin && xCount - oCount != 0)
            {
                return false;
            }
            if (c1 && c2)
            {
                return true;
            }
            return false;
        }

        private bool CanExist(bool[] board, out bool isWin)
        {
            isWin = false;
            bool b1 = board[0] & board[1] & board[2];
            bool b2 = board[3] & board[4] & board[5];
            bool b3 = board[6] & board[7] & board[8];
            bool b4 = board[0] & board[3] & board[6];
            bool b5 = board[1] & board[4] & board[7];
            bool b6 = board[2] & board[5] & board[8];
            bool b7 = board[0] & board[4] & board[8];
            bool b8 = board[2] & board[4] & board[6];
            if (b1 || b2 || b3 || b4 || b5 || b6 || b7 || b8)
            {
                isWin = true;
            }

            bool b12 = b1 && b2;
            bool b13 = b1 && b3;
            bool b14 = b1 && b4;
            bool b15 = b1 && b5;
            bool b16 = b1 && b6;
            bool b17 = b1 && b7;
            bool b18 = b1 && b8;
            bool b23 = b2 && b3;
            bool b24 = b2 && b4;
            bool b25 = b2 && b5;
            bool b26 = b2 && b6;
            bool b27 = b2 && b7;
            bool b28 = b2 && b8;
            bool b34 = b3 && b4;
            bool b35 = b3 && b5;
            bool b36 = b3 && b6;
            bool b37 = b3 && b7;
            bool b38 = b3 && b8;
            bool b45 = b4 && b5;
            bool b46 = b4 && b6;
            bool b47 = b4 && b7;
            bool b48 = b4 && b8;
            bool b56 = b5 && b6;
            bool b57 = b5 && b7;
            bool b58 = b5 && b8;
            bool b67 = b6 && b7;
            bool b68 = b6 && b8;
            bool b78 = b7 && b8;
            if (b12 || b13 || b23 || b45 || b46 || b56)
            {
                return false;
            }
            return true;
        }
    }
}
