namespace Assignment4_1_2Calculator
{
    public enum Operator
    {
        NONE,
        Addition, 
        Subtraction,
        Multiplication,
        Division,
        Modulo,
        Square,
        square_Root, 
        Factorial
    }
    public partial class FormCalculator : Form
    {
        private bool EqualClicked, GotOperant;
        private bool DotClicked;
        private bool IsLastEnteredOperator;
        private Operator ops;
        public FormCalculator()
        {
            InitializeComponent();
            txtDisplay.BorderStyle = BorderStyle.Fixed3D;
            txtHistory.BorderStyle = BorderStyle.None;
        }
        private void FormCalculator_Load(object sender, EventArgs e)
        {
            ClearAll();
        }

        // ************ Operations *****************
        private void ConvertPosNeg()
        {
            int startIndex;
            if (Data.operantStr.Length > 0)
            {
                if(Data.displayStr.Length > Data.operantStr.Length)
                {
                    startIndex = Data.displayStr.Length - Data.operantStr.Length;
                }
                else
                {
                    startIndex = 0; 
                }

                if (Data.operantStr.ToString()[0] != '-')
                {
                    Data.displayStr.Insert(startIndex, '-');
                    Data.operantStr.Insert(0, '-');
                }
                else
                {
                    Data.displayStr.Remove(startIndex, 1);
                    Data.operantStr.Remove(0, 1);
                }
            }
            else if (Data.operants.Count > 0)
            {
                RestoreOperant();
                Data.displayStr.Clear();
                Data.displayStr.Append(Data.operantStr.ToString());
            }
           
            DisplayResult();
        }
        private void GetOperant()
        {
            try
            {
                //if (Data.operantStr.Length > 0 && Data.operantStr.ToString()[0] == '(')
                //{
                //    Data.operantStr.Remove(0, 1);
                //    Data.operantStr.Remove(Data.operantStr.Length = 1, 1);
                //}
                decimal operant = decimal.Parse(Data.operantStr.ToString());
                Data.operants.Add(operant);
                Data.operantStr.Clear();
                GotOperant = true;
            }
            catch (Exception ex)
            {
                txtDisplay.Text = "Error!";
                ClearAll();
            }
        }
        private void RestoreOperant()
        {
            int lastItem = Data.operants.Count - 1;
            Data.operantStr.Append(Data.operants[lastItem]);
            Data.operants.Clear();
            GotOperant = false;
        }
        private void ChangeOperator(string op, Operator opType)
        {
            RemoveOperator();
            AddOperator(op, opType);
        }
        private void PerformCalculation()
        {
            decimal result;
            MyMath math = new MyMath();

            switch (ops)
            {
                case Operator.Addition:
                    result = math.Add(Data.operants.ToArray());
                    break;
                case Operator.Subtraction:
                    result = math.Subtract(Data.operants.ToArray());
                    break;
                case Operator.Multiplication:
                    result = math.Multiply(Data.operants.ToArray());
                    break;
                case Operator.Division:
                    if (Data.operants.Count > 1 && Data.operants[Data.operants.Count - 1] == 0)
                    {
                        ClearAll();
                        Data.displayStr.Append("ERROR!");
                        EqualClicked = true;
                        result = 0;
                        return;
                    }
                    else
                    {
                        result = math.Divide(Data.operants.ToArray());
                        break;
                    }
                case Operator.Modulo:
                    result = math.Modulo(Data.operants.ToArray());
                    break;
                default:
                    result = 0;
                    break;
            }
            Data.historyStr.Clear();
            Data.historyStr.Append(Data.displayStr.ToString());
            Data.displayStr.Clear();
            Data.displayStr.Append(result.ToString());
            Data.operants.Clear();
            Data.operants.Add(result);
            GotOperant = true;
        }
        private bool IsLastCharOperator(string str)
        {
            if (str.Length == 0) return false;
            else
            {
                char c = str[str.Length - 1];
                return (c == '+' || c == '−' || c == '×' || c == '÷' || c == '%' || c == '-');
            }
        }
        private void DisplayResult()
        {
            txtHistory.Text = Data.historyStr.ToString();
            txtDisplay.Text = Data.displayStr.ToString();
        }
        private void ClearAll()
        {
            txtHistory.Text = string.Empty;
            Data.historyStr.Clear();
            EqualClicked = false;
            StartNewOperation();
        }
        private void StartNewOperation()
        {
            txtDisplay.Text = string.Empty;
            Data.operants.Clear();
            Data.operantStr.Clear();
            Data.displayStr.Clear();
            DotClicked = false;
            GotOperant = false;
            IsLastEnteredOperator = false;
            ops = Operator.NONE;
        }

        //************* ADDing functions ************
        private void AddOperator(string op, Operator opType)
        {
            if (EqualClicked)
            {
                ClearAll();
            }
            if (Data.displayStr.Length == 0)
            {
                AddDigit("0");
            }
            if (!GotOperant)
            {
                GetOperant();
            }
            if (ops != Operator.NONE)
            {
                PerformCalculation();
            }
            IsLastEnteredOperator = true;
            Data.displayStr.Append(op);
            DotClicked = false;
            ops = opType;
            DisplayResult();
        }
        private void AddDigit(string digit)
        {
            if (EqualClicked)
            {
                ClearAll();
            }
            if (Data.displayStr.Equals("0") && !DotClicked)
            {
                RemoveZero();
            }
            if (!IsLastEnteredOperator && Data.operants.Count > 0 && Data.operantStr.Length == 0)
            {
                Data.operantStr.Append(Data.displayStr.ToString());
                Data.operants.Clear();
            }
            Data.displayStr.Append(digit);
            Data.operantStr.Append(digit);
            IsLastEnteredOperator = false;
            GotOperant = false;
            DisplayResult();
        }

        //************* REMOVE functions ************
        private void RemoveLastInput()
        {
            if (IsLastEnteredOperator || IsLastCharOperator(Data.displayStr.ToString()))
            {
                RemoveOperator();
                DisplayResult();
            }
            else if (Data.displayStr.Length > 0 && Data.displayStr.ToString()[Data.displayStr.Length - 1] == '.')
            {
                DotClicked = false;
                RemoveLastAndDisplay();
            }
            else if (Data.operantStr.Length > 0)
            {
                RemoveLastAndDisplay();
            }
            else if (Data.operantStr.Length != Data.displayStr.Length)
            {
                Data.operantStr.Append(Data.displayStr.ToString());
                Data.operants.Clear();
                GotOperant = false;
                //RemoveLastAndDisplay();
            }
            if (Data.operantStr.Length == 0 && Data.operants.Count > 0)
            {
                RestoreOperant();
            }
        }
        private void RemoveOperator()
        {
            IsLastEnteredOperator = false;
            ops = Operator.NONE;
            Data.displayStr.Remove(Data.displayStr.Length - 1, 1);
        }
        private void RemoveLastAndDisplay()
        {
            Data.displayStr.Remove(Data.displayStr.Length - 1, 1);
            Data.operantStr.Remove(Data.operantStr.Length - 1, 1);
            DisplayResult();
        }
        private void RemoveZero()
        {
            Data.operantStr.Clear();
            Data.displayStr.Clear();
            Data.operants.Clear();
            GotOperant = false;
            DisplayResult();
        }
        

        // ********************* FORM Button functions *********************
        private void btnAC_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            RemoveLastInput();
        }
        private void btnMod_Click(object sender, EventArgs e)
        {
            if (IsLastCharOperator(Data.displayStr.ToString()))
            {
                ChangeOperator("%", Operator.Modulo);
            }
            else
            {
                AddOperator("%", Operator.Modulo);
            }
        }
        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (IsLastCharOperator(Data.displayStr.ToString()))
            {
                ChangeOperator("÷", Operator.Division);
            }

            else
            {
                AddOperator("÷", Operator.Division);
            }
        }
        private void btnMul_Click(object sender, EventArgs e)
        {
            if (IsLastCharOperator(Data.displayStr.ToString()))
            {
                ChangeOperator("×", Operator.Multiplication);
            }
            else
            {
                AddOperator("×", Operator.Multiplication);
            }
        }
        private void btnSub_Click(object sender, EventArgs e)
        {
            if (IsLastCharOperator(Data.displayStr.ToString()))
            { 
                ChangeOperator("−", Operator.Subtraction);
            }
            else
            {
                AddOperator("−", Operator.Subtraction);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsLastCharOperator(Data.displayStr.ToString()))
            {
                ChangeOperator("+", Operator.Addition);
            }
            else
            {
                AddOperator("+", Operator.Addition);
            }
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            EqualClicked = true;
            GetOperant();
            PerformCalculation();
            DisplayResult();
        }
        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!DotClicked)
            {
                if (Data.operantStr.Length == 0)
                {
                    AddDigit("0");
                }
                DotClicked = true;
                AddDigit(".");
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            AddDigit("1");
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            AddDigit("2");
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            AddDigit("3");
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            AddDigit("4");
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            AddDigit("5");
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            AddDigit("6");
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            AddDigit("7");
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            AddDigit("8");
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            AddDigit("9");
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            if (Data.operantStr.ToString() != "0")
            {
                AddDigit("0");
            }
        }
        private void btnPosNeg_Click(object sender, EventArgs e)
        {
            ConvertPosNeg();
        }
    }
}
