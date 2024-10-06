Console.WriteLine("Kim Milyoner Olmak İster'e hoşgeldiniz." +
                 "\nOyun çok basit, 3 sorudan 2'sine doğru cevap vermelisiniz" +
                 "Cevaplarınızı şık olarak belirtiniz, \nHadi başlıyalım...");


Console.Write("\nDünyanın en büyük okyanusu hangisidir?" +
              "\nA) Atlantik Okyanusu" +
              "\nB) Pasifik Okyanusu" +
              "\n" +
              "\nCevap: ");

string answer1 = Console.ReadLine();
int counter = 0;

answer1 = answer1.ToLower();

if (answer1 == "b")
{
    Console.WriteLine("Tebrikler, doğru cevap verdiniz.");
    counter++;
}
else
{
    Console.WriteLine("Maalesef, yanlış cevap.");
}

Console.Write("\nHangi gezegen \"Kırmızı Gezegen\" olarak bilinir?" +
              "\nA) Mars" +
              "\nB) Venüs" +
              "\n" +
              "\nCevap: ");

string answer2 = Console.ReadLine();
answer2 = answer2.ToLower();

if (answer2 == "a")
{
    if (counter == 1)
    {
        Console.WriteLine("Tebrikler doğru cevap verdiniz.");
        Console.WriteLine("...");
        Console.WriteLine("\nYarışmayı kazandınız, artık milyonersiniz!");
        counter++;
    }
    else
    {
        Console.WriteLine("Tebrikler doğru cevap verdiniz.");
        counter++;
    }
}
else
{
    if (counter == 1)
    {
        Console.WriteLine("Maalesef, yanlış cevap.");
    }
    else
    {
        Console.WriteLine("Maalesef, yanlış cevap.");
        Console.WriteLine("...");
        Console.WriteLine("Elendiniz!");
    }
}

if (counter == 1)
{
    Console.Write("\nHangisi \"En Hızlı\" kara canlısıdır?" +
                  "\nA Aslan" +
                  "\nB) Çita" +
                  "\n" +
                  "\nCevap: ");

    string answer3 = Console.ReadLine();
    answer3 = answer3.ToLower();

    if (answer3 == "b")
    {
        Console.WriteLine("Tebrikler doğru cevap verdiniz.");
        Console.WriteLine("...");
        Console.WriteLine("\nYarışmayı kazandınız, artık milyonersiniz!");
        counter++;
    }
    else
    {
        Console.WriteLine("Maalesef, yanlış cevap.");
        Console.WriteLine("...");
        Console.WriteLine("Elendiniz!");
    }

}