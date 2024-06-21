using System;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;


namespace Calculator
{
    public partial class Calculator : Form
    {
        public static Stack<clsOperation> _history = new Stack<clsOperation>(); 

        private char _exepretionSigne = '+';
        private char _braces = '(';
        private string _result;
        
        public Calculator()
        {
            InitializeComponent();
        }

      

        private void NumberClick(object sender, EventArgs e)
        {
            LabelInput.Text += ((Button)sender).Tag; 
        }

        private void OperatorsClick(object sender, EventArgs e)
        {
            LabelInput.Text += ((Button)sender).Tag;

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {


            string Input = LabelInput.Text; 
            LabelInput.Text = clsStringManipulation.RemoveLastChar(Input);
            if (LabelInput.Text == "")
            {
                LblResult.Text = "0"; 
                _result = "0";
            }

        }

        private void buttonDegRad_Click(object sender, EventArgs e)
        {
            if(LabelDeg_Rad.Text == "Deg")
            {
                LabelDeg_Rad.Text = "Rad"; 
                clsCalculator.useDegrees = false;
            }
            else
            {
                LabelDeg_Rad.Text = "Deg";
                clsCalculator.useDegrees = true;

            }
        }

        private void buttonPlusOrMines_Click(object sender, EventArgs e)
        {
            if (_exepretionSigne == '+')
            {
                _exepretionSigne = '-';
                LabelInput.Text = clsStringManipulation.AddCharAtFirst('-', LabelInput.Text); 

            }

            else
            {
                _exepretionSigne = '+';
                LabelInput.Text = clsStringManipulation.RemoveFirstChar(LabelInput.Text);
            }

        }

        private void buttonBraces_Click(object sender, EventArgs e)
        {
            LabelInput.Text += _braces;
            if (_braces == '(')
                            {
                _braces = ')'; 
            }
            else
            {
                _braces = '('; 
            }
        }

        private void FunctionButton(object sender, EventArgs e)
        {
            LabelInput.Text += ((Button)sender).Tag;
            _braces = ')'; 
        }

        private void ConstanetsButton(object sender, EventArgs e)
        {
            LabelInput.Text += ((Button)sender).Tag; 
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            LblResult.Text = clsCalculator.CalculateResult(LabelInput.Text);
            _result = LblResult.Text;
            if (_result != "Error")
            {
                _history.Push(new clsOperation(LabelInput.Text, _result)); 
            }
        }

        private void button1OverX_Click(object sender, EventArgs e)
        {
            LabelInput.Text = "1/(" + LabelInput.Text +")";
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            History HistoryForm = new History();
            HistoryForm.Show();
            if (_history.Count != 0)
            {
                HistoryForm.AddCalculationLabels(_history);
            }

        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            LblResult.Text = "0";
            LabelInput.Text = "";
            _result = "0"; 
        }

        public static void ClearHistory()
        {
            _history.Clear(); 
        }
    }
}
