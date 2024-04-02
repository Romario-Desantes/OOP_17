using System;

namespace OOP_17
{
    public partial class Form1 : Form
    {
        Integer firstNumber;//��������� ��'���� ����� Integer
        Integer secondNumber;//��������� ��'���� ����� Integer
        Real firstNumberReal;//��������� ��'���� ����� Real
        Real secondNumberReal;//��������� ��'���� ����� Real

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            try
            {
                firstNumber = new Integer(int.Parse(textBoxInt1.Text));//����������� ��'����
                secondNumber = new Integer(int.Parse(textBoxInt2.Text));//����������� ��'����

                Number result;//��������� ��'���� ����� Number

                result = firstNumber.Add(secondNumber);
                lblAdd.Text = "����: " + ((Integer)result).A.ToString();
                result = firstNumber.Sub(secondNumber);
                lblSub.Text = "г�����: " + ((Integer)result).A.ToString();
                result = firstNumber.Mul(secondNumber);
                lblMul.Text = "�������: " + ((Integer)result).A.ToString();
                result = firstNumber.Div(secondNumber);
                lblDiv.Text = "������: " + ((Integer)result).A.ToString() + " (��������o �� �������)";

            }
            catch (FormatException)
            {
                lblAdd.Text = "������� ����� ������ �����!";
                lblSub.Text = "������� ����� ������ �����!";
                lblMul.Text = "������� ����� ������ �����!";
                lblDiv.Text = "������� ����� ������ �����!";
            }
            catch (DivideByZeroException)
            {
                lblDiv.Text = "ĳ���� �� ���� �� �����!";
            }
        }

        private void btnReal_Click(object sender, EventArgs e)
        {
            try
            {
                firstNumberReal = new Real(float.Parse(textBoxReal1.Text));//����������� ��'����
                secondNumberReal = new Real(float.Parse(textBoxReal2.Text));//����������� ��'����

                Number result;//��������� ��'���� ����� Number

                result = firstNumberReal.Add(secondNumberReal);
                lblAddReal.Text = "����: " + ((Real)result).A.ToString();
                result = firstNumberReal.Sub(secondNumberReal);
                lblSubReal.Text = "г�����: " + ((Real)result).A.ToString();
                result = firstNumberReal.Mul(secondNumberReal);
                lblMulReal.Text = "�������: " + ((Real)result).A.ToString();
                result = firstNumberReal.Div(secondNumberReal);
                lblDivReal.Text = "������: " + ((Real)result).A.ToString();
            }
            catch (FormatException)
            {
                lblAddReal.Text = "������� ����� ������ �����!";
                lblSubReal.Text = "������� ����� ������ �����!";
                lblMulReal.Text = "������� ����� ������ �����!";
                lblDivReal.Text = "������� ����� ������ �����!";
            }
            catch(DivideByZeroException) 
            {
                lblDivReal.Text = "ĳ���� �� ���� �� �����!";
            }
        }
    }
}
