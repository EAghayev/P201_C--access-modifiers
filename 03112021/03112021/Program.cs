using System;
using _03112021.Classes;
using System.Text;
using MyClassLibrary;
using _03112021.Exceptions;

namespace _03112021
{
    class Program
    {
        static void Main(string[] args)
        {


            string yearStr;
            int year;

            do
            {
                Console.WriteLine("Masinin ilini daxil edin:");
                yearStr = Console.ReadLine();

            } while (!int.TryParse(yearStr,out year));

           

            Car car1 = new Car();
            try
            {
                car1.Year = year;

                Console.WriteLine("Brand adi daxil edin: ");
                car1.Brand = Console.ReadLine();
            }
            catch (InvalidCarYearException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(InvalidCarBrandException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Bilinmeyen bir xeta bas verdi!");
            }
           

            Console.WriteLine($"Ili: {car1.Year} - Brand: {car1.Brand}");



            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();

            Classes.StringBuilder strBuilder = new Classes.StringBuilder();

            Car car = new Car();
            
            car.Year = 1980;
            Console.WriteLine(car.Year);

            Product product = new Product();

            Doctor doctor = new Doctor();

            Book book = new Book();

            try
            {
                Console.WriteLine("yas:");
                int age = Convert.ToInt32(Console.ReadLine());

                if (age < 0) throw new InvalidAgeExcaption("Yas deyeri 0-dan kicik ola bilmez!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Format xetasi bas verdi");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("0-a bolme eded bilmezsiniz!");
            }
            catch (InvalidAgeExcaption e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
            finally
            {
                Console.WriteLine("Finally");
            }


            Console.WriteLine("Davam edir..");
            Console.WriteLine("Davam edir..");
            Console.WriteLine("Davam edir..");

        }
    }
}
