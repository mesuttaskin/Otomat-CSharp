using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomat
{
    internal class Program
    {
        static void Main(string[] args)
        {

        #region Dizi Tanımlamaları
        BAS:
            Console.WriteLine("Otomata Hoş geldiniz!");
            Console.WriteLine("1) Kullanıcı Girişi\n2) Yönetici Girişi");

            int giris = Convert.ToInt32(Console.ReadLine());


            string[] urunler = new string[3];
            urunler[0] = "1) Kola";
            urunler[1] = "2) Bisküvi";
            urunler[2] = "3) Çikolata";

            int[] urunfiyat = new int[3];
            urunfiyat[0] = 7;
            urunfiyat[1] = 3;
            urunfiyat[2] = 2;

            #endregion
            #region Kullanıcı Paneli
            if (giris == 1)
            {
                foreach (string i in urunler)
                {
                    Console.WriteLine(i);
                }
                int urunsecim = Convert.ToInt32(Console.ReadLine());


                if (giris == 1)
                {
                DON:
                    #region 1) Kola Seçimi
                    if (urunsecim == 1)
                    {
                        Console.WriteLine("Kola Fiyatı: " + urunfiyat[0] + " TL");
                        Console.WriteLine("Kola verilmesi için otomatın para bölmesinden ödeme yapınız...\nYaptığınız tutarı giriniz...");
                        int odenentutar = Convert.ToInt32(Console.ReadLine());
                        int paraustu = (odenentutar - urunfiyat[0]);

                        if (odenentutar >= urunfiyat[0])
                        {

                            Console.WriteLine("Alınacak Paraüstü: " + paraustu + "TL");
                            Console.WriteLine("Para üstünüzü ve ürününüzü alabilirsiniz.");
                            Console.WriteLine("Ana ekrana yönlendiriliyorsunuz....");
                            goto BAS;
                        }

                        else
                        {
                            Console.WriteLine("Ürün tutarından daha düşük para otomata verdiniz.En az ürün tutarı kadar vermelisiniz.");
                            goto DON;

                        }

                    }
                    #endregion
                    #region 2) Bisküvi Seçimi

                    else if (urunsecim == 2)
                    {
                    SECb:
                        Console.WriteLine("Bisküvi Fiyatı: " + urunfiyat[1] + " TL");
                        Console.WriteLine("Bisküvi verilmesi için otomatın para bölmesinden ödeme yapınız...\nYaptığınız tutarı giriniz...");
                        int odenentutar = Convert.ToInt32(Console.ReadLine());
                        int paraustu = (odenentutar - urunfiyat[1]);

                        if (odenentutar > urunfiyat[1])
                        {

                            Console.WriteLine("Alınacak Paraüstü: " + paraustu + "TL");
                            Console.WriteLine("Para üstünüzü ve ürününüzü alabilirsiniz.");
                            Console.WriteLine("Ana ekrana yönlendiriliyorsunuz....");
                            goto BAS;
                        }

                        else
                        {
                            Console.WriteLine("Ürün tutarından daha düşük para otomata verdiniz.En az ürün tutarı kadar vermelisiniz.");
                            goto SECb;
                        }
                    }
                    #endregion
                    #region 3) Çikolata Seçimi
                    else if (urunsecim == 3)
                    {
                    SECc:
                        Console.WriteLine("Çikolata Fiyatı: " + urunfiyat[2] + " TL");
                        Console.WriteLine("Çikolata verilmesi için otomatın para bölmesinden ödeme yapınız...\nYaptığınız tutarı giriniz...");
                        int odenentutar = Convert.ToInt32(Console.ReadLine());
                        int paraustu = (odenentutar - urunfiyat[2]);

                        if (odenentutar > urunfiyat[2])
                        {

                            Console.WriteLine("Alınacak Paraüstü: " + paraustu + "TL");
                            Console.WriteLine("Para üstünüzü ve ürününüzü alabilirsiniz.");
                            Console.WriteLine("Ana ekrana yönlendiriliyorsunuz....");
                            goto BAS;
                        }

                        else
                        {
                            Console.WriteLine("Ürün tutarından daha düşük para otomata verdiniz.En az ürün tutarı kadar vermelisiniz.");
                            goto SECc;

                        }
                    }
                    #endregion
                    else
                    {
                        Console.WriteLine("Hatalı seçim yaptınız..");
                        goto BAS;
                    }
                }
            }
            #endregion
            #region Yönetici Paneli
            else if (giris == 2)
            {

                Console.WriteLine("Yönetici paneli");
            sifre:
                Console.WriteLine("Lütfen yönetici şifresi giriniz:");
                string sifre = "12345mesut";
                string pass = Console.ReadLine();

                if (sifre == pass)
                {

                    Console.WriteLine("1)Ürün Sil\n2)Ürün İsmi Düzenle\n3)Ürün Fiyatı Düzenle\n4)Ürün Ekle");
                    int adminsecim = Convert.ToInt32(Console.ReadLine());
                    #region 1) Ürün Silme
                    if (adminsecim == 1)
                    {
                        Console.WriteLine("Ürün Silme Menüsü\n Silinecek ürünü tuşlayınız...");
                        foreach (string i in urunler)
                        {
                            Console.WriteLine(i);
                        }
                        int silinenurun = Convert.ToInt32(Console.ReadLine());
                        Array.Clear(urunler, (silinenurun - 1), 1);
                        Console.WriteLine("Ürün Silindi..\nMevcut ürünler:");
                        foreach (string i in urunler)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    #endregion
                    #region 2) Ürün İsmi Düzenleme
                    else if (adminsecim == 2)
                    {
                        Console.WriteLine("Ürün İsmi Düzenleme Menüsü");
                        foreach (string i in urunler)
                        {
                            Console.WriteLine(i);
                        }
                        int duzenlenecekurun = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Seçtiğiniz ürünün yeni ismini girin...");
                        urunler[duzenlenecekurun - 1] = Console.ReadLine();
                        Console.WriteLine("Ürün İsmi düzenlendi..\nMevcut ürünler:");
                        foreach (string i in urunler)
                        {
                            Console.WriteLine(i);
                        }

                    }
                    #endregion
                    #region 3) Ürün Fiyatı Düzenleme
                    else if (adminsecim == 3)
                    {
                        Console.WriteLine("Ürün Fiyatı Düzenleme Menüsü");
                        foreach (string i in urunler)
                        {
                            Console.WriteLine(i);
                        }
                        int duzenlenecekfiyat = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Seçtiğiniz ürünün yeni fiyatını girin...");
                        urunfiyat[duzenlenecekfiyat - 1] = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ürün fiyatı düzenlendi..\nMevcut ürünler:");
                        foreach (string i in urunler)
                        {
                            Console.WriteLine(i);
                        }
                        Console.WriteLine("Fiyatlar sırayla:");
                        foreach (int i in urunfiyat)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    #endregion
                    #region 4) Ürün Ekleme
                    else if (adminsecim == 4)
                    {
                        Console.WriteLine("Ürün Ekleme Menüsü");
                        Console.WriteLine("Yeni ürünün ismini başında numaraısyla girin.(ör: 5) Maden Suyu...)");
                        string yenisim = Console.ReadLine();
                        urunler = urunler.Concat(new string[] { yenisim }).ToArray();

                        Console.WriteLine("Yeni ürünün fiyatını girin.(ör: 5) )");
                        int yenifiyatt = Convert.ToInt32(Console.ReadLine());
                        urunfiyat = urunfiyat.Concat(new int[] { yenifiyatt }).ToArray();

                        Console.WriteLine("Ürün başarıyla eklendi.. ");

                        foreach (string i in urunler)
                        {
                            Console.WriteLine(i);
                        }
                        Console.WriteLine("Fiyatlar sırayla:");
                        foreach (int i in urunfiyat)
                        {
                            Console.WriteLine(i);
                        }
                        goto BAS;
                    }
                    #endregion
                    else
                    {
                        Console.WriteLine("Hatalı seçim yaptınız...");
                    }

                }
                else
                {
                    Console.WriteLine("Hatalı şifre girdiniz...");
                    goto sifre;
                }

            }
            else
            {
                Console.WriteLine("Hatalı seçim yaptınız");
                goto BAS;
            }

            #endregion

            Console.ReadLine();
        }
    }
}
