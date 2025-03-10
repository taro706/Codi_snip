using System;
using System.Windows.Forms;
using System.Drawing;

public class MainForm : Form
{
    public MainForm()
    {
        // Inicializar el control Label
        Label infoLabel = new Label();
        infoLabel.Text = "Pasa el ratón sobre mí para cambiar el color.";
        infoLabel.Font = new Font("Arial", 12);
        infoLabel.ForeColor = Color.Black;
        infoLabel.Location = new Point(10, 10);
        infoLabel.AutoSize = true;

        // Evento cuando el ratón pasa sobre el Label
        infoLabel.MouseHover += new EventHandler(OnMouseHover);

        // Evento cuando el ratón deja el Label
        infoLabel.MouseLeave += new EventHandler(OnMouseLeave);

        // Agregar el control Label al formulario
        this.Controls.Add(infoLabel);

        // Configuración del formulario
        this.Text = "Ejemplo de Label en Windows Forms";
        this.Size = new Size(400, 200);
    }

    // Evento que se dispara al pasar el ratón sobre el Label
    private void OnMouseHover(object sender, EventArgs e)
    {
        Label label = sender as Label;
        if (label != null)
        {
            label.BackColor = Color.LightBlue;  // Cambiar el fondo al pasar el ratón
        }
    }

    // Evento que se dispara al quitar el ratón del Label
    private void OnMouseLeave(object sender, EventArgs e)
    {
        Label label = sender as Label;
        if (label != null)
        {
            label.BackColor = Color.Transparent;  // Volver al fondo original
        }
    }

    public static void Main()
    {
        Application.Run(new MainForm());
    }
}
