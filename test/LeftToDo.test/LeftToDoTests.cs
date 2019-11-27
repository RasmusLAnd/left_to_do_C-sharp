using System;
using Xunit;
using System.Collections.Generic;

namespace lefttodo.test
{
    public class LeftToDoTests
    {
        [Fact]
        public void CreateTest()
        {
            //Arrange
            List<Item> ItemList= new List<Item>(); 
            var item = new Item();
            
            //act
            item.Items("kage", "d", "2");
            ItemList.add(item);
            int lentgh = ItemList.Count;

            //assert
            Assert.Equal(1,length); 
        }

        public void TaskDone()
        {

        }

        public void FileAllDone()
        {

        }
    }
}
