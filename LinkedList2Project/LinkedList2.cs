using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

	public class Node
	{
		public int value;
		public Node next, prev;

		public Node(int _value)
		{
			value = _value;
			next = null;
			prev = null;
		}
	}

	public class LinkedList2
	{
		public Node head;
		public Node tail;

		public LinkedList2()
		{
			head = null;
			tail = null;
		}

		public void AddInTail(Node _item)
		{
			if (head == null)
			{
				head = _item;
				head.next = null;
				head.prev = null;
			}
			else
			{
				tail.next = _item;
				_item.prev = tail;
			}

			tail = _item;
		}

		public Node Find(int _value)
		{
			Node node = head;
			while (node != null)
			{
				if (node.value == _value) return node;
				node = node.next;
			}

			return null;
		}

		public List<Node> FindAll(int _value)
		{
			List<Node> nodes = new List<Node>();

			Node node = head;
			while (node != null)
			{
				if (node.value == _value)
					nodes.Add(node);

				node = node.next;
			}

			return nodes;
		}

		public bool Remove(int _value)
		{
			Node node = head;
			bool isDeleted = false;
			while (node != null && !isDeleted)
			{
				if (node.value == _value)
				{
					if (node.prev != null)
						node.prev.next = node.next;
					else
						head = node.next;

					if (node.next != null)
						node.next.prev = node.prev;
					else
						tail = node.prev;

					isDeleted = true;
				}

				node = node.next;
			}

			return isDeleted;
		}

		public void RemoveAll(int _value)
		{
			Node node = head;
			while (node != null)
			{
				if (node.value == _value)
				{
					if (node.prev != null)
						node.prev.next = node.next;
					else
						head = node.next;

					if (node.next != null)
						node.next.prev = node.prev;
					else
						tail = node.prev;
				}

				node = node.next;
			}
		}

		public void Clear()
		{
			Node node = head;
			head = null;
			tail = null;
			while (node != null)
			{
				Node nextNode = node.next;
				node = null;
				node = nextNode;
			}
		}

		public int Count()
		{
			int count = 0;
			var node = head;
			if (node != null)
			{
				while (node != null)
				{
					count++;
					node = node.next;
				}
			}

			return count;
		}

		public void InsertAfter(Node _nodeAfter, Node _nodeToInsert)
		{
			if (head == null || _nodeAfter == null)
				AddInTail(_nodeToInsert);
			else if (tail == _nodeAfter)
			{
				tail.next = _nodeToInsert;
				_nodeToInsert.prev = tail;
				tail = _nodeToInsert;
			}
			else
			{
				_nodeToInsert.next = _nodeAfter.next;
				_nodeAfter.next = _nodeToInsert;
				_nodeToInsert.prev = _nodeAfter;
				_nodeToInsert.next.prev = _nodeToInsert;
			}
		}
	}
}