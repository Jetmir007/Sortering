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

void Merge(ref int[] arr, int l, int r){
    
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
    Bubble(ref tal);
    
    foreach(int n in tal){
        Console.Write(n + " ");
    }
    watch.Stop();
    TimeSpan ts = watch.Elapsed;
    Console.WriteLine("\n" + ts);
    

}
Main();