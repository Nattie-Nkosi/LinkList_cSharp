// See https://aka.ms/new-console-template for more information


class Program {
  class Node {
    public int data;
    public Node next;

    public Node(int x) {
      data = x;
      next = null!;
    }
  }

  class LinkedList {
    int count;
    Node head;
    public LinkedList() {
      head = null!;
      count = 0;
    }

    public void addNodeToFront(int data) {
      Node node = new Node(data);
      node.next = head;
      head = node;
      count++;
    }

    public void printList() {
      Node temp = head;
      while(temp != null) {
        System.Console.WriteLine(temp.data);
        temp = temp.next;
      }
    }
  }
  static void Main(string[] args) {
    LinkedList list = new LinkedList();
    list.addNodeToFront(1);
    list.addNodeToFront(2);
    list.addNodeToFront(3);
    list.addNodeToFront(4);
    list.addNodeToFront(5);
    list.printList();
  }
}
