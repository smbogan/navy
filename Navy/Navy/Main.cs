using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            db = new LiteDatabase(Path.Combine(Application.UserAppDataPath, "db.db"));

            collection = db.GetCollection<Transaction>("register");
            
            var result = collection.Find(Query.All()).OrderBy(t => t.Date).ToList();

            register.MultiSelect = false;
            register.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            register.AutoGenerateColumns = true;
            register.DataSource = result;

            RefreshTransactionView();
        }

        private void RefreshRegister()
        {
            collection = db.GetCollection<Transaction>("register");

            var result = collection.Find(Query.All()).OrderBy(t => t.Date).ToList();

            register.DataSource = result;
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

            RefreshRegister();

            RefreshTransactionView();

            register.Invalidate();

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

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (register.SelectedRows.Count > 0)
            {
                Transaction transaction = (Transaction)register.SelectedRows[0].DataBoundItem;

                currentTransaction = new Transaction(transaction);

                RefreshTransactionView();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (register.SelectedRows.Count > 0)
            {
                Transaction transaction = (Transaction)register.SelectedRows[0].DataBoundItem;

                collection.Delete(Query.EQ("_id", transaction.Id));

                RefreshRegister();
            }
        }

        private void addCopy_Click(object sender, EventArgs e)
        {
            currentTransaction = new Transaction(currentTransaction);

            if (currentTransaction.Id == null)
            {
                collection.Insert(currentTransaction);
            }
            else
            {
                collection.Update(currentTransaction);
            }

            RefreshRegister();

            RefreshTransactionView();

            register.Invalidate();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (register.SelectedRows.Count > 0)
            {
                Transaction transaction = (Transaction)register.SelectedRows[0].DataBoundItem;

                collection.Delete(Query.EQ("_id", transaction.Id));

                RefreshRegister();
            }
        }
    }
}
