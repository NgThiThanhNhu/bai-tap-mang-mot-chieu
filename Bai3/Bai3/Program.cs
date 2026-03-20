
Console.Write("Nhap so phan tu cua mang 1: ");
int n = int.Parse(Console.ReadLine());
int[] arr1 = new int[n];

for (int i=0; i<n; i++)
{
    Console.Write($"Phan tu {i}: ");
    arr1[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Nhap so phan tu cua mang 2: ");
int m = int.Parse(Console.ReadLine());
int[] arr2 = new int[m];
for (int j = 0; j<m; j++)
{
    Console.Write($"Phan tu {j}: ");
    arr2[j] = int.Parse(Console.ReadLine());
}
int s3 = n + m;
int[] arr3 = new int[s3];
for (int i=0; i<n; i++)
{
    arr3[i] = arr1[i];
}
for (int j = 0; j<m; j++)
{
    arr3[n + j] = arr2[j];
}

for (int k = 0; k<s3; k++)
{
    for (int l = k +1; l<s3; l++)
    {
        if (arr3[k] > arr3[l])
        {
            int temp = arr3[k];
            arr3[k] = arr3[l];
            arr3[l] = temp;
        }
    }
}
Console.WriteLine("Mang arr3 da sap xep la");
for (int k=0; k<s3; k++)
{
    Console.Write($"{arr3[k]} ");
}