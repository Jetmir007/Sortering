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

        }
    }
}

void Main()
{
    int[] tal = new int[1000];
    for (int i = 0; i <= tal.Length-1; i++)
    {
        Random rng = new Random();
        tal[i] = rng.Next(0, 10000);
    }

    Bubble(ref tal);

    foreach(int n in tal){
        Console.Write(n + " ");
    }
}
Main();