
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue items with different priorities and dequeue them.
    // Expected Result: Items dequeued in order of highest priority.
    public void TestPriorityQueue_Basic()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("LowPriority", 1);
        priorityQueue.Enqueue("HighPriority", 5);
        priorityQueue.Enqueue("MediumPriority", 3);

        Assert.AreEqual("HighPriority", priorityQueue.Dequeue());
        Assert.AreEqual("MediumPriority", priorityQueue.Dequeue());
        Assert.AreEqual("LowPriority", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue items with the same priority.
    // Expected Result: Items dequeued in the order they were added FIFO.
    public void TestPriorityQueue_FIFOOrder()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("First", 3);
        priorityQueue.Enqueue("Second", 3);
        priorityQueue.Enqueue("Third", 3);

        Assert.AreEqual("First", priorityQueue.Dequeue());
        Assert.AreEqual("Second", priorityQueue.Dequeue());
        Assert.AreEqual("Third", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Dequeue from an empty queue.
    // Expected Result: Exception thrown.
    public void TestPriorityQueue_Empty()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Expected an InvalidOperationException.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }
}
