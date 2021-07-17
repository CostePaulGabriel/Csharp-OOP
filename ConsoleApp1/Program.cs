using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{	 class Applications
	{
		public static void P29(string Str)
		{
			string adding = "";
			for (int i = 0; i < Str.Length; i++)
			{
				if (i % 2 == 0)
				{
					adding += Str[i];
				}
			}
			Console.WriteLine(adding);
		}
		public static string P30(string Str)
		{
			string adding = string.Empty;

			for (int i = 0; i < Str.Length; i++)
			{
				adding += Str.Substring(0, i + 1);
			}

			return adding;
		}

		public static int P31(string Str)
		{
			var count = 0;

			string search = Str.Substring(Str.Length - 2);

			for (int i = 0; i < Str.Length - 2; i++)
			{
				if (Str.Substring(i, 2).Equals(search))
				{
					count++;
				}
			}
			return count;
		}
		public static void P32(int[] array, int n)
		{
			for (int i = 0; i < array.Length; i++)
			{

				Console.WriteLine(n == array[i] ? true : false);

			}


		}
		public static void P33(int[] array, int n)
		{
			int ct = 0;

			for (int i = 0; i < 4; i++)
			{
				if (array[i] == n)
				{
					ct++;
				}
			}
			Console.WriteLine(ct != 0 ? true : false);
		}
		public static void P34(int[] array)
		{
			int check = 0;
			for (int i = 0; i < array.Length - 2; i++)
			{
				if (array[i] == 1 && array[i + 1] == 2 && array[i + 2] == 3)
				{
					check = 1;
				}
			}

			Console.WriteLine(check != 0 ? true : false);
		}
		public static void P35(string a, string b)
		{
			var pos = 0;
			for (int i = 0; i < a.Length - 1; i++)
			{
				for (int j = 0; j < b.Length - 1; j++)
				{

					if (a.Substring(i, 2).Equals(b.Substring(j, 2)))
					{
						pos++;
					}
				}
			}

			Console.WriteLine(pos);
		}
		public static void P36(string a, char b)
		{
			for (var i = 0; i < a.Length - 1; i++)
			{
				if (a[i].Equals(b))
				{
					a = a.Remove(i, 1);
				}
			}
			Console.WriteLine(a);
		}

		public static void P37(string a)
		{
			string copy = string.Empty;

			for (int i = 0; i < a.Length; i += 4)
			{
				var c = i + 2;
				var n = 0;
				n += c > a.Length ? 1 : 2;
				copy += a.Substring(i, n);
			}

			Console.WriteLine(copy);
		}

		public static void P38(int[] array, int n)
		{
			//Array.Length-1 is the last element
			int ct = 0;
			for (int i = 0; i < array.Length - 1; i++)
			{
				if (array[i].Equals(n) && array[i + 1].Equals(n) || array[i + 1].Equals(n + 1))
				{
					ct++;
				}
			}

			Console.WriteLine(ct);
		}
		public static void P39(int[] array)
		{
			int n;
			for (int i = 0; i < array.Length - 1; i++)
			{
				n = array[i];
				if (n == array[i + 1] && n == array[i + 2])
				{
					Console.WriteLine(true);
					break;
				}
				else
				{
					Console.WriteLine(false);
				}
			}


		}
		public static int P40(int n1, int n2)
		{
			var sum = n1 + n2;

			return sum > 10 && sum <= 20 ? 30 : sum;

		}
		public static void P41(int n1, int n2)
		{
			var sum = n1 + n2;
			var dif = Math.Abs(n1 - n2);

			Console.WriteLine((n1 == 5 || n2 == 5 || sum == 5 || dif == 5) ? true : false);
		}
		public static void P42(int nr)
		{
			Console.WriteLine(nr % 13 == 0 || nr % 13 == 1 ? true : false);
		}
		public void P43(int nr)
		{
			if (nr > 0)
			{
				if (nr % 3 == 0)
					Console.WriteLine("Number {0} is a multiple of 3.", nr);
				if (nr % 7 == 0)
					Console.WriteLine("Number {0} is a multiple of 7.", nr);
				if (nr % 3 == 0 && nr % 7 == 0)
					Console.WriteLine("Number {0} is not a multiple of 3, neither of 7.", nr);
			}
			else Console.WriteLine($"Your number is not positive. ({nr})");
		}
		public static void P44a(int nr)
		{
			int[] array = { 2, 5, 10 };
			var check = 0;
			for (int i = 0; i < array.Length; i++)
			{
				if (nr % array[i] == 0)
				{
					check += 1;
				}
			}
			Console.WriteLine(check != 0 ? true : false);
		}
		public static bool P44(int nr)
		{
			return nr % 10 <= 2 || nr % 10 >= 8;
		}
		public static void P45(int nr1, int nr2)
		{
			Console.WriteLine(nr1 >= 10 && nr1 <= 20 || nr2 >= 10 && nr2 <= 20 ? 18 : nr1 + nr2);
		}
		public static string P46(string Str)
		{
			if (Str[0].Equals('F'))
				return "Fizz";
			if (Str[Str.Length - 1].Equals('B'))
				return "Buzz";
			if (Str[0].Equals('F') && Str[Str.Length - 1].Equals('B'))
				return "FizzBuzz";
			else return Str;
		}

		public static void P47(int n1, int n2, int n3)
		{
			Console.WriteLine(n1 + n2 == n3 ? true : false);
		}
		public static void P48(int x, int y, int z)
		{
			Console.WriteLine(y > x && z > y ? true : false);
		}
		public static bool P49(int x, int y, int z, bool flag)
		{
			return flag ? x <= y && y <= z : x < y && y < z;
		}
		public static bool P50(int x, int y, int z)
		{
			int lastrightdigit = x % 10;

			if (lastrightdigit == x % 10 && lastrightdigit == y % 10 && lastrightdigit == z % 10)
				return true;
			else if (lastrightdigit == x % 10 && lastrightdigit == y % 10 || lastrightdigit == z % 10)
				return true;
			else return false;
		}
		public static void P51(int n1, int n2, int n3)
		{
			Console.WriteLine(n3 - n1 == 20 || n2 - n1 == 20 || n2 - n3 == 20 ? true : false);
		}
		public static void P52(int x, int y)
		{
			if (x == y)
				Console.WriteLine(0);
			else Console.WriteLine(x % 7 == y % 7 ? Math.Min(x, y) : Math.Max(x, y));
		}

		public static void P53(int x, int y)
		{
			while (x <= 99 && y <= 99 && x > 10 && x > 10)
			{
				if (x % 10 == y % 10)
				{
					Console.WriteLine(true);
					break;
				}
				else Console.WriteLine(false);
			}
		}
		public static void P54(int nr1, int nr2)
		{
			Console.WriteLine((nr1 + nr2).ToString().Length > nr1.ToString().Length ? nr1 : nr1 + nr2);
		}
		public static void P55(int nr1, int nr2, int nr3)
		{
			Console.WriteLine(nr1 != nr2 || nr1 != nr3 || nr2 != nr3 ? nr1 + nr2 + nr3 : nr3);
		}

		public void P56(int n1, int n2, int n3)
		{
			int sum = 0;
			Console.WriteLine(n1 == 13 ? sum += 0 : (n2 == 13) ? sum += n1 : (n3 == 13) ? sum += n1 + n2 : n1 + n2 + n3);
		}
		private int P57Result(int n)
		{
			return (n < 13 && n > 9) && (n < 17 && n < 21) ? 0 : n;
		}
		public static void P57(int n1, int n2, int n3)
		{
			//Create an instance of the private non-static method P57Result
			//to access an private method inside a class use "Class name" + "." + "Method(-/parameter)";
			Applications refe = new Applications();
			Console.WriteLine(refe.P57Result(n1) + refe.P57Result(n2) + refe.P57Result(n3));
		}
		public static void P58(int n1, int n2)
		{
			if (n1 > 13 && n2 > 13)
				Console.WriteLine(0);
			else Console.WriteLine(Math.Abs(n1 - 13) < Math.Abs(n2 - 13) ? n1 : n2);
		}
		public static void P59(int small, int medium, int large)
		{
			Console.WriteLine(small - medium == medium - large ? true : false);
		}
		public string P60(string S1, string S2)
		{
			return S1 + S2 + S2 + S1;
		}
		public string P61(string S1, string S2)
		{
			return S1.Substring(0, 2) + S2 + S1.Substring(2, 2);
		}
		public static void P62(string S)
		{
			string NewString = S.Substring(S.Length - 2, 2) + S.Substring(S.Length - 2, 2) + S.Substring(S.Length - 2, 2);

			Console.WriteLine(S.Length >= 2 ? NewString : "No action performed.");
		}
		public static string P63(string Str)
		{
			return (Str.Length >= 2 ? Str.Substring(0, 2) : Str);
		}
		public static void P64(string Str)
		{
			Console.WriteLine(Str.Substring(0, Str.Length / 2));
		}
		public static void P65(string Str)
		{
			Console.WriteLine(Str.Length > 2 ? Str.Substring(1, Str.Length - 2) : "No action performed.");
		}
		public static void P66(string S1, string S2)
		{
			Console.WriteLine(S1.Length < S2.Length ? S2 + S1 + S2 : S1 + S2 + S1);
		}
		public static void P67(string S1, string S2)
		{
			Console.WriteLine(S1.Length > 1 && S2.Length > 1 ? S1.Substring(1, S1.Length - 1) + S2.Substring(1, S2.Length - 1) : "No action performed.");
		}
		public static void P68(string Str)
		{
			Console.WriteLine(Str.Length > 2 ? Str.Substring(2, Str.Length - 2) + Str.Substring(0, 2) : Str);
		}
		public static void P69(string Str)
		{
			Console.WriteLine(Str.Length > 2 ? Str.Substring(Str.Length - 2, 2) + Str.Substring(0, Str.Length - 2) : Str);
		}
		public static void P70(string Str)
		{
			Console.WriteLine(Str.Substring(1, Str.Length - 2));
		}
		public static void P71(string Str)
		{
			Console.WriteLine(Str.Length > 2 ? Str.Substring(1, Str.Length - 2) : Str);
		}
		public bool P72(string Str)
		{
			return Str.EndsWith("on") ? true : false;
		}
		public static void P73(string Str, int n)
		{
			Console.WriteLine(Str.Length > n ? Str.Substring(0, n) + Str.Substring(Str.Length - n, n) : Str);
		}
		public static void P74(string Str, int n)
		{
			Console.WriteLine(Str.Length > 2 ? Str.Substring(n - 1, 2) : Str);
		}
		public static void P75(string Str)
		{
			Console.WriteLine(Str.Length > 3 ? Str.Substring(1, Str.Length / 2) : Str);
		}
		public static void P76(string Str)
		{
			if (Str.Length > 2)
			{
				Console.WriteLine(Str.Substring(0, 2));
			}
			else Console.WriteLine(Str.Length.Equals(1) ? Str += "#" : Str += "##");

		}
		public static string P77(string S1, string S2)
		{
			return S1.Length.Equals(0) ? "#" + S2.Substring(S2.Length - 1, 1) : S2.Length.Equals(0) ? S1.Substring(0, 1) + "#" : S1.Length.Equals(0) && S2.Length.Equals(0) ? "##" : S1.Substring(0, 1) + S2.Substring(S2.Length - 1, 1);
		}
		public static void P78(string S1, string S2)
		{
			Console.WriteLine(S1.EndsWith(S2.Substring(0, 1)) ? S1.Substring(0, S2.Length - 1) + S2 : S1 + S2);
		}
		public static void P79(string S1)
		{
			var Empty = string.Empty;
			Empty = S1.Substring(0, S1.Length - 2) + S1.Substring(S1.Length - 1, 1) + S1.Substring(S1.Length - 2, 1);
			Console.WriteLine(Empty);
		}
		public static void P80(string S1)
		{
			if (S1.Length > 2)
			{
				Console.WriteLine(S1.StartsWith("abc") ? "abc" : S1.StartsWith("xyz") ? "xyz" : "empty...");
			}
			else Console.WriteLine("No actions performed");
		}
		public bool P81(string Str)
		{
			return Str.Substring(0, 2).Equals(Str.Substring(Str.Length - 2, 2));
		}
		public static void P82(string Str1, string Str2)
		{
			if (Str1.Length > Str2.Length)
			{
				Console.WriteLine(Str1.Substring(Str1.Length - Str2.Length) + Str2);
			}
			else if (Str2.Length > Str1.Length)
			{
				Console.WriteLine(Str1 + Str2.Substring(Str2.Length - Str1.Length));
			}
			else Console.WriteLine(Str1 + Str2);
		}

		public static void P83(string Str)
		{

			Console.WriteLine(Str.Length > 2 ? Str.Substring(0, 2) + Str.Substring(0, 2) + Str.Substring(0, 2) : Str + Str + Str);
		}

		public static void P84(string Str)
		{
			if (Str.Substring(0, 2).Equals(Str.Substring(Str.Length - 2, 2)))
			{
				Console.WriteLine(Str.Substring(2, Str.Length - 2));
			}
			else Console.WriteLine(Str);
		}
		public static void P85(string Str)
		{
			Console.WriteLine(Str.Substring(0, 2).Equals("py") ? Str :
							  Str.Substring(1, 1).Equals("y") ? Str.Substring(1, 1) + Str.Substring(2, Str.Length - 2) :
							 Str.Substring(0, 1).Equals("p") ? Str.Substring(0, 1) + Str.Substring(3, Str.Length - 3) :
								Str.Substring(2, Str.Length - 2));
		}
		public static void P86(string Str)
		{
			Console.WriteLine(Str.Substring(0, 1).Equals("a") && Str.Substring(Str.Length - 1, 1).Equals("a") ? Str.Substring(1, Str.Length - 2) : Str);

		}
		public static void P87(string Str)
		{
			if (Str.Length == 1 && Str.Substring(0, 1) == ("a"))
			{
				Str = Str.Remove(0, 1);
			}
			if (Str.Length > 1)
			{
				if (Str.Substring(1, 1).Equals("a"))
				{
					Str = Str.Remove(1, 1);
				}
				if (Str.Substring(0, 1).Equals("a"))
				{
					Str = Str.Remove(0, 1);
				}
			}

			Console.WriteLine(Str);
		}
		public static void P88(int [] array)
		{
			Console.WriteLine(array[0] == 10 || array[array.Length - 1] == 10 ? true : false);
		}
		public static bool P89(int [] array)
		{
			return array[0] == array[array.Length - 1];
		}
		public static void P90(int [] arr1, int [] arr2)
		{
			Console.WriteLine(arr1[0]==arr2[0] || arr1[arr1.Length-1]==arr2[arr2.Length-1]?true:false);
		}
		public static void P91(int [] arr1)
		{
			var sum = 0;

			for (int i = 0; i < arr1.Length; i++)
			{
				sum += arr1[i];
			}

			Console.WriteLine("Sum of all elements in the array is :{0}", sum);
		}
		public static void P92(int [] array)
		{	
			Console.WriteLine("array is: {0},{1},{2},{3}",array[1],array[2],array[3],array[0]);
		}
		public static void P93(int [] array)
		{
			Console.WriteLine("inversed array: ");
			for (int i = array.Length-1; i >= 0; i--)
			{
				Console.Write("{0} ", array[i]);
			}
		}
		public static void P94(int [] array)
		{
			var max = array[0];
			int[] arraycopy = new int[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				if(array[i]>max)
				{
					max = array[i];
				}
			}

			for (int i = 0; i < array.Length; i++)
			{
				arraycopy[i] = max;
				Console.Write("{0} ", arraycopy[i]);
			}
		}

		public static void P95(int [] arr1, int [] arr2)
		{
			Console.WriteLine("{0},{1}",arr1[2],arr2[2]);
		}

		public static void P96(int []arr1)
		{
			Console.WriteLine("{0},{1}", arr1[0]  ,arr1[arr1.Length-1]);
			
		}

		public static void P97(int []array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == 15 || array[i] == 20)
				{
					Console.WriteLine(true); break;
				}
				else Console.WriteLine(false);
			}
			
		}

		public static void P98(int[] array)
		{
			foreach(var value in array)
			{
				Console.WriteLine(value.Equals(15) || value.Equals(20) ? false : true);
				break;
			}

		}
		public static void P99(int[]array)
		{
			var First = array[0];
			int[] CpyArray = new int[array.Length];
			for (int i = 1; i < array.Length; i++)
			{
				CpyArray[i] = 0;
			}
			CpyArray[0] = First;
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write("{0} ", CpyArray[i]);
			}
		}
		public static bool P100(int[]array)
		{
			return array[0] == 10 && array[1] == 10 || array[0] == 20 && array[1] == 20;
		}
		public static void P101(int [] array)
		{
			var pos = 0;
			for (int i = 0; i < array.Length-1; i++)
			{
				if(array[i]==5)
				{
					pos = i;
				}
				if(array[pos+1]==7)
				{
					array[pos + 1] = 1;
				}
				
			}
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write("{0} ", array[i]);
			}
		}

		public static void P102(int []arr1,int []arr2)
		{
			var sum = 0;
			var sum2 = 0;
			for (int i = 0; i < arr1.Length; i++)
			{
				sum += arr1[i];
			}
			for (int i = 0; i < arr2.Length; i++)
			{
				sum2 += arr2[i];
			}

			Console.WriteLine("largest sum in in the {0} aray, which is equal to : {1}.",sum>sum2?"first":"second",sum>sum2?sum:sum2);
		}
		public static int [] P103(int [] arr)
		{
			return new int[] {arr[arr.Length/2-1],arr[arr.Length/2] };
		}

		public static void P104(int [] arr1, int [] arr2)
		{
			int i;
			int[] arrayMerge = new int[arr1.Length+arr2.Length];

			for ( i = 0; i < arr1.Length; i++)
			{
				arrayMerge[i] = arr1[i];
			}

			for (int j = 0; j < arr2.Length; j++)
			{
				arrayMerge[i] = arr2[j];
				i++;
			}

			for ( i = 0; i < arrayMerge.Length; i++)
			{
				Console.Write("{0} ", arrayMerge[i]);
			}
		}

		public static void P105(int [] array)
		{
			var temp = 0;

			for (int i = 0; i < array.Length; i++)
			{
				temp = array[0];
				array[0] = array[array.Length - 1];
				array[array.Length - 1] = temp;
			}

			for (int i = 0; i < array.Length; i++)
			{
				Console.Write("{0} ", array[i]);
			}
		}
		public static int [] P106(int [] array)
		{
			return new int[] {array[array.Length/2-1],array[array.Length/2],array[array.Length/2+1] };
		}
		public static int P107(int []array)
		{
			
			var firstelement = array[0];
			var middleelement = array[array.Length / 2];
			var lastelement = array[array.Length - 1];
			var max = firstelement;

			if (middleelement > max)
				max = middleelement;
			if (lastelement>max)
				 max = lastelement;

			return max;
		}
		public int [] P108(int [] array)
		{
			return array.Length > 2 ? new int[] { array[0], array[1] } : new int[array[0]];

		}
		public static int P109(int [] array)
		{
			var ct = 0;

			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] % 2 == 0)
					ct++;
			}

			return ct;
		}
		public static int P110(int [] arr)
		{
			var max = arr[0];
			var min = arr[0];

			for (int i = 0; i < arr.Length; i++)
			{
				if(arr[i]>max)
				{
					max = arr[i];
				}
				else if(arr[i]<min)
				{
					min = arr[i];
				}
			}

			return  max - min;
		}

		public static int P111(int [] arr)
		{
			var sum = 0;
			
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] == 17)
					continue;
				else sum += arr[i];
			}

			return arr.Length > 1 ? sum : 0;
		}
		public static int P112(int [] arr)
		{
			var sum = 0;

			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] == 5 && arr[i+1] == 6)
					i++;	//continue
				else sum += arr[i];
			}
			return sum;
		}

		public static bool P113(int [] arr)
		{ var check = 0;
			for (int i = 0; i < arr.Length-1; i++)
			{
				if (arr[i] == 5 && arr[i + 1] == 5)
					check = 1;
			}

			return check == 1?true:false;
		}
		public static void P114(int [] arr)
		{
			var check = 1;
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] == 5 || arr[i] == 7)
					check = 0;
			}

			Console.WriteLine(check == 1 ? false : true);
		}
		public static void P115(int []array)
		{
			var ct = 0;

			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == 5)
					ct++;
			}

			Console.WriteLine(ct == 3 ? true : false);
		}
		public static bool P116(int []array)
		{
			var ct3 = 0;
			var ct5 = 0;

			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == 3)
					ct3++;
				if (array[i] == 5)
					ct5++;
			}
			return ct3 > ct5 ? true:false;
		}
		public static void P117(int []array)
		{
			var check = 0;

			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == 3 || array[i] == 5)
					check = 1;
			}

			Console.WriteLine(check == 1?"Array contains 5`s or 3`s.":"Array does not contain 3`s or 5`s.");
		}
		public static bool P118(int []array)
		{
			var checker = 0;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == 3 && array[i] == 5)
					checker = 0;
				else checker = 1;
			}

			return checker == 1 ? true : false;
		}
		public static void P119(int []array)
		{
			var pair = 0;

			for (int i = 0; i < array.Length-1; i++)
			{
				if (array[i] == 3 && array[i + 1] == 3)
					pair = 1;
				if (array[i] == 5 && array[i + 1] == 5)
					pair = 1;
			}

			Console.WriteLine(pair == 1 ? true : false);
		}
		public static void P120(int []array)
		{
			var Check = 0;

			for (int i = 0; i < array.Length-1; i++)
			{
				if (array[i] == 5 && array[i + 1] == 5)
					Check = 1;
				for (int j = 0; j < array.Length-2; j++)
				{
					if (array[j] == 5 && array[j + 2] == 5)
					Check = 1;
				}
				
			}

			Console.WriteLine(Check == 1 ?true:false);
		}
		public static void P121(int [] array)
		{
			var Check = 0;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == 3)
					Check = 1;
				if (Check == 1)
				{
					for (int j = 0; j < array.Length; j++)
					{
						if (array[j] == 5)
							Check = 2;
					}
				}
			}
			Console.WriteLine(Check == 2 ? true : false);
		}
		public static void P122(int [] array)
		{
			var Checker = 0;
			for (int i = 0; i < array.Length-1; i++)
			{
				if (array[i] % 2 == 1 && array[i + 1] % 2 == 1 || array[i] == array[i + 1])
					Checker = 1;
			}

			Console.WriteLine(Checker == 1 ? true : false);
		}
		public static void P123(int [] array)
		{
			var ct = 0;

			for (int i = 0; i < array.Length; i++)
			{
				if(array[i]==5)
				{
					for (int j = 1; j < array.Length-1; j++)
					{
						if (array[i] == 5 && array[j] == 5)
						{
							continue;
						}
						else ct++;
					}
				}
			}
			Console.WriteLine(ct >= 5 ? true : false);
		}
		public static void P124(int[] array)
		{
			var check = false;
			for (int i = 0; i < array.Length; i++)
			{
				if(array[i]==5)
				{
					if (i > 0 && array[i - 1] == 5 || i < array.Length - 1 && array[i + 1] == 5) check = true;
					else if (i == array.Length - 1) check = false;
					else check = false;
				}
			}

			Console.WriteLine(check);
			
		}

		public static void P125(int [] array,int element)
		{ var val = 0;

			for (int i = 0; i < array.Length; i++)
			{
				if (array[element-1] == array[array.Length - 1])
					val = 1;
			}
			Console.WriteLine(val == 1 ? true : false);
		}

		public static void P126(int[]array)
		{
			var check = 0;
			for (int i = 0; i < array.Length-1; i++)
			{
				if(array[i]+1==array[i+1] && array[i+1]+1==array[i+2])
				{
					check = 1;
				}
			}
			Console.WriteLine(check == 1 ? true : false);
		}
		public static void P127(int []array)
		{
			int[] ShiftArr = new int[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				ShiftArr[i] = array[(i + 1) % array.Length];
				Console.Write("{0} ", ShiftArr[i]);
			}
		}
		public static void P128(int []array)
		{
			int[] Before5 ;
			var pos = 0;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == 5)
				{
					pos = i;
					break;
				}
			}
			Before5 = new int [pos];
			for (int j = 0; j < Before5.Length; j++)
			{
				Before5[j] = array[j];
				Console.Write("{0} ", Before5[j]);
			}	
		}
		public static void P129(int []array)
		{
			var pos = 0;
			int[] After5;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == 5)
				{
					pos = i;
					break;
				}
			}
			After5 = new int[array.Length-pos-1];

			for (int i = 0; i < After5.Length; i++)
			{
				After5[i] = array[pos+=1];
			}
			for (int i = 0; i < After5.Length; i++)
			{
				Console.Write(After5[i].ToString() + ",");
			}
			
		}
		public static int [] P130(int [] array)
		{
			var pos = 0;
			for (int i = 0; i < array.Length; i++)
			{
				if(array[i]==0)
				{
					array[i] = array[pos];
					array[pos++] = 0; //if there are more elements  which are 0
				}
			}

			return array;
		}
		public static int [] P131 (int [] array)
		{
			var pos = 0;
			int[] array2 = new int[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				if(array[i]!=5)
				{
					array2[pos++] = array[i];
				}
			}
			return array2;
		}

		public static void P132(int []array)
		{
			var index = 0;
			var size = array.Length;
			for (int i = 0; i < size; i++)
			{
				if (array[i] % 2 == 0)
				{
					int temp = array[index];
					array[index] = array[i];
					array[i] = temp;

					index++;
				}
				
			}
			for (int i = 0; i < size; i++)
			{
				Console.Write("{0} ", array[i]);
			}
			
		}
		public static void P133(int [] array)
		{
			bool check = true;
			for (int i = 0; i < array.Length-1; i++)
			{
				if(array[i+1]<array[i])
				{
		
					check = false;
				}
			}
			Console.WriteLine(check == false ? false : true);
		}
		public static void P134(int [] array)
		{
			bool c = false;
			for (int i = 0; i < array.Length-1; i++)
			{
				if (array[i] == 15 && array[i + 1] == 15)
				{
					c = true;
				}  
			}
			Console.WriteLine(c);
		}
		public static void P135(int [] array)
		{
			var sum1 = 0;
			var sum2 = 0;
			for (int i = 0; i < array.Length/2; i++)
			{
				sum1 += array[i] ;
			}
			for (int i = array.Length/2; i < array.Length; i++)
			{
				sum2 += array[i] ;
			}
			Console.WriteLine(sum1 > sum2 ? sum1/(array.Length/2) : sum2/(array.Length/2));
		}
		public static int P136(string [] array,int n)
		{
			var ct = 0;
			for (int i = 0; i < array.Length; i++)
			{
				if(array[i].Length == n)
				{
					ct++;
				}
			}

			return ct;
		}

		public static string [] P137(string [] array,int n)
		{
			string[] array2 = new string[n];
			var I = 0;
			for (int i = 0; i < array2.Length; i++)
			{
				if(n>=1 && n<=array2.Length)
				{
					array2[I++] = array[i];
				}
			}
			return array2;
		}
		public static string [] P138(string [] array ,int n)
		{	
			string[] Copy = new string[10];
			var Index = 0;
			//Counting how many elements
			/*
			for (int i = 0; i< array.Length;i++)
			{
				if(array[i].Length==n)
					copylength++;
			}
			*/ 
			for (int i = 0; i < array.Length; i++)
			{
				if(array[i].Length==n)
				{
					Copy[Index++] = array[i];
				}
			}
			return Copy;
		}

		public static bool P139(int n)
		{
			while(n>0)
			{
				if (n % 10 == 2) return true;
					n /= 10;
			}
			return false;
		}

		public static int [] P140(int [] arr,int oddlength)
		{
			int[] Odd = new int[oddlength];
			var pos = 0;
			var Index = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] % 2 != 0)
				{
					pos = i;
				}
				else continue;
				if (Index < oddlength)
				{
					Odd[Index++] = arr[pos];
				}
			}
			return Odd;
		}

		public static List<int> P141(List<int> I)
		{
			var multiply = 3;

			for (int i = 0; i < I.Count; i++)
			{
				I[i] *= multiply;
			}

			return I;
		}

		public static List<int> P142(List<int> List)
		{
			IEnumerable<int> squared = List.Select(x => x * x * x);
			return squared.ToList();
		}

		public static List<string> P143(List<string>List)
		{
			IEnumerable<string> Add = List.Select(i => "#" + i + "#");

			return Add.ToList();
		}
		public static List<string> P144(List<string>List)
		{
			IEnumerable<string> Duplicate = List.Select(e => e + e + e + e);

			return Duplicate.ToList();
		}

		public static List<int> P145(List<int>List)
		{
			IEnumerable<int> Mutiply = List.Select(x => (x + 2) * 5);

			return Mutiply.ToList();
		}

		public static List<int> P146(List<int>List)
		{
			IEnumerable<int> LastDigit = List.Select(p => p = p % 10);

			return LastDigit.ToList();
		}
		public static List<string> P147(List<string>List)
		{
			IEnumerable<string> ToUpper = List.Select(e => e.ToUpper());

			return ToUpper.ToList();
		}

		public static List<string> P148(List<string>List)
		{
			IEnumerable<string> RemoveA = List.Select(a => a.Replace("a",""));

			return RemoveA.ToList();
		}
		public List<int> P149(List<int>List)
		{
			return List.Where(n => n < 4).ToList();
		}

		public static List<int> P150(List<int>List)
		{
			return List.Where(n => n % 10 < 7).ToList();
		}
	}
	class Program:Applications
	{
		//1.Sum of 2 int 
		static void Main(string[] args)

		{ // That`s how you can write a color Text;
		  //Console.WriteLine() is a method for printing some text
		  //Console.ReadLine() is a method used to read the text you type from the keyboard

			/*
			-----------------  1. Write/Read Program ----------------

				Console.Title = "1st Program";
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WindowHeight = 40;

				Console.WriteLine("Hello, What`s your name?");

				Console.ReadLine();

				Console.WriteLine("I`m RAN \nI`m a robot");
			*/

			/*----------------- 2. Numbers media ----------------
			  
			int a;
			int b;

			Console.Write("Type the First Number: ");
			a = Convert.ToInt32( Console.ReadLine());

			Console.Write("Type the Second Number:");

			b = Convert.ToInt32( Console.ReadLine());


			double result = (a + b) / 2;

			Console.Write("The Numbers media is " + result);

			// Wait before closing
						Console.ReadKey();
			*/




			//----- Basic algorithms exercises (150 ex)--------

			//1.Write a C# Sharp program to compute the sum of the two given integer values. If the two values are the same, then return triple their sum.

			//method
			/*
			public static int Sum(int n, int m)
			{
				int x = 0;
				if (n == m)
				{
					x = (n + m) * 3;
				}
				else x = n + m;
				return x;
			}

			Console.WriteLine(Sum(3, 3));
			*/

			//2.Write a C# Sharp program to get the absolute difference between n and 51. If n is greater than 51 return triple the absolute difference.

			//--------------Method ---------
			/*
						public static int Result(int n)
						{
							int x = 51;

							if (n > x)
							{
								return (n - x) * 3;
							}
							else return n - x;

						}
						Console.WriteLine(Result(4));
			*/


			//3.Write a C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30.
			/*

			Console.WriteLine(Method(32, 31));

			public static bool Method(int n1, int n2)
			{
				int sum = n1 + n2;

				if (n1 == 30 || n2 == 30 || sum == 30)

					return true;
				else return false;



			}
			*/




			//4.Write a C# Sharp program to check a given integer and return true if it is within 10 of 100 or 200.

			/*



						Console.WriteLine(Test(99));

						public static bool Test(int n)
						{
							if (Math.Abs(n - 100) <= 10 || Math.Abs(n - 200) <= 10)
							{ return true; }

							else return false;
						}
			*/



			//5.Write a C# Sharp program to create a new string where 'if' is added to the front of a given string. If the string already begins with 'if', return the string unchanged.
			/*
						public static string IF(string Word)
						{


							if (Word.Contains("if"))
							{
								Console.WriteLine("Your word remain unchanged");
								return Word;
							}
							else
							{
								Console.WriteLine("\"if\" --- was added to your word.");
								return Word.Insert(0, "if");
							}


						}

						Console.Write("Input a string: ");
						string word = Console.ReadLine();

						Console.WriteLine(IF(word));
			*/




			//6.Write a C# Sharp program to remove the character in a given position of a given string. The given position will be in the range 0.. string length -1 inclusive.
			/*
						Console.Write("Input a word: ");
						string Word = Console.ReadLine();

						Console.Write("Specify a position to delete a character: ");
						int pos = Convert.ToInt32(Console.ReadLine());

						if (pos < Word.Length - 1)
						{
							Console.WriteLine(Word.Remove(pos,1));
						}
						else Console.WriteLine("Position was out of index size.");

			*/

			//7.Write a C# Sharp program to exchange the first and last characters in a given string and return the new string.
			/*
			Console.Write("Input a string : ");
			string Word = Console.ReadLine();

			string a = Word.Substring(0, 1);
			string b = Word.Substring(Word.Length - 1, 1);
			Console.WriteLine(b+ Word.Substring(1, Word.Length - 2) + a);

*/
			//8.Write a C# Sharp program to create a new string which is 4 copies of the 2 front characters of a given string. If the given string length is less than 2 return the original string.

			/*
			Console.Write("Input a string: ");
			string Word = Console.ReadLine();

			Console.WriteLine(Word.Length - 1 > 2 ? Word.Substring(0, 2) + Word.Substring(0, 2) + Word.Substring(0, 2) + Word.Substring(0, 2) : Word);
*/

			//9.Write a C# Sharp program to create a new string with the last char added at the front and back of a given string of length 1 or more.
			/*
						Console.Write("Input a string:");
						string Str = Console.ReadLine();

						if (Str.Length - 1 > 0)
						{
							Console.WriteLine(Str.Substring(Str.Length-1,1)+Str+ Str.Substring(Str.Length - 1, 1));
						}
						else Console.WriteLine("Your string is empty.");
			*/



			//10.Write a C# Sharp program to check if a given positive number is a multiple of 3 or a multiple of 7.
			/*
						Console.Write("Input a number:");
						int number = Convert.ToInt32(Console.ReadLine());

						if (number % 3 == 0 || number % 7 == 0)
						{
							Console.WriteLine(true);
						}
						else Console.WriteLine(false);
			*/

			//11.Write a C# Sharp program to create a new string taking the first 3 characters of a given string and return the string with the 3 characters added at both the front and back. If the given string length is less than 3, use whatever characters are there.
			/*
			Console.Write("Input a word: ");
			string Word = Console.ReadLine();

			if (Word.Length > 3)
			{
				Console.WriteLine(Word.Substring(0, 3) + Word + Word.Substring(0, 3));
			}
			else Console.WriteLine(Word.Substring(0,Word.Length) + Word + Word.Substring(0,Word.Length));
*/

			//12. Write a C# Sharp program to check if a given string starts with 'C#' or not.
			/*
			Console.Write("Input a string: ");
			string Str = Console.ReadLine();
			string a = "C#";
			if (Str.StartsWith(a))
			{
				Console.WriteLine(true);
			}
			else Console.WriteLine(false);
*/

			//13.Write a C# Sharp program to check if one given temperatures is less than 0 and the other is greater than 100.
			/*
						Console.Write("input a temp:");
						int a = int.Parse(Console.ReadLine());
						int b = int.Parse(Console.ReadLine());


						if(a<0 && b < 100 || a>100 && b<0)

								Console.WriteLine(true);
						else Console.WriteLine(false);
			*/


			//14.Write a C# Sharp program to check two given integers whether either of them is in the range 100..200 inclusive.
			/*
						Console.Write("input 2 intigers:");
						int n = int.Parse(Console.ReadLine());
						int m = int.Parse(Console.ReadLine());

						if (n < 200 && n >= 100 || m < 200 && m >= 100)
						{
							Console.WriteLine(true);
						}
						else Console.WriteLine(false);

			*/

			//15. Write a C# Sharp program to check whether three given integer values are in the range 20..50 inclusive. Return true if 1 or more of them are in the said range otherwise false.
			/*
			Console.Write("input 3 intigers:");
			int n = int.Parse(Console.ReadLine());
			int m = int.Parse(Console.ReadLine());
			int p = int.Parse(Console.ReadLine());
			if (n < 50 && n >= 20 || m < 50 && m >= 20 || p<50 && p>=20)
			{
				Console.WriteLine(true);
			}
			else Console.WriteLine(false);
			*/

			//16.Write a C# Sharp program to check whether two given integer values are in the range 20..50 inclusive. Return true if 1 or other is in the said range otherwise false.

			//--------------------Same------------------


			//17.Write a C# Sharp program to check if a string 'yt' appears at index 1 in a given string. If it appears return a string without 'yt' otherwise return the original string.
			/*
						Console.WriteLine("input a string:");
						string Str = Console.ReadLine();
						string chk = "yt";

						Console.WriteLine(Str.Substring(1, 2).Equals(chk) ? Str.Remove(1,2) : Str);
			*/


			//18.Write a C# Sharp program to check the largest number among three given integers.
			/*
						int[] array = new int[3];

						Console.WriteLine("Input 3 numbers: ");
						int max = array[0];
						for (int i = 0; i < array.Length; i++)
						{
							array[i] = Convert.ToInt32(Console.ReadLine());
							if(array[i]>max)
							{
								max = array[i];
							}
						}

						Console.WriteLine("Maximum element is : {0}.", max);
			*/
			/*
						//Another way of solving with a method
						public static int _Max(int n1, int n2, int n3)
						{
							int max = Math.Max(n1, (Math.Max(n2, n3)));

							return max;
						}
						Console.WriteLine("Maximum element is: {0}",_Max(2, 3, 4)+".");
			*/



			//19.Write a C# Sharp program to check which number nearest to the value 100 among two given integers. Return 0 if the two numbers are equal.
			/*
						public static int _Nearest(int n1, int n2)
						{
							int result = 0;
							if (n1 < 100 && n1 > 0 || n2 < 100 && n2 > 0)
							{
								if (n1 > n2)
								{
									result = n1;
								}
								else result = n2;
							}
							if (n1 == n2)
								return 0;

							return result;
						}

						Console.WriteLine("Nearest value to 100 is : {0}.", _Nearest(98, 99));

			*/


			//Another way of solving with Math.Abs() Method wich substracts the value of 100 from the input integer
			/*
						public static int _NearestTo100(int n1, int n2)
						{
							int result1 = Math.Abs(100 - n1);
							int result2 = Math.Abs(100 - n2);

							return n1 == n2 ? 0 : (result1 < result2 ? n1 : n2);


						}
						Console.WriteLine("Closer to 100: {0}.",_NearestTo100(99,89));

			*/



			//20.Write a C# Sharp program to check whether two given integers are in the range 40..50 inclusive, or they are both in the range 50..60 inclusive.
			/*
			public static bool _InRange(int n1, int n2)
			{
				if ((n1 >= 40 && n1 <= 50 && n2 <= 50 && n2 >= 40) || (n1 >= 50 && n1 <= 60 && n2 <= 60 && n2 >= 50))
					return true;
				else return false;
			}
			Console.WriteLine("Result : {0}.", _InRange(45, 60));
			*/

			//21.Write a C# Sharp program to find the larger value from two positive integer values that is in the range 20..30 inclusive, or return 0 if neither is in that range.
			/*
						public static int _Max(int x, int y)
						{
							int max = Math.Max(x, y);
							return max >= 20 && max <= 30 ? max : 0;
						}
						Console.WriteLine(_Max(20, 30));
			*/


			//22.Write a C# Sharp program to check if a given string contains between 2 and 4 'z' character.
			/*
						public static bool ContainsZ(string Str)
						{
							int check = 0;

							foreach (var item in Str)
							{
								if (item.Equals('z'))
								{
									check++;
								}
							}

							return (check >= 2 && check <= 4) ? true : false;


						}
						Console.WriteLine("Your string contains z? : {0}.", ContainsZ("zzzabc"));
			*/

			//23. Write a C# Sharp program to check if two given non-negative integers have the same last digit.
			/*
						public static bool Lastdigit(int n1, int n2)
						{
							int ld1 = n1 % 10;
							int ld2 = n2 % 10;


							return (n1 > 0 && n2 > 0) ? (ld1 == ld2 ? true : false) : false;


						}

						Console.WriteLine(Lastdigit(4, 14));
			*/

			//24.Write a C# Sharp program to convert the last 3 characters of a given string in upper case. If the length of the string has less than 3 then uppercase all the characters.
			/*
						public static string _Upper(string Str)
						{
							string last3 = Str.Substring(Str.Length - 3, 3);
							return (Str.Length > 3) ? Str.Substring(0, Str.Length - 3) + last3.ToUpper() : Str.ToUpper();
						}

						Console.WriteLine(_Upper("abecedar"));
			*/


			//25.Write a C# Sharp program to create a new string which is n (non-negative integer) copies of a given string.
			/*

						public static string StringCopy(string Str, int copy)
						{
							string result = "";

							if (Str.Length > 0)
							{
								for (int i = 0; i < copy; i++)
								{
									result += Str;
								}
							}
							return result;
						}

						Console.WriteLine(StringCopy("abc", 3));
			*/




			//26.Write a C# Sharp program to create a new string which is n (non-negative integer) copies of the the first 3 characters of a given string. If the length of the given string is less than 3 then return n copies of the string.
			/*
			public static string _Copy(string Str, int n)
			{

				string CopyString = "";
				if (Str.Length > 3)
				{
					for (int i = 0; i < n; i++)
					{
						string char3 = Str.Substring(0, 3);
						CopyString += char3;
					}
					return CopyString;
				}
				else
				{
					for (int i = 0; i < n; i++)
					{
						CopyString += Str;
					}
					return CopyString;
				}
			}

			Console.WriteLine(_Copy("Python", 2));
			*/



			//27.Write a C# Sharp program to count the string "aa" in a given string and assume "aaa" contains two "aa".
			/*
			public static void _countA(string Str)
			{
				int ct_aa = 0;

				if (Str.Contains('a'))
				{
					for (int i = 0; i < Str.Length - 1; i++)
					{
						if (Str.Substring(i, 2).Equals("aa"))
						{
							ct_aa++;
						}
					}
					Console.WriteLine(ct_aa);
				}
				else Console.WriteLine("String DOES NOT contain character \"a\".");
			}

			Console.Write("Input a string; ");
			string Str = Console.ReadLine();

			 _countA(Str);

			*/


			//28.Write a C# Sharp program to check if the first appearance of "a" in a given string is immediately followed by another "a".
			/*
						public static bool DoubleAA(string Str)
						{
							if (Str.Contains('a'))
							{
								var IndexOfA = Str.IndexOf('a');
								return Str.Substring(IndexOfA, 2).Equals("aa") ? true : false;
							}
							else return false; ;
						}

						Console.WriteLine(DoubleAA("caabb"));
						Console.WriteLine(DoubleAA("babaaba"));
						Console.WriteLine(DoubleAA("aaaaa"));
			*/



			//29.Write a C# Sharp program to create a new string made of every other character starting with the first from a given string.	
			//=============== Inherited class to Program ===============
			/*	P29("Python"); */

			//30.Write a C# Sharp program to create a string like "aababcabcd" from a given string "abcd". 
			//=============== Inherited class to Program ===============
			/*Console.WriteLine(P30("abcd"));*/

			//31. Write a C# Sharp program to count a substring of length 2 appears in a given string and also as the last 2 characters of the string. Do not count the end substring.
			/*

						Console.WriteLine(P31("abcdsab"));
						Console.WriteLine(P31("abcdabab"));
						Console.WriteLine(P31("abcabdabab"));
						Console.WriteLine(P31("abcabd"));
			*/

			//32.Write a C# Sharp program to check a specified number is present in a given array of integers.
			/*
						int[] array = { 3, 4, 5, 6, 5, 3, 7, 5, 9 };
						Console.WriteLine("{{0}}",String.Join(",",array));
						Console.Write("search for an element in the array:");
						int n = Convert.ToInt32(Console.ReadLine());
						P32(array, n);
			*/

			//33.Write a C# Sharp program to check if one of the first 4 elements in an array of integers is equal to a given element
			/*
			int[] array = { 1, 2, 9, 3 ,5};
			Console.WriteLine("[{0}]",String.Join(",", array));
			int n = Convert.ToInt32(Console.ReadLine());

			P33(array, n);
			*/

			//34.Write a C# Sharp program to check whether the sequence of numbers 1, 2, 3 appears in a given array of integers somewhere.
			/*
						int[] array = { 1, 1, 2, 1, 2, 3 };
						Console.WriteLine("Array is: "+"[{0}]", String.Join(',', array));
						P34(array);
			*/


			//35.Write a C# Sharp program to compare two given strings and return the number of the positions where they contain the same length 2 substring.

			//P35("abcdefgh", "abijsklm");


			//36. Write a C# Sharp program to create a new string from a give string where a specified character have been removed except starting and ending position of the given string.

			//P36("xxHxix", 'x');

			//37. Write a C# Sharp program to create a new string of the characters at indexes 0,1, 4,5, 8,9 ... from a given string.


			//P37("abecedar");

			//38. Write a C# Sharp program to count the number of two 5's are next to each other in an array of integers. Also count the situation where the second 5 is actually a 6.
			/*
						int[] array = { 5, 6, 2, 9 };
						P38(array,5);
			*/

			//39.Write a C# Sharp program to check if a triple is presents in an array of integers or not. If a value appears three times in a row in an array it is called a triple.

			/*
			int[] array = { 2, 2, 2, 2, 2, 2, 1 };

			P39(array);
			*/

			//40. Write a C# Sharp program to compute the sum of the two given integers. If the sum is in the range 10..20 inclusive return 30.

			//Console.WriteLine(P40(2, 17));

			//41. Write a C# Sharp program that accept two integers and return true if either one is 5 or their sum or difference is 5.

			//P41(3, 5);

			//42. Write a C# Sharp program to test if a given non-negative number is a multiple of 13 or it is one more than a multiple of 13.

			//P42(4);

			//43. Write a C# Sharp program to check if a given non-negative given number is a multiple of 3 or 7, but not both.

			//---------Since we didn`t pass the word "STATIC" when we declared the method P43, we need to create a new INSTANCE of it, so that`s how we do that:
			// INSTANTE THE CLASS ===== "NAME OF THE CLASS" + "VARIABLE NAME" = new "CLASS NAME()";
			/*
			Applications instantiation = new Applications();
			instantiation.P43(3);
			*/

			//44(a).Write a program which verify that a number shares a multiple of the number 10.
			/*
			P44a(3);
			P44a(7);
			P44a(8);
			P44a(21);
			*/


			//44.Write a C# Sharp program to check if a given number is within 2 of a multiple of 10. 
			/*
			Console.WriteLine(P44(3));
			Console.WriteLine(P44(7));
			Console.WriteLine(P44(8));
			Console.WriteLine(P44(21));
			*/

			//45. Write a C# Sharp program to compute the sum of the two given integers. If one of the given integer value is in the range 10..20 inclusive return 18.
			/*
			P45(10, 20);
			P45(21,220);
			*/

			//46. Write a C# Sharp program to check whether a given string starts with "F" or ends with "B". If the string starts with "F" return "Fizz" and return "Buzz" if it ends with "B" If the string starts with "F" and ends with "B" return "FizzBuzz". In other cases return the original string.
			/*
			Console.WriteLine(P46("FizzBuzz"));
			Console.WriteLine(P46("Fizz"));
			Console.WriteLine(P46("Buzz"));
			Console.WriteLine(P46("Founder"));
			*/


			//47. Write a C# Sharp program to check if it is possible to add two integers to get the third integer from three given integers.
			/*
			P47(1, 2, 3);
			P47(4, 5, 6);
			*/




			//48.Write a C# Sharp program to check if y is greater than x, and z is greater than y from three given integers x,y,z.
			/*
			P48(1, 2, 3);
			P48(4, 5, 6);
			P48(-1, 1, 0);
			*/

			//49.Write a C# Sharp program to check if three given numbers are in strict increasing order, such as 4 7 15, or 45, 56, 67, but not 4 ,5, 8 or 6, 6, 8.However,if a fourth parameter is true, equality is allowed, such as 6, 6, 8 or 7, 7, 7.
			/*
			Console.WriteLine( P49(1, 2, 3, false));
			Console.WriteLine(P49(1, 2, 3, true));
			Console.WriteLine(P49(10, 2, 30, false));
			Console.WriteLine(P49(10, 10, 30, true));
			*/

			//50. Write a C# Sharp program to check if two or more non-negative given integers have the same rightmost digit.
			/*
						Console.WriteLine(P50(11, 21, 31));
						Console.WriteLine(P50(11, 22, 31));
						Console.WriteLine(P50(11, 22, 33));
			*/

			//51.Write a C# Sharp program to check three given integers and return true if one of them is 20 or more less than one of the others.
			/*
						P51(11, 21, 31);
						P51(11, 22, 31);
						P51(10, 20, 15);
			*/

			//52. Write a C# Sharp program to find the larger from two given integers. However if the two integers have the same remainder when divided by 7, then the return the smaller integer. If the two integers are the same, return 0.
			/*
						P52(11, 21);
						P52(11, 20);
						P52(10, 10);
			*/
			//53.Write a C# Sharp program to check two given integers, each in the range 10..99. Return true if a digit appears in both numbers, such as the 3 in 13 and 33.

			//P53(11, 21);

			//54. Write a C# Sharp program to compute the sum of two given non-negative integers x and y as long as the sum has the same number of digits as x. If the sum has more digits than x then return x without y.

			//P54(4, 5);

			//55. Write a C# Sharp program to compute the sum of three given integers. If the two values are same return the third value.

			//55(4, 5, 7);

			//56. Write a C# Sharp program to compute the sum of the three integers. If one of the values is 13 then do not count it and its right towards the sum.

			//Instantiate the non-static method	
			/*
						Applications Solution = new Applications();
						Solution.P56(10, 13, 12);
			*/


			//57.Write a C# Sharp program to compute the sum of the three given integers. However, if any of the values is in the range 10..20 inclusive then that value counts as 0, except 13 and 17.

			//P57(7, 4, 12);

			//58. Write a C# Sharp program to check two given integers and return the value whichever value is nearest to 13 without going over. Return 0 if both numbers go over.

			//P58(10, 13);
			//P58(17, 33);

			//59.Write a C# Sharp program to check three given integers (small, medium and large) and return true if the difference between small and medium and the difference between medium and large is same.
			/*
						P59(4, 5, 6);
						P59(7, 12, 13);
						P59(-1, 0,1);
			*/

			//60. Write a C# Sharp program to create a new string using two given strings s1, s2, the format of the new string will be s1s2s2s1.
			/*
			Applications reference = new Applications();
			Console.WriteLine(reference.P60("Hi", "Hello"));
			*/

			//61. Write a C# Sharp program to insert a given string into middle of the another given string of length 4.
			/*

						Applications reference = new Applications();
						Console.WriteLine(reference.P61("[[]]", "ABC"));
			*/



			//62.Write a C# Sharp program to create a new string using three copies of the last two character of a given string of length atleast two.

			//	P62("hello");

			//63. Write a C# Sharp program to create a new string using first two characters of a given string. If the string length is less than 2 then return the original string.

			//Console.WriteLine(P63("Hello"));

			//64. Write a C# Sharp program to create a new string of the first half of a given string of even length.

			//P64("Hello");

			//65. Write a C# Sharp program to create a new string without the first and last character of a given string of length atleast two.

			//P65("Hello");

			//66. Write a C# Sharp program to create a new string from two given string one is shorter and another is longer. The format of the new string will be long string + short string + long string.

			//P66("Hello", "Hi");

			//67. Write a C# Sharp program to concat two given string of length atleast 1, after removing their first character.

			//P67("JS", "Python");

			//68. Write a C# Sharp program to move the first two characters to the end of a given string of length at least two.

			//P68("Hello");

			//69. Write a C# Sharp program to move the last two characters to the start of a given string of length at least two.

			//P69("Hello");

			//70. Write a C# Sharp program to create a new string without the first and last character of a given string of any length.

			//P70("Negri");

			//71. Write a C# Sharp program to create a new string using the two middle characters of a given string of even length (at least 2).

			//P71("Hello");

			//72. Write a C# Sharp program to check if a given string ends with "on".
			/*
						Applications reference = new Applications();

						Console.WriteLine(reference.P72("Python"));
						Console.WriteLine(reference.P72("o"));
						Console.WriteLine(reference.P72("hello"));
			*/

			//73. Write a C# Sharp program to create a new string using the first and last n characters from a given string of length at least n.
			//P73("Hello", 2);

			//74. Write a C# Sharp program to create a new string of length 2 starting at the given index of a given string.

			//P74("Hello", 2);

			//75.Write a C# Sharp program to create a new string taking 3 characters from the middle of a given string at least 3.

			//P75("Python");

			//76.Write a C# Sharp program to create a new string of length 2, using first two characters of a given string. If the given string length is less than 2 use '#' as missing characters.

			//	P76("a"); P76("Hello");P76("");

			//77. Write a C# Sharp program to create a new string taking the first character from a given string and the last character from another given string. If the length of any given string is 0, use '#' as its missing character.
			//Console.WriteLine(P77("Csharp", ""));

			//78.Write a C# Sharp program to concat two given strings (lowercase). If there are any double character in new string then omit one character.

			//P78("abc", "cat");

			//79.Write a C# Sharp program to create a new string from a given string after swapping last two characters.

			//P79("Hello");

			//80. Write a C# Sharp program to check if a given string begins with 'abc' or 'xyz'. If the string begins with 'abc' or 'xyz' return 'abc' or 'xyz' otherwise return the empty string.

			//P80("xyzabc");
			//P80("ats");

			//81. Write a C# Sharp program to check whether the first two characters and last two characters of a given string are same.
			/*
			Applications reference = new Applications();
			Console.WriteLine(reference.P81("abab"));
			Console.WriteLine(reference.P81("abavb"));
			*/

			//82. Write a C# Sharp program to concat two given strings. If the given strings have different length remove the characters from the longer string.

			//P82("abc", "abcd");

			//83. Write a C# Sharp program to create a new string using 3 copies of the first 2 characters of a given string. If the length of the given string is less than 2 use the whole string.

			//P83("abc");
			//P83("a");

			//84. Write a C# Sharp program to create a new string from a given string. If the two characters of the given string from its beginning and end are same return  the given string without the first two characters otherwise return the original string.

			//P84("abcab");
			//P84("Python");

			//85. Write a C# Sharp program to create a new string from a given string without the first two characters. Keep the first character if it is "p" and keep the second character if it is "y".

			//P85("python");
			//P85("hello");
			//P85("What`s upp");

			//86. Write a C# Sharp program to create a new string from a given string without the first and last character if the first or last characters are 'a' otherwise return the original given string.

			//P86("abcd");
			//P86("ababac");
			//P86("aba");

			//87. Write a C# Sharp program to create a new string from a given string. If the first or first two characters is 'a', return the string without those 'a' characters otherwise return the original given string.

			//P87("aaab");
			//P87("abaaba");
			//P87("cod");
			//P87("aaba");

			//88. Write a C# Sharp program to check a given array of integers of length 1 or more and return true if 10 appears as either first or last element in the given array.

			//P88(new []{ 10, 20, 40, 50 });
			//P88(new []{ 12, 24, 35, 55 });

			//89. Write a C# Sharp program to check a given array of integers of length 1 or more and return true if the first element and the last element are equal in the given array.

			//Console.WriteLine(P89(new[] { 10, 20, 40, 50 }));
			//Console.WriteLine(P89(new[] { 10, 20, 40, 10 }));

			//90. Write a C# Sharp program to check two given arrays of integers of length 1 or more and return true if they have the same first element or they have the same last element.

			//P90(new[]  { 10, 20, 40, 50 }, new [] { 1, 20, 40, 1 } );

			//91. Write a C# Sharp program to compute the sum of the elements of an given array of integers.

			//P91(new[] { 10, 20, 30, 40, 50 });

			//92. Write a C# Sharp program to rotate the elements of a given array of integers (length 4 ) in left direction and return the new array.

			//P92(new[] {1,2,3,4 });

			//93. Write a C# Sharp program to reverse a given array of integers and length 5.

			//P93(new[] { 1, 2, 3, 4, 5 });

			//94. Write a C# Sharp program to find out the maximum element between the first or last element in a given array of integers ( length 4), replace all elements with maximum element.

			//P94(new[] { 1, 2, 3, 4, 5});

			//95. Write a C# Sharp program to create a new array containing the middle elements from the two given arrays of integers, each length 5.

			//P95(new[] { 1, 2, 3, 4, 5 }, new[] { 1, 3, 4, 6, 7 });

			//96.Write a C# Sharp program to create a new array taking  the first and last elements of a given array of integers and length 1 or more.

			//P96(new[] { 1, 2, 3, 4, 5 });

			//97. Write a C# Sharp program to check if a given array of integers and length 2, contains 15 or 20.

			//P97(new[] { 1, 2 });
			//P97(new[] { 15, 2});
			//P97(new[] { 15, 20});

			//98. Write a C# Sharp program to check if a given array of integers and length 2, does not contain 15 or 20.

			//P98(new[] { 1, 2 });
			//P98(new[] { 15, 2 });

			//99. Write a C# Sharp program to create a new array of integers and length 1 or more. The length of the new array will be double length of the given array and all the elements are 1 except the first element which is equal to the given array.

			//P99(new[] { 10, 20, -30, -40, 30 });

			//100. Write a C# Sharp program to check a given array of integers and return true if the array contains 10 or 20 twice. The length of the array will be 0, 1, or 2.
			//int[] array = { 12, 20 };
			//Console.WriteLine(P100(array));
			//Console.WriteLine(P100(new[] { 10, 10 }));

			//101. Write a C# Sharp program to check a given array of integers, length 3 and create a new array. If there is a 5 in the given array immediately followed by a 7 then set 7 to 1.

			//P101(new[] { 1, 2, 3, 5, 7 });

			//102. Write a C# Sharp program to compute the sum of the two given arrays of integers, length 3 and find the array which has the largest sum.

			//P102(new[] {1,2,3 }, new[] {3,4,5 });


			//103. Write a C# Sharp program to create an array taking two middle elements from a given array of integers of length even.
			/*
			int [] array = P103(new[]{ 1, 2, 3, 4, 5, 6,7,8 });
			foreach(var element in array)
			{
				Console.Write(element.ToString() + " ");
			}
			*/


			//104. Write a C# Sharp program to create a new array from two give array of integers, each length 3.
			/*
			int []array1 ={ 1,2,3 };
			int[] array2 = { 4, 5, 6 };

			P104(array1, array2);
			*/

			//105. Write a C# Sharp program to create a new array swapping the first and last elements of a given array of integers and length will be least 1.

			//P105(new[] { 1, 2, 3, 4, 5 });


			//106.Write a C# Sharp program to create a new array length 3 from a given array (length atleast 3) using the elements from the middle of the array.
			/*
			int [] item = P106(new[] { 1, 2, 3, 4, 5, 6 });
			for (int i = 0; i < item.Length; i++)
			{
				Console.Write(item[i].ToString() + " ");
			}
			*/

			//107. Write a C# Sharp program to find the largest value from first, last, and middle elements of a given array of integers of odd length (atleast 1).

			//Console.WriteLine(P107(new[] { 1, 2, 3, 4, 5 }));

			//108. Write a C# Sharp program to create a new array taking the first two elements from a given array. If the length of the given array is less than 2 then return the give array.
			/*
			Applications reference = new Applications();
			int [] item = reference.P108(new[] { 1, 2, 3, 4, 5, 6 });
			foreach (var i in item)
			{
				Console.Write(i.ToString() + " ");
			}
			*/

			//109. Write a C# Sharp program to count even number of elements in a given array of integers.
			/*
			int[] arr = { 1,5,7, 10, 12 };
			// the answer will be 2 because 10 & 12 %2 will return 1 and 2
			Console.Write(P109(arr));
			*/
			//110. Write a C# Sharp program to compute the difference between the largest and smallest values in a given array of integers and length one or more.

			//Console.Write(P110(new[] { 1, 2, 3, 4, 5 }));

			//111. Write a C# Sharp program to compute the sum of values in a given array of integers except the number 17. Return 0 if the given array has no integer.

			//Console.Write(P111(new[] {1,15,17 }));

			//112. Write a C# Sharp program to compute the sum of the numbers in a given array except those numbers starting with 5 followed by atleast one 6. Return 0 if the given array has no integer.

			//Console.Write(P112(new[] { 5, 6, 1, 5, 6, 9, 10, 17, 5, 6 }));

			//113. Write a C# Sharp program to check if a given array of integers contains 5 next to a 5 somewhere.

			//Console.WriteLine(P113(new[] { 1, 2, 3, 5, 8, 5 }));
			//Console.WriteLine(P113(new[] { 1, 2, 3, 5, 5, 4 }));


			//114.Write a C# Sharp program to check whether a given array of integers contains 5's and 7's.

			//P114(new[] { 1, 2, 3, 4, 8 });
			//P114(new[] { 1, 2, 3, 5, 7 });

			//115. Write a C# Sharp program to check if the sum of all 5' in the array exactly 15 in a given array of integers.

			//int[] arr = { 1, 2, 3, 5, 6, 5, 3, 5 };
			//P115(arr);


			//116. Write a C# Sharp program to check if the number of 3's is greater than the number of 5's.

			//int[] arr = { 1, 2, 3, 3, 5, 5, 5 };
			//Console.WriteLine(P116(arr));

			//117. Write a C# Sharp program to check if a given array of integers contains a 3 or a 5.

			//P117(new[] { 1, 2, 2, 4, 2 });

			//118. Write a C# Sharp program to check if a given array of integers contains no 3 or a 5. 

			//Console.WriteLine(P118(new[] { 3, 3, 5, 3, 3, 3 }));

			//119. Write a C# Sharp program to check if an array of integers contains a 3 next to a 3 or a 5 next to a 5 or both.

			//P119(new[] { 1, 2, 2, 3, 5, 4, 5 });

			//120. Write a C# Sharp program to check a given array of integers and return true if the given array contains two 5's next to each other, or two  5 separated by one element.

			//P120(new[] { 1, 2, 3, 5, 0, 0, 5 });

			//121. Write a C# Sharp program to check a given array of integers and return true if there is a 3 with a 5 somewhere later in the given array.

			//P121(new[] { 1, 2, 3, 4, 5, 7 });

			//122. Write a C# Sharp program to check a given array of integers and return true if the given array contains either 2 even or 2 odd values all next to each other.

			//P122(new[] { 3, 5, 1, 3, 7 });

			//123. Write a C# Sharp program to check a given array of integers and return true if the value 5 appears 5 times and there are no 5 next to each other.

			//P123(new[] { 3, 5, 1, 5, 3, 5, 7, 5, 5, 5 });
			//P123(new[] { 3, 5, 5, 5, 5, 5, 5 });

			//124. Write a C# Sharp program to check a given array of integers and return true if every 5 that appears in the given array is next to another 5. 
			/*
			P124(new[] { 3, 5, 5, 3, 7 });
			P124(new[] { 3, 5, 5, 4, 1, 5, 7 });
			P124(new[] { 3, 5, 5, 5, 5, 5 });
			P124(new[] { 2, 4, 5, 5, 6, 7, 5 });
			*/

			//125. Write a C# Sharp program to check a given array of integers and return true if the specified number of same elements appears at the start and end of the given array.

			/*
			P125(new[] { 3, 7, 5, 5, 3, 7 }, 2);
			P125(new[] { 3, 7, 5, 5, 3, 7 }, 3);
			P125(new[] { 3, 7, 5, 5, 3, 7, 5 }, 3);
			*/


			//126. Write a C# Sharp program to check a given array of integers and return true if the array contains three increasing adjacent numbers.
			/*
						P126(new[] { 1, 2, 3, 5, 3, 7 });
						P126(new[] { 3, 7, 5, 5, 3, 7 });
						P126(new[] { 3, 7, 5, 5, 6, 7, 5 });
			*/

			//127. Write a C# Sharp program to shift an element in left direction and return a new array.

			//P127(new[] { 1, 2, 3, 4 });

			//128. Write a C# Sharp program to create a new array taking the elements before the element value 5 from a given array of integers.

			//P128(new[] { 1, 2, 3, 4, 5 });

			//129. Write a C# Sharp program to create a new array taking the elements after the element value 5 from a given array of integers.

			//P129(new[] { 1,2,4,0,5,6, 2, 3, 4, 6 });

			//130. Write a C# Sharp program to create a new array from a given array of integers shifting all zeros to left direction.
			/*
						int[] array = P130(new[]{ 1,3,4,0,0,7,6});

						foreach (var item in array)
						{
							Console.Write(item.ToString() + ",");
						}
			*/

			//131.Write a C# Sharp program to create a new array after replacing all the values 5 with 0 shifting all zeros to right direction.
			/*
						int[] array = P131(new[] { 1, 2, 5, 3, 5, 7, 5, 9, 11 });

						foreach (var item in array)
						{
							Console.Write(item.ToString() + " ");
						}
			*/

			//132. Write a C# Sharp program to create new array from a given array of integers shifting all even numbers before all odd numbers.

			//P132(new[] { 1, 2, 5, 3, 5, 4, 6, 9, 11 });

			//133. Write a C# Sharp program to check if the value of each element is equal or greater than the value of previous element of a given array of integers.

			//P133(new []{ 5, 5, 1, 5, 5 });
			//P133(new [] { 1, 2, 3, 4 });
			//P133(new [] { 3, 3, 5, 5, 5, 5 });
			//P133(new [] { 1, 5, 5, 7, 8, 10 });


			//134. Write a C# Sharp program to check a given array (length will be atleast 2) of integers and return true if there are two values 15, 15 next to each other.

			//P134(new[] { 5, 5, 1, 15, 15 });
			//P134(new[] { 15, 2, 3, 4, 15 });
			//P134(new[] { 3, 3, 15, 15, 5, 5 });
			//P134(new[] { 1, 5, 15, 7, 8, 15 });

			//135. Write a C# Sharp program to find the larger average value between the first and the second half of a given array of integers and minimum length is atleast 2. Assume that the second half begins at index (array length)/2.

			//P135(new[] { 1, 2, 3, 4, 6, 8 });

			//136. Write a C# Sharp program to count the number of strings with given length in given array of strings.

			//Console.Write(P136(new[] {"a","b","c","de","fc","dcc"},1));

			//137. Write a C# Sharp program to create a new array using the first n strings from a given array of strings. (n>=1 and <=length of the array).
			/*
						string[] arr = P137(new[] { "a", "ab", "bc", "de", "acd" }, 3);

						foreach (var item in arr)
						{
							Console.Write(item + " ");
						}
			*/

			//138. Write a C# Sharp program to create a new array from a given array of strings  using all the strings whose length are matched with given string length.
			/*
						string[] arr = P138(new[] {"a","ab","bc","dc","de","an","cdh" },2);

						for (int i = 0; i < arr.Length; i++)
						{
							Console.Write("{0} ", arr[i]);
						}
			*/

			//139. Write a C# Sharp program to check a positive integer and return true if it contains a number 2.

			//Console.WriteLine(P139(123));

			//140. Write a C# Sharp program to create a new array of given length using the odd numbers from a given array of positive integers.
			/*
			int[] arr = P140(new[] { 1, 2, 3, 5, 7, 9, 10 }, 4);

			foreach (var item in arr)
			{
				Console.Write(item.ToString() + " ");
			}
			*/

			//141. Write a C# Sharp program to create a new list from a given list of integers where each element is multiplied by 3.
			/*
			List<int> Result = P141(new List<int> {1,2,3,4 });

			foreach (var item in Result)
			{
				Console.Write(item.ToString() + " ");
			}
			*/

			//142.Write a C# Sharp program to create a new list from a given list of integers where each integer multiplied by itself three times.

			/*
			List<int> List = P142(new List<int> {1,2,3,4 });

			foreach (var item in List)
			{
				Console.Write(item.ToString() + " ");
			}
			*/

			//143. Write a C# Sharp program to create a new list from a given list of strings where each element has "#" added at the beginning and end position.
			/*
			List<string> List = P143(new List<string>{ "1", "2", "3" , "4"});

			foreach (var item in List)
			{
				Console.Write(item + " ");
			}
			*/

			//144. Write a C# Sharp program to create a new list from a given list of strings where each element is replaced by 4 copies of the string concatenated together.
			/*
			List<string> List = P144(new List<string> { "1", "2", "3", "4" });

			foreach (var item in List)
			{
				Console.Write(item + " ");
			}
			*/


			//145.Write a C# Sharp program to create a new list from a given list of integers where each integer value is added to 2 and the result value is multiplied by 5.
			/*
			List<int> List = P145(new List<int> { 1, 2, 3, 4 });

			for (int i = 0; i < List.Count; i++)
			{
				Console.Write(List[i].ToString() + " ");
			}
			*/


			//146.Write a C# Sharp program to create a new list of the rightmost digits from a given list of positive integers.
			/*
			List<int> List = P146(new List<int> { 10, 22, 35, 41 });

			foreach (var item in List)
			{
				Console.Write(item.ToString()+" ");
			}
			*/

			//147.Write a C# Sharp program to create a new list from a given list of strings where strings will be in upper case in new string.
			/*
			List<string> List = P147(new List<string> { "Abc", "cdef", "js", "php" });

			foreach (var item in List)
			{
				Console.Write(item + " ");
			}
			*/

			//148.Write a C# Sharp program to remove all "a" in each string in given list of strings and return the new string. 
			/*
						List<string> List = P148(new List<string> { "abc", "cdaef", "js", "php" });

						foreach (var item in List)
						{
							Console.Write(item + " ");
						}
			*/

			//149. Write a C# Sharp program to create a new list from a given list of integers removing those values which are less than 4.
			/*
			Applications refpar = new Applications();

			List<int> List1 = refpar.P149(new List<int> { 0, -2, 1, 2, 3, 5, 4, 7, 8 });

			foreach (var item in List1)
			{
				Console.Write(item.ToString() + " ");
			}
			*/

			//150. Write a C# Sharp program to create a new list from a given list of integers removing those values end with 7.
			/*
			List<int>List = P150(new List<int> { 10, 22, 35, 47, 53, 67 });

			foreach (var item in List)
			{
				Console.Write(item.ToString() + " ");
			}
			*/

			int n = int.Parse(Console.ReadLine());
			int m = int.Parse(Console.ReadLine());
			var length = m;
			for (int i = 0; i < length; i++)
			{
				for (int j = 0; j < m; j++)
				{
					Console.Write(n);
					
				}
				Console.WriteLine();
				m--;
			}

		}
	} 
}