//method tambah
int c = 0;

void tambah(int a, int b)
{
    c = a + b;
    Console.WriteLine($"{a} + {b} = {c}");
}
// method kurang
void kurang(int a, int b)
{
    c = a - b;
    Console.WriteLine($"{a} - {b} = {c}");
}
//method kali
void kali(int a, int b)
{
    c = a * b;
    Console.WriteLine($"{a} * {b} = {c}");
}
//method bagi
void bagi(int a, int b)
{
    c = a / b;
    Console.WriteLine($"{a} / {b} = {c}");
}

tambah(8,2);
kurang(5,2);
bagi(3,10);
kali(8,4);