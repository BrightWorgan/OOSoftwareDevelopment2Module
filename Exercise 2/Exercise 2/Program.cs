// See https://aka.ms/new-console-template for more information
using Exercise_2;
using Microsoft.VisualBasic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;


ToDoNote testNote = new ToDoNote("Subject SHIT", DateTime.Now, ToDoNote.Priority.high);

ToDoList myList = new ToDoList("Colin");
myList.Add(testNote);

myList[0].WriteXMLToFile("helloworld.txt");