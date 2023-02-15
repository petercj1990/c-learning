static string ToBinary(int value){
    return Convert.ToString(value, toBase: 2).PadLeft(8, '0');
}
var a = 10;
var b = 6;
WriteLine();
WriteLine("Outputting intergers as binary");
WriteLine($"a = {ToBinary(a)}");
WriteLine($"b = {ToBinary(b)}");
WriteLine($"a & b = {ToBinary(a & b)}");
WriteLine($"a | b = {ToBinary(a | b)}");
WriteLine($"a ^ b = {ToBinary(a ^ b)}");