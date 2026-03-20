//Đếm số lần xuất hiện của từng phần tử trong mảng
Console.Write("Nhap so phan tu cua mang: ");
int n = int.Parse(Console.ReadLine());
int[] mang = new int[n];

for (int i=0; i<n; i++)
{
    Console.Write($"Nhap phan tu {i}: ");
    mang[i] = int.Parse(Console.ReadLine());
}

for (int i=0; i<n; i++)
{
    int count = 0;
    for (int j=0; j<n; j++)
    {
        if (mang[i] == mang[j] )
        {
            count++;
        }
    }
    Console.WriteLine($"So lan xuat hien cua so {mang[i]} la {count} lan");
}