using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22f_filmek_moho
{
	internal class Program
	{

		class Film
		{
			public int k;
			public int v;
			public Film(int k, int v)
			{
				this.k = k;
				this.v = v;
			}

			public override string ToString() => $"[{k};{v}[";
		}

		static List<Film> Beolvas_konzolrol()
		{
			List<Film> result = new List<Film>();

			int db = int.Parse(Console.ReadLine());

			for (int i = 0; i < db; i++)
			{
				string[] t = Console.ReadLine().Split(' '); // ["2", "9"]
				result.Add(new Film(int.Parse(t[0]), int.Parse(t[1])));
			}

			return result;
		}

		static int elobb_er_veget(Film f1, Film f2)
		{
			if (f1.v < f2.v)
				return -1;
			if (f1.v < f2.v)
				return 1;
			return 0;
		}

		static List<Film> Megold(List<Film> filmek)
		{
			List<Film> result = new List<Film>();

			// sorbarendezés:
			filmek.Sort(elobb_er_veget); // maradandóan átalakítja a listát.


			/**/
			foreach (Film film in filmek)
			{
                Console.WriteLine(film);
            }
			/**/

			return result;
		}

		static void Main(string[] args)
		{
			List<Film> filmek = Beolvas_konzolrol();

			List<Film> mo = Megold(filmek);



            Console.WriteLine("Ennyi a legtöbb megnézhető film:");
            Console.WriteLine(mo.Count); 
		}
	}
}


/*
8
2 9
4 6
3 11
1 14
5 7
8 12
10 15
13 16

*/