using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ToDoList.Models;
using System.Collections.Generic;


namespace ToDoList.Tests
{
  [TestClass]
  public class TaskTest : IDisposable
  {
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
        //Arrange
        string description = "Walk the dog.";
        Task newTask = new Task(description);

        //Act
        string result = newTask.GetDescription();

        //Assert
        Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetAll_ReturnsTasks_TaskList()
    {
        //Arrange
        string description01 = "Walk the dog";
        string description02 = "Wash the dishes";
        Task newTask1 = new Task(description01);
        Task newTask2 = new Task(description02);
        List<Task> newList = new List<Task> { newTask1, newTask2 };

        //Act
        List<Task> result = Task.GetAll();
        // foreach (Task thisTask in result)
        // {
        //   Console.WriteLine("Output: " + thisTask.GetDescription());
        // }

        //Assert
        CollectionAssert.AreEqual(newList, result);
    }

    public void Dispose()
    {
      Task.ClearAll();
    }

  }
}
