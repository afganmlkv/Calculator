// See https://aka.ms/new-console-template for more information
int nomre = 1;
Console.WriteLine($"Emeliyyat No: {nomre}");
double eded1 = 0;
double eded2 = 0;
double netice = 0;
string emeliyyat;
ed1Assign();
ed2Assign();
emel();
hesablama();


void ed1Assign()
{
    Console.Write("1-ci ededi daxil et: ");
    eded1 = Convert.ToDouble(Console.ReadLine());
}

void ed2Assign()
{
    Console.Write("2-ci ededi daxil et: ");
    eded2 = Convert.ToDouble(Console.ReadLine());
}

void emel()
{
    Console.Write("Emeliyyati daxil et: ");
    emeliyyat = Console.ReadLine();
}


double toplama(double ed1, double ed2)
{
    double cavab;
    cavab = ed1 + ed2;
    return cavab;
}

double chixma(double ed1, double ed2)
{
    double cavab;
    cavab = ed1 - ed2;
    return cavab;
}
double vurma(double ed1, double ed2)
{
    double cavab;
    cavab = ed1 * ed2;
    return cavab;
}
double bolme(double ed1, double ed2)
{
    double cavab;
    cavab = ed1 / ed2;
    return cavab;
}

void hesablama()
{
    //    if (emeliyyat == "+")
    //    {
    //        netice = toplama(eded1, eded2);
    //        Console.WriteLine($"Cavab: {netice} \n");
    //    }
    //    else
    //    {
    //        if (emeliyyat == "-")
    //        {
    //            netice = chixma(eded1, eded2);
    //            Console.WriteLine($"Cavab: {netice} \n");
    //        }
    //        else
    //        {
    //            if (emeliyyat == "*")
    //            {
    //                netice = vurma(eded1, eded2);
    //                Console.WriteLine($"Cavab: {netice} \n");
    //            }
    //            else
    //            {
    //                if (emeliyyat == "/")
    //                {
    //                    netice = bolme(eded1, eded2);
    //                    Console.WriteLine($"Cavab: {netice} \n");
    //                }
    //                else
    //                {
    //                    if (emeliyyat == "%")
    //                    {
    //                        Console.WriteLine("979");
    //                    }
    //                    else
    //                    {
    //                        Console.WriteLine("Emeliyyati duzgun daxil edin");
    //                        emel();
    //                        hesablama();
    //                    }


    //                }
    //            }
    //        }
    //    }




    //if (emeliyyat == "+")
    //{
    //    netice = toplama(eded1, eded2);
    //    Console.WriteLine($"Cavab: {netice} \n");
    //}
    //else if (emeliyyat == "-")
    //{
    //    netice = chixma(eded1, eded2);
    //    Console.WriteLine($"Cavab: {netice} \n");
    //}
    //else if (emeliyyat == "*")
    //{
    //    netice = vurma(eded1, eded2);
    //    Console.WriteLine($"Cavab: {netice} \n");
    //}
    //else if (emeliyyat == "/")
    //{
    //    netice = bolme(eded1, eded2);
    //    Console.WriteLine($"Cavab: {netice} \n");
    //}
    //else if (emeliyyat == "%")
    //{

    //}
    //else
    //{
    //    Console.WriteLine("Emeliyyati duzgun daxil edin");
    //    emel();
    //    hesablama();
    //}





    //if (emeliyyat == "+")
    //{
    //    netice = toplama(eded1, eded2);
    //    Console.WriteLine($"Cavab: {netice} \n");
    //}
    //if (emeliyyat == "-")
    //{
    //    netice = chixma(eded1, eded2);
    //    Console.WriteLine($"Cavab: {netice} \n");
    //}
    //if (emeliyyat == "*")
    //{
    //    netice = vurma(eded1, eded2);
    //    Console.WriteLine($"Cavab: {netice} \n");
    //}

    //if (emeliyyat == "/")
    //{
    //    netice = bolme(eded1, eded2);
    //    Console.WriteLine($"Cavab: {netice} \n");
    //}


    //if (emeliyyat != "+" && emeliyyat != "-" && emeliyyat != "*" && emeliyyat != "/")
    //{
    //    Console.WriteLine("Emeliyyati duzgun daxil edin");
    //    emel();
    //    hesablama();
    //}


    switch (emeliyyat)
{
    case "+":
        netice = toplama(eded1, eded2);
        Console.WriteLine($"Cavab: {netice} \n");
        break;
    case "-":
        netice = chixma(eded1, eded2);
        Console.WriteLine($"Cavab: {netice} \n");
        break;
    case "*":
        netice = vurma(eded1, eded2);
        Console.WriteLine($"Cavab: {netice} \n");
        break;
    case "/":
        netice = bolme(eded1, eded2);
        Console.WriteLine($"Cavab: {netice} \n");
        break;
    default:
        Console.WriteLine("Emeliyyati duzgun daxil edin");
        emel();
        hesablama();
        break;
}
nomre++;
davam();
}

void davam()
{
    Console.WriteLine($"Emeliyyat No: {nomre}");
    ed1Assign();
    ed2Assign();
    emel();
    hesablama();
}



