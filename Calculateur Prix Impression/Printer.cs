using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculateur_Prix_Impression
{
	class Printer
	{
		public String name;
		public double price;
		public double depreciation;
		public double care;
		public double consumption;

		public Printer(string _name, double _price, double _depreciation, double _care, double _consumption)
		{
			this.name = _name;
			this.price = _price;
			this.depreciation = _depreciation;
			this.care = _care;
			this.consumption = _consumption;
		}
	}
}
