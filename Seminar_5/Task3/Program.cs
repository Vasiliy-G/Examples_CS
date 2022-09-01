// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные,
// и наоборот. [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int [] inputArray = {-4, -8, 8, 2};

for(int i = 0; i < inputArray.Length; i++)
{
    inputArray[i] *= -1;
}

Console.WriteLine(String.Join(", ", inputArray));
