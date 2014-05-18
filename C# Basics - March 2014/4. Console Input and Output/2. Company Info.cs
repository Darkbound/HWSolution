using System;

namespace Homework
{
class PrintCompanyInfo
{
    static void Main()
    {
        Console.WriteLine("Please input the Company and its Manager info in the next few lines.");
        Console.Write("Company name: ");
        string cName = Console.ReadLine();
        Console.Write("Company address: ");
        string cAdd = Console.ReadLine();
        Console.Write("Phone number: ");
        string cPhone = Console.ReadLine();
        Console.Write("Fax number: ");
        string cFax = Console.ReadLine(); if (cFax.Length == 0) { cFax = "(no fax)"; }
        Console.Write("Web site: ");
        string cWeb = Console.ReadLine();
        Console.Write("Manager first name: ");
        string mfName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string mlName = Console.ReadLine();
        Console.Write("Manager age: ");
        string mAge = Console.ReadLine();
        Console.Write("Manager phone: ");
        string mPhone = Console.ReadLine();

        Console.WriteLine("{0}\r\n" +
                         "Address: {1}\r\n" +
                         "Tel. {2}\r\n" +
                         "Fax: {3}\r\n" +
                         "Web site: {4}\r\n"+
                         "Manager: {5} {6} (age: {7}, tel. {8})", 
                         cName, cAdd, cPhone, cFax, cWeb,
                         mfName, mlName, mAge, mPhone);
    }
}
}
