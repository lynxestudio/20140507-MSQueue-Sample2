using System;

namespace Samples{
	public class TestReceiveMessageQueue
	{
		public static void Main(string[] args)
		{
	string message = null;
	try
	{
	Console.WriteLine("\nTest receive message\n");
	Console.Write("Queue path > ");
	string path = Console.ReadLine();
	message = MessageQueueHelper.GetMessage(path);
	Console.WriteLine("The message is : \n");
	Console.WriteLine("+-------------------+");
	Console.WriteLine("{0}",message);
	Console.WriteLine("+-------------------+");
	}
	catch(Exception ex)
	{
		Console.WriteLine(ex.Message);
	}

		}
	}
}
