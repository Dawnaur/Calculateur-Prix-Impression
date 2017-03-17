using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculateur_Prix_Impression
{
	class Filament
	{
		public String name;
		public double price;

		public Filament(String _name, double _price)
		{
			this.name = _name;
			this.price = _price;
		}
	}
}
