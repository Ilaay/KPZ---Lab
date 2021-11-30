using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ivanov
{
    public partial class Form1 : Form
    {
        public Algorithm ProgramAlgorithm { get; private set; } = new Algorithm();
        public Form1()
        {
            InitializeComponent();
        }

        private void print_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(printInfo.Text))
            {
                ProgramAlgorithm.Add(WorkType.Print, printInfo.Text);
                if (string.IsNullOrEmpty(Algorithm.Text))
                {
                    Algorithm.Text = $"Print ({printInfo.Text})";
                }
                else
                {
                    Algorithm.Text += $" -> Print ({printInfo.Text})";
                }
                printInfo.Text = string.Empty;
            }
        }

        #region smth
        private void InitializeComponent()
        {
            this.print = new System.Windows.Forms.Button();
            this.varInfo = new System.Windows.Forms.TextBox();
            this.printInfo = new System.Windows.Forms.TextBox();
            this.equalInfo = new System.Windows.Forms.TextBox();
            this.equality = new System.Windows.Forms.Button();
            this.addVar = new System.Windows.Forms.Button();
            this.Algorithm = new System.Windows.Forms.RichTextBox();
            this.algorithmLabel = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // print
            // 
            this.print.Location = new System.Drawing.Point(226, 224);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(141, 44);
            this.print.TabIndex = 1;
            this.print.Text = "Print value";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // varInfo
            // 
            this.varInfo.Location = new System.Drawing.Point(32, 198);
            this.varInfo.Name = "varInfo";
            this.varInfo.Size = new System.Drawing.Size(141, 20);
            this.varInfo.TabIndex = 5;
            this.varInfo.TextChanged += new System.EventHandler(this.varInfo_TextChanged);
            // 
            // printInfo
            // 
            this.printInfo.Location = new System.Drawing.Point(226, 198);
            this.printInfo.Name = "printInfo";
            this.printInfo.Size = new System.Drawing.Size(141, 20);
            this.printInfo.TabIndex = 7;
            this.printInfo.TextChanged += new System.EventHandler(this.printName_TextChanged);
            // 
            // equalInfo
            // 
            this.equalInfo.Location = new System.Drawing.Point(423, 198);
            this.equalInfo.Name = "equalInfo";
            this.equalInfo.Size = new System.Drawing.Size(141, 20);
            this.equalInfo.TabIndex = 8;
            this.equalInfo.TextChanged += new System.EventHandler(this.equalInfo_TextChanged);
            // 
            // equality
            // 
            this.equality.Location = new System.Drawing.Point(423, 224);
            this.equality.Name = "equality";
            this.equality.Size = new System.Drawing.Size(141, 44);
            this.equality.TabIndex = 9;
            this.equality.Text = "Equality";
            this.equality.UseVisualStyleBackColor = true;
            this.equality.Click += new System.EventHandler(this.equality_Click);
            // 
            // addVar
            // 
            this.addVar.Location = new System.Drawing.Point(32, 224);
            this.addVar.Name = "addVar";
            this.addVar.Size = new System.Drawing.Size(141, 44);
            this.addVar.TabIndex = 10;
            this.addVar.Text = "Set value";
            this.addVar.UseVisualStyleBackColor = true;
            this.addVar.Click += new System.EventHandler(this.addVar_Click);
            // 
            // Algorithm
            // 
            this.Algorithm.Location = new System.Drawing.Point(32, 51);
            this.Algorithm.Name = "Algorithm";
            this.Algorithm.Size = new System.Drawing.Size(532, 104);
            this.Algorithm.TabIndex = 14;
            this.Algorithm.Text = "";
            this.Algorithm.TextChanged += new System.EventHandler(this.Algorithm_TextChanged);
            // 
            // algorithmLabel
            // 
            this.algorithmLabel.AutoSize = true;
            this.algorithmLabel.Location = new System.Drawing.Point(279, 18);
            this.algorithmLabel.Name = "algorithmLabel";
            this.algorithmLabel.Size = new System.Drawing.Size(50, 13);
            this.algorithmLabel.TabIndex = 15;
            this.algorithmLabel.Text = "Algorithm";
            this.algorithmLabel.Click += new System.EventHandler(this.algorithmLabel_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(32, 280);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(532, 23);
            this.Start.TabIndex = 16;
            this.Start.Text = "START";
            this.Start.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(594, 315);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.algorithmLabel);
            this.Controls.Add(this.Algorithm);
            this.Controls.Add(this.addVar);
            this.Controls.Add(this.equality);
            this.Controls.Add(this.equalInfo);
            this.Controls.Add(this.printInfo);
            this.Controls.Add(this.varInfo);
            this.Controls.Add(this.print);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void varList_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Algorithm_TextChanged(object sender, EventArgs e)
        {

        }

        private void printName_TextChanged(object sender, EventArgs e)
        {

        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void varInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void equalInfo_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void addVar_Click(object sender, EventArgs e)
        {
            varInfo.Text = varInfo.Text.Replace(" ", string.Empty);
            if (!string.IsNullOrEmpty(varInfo.Text))
            {
                if (varInfo.Text.Count(ch => ch == '=') != 1)
                {
                    MessageBox.Show("Error!");
                    varInfo.Text = string.Empty;
                    return;
                }
                ProgramAlgorithm.Add(WorkType.Add, varInfo.Text);
                if (string.IsNullOrEmpty(Algorithm.Text))
                {
                    Algorithm.Text = $"Set value ({varInfo.Text})";
                }
                else
                {
                    Algorithm.Text += $" -> Set value ({varInfo.Text})";
                }
                varInfo.Text = string.Empty;
            }
        }

        private void equality_Click(object sender, EventArgs e)
        {
            equalInfo.Text = equalInfo.Text.Replace(" ", string.Empty);
            if (!string.IsNullOrEmpty(equalInfo.Text) && equalInfo.Text.Count(ch => ch == '?') == 1 && equalInfo.Text.Count(ch => ch == ':') == 1)
            {
                ProgramAlgorithm.Add(WorkType.Equality, equalInfo.Text);
                if (string.IsNullOrEmpty(Algorithm.Text))
                {
                    Algorithm.Text = $"Equality ({equalInfo.Text})";
                }
                else
                {
                    Algorithm.Text += $" -> Equality ({equalInfo.Text})";
                }
                equalInfo.Text = string.Empty;
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Algorithm.Enabled = false;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            ProgramAlgorithm.DoAlgorithm(5);
        }

        private void algorithmLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

public enum WorkType
{
    Add,
    Print,
    Equality
}

public class Algorithm
{
    private List<Tuple<WorkType, string>> algorithm { get; set; }

    public Algorithm()
    {
        algorithm = new List<Tuple<WorkType, string>>();
    }

    public void Add(WorkType workType, string text)
    {
        algorithm.Add(new Tuple<WorkType, string>(workType, text));
    }

    public void DoAlgorithm(int numOfAlg = 0)
    {
        Dictionary<string, int> algDict = new Dictionary<string, int>();
        foreach (var step in algorithm)
        {
            switch (step.Item1)
            {
                case WorkType.Add:
                    Add_worktype(step.Item2, algDict);
                    break;
                case WorkType.Print:
                    MessageBox.Show(algDict.ContainsKey(step.Item2) ? algDict[step.Item2].ToString() : step.Item2, $"Print ({step.Item2})");
                    break;
                case WorkType.Equality:
                    var conditionText = step.Item2.Substring(0, step.Item2.IndexOf('?'));
                    var trueCondText = step.Item2.Substring(step.Item2.IndexOf('?') + 1, step.Item2.IndexOf(':') - step.Item2.IndexOf('?') - 1);
                    var falseCondText = step.Item2.Substring(step.Item2.IndexOf(':') + 1);
                    if (checkCondition(conditionText, algDict))
                    {
                        Add_worktype(trueCondText, algDict);
                    }
                    else
                    {
                        Add_worktype(falseCondText, algDict);
                    }
                    break;
                default:
                    MessageBox.Show("Error!");
                    break;
            }
        }
        MessageBox.Show(string.Join("\n", algDict.Select(varInfo => $"{varInfo.Key} = {varInfo.Value}")), $"Result ({numOfAlg})");
    }

    private void Add_worktype(string text, Dictionary<string, int> algDict)
    {
        var fieldInfo = text.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
        var fieldVal = fieldInfo[1].Any(symbol => !Char.IsDigit(symbol)) ?
            algDict.ContainsKey(fieldInfo[1]) ? algDict[fieldInfo[1]].ToString() : string.Empty :
            fieldInfo[1].ToString();
        if (string.IsNullOrEmpty(fieldVal))
        {
            MessageBox.Show("Error!");
            return;
        }
        if (!algDict.ContainsKey(fieldInfo[0]))
        {
            algDict.Add(fieldInfo[0], Convert.ToInt32(fieldVal));
        }
        else
        {
            algDict[fieldInfo[0]] = Convert.ToInt32(fieldVal);
        }
    }

    private bool checkCondition(string condition, Dictionary<string, int> vars)
    {
        var f1 = condition.IndexOf(condition.First(ch => !Char.IsLetterOrDigit(ch)));
        var l1 = condition.LastIndexOf(condition.Last(ch => !Char.IsLetterOrDigit(ch)));

        var val1Text = condition.Substring(0, f1);
        var val2Text = condition.Substring(l1 + 1);

        var check = condition.Substring(f1, l1 - f1 + 1);

        var val1 = val1Text.Any(ch => !Char.IsDigit(ch)) ? vars[val1Text] : Convert.ToInt32(val1Text);
        var val2 = val2Text.Any(ch => !Char.IsDigit(ch)) ? vars[val2Text] : Convert.ToInt32(val2Text);

        switch (check)
        {
            case "==":
                return val1 == val2;
                break;
            case "<=":
                return val1 <= val2;
                break;
            case ">=":
                return val1 >= val2;
                break;
            case "<":
                return val1 < val2;
                break;
            case ">":
                return val1 > val2;
                break;
            default:
                return false;
        }
    }
}