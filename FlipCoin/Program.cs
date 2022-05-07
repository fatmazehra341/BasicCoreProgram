// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//class Power
class FlipFlop
{
	//Function to find count of head and tail
	public static Tuple<int, int>Count_ht(char s,int N)
    {
		//check if initially all the coins are facingtowards head
		Tuple<int, int> p = Tuple.Create(0, 0);
		if (s == 'H')
		{
			p = Tuple.Create((int)Math.Floor(N / 2.0),
							 (int)Math.Ceiling(N / 2.0));
		}
		else if (s == 'T')
		{
			p = Tuple.Create((int)Math.Ceiling(N / 2.0), (int)Math.Ceiling(N / 2.0));
		}
			return p;
        }
		static void Main()
        {
			char C = 'H';
			int N = 3;
			Tuple<int, int> p = Count_ht(C,N);
			Console.WriteLine("Head = " + p.Item1);
			Console.WriteLine("Tail = " + p.Item2);
        }
    }
	