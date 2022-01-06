using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstBlazorApp.DataStructures
{
    public class ListElement
    {
        public string name = "";
        public DateTime dueDate = new DateTime();
        public string whoseResponsibility = "";
        public string description = "";
        public DateTime whenItWasAdded = new DateTime();
    }
}
