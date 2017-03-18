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
			//imprimanteToolStripMenuItem.DropDownItems.Add(new ToolStripSeparator());
			imprimanteToolStripMenuItem.DropDownItems.Add("Manage Printers");
			imprimanteToolStripMenuItem.DropDownItems[++i].Click += new EventHandler(show_printers_settings);
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

			printer_rentability = printer_price * (1 + (printer_care * printer_lifetime)) / (printer_hours * 365.25 * printer_lifetime); // prix d'amortissement de l'imprimante à l'heure
			price = Convert.ToDouble(tb_time.Text) * printer_rentability; // frais d'amortissement
			price += Convert.ToDouble(tb_time.Text) * printer_consumption * electricity_cost / 1000; // frais d'électricité
			price += Convert.ToDouble(tb_weight.Text) * filament_price / 1000; // frais de filament
			price *= (1 + fail_probability);
			price *= (1 + operator_margin);
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

		private void show_printers_settings(object sender, EventArgs e)
		{
			int i = -1;

			lb_printers.Items.Clear();
			foreach (Printer item in printers)
			{
				lb_printers.Items.Add(item.name);
			}
			tb_printers_price.Clear();
			tb_printers_lifetime.Clear();
			tb_printers_care.Clear();
			tb_printers_power.Clear();
			tb_printers_price.Enabled = false;
			tb_printers_lifetime.Enabled = false;
			tb_printers_care.Enabled = false;
			tb_printers_power.Enabled = false;
			gb_printers.Visible = true;
		}

		private void load_printer_specs(String name)
		{
			foreach (Printer item in printers)
			{
				if (item.name == name)
				{
					tb_printers_price.Text = item.price.ToString();
					tb_printers_lifetime.Text = item.depreciation.ToString();
					tb_printers_care.Text = String.Format("{0:0}", item.care * 100); ;
					tb_printers_power.Text = item.consumption.ToString();
					break;
				}
			}
			tb_printers_price.Enabled = true;
			tb_printers_lifetime.Enabled = true;
			tb_printers_care.Enabled = true;
			tb_printers_power.Enabled = true;
		}

		private void save_printer_specs(String name)
		{
			if (lb_printers.SelectedIndex >= 0)
			{
				foreach (Printer item in printers)
				{
					if (item.name == name) // erreur sur le nom
					{
						item.price = Convert.ToDouble(tb_printers_price.Text);
						item.depreciation = Convert.ToDouble(tb_printers_lifetime.Text);
						item.care = Convert.ToDouble(tb_printers_care.Text) / 100;
						item.consumption = Convert.ToDouble(tb_printers_power.Text);
						printer_price = item.price;
						printer_lifetime = item.depreciation;
						printer_care = item.care;
						printer_consumption = item.consumption;
						break;
					}
				}
			}
		}

		private void bt_printers_cancel_Click(object sender, EventArgs e)
		{
			if (lb_printers.SelectedIndex >= 0)
				load_printer_specs(lb_printers.Items[lb_printers.SelectedIndex].ToString());
		}

		private void bt_printers_ok_Click(object sender, EventArgs e)
		{
			gb_printers.Visible = false;
			refresh_price();
		}

		private void lb_printers_SelectedIndexChanged(object sender, EventArgs e)
		{
			ListBox lst = (ListBox)sender;
			if (lst.SelectedIndex >= 0)
				load_printer_specs(lst.Items[lst.SelectedIndex].ToString());
		}

		private void bt_printers_add_Click(object sender, EventArgs e)
		{

		}

		private void bt_printers_delete_Click(object sender, EventArgs e)
		{
			if (lb_printers.SelectedIndex >= 0)
			{
				foreach (Printer elem in printers)
				{
					if (elem.name == lb_printers.Items[lb_printers.SelectedIndex].ToString())
					{
						printers.Remove(elem);
						refresh_printers();
						break;
					}
				}
				lb_printers.Items.RemoveAt(lb_printers.SelectedIndex);
				lb_printers.SelectedIndex = 0;
			}
		}

		private void bt_printers_save_Click(object sender, EventArgs e)
		{
			if (lb_printers.SelectedIndex >= 0)
				save_printer_specs(lb_printers.Items[lb_printers.SelectedIndex].ToString());
		}
	}

}
