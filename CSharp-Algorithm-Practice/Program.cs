int [] numbers = {3, 7, 2, 9, 1, 5};
float sum = 0;

for (int i = 0; i < numbers.Length; i ++)
{
        sum = sum + numbers[i];
}

float average = sum / numbers.Length; 
Console.WriteLine(average);