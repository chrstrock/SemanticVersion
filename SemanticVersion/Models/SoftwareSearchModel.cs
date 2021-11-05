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

        public SoftwareSearchModel()
        {
            SearchText = "0";
            softwareList = new List<Software>();
        }
        public void setSoftwareList()
        {
            if(Char.IsDigit(SearchText[0]) && SearchText.Length == 1)
            {
                SearchText += ".0";
            }
            
            
            Version version = new Version(SearchText);
            
                List<Software> allSoftwareList = new List<Software>(SoftwareManager.GetAllSoftware());
                softwareList = new List<Software>();


                //compare versions
                foreach (Software software in allSoftwareList)
                {
                    if (new Version(software.Version) > version)
                    {
                        softwareList.Add(software);
                    }

                }
            
        }
    }
}
