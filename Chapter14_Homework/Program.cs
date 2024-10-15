using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Chapter14_Homework
{
    public class Student
    {
        public int ogrenciNo;
        private string isim { get; set; }
        private string soyisim { get; set; }
        private int vize1 { get; set; }
        private int vize2 { get; set; }
        private int final { get; set; }
        private string okulismi { get; set; }


        public Student(int ogrencino, string ogrenciisim, string ogrencisoyisim, int ogrencivize1, int ogrencivize2, int ogrencifinal, string ogrenciokulismi)
        {
            ogrenciNo = ogrencino;
            isim = ogrenciisim;
            soyisim = ogrencisoyisim;
            vize1 = ogrencivize1;
            vize2 = ogrencivize2;
            final = ogrencifinal;
            okulismi = ogrenciokulismi;
        }

        public string GetIsim()
        {
            return isim;
        }
        public string GetSoyisim()
        {
            return soyisim;
        }
        public int GetVize1()
        {
            return vize1;
        }
        public int GetVize2()
        {
            return vize2;
        }
        public int GetFinal()
        {
            return final;
        }
        public string GetOkul()
        {
            return okulismi;
        }
        internal class Program
        {

            static void ogrenciBilgiGetir(Student student)
            {
                Console.WriteLine($"Öğrenci No: " + student.ogrenciNo);
                Console.WriteLine($"Öğrenci AdSoyad: " + student.GetIsim() + " " + student.GetSoyisim());
            }
            static void ogrenciOrt(Student student)
            {
                int ort = (student.GetVize1() + student.GetVize2() + student.GetFinal()) / 3;
                Console.WriteLine("Ortalama: " + ort);
            }

            static void Main(string[] args)
            {
                Student student = new Student(2110206075, "ismail", "Aydın", 60, 72, 100, "Karabük Üniversitesi");
                while (true)
                {
                    Console.WriteLine("(1) Öğrenci Bilgileri: ");
                Console.WriteLine("(2) Öğrenci Ort: ");
                Console.WriteLine("(3) Öğrenci OKUL: ");
                Console.WriteLine("(4) ÇIK: ");
                string seçim = Console.ReadLine();
               
                    switch (seçim)
                    {
                        case "1":
                            ogrenciBilgiGetir(student);
                            break;
                        case "2":
                            ogrenciOrt(student);
                            break;
                        case "3":
                            Console.WriteLine(student.okulismi);
                            break;
                        case "4":
                            return;
                    }
                }
            }

        }
    }
}
