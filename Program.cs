
void PrintArray (int[] arr)
{   for (int pos=0; pos<arr.Length; pos++)
    {Console.Write($"{arr[pos]} ");}
}
void FillArr (int[] array)
{   int length = array.Length;
        for (int i=0; i<length; i++){
        array[i] = int.Parse(Console.ReadLine());}
} 
Console.WriteLine("Введите число элементов");
int len = int.Parse(Console.ReadLine());

int[] massiv = new int [len];
Console.WriteLine("Введите элементы");
FillArr(massiv);

for (int j=0; j<massiv.Length; j++)
{   if (massiv[j]==20) 
       {massiv[j]=200;
        break;}
}
Console.WriteLine();
PrintArray(massiv);




