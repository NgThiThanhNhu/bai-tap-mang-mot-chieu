//Đọc và in các phần tử mảng
Console.Write("Nhap so phan tu cua mang: ");
int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
for (int i=0; i<n; i++)
{
    Console.WriteLine($"Nhap phan tu thu {i}");
    arr[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Mang vua nhap");
for (int i=0; i<n; i++)
{
    Console.WriteLine(arr[i]);
}
Console.WriteLine("Mang dao chieu");
//In mảng theo chiều đảo ngược
for (int j= n-1; j>=0; j--)
{
    Console.WriteLine(arr[j]);
}
//Tìm tổng các phần tử của mảng
int sum = 0;
for (int i=0; i<n; i++)
{
    sum += arr[i];
}
Console.WriteLine($"Tong cac phan tu trong mang la {sum}");

//sao chép mảng

Console.Write("Nhap so phan tu cua mang: ");
int l = int.Parse(Console.ReadLine()); 

int[] arrsaochep = new int[l];
int[] array = new int[l];
Console.WriteLine("Nhap mang goc");
for (int i=0; i<l; i++)
{
    Console.Write($"Nhap phan tu thu {i}: ");
    array[i] = int.Parse(Console.ReadLine());
    for (int j =0; j<=i; j++)
    {
        if (j == i)
        {
            arrsaochep[j] = array[i];
        }
    }
}
Console.WriteLine("Mang da sao chep");
for (int j=0; j<l; j++)
{
    Console.WriteLine($"phan tu thu {j} sao cheo tu mang arr[{j}] la: {arrsaochep[j]}");
}

//Tìm số phần tử giống nhau trong một mảng
Console.Write("Nhap so phan tu cua mang: ");
int m = int.Parse(Console.ReadLine());
int[] arrs = new int[m];
for (int i=0; i<m; i++)
{
    Console.Write($"Nhap phan tu thu {i}: ");
    arrs[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Mang vua nhap");
for (int i=0; i<m; i++)
{
    Console.WriteLine(arrs[i]);
}
int count = 0;
for (int i=0; i<m; i++)
{
    for (int j=i+1; j<m; j++)
    {
        if (arrs[i] == arrs[j])
        {
            count = count + 1; 
        }
    }
}

Console.WriteLine($"So phan tu thu i giong nhau la: {count}");
