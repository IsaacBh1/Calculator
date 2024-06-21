using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        public void RemovePicBox()
        {
            NoHistoryPic.Visible = false;
            /*NoHistoryPic.Dispose();*/
        }

        public void AddPicBox()
        {
            NoHistoryPic.Visible = true;

        }

        public void AddCalculationLabels(Stack<clsOperation> Operations) {

            RemovePicBox();
            Stack<clsOperation> CopyOperations = new Stack<clsOperation>(Operations.ToArray());
            while (CopyOperations.Count != 0)
            {
                var op = CopyOperations.Pop();
                Exepretionlbl.Text += (op.Exepretion.ToString() +" = " + op.Result.ToString() + Environment.NewLine);
                Exepretionlbl.ForeColor = Color.DarkGray;

            }

            Historypanel.Controls.Add(Exepretionlbl); 
        }


        private void NoHistoryPic_Click(object sender, EventArgs e)
        {
        }

        private void buttonBraces_Click(object sender, EventArgs e)
        {
            Exepretionlbl.Text = "";
            Calculator.ClearHistory();


        }
    }
}
