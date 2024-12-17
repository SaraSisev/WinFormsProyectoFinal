using MySql.Data.MySqlClient;
using ScottPlot;
using ScottPlot.Plottables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace WinFormsProyectoFinal
{
    public partial class FormGrafica : Form
    {


        public FormGrafica()
        {


            List<string> nombres = new List<string>(); //Vector para almacenar los nombres
            List<int> ventas = new List<int>();  //Vector para almacenar las ventas
            InitializeComponent();
            try
            {
                Conexion con = new Conexion(); //Conexion a la base de datos
                MySqlDataAdapter da;
                MySqlConnection conn = con.conexionBD();


                // Consulta para contar los registros
                string consulta = "SELECT nombre, ventas FROM proyectogina.productos"; // Cambia "TablaVentas", "Nombre" y "Ventas" según tu tabla y columnas.


                using (MySqlCommand command = new MySqlCommand(consulta, conn))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Agrega cada nombre al vector
                            nombres.Add(reader["nombre"].ToString());

                            // Agregar ventas a la lista
                            ventas.Add(Convert.ToInt32(reader["ventas"]));
                        }

                    }
                }

                string[] colorCodes = new string[] { "#3369cc", "#95bce3", "#f4a861", "#fd8d00" };
                ScottPlot.Palettes.Custom palette = new(colorCodes);

                //convertir listas a un arreglos para usarlas en las gráficas
                double[] ventasVect = Array.ConvertAll(ventas.ToArray(), x => (double)x);
                string[] nombresVect = nombres.ToArray();

                Tick[] ticks = new Tick[nombresVect.Length];
                for (int i = 0; i < nombresVect.Length; i++)
                {
                    ticks[i] = new Tick(i, nombres[i]);

                }

                //creando el grafico de barras
                var barPlot = formsPlot1.Plot.Add.Bars(ventasVect);

                //crea colores personalizados para cada barra
                for (int i = 0; i < ventasVect.Length; i++)
                {
                    barPlot.Bars[i].FillColor = palette.GetColor(i);
                    barPlot.Bars[i].FillHatch = new ScottPlot.Hatches.Striped();

                }

                foreach (var bar in barPlot.Bars)
                {
                    bar.LineWidth = 2;
                    bar.LineColor = bar.FillColor.Darken(0.5);
                    bar.FillHatchColor = bar.FillColor.Lighten(0.1);
                   
                }

                //configurar ticks personalizados
                formsPlot1.Plot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(ticks);
                formsPlot1.Plot.Axes.Bottom.MajorTickStyle.Length = 0; //sin marcas grandes en el eje X


                formsPlot1.Plot.HideGrid(); //ocultar la cuadrícula


                formsPlot1.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonLogoutG_Click(object sender, EventArgs e)
        {
            Form2 form2g = new Form2();
            form2g.Show();
            this.Hide();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            //Regresar al boton de inicio
            Form4 inicio = new Form4();
            inicio.Show();
            this.Close();
        }

        private void formsPlot1_Load(object sender, EventArgs e)
        {

        }
    }
}
