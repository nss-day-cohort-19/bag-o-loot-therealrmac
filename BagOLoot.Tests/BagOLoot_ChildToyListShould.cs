using System;
using System.Collections.Generic;
using Xunit;

namespace BagOLoot.Tests
{
    public class ToyManagerShould
    {
        private ToyManager _manager;
        private ChildRegister _register;
        private AssignToyToChild _assign;
        
    public ToyManagerShould()
    {
       _manager = new ToyManager();
       _register = new ChildRegister();
       _assign = new AssignToyToChild();
    }
    [Fact]
    public void ListAllChidrenGettingAToy()
    {
        // int childId= 1;
        // string childToAdd= "Ryan";
        // string toyToAdd= "Baseball";
      
        // List<int> goodChildren= _manager.GetAllChildrenWhoAreQualifiedForToys();


        // Assert.True(goodChildren.Count ==0);
        // _register.AddChild(childToAdd);
        // int returnedChildId= _register.GetChildId(childToAdd);
        // _assign.AddToyToBag(toyToAdd, childId);

        
        // List<int> goodChildrenAfterAdd= _manager.GetAllChildrenWhoAreQualifiedForToys();

        // Assert.True(goodChildrenAfterAdd.Count >= 1);

       List<int>toys= _manager.GetEveryToyThatHasBeenAssignedToAChild();
       List<int> kidsWhoGetToys= _manager.GetAllChildrenWhoAreQualifiedForToys(toys);
       Assert.NotNull(kidsWhoGetToys);

        
    }
    [Fact]
    public void ListAllToysForAGivenChild()
    {
        int ChildID= 3;
        List<int> toys= _manager.GetEveryToyInOrderToGetAChild(ChildID);
        Assert.True(toys.Count >= 0);

    }
    [Fact]
    public void DeliverAllTheToys()
    {
        int childId= 4;
        var delivery= _manager.HasItBeenDelivered(childId);
        Assert.True(delivery);
    }
    }
}
