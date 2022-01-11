using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstBlazorApp.DataStructures
{
    public class ListElement
    {
        /// <summary>
        /// The name of the task, Date it needs to be completed by, person who needs to do this task, task description and when the task was added to the to do list.
        /// </summary>
        public string name = "";

        public DateTime dueDate = new DateTime();

        public string whoseResponsibility = "";

        public string description = "";

        public DateTime whenItWasAdded = new DateTime();
    }
}
