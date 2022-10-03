using System;
namespace array
{
    class Program
    {
        static void Main(string [] args){
            // Sort
            int[] sayiDizisi = {23,12,4,84,72,3,11,17};
            Console.WriteLine("**********Sırasız Dizi********");
            foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);

            Console.WriteLine("******Sıralı Dizi********");
            Array.Sort(sayiDizisi);

            foreach( var sayi in sayiDizisi)
            Console.WriteLine(sayi);


            //clear
            Console.WriteLine("********Array Clear*******");
            //sayi dizisini kullanarak 2. indexten itibaren 2 tane sıfırlar
            Array.Clear(sayiDizisi,2,2);
            
            foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);

            //Reserve
            Console.WriteLine("*****Array Reserve*******");
            Array.Reverse(sayiDizisi);

            foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);



        }
    }

} 