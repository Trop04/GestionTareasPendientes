using System.Media;

namespace GestionTareasPendientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* Me llevo bien con C# profe, es mi lenguaje favorito, si est� leyendo esto �Hablaremos sobre .NET en clases futuras?
        no conozco mucho el framework m�s all� de Blazor(por un intento de webapp mio) y me gustar�a ver como usar mejor el ecosistema de C#  */

        int numeroTareas = 1;
        List<string> tareaInsertada = new List<string>(500);
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            if (txtTarea.Text != string.Empty)
            {
                tareaInsertada.Add(txtTarea.Text);
                txtTarea.Clear();
                lstTareas.Items.Add($"Tarea {numeroTareas}: {tareaInsertada[numeroTareas - 1],10}");
                numeroTareas++;
            }
            else { SystemSounds.Hand.Play(); MessageBox.Show("La tarea no puede estar vac�a"); } //Encontr� como hacer el sonido de error de windows y se me ocurri� esto
        }



        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            int seleccion = lstTareas.SelectedIndex;
            if (numeroTareas > 1 && seleccion >= 0) // Estaba muy aburrido y decid� hacer que siempre tenga el # correcto de tareas, me fum� 40m en esto sin darme cuenta, deber�a practicar m�s lidiar con Lists
            {
                numeroTareas--;
                lstTareas.Items.RemoveAt(seleccion);
                tareaInsertada.RemoveAt(seleccion);

                for (int i = 0; i < lstTareas.Items.Count; i++) 
                {
                    lstTareas.Items[i] = ($"Tarea {i + 1}: {tareaInsertada[i],10}");
                }
            }


        }
        private void lstTareas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void txtTarea_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
