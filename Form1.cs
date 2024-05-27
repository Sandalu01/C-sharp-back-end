using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet4.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter2.Fill(this.databaseDataSet4.Employee);
            // TODO: This line of code loads data into the 'databaseDataSet3.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter1.Fill(this.databaseDataSet3.Employee);
            // TODO: This line of code loads data into the 'databaseDataSet2.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter1.Fill(this.databaseDataSet2.Book);
            // TODO: This line of code loads data into the 'databaseDataSet1.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.databaseDataSet1.Book);
            // TODO: This line of code loads data into the 'databaseDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.databaseDataSet.Employee);

        }
    }
}
