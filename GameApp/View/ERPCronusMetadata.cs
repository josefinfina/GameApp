using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameQuiz.View
{
    public partial class ERPCronusMetadata : Form
    {
        private WebReference.WebService proxy = new WebReference.WebService();

        public ERPCronusMetadata()
        {
            InitializeComponent();
        }

        private void ERPUpdate_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm frm = new LoginForm();
            frm.SelectedTab = 2;
            frm.Show();
        }

        private void findAllKeysButton_Click(object sender, EventArgs e)
        {
            FindKeysAndPrint();
        }
        private void FindKeysAndPrint()
        {
            proxy.FindAllKeys();

            DataTable keys = proxy.FindAllKeys();
            metadataDataGridView.DataSource = proxy.FindAllKeys();
        }
        private void FindIndexesAndPrint()
        {
            proxy.FindAllIndexes();

            DataTable index = proxy.FindAllIndexes();
            metadataDataGridView.DataSource = proxy.FindAllIndexes();
        }
        private void FindTableConstraintsAndPrint()
        {
            proxy.FindAllTableConstraints();

            DataTable constraints = proxy.FindAllTableConstraints();
            metadataDataGridView.DataSource = proxy.FindAllTableConstraints();
        }
        private void FindAllTablesAndPrint()
        {
            proxy.FindAllTables();

            DataTable tables = proxy.FindAllTables();
            metadataDataGridView.DataSource = proxy.FindAllTables();
        }
        private void FindAllColumnsEmployeeAndPrint()
        {
            proxy.FindAllColumnsEmployee();

            DataTable tables = proxy.FindAllColumnsEmployee();
            metadataDataGridView.DataSource = proxy.FindAllColumnsEmployee();
        }
        private void FindAllColumnssEmployeeTwoAndPrint()
        {
            proxy.FindAllColumnsEmployeeTwo();

            DataTable tables = proxy.FindAllColumnsEmployeeTwo();
            metadataDataGridView.DataSource = proxy.FindAllColumnsEmployeeTwo();
        }
        private void FindAllTablesTwoAndPrint()
        {
            proxy.FindAllTablesTwo();

            DataTable tables = proxy.FindAllTablesTwo();
            metadataDataGridView.DataSource = proxy.FindAllTablesTwo();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FindIndexesAndPrint();
        }

        private void allColumnsEmployeeButton_Click(object sender, EventArgs e)
        {
            FindAllColumnsEmployeeAndPrint();
        }

        private void tableConstraintsButton_Click(object sender, EventArgs e)
        {
            FindTableConstraintsAndPrint();
        }

        private void allTablesButton_Click(object sender, EventArgs e)
        {
            FindAllTablesAndPrint();
        }

        private void allColumnsEmployeeButton_Click_1(object sender, EventArgs e)
        {
            FindAllColumnsEmployeeAndPrint();
        }

        private void allColumnsEmployeeTwoButton_Click(object sender, EventArgs e)
        {
            FindAllColumnssEmployeeTwoAndPrint();
        }

        private void allTablesTwoButton_Click(object sender, EventArgs e)
        {
            FindAllTablesTwoAndPrint();
        }
    }
}
