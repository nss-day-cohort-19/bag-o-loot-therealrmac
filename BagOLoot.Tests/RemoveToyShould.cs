using System;
using System.Collections.Generic;
using Xunit;

namespace BagOLoot.Tests
{
    public class RemoveToyFromAChildShould
    {
        private RemoveChildToy _remove;
    public RemoveToyFromAChildShould()
    {
        _remove= new RemoveChildToy();
    }
    [Fact]
    public void RemoveFromChildsBag()
    {
        int childId= 5;
        int toyId= 45;
        // _remove.GetChildren();
        // _remove.SelectChildToRemoveToy(childId);
        List <int> toys= _remove.GetListOfToys(childId);
        List <int> remainingToys= _remove.RemoveToyFromBag(toyId, childId);

        Assert.DoesNotContain(toyId, remainingToys);
    }
    }
}
