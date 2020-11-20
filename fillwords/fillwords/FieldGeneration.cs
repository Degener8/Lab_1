using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace fillwords
{
    class FieldGeneration
    {
        static int width, height;
        static List<string> words;
        static List<int> dividedWords;
        static char[,] letters;
        static string path;
        static List<int> emptyCells;

        static void GetWords()
        {
            int length = 0;
            Random rnd = new Random();

            do
            {
                int id = rnd.Next(0, File.ReadAllLines(path).Length);
                words.Add(File.ReadAllLines(path)[id]);
                length += File.ReadAllLines(path)[id].Length;
            }
            while (length < width * height);

            if (length > width * height)
            {
                words[words.Count - 1] = words[words.Count - 1].Substring(0, words[words.Count - 1].Length - (length - width * height) - 1);
                dividedWords.Add(words.Count - 1);
            }

            if (words.Count < 3)
            {
                words.Clear();
                GetWords();
            }
        }

        static char[,] GenerateField()
        {
            char[,] field = new char[width, height];

            static bool CheckSpace(int i, int j, char[,] field)
            {
                return (field[i, j] == '0');
            }

            static bool CheckExistence(int i, int j)
            {
                return (i >= 0 && i < height && j >= 0 && j < width);
            }

            static bool CheckPath(int i, int j, char[,] field)
            {
                return (CheckSpace(i, j, field) && CheckExistence(i, j));
            }

            static bool CheckIfCanMove(int i, int j, char[,] field)
            {
                return ((CheckPath(i - 1, j, field)) || (CheckPath(i + 1, j, field)) || (CheckPath(i, j - 1, field)) || (CheckPath(i, j + 1, field)));
            }

            static int[] RandomisePath(int i, int j, char[,] field)
            {
                Random rnd = new Random();
                int path = rnd.Next(0, 3);
                int[] pair = new int[2];

                if (path == 0 && CheckPath(i - 1, j, field))
                {
                    pair[0] = i - 1;
                    pair[1] = j;
                }
                else if (path == 1 && CheckPath(i + 1, j, field))
                {
                    pair[0] = i + 1;
                    pair[1] = j;
                }
                else if (path == 2 && CheckPath(i, j - 1, field))
                {
                    pair[0] = i;
                    pair[1] = j - 1;
                }
                else if (path == 2 && CheckPath(i, j - 1, field))
                {
                    pair[0] = i;
                    pair[1] = j - 1;
                }
                else RandomisePath(i, j, field);


                return pair;
            }


            static int[] FindEmptyCell(char[,] field)
            {
                int[] pair = new int[2];
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        if (field[i, j] == '0')
                        {
                            pair[0] = i;
                            pair[1] = j;
                            break;
                        }
                    }
                }
                return pair;
            }

            List<int> emptyCells = new List<int>();
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    field[i, j] = '0';
                    emptyCells.Add(i * width + j);
                }

            }


            for (int i = 0; i < words.Count; i++)
            {
                Random rnd = new Random();
                int[] pair = FindEmptyCell(field);
                string word = words[i];
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (j > 0 && CheckIfCanMove(pair[0], pair[1], field))
                        pair = RandomisePath(i, j, field);
                    else
                    {
                        int cell = rnd.Next(0, emptyCells.Count);
                        pair[0] = emptyCells[cell] / width;
                        pair[1] = emptyCells[cell] % width;
                        emptyCells.RemoveAt(cell);
                        dividedWords.Add(i);
                    }
                    
                    field[pair[0], pair[1]] = word[j];

                }
            }

            for (int i = 0; i < dividedWords.Count; i++)
                words.RemoveAt(dividedWords[i]);

            return field;
        }


    }
}
