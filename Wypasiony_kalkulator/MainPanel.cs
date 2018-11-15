using System;
using System.Windows.Forms;

namespace Wypasiony_kalkulator
{
    public partial class MainPanel : Form
    {
        private static string _liczba = "";
        private static string _znak = "";
        private static float _wynik = 0;
        private static bool _firstOperation = true;
        private static string _operations = "";

        public MainPanel() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            lblWynik.BackColor = System.Drawing.Color.Transparent;
            lblHelp.BackColor = System.Drawing.Color.Transparent;
            pbExit.BackColor = System.Drawing.Color.Transparent;
        }

        public void FunctionalityCall()
        {
            if (!_firstOperation)
            {
                if (_liczba != "")
                {
                    _wynik = Functionality.Equals(_znak, _wynik.ToString(), _liczba);
                    _operations = _operations + _liczba;
                    _liczba = "";
                }           
            }
            else
            {
                if (_liczba != "")
                {
                    _wynik = float.Parse(_liczba);
                    _operations = _operations + _liczba;
                    _liczba = "";
                    _firstOperation = false;
                }
            }

            lblHelp.Text = _operations;
            lblWynik.Text = _wynik.ToString();
        }

        public void Operations(string znak)
        {
            FunctionalityCall();
            _znak = znak;

            if (_operations[_operations.Length - 1] == '+' || _operations[_operations.Length - 1] == '-' || _operations[_operations.Length - 1] == '*' || _operations[_operations.Length - 1] == '/')
            {
                _operations = _operations.Substring(0, _operations.Length - 1) + znak;
            }
            else
            {
                _operations = _operations + " " + znak;
            }
            lblHelp.Text = _operations;
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            _liczba = _liczba + '1';
            lblWynik.Text = _liczba;
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            _liczba = _liczba + '2';
            lblWynik.Text = _liczba;
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            _liczba = _liczba + '3';
            lblWynik.Text = _liczba;
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            _liczba = _liczba + '4';
            lblWynik.Text = _liczba;
        }

        private void pb5_Click(object sender, EventArgs e)
        {
            _liczba = _liczba + '5';
            lblWynik.Text = _liczba;
        }

        private void pb6_Click(object sender, EventArgs e)
        {
            _liczba = _liczba + '6';
            lblWynik.Text = _liczba;
        }

        private void pb7_Click(object sender, EventArgs e)
        {
            _liczba = _liczba + '7';
            lblWynik.Text = _liczba;
        }

        private void pb8_Click(object sender, EventArgs e)
        {
            _liczba = _liczba + '8';
            lblWynik.Text = _liczba;
        }

        private void pb9_Click(object sender, EventArgs e)
        {
            _liczba = _liczba + '9';
            lblWynik.Text = _liczba;
        }

        private void pb0_Click(object sender, EventArgs e)
        {
            _liczba = _liczba + '0';
            lblWynik.Text = _liczba;
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            Operations("+");
        }

        private void pbMinus_Click(object sender, EventArgs e)
        {
            Operations("-");
        }

        private void pbMultiply_Click(object sender, EventArgs e)
        {
            Operations("*");
        }

        private void pbDivide_Click(object sender, EventArgs e)
        {
            Operations("/");
        }

        private void pbEqual_Click(object sender, EventArgs e)
        {
            FunctionalityCall();
            _operations = _wynik.ToString();
            lblWynik.Text = _wynik.ToString();
            lblHelp.Text = "";
        }

        private void pbClear_Click(object sender, EventArgs e)
        {
            _wynik = 0;
            _liczba = "";
            _firstOperation = true;
            _operations = "";
            lblHelp.Text = _operations;
            lblWynik.Text = _liczba;
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            if (_liczba == "") return;
            _liczba = _liczba.Substring(0, _liczba.Length - 1);
            lblWynik.Text = _liczba;
        }

        private void pbPlusMinus_Click(object sender, EventArgs e)
        {          
            //if (_liczba == "")
            //{
            //    _wynik = _wynik * (-1);
            //    _operations = _wynik.ToString();
            //    lblWynik.Text = _wynik.ToString();
            //}
            //else
            //{
            //    _liczba = (float.Parse(_liczba) * (-1)).ToString();
            //    lblWynik.Text = _liczba;
            //}
        }

        private void pbPrzecinek_Click(object sender, EventArgs e)
        {
            if (_liczba != "" && !_liczba.Contains(","))
            {
                _liczba = _liczba + ",";
                lblWynik.Text = _liczba;
            }
        }
    }
}
