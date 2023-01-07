using Tasks.Tasks;
using Xunit;

namespace Tests.LeetCode;

public sealed class LinkedListWithCycles
{
    [Fact]
    public void LinkedListHasCycle_ShouldReturnTrue()
    {
        var list = new LinkedList(5);
        var node4 = new Node(4, list.Head);
        list.Add(node4);
        var node3 = new Node(3, node4);
        list.Add(node3);
        var node2 = new Node(2, node3);
        list.Add(node2);
        var node1 = new Node(1, node2);
        list.Add(node1);
        list.Head.Next = node1;
        Assert.True(list.HasCycles());
    }
    
    [Fact]
    public void LinkedListHasNoCycle_ShouldReturnFalse()
    {
        var list = new LinkedList(5);
        list.Add(4);
        list.Add(3);
        list.Add(2);
        list.Add(1);
        Assert.False(list.HasCycles());
    }
}