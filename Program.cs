int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine())!;
}

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

void Fill2DArray(int[,] array, int minValue, int maxValue)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(minValue, maxValue + 1);
}

string Print2DArray(int[,] array)
{
    string res = String.Empty;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            res += array[i, j];
            if (j != array.GetLength(1) - 1)
                res += "\t";
            else
                res += "\n";
        }
    return res;
}

bool SearchNumByIndexes(int rows, int cols, int indI, int indJ)
{
    return indI > 0 && indJ > 0 && indI <= rows && indJ <= cols;
}

string IsElement(bool check, int[,] array, int indI, int indJ)
{
    string ans = "This is no number with such indexes.";
    if(check == true) ans = $"Value of number is {array[indI - 1, indJ - 1]}.";
    return ans;
}

int numRows = InputNum("Input a number of rows: ");
int numCols = InputNum("Input a numbers of columns: ");
int[,] myArray = Create2DArray(numRows, numCols);
int min = InputNum("Input a min value: ");
int max = InputNum("Input a max value: ");
Fill2DArray(myArray, min, max);
string result = Print2DArray(myArray);
Console.WriteLine(result);

int numRow = InputNum("Input an index of row: ");
int numCol = InputNum("Input an index of column: ");

bool check = SearchNumByIndexes(numRows, numCols, numRow, numCol);
string element = IsElement(check, myArray, numRow, numCol);
Console.WriteLine(element);