int ArraySize()
{
    Console.WriteLine("введите количество элементов массива");
    int numberOfElements = Convert.ToInt32(Console.ReadLine());
    return numberOfElements;
}
string[] CreateAraay(int arraySize)
{
    string[] array = new string[arraySize];
    return array;
}
void EnterArrayElements(string[] array)
{
   for(int i = 0; i<array.Length; i++)
    {
        Console.WriteLine($"Введите {i+1}-й элемент");
        array[i] =Console.ReadLine();
    }
    
}
int NumberElementsLengthLess4(string[] array)
{
   int k = 0;
   for(int i = 0; i<array.Length; i++)
    {
        if(array[i].Length<4) k++;        
    } 
    return k;
}
void FillArrayElementLengthLess4(string[] arrayFinal, string[] arraySource)
{
    int k = 0;
    for(int i = 0; i<arraySource.Length; i++)
    {
        if(arraySource[i].Length<4)
        {
            arrayFinal[k] = arraySource[i];
            k++;
        }        
    } 

}
void PrintArray(string[]array)
{
    for(int i = 0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
int sourceArraySize = ArraySize();
string[] sourceArray = CreateAraay(sourceArraySize);
EnterArrayElements(sourceArray);
int finalArraySize = NumberElementsLengthLess4(sourceArray);
string[] finalArray = CreateAraay(finalArraySize);
FillArrayElementLengthLess4(finalArray, sourceArray);
PrintArray(sourceArray);
PrintArray(finalArray);
