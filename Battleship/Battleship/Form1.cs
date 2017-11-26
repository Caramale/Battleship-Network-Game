using Battleship.Model;
using Battleship.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Battleship.Controller;

namespace Battleship
{
    public partial class Form1 : Form, IView, IModel
    {
        IController _controller;

        public event ViewCabinHandler<IView> CabinChanged;

        public Form1()
        {
            InitializeComponent();
            dataGridView1.RowCount = 10;
            dataGridView2.RowCount = 10;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CabinChanged.Invoke(this, new CellEnteredEventArgs(dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.Azure, e.RowIndex, e.ColumnIndex));
            }
            catch
            {

            }
            DataGridView datagrid = sender as DataGridView;
            datagrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Aqua;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView datagrid = sender as DataGridView;
            datagrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Aqua;
        }

        public void setController(IController controller)
        {
            _controller = controller;
        }

        public void attach(IModelObserver modelObserver)
        {
            throw new NotImplementedException();
        }

        public void SetCabin(int indexRow, int indexColumn)
        {
            throw new NotImplementedException();
        }

        public void StepOfGame(int indexRow, int indexColumn)
        {
            throw new NotImplementedException();
        }
    }
}
