
void PrintArray (int[] arr)
{   int count = arr.Length;
    int pos=0;
    while (pos<count)
        {Console.Write($"{arr[pos]} ");
        pos++;}
}
void FillArr (int[] array)
{   int length = array.Length;
        for (int i=0; i<length; i++){
        array[i] = new Random().Next(100,999);}
} 

Console.WriteLine("Введите число элементов массива");
int len = int.Parse(Console.ReadLine());

int[] massiv = new int [len];
FillArr(massiv);
PrintArray(massiv);

int KolichestvoChetnih(int[] array){
int kol=0;
for (int j=0; j<array.Length; j++){
    if (array[j]%2==0) kol++;}
return kol;
}
Console.WriteLine();
Console.WriteLine("количество чётных чисел = "+KolichestvoChetnih(massiv));




