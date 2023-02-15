uint naturalNumber = 23;
int intergernumber = -23;
float realBumber = 2.3F;
double anotherRealNmber = 2.3;
int decimalnotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
int hexNotation = 0x_001E_8480;

Console.WriteLine($"{decimalnotation== binaryNotation }");

Console.WriteLine($"{decimalnotation== hexNotation }");


double a = 0.1;
double b = 0.2;
if (a + b == 0.3){
    Console.WriteLine($"{a} + {b} equals {0.3}");
}
if (a + b != 0.3){
    Console.WriteLine($"{a} + {b} does not equal {0.3}");
}