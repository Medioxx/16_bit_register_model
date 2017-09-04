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
        private bool XorLH = false;
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
        public int getOlder()
        {
            return old_c; 
        }
        public int getYounger()
        {
            return you_c;
        }
        public int getall()
        {
            return dec_c;
        }
        public void addX(int number)
        {
            dec_c += number;
            XorLH = false;
            changeRegisters();
        }
        public void addH(int number)
        {
            old_c += number;
            XorLH = true;
            changeRegisters();

        }
        public void addL(int number)
        {
            you_c += number;
            XorLH = true;
            changeRegisters();
        }

        public void movX(int number)
        {
            dec_c = number;
            XorLH = false;
            changeRegisters();
        }


        public void movH(int number)
        {
            old_c = number;
            XorLH = true;
            changeRegisters();
        }

        public void movL(int number)
        {
            you_c = number;
            XorLH = true;
            changeRegisters();
        }


        public void subX(int number)
        {
            dec_c =dec_c- number;
            MessageBox.Show(dec_c.ToString());
            if (dec_c < 0)
                dec_c = 0;
            XorLH = false;
            changeRegisters();
        }

        public void subH(int number)
        {
            old_c -= number;
            if (old_c < 0)
            {
                you_c = +old_c;
                old_c = 0;
            }
            XorLH = true;
            changeRegisters();
        }

        public void subL(int number)
        {
            you_c -= number;
            if (you_c < 0)
                you_c = 0;
            XorLH = true;
            changeRegisters();
        }

        private void changeRegisters()
        {
            string decBinary;
            if (!XorLH)
            {
                if (dec_c > 255)
                {
                    you_c = 255;
                    old_c = dec_c - you_c;
                    decBinary = toBinary(dec_c);
                }
                else
                {
                    old_c = 0;
                    you_c = dec_c;
                    decBinary = toBinary(dec_c);
                }
            }
            else
            {
                string olderBinary = toBinary(old_c);
                if (olderBinary.Length < 8)
                {
                    for (int i = olderBinary.Length; i < 8; i++)
                        olderBinary = "0"+olderBinary;
                }
                string youngerBinary = toBinary(you_c);
                if (youngerBinary.Length < 8)
                {
                    for (int i = youngerBinary.Length; i < 8; i++)
                        youngerBinary = "0" + youngerBinary;
                }
                decBinary = olderBinary + youngerBinary;
                
                dec_c = Convert.ToInt32(decBinary, 2);
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
