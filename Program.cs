
void PrintArray (double[] arr)
{   for (int pos=0; pos<arr.Length; pos++)
    {Console.Write($"{arr[pos]} ");}
}
void FillArr (double[] array)
{   int length = array.Length;
        for (int i=0; i<length; i++){
        array[i] = new Random().Next(0,100);}
} 

Console.WriteLine("Введите число элементов массива");
int len = int.Parse(Console.ReadLine());

double[] massiv = new double [len];
FillArr(massiv);
PrintArray(massiv);

double max=massiv[0];
double min=massiv[0];
for (int j=1; j<massiv.Length; j++){
    if (massiv[j]>max) max=massiv[j];
    if (massiv[j]<min) min=massiv[j];}
double Razniza=(max-min);

Console.WriteLine();
Console.WriteLine("разница между максимальным и минимальным элементом массива = "+Razniza);




