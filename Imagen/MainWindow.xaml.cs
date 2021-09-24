using System.Windows;

namespace Imagen
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();
        private void nivel1Boton_Click(object sender, RoutedEventArgs e) => this.foto.Opacity = 1;
        private void nivel2Boton_Click(object sender, RoutedEventArgs e) => this.foto.Opacity = 0.66;
        private void nivel3Boton_Click(object sender, RoutedEventArgs e) => this.foto.Opacity = 0.33;
    }
}
