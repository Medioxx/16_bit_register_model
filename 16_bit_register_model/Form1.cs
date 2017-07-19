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
        int secondLoop = 0;
        public Form1()
        {
            InitializeComponent();
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
            row = row + numericUpDown1.Value.ToString();
            Row_to_all.Text = row;
            numericUpDown1.Enabled = false;
            Add_code.Enabled = true;
            A.Enabled = false;
            B.Enabled = false;
            C.Enabled = false;
            D.Enabled = false;

        }
    }
}
