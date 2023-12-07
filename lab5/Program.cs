using System;

bool flag1 = true;
bool flag2 = true;
while (flag1) {
    Console.WriteLine("Введите А");
    Console.WriteLine("Введите B");
    while(flag2)
    {
        Console.WriteLine("Меню операций:");
        Console.WriteLine("1. Сложение A+B");
        Console.WriteLine("2. Вычитание A-B");
        Console.WriteLine("3. Умножение A*B");
        Console.WriteLine("4. Деление A/B");
        flag1 = false;
        flag2 = false;
    }
};
