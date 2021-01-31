using System;
using System.Collections.Generic;

namespace RecordNotFoundException
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exception Example
            try
            {
                Find();
            }
            catch (RecordNotFound exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            //Sample customers from db
            List<string> customers = new List<string> { "Arda", "Cumhur", "Nazire" };

            if (!customers.Contains("Arzu"))
            {
                throw new RecordNotFound("Kayıt bulunamadı");
            }
            else
            {
                Console.WriteLine("Kayıt bulundu");
            }
        }
    }
}
