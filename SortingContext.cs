using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class SortingContext
    { 
        private Dictionary<string, ISortData> sortStrategy = new Dictionary<string, ISortData>();

        public SortingContext()
        {
            sortStrategy.Add("List", new List());
        }

        public string GetSortedData(string searchType, string data)
        {
            return sortStrategy[searchType].Options(data);
        }
    }
}
