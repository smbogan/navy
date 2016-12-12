using LiteDB;
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
        LiteDatabase db;

        LiteCollection<Transaction> Register { get; set; }

        Transaction currentTransaction = new Transaction();

        LiteCollection<Transaction> collection;

        public Main()
        {
            InitializeComponent();

            db = new LiteDatabase("db.db");

            collection = db.GetCollection<Transaction>("register");
            
            var result = collection.Find(Query.All(Query.Descending)).ToList();

            register.MultiSelect = false;
            register.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            register.AutoGenerateColumns = true;
            register.DataSource = result;

            RefreshTransactionView();
        }

        private void add_Click(object sender, EventArgs e)
        {
            currentTransaction = new Transaction();

            RefreshTransactionView();
        }

        

        private void RefreshTransactionView()
        {
            transactionView.SelectedObject = currentTransaction;
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {

            db.Dispose();
        }

        private void accept_Click(object sender, EventArgs e)
        {
            if(currentTransaction.Id == null)
            {
                collection.Insert(currentTransaction);
            }
            else
            {
                collection.Update(currentTransaction);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (register.SelectedRows.Count > 0)
            {
                Transaction transaction = (Transaction)register.SelectedRows[0].DataBoundItem;

                currentTransaction = transaction;

                RefreshTransactionView();
            }
        }
    }
}
