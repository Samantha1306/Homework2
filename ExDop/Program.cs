// Задача необязательная 2:

// В институте биоинформатики по офису передвигается робот. Недавно студенты из группы программистов написали для него программу, по которой робот, когда заходит в комнату, считает количество программистов в ней и произносит его вслух: "n программистов".

// Для того, чтобы это звучало правильно, для каждого n нужно использовать верное окончание слова.

// Напишите программу, считывающую с пользовательского ввода целое число n (неотрицательное), выводящее это число в консоль вместе с правильным образом изменённым словом "программист", для того, чтобы робот мог нормально общаться с людьми, например: 1 программист, 2 программиста, 5 программистов.

// В комнате может быть очень много программистов. Проверьте, что ваша программа правильно обработает все случаи, как минимум до 1000 человек. Для самопроверки прогоните цикл от 1 до 30 например.

int x = new Random().Next(1,10000);
Console.WriteLine($"Сгенерировано случайное число: {x}");
int lastnumber = x % 10;
int twolastnumbers = x % 100;
if (lastnumber == 1) 
{
    if (twolastnumbers == 11) Console.WriteLine($"В комнате {x} программистов.");
    else Console.WriteLine($"В комнате {x} программист.");
}
if (lastnumber == 2 || lastnumber == 3 || lastnumber == 4)
{
    if (twolastnumbers == 12 || twolastnumbers == 13 || twolastnumbers == 14) Console.WriteLine($"В комнате {x} программистов.");
    else Console.WriteLine($"В комнате {x} программиста.");
}
if (lastnumber == 0 || lastnumber >= 5 && lastnumber <= 9) Console.WriteLine($"В комнате {x} программистов.");