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
        private Dictionary<string, int> varsDict { get; set; } = new Dictionary<string, int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.print = new System.Windows.Forms.Button();
            this.varInfo = new System.Windows.Forms.TextBox();
            this.printInfo = new System.Windows.Forms.TextBox();
            this.equalInfo = new System.Windows.Forms.TextBox();
            this.equality = new System.Windows.Forms.Button();
            this.addVar = new System.Windows.Forms.Button();
            this.varList = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // print
            // 
            this.print.Location = new System.Drawing.Point(376, 431);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(141, 44);
            this.print.TabIndex = 1;
            this.print.Text = "Print value";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // varInfo
            // 
            this.varInfo.Location = new System.Drawing.Point(32, 405);
            this.varInfo.Name = "varInfo";
            this.varInfo.Size = new System.Drawing.Size(141, 20);
            this.varInfo.TabIndex = 5;
            this.varInfo.TextChanged += new System.EventHandler(this.varInfo_TextChanged);
            // 
            // printInfo
            // 
            this.printInfo.Location = new System.Drawing.Point(376, 405);
            this.printInfo.Name = "printInfo";
            this.printInfo.Size = new System.Drawing.Size(141, 20);
            this.printInfo.TabIndex = 7;
            this.printInfo.TextChanged += new System.EventHandler(this.printName_TextChanged);
            // 
            // equalInfo
            // 
            this.equalInfo.Location = new System.Drawing.Point(700, 410);
            this.equalInfo.Name = "equalInfo";
            this.equalInfo.Size = new System.Drawing.Size(141, 20);
            this.equalInfo.TabIndex = 8;
            this.equalInfo.TextChanged += new System.EventHandler(this.equalInfo_TextChanged);
            // 
            // equality
            // 
            this.equality.Location = new System.Drawing.Point(700, 437);
            this.equality.Name = "equality";
            this.equality.Size = new System.Drawing.Size(141, 44);
            this.equality.TabIndex = 9;
            this.equality.Text = "Equality";
            this.equality.UseVisualStyleBackColor = true;
            this.equality.Click += new System.EventHandler(this.equality_Click);
            // 
            // addVar
            // 
            this.addVar.Location = new System.Drawing.Point(32, 431);
            this.addVar.Name = "addVar";
            this.addVar.Size = new System.Drawing.Size(141, 44);
            this.addVar.TabIndex = 10;
            this.addVar.Text = "Set value";
            this.addVar.UseVisualStyleBackColor = true;
            this.addVar.Click += new System.EventHandler(this.addVar_Click);
            // 
            // varList
            // 
            this.varList.Location = new System.Drawing.Point(729, 26);
            this.varList.Name = "varList";
            this.varList.Size = new System.Drawing.Size(112, 350);
            this.varList.TabIndex = 12;
            this.varList.Text = "";
            this.varList.TextChanged += new System.EventHandler(this.varList_TextChanged_1);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(867, 493);
            this.Controls.Add(this.varList);
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

        private void print_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(printInfo.Text))
            {
                MessageBox.Show(varsDict.ContainsKey(printInfo.Text) ? varsDict[printInfo.Text].ToString() : printInfo.Text);
                printInfo.Text = string.Empty;
            }
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

        private void equality_Click(object sender, EventArgs e)
        {

        }

        private void addVar_Click(object sender, EventArgs e)
        {
            varInfo.Text = varInfo.Text.Replace(" ", string.Empty);
            if (!string.IsNullOrEmpty(varInfo.Text))
            {
                var fieldInfo = varInfo.Text.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                if(fieldInfo.Count() != 2)
                {
                    MessageBox.Show("Error!");
                    varInfo.Text = string.Empty;
                    return;
                }
                var fieldVal = fieldInfo[1].Any(symbol => !Char.IsDigit(symbol)) ?
                    varsDict.ContainsKey(fieldInfo[1]) ? varsDict[fieldInfo[1]].ToString() : string.Empty : 
                    fieldInfo[1].ToString(); 
                if (string.IsNullOrEmpty(fieldVal))
                {
                    MessageBox.Show("Error!");
                    varInfo.Text = string.Empty;
                    return;
                }
                if (!varsDict.ContainsKey(fieldInfo[0]))
                {
                    varsDict.Add(fieldInfo[0], Convert.ToInt32(fieldVal));
                }
                else
                {
                    varsDict[fieldInfo[0]] = Convert.ToInt32(fieldVal);
                }
                varInfo.Text = string.Empty;
                varList.Text = getVarListInfo();
            }
        }

        private string getVarListInfo()
        {
            return string.Join("\n", varsDict.Select(obj => $"{obj.Key} = {obj.Value}"));
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            varList.Enabled = false;
        }

        private void varList_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
