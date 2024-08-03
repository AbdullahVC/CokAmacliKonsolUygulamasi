using System;
using System.Threading;

Console.Write("Uygulama Açılıyor Lütfen Bekleyiniz: [");
for (int i = 0; i < 25; i++)
{
    Console.Write("=");
    Thread.Sleep(75); // To slow down.
}
Console.WriteLine("]");

Console.WriteLine("╔════════════════════════════════════════════════════════╗");
Console.WriteLine("║                                                        ║");
Console.WriteLine("║   Merhaba Çok Amaçlı Konsol Uygulamamıza Hoşgeldiniz ! ║");
Console.WriteLine("║                                                        ║");
Console.WriteLine("╚════════════════════════════════════════════════════════╝");
Console.WriteLine(" ");

bool toContinue = true;

while (toContinue)
{
    Console.WriteLine(" ");
    Console.WriteLine("Hangi programı çalıştırmak istersiniz ?\n(Lütfen bir sayı seçin.)\n1 - Rastgele Sayı Bulma Oyunu      4 - Yakında Gelecek\n2 - Hesap Makinesi                 5 - Yakında Gelecek\n3 - Ortalama Hesaplama             6 - Yakında Gelecek\n0 - Çıkış");
    Console.WriteLine(" ");
    // Program selection phase
    string input = Console.ReadLine();
    int choice;
    bool isNumeric = int.TryParse(input, out choice);

    if (!isNumeric)
    {
        Console.WriteLine("Geçersiz giriş. Lütfen bir sayı giriniz.");
        continue;
    }
    switch (choice)
    {
        case 0:
            toContinue = false;
            break;
        case 1:
            RandomNumberFindingGame();
            break;
        case 2:
            Calculator();
            break;
        case 3:
            GradeCalculator();
            break;
        case 4:
        case 5:
        case 6:
            Console.WriteLine("Programımız henüz hazır değil.");
            break;

        default:
            Console.WriteLine("Tanımlanmamış bir giriş yaptınız.");
            break;
    }
    if (!toContinue)
    {
        break;
    }
    //Here we add lines to give the user a choice to exit or continue the application.
    Console.WriteLine(" ");
    Console.Write("Başka bir uygulama seçmek ister misiniz? (Evet için 'E', Hayır için 'H' girin)");
    char answer = Convert.ToChar(Console.ReadLine().ToUpper());

    if (answer == 'H')
    {
        toContinue = false;
    }
}
Console.WriteLine("");
Console.WriteLine("Programdan çıkılıyor. İyi günler!");
Console.WriteLine("");


//Random Number Finding Game
void RandomNumberFindingGame()
{
    Random rnd = new Random();
    int ranNum = rnd.Next(1, 101);
    int guess;
    int life = 5;
    //Here we explain the gameplay.
    Console.WriteLine("Rastgele Sayı Bulma Oyununa Hoşgeldiniz");
    Console.WriteLine("Oyunumuzun oynanış şekli:");
    Console.WriteLine("1. Bilgisayar 1-100 arasında rastgele bir sayı seçer.");
    Console.WriteLine("2. Sizden bir sayıyı tahmin etmenizi ister.");
    Console.WriteLine("3. Bilgisayar daha yüksek mi, daha düşük mü olduğunu söyler.");
    Console.WriteLine("4. 5 tahmin hakkınınız var.");
    Console.WriteLine("5. Doğru tahmin ederseniz kazanırsın.");
    Console.WriteLine("6. 5 hakkınınız dolarsa, doğru sayı gösterilir ve oyun biter.");


    while (life > 0)
    {
        Console.WriteLine(" ");
        Console.Write("Tahmininiz: ");
        string input = Console.ReadLine();//Here we add some lines to check if the user uses numbers or not.

        bool isNumeric = int.TryParse(input, out guess);

        if (isNumeric)
        {
            if (guess < ranNum)//Here we respond the user for his answers.
            {
                Console.WriteLine("Daha yüksek bir sayı girin.");
            }
            else if (guess > ranNum)
            {
                Console.WriteLine("Daha düşük bir sayı girin.");
            }
            else
            {
                Console.WriteLine("Tebrikler! Doğru tahmin ettiniz.");
                return;
            }
        }
        else
        {
            Console.WriteLine("Geçersiz giriş. Lütfen bir sayı giriniz.");
        }

        life--;
        Console.WriteLine($"Kalan tahmin hakkınız: {life}");
    }

    Console.WriteLine($"Tahmin hakkınız doldu. Doğru sayı {ranNum} idi.");
}



//Calculator
void Calculator()
{
    Console.WriteLine("Hesap Makinesi\nİlk sayıyı girin: Örneğin, 12.\nİkinci sayıyı girin: Örneğin, 8.\nİşlemi seçin: Toplama için +, Çıkarma için -, Çarpma için *, Bölme için /.\nSonucu görün: Hesaplama sonucu ekranda gösterilecektir.");
    Console.WriteLine(" ");
    double num1;
    //Here we add some lines to check the users answers
    while (true)
    {
        Console.Write("İlk sayıyı girin: ");
        if (double.TryParse(Console.ReadLine(), out num1))
        {
            break;
        }
        else
        {
            Console.WriteLine("Geçersiz giriş. Lütfen bir sayı giriniz.");
        }
    }

    double num2;
    //Here we add some lines to check the users answers
    while (true)
    {
        Console.Write("İkinci sayıyı girin: ");
        if (double.TryParse(Console.ReadLine(), out num2))
        {
            break;
        }
        else
        {
            Console.WriteLine("Geçersiz giriş. Lütfen bir sayı giriniz.");
        }
    }

    char transaction;
    //Here we add some lines to check the users answers
    while (true)
    {
        Console.Write("Yapmak istediğiniz işlemi seçin (+, -, *, /): ");
        if (char.TryParse(Console.ReadLine(), out transaction) && (transaction == '+' || transaction == '-' || transaction == '*' || transaction == '/'))
        {
            break;
        }
        else
        {
            Console.WriteLine("Geçersiz işlem. Lütfen +, -, * veya / giriniz.");
        }
    }
    double conclusion = 0;
    bool currentTransaction = true;

    switch (transaction)
    {
        case '+':
            conclusion = num1 + num2;
            break;
        case '-':
            conclusion = num1 - num2;
            break;
        case '*':
            conclusion = num1 * num2;
            break;
        case '/':
            if (num2 != 0)
            {
                conclusion = num1 / num2;
            }
            else
            {
                Console.WriteLine("Hata: Sıfıra bölme hatası!");
                currentTransaction = false;
            }
            break;
        default:
            Console.WriteLine("Geçersiz işlem.");
            currentTransaction = false;
            break;
    }

    if (currentTransaction)
    {
        Console.WriteLine($"Sonuç: {conclusion}");
    }
}

//Grade Calculator
void GradeCalculator()
{
    Console.WriteLine("Ortalama Hesaplama");
    Console.WriteLine("Uygulamamız sizden üç not girmenizi isteyecek.\nUygulama notların ortalamısını alıp size hem Not Ortalamanızı hemde Harf notunuzu verecek.");

    double not1, not2, not3;
    //Here we add some lines to check the users answers
    while (true)
    {
        Console.Write("Birinci ders notunu girin: ");
        if (double.TryParse(Console.ReadLine(), out not1) && not1 >= 0 && not1 <= 100)
        {
            break;
        }
        else
        {
            Console.WriteLine("Geçersiz giriş. Notlar 0 ile 100 arasında olmalıdır.");
        }
    }

    while (true)
    {
        Console.Write("İkinci ders notunu girin: ");
        if (double.TryParse(Console.ReadLine(), out not2) && not2 >= 0 && not2 <= 100)
        {
            break;
        }
        else
        {
            Console.WriteLine("Geçersiz giriş. Notlar 0 ile 100 arasında olmalıdır.");
        }
    }

    while (true)
    {
        Console.Write("Üçüncü ders notunu girin: ");
        if (double.TryParse(Console.ReadLine(), out not3) && not3 >= 0 && not3 <= 100)
        {
            break;
        }
        else
        {
            Console.WriteLine("Geçersiz giriş. Notlar 0 ile 100 arasında olmalıdır.");
        }
    }


    double ortalama = (not1 + not2 + not3) / 3;
    Console.WriteLine($"Ortalama: {ortalama}");
    //Here we added the lines where the letter grades will be determined.
    string harfNotu;

    if (ortalama >= 90)
        harfNotu = "AA";
    else if (ortalama >= 85)
        harfNotu = "BA";
    else if (ortalama >= 80)
        harfNotu = "BB";
    else if (ortalama >= 75)
        harfNotu = "CB";
    else if (ortalama >= 70)
        harfNotu = "CC";
    else if (ortalama >= 65)
        harfNotu = "DC";
    else if (ortalama >= 60)
        harfNotu = "DD";
    else if (ortalama >= 55)
        harfNotu = "FD";
    else
        harfNotu = "FF";

    Console.WriteLine($"Harf Notu: {harfNotu}");
}




