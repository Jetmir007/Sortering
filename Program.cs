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

static void Merge(int[] arr, int l, int m, int r){
    int sub1 = m-1+1;
    int sub2 = r-m;

    int[] Left = new int[sub1];
    int[] Right = new int[sub2];
    int i, j;

    for (i = 0; i < sub1; i++)
    {
        Left[i] = arr[l+1];
    }
    for (j = 0; j < sub2; j++)
    {
        Right[j] = arr[m+1+j];
    }

    j = 0;
    i = 0;

    int k = 1;

while(i<sub1 && j<sub2){
    if (Left[i] <= Right[j]) {
            arr[k] = Left[i];
            i++;
        }
        else {
            arr[k] = Right[j];
            j++;
        }
    k++;
}

    while(i<sub1){
        arr[k] = Left[i];
        i++;
        k++;
    }

    while(j<sub2){
        arr[k] = Right[j];
        j++;
        k++;
    }
}

static void Mergesort(int[] arr, int l, int r){
    if(l<r){
        int m = l+(r-l) /2;
        Mergesort(arr, l, m);
        Mergesort(arr, m+1, r);

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
    int[] tal = new int[100000];
    for (int i = 0; i <= tal.Length-1; i++)
    {
        Random rng = new Random();
        tal[i] = rng.Next(0, 1000000);
    }
    watch.Start();
    Quick(tal, 0, tal.Length-1);
    watch.Stop();
    foreach(int n in tal){
        Console.Write(n + " ");
    }
    
    TimeSpan ts = watch.Elapsed;
    Console.WriteLine("\n" + ts);
    

}
Main();