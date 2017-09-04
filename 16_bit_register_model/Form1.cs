using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_bit_register_model
{
    public partial class Form1 : Form
    {
        int numberOfRows=1;
        String allCode="";
        String row="";
        Register Ar = new Register();
        Register Br = new Register();
        Register Cr = new Register();
        Register Dr = new Register();
        int secondLoop = 0;
        public Form1()
        {
            InitializeComponent();
            Register Arr = new Register(Older_A, YOUNGER_A, BINARY_A, DECIMAL_A);
            Register Brr = new Register(Older_B, YOUNGER_B1, BINARY_B, DECIMAL_B);
            Register Crr = new Register(Older_C, YOUNGER_C, BINARY_C, DECIMAL_C);
            Register Drr = new Register(Older_D, YOUNGER_D, BINARY_D, DECIMAL_D);
            Ar = Arr;
            Br = Brr;
            Cr = Crr;
            Dr = Drr;
        }

        private void MOV_Click(object sender, EventArgs e)
        {
            row = row+ numberOfRows.ToString() + " MOV";
            Row_to_all.Text = row;
            MOV.Enabled = false;
            ADD.Enabled = false;
            SUB.Enabled = false;
            A.Enabled = true;
            B.Enabled = true;
            C.Enabled = true;
            D.Enabled = true;
            Delete.Enabled = true;
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            row = row+ numberOfRows.ToString() + " ADD";
            Row_to_all.Text = row;
            MOV.Enabled = false;
            ADD.Enabled = false;
            SUB.Enabled = false;
            A.Enabled = true;
            B.Enabled = true;
            C.Enabled = true;
            D.Enabled = true;
            Delete.Enabled = true;
        }

        private void SUB_Click(object sender, EventArgs e)
        {
            row =row+ numberOfRows.ToString() + " SUB";
            Row_to_all.Text = row;
            MOV.Enabled = false;
            ADD.Enabled = false;
            SUB.Enabled = false;
            A.Enabled = true;
            B.Enabled = true;
            C.Enabled = true;
            D.Enabled = true;
            Delete.Enabled = true;
        }

        private void A_Click(object sender, EventArgs e)
        {
            row =row + " A";
            Row_to_all.Text = row;
            A.Enabled = false;
            B.Enabled = false;
            C.Enabled = false;
            D.Enabled = false;
            All.Enabled = true;
            H.Enabled = true;
            L.Enabled = true;
            if (secondLoop == 1)
            {
                numericUpDown1.Enabled = false;
            }


        }

        private void B_Click(object sender, EventArgs e)
        {
            row =row+ " B";
            Row_to_all.Text = row;
            A.Enabled = false;
            B.Enabled = false;
            C.Enabled = false;
            D.Enabled = false;
            All.Enabled = true;
            H.Enabled = true;
            L.Enabled = true;
            if (secondLoop == 1)
            {
                numericUpDown1.Enabled = false;
            }
       

        }

        private void C_Click(object sender, EventArgs e)
        {
            row =row + " C";
            Row_to_all.Text = row;
            A.Enabled = false;
            B.Enabled = false;
            C.Enabled = false;
            D.Enabled = false;
            All.Enabled = true;
            H.Enabled = true;
            L.Enabled = true;
            if (secondLoop == 1)
            {
                numericUpDown1.Enabled = false;
            }

        }

        private void D_Click(object sender, EventArgs e)
        {
            row =row+ " D";
            Row_to_all.Text = row;
            A.Enabled = false;
            B.Enabled = false;
            C.Enabled = false;
            D.Enabled = false;
            All.Enabled = true;
            H.Enabled = true;
            L.Enabled = true;
            if (secondLoop == 1)
            {
                numericUpDown1.Enabled = false;
            }
        }

        private void All_Click(object sender, EventArgs e)
        {

            row = row + "X";
            Row_to_all.Text = row;
            All.Enabled = false;
            H.Enabled = false;
            L.Enabled = false;
            secondLoop += 1;
            if (secondLoop % 2 == 0)
            {
                Add_code.Enabled = true;
            }
            else
            {
                A.Enabled = true;
                B.Enabled = true;
                C.Enabled = true;
                D.Enabled = true;
                numericUpDown1.Enabled = true;
                row = row + ",";
                Row_to_all.Text = row;
            }

        }

        private void H_Click(object sender, EventArgs e)
        {
            row = row + "H";
            Row_to_all.Text = row;
            All.Enabled = false;
            H.Enabled = false;
            L.Enabled = false;
            secondLoop += 1;
            if (secondLoop % 2 == 0)
            {
                Add_code.Enabled = true;
            }
            else
            {
                A.Enabled = true;
                B.Enabled = true;
                C.Enabled = true;
                D.Enabled = true;
                numericUpDown1.Enabled = true;
                row = row + ",";
                Row_to_all.Text = row;
            }

        }

        private void L_Click(object sender, EventArgs e)
        {
            row = row+ "L";
            Row_to_all.Text = row;
            All.Enabled = false;
            H.Enabled = false;
            L.Enabled = false;
            secondLoop += 1;
            if (secondLoop % 2 == 0)
            {
                Add_code.Enabled = true;
            }
            else
            {
                A.Enabled = true;
                B.Enabled = true;
                C.Enabled = true;
                D.Enabled = true;
                numericUpDown1.Enabled = true;
                row = row + ",";
                Row_to_all.Text = row;
            }
        }

        private void Add_code_Click(object sender, EventArgs e)
        {
            allCode = allCode+ row + Environment.NewLine;
            textBox1.Text =allCode;
            numberOfRows += 1;
            MOV.Enabled = true;
            ADD.Enabled = true;
            SUB.Enabled = true;
            Compile.Enabled = true;
            Add_code.Enabled = false;
            Delete.Enabled = false;
            row = "";
            Row_to_all.Text = row;
            secondLoop = 0;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            row = "";
            MOV.Enabled = true;
            ADD.Enabled = true;
            SUB.Enabled = true;
            All.Enabled = false;
            H.Enabled = false;
            L.Enabled = false;
            A.Enabled = false;
            B.Enabled = false;
            C.Enabled = false;
            D.Enabled = false;
            secondLoop = 0;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {   
            row = row +" " +numericUpDown1.Value.ToString();
            Row_to_all.Text = row;
            numericUpDown1.Enabled = false;
            Add_code.Enabled = true;
            A.Enabled = false;
            B.Enabled = false;
            C.Enabled = false;
            D.Enabled = false;

        }

        private void Compile_Click(object sender, EventArgs e)
        {
            string compileText = textBox1.Text;
            string[] bekate = new string[numberOfRows];
            string[] bekate2 = new string[4];
            bekate=compileText.Split('\n');
            for (int i = 0; i < numberOfRows-1; i++)
            {
                compilator(bekate[i]);
                MessageBox.Show(bekate[i]);

            }



        }


        void compilator(string line)
        {
            string[] splittedLine = line.Split(' ');
            MessageBox.Show(splittedLine[1]+splittedLine[2]);
            switch (splittedLine[1])
            {
                case "ADD":
                    ADDcompile(splittedLine[2], splittedLine[3]);
                    break;
                case "SUB":
                    SUBcompile(splittedLine[2], splittedLine[3]);
                    break;
                case "MOV":
                    MOVcompile(splittedLine[2], splittedLine[3]);
                    break;
            }
            

        }

        int getNumber(string line2)
        {
            int x = 0;
            if (Int32.TryParse(line2, out x))
            {


            }
            else
            {
                switch (line2)
                {
                    case "AX":
                        x = Ar.getall();
                        break;
                    case "AH":
                        x = Ar.getOlder();
                        break;
                    case "AL":
                        x = Ar.getYounger();
                        break;
                    case "BX":
                        x = Br.getall();
                        break;
                    case "BH":
                        x = Br.getOlder();
                        break;
                    case "BL":
                        x = Br.getYounger();
                        break;
                    case "CX":
                        x = Cr.getall();
                        break;
                    case "CH":
                        x = Cr.getOlder();
                        break;
                    case "CL":
                        x = Cr.getYounger();
                        break;
                    case "DX":
                        x = Dr.getall();
                        break;
                    case "DH":
                        x = Ar.getOlder();
                        break;
                    case "DL":
                        x = Ar.getYounger();
                        break;

                }

            }
            return x;
        }

        void ADDcompile(string line, string line2)
        {
            int number = getNumber(line2);
            switch (line)
            {
                case "AX,":
                     Ar.addX(number);
                    break;
                case "AH,":
                    Ar.addH(number);
                    break;
                case "AL,":
                    Ar.addL(number);
                    break;
                case "BX,":
                    Br.addX(number);
                    break;
                case "BH,":
                    Br.addH(number);
                    break;
                case "BL,":
                    Br.addL(number);
                    break;
                case "CX,":
                    Cr.addX(number);
                    break;
                case "CH,":
                    Cr.addH(number);
                    break;
                case "CL,":
                    Cr.addL(number);
                    break;
                case "DX,":
                    Dr.addX(number);
                    break;
                case "DH,":
                    Dr.addH(number);
                    break;
                case "DL,":
                    Dr.addL(number);
                    break;

            }

        }


        void SUBcompile(string line, string line2)
        {
            int number = getNumber(line2);
            switch (line)
            {
                case "AX,":
                    Ar.subX(number);
                    break;
                case "AH,":
                    Ar.subH(number);
                    break;
                case "AL,":
                    Ar.subL(number);
                    break;
                case "BX,":
                    Br.subX(number);
                    break;
                case "BH,":
                    Br.subH(number);
                    break;
                case "BL,":
                    Br.subL(number);
                    break;
                case "CX,":
                    Cr.subX(number);
                    break;
                case "CH,":
                    Cr.subH(number);
                    break;
                case "CL,":
                    Cr.subL(number);
                    break;
                case "DX,":
                    Dr.subX(number);
                    break;
                case "DH,":
                    Dr.subH(number);
                    break;
                case "DL,":
                    Dr.subL(number);
                    break;

            }

        }
        void MOVcompile(string line, string line2)
        {
            int number = getNumber(line2);
            switch (line)
            {
                case "AX,":
                    Ar.movX(number);
                    break;
                case "AH,":
                    Ar.movH(number);
                    break;
                case "AL,":
                    Ar.movL(number);
                    break;
                case "BX,":
                    Br.movX(number);
                    break;
                case "BH,":
                    Br.movH(number);
                    break;
                case "BL,":
                    Br.movL(number);
                    break;
                case "CX,":
                    Cr.movX(number);
                    break;
                case "CH,":
                    Cr.movH(number);
                    break;
                case "CL,":
                    Cr.movL(number);
                    break;
                case "DX,":
                    Dr.movX(number);
                    break;
                case "DH,":
                    Dr.movH(number);
                    break;
                case "DL,":
                    Dr.movL(number);
                    break;

            }

        }
    }
}
