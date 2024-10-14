using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using yWorks.Controls;
using yWorks.Graph;
using yWorks.Layout.Tree;

namespace SuperNovayFiles
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            graphControl.Loaded += OnGraphControlLoaded;
        }

        private void OnGraphControlLoaded(object sender, RoutedEventArgs e)
        {
            ConstruirGrafo();
        }

        private void ConstruirGrafo()
        {
            if (graphControl == null)
            {
                throw new ArgumentNullException(nameof(graphControl), "GraphControl no está inicializado.");
            }

            IGraph graph = graphControl.Graph;
            INode nodo1 = graph.CreateNode();
            graph.AddLabel(nodo1, "Nodo 1");

            INode nodo2 = graph.CreateNode();
            graph.CreateEdge(nodo1, nodo2);
        }
    }

    public class Personaje
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty; // Inicializar a una cadena vacía
        public string Apellido { get; set; } = string.Empty; // Inicializar a una cadena vacía
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaMuerte { get; set; }
    }

    public class Relacion
    {
        public int PersonajeId1 { get; set; }
        public int PersonajeId2 { get; set; }
        public string TipoRelacion { get; set; } = string.Empty; // Inicializar a una cadena vacía
    }
}
