using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using System.Xml.Schema;

namespace Classwork20200330_Schema
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Завдання 1 (Практикум на парі)
                Написати XML-документ для збереження даних <b>про облікові записи користувачів</b>. 
                Про кожнен обліковий запис в документі зберігаються дані про:
                <ul><li>Ім'я користувача</li>
                <li>Логін</li>
                <li>Пароль</li>
                <li>Дата створення облікового запису</li>
                </ul>
                Додати в документ;
                Реалізувати можливість: 
                Додати/
                видвлити/
                редагувати користувача.
                Зробити можливість імпорту в html
                Написати xsd сxему для валідації*/

            String path = @"D:\Folder\Accounts.xml";
            Console.WriteLine(" CREATE FILE .XML");
            XDocument xmlDocument = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("This is a test comment"),
                new XElement("Accounts", from contact in Account.GetAllSContacts()
                                         select new XElement("Account",
                                         new XAttribute("ID", contact.ID),
                                         new XElement("Name", contact.Name),
                                         new XElement("Login", contact.Login),
                                         new XElement("Password", contact.Password),
                                         new XElement("Date", contact.Date))
                ));
            xmlDocument.Save(path);

            ////a) Додавання контакту
            //Console.WriteLine(" ADD NEW ACCOUNT (You must add ID, Name, Login, Password, Date):");
            //xmlDocument.Element("Accounts").Add(
            //    new XElement("Account", new XAttribute("ID", Console.ReadLine()),
            //    new XElement("Name", Console.ReadLine()),
            //    new XElement("Login", Console.ReadLine()),
            //    new XElement("Password", Console.ReadLine()),
            //    new XElement("Date", Console.ReadLine())
            //    ));
            //xmlDocument.Save(path);

            ////б) Редагування контакту
            //Console.WriteLine("Enter the Account ID to edit:");
            //string number = Console.ReadLine();
            //XDocument xmlDocument1 = XDocument.Load(path);
            //xmlDocument1.Element("Accounts").Elements("Account")
            //    .Where(x => x.Attribute("ID").Value == number).FirstOrDefault().SetElementValue("Name", "Sara");
            //xmlDocument1.Save(path);

            ////г) Видалення
            //Console.WriteLine("Enter the account ID to delete:");
            //string number1 = Console.ReadLine();
            //XDocument xmlDocument2 = XDocument.Load(path);
            //xmlDocument2.Root.Elements().Where(x => x.Attribute("ID").Value == number1).Remove();
            //xmlDocument2.Save(path);

            //д) Показати всі контакти
            Console.WriteLine("SHOW ALL CONTACTS:");
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNodeList elemList = doc.GetElementsByTagName("Name");
            for (int i = 0; i < elemList.Count; i++)
            {
                Console.Write($"Name of account{i+1}: ");
                Console.WriteLine(elemList[i].InnerXml);
            }


            // ж) Пошук по імені
            Console.WriteLine("Enter the account Name to find:");
            string number2 = Console.ReadLine();
            XDocument xmlDocument3 = XDocument.Load(path);
            XmlNodeList elemList1 = doc.GetElementsByTagName("Name");
            bool exit = false;
            for (int i = 0; i < elemList1.Count; i++)
            {
                if (number2 == elemList1[i].InnerXml)
                {
                    Console.WriteLine($"The Account with Name \"{elemList[i].InnerXml}\" is in table");
                    exit = true;
                }
            }
            if (!exit)
            {
                Console.WriteLine($"The Account with Name \"{number2}\" is absent in table");
            }
            
                  

            // Зробити можливість імпорту в csv
            Console.WriteLine("IMPORT XLS-FILE in CSV:");
            StringBuilder sb = new StringBuilder();
            string delimiter = ",";

            XDocument.Load(path).Descendants("Account")
                .ToList().ForEach(x => sb.Append(
                    x.Attribute("ID").Value + delimiter + "\t" +
                    x.Element("Name").Value + delimiter +
                    x.Element("Login").Value + delimiter +
                    x.Element("Password").Value + delimiter +
                    x.Element("Date").Value + "\n"
                    ));
            StreamWriter sw = new StreamWriter(@"D:\Folder\Result.csv");
            sw.WriteLine(sb.ToString());
            sw.Close();

            // Зробити можливість імпорту в HTML
            Console.WriteLine("IMPORT XLS-FILE in HTML:");
            XDocument xmlDocument4 = XDocument.Load(path);

            XDocument result = new XDocument(new XElement("table", new XAttribute("border", 2),
                new XElement("thead",
                    new XElement("tr",
                        new XElement("th", "ID"),
                        new XElement("th", "Name"),
                        new XElement("th", "Login"),
                        new XElement("th", "Password"),
                        new XElement("th", "Date"))),
                new XElement("tbody",
                    from account in xmlDocument4.Descendants("Account")
                    select new XElement("tr",
                        new XElement("td", account.Attribute("ID").Value),
                        new XElement("td", account.Element("Name").Value),
                        new XElement("td", account.Element("Login").Value),
                        new XElement("td", account.Element("Password").Value),
                        new XElement("td", account.Element("Date").Value)))
                ));
            result.Save(@"D:\Folder\index_account.html");

            // Написати xsd сxему для валідації 
            XmlSchemaSet schema = new XmlSchemaSet();
            string schemaPath = @"D:\Шаг\C#\Classwork20200330_Schema\Account.xsd";
            schema.Add("", schemaPath);
            XDocument xmlDocument5 = XDocument.Load(path);

            bool valid = false;

            xmlDocument5.Validate(schema, (s, e) =>
            {
                Console.WriteLine(e.Message);
                valid = true;
            });

            if (!valid)
            {
                Console.WriteLine("Validation success!");
            }
            else
            {
                Console.WriteLine("Validation failed!");
            }

        }

    }
}

