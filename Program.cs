using System;

namespace BA1K
{
	class Program
	{ public static int Patterntonumber(string pattern)
		{
			int res = 0;
			int k = 0;
			for (int i = pattern.Length - 1; i>= 0; i--)
			{
				if (pattern.Substring(i, 1) == "C")
					res = (int)(res + 1 * Math.Pow(4,k));
				if (pattern.Substring(i, 1) == "G")
					res = (int)(res + 2 * Math.Pow(4, k));
				if (pattern.Substring(i, 1) == "T")
					res = (int)(res + 3 * Math.Pow(4, k));
				k += 1;
			}
			return res;
		}
		public static int[] FrequencyArray(string text, int k)
		{
			int[] array = new int[(int)Math.Pow(4, k)];
			for (int i = 0; i < array.Length; i++)
				array[i] = 0;
			for (int i = 0; i <= text.Length - k; i++)
			{
				int num = Patterntonumber(text.Substring(i, k));
				array[num] += 1;

			}
			return array;
		}
		static void Main(string[] args)
		{
			//int z = Patterntonumber("AGT");
			//Console.WriteLine(z);
			int[] niz = FrequencyArray("ACGCGGCTCTGAAA", 2);
			for (int i = 0; i <niz.Length; i++)
				Console.Write(niz[i] + " ");
			Console.WriteLine("kraj");
		}
	}
}
