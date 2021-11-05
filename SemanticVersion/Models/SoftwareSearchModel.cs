using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SemanticVersion.Models
{
    public class SoftwareSearchModel
    {
        //software list that will contain search results
        public List<Software> softwareList { get; set; }
        //string to contain the search text
        public string SearchText { get; set; }
    }
}
