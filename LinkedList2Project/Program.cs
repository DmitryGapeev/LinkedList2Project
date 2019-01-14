using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsDataStructures;

namespace LinkedList2Project
{
  class Program
  {
    static void Main(string[] args)
    {
			TestClear();
			TestFindElement();
			TestFindElements();
			TestRemove();
			TestRemoveAll();
			TestInsertAfter();

	    Console.Read();
    }

	  static void TestFindElement()
	  {
			Console.WriteLine("find element test");

		  var list = new LinkedList2();
			list.AddInTail(new Node(20));
			list.AddInTail(new Node(24));
		  list.AddInTail(new Node(10));
		  list.AddInTail(new Node(15));
			list.AddInTail(new Node(77));
			list.AddInTail(new Node(24));

			Console.WriteLine("find 20");
		  var result = list.Find(20);
			Console.WriteLine("result " + result.value);

			Console.WriteLine("find 10");
		  result = list.Find(10);
		  Console.WriteLine("result " + result.value);

			Console.WriteLine("find 24");
		  result = list.Find(24);
		  Console.WriteLine("result " + result.value);

			Console.WriteLine(new string('=', 30));
	  }

	  static void TestFindElements()
	  {
		  Console.WriteLine("find elements test");

			var list = new LinkedList2();
		  list.AddInTail(new Node(20));
		  list.AddInTail(new Node(24));
		  list.AddInTail(new Node(10));
		  list.AddInTail(new Node(15));
		  list.AddInTail(new Node(77));
		  list.AddInTail(new Node(24));

		  Console.WriteLine("find 20");
		  var result = list.FindAll(20);
		  foreach (var item in result)
				Console.WriteLine(item.value);

		  Console.WriteLine("find 24");
		  result = list.FindAll(24);
		  foreach (var item in result)
			  Console.WriteLine(item.value);

		  Console.WriteLine(new string('=', 30));
		}

	  static void TestClear()
	  {
		  Console.WriteLine("clear test");

			var list = new LinkedList2();
		  list.AddInTail(new Node(20));
		  list.AddInTail(new Node(24));
		  list.AddInTail(new Node(10));
		  list.AddInTail(new Node(15));
		  list.AddInTail(new Node(77));
		  list.AddInTail(new Node(24));

			Console.WriteLine("count before clear = " + list.Count());
			Console.WriteLine("head before clear = " + list.head.value);
		  Console.WriteLine("tail before clear = " + list.tail.value);
			list.Clear();
		  Console.WriteLine("count after clear = " + list.Count());
		  Console.WriteLine("head after clear = " + (list.head == null ? "null" : list.head.value.ToString()));
		  Console.WriteLine("tail after clear = " + (list.head == null ? "null" : list.tail.value.ToString()));

		  Console.WriteLine(new string('=', 30));
		}

	  static void TestRemove()
	  {
		  var list = new LinkedList2();
		  list.AddInTail(new Node(20));
		  list.AddInTail(new Node(24));
		  list.AddInTail(new Node(10));
		  list.AddInTail(new Node(15));
		  list.AddInTail(new Node(77));
		  list.AddInTail(new Node(24));

			Console.WriteLine("delete 10");
		  Console.WriteLine("count before delete = " + list.Count());
		  Console.WriteLine("head before delete = " + list.head.value);
		  Console.WriteLine("tail before delete = " + list.tail.value);
		  var result = list.Remove(10);
			Console.WriteLine("delete result = " + result);
		  Console.WriteLine("count after delete = " + list.Count());
		  Console.WriteLine("head after delete = " + list.head.value);
		  Console.WriteLine("tail after delete = " + list.tail.value);

			Console.WriteLine();

		  Console.WriteLine("delete head");
		  Console.WriteLine("count before delete = " + list.Count());
		  Console.WriteLine("head before delete = " + list.head.value);
		  Console.WriteLine("tail before delete = " + list.tail.value);
		  list.Remove(20);
		  Console.WriteLine("delete result = " + result);
			Console.WriteLine("count after delete = " + list.Count());
		  Console.WriteLine("head after delete = " + list.head.value);
		  Console.WriteLine("tail after delete = " + list.tail.value);

		  Console.WriteLine();

			Console.WriteLine("delete 24");
		  Console.WriteLine("count before delete = " + list.Count());
		  Console.WriteLine("head before delete = " + list.head.value);
		  Console.WriteLine("tail before delete = " + list.tail.value);
		  list.Remove(24);
		  Console.WriteLine("delete result = " + result);
			Console.WriteLine("count after delete = " + list.Count());
		  Console.WriteLine("head after delete = " + list.head.value);
		  Console.WriteLine("tail after delete = " + list.tail.value);

		  Console.WriteLine();

			Console.WriteLine("delete tail");
		  Console.WriteLine("count before delete = " + list.Count());
		  Console.WriteLine("head before delete = " + list.head.value);
		  Console.WriteLine("tail before delete = " + list.tail.value);
		  list.Remove(24);
		  Console.WriteLine("delete result = " + result);
			Console.WriteLine("count after delete = " + list.Count());
		  Console.WriteLine("head after delete = " + list.head.value);
		  Console.WriteLine("tail after delete = " + list.tail.value);

		  Console.WriteLine();

			Console.WriteLine("delete 15, 77");
		  list.Remove(15);
		  list.Remove(77);
		  Console.WriteLine("count after delete = " + list.Count());
		  Console.WriteLine("head after delete = " + (list.head == null ? "null" : list.head.value.ToString()));
		  Console.WriteLine("tail after delete = " + (list.tail == null ? "null" : list.tail.value.ToString()));

			Console.WriteLine("delete 100");
		  list.Remove(100);
		  Console.WriteLine("count after delete = " + list.Count());
			Console.WriteLine("head after delete = " + (list.head == null ? "null" : list.head.value.ToString()));
		  Console.WriteLine("tail after delete = " + (list.tail == null ? "null" : list.tail.value.ToString()));

		  Console.WriteLine();

			Console.WriteLine(new string('=', 30));
		}

	  static void TestRemoveAll()
	  {
		  Console.WriteLine("remove all test");

		  var list = new LinkedList2();
		  list.AddInTail(new Node(20));
		  list.AddInTail(new Node(24));
		  list.AddInTail(new Node(10));
		  list.AddInTail(new Node(15));
		  list.AddInTail(new Node(77));
		  list.AddInTail(new Node(24));

		  Console.WriteLine("delete 10");
		  Console.WriteLine("count before delete = " + list.Count());
		  Console.WriteLine("head before delete = " + list.head.value);
		  Console.WriteLine("tail before delete = " + list.tail.value);
		  list.RemoveAll(10);
		  Console.WriteLine("count after delete = " + list.Count());
		  Console.WriteLine("head after delete = " + list.head.value);
		  Console.WriteLine("tail after delete = " + list.tail.value);

			Console.WriteLine();

		  Console.WriteLine("delete 24");
		  Console.WriteLine("count before delete = " + list.Count());
		  Console.WriteLine("head before delete = " + list.head.value);
		  Console.WriteLine("tail before delete = " + list.tail.value);
		  list.RemoveAll(24);
		  Console.WriteLine("count after delete = " + list.Count());
		  Console.WriteLine("head after delete = " + list.head.value);
		  Console.WriteLine("tail after delete = " + list.tail.value);

		  Console.WriteLine();

			Console.WriteLine(new string('=', 30));
		}

	  static void TestInsertAfter()
	  {
			var list = new LinkedList2();

			Console.WriteLine("insert 10");
			Console.WriteLine("count before insert = " + list.Count());
			Console.WriteLine("head before insert = " + (list.head == null ? "null" : list.head.value.ToString()));
		  Console.WriteLine("tail before insert = " + (list.tail == null ? "null" : list.tail.value.ToString()));
			list.InsertAfter(null, new Node(10));
		  Console.WriteLine("count after insert = " + list.Count());
		  Console.WriteLine("head after insert = " + (list.head == null ? "null" : list.head.value.ToString()));
		  Console.WriteLine("tail after insert = " + (list.tail == null ? "null" : list.tail.value.ToString()));

			Console.WriteLine();

		  Console.WriteLine("insert 20");
		  Console.WriteLine("count before insert = " + list.Count());
		  Console.WriteLine("head before insert = " + (list.head == null ? "null" : list.head.value.ToString()));
		  Console.WriteLine("tail before insert = " + (list.tail == null ? "null" : list.tail.value.ToString()));
			list.InsertAfter(null, new Node(20));
		  Console.WriteLine("count after insert = " + list.Count());
		  Console.WriteLine("head after insert = " + (list.head == null ? "null" : list.head.value.ToString()));
		  Console.WriteLine("tail after insert = " + (list.tail == null ? "null" : list.tail.value.ToString()));

		  Console.WriteLine();

			Console.WriteLine("insert 30 after head");
		  Console.WriteLine("count before insert = " + list.Count());
		  Console.WriteLine("head before insert = " + (list.head == null ? "null" : list.head.value.ToString()));
		  Console.WriteLine("tail before insert = " + (list.tail == null ? "null" : list.tail.value.ToString()));
		  list.InsertAfter(list.head, new Node(20));
		  Console.WriteLine("count after insert = " + list.Count());
		  Console.WriteLine("head after insert = " + (list.head == null ? "null" : list.head.value.ToString()));
		  Console.WriteLine("tail after insert = " + (list.tail == null ? "null" : list.tail.value.ToString()));

		  Console.WriteLine();

			Console.WriteLine("insert 50 after tail");
		  Console.WriteLine("count before insert = " + list.Count());
		  Console.WriteLine("head before insert = " + (list.head == null ? "null" : list.head.value.ToString()));
		  Console.WriteLine("tail before insert = " + (list.tail == null ? "null" : list.tail.value.ToString()));
		  list.InsertAfter(list.tail, new Node(50));
		  Console.WriteLine("count after insert = " + list.Count());
		  Console.WriteLine("head after insert = " + (list.head == null ? "null" : list.head.value.ToString()));
		  Console.WriteLine("tail after insert = " + (list.tail == null ? "null" : list.tail.value.ToString()));

		  Console.WriteLine();

			Console.WriteLine(new string('=', 30));
		}
  }
}
