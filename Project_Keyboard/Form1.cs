using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Keyboard
{
    public partial class Form1 : Form
    {
        string remember = "";
        protected override CreateParams CreateParams 
        {
            get 
            {
                CreateParams param = base.CreateParams;
                param.ExStyle |= 0x08000000;
                return param;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked )
            {
                txt輸入空框.Text += "Q";
                SendKeys.Send("Q");

            }
            else {
                SendKeys.Send("q");
                txt輸入空框.Text += "q";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked )
            {
                SendKeys.Send("W");
                txt輸入空框.Text += "W";

            }
            else
            {
                SendKeys.Send("w");
                txt輸入空框.Text += "w";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked )
            {
                SendKeys.Send("E");
                txt輸入空框.Text += "E";

            }
            else
            {
                SendKeys.Send("e");
                txt輸入空框.Text += "e";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked )
            {
                SendKeys.Send("R");
                txt輸入空框.Text += "R";

            }
            else
            {
                SendKeys.Send("r");
                txt輸入空框.Text += "r";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked)
            {
                SendKeys.Send("T");
                txt輸入空框.Text += "T";

            }
            else
            {
                SendKeys.Send("t");
                txt輸入空框.Text += "t";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked)
            {
                SendKeys.Send("Y");
                txt輸入空框.Text += "Y";

            }
            else
            {
                SendKeys.Send("y");
                txt輸入空框.Text += "y";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked)
            {
                SendKeys.Send("U");
                txt輸入空框.Text += "U";

            }
            else
            {
                SendKeys.Send("u");
                txt輸入空框.Text += "u";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked)
            {
                SendKeys.Send("I");
                txt輸入空框.Text += "I";

            }
            else
            {
                SendKeys.Send("i");
                txt輸入空框.Text += "i";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked)
            {
                SendKeys.Send("O");
                txt輸入空框.Text += "O";

            }
            else
            {
                SendKeys.Send("o");
                txt輸入空框.Text += "o";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked)
            {
                SendKeys.Send("P");
                txt輸入空框.Text += "P";

            }
            else
            {
                SendKeys.Send("p");
                txt輸入空框.Text += "p";
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {

            if (chkshift01.Checked || chkShift02.Checked) 
            {
                SendKeys.Send("{{}");
                txt輸入空框.Text += "{";
                chkshift01.Checked = false;
                chkShift02.Checked = false;
            }
            else
            {
                SendKeys.Send("{[}");
                txt輸入空框.Text += "[";
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (chkshift01.Checked || chkShift02.Checked)
            {
                SendKeys.Send("{}}");
                txt輸入空框.Text += "}";
                chkshift01.Checked = false;
                chkShift02.Checked = false;
            }
            else
            {
                SendKeys.Send("{]}");
                txt輸入空框.Text += "]";
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (chkshift01.Checked || chkShift02.Checked)
            {
                SendKeys.Send("{|}");
                txt輸入空框.Text += "|";
                chkshift01.Checked = false;
                chkShift02.Checked = false;
            }
            else
            {
                SendKeys.Send("{\\}");
                txt輸入空框.Text += "\\";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked)
            {
                SendKeys.Send("A");
                txt輸入空框.Text += "A";

            }
            else
            {
                SendKeys.Send("a");
                txt輸入空框.Text += "a";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked)
            {
                SendKeys.Send("S");
                txt輸入空框.Text += "S";

            }
            else
            {
                SendKeys.Send("s");
                txt輸入空框.Text += "s";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked)
            {
                SendKeys.Send("D");
                txt輸入空框.Text += "D";

            }
            else
            {
                SendKeys.Send("d");
                txt輸入空框.Text += "d";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked)
            {
                SendKeys.Send("F");
                txt輸入空框.Text += "F";

            }
            else
            {
                SendKeys.Send("f");
                txt輸入空框.Text += "f";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked)
            {
                SendKeys.Send("G");
                txt輸入空框.Text += "G";

            }
            else
            {
                SendKeys.Send("g");
                txt輸入空框.Text += "g";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked)
            {
                SendKeys.Send("H");
                txt輸入空框.Text += "H";

            }
            else
            {
                SendKeys.Send("h");
                txt輸入空框.Text += "h";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked)
            {
                SendKeys.Send("J");
                txt輸入空框.Text += "J";

            }
            else
            {
                SendKeys.Send("j");
                txt輸入空框.Text += "j";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked)
            {
                SendKeys.Send("K");
                txt輸入空框.Text += "K";

            }
            else
            {
                SendKeys.Send("k");
                txt輸入空框.Text += "k";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked)
            {
                SendKeys.Send("L");
                txt輸入空框.Text += "L";

            }
            else
            {
                SendKeys.Send("l");
                txt輸入空框.Text += "l";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (chkshift01.Checked || chkShift02.Checked)
            {
                SendKeys.Send("{:}");
                txt輸入空框.Text += ":";
                chkshift01.Checked = false;
                chkShift02.Checked = false;
            }
            else
            {
                SendKeys.Send("{;}");
                txt輸入空框.Text += ";";
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (chkshift01.Checked || chkShift02.Checked)
            {
                SendKeys.Send("{\"}");
                txt輸入空框.Text += "\"";
                chkshift01.Checked = false;
                chkShift02.Checked = false;
            }
            else
            {
                SendKeys.Send("{\'}");
                txt輸入空框.Text += "\'";
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked)
            {
                SendKeys.Send("Z");
                txt輸入空框.Text += "Z";

            }
            else
            {
                SendKeys.Send("z");
                txt輸入空框.Text += "z";
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked)
            {
                SendKeys.Send("X");
                txt輸入空框.Text += "X";

            }
            else
            {
                SendKeys.Send("x");
                txt輸入空框.Text += "x";
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked)
            {
                SendKeys.Send("C");
                txt輸入空框.Text += "C";

            }
            else
            {
                SendKeys.Send("c");
                txt輸入空框.Text += "c";
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked)
            {
                SendKeys.Send("V");
                txt輸入空框.Text += "V";

            }
            else
            {
                SendKeys.Send("v");
                txt輸入空框.Text += "v";
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked)
            {
                SendKeys.Send("B");
                txt輸入空框.Text += "B";

            }
            else
            {
                SendKeys.Send("b");
                txt輸入空框.Text += "b";
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked)
            {
                SendKeys.Send("N");
                txt輸入空框.Text += "N";

            }
            else
            {
                SendKeys.Send("n");
                txt輸入空框.Text += "n";
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (chkCapsLock.Checked)
            {
                SendKeys.Send("M");
                txt輸入空框.Text += "M";

            }
            else
            {
                SendKeys.Send("m");
                txt輸入空框.Text += "m";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (chkshift01.Checked || chkShift02.Checked)
            {
                SendKeys.Send("{<}");
                txt輸入空框.Text += "<";
                chkshift01.Checked = false;
                chkShift02.Checked = false;
            }
            else
            {
                SendKeys.Send("{,}");
                txt輸入空框.Text += ",";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (chkshift01.Checked || chkShift02.Checked)
            {
                SendKeys.Send("{>}");
                txt輸入空框.Text += ">";
                chkshift01.Checked = false;
                chkShift02.Checked = false;
            }
            else
            {
                SendKeys.Send("{.}");
                txt輸入空框.Text += ".";
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (chkshift01.Checked || chkShift02.Checked)
            {
                SendKeys.Send("{?}");
                txt輸入空框.Text += "?";
                chkshift01.Checked = false;
                chkShift02.Checked = false;
            }
            else
            {
                SendKeys.Send("{/}");
                txt輸入空框.Text += "/";
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (chkshift01.Checked || chkShift02.Checked)
            {
                SendKeys.Send("{~}");
                txt輸入空框.Text += "~";
                chkshift01.Checked = false;
                chkShift02.Checked = false;
            }
            else
            {
                SendKeys.Send("{`}");
                txt輸入空框.Text += "`";
            }
        }

        private void button55_Click(object sender, EventArgs e)
        {
            if (chkshift01.Checked || chkShift02.Checked)
            {
                SendKeys.Send("{!}");
                txt輸入空框.Text += "!";
                chkshift01.Checked = false;
                chkShift02.Checked = false;
            }
            else
            {
                SendKeys.Send("{1}");
                txt輸入空框.Text += "1";
            }
        }

        private void button54_Click(object sender, EventArgs e)
        {
            if (chkshift01.Checked || chkShift02.Checked)
            {
                SendKeys.Send("{@}");
                txt輸入空框.Text += "@";
                chkshift01.Checked = false;
                chkShift02.Checked = false;
            }
            else
            {
                SendKeys.Send("{2}");
                txt輸入空框.Text += "2";
            }
        }

        private void button51_Click(object sender, EventArgs e)
        {
            if (chkshift01.Checked || chkShift02.Checked)
            {
                SendKeys.Send("{#}");
                txt輸入空框.Text += "#";
                chkshift01.Checked = false;
                chkShift02.Checked = false;
            }
            else
            {
                SendKeys.Send("{3}");
                txt輸入空框.Text += "3";
            }
        }

        private void button52_Click(object sender, EventArgs e)
        {
            if (chkshift01.Checked || chkShift02.Checked)
            {
                SendKeys.Send("{$}");
                txt輸入空框.Text += "$";
                chkshift01.Checked = false;
                chkShift02.Checked = false;
            }
            else
            {
                SendKeys.Send("{4}");
                txt輸入空框.Text += "4";
            }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            if (chkshift01.Checked || chkShift02.Checked)
            {
                SendKeys.Send("{%}");
                txt輸入空框.Text += "%";
                chkshift01.Checked = false;
                chkShift02.Checked = false;
            }
            else
            {
                SendKeys.Send("{5}");
                txt輸入空框.Text += "5";
            }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            if (chkshift01.Checked || chkShift02.Checked)
            {
                SendKeys.Send("{^}");
                txt輸入空框.Text += "^";
                chkshift01.Checked = false;
                chkShift02.Checked = false;
            }
            else
            {
                SendKeys.Send("{6}");
                txt輸入空框.Text += "6";
            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            if (chkshift01.Checked || chkShift02.Checked)
            {
                SendKeys.Send("{&}");
                txt輸入空框.Text += "&";
                chkshift01.Checked = false;
                chkShift02.Checked = false;
            }
            else
            {
                SendKeys.Send("{7}");
                txt輸入空框.Text += "7";
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (chkshift01.Checked || chkShift02.Checked)
            {
                SendKeys.Send("{*}");
                txt輸入空框.Text += "*";
                chkshift01.Checked = false;
                chkShift02.Checked = false;
            }
            else
            {
                SendKeys.Send("{8}");
                txt輸入空框.Text += "8";
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            if (chkshift01.Checked || chkShift02.Checked)
            {
                SendKeys.Send("{(}");
                txt輸入空框.Text += "(";
                chkshift01.Checked = false;
                chkShift02.Checked = false;
            }
            else
            {
                SendKeys.Send("{9}");
                txt輸入空框.Text += "9";
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            if (chkshift01.Checked || chkShift02.Checked)
            {
                SendKeys.Send("{)}");
                txt輸入空框.Text += ")";
                chkshift01.Checked = false;
                chkShift02.Checked = false;
            }
            else
            {
                SendKeys.Send("{0}");
                txt輸入空框.Text += "0";
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (chkshift01.Checked || chkShift02.Checked)
            {
                SendKeys.Send("{_}");
                txt輸入空框.Text += "_";
                chkshift01.Checked = false;
                chkShift02.Checked = false;
            }
            else
            {
                SendKeys.Send("{-}");
                txt輸入空框.Text += "-";
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (chkshift01.Checked || chkShift02.Checked)
            {
                SendKeys.Send("{+}");
                txt輸入空框.Text += "+";
                chkshift01.Checked = false;
                chkShift02.Checked = false;
            }
            else
            {
                SendKeys.Send("{=}");
                txt輸入空框.Text += "=";
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{BACKSPACE}");
            string str = txt輸入空框.Text.ToString();
            txt輸入空框.Text = str.Remove(str.Length-1,1);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{TAB}");
        }

        private void button56_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");
            
            txt輸入空框.Text += "\r\n";
        }
        
        private void button41_Click(object sender, EventArgs e)
        {
            SendKeys.SendWait("^C");
            remember = txt輸入空框.Text.ToString();
            
        }

        private void button40_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{HOME}");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{%}");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            SendKeys.Send(" ");
            txt輸入空框.Text += " ";
        }

        private void button39_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{%}");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{^}");
        }

        private void button59_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ADD}");
            txt輸入空框.Text += "+";
        }

        private void button58_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{SUBTRACT}");
            txt輸入空框.Text += "-";
        }

        private void button60_Click(object sender, EventArgs e)
        {
            if (chkNUM.Checked) {

            }
            else {
                SendKeys.Send("7");
                txt輸入空框.Text += "7";
            }
        }

        private void button57_Click(object sender, EventArgs e)
        {
            if (chkNUM.Checked)
            {
                
            }
            else
            {
                SendKeys.Send("8");
                txt輸入空框.Text += "8";
            }
        }

        private void button67_Click(object sender, EventArgs e)
        {
            if (chkNUM.Checked)
            {

            }
            else
            {
                SendKeys.Send("9");
                txt輸入空框.Text += "9";
            }
        }

        private void button62_Click(object sender, EventArgs e)
        {
            if (chkNUM.Checked)
            {

            }
            else
            {
                SendKeys.Send("4");
                txt輸入空框.Text += "4";
            }
        }

        private void button61_Click(object sender, EventArgs e)
        {
            if (chkNUM.Checked)
            {

            }
            else
            {
                SendKeys.Send("5");
                txt輸入空框.Text += "5";
            }
        }

        private void button68_Click(object sender, EventArgs e)
        {
            if (chkNUM.Checked)
            {

            }
            else
            {
                SendKeys.Send("6");
                txt輸入空框.Text += "6";
            }
        }

        private void button64_Click(object sender, EventArgs e)
        {
            if (chkNUM.Checked)
            {

            }
            else
            {
                SendKeys.Send("1");
                txt輸入空框.Text += "1";
            }
        }

        private void button63_Click(object sender, EventArgs e)
        {
            if (chkNUM.Checked)
            {

            }
            else
            {
                SendKeys.Send("2");
                txt輸入空框.Text += "2";
            }
        }

        private void button69_Click(object sender, EventArgs e)
        {
            if (chkNUM.Checked)
            {

            }
            else
            {
                SendKeys.Send("3");
                txt輸入空框.Text += "3";
            }
        }

        private void button66_Click(object sender, EventArgs e)
        {
            if (chkNUM.Checked)
            {

            }
            else
            {
                SendKeys.Send("0");
                txt輸入空框.Text += "0";
            }
        }

        private void button65_Click(object sender, EventArgs e)
        {
            if (chkNUM.Checked)
            {

            }
            else
            {
                SendKeys.Send(".");
                txt輸入空框.Text += ".";
            }
        }

        private void button70_Click(object sender, EventArgs e)
        {
            if (chkNUM.Checked)
            {

            }
            else
            {
                SendKeys.Send("{ENTER}");
                txt輸入空框.Text += "\n";
            }
        }

        private void button90_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{PGUP}");
        }

        private void button91_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{PGDN}");
        }

        private void button92_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{RIGHT}");
            txt輸入空框.Select(txt輸入空框.SelectionStart, +1);
        }

        private void button93_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{LEFT}");
            txt輸入空框.Select(txt輸入空框.SelectionStart, -1);
        }

        private void button71_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ESC}");
        }

        private void button72_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F1}");
        }

        private void button73_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F2}");
        }

        private void button74_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F3}");
        }

        private void button78_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F4}");
        }

        private void button77_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F5}");
        }

        private void button76_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F6}");
        }

        private void button75_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F7}");
        }

        private void button82_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F8}");
        }

        private void button81_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F9}");
        }

        private void button80_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F10}");
        }

        private void button79_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F11}");
        }

        private void button86_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F12}");
        }

        private void button85_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{PRTSC}");
        }

        private void button84_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{INSERT}");
        }

        private void button83_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{DELETE}");
            txt輸入空框.Text = "";
        }

        private void button87_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{MULTIPLY}");
            txt輸入空框.Text += "*";
        }

        private void button88_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{DIVIDE}");
            txt輸入空框.Text += "/";
        }

        private void button89_Click(object sender, EventArgs e)
        {
            SendKeys.SendWait("^V");

            txt輸入空框.Text += remember;
        }

        private void chkshift01_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
