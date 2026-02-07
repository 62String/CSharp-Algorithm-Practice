int [] numbers = {3, 7, 2, 9, 1, 5};
int saveMax = numbers[0];

for (int i = 0; i <= 5; i ++)
{
    if (numbers[i] > saveMax)
    {
        saveMax = numbers[i];
        
    }
}
Console.WriteLine(saveMax);