using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Multiplication_Table
{
	public partial class Form1 : Form
	{
		double first, second;

		public Form1()
		{
			InitializeComponent();
		}

		public void multiply(object sender, EventArgs e)
		{
			if (double.TryParse(textBoxSecondValue.Text, out second) && double.TryParse(textBoxFirstValue.Text, out first))
			{
				labelResultMul.Text = (first * second).ToString();
				showMulTable();
			}
		}

		void showMulTable()
		{
			int _first = (int)first, _second = (int)second;

			if ((_first > 0 && _second > 0) == false)
			{
				return;
			}


			DataTable dt = new DataTable();
			for (int i = 1; i <= first; i++)
			{
				dt.Rows.Add();
			}
			for (int i = 1; i <= second; i++)
			{
				DataColumn t = new DataColumn(String.Format("{0:0}", i));
				dt.Columns.Add(t);
			}






			for (int i=1; i<=first; i++)
			{
				for (int j=1; j<=second; j++)
				{
					dt.Rows[i-1][j-1] = i*j; 
				}
			}
			dataGridView1.DataSource = dt;

			for (int i = 1; i <= first; i++)
			{
				dataGridView1.Rows[i - 1].HeaderCell.Value = i.ToString();
			}
			
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
		}
	}
}
