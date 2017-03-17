namespace Calculateur_Prix_Impression
{
	partial class settings
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.bt_ok = new System.Windows.Forms.Button();
			this.bt_cancel = new System.Windows.Forms.Button();
			this.lb_settings = new System.Windows.Forms.Label();
			this.lb_elec_price = new System.Windows.Forms.Label();
			this.lb_hours = new System.Windows.Forms.Label();
			this.lb_fail = new System.Windows.Forms.Label();
			this.tb_elec_price = new System.Windows.Forms.TextBox();
			this.tb_fail = new System.Windows.Forms.TextBox();
			this.tb_hours = new System.Windows.Forms.TextBox();
			this.lb_elec_price_unit = new System.Windows.Forms.Label();
			this.lb_hours_unit = new System.Windows.Forms.Label();
			this.lb_fail_unit = new System.Windows.Forms.Label();
			this.lb_margin_unit = new System.Windows.Forms.Label();
			this.tb_margin = new System.Windows.Forms.TextBox();
			this.lb_margin = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// bt_ok
			// 
			this.bt_ok.Location = new System.Drawing.Point(59, 202);
			this.bt_ok.Name = "bt_ok";
			this.bt_ok.Size = new System.Drawing.Size(75, 23);
			this.bt_ok.TabIndex = 14;
			this.bt_ok.Text = "OK";
			this.bt_ok.UseVisualStyleBackColor = true;
			this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
			// 
			// bt_cancel
			// 
			this.bt_cancel.Location = new System.Drawing.Point(153, 202);
			this.bt_cancel.Name = "bt_cancel";
			this.bt_cancel.Size = new System.Drawing.Size(75, 23);
			this.bt_cancel.TabIndex = 15;
			this.bt_cancel.Text = "Cancel";
			this.bt_cancel.UseVisualStyleBackColor = true;
			this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
			// 
			// lb_settings
			// 
			this.lb_settings.AutoSize = true;
			this.lb_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_settings.Location = new System.Drawing.Point(90, 13);
			this.lb_settings.Name = "lb_settings";
			this.lb_settings.Size = new System.Drawing.Size(115, 24);
			this.lb_settings.TabIndex = 2;
			this.lb_settings.Text = "Paramètres";
			// 
			// lb_elec_price
			// 
			this.lb_elec_price.AutoSize = true;
			this.lb_elec_price.Location = new System.Drawing.Point(14, 70);
			this.lb_elec_price.Name = "lb_elec_price";
			this.lb_elec_price.Size = new System.Drawing.Size(68, 13);
			this.lb_elec_price.TabIndex = 3;
			this.lb_elec_price.Text = "Prix du kWh:";
			// 
			// lb_hours
			// 
			this.lb_hours.AutoSize = true;
			this.lb_hours.Location = new System.Drawing.Point(14, 100);
			this.lb_hours.Name = "lb_hours";
			this.lb_hours.Size = new System.Drawing.Size(130, 13);
			this.lb_hours.TabIndex = 4;
			this.lb_hours.Text = "Durée de fonctionnement:";
			// 
			// lb_fail
			// 
			this.lb_fail.AutoSize = true;
			this.lb_fail.Location = new System.Drawing.Point(14, 130);
			this.lb_fail.Name = "lb_fail";
			this.lb_fail.Size = new System.Drawing.Size(90, 13);
			this.lb_fail.TabIndex = 5;
			this.lb_fail.Text = "Probabilité de fail:";
			// 
			// tb_elec_price
			// 
			this.tb_elec_price.Location = new System.Drawing.Point(172, 67);
			this.tb_elec_price.Name = "tb_elec_price";
			this.tb_elec_price.Size = new System.Drawing.Size(50, 20);
			this.tb_elec_price.TabIndex = 6;
			this.tb_elec_price.Text = "0,15";
			this.tb_elec_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tb_elec_price.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_elec_price_KeyDown);
			this.tb_elec_price.Leave += new System.EventHandler(this.tb_elec_price_Leave);
			// 
			// tb_fail
			// 
			this.tb_fail.Location = new System.Drawing.Point(172, 127);
			this.tb_fail.Name = "tb_fail";
			this.tb_fail.Size = new System.Drawing.Size(50, 20);
			this.tb_fail.TabIndex = 8;
			this.tb_fail.Text = "15";
			this.tb_fail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tb_fail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_fail_KeyDown);
			this.tb_fail.Leave += new System.EventHandler(this.tb_fail_Leave);
			// 
			// tb_hours
			// 
			this.tb_hours.Location = new System.Drawing.Point(172, 97);
			this.tb_hours.Name = "tb_hours";
			this.tb_hours.Size = new System.Drawing.Size(50, 20);
			this.tb_hours.TabIndex = 7;
			this.tb_hours.Text = "3";
			this.tb_hours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tb_hours.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_hours_KeyDown);
			this.tb_hours.Leave += new System.EventHandler(this.tb_hours_Leave);
			// 
			// lb_elec_price_unit
			// 
			this.lb_elec_price_unit.AutoSize = true;
			this.lb_elec_price_unit.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.lb_elec_price_unit.Location = new System.Drawing.Point(224, 70);
			this.lb_elec_price_unit.Name = "lb_elec_price_unit";
			this.lb_elec_price_unit.Size = new System.Drawing.Size(13, 13);
			this.lb_elec_price_unit.TabIndex = 9;
			this.lb_elec_price_unit.Text = "€";
			// 
			// lb_hours_unit
			// 
			this.lb_hours_unit.AutoSize = true;
			this.lb_hours_unit.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.lb_hours_unit.Location = new System.Drawing.Point(224, 100);
			this.lb_hours_unit.Name = "lb_hours_unit";
			this.lb_hours_unit.Size = new System.Drawing.Size(39, 13);
			this.lb_hours_unit.TabIndex = 10;
			this.lb_hours_unit.Text = "heures";
			// 
			// lb_fail_unit
			// 
			this.lb_fail_unit.AutoSize = true;
			this.lb_fail_unit.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.lb_fail_unit.Location = new System.Drawing.Point(224, 130);
			this.lb_fail_unit.Name = "lb_fail_unit";
			this.lb_fail_unit.Size = new System.Drawing.Size(15, 13);
			this.lb_fail_unit.TabIndex = 11;
			this.lb_fail_unit.Text = "%";
			// 
			// lb_margin_unit
			// 
			this.lb_margin_unit.AutoSize = true;
			this.lb_margin_unit.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.lb_margin_unit.Location = new System.Drawing.Point(224, 160);
			this.lb_margin_unit.Name = "lb_margin_unit";
			this.lb_margin_unit.Size = new System.Drawing.Size(15, 13);
			this.lb_margin_unit.TabIndex = 14;
			this.lb_margin_unit.Text = "%";
			// 
			// tb_margin
			// 
			this.tb_margin.Location = new System.Drawing.Point(172, 157);
			this.tb_margin.Name = "tb_margin";
			this.tb_margin.Size = new System.Drawing.Size(50, 20);
			this.tb_margin.TabIndex = 13;
			this.tb_margin.Text = "20";
			this.tb_margin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tb_margin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_margin_KeyDown);
			this.tb_margin.Leave += new System.EventHandler(this.tb_margin_Leave);
			// 
			// lb_margin
			// 
			this.lb_margin.AutoSize = true;
			this.lb_margin.Location = new System.Drawing.Point(14, 160);
			this.lb_margin.Name = "lb_margin";
			this.lb_margin.Size = new System.Drawing.Size(88, 13);
			this.lb_margin.TabIndex = 12;
			this.lb_margin.Text = "Marge opérateur:";
			// 
			// settings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 240);
			this.Controls.Add(this.lb_margin_unit);
			this.Controls.Add(this.tb_margin);
			this.Controls.Add(this.lb_margin);
			this.Controls.Add(this.lb_fail_unit);
			this.Controls.Add(this.lb_hours_unit);
			this.Controls.Add(this.lb_elec_price_unit);
			this.Controls.Add(this.tb_hours);
			this.Controls.Add(this.tb_fail);
			this.Controls.Add(this.tb_elec_price);
			this.Controls.Add(this.lb_fail);
			this.Controls.Add(this.lb_hours);
			this.Controls.Add(this.lb_elec_price);
			this.Controls.Add(this.lb_settings);
			this.Controls.Add(this.bt_cancel);
			this.Controls.Add(this.bt_ok);
			this.Name = "settings";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "settings";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.settings_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bt_ok;
		private System.Windows.Forms.Button bt_cancel;
		private System.Windows.Forms.Label lb_settings;
		private System.Windows.Forms.Label lb_elec_price;
		private System.Windows.Forms.Label lb_hours;
		private System.Windows.Forms.Label lb_fail;
		private System.Windows.Forms.TextBox tb_elec_price;
		private System.Windows.Forms.TextBox tb_fail;
		private System.Windows.Forms.TextBox tb_hours;
		private System.Windows.Forms.Label lb_elec_price_unit;
		private System.Windows.Forms.Label lb_hours_unit;
		private System.Windows.Forms.Label lb_fail_unit;
		private System.Windows.Forms.Label lb_margin_unit;
		private System.Windows.Forms.TextBox tb_margin;
		private System.Windows.Forms.Label lb_margin;
	}
}