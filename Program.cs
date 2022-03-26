double tempf, tempc;

Console.Write("Digite a temperatura em graus Fahrenheit:");
tempf = Convert.ToDouble(Console.ReadLine());

tempc = (tempf - 32) / 1.8;


Console.WriteLine($"{tempf}°F equivalem a {tempc:N2}°C");
