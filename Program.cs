{
    int a = 1_500_000_000;
    int b = 1_500_000_000;

    int c = a + b;

    Console.WriteLine(c);
    Console.ReadLine();
}

{
    double a = 0.1;
    double b = 0.2;
    Console.WriteLine($"{a} + {b} = {a + b}");

    float num1 = 0.1F;
    float num2 = 0.2F;
    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");

    a = 17.3;
    b = 17;
    Console.WriteLine($"{a} - {b} = {a - b}");

    num1 = 17.3F;
    num2 = 17F;
    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
    Console.ReadLine();

    //Try the same in JavaScript the browser console 
    //console.log(0.1 + 0.2);
    //console.log(17.3 - 17);
}


