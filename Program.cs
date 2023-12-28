Console.Write("Insert number: ");
int N = int.Parse(Console.ReadLine());
for (int i = 2; i <= N; i++)
 {
    if (i % 2 == 0)
     {
       Console.WriteLine(i);
     }
 }