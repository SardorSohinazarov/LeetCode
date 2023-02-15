public class MyLinkedList// learned
{
    Node head;
    public MyLinkedList()
    {
    }

    public class Node
    {
        public int data;
        public Node next;

        public Node(int val)
        {
            data = val;
            next = null;
        }
    }

    public int Get(int index)
    {
        Node temp = head;

        if (temp == null)
            return -1;

        for (int i = 0; i < index; i++)
        {
            if (temp == null)
                return -1;

            temp = temp.next;
        }

        if (temp == null)
            return -1;

        return temp.data;
    }

    public void AddAtHead(int val)
    {
        Node node = new Node(val);

        node.next = head;
        head = node;
    }

    public void AddAtTail(int val)
    {
        if (head == null)
        {
            head = new Node(val);
            return;
        }

        Node temp = head;

        while (temp.next != null)
        {
            temp = temp.next;
        }

        temp.next = new Node(val);
    }

    public void AddAtIndex(int index, int val)
    {
        if (index == 0)
        {
            AddAtHead(val);
            return;
        }


        Node current = head;
        if (current == null)
            return;

        Node prev = head;
        for (int i = 0; i < index; i++)
        {
            prev = current;
            if (prev == null)
                return;

            current = current.next;
        }
        
        Node node = new Node(val);
        node.next = current;
        prev.next = node;
    }

    public void DeleteAtIndex(int index)
    {
        if (head == null)
            return;
        
        Node current = head;
        
        Node prev = head;

        if (index == 0)
        {
            head = head.next;
            return;
        }

        for (int i = 0; i < index; i++)
        {
            prev = current;
            if (prev == null)
                return;

            current = current.next;
        }

        if (current == null)
            return;

        prev.next = current.next;
    }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */