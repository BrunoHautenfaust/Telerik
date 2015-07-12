
namespace MineSweeper
{
    using System;
    using System.Collections.Generic;
    class MineSweeperGame
    {
        static void Main(string[] args)
        {
            const int MAX_SCORE = 35;

            string move = string.Empty;
            char[,] field = CreateGameField();
            char[,] mines = PlaceMines();
            int ScoreCounter = 0;
            bool hitMine = false;
            List<Player> winners = new List<Player>(6);
            int intialRow = 0;
            int initialCol = 0;
            bool newGameStarted = true;
            bool endGame = false;

            do
            {
                if (newGameStarted)
                {
                    Console.WriteLine("===== Let's play Mine Sweeper =====" +
                    "\n\t Commands:\n'top' - High Score\n'restart' - New Game\n'exit' - Exit Game");
                    UpdateGameField(field);
                    newGameStarted = false;
                }
                Console.Write("Input row and column: ");
                move = Console.ReadLine().Trim();
                if (move.Length >= 3)
                {
                    if (int.TryParse(move[0].ToString(), out intialRow) &&
                    int.TryParse(move[2].ToString(), out initialCol) &&
                        intialRow <= field.GetLength(0) && initialCol <= field.GetLength(1))
                    {
                        move = "turn";
                    }
                }
                switch (move)
                {
                    case "top":
                        HighPlayers(winners);
                        break;
                    case "restart":
                        field = CreateGameField();
                        mines = PlaceMines();
                        UpdateGameField(field);
                        hitMine = false;
                        newGameStarted = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye!");
                        break;
                    case "turn":
                        if (mines[intialRow, initialCol] != '*')
                        {
                            if (mines[intialRow, initialCol] == '-')
                            {
                                PlayerTurn(field, mines, intialRow, initialCol);
                                ScoreCounter++;
                            }
                            if (MAX_SCORE == ScoreCounter)
                            {
                                endGame = true;
                            }
                            else
                            {
                                UpdateGameField(field);
                            }
                        }
                        else
                        {
                            hitMine = true;
                        }
                        break;
                    default:
                        Console.WriteLine("\nInvalid command!\n");
                        break;
                }
                if (hitMine)
                {
                    UpdateGameField(mines);
                    Console.Write("\nYou blew it! Your score: {0}. " +
                        "Input nickname: ", ScoreCounter);
                    string nickname = Console.ReadLine();
                    Player playerInHighScores = new Player(nickname, ScoreCounter);
                    if (winners.Count < 5)
                    {
                        winners.Add(playerInHighScores);
                    }
                    else
                    {
                        for (int i = 0; i < winners.Count; i++)
                        {
                            if (winners[i].Points < playerInHighScores.Points)
                            {
                                winners.Insert(i, playerInHighScores);
                                winners.RemoveAt(winners.Count - 1);
                                break;
                            }
                        }
                    }
                    winners.Sort((Player r1, Player r2) => r2.Name.CompareTo(r1.Name));
                    winners.Sort((Player r1, Player r2) => r2.Points.CompareTo(r1.Points));
                    HighPlayers(winners);

                    field = CreateGameField();
                    mines = PlaceMines();
                    ScoreCounter = 0;
                    hitMine = false;
                    newGameStarted = true;
                }
                if (endGame)
                {
                    Console.WriteLine("\nCongratulations! You've opened 35 cells without stepping on a mine.");
                    UpdateGameField(mines);
                    Console.WriteLine("Input your nickname: ");
                    string name = Console.ReadLine();
                    Player bestPlayerInHighScores = new Player(name, ScoreCounter);
                    winners.Add(bestPlayerInHighScores);
                    HighPlayers(winners);
                    field = CreateGameField();
                    mines = PlaceMines();
                    ScoreCounter = 0;
                    endGame = false;
                    newGameStarted = true;
                }
            }
            while (move != "exit");
            Console.WriteLine("Made in Bulgaria!");
            Console.Read();
        }

        private static void HighPlayers(List<Player> HighScorePlayers)
        {
            Console.WriteLine("\nPoints:");
            if (HighScorePlayers.Count > 0)
            {
                for (int i = 0; i < HighScorePlayers.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} boxes",
                        i + 1, HighScorePlayers[i].Name, HighScorePlayers[i].Points);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("---\n");
            }
        }

        private static void PlayerTurn(char[,] mineField,
            char[,] BOMBI, int currentRow, int currentCol)
        {
            char numberOfMines = GetNumberOfMines(BOMBI, currentRow, currentCol);
            BOMBI[currentRow, currentCol] = numberOfMines;
            mineField[currentRow, currentCol] = numberOfMines;
        }

        private static void UpdateGameField(char[,] board)
        {
            int rowCount = board.GetLength(0);
            int colCount = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rowCount; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < colCount; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateGameField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] PlaceMines()
        {
            int rowsForMines = 5;
            int colsForMines = 10;
            char[,] gameField = new char[rowsForMines, colsForMines];

            for (int i = 0; i < rowsForMines; i++)
            {
                for (int j = 0; j < colsForMines; j++)
                {
                    gameField[i, j] = '-';
                }
            }

            List<int> minesList = new List<int>();
            while (minesList.Count < 15)
            {
                Random random = new Random();
                int asfd = random.Next(50);
                if (!minesList.Contains(asfd))
                {
                    minesList.Add(asfd);
                }
            }

            foreach (int i2 in minesList)
            {
                int kol = (i2 / colsForMines);
                int red = (i2 % colsForMines);
                if (red == 0 && i2 != 0)
                {
                    kol--;
                    red = colsForMines;
                }
                else
                {
                    red++;
                }
                gameField[kol, red - 1] = '*';
            }

            return gameField;
        }

        private static void smetki(char[,] pole)
        {
            int kol = pole.GetLength(0);
            int red = pole.GetLength(1);

            for (int i = 0; i < kol; i++)
            {
                for (int j = 0; j < red; j++)
                {
                    if (pole[i, j] != '*')
                    {
                        char kolkoo = GetNumberOfMines(pole, i, j);
                        pole[i, j] = kolkoo;
                    }
                }
            }
        }

        private static char GetNumberOfMines(char[,] fieldWithMines, int currentRow, int currentCol)
        {
            int numberOfMines = 0;
            int row = fieldWithMines.GetLength(0);
            int col = fieldWithMines.GetLength(1);

            if (currentRow - 1 >= 0)
            {
                if (fieldWithMines[currentRow - 1, currentCol] == '*')
                {
                    numberOfMines++;
                }
            }
            if (currentRow + 1 < row)
            {
                if (fieldWithMines[currentRow + 1, currentCol] == '*')
                {
                    numberOfMines++;
                }
            }
            if (currentCol - 1 >= 0)
            {
                if (fieldWithMines[currentRow, currentCol - 1] == '*')
                {
                    numberOfMines++;
                }
            }
            if (currentCol + 1 < col)
            {
                if (fieldWithMines[currentRow, currentCol + 1] == '*')
                {
                    numberOfMines++;
                }
            }
            if ((currentRow - 1 >= 0) && (currentCol - 1 >= 0))
            {
                if (fieldWithMines[currentRow - 1, currentCol - 1] == '*')
                {
                    numberOfMines++;
                }
            }
            if ((currentRow - 1 >= 0) && (currentCol + 1 < col))
            {
                if (fieldWithMines[currentRow - 1, currentCol + 1] == '*')
                {
                    numberOfMines++;
                }
            }
            if ((currentRow + 1 < row) && (currentCol - 1 >= 0))
            {
                if (fieldWithMines[currentRow + 1, currentCol - 1] == '*')
                {
                    numberOfMines++;
                }
            }
            if ((currentRow + 1 < row) && (currentCol + 1 < col))
            {
                if (fieldWithMines[currentRow + 1, currentCol + 1] == '*')
                {
                    numberOfMines++;
                }
            }
            return char.Parse(numberOfMines.ToString());
        }
    }
}