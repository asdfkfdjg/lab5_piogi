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

double del (int A, int B)
{
    return (double)A / (double)B;
}

bool flag1 = true;
bool flag2 = true;
while (flag1) {
    int number;
    Console.WriteLine("Введите А");
    string A_str = Console.ReadLine();
    bool success_A = int.TryParse(A_str, out number);
    int A;
    if (success_A)
    {
        A = int.Parse(A_str);
    }
    else 
    {
        Console.WriteLine("А должно быть целочисленным");
        continue;
    }
    Console.WriteLine("Введите B");
    string B_str = Console.ReadLine();
    bool success_B = int.TryParse(B_str, out number);

    int B;
    if (success_B)
    {
        B = int.Parse(B_str);
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
        Console.WriteLine("5. Выбрать другие числа");
        Console.WriteLine("Выберите операцию");
        string num_str = Console.ReadLine();
        bool success_num = int.TryParse(num_str, out number);
        if (success_num)
        {
            int num = int.Parse(num_str);
            int c;
            double c2;
            switch (num)
            {
                case 1:
                    c = sum(A, B);
                    Console.WriteLine($"{A} + {B} = {c}");
                    break;
                case 2:
                    c = minus(A, B);
                    Console.WriteLine($"{A} - {B} = {c}");
                    break;
                case 3:
                    c = umn(A, B);
                    Console.WriteLine($"{A} * {B} = {c}");
                    break;
                case 4:
                    c2= del(A,B);
                    Console.WriteLine($"{A} / {B} = {c2, 0:0.0}");
                    break;
                case 5:
                    flag2= false;
                    break;
            }
        }
        else
        {
            Console.WriteLine("Выберите из предложенных операций");
            continue;
        }

    }
}
