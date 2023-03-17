Console.Write("Введите число N: ");
string N = Console.ReadLine();
int n = System.Convert.ToInt32(N);

int max_iter = n / 2;
int count = 1;
int output = 2;

if(max_iter > 0) Console.Write(output);
while(count < max_iter){
    output += 2;
    Console.Write(", ");
    Console.Write(output);
    count++;
}
Console.WriteLine();
