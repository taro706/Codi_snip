using System;
using System.Windows.Forms;

namespace AplicacioCheckBoxWindows
{
    public class Form1 : Form
    {
        private CheckBox checkBox;

        public Form1()
        {
            // Inicialitzar el CheckBox
            checkBox = new CheckBox
            {
                Text = "El CheckBox està desmarcat",  // Text inicial del CheckBox
                Location = new System.Drawing.Point(100, 50), // Ubicació dins del formulari
                AutoSize = true // Ajustar automàticament la mida
            };

            // Afegir els esdeveniments per quan canviï l'estat del CheckBox
            checkBox.CheckedChanged += CheckBox_CheckedChanged;

            // Afegir el CheckBox al formulari
            Controls.Add(checkBox);

            // Configurar les propietats del formulari
            this.Text = "Exemple de CheckBox a Windows Forms";
            this.Size = new System.Drawing.Size(400, 200);
        }

        // Esdeveniment que es dispara quan canvia l'estat del CheckBox
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked)
            {
                checkBox.Text = "El CheckBox està marcat";  // Canviar el text quan està marcat
            }
            else
            {
                checkBox.Text = "El CheckBox està desmarcat";  // Canviar el text quan està desmarcat
            }
        }

        // Punt d'entrada per a l'aplicació
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());  // Mostrar el formulari
        }
    }
}
