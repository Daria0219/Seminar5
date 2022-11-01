
void PrintArray (int[] arr)
{   for (int pos=0; pos<arr.Length; pos++)
    {Console.Write($"{arr[pos]} ");}
}
void FillArr (int[] array)
{   int length = array.Length;
        for (int i=0; i<length; i++){
        array[i] = new Random().Next(-100,100);}
} 

Console.WriteLine("Введите число элементов массива");
int len = int.Parse(Console.ReadLine());

int[] massiv = new int [len];
FillArr(massiv);
PrintArray(massiv);

int SumNaNechetPos(int[] array){
int sum=0;
for (int j=1; j<array.Length; j=j+2){
    sum=sum+array[j];}
return sum;
}
Console.WriteLine();
Console.WriteLine("сумма элементов, стоящих на нечётных позициях = "+SumNaNechetPos(massiv));




