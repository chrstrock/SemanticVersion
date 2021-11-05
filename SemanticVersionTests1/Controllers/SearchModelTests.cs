using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemanticVersion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemanticVersion.Controllers.Tests
{
    [TestClass()]
    public class SearchModelTests
    {

        /// <summary>
        /// Test to determine expected result for input of 2.
        /// </summary>
        [TestMethod()]
        public void getSoftwareListFor2Test()
        {
            
            SoftwareSearchModel searchModel = new SoftwareSearchModel();
            searchModel.SearchText = "2";
            searchModel.setSoftwareList();
            List<Software> expectedList = new List<Software> 
            { new Software
                {
                    Name = "MS Word",
                    Version = "13.2.1"
                },
              new Software
                {
                    Name = "Angular",
                    Version = "8.1.13"
                },
              new Software
                {
                    Name = "Vue.js",
                    Version = "2.6"
                },
              new Software
                {
                    Name = "Visual Studio",
                    Version = "2017.0.1"
                },
              new Software
                {
                    Name = "Visual Studio",
                    Version = "2019.1"
                },

            };
            Assert.IsTrue(searchModel.softwareList.Equals(expectedList));

        }
    }
}