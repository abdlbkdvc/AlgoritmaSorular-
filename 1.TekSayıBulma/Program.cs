


// input'un modunu alırım eğer tek ise input % 2 != 0
//eğer çift ise input % 2 == 0
//


int sayi = 123;


 void TekSayıBulanMetot(int sayi)
{
    if(sayi % 2 == 0)
        Console.WriteLine("Bu sayi çifttir");
    else
        Console.WriteLine("Bu sayı tektir");
}

TekSayıBulanMetot(sayi);