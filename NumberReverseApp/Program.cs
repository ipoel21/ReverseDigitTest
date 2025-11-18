string input;
do
{
    Console.Write("Masukan Angka untuk direverse: ");
    input = Console.ReadLine();
    if (!input.All(x => (x >= 48 && x <= 57) || x == 44 || x == 46))
    {
        Console.WriteLine("Input Tidak Valid. Bisa dicoba kembali");
        continue;
    }
    input = input.Replace(",", "").Replace(".", "");
    var inputReverse = "";
    for (int i = 1; i <= input.Length; i++)
    {
        inputReverse += input[input.Length - i];
    }
    var intInput = int.Parse(input);
    var intInputReverse = int.Parse(inputReverse);

    int Difference;
    if (intInput > intInputReverse)
    {
        Difference = intInput - intInputReverse;
    }
    else
    {
        Difference = intInputReverse - intInput;
    }
    Console.WriteLine("====================Hasil===============");
    Console.WriteLine($"Input : {intInput}");
    Console.WriteLine($"Reverse : {intInputReverse}");
    Console.WriteLine($"Difference : {Difference}");
    Console.WriteLine("=========================================");

} while (!string.IsNullOrEmpty(input));

