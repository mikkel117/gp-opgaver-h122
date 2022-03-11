using static System.Console;

int Sizeof = sizeof(int);
/*int.MaxValue*/
WriteLine($"int er {Sizeof} bytes stor");
WriteLine($"int kan holde {int.MaxValue} værdier");
DiagramOfDataTypsSize();


void DiagramOfDataTypsSize()
{
    for (int i = 0; i < Sizeof; i++)
    {
        WriteLine("|------------|");
        WriteLine("|            |");
        WriteLine("|   1 byet   |");
        WriteLine("|            |");
        WriteLine("|------------|");

        WriteLine(" ");
    }
}
