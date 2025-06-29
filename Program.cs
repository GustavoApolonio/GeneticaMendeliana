string ind1, ind2, dominancia;
string repetir;

do
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("--- Genética Mendeliana ---");
    Console.ResetColor();

    Console.Write("Alelos do indivíduo 1 (AA, Aa ou aa)...: ");
    ind1 = Console.ReadLine()!;

    Console.Write("Alelos do indivíduo 2 (AA, Aa ou aa)...: ");
    ind2 = Console.ReadLine()!;

    Console.Write("Tipo de dominância (C/I)...............: ");
    dominancia = Console.ReadLine()!.ToUpper();
    Console.WriteLine();

    if ((ind1 == "AA" || ind1 == "Aa" || ind1 == "aa") &&
        (ind2 == "AA" || ind2 == "Aa" || ind2 == "aa") &&
        (dominancia == "C" || dominancia == "I"))
    {
        switch (ind1)
        {
            case "Aa":
                Console.WriteLine(@"  | A  |  a");
                if (ind2 == "aa")
                {
                    Console.WriteLine(@"-----------
a | Aa | aa
-----------
a | Aa | aa");
                    if (dominancia == "C")
                    {
                        Console.WriteLine(@"
AA:   0% - não apresenta a característica recessiva
Aa:  50% - não apresenta a característica recessiva
aa:  50% - apresenta a característica recessiva
");
                    }
                    else
                    {
                        Console.WriteLine(@"
AA:  0% - apresenta a característica de A
Aa:  50% - apresenta característica distinta de A e de a
aa:  50% - apresenta a característica de a
");
                    }
                }
                else if (ind2 == "Aa")
                {
                    Console.WriteLine(@"-----------
A | AA | Aa
-----------
a | Aa | aa");
                    if (dominancia == "C")
                    {
                        Console.WriteLine(@"
AA:   25% - não apresenta a característica recessiva
Aa:  50% - não apresenta a característica recessiva
aa:  25% - apresenta a característica recessiva
");
                    }
                    else
                    {
                        Console.WriteLine(@"
AA:  25% - apresenta a característica de A
Aa:  50% - apresenta característica distinta de A e de a
aa:  25% - apresenta a característica de a
");
                    }
                }
                else if (ind2 == "AA")
                {
                    Console.WriteLine(@"-----------
A | AA | Aa
-----------
A | AA | Aa");
                    if (dominancia == "C")
                    {
                        Console.WriteLine(@"
AA:   50% - não apresenta a característica recessiva
Aa:  50% - não apresenta a característica recessiva
aa:  0% - apresenta a característica recessiva
");
                    }
                    else
                    {
                        Console.WriteLine(@"
AA:  50% - apresenta a característica de A
Aa:  50% - apresenta característica distinta de A e de a
aa:  0% - apresenta a característica de a
");
                    }
                }
                break;

            case "AA":
                Console.WriteLine(@"  | A  |  A");
                if (ind2 == "aa")
                {
                    Console.WriteLine(@"-----------
a | Aa | Aa
-----------
a | Aa | Aa");
                    if (dominancia == "C")
                    {
                        Console.WriteLine(@"
AA:   0% - não apresenta a característica recessiva
Aa:  100% - não apresenta a característica recessiva
aa:  0% - apresenta a característica recessiva
");
                    }
                    else
                    {
                        Console.WriteLine(@"
AA:  0% - apresenta a característica de A
Aa:  100% - apresenta característica distinta de A e de a
aa:  0% - apresenta a característica de a
");
                    }
                }
                else if (ind2 == "Aa")
                {
                    Console.WriteLine(@"-----------
A | AA | AA
-----------
a | Aa | Aa");
                    if (dominancia == "C")
                    {
                        Console.WriteLine(@"
AA:   50% - não apresenta a característica recessiva
Aa:  50% - não apresenta a característica recessiva
aa:  0% - apresenta a característica recessiva
");
                    }
                    else
                    {
                        Console.WriteLine(@"
AA:  50% - apresenta a característica de A
Aa:  50% - apresenta característica distinta de A e de a
aa:  0% - apresenta a característica de a
");
                    }
                }
                else if (ind2 == "AA")
                {
                    Console.WriteLine(@"-----------
A | AA | AA
-----------
A | AA | AA");
                    if (dominancia == "C")
                    {
                        Console.WriteLine(@"
AA:   100% - não apresenta a característica recessiva
Aa:  0% - não apresenta a característica recessiva
aa:  0% - apresenta a característica recessiva
");
                    }
                    else
                    {
                        Console.WriteLine(@"
AA:  100% - apresenta a característica de A
Aa:  0% - apresenta característica distinta de A e de a
aa:  0% - apresenta a característica de a
");
                    }
                }
                break;

            case "aa":
                Console.WriteLine(@"  | a  |  a");
                if (ind2 == "aa")
                {
                    Console.WriteLine(@"-----------
a | aa | aa
-----------
a | aa | aa");
                    if (dominancia == "C")
                    {
                        Console.WriteLine(@"
AA:   0% - não apresenta a característica recessiva
Aa:  0% - não apresenta a característica recessiva
aa:  100% - apresenta a característica recessiva
");
                    }
                    else
                    {
                        Console.WriteLine(@"
AA:  0% - apresenta a característica de A
Aa:  0% - apresenta característica distinta de A e de a
aa:  100% - apresenta a característica de a
");
                    }
                }
                else if (ind2 == "Aa")
                {
                    Console.WriteLine(@"-----------
A | Aa | Aa
-----------
a | aa | aa");
                    if (dominancia == "C")
                    {
                        Console.WriteLine(@"
AA:   0% - não apresenta a característica recessiva
Aa:  50% - não apresenta a característica recessiva
aa:  50% - apresenta a característica recessiva
");
                    }
                    else
                    {
                        Console.WriteLine(@"
AA:  0% - apresenta a característica de A
Aa:  50% - apresenta característica distinta de A e de a
aa:  50% - apresenta a característica de a
");
                    }
                }
                else if (ind2 == "AA")
                {
                    Console.WriteLine(@"-----------
A | Aa | Aa
-----------
A | Aa | Aa");
                    if (dominancia == "C")
                    {
                        Console.WriteLine(@"
AA:   0% - não apresenta a característica recessiva
Aa:  100% - não apresenta a característica recessiva
aa:  0% - apresenta a característica recessiva
");
                    }
                    else
                    {
                        Console.WriteLine(@"
AA:  0% - apresenta a característica de A
Aa:  100% - apresenta característica distinta de A e de a
aa:  0% - apresenta a característica de a
");
                    }
                }
                break;
        }
    }
    else
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(@"Entrada inválida! Certifique-se de usar AA, Aa, aa e tipo C ou I.
");
        Console.ResetColor();
    }

    Console.Write("Deseja executar novamente? (S/N): ");
    repetir = Console.ReadLine()!.ToUpper();

} while (repetir == "S");
