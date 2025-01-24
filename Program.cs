using System.Diagnostics;

static void Swap(ref int a, ref int b){
    int temp = a;
    a = b;
    b = temp;
}

void Bubble( ref int[] arr){
    for (int i = 0; i < arr.Length-1; i++)
    {
        for (int j = 0; j < arr.Length-1-i; j++)
        {
            if(arr[j]>arr[j+1]){
                Swap(ref arr[j], ref arr[j+1]);
            }
        }
    }
}

void Insertion(ref int[] arr){
    for (int i = 1; i < arr.Length; i++)
    {
        int key = arr[i];
        int j = i-1;

        while(j>=0 && arr[j] > key){
            arr[j+1] = arr[j];
            j--;
        }
        arr[j+1] = key;
    }
}

static void Merge(int[] arr, int l, int m, int r)
    {
        int n1 = m - l + 1;
        int n2 = r - m;

        int[] L = new int[n1];
        int[] R = new int[n2];
        int i, j;

        for (i = 0; i < n1; ++i)
            L[i] = arr[l + i];
        for (j = 0; j < n2; ++j)
            R[j] = arr[m + 1 + j];

        i = 0;
        j = 0;

        int k = l;
        while (i < n1 && j < n2) {
            if (L[i] <= R[j]) {
                arr[k] = L[i];
                i++;
            }
            else {
                arr[k] = R[j];
                j++;
            }
            k++;
        }

        while (i < n1) {
            arr[k] = L[i];
            i++;
            k++;
        }


        while (j < n2) {
            arr[k] = R[j];
            j++;
            k++;
        }
    }

    static void MergeSort(int[] arr, int l, int r)
    {
        if (l < r) {

            int m = l + (r - l) / 2;

            MergeSort(arr, l, m);
            MergeSort(arr, m + 1, r);

            Merge(arr, l, m, r);
        }
    }


static int Partition(int[] arr, int l, int h){
    int p = arr[h];

    int i = l-1;

    for (int j = l; j <= h-1; j++)
    {
        if(arr[j]<p){
            i++;
            Swap2(arr, i, j);
        }
    }

    Swap2(arr, i+1, h);
    return i+1;
}

static void Swap2(int[] arr, int i, int j){
    int temp = arr[i];
    arr[i] = arr[j];
    arr[j] = temp;
}

static void Quick(int[] arr, int l, int h){
    if(l<h){
        int pi = Partition(arr, l, h);

        Quick(arr, l, pi-1);
        Quick(arr, pi+1, h);
    }
}

void Main()
{
    Stopwatch watch = new Stopwatch();
    int[] tal = new int[10];
    for (int i = 0; i <= tal.Length-1; i++)
    {
        Random rng = new Random();
        tal[i] = rng.Next(0, 1000000);
    }
    watch.Start();
    MergeSort(tal, 0, tal.Length-1);
    watch.Stop();
    foreach(int n in tal){
        Console.Write(n + " ");
    }
    
    TimeSpan ts = watch.Elapsed;
    Console.WriteLine("\n" + ts);
    

}
Main();