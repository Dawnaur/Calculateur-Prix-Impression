using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculateur_Prix_Impression
{
	public partial class Form1 : Form
	{
		List<Printer> printers = new List<Printer>();
		List<Filament> filaments = new List<Filament>();
		double printer_price = 300;
		double printer_lifetime = 2;
		double printer_care = 0.15;
		double printer_consumption = 80;
		double filament_price = 25;

		public double printer_hours = 3;
		public double electricity_cost = 0.15;
		public double fail_probability = 0.2;
		public double operator_margin = 0.2;

		public Form1()
		{
			InitializeComponent();
		}

		private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			fichierToolStripMenuItem.DropDownItems.Insert(1, new ToolStripSeparator());
			printers.Add(new Printer("Generic i3", 300, 2, 0.1, 80));
			printers.Add(new Printer("Discovery200", 350, 2, 0.1, 60));
			filaments.Add(new Filament("Generic PLA", 25));
			filaments.Add(new Filament("esun PLA", 20));
			filaments.Add(new Filament("flex PLA", 35));
			refresh_printers();
			refresh_filaments();
			refresh_price();
		}

		private void printer_click(object sender, EventArgs e)
		{
			ToolStripItem item = (ToolStripItem)sender;
			foreach (ToolStripMenuItem something in imprimanteToolStripMenuItem.DropDownItems)
				something.Checked = false;
			foreach (Printer elem in printers)
			{
				if (elem.name == item.Text)
				{
					printer_price = elem.price;
					printer_lifetime = elem.depreciation;
					printer_care = elem.care;
					printer_consumption = elem.consumption;
					refresh_price();
					((ToolStripMenuItem)item).Checked = true;
					break;
				}
			}
		}

		private void filament_click(object sender, EventArgs e)
		{
			ToolStripItem item = (ToolStripItem)sender;
			foreach (ToolStripMenuItem something in filamentToolStripMenuItem.DropDownItems)
				something.Checked = false;
			foreach (Filament elem in filaments)
			{
				if (elem.name == item.Text)
				{
					filament_price = elem.price;
					refresh_price();
					((ToolStripMenuItem)item).Checked = true;
					break;
				}
			}
		}

		private void refresh_printers()
		{
			int i = -1;
			imprimanteToolStripMenuItem.DropDownItems.Clear();
			foreach (Printer item in printers)
			{
				imprimanteToolStripMenuItem.DropDownItems.Add(item.name);
				imprimanteToolStripMenuItem.DropDownItems[++i].Click += new EventHandler(printer_click);
				if (i == 0)
					((ToolStripMenuItem)imprimanteToolStripMenuItem.DropDownItems[i]).Checked = true;
			}
		}

		private void refresh_filaments()
		{
			int i = -1;
			filamentToolStripMenuItem.DropDownItems.Clear();
			foreach (Filament item in filaments)
			{
				filamentToolStripMenuItem.DropDownItems.Add(item.name);
				filamentToolStripMenuItem.DropDownItems[++i].Click += new EventHandler(filament_click);
				if (i == 0)
					((ToolStripMenuItem)filamentToolStripMenuItem.DropDownItems[i]).Checked = true;
			}
		}

		private void refresh_price()
		{
			double price;
			double printer_rentability;

			printer_rentability = printer_price * (1 + (printer_care * printer_lifetime)) / (printer_hours * 365.25 * printer_lifetime);
			price = Convert.ToDouble(tb_time.Text) / printer_rentability; // frais d'amortissement
			price += Convert.ToDouble(tb_time.Text) * printer_consumption * electricity_cost / 1000; // frais d'électricité
			price += Convert.ToDouble(tb_weight.Text) * filament_price / 1000; // frais de filament
			price *= (1 + fail_probability);
			price *= operator_margin;
			price += Convert.ToDouble(tb_start.Text); // frais de départ
			tb_total.Text = String.Format("{0:0.00}", price);
		}

		private void tb_time_TextChanged(object sender, EventArgs e)
		{
			tb_time.Text = tb_time.Text.Replace(".", ",");
			if (Convert.ToDouble(tb_time.Text) < 0)
				tb_time.Text = 0.ToString();
			refresh_price();
		}

		private void tb_weight_TextChanged(object sender, EventArgs e)
		{
			tb_weight.Text = tb_weight.Text.Replace(".", ",");
			if (Convert.ToDouble(tb_weight.Text) < 0)
				tb_time.Text = 0.ToString();
			refresh_price();
		}

		private void tb_start_TextChanged(object sender, EventArgs e)
		{
			tb_start.Text = tb_start.Text.Replace(".", ",");
			if (Convert.ToDouble(tb_start.Text) < 0)
				tb_time.Text = 0.ToString();
			refresh_price();
		}

		private void réglagesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			settings formsettings = new settings(this);
			formsettings.ShowDialog();
			refresh_price();
		}
	}

}
