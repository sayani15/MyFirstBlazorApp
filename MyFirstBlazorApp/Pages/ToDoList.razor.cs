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

        public List<ListElement> ListElements { get; set; } = new List<ListElement>();

        /// <summary>
        /// This makes sure that what the user has typed in is actually saved to 'name'.
        /// </summary>
        public bool CanDisplayElement { get; set; } = false;

        public ToDoList()
        {
        }
        
        public void DisplayElement()
        {
            CanDisplayElement = true;

            ListElements.Add(ListElement); 
        }

    }
}
