using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;

namespace Homework_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. Розробити програму по роботі з XML-документом "Список контактів"
                 Програма через меню повинна забезпечити: 
                a) Додавання контакту
                б) Редагування контакту
                г) Видалення
                д) Показати всі контакти
                ж) Пошук по імені
                */

            //Create XML file from class Contactlist
            string path = @"D:\Folder\Data.xml";
        Console.WriteLine(" CREATE FILE .XML");
            XDocument xmlDocument = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("This is a test comment"),
                new XElement("Contacts", from contact in Contactlist.GetAllSContacts()
                                         select new XElement("Contact",
                                         new XAttribute("ID", contact.ID),
                                         new XAttribute("Name", contact.Name),
                                         new XAttribute("Birthday", contact.Birthday),
                                         new XAttribute("Phone", contact.Phone))
                ));
        xmlDocument.Save(path);

            //// a) Додавання контакту
            //Console.WriteLine(" ADD NEW CONTACT (You must add ID, Name, Birthday, Phohe):");
            //xmlDocument.Element("Contacts").Add(
            //    new XElement("Contact", new XAttribute("Id", Console.ReadLine()),
            //    new XElement("Name", Console.ReadLine()),
            //    new XElement("Birthday", Console.ReadLine()),
            //    new XElement("Phone", Console.ReadLine())
            //    ));
            //xmlDocument.Save(path);

            ////б) Редагування контакту

            //Console.WriteLine("Enter the client ID to edit:");
            //string number = Console.ReadLine();
            //XDocument xmlDocument1 = XDocument.Load(path);
            //xmlDocument1.Element("Contacts").Elements("Contact")
            //    .Where(x => x.Attribute("ID").Value == number).FirstOrDefault().SetElementValue("Name", "sdasd");
            //xmlDocument1.Save(path);


            //г) Видалення
            Console.WriteLine("Enter the client ID to delete:");
            string number1 = Console.ReadLine();

            XDocument xmlDocument2 = XDocument.Load(path);
            xmlDocument2.Root.Elements().Where(x => x.Attribute("ID").Value == number1).Remove();
            xmlDocument2.Save(path);


            //д) Показати всі контакти
            Console.WriteLine("SHOW ALL CONTACTS:");

            // ж) Пошук по імені

        }
    }
}
