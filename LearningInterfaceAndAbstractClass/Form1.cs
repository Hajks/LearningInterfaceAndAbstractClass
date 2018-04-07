using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningInterfaceAndAbstractClass
{

    public partial class Form1 : Form
    {
        Worker[] workers = new Worker[4];
        Queen queen;
        NectarStinger bobTheBee = new NectarStinger(); // new object with TURBO Bee ;)


        public Form1()
        {
            InitializeComponent();
            jobList.SelectedIndex = 0;
            workers[0] = new Worker (new string[] { "Nauczanie pszczółek", "Pielęgnacja jaj" }, 175); 
            workers[1] = new Worker (new string[] { "Utrzymalnie ula", "Wytwarzanie miodu" }, 114);
            workers[2] = new Worker (new string[] { "Zbieranie nektaru", "Patrol z żądłami" },149);
            workers[3] = new Worker (new string[] { "Nauczanie pszczółek", "Pielęgnacja jaj", "Utrzymanie ula", "Wytwarzanie miodu", "Zbieranie nektaru", "Patrol z żadłami" },155);
            queen = new Queen(workers, 275);
            bobTheBee.LookForEnemies(); //now, bob bee can use both methods LookForEnemies and FindFlowers.
            bobTheBee.FindFlowers(); 

        }
        private void button2_Click(object sender, EventArgs e) 
        {
            if(queen.AssignWork(jobList.Text, (int) numericUpDown1.Value) == false)
            {
                MessageBox.Show("Nie ma dostępnych pszczół do wykonania tego zadania '" + jobList.Text + "'", "Królowa pszczół mówi...");
            }
            else
            {
                MessageBox.Show("Zadanie '" + jobList.Text + "'" + " będzie ukończone za " + numericUpDown1.Value + " zmiany.", "Królowa pszczół mówi...");
            }
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            textBox1.Text = queen.WorkTheNextShift();
        }

    }
}


