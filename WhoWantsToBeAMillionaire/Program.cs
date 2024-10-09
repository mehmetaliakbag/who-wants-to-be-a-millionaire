Console.WriteLine("Kim Milyoner Olmak İster'e hoşgeldiniz." +
                 "\nOyun çok basit, 3 sorudan 2'sine doğru cevap vermelisiniz" +
                 "Cevaplarınızı şık olarak belirtiniz, \nHadi başlıyalım...");


#region Question-1


// Kullanıcıya ilk soruyu sorup şıklardan birini seçmesini istiyoruz.
  
Console.Write("\nDünyanın en büyük okyanusu hangisidir?" +
              "\nA) Atlantik Okyanusu" +
              "\nB) Pasifik Okyanusu" +
              "\n" +
              "\nCevap: ");

string answer1 = Console.ReadLine();

int counter = 0;

answer1 = answer1.ToLower();



// Verilen cevabın doğru olup olmadığını kontrol ediyoruz. 

// Cevap doğru ise counter değişkenini bir arttırıyoruz.

if (answer1 == "b")
{
    Console.WriteLine("Tebrikler, doğru cevap verdiniz.");
    counter++;
}
else
{
    Console.WriteLine("Maalesef, yanlış cevap.");
}


#endregion

#region Question-2
  

// Kullanıcıya ilk soruyu sorup şıklardan birini seçmesini istiyoruz

Console.Write("\nHangi gezegen \"Kırmızı Gezegen\" olarak bilinir?" +
              "\nA) Mars" +
              "\nB) Venüs" +
              "\n" +
              "\nCevap: ");

string answer2 = Console.ReadLine();

answer2 = answer2.ToLower();



// Kullanıcının verdiği cevabın doğru olup olmadığını kontrol ediyoruz.

// Cevap doğru ise counter değişkenini bir arttırıyoruz.

// counter değişkeni 2'ye eşitse yarışmayı kazandığı için tebrik ediyoruz

// counter değişkeni 0 ise elendiği belirtiyoruz.

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



// counter değişkeni 1 ise yarışmacı 3.soruya doğru cevap verip hala büyük ödülü kazanabilir.

// Toplam doğru cevap sayısını kontrol edip koşul sağlanıyorsa 3. soruyu soruyoruz.

if (counter == 1)
{
    Console.Write("\nHangisi \"En Hızlı\" kara canlısıdır?" +
                  "\nA Aslan" +
                  "\nB) Çita" +
                  "\n" +
                  "\nCevap: ");

    string answer3 = Console.ReadLine();
  
    answer3 = answer3.ToLower();




  // Kullanıcının verdiği cevabın doğru olup olmadığını kontrol ediyoruz.

  // Cevap doğru ise counter değişkenini bir arttırıyoruz.

  // counter değişkeni 2'ye eşitse yarışmayı kazandığı için tebrik ediyoruz

  // Cevap yanlış ise elendiğini belirtiyoruz
  
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
