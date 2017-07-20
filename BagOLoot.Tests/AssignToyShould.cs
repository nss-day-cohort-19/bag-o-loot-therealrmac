using System;
using System.Collections.Generic;
using Xunit;

namespace BagOLoot.Tests
{
    public class AssigningToyToAChildShould
        {
        private  AssignToyToChild _assign;
        public AssigningToyToAChildShould()
        {
            _assign= new AssignToyToChild();
        }  
        
        [Fact]
        public void AddToyToChildsBag()
        {
            string toyName= "skateboard";
            int childId= 715;
            int toyId= _assign.AddToyToBag(toyName, childId);
            List<int> toys= _assign.GetChildsToys(childId);
            
            Assert.Contains(toyId, toys);
        }


        [Fact]
        public void ReturnChildNameFromDB()
        {
            var result = _assign.GetChildFromDB("Ryan");
            Assert.Equal(result, true);
        }
    }
}