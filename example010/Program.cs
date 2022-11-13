int[] array = { 86, 2, 30, 4, 58, 6, 97, 86 };

int n = array.Length;
int find = 86;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}