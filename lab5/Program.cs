using System;

int sum(int A, int B)
{
    return A + B;
}


int minus (int A, int B)
{
    return A - B;
}

int umn (int A, int B)
{
    return A * B;
}

bool flag1 = true;
bool flag2 = true;
while (flag1) {
    int number;
    Console.WriteLine("Введите А");
    string A_str = Console.ReadLine();
    bool success_A = int.TryParse(A_str, out number);
    if (success_A)
    {
        int A = int.Parse(A_str);
    }
    else 
    {
        Console.WriteLine("А должно быть целочисленным");
        continue;
    }
    Console.WriteLine("Введите B");
    string B_str = Console.ReadLine();
    bool success_B = int.TryParse(B_str, out number);
    if (success_B)
    {
        int B = int.Parse(B_str);
    }
    else
    {
        Console.WriteLine("B должно быть целочисленным");
        continue;
    }
    while (flag2)
    {
        Console.WriteLine("Меню операций:");
        Console.WriteLine("1. Сложение A+B");
        Console.WriteLine("2. Вычитание A-B");
        Console.WriteLine("3. Умножение A*B");
        Console.WriteLine("4. Деление A/B");
        flag1 = false;
        flag2 = false;
    }
}
