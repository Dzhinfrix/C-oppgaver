Console.WriteLine("enter number A");
uint A = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine("enter number B");
uint B = Convert.ToUInt32(Console.ReadLine());

void printNum(uint number) // при данной переменной если пишем ретерн то ничего не указыываем
{
 if(number < A)

    return;
 
    printNum(number - 1);
 
 Console.Write(number + " ");
}
printNum(B);
