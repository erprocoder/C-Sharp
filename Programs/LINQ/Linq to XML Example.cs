using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

//Linq to XML Example
namespace ProgrammingHub
{
    class LinqToXMLExample
    {

        static void Main(string[] args)
        {
            //string with xml content
            string studentXML = @"<Students>
                       <StudentName>Avinash</StudentName>
                       <StudentName>Miten</StudentName>
                       <StudentName>Prasanna</StudentName>
                       <StudentName>Anoop</StudentName>
                       </Students>";
            //object for holding xml document
            XDocument xdoc = new XDocument();
            xdoc = XDocument.Parse(studentXML);
            
            //returns a collection of descendant for the xml document/element
            var result = xdoc.Element("Students").Descendants();
            
            foreach (XElement item in result)
            {
                Console.WriteLine("Student Name is " + item.Value);
            }
            Console.ReadKey();
        }
    }
}