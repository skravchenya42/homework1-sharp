//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// ИНПУТ ДЛЯ ЦЕЛЫХ ЧИСЕЛ
uint  Input(string welcome)
{
    Console.Write(welcome);
    return Convert.ToUInt32(Console.ReadLine());
}

uint  AkkerMan(uint  M,uint  N)
{
    if (M==0) return (N+1);
    else if (M>0 && N==0) return AkkerMan(M-1,1);
    else return AkkerMan(M-1,AkkerMan(M,N-1));
}

uint  M = Input("M>0 = ");
uint  N = Input("N>0 = ");
if (M<0||N<0) Console.Write("нужны неотрицательные");
else Console.Write(AkkerMan(M,N));
