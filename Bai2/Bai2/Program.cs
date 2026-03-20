//tim phan tu duy nhat trong mang
Console.Write("Nhap so phan tu cua mang: ");
int n = int.Parse(Console.ReadLine());
int[] mang = new int[n];
for (int i=0; i<n; i++)
{
    Console.Write($"phan tu {i}: ");
    mang[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Phan tu duy nhat trong mang: ");
for (int i=0; i<n; i++)
{
    int count = 0;
    for (int j=i+1; j<n; j++)
    {
        if (mang[i] == mang[j])
        {
            count++;
        }
    }
    for (int k = i + 1; k < n; k++)
    {
        if (mang[i] == mang[k])
        {
            count++;
        }
    }
    if (count == 0)
    {
        Console.Write("{0} ", mang[i]);
    }
}