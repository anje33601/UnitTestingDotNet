using System;
using Xunit;

namespace TestProjectTodo
{
    public class UnitTestTodo
    {
        [Fact]
        public void TestCreateToDoItemShutReturnToDoItem()
        {
            //Arange
            string title = "testtitle";
            bool compleated = false;

            //Act
            Todo todo = new Todo(title, compleated);
            //Assert
            Assert.Equal(title, todo.GetTitle());
            Assert.False(todo.GetCompleated());
        }

        [Fact]
        public void TestCreateToDoItemEmtyTitleShutReturnException()
        {
            //Arange
            string title = null;
            bool compleated = false;

            //Act
            //Assert
            Assert.Throws<ArgumentNullException>(() =>  new Todo(title, compleated));

        }
        [Fact]
        public void TestEditToDoItemShoudUpdateTheExcistingOne()
        {
            //Arange
            Todo excistingOneTodo = new Todo("Title", true);
            string newTitle = "NewTitle";

            //Act
            excistingOneTodo.SetTitle(newTitle);

            //Assert
            Assert.Equal(newTitle, excistingOneTodo.GetTitle());

        }
        [Fact]
        public void testIfCompleted_shouldNot_setToCompeted()
        {
            //Arange
            Todo excistingOneTodo = new Todo("Title", true);
            

            //Act
            excistingOneTodo.SetCompleated(true);

            //Assert
            Assert.False(excistingOneTodo.SetCompleated(true));

        }



    }
}
