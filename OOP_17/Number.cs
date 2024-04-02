using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_17
{
    abstract class Number//абстрактний базовий клас Number
    {
        public abstract Number Add(Number num);//віртуальний метод додавання
        public abstract Number Sub(Number num);//віртувальний метод віднімання
        public abstract Number Mul(Number num);//віртуальний метод множення
        public abstract Number Div(Number num);//віртуальний метод ділення
    }
    class Integer : Number//похідний клас Integer
    {
        private int a;
        public int A//властивість
        {
            get { return a; }
            set { a = value; }
        }

        public Integer(int A)//конструктор 
        {
            a = A;
        }

        public override Number Add(Number num)//опис методу додавання 
        {
            Number temp = new Integer(this.a + ((Integer)num).a);
            return temp;
        }
        public override Number Sub(Number num)//опис методу віднімання 
        {
            Number temp = new Integer(this.a - ((Integer)num).a);
            return temp;
        }
        public override Number Mul(Number num)//опис методу множення 
        {
            Number temp = new Integer(this.a * ((Integer)num).a);
            return temp;
        }
        public override Number Div(Number num)//опис методу ділення
        {
            Number temp;
            if(((Integer)num).a != 0)
            {
                temp = new Integer(this.a / ((Integer)num).a);
                return temp;
            }
            else
            {
                throw new DivideByZeroException();
            }
            
        }
    }
    class Real : Number//похідний клас Real
    {
        private float a;
        public float A//властивість
        {
            get { return a; }
            set { a = value; }
        }
        public Real(float A)//конструктор 
        {
            this.a = A;
        }

        public override Number Add(Number num)//опис методу додавання
        {
            Number temp = new Real(this.a + ((Real)num).a);
            return temp;
        }

        public override Number Div(Number num)//опис методу ділення
        {
            Number temp;
            if (((Real)num).a != 0)
            {
                temp = new Real(this.a / ((Real)num).a);
                return temp;
            }
            else
            {
                throw new DivideByZeroException();
            }
        }

        public override Number Mul(Number num)//опис методу множення 
        {
            Number temp = new Real(this.a * ((Real)num).a);
            return temp;
        }

        public override Number Sub(Number num)//опис методу віднімання 
        {
            Number temp = new Real(this.a - ((Real)num).a);
            return temp;
        }
    }
}
