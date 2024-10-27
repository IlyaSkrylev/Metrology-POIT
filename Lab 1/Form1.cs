using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        Dictionary<string, int> operandsList = new Dictionary<string, int>();
        Dictionary<string, int> operatorsList = new Dictionary<string, int>();

        // ключевые слова, которые идут вместе со скобками /*сюда надо добавлять имена функций*/
        List<string> operatorsWithParenthesis = new List<string>
        {
            "for", "while", "if", "do", "push"
        };

        // ключевые слова, которые не являются операндами
        List<string> reservedWords = new List<string>
        {
            "if", "else", "for", "while", "return", "function", "var", "let", "const",
            "class", "interface", "public", "private", "protected", "static", "void", "any", "", "do", "number", "push"
        };

        List<string> functionsName = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            dgvOperators.Rows.Clear();
            dgvOperands.Rows.Clear();
            rtbText.Clear();

            // Считываем с файла код и заносим в text
            string text = "";
            string path = "text.txt";
            StreamReader sr = new StreamReader(path);
            string line = sr.ReadLine();
            while (line != null)
            {
                rtbText.Text += line + '\n';
                text += line + '\n';
                line = sr.ReadLine();
            }
            sr.Close();
            
            operatorsList["+"] = Regex.Matches(text, @"[^\+]\+[^\+\=]").Count;
            operatorsList["-"] = Regex.Matches(text, @"[^\-]\-[^\-\=]").Count;
            operatorsList["*"] = Regex.Matches(text, @"\*(?!=)").Count;
            operatorsList["/"] = Regex.Matches(text, @"\/(?!=)").Count;
            operatorsList["%"] = Regex.Matches(text, @"\%(?!=)").Count;
            operatorsList["++"] = Regex.Matches(text, @"\+\+").Count;
            operatorsList["--"] = Regex.Matches(text, @"\-\-").Count;

            operatorsList["&"] = Regex.Matches(text, @"[^\&]\&[^\&]").Count;
            operatorsList["|"] = Regex.Matches(text, @"[^\|]\|[^\|]").Count;
            operatorsList["^"] = Regex.Matches(text, @"\^").Count;
            operatorsList["~"] = Regex.Matches(text, @"\~").Count;
            operatorsList[">>"] = Regex.Matches(text, @"[^\>]\>\>[^\>]").Count;
            operatorsList["<<"] = Regex.Matches(text, @"\<\<(?!=)").Count;
            operatorsList[">>>"] = Regex.Matches(text, @"\>\>\>").Count;

            operatorsList["="] = Regex.Matches(text, @"[^\+\-\*\/\%\<\>\!\=\<\>\&\|^]=[^\=]").Count;
            operatorsList["+="] = Regex.Matches(text, @"\+\=").Count;
            operatorsList["-="] = Regex.Matches(text, @"\-\=").Count;
            operatorsList["*="] = Regex.Matches(text, @"\*\=").Count;
            operatorsList["/="] = Regex.Matches(text, @"\/\=").Count;
            operatorsList["%="] = Regex.Matches(text, @"\%\=").Count;

            operatorsList["&="] = Regex.Matches(text, @"\&\=").Count;
            operatorsList["|="] = Regex.Matches(text, @"\|\=").Count;
            operatorsList["^="] = Regex.Matches(text, @"\^\=").Count;
            operatorsList[">>="] = Regex.Matches(text, @"[^\>]\>\>\=").Count;
            operatorsList["<<="] = Regex.Matches(text, @"\<\<\=").Count;
            operatorsList[">>>="] = Regex.Matches(text, @"\>\>\>\=").Count; // сдвиг вправо с добавлением нуля

            operatorsList["=="] = Regex.Matches(text, @"[^\=\!]\=\=[^\=]").Count;
            operatorsList["==="] = Regex.Matches(text, @"[^\!]\=\=\=").Count;
            operatorsList["!="] = Regex.Matches(text, @"\!\=(?!=)").Count;
            operatorsList["!=="] = Regex.Matches(text, @"\!\=\=(?!=)").Count;
            operatorsList["!==="] = Regex.Matches(text, @"\!\=\=\=;").Count;
            operatorsList[">="] = Regex.Matches(text, @"[^\>]\>\=;").Count;
            operatorsList["<="] = Regex.Matches(text, @"[^\<]\<\=").Count;
            operatorsList[">"] = Regex.Matches(text, @"[^\>]\>[^\>\=]").Count;
            operatorsList["<"] = Regex.Matches(text, @"[^\<]\<[^\<\=]").Count;

            operatorsList["&&"] = Regex.Matches(text, @"\&\&").Count;
            operatorsList["||"] = Regex.Matches(text, @"\|\|").Count;
            operatorsList["!"] = Regex.Matches(text, @"\!(?!=)").Count;

            operatorsList["?"] = Regex.Matches(text, @"\?").Count; // тернарный оператор

            operatorsList["if"] = Regex.Matches(text, @"\bif\b", RegexOptions.IgnoreCase).Count;
            operatorsList["do"] = Regex.Matches(text, @"\bdo\b", RegexOptions.IgnoreCase).Count;
            operatorsList["while"] = Regex.Matches(text, @"\bwhile\b", RegexOptions.IgnoreCase).Count - operatorsList["do"];
            operatorsList["for"] = Regex.Matches(text, @"\bfor\b", RegexOptions.IgnoreCase).Count;
            operatorsList["push"] = Regex.Matches(text, @"\bpush\b", RegexOptions.IgnoreCase).Count;

            GetWordsAfterFunction(text);
            foreach(var fName in functionsName)
            {
                operatorsList[fName] = Regex.Matches(text, fName, RegexOptions.IgnoreCase).Count;
            }

            operatorsList["( )"] = Regex.Matches(text, @"\(").Count - NumUnnecessaryParenthesis();
            operatorsList["{ }"] = Regex.Matches(text, @"\{").Count;
            operatorsList["[ ]"] = Regex.Matches(text, @"\[").Count;
            operatorsList[":"] = Regex.Matches(text, @"\:").Count - operatorsList["?"];
            operatorsList[";"] = Regex.Matches(text, @"\;").Count;
            operatorsList["."] = Regex.Matches(text, @"\.").Count;


            int numOperators = 0;
            int numUnicOperators = 0;
            foreach (var oper in operatorsList)
            {
                if (oper.Value != 0)
                {
                    dgvOperators.Rows.Add(oper.Key, oper.Value);
                    numUnicOperators++;
                }
                numOperators += oper.Value;
            }

            dgvOperators.Rows.Add("Всего", numOperators);
            lOperator.Text = "Общее число операторов: " + numOperators;
            lUOperator.Text = "Число уникальных операторов: " + numUnicOperators;

            operandsList = ExtractOperands(text);
            int numOperands = 0;
            int numUnicOperands = 0;
            foreach (var operands in operandsList)
            {
                if (operands.Value != 0)
                {
                    dgvOperands.Rows.Add(operands.Key, operands.Value);
                    numUnicOperands++;
                }
                numOperands += operands.Value;
            }
            dgvOperands.Rows.Add("Всего", numOperands);
            lOperand.Text = "Общее число операндов: " + numOperands;
            lUOperand.Text = "Число уникальных операндов: " + numUnicOperands;

            l1.Text = "Словарь программы: " + (numUnicOperators + numUnicOperands);
            l2.Text = "Длина программы: " + (numOperators + numOperands);
            l3.Text = "Объём программы: " + Math.Round((numOperators + numOperands) * Math.Log((numUnicOperators + numUnicOperands), 2), 3);
        }

        public Dictionary<string, int> ExtractOperands(string tsCode)
        {
            Dictionary<string, int> operandsList = new Dictionary<string, int>();

            string pattern = @"\b([a-zA-Z0-9_]*)\b";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(tsCode);
            foreach (Match match in matches)
            {
                string operand = match.Value;

                if (!IsReservedWord(operand))
                {
                    if (operandsList.ContainsKey(operand))
                    {
                        operandsList[operand]++;
                    }
                    else
                    {
                        operandsList[operand] = 1;
                    }
                }
            }

            return operandsList;
        }

        private bool IsReservedWord(string operand)
        {
            return reservedWords.Contains(operand);
        }

        private int NumUnnecessaryParenthesis()
        {
            int num = 0;
            foreach (var oper in operatorsList)
                if (IsOperatorWithParenthesis(oper.Key))
                    num += oper.Value;

            return num;
        }

        private bool IsOperatorWithParenthesis(string oper)
        {
            return operatorsWithParenthesis.Contains(oper);
        }

        private void GetWordsAfterFunction(string text)
        {
            var regex = new Regex(@"function\s+(\w+)\s*\(", RegexOptions.IgnoreCase);
            var funcs = regex.Matches(text);

            for (int i = 0; i < funcs.Count; i++)
            {
                var func = funcs[i].Groups[1].Value;

                operatorsWithParenthesis.Add(func);
                reservedWords.Add(func);
                bool isThereInTheArray = false;
                foreach (var fName in functionsName)
                    if (fName == func)
                        isThereInTheArray = true;

                if (!isThereInTheArray)
                    functionsName.Add(func);
            }
        }

        private void rtbText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}