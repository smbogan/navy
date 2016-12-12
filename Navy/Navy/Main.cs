using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navy
{
    public partial class Main : Form
    {
        Transaction currentTransaction = new Transaction(Operation.Buy);

        public Main()
        {
            InitializeComponent();

            

            RefreshTransactionView();
        }

        private void add_Click(object sender, EventArgs e)
        {
            currentTransaction = new Navy.Transaction(Operation.Buy);

            RefreshTransactionView();
        }

        private void RefreshTransactionView()
        {
            transactionView.SelectedObject = currentTransaction;
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
