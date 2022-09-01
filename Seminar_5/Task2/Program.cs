// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве. [1 2 3 4 5] -> 5 8 3 [6 7 3 6] -> 36 21 

int [] inputArray = {1, 2, 3, 4, 5};
// int index = inputArray.Length;

int [] resultArray = new int[inputArray.Length/2 + inputArray.Length%2];
// int [] resultArray = new int[index/2 + index%2];

for(int i = 0; i < resultArray.Length; i++)
{
    resultArray[i] = inputArray[i] * inputArray[inputArray.Length - 1 - i];    

    //if(i == (resultArray.Length - 1 - i))
    if(i == (inputArray.Length - 1 - i))
    {
        resultArray[i] =  inputArray[i];
    }

}

Console.WriteLine(String.Join(", ", resultArray));
