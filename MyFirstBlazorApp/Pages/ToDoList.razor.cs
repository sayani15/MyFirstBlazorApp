using MyFirstBlazorApp.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstBlazorApp.Pages
{
    public partial class ToDoList
    {
        public ListElement ListElement { get; set; } = new ListElement();

        public bool CanDisplayElement { get; set; } = false;

        public ToDoList()
        {
            ListElement.name = "hi";
        }

        public void DisplayElement()
        {
            CanDisplayElement = true;
            
        }

    }
}
