using System;

namespace OOP_17
{
    public partial class Form1 : Form
    {
        Integer firstNumber;//створення об'єкту класу Integer
        Integer secondNumber;//створення об'єкту класу Integer
        Real firstNumberReal;//створення об'єкту класу Real
        Real secondNumberReal;//створення об'єкту класу Real

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            try
            {
                firstNumber = new Integer(int.Parse(textBoxInt1.Text));//ініціалізація об'єкта
                secondNumber = new Integer(int.Parse(textBoxInt2.Text));//ініціалізація об'єкта

                Number result;//створення об'єкту класу Number

                result = firstNumber.Add(secondNumber);
                lblAdd.Text = "Сума: " + ((Integer)result).A.ToString();
                result = firstNumber.Sub(secondNumber);
                lblSub.Text = "Різниця: " + ((Integer)result).A.ToString();
                result = firstNumber.Mul(secondNumber);
                lblMul.Text = "Добуток: " + ((Integer)result).A.ToString();
                result = firstNumber.Div(secondNumber);
                lblDiv.Text = "Частка: " + ((Integer)result).A.ToString() + " (округленo до меншого)";

            }
            catch (FormatException)
            {
                lblAdd.Text = "Введено інший формат даних!";
                lblSub.Text = "Введено інший формат даних!";
                lblMul.Text = "Введено інший формат даних!";
                lblDiv.Text = "Введено інший формат даних!";
            }
            catch (DivideByZeroException)
            {
                lblDiv.Text = "Ділити на нуль не можна!";
            }
        }

        private void btnReal_Click(object sender, EventArgs e)
        {
            try
            {
                firstNumberReal = new Real(float.Parse(textBoxReal1.Text));//ініціалізація об'єкта
                secondNumberReal = new Real(float.Parse(textBoxReal2.Text));//ініціалізація об'єкта

                Number result;//створення об'єкту класу Number

                result = firstNumberReal.Add(secondNumberReal);
                lblAddReal.Text = "Сума: " + ((Real)result).A.ToString();
                result = firstNumberReal.Sub(secondNumberReal);
                lblSubReal.Text = "Різниця: " + ((Real)result).A.ToString();
                result = firstNumberReal.Mul(secondNumberReal);
                lblMulReal.Text = "Добуток: " + ((Real)result).A.ToString();
                result = firstNumberReal.Div(secondNumberReal);
                lblDivReal.Text = "Частка: " + ((Real)result).A.ToString();
            }
            catch (FormatException)
            {
                lblAddReal.Text = "Введено інший формат даних!";
                lblSubReal.Text = "Введено інший формат даних!";
                lblMulReal.Text = "Введено інший формат даних!";
                lblDivReal.Text = "Введено інший формат даних!";
            }
            catch(DivideByZeroException) 
            {
                lblDivReal.Text = "Ділити на нуль не можна!";
            }
        }
    }
}
