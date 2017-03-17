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
	public partial class settings : Form
	{
		private Form1 frmParent;

		public settings(Form1 fparent)
		{
			InitializeComponent();
			frmParent = fparent;
		}

		private void tb_elec_price_Leave(object sender, EventArgs e)
		{
			tb_elec_price.Text = tb_elec_price.Text.Replace(".", ",");
			if (Convert.ToDouble(tb_elec_price.Text) < 0)
				tb_elec_price.Text = 0.ToString();
		}

		private void tb_hours_Leave(object sender, EventArgs e)
		{
			tb_hours.Text = tb_hours.Text.Replace(".", ",");
			if (Convert.ToDouble(tb_hours.Text) < 0)
				tb_hours.Text = 0.ToString();
		}

		private void tb_fail_Leave(object sender, EventArgs e)
		{
			tb_fail.Text = tb_fail.Text.Replace(".", ",");
			if (Convert.ToDouble(tb_fail.Text) < 0)
				tb_fail.Text = 0.ToString();
		}

		private void tb_margin_Leave(object sender, EventArgs e)
		{
			tb_margin.Text = tb_margin.Text.Replace(".", ",");
			if (Convert.ToDouble(tb_margin.Text) < 0)
				tb_margin.Text = 0.ToString();
		}

		private void bt_cancel_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void bt_ok_Click(object sender, EventArgs e)
		{
			save_settings();
			this.Dispose();
		}

		private void settings_Load(object sender, EventArgs e)
		{
			tb_elec_price.Text = Convert.ToString(frmParent.electricity_cost);
			tb_hours.Text = Convert.ToString(frmParent.printer_hours);
			tb_fail.Text = String.Format("{0:0}", frmParent.fail_probability * 100);
			tb_margin.Text = String.Format("{0:0}", frmParent.operator_margin * 100);
		}
		
		private void save_settings()
		{
			frmParent.electricity_cost = Convert.ToDouble(tb_elec_price.Text);
			frmParent.printer_hours = Convert.ToDouble(tb_hours.Text);
			frmParent.fail_probability = Convert.ToDouble(tb_fail.Text) / 100;
			frmParent.operator_margin = Convert.ToDouble(tb_margin.Text) / 100;
		}

		private void tb_elec_price_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				save_settings();
				this.Dispose();
			}
		}

		private void tb_hours_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				save_settings();
				this.Dispose();
			}
		}

		private void tb_fail_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				save_settings();
				this.Dispose();
			}
		}

		private void tb_margin_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				save_settings();
				this.Dispose();
			}
		}
	}
}
