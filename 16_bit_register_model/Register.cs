using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_bit_register_model
{
    class Register
    {
        private Label older;
        private Label younger;
        private Label binary;
        private Label dec;
        private int old_c = 0;
        private int you_c = 0;
        private int dec_c = 0;
        public Register(Label one, Label two, Label three, Label four)
        {
            older = one;
            younger = two;
            binary = three;
            dec = four;
        }
        public Register()
        {

        }
        public void test()
        {
            older.Text = "beka";
        }
        public void addX(int number)
        {
            dec_c = dec_c + number;
            changeRegisters();
        }
        public void addH(int number)
        {
            old_c = +number;
            changeRegisters();
        }
        public void addL(int number)
        {
            you_c = +number;
            changeRegisters();
        }

        public void movX(int number)
        {
            dec_c = number;
            changeRegisters();
        }

        public void movH(int number)
        {
            old_c = number;
            changeRegisters();
        }

        public void movL(int number)
        {
            you_c = number;
            changeRegisters();
        }


        public void subX(int number)
        {
            dec_c = -number;
            if (dec_c < 0)
                dec_c = 0;

            changeRegisters();
        }

        public void subH(int number)
        {
            old_c = -number;
            if (old_c < 0)
            {
                you_c = +old_c;
                old_c = 0;
            }
            changeRegisters();
        }

        public void subL(int number)
        {
            you_c = -number;
            if (you_c < 0)
                you_c = 0;

            changeRegisters();
        }

        private void changeRegisters()
        {
            string decBinary = toBinary(dec_c);
            if (dec_c > 255)
            {
                you_c = 255;
                old_c = dec_c - you_c;

            }
            else
            {
                old_c = 0;
                you_c = dec_c;
            }
            dec.Text = dec_c.ToString();
            binary.Text = decBinary;
            older.Text = old_c.ToString();
            younger.Text = you_c.ToString();

        }


        private string toBinary(int number)
        {
            string str = Convert.ToString(number, 2);
            dec.Text = str;
            return str;
        }
    }
}
