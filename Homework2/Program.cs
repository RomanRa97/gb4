int number = Convert.ToInt32(Console.ReadLine());
int counter = 0;

int lenght (int number)
{
    int num_len = 1;
    while ((number /= 10) >=1) ++num_len;
    return num_len;      
}
int len = lenght(number);

int [] array = new int[len];
int i = 0;
int tmp = number;

while (i<len)
{
    array[i] = tmp % 10;
    tmp = tmp / 10;
    if (array[i] != 0) 
        if (number % array[i] == 0) counter += array[i];
    i++;
}
Console.WriteLine(counter);