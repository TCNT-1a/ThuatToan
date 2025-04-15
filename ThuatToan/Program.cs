// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] a = { 1, 2, 3, 5, 4, 5 };
int soLonNhat;
int pSoLonNhat;
int soLonNhi;
int pSoLonNhi;
soLonNhat = a[0];
pSoLonNhat = 0;
soLonNhi = a[0];
pSoLonNhi = 0;
for (int i =0; i<a.Length; i++)
{


    if (a[i] > soLonNhat)
    {
        soLonNhi = soLonNhat;
        pSoLonNhi = pSoLonNhat;
        soLonNhat = a[i];
        pSoLonNhat = i;  
    }
    else
    {
        if(a[i] > soLonNhi)
        {
            soLonNhi = a[i];
            pSoLonNhi = i;
        }
       
    }
}
Console.WriteLine($"So lon nhat la {soLonNhat} tai vi tri {pSoLonNhat}");
Console.WriteLine($"So lon nhi la {soLonNhi} tai vi tri {pSoLonNhi}");
