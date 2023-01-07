namespace Tasks.Tasks;

/*
 * Есть связанный список элементов, где последний элемент ссылается на null.
Необходимо определить, есть ли в этом списке элементов "цикл".
Т.е. ситуации, когда допустим 10й элемент ссылается вместо 11го на 2й.
структура одного элемента такая:
*/
public class Node
{
    public int Value {get;}
    public Node? Next {get; set; }

    public Node(int value, Node? next)
    {
        Value = value;
        Next = next;
    }
}

public class LinkedList
{
    public Node Head { get; }
    public int Count { get; private set; }

    private Node _current;

    public LinkedList(int value)
    {
        Count++;
        Head = new Node(value, null);
        _current = Head;
    }

    public void Add(int value)
    {
        var node = new Node(value, null);
        _current.Next = node;
        _current = _current.Next;
        Count++;
    }

    public void Add(Node node)
    {
        _current.Next = node;
        _current = _current.Next;
        Count++;
    }

    public bool HasCycles()
    {
        var localCount = 0;
        var cur = Head;
        while (cur.Next != null && localCount <= Count)
        {
            cur = cur.Next;
            localCount++;
        }

        if (localCount > Count)
        {
            return true;
        }

        return false;
    }
}