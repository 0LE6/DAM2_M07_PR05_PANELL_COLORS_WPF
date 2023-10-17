using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DAM2_M07_PR05_PANELL_COLORS_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            colorPicker.SelectedColorChanged += ColorPicker_SelectedColorChanged;
        }
        private void ColorPicker_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            if (e.NewValue.HasValue)
            {
                Color selectedColor = e.NewValue.Value;
                SolidColorBrush brush = new SolidColorBrush(selectedColor);
                cvColors.Background = brush; // Aplica el color al fondo del Canvas
            }
        }

        private void scbNumeroA_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (sldrA != null)
            {
                scbNumeroA.Value = sldrA.Value;

            }
            //double newValue = e.NewValue;

            //// Sincronizar con R, G y B
            //scbNumeroR.Value = newValue;
            //scbNumeroG.Value = newValue;
            //scbNumeroB.Value = newValue;

            // Aquí puedes actualizar el fondo del Canvas o realizar otras acciones según sea necesario
            UpdateCanvasColor();
        }

        private void scbNumeroR_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double newValue = e.NewValue;

            // Sincronizar con A, G y B
            scbNumeroA.Value = newValue;
            scbNumeroG.Value = newValue;
            scbNumeroB.Value = newValue;

            // Aquí puedes actualizar el fondo del Canvas o realizar otras acciones según sea necesario
            UpdateCanvasColor();
        }

        private void scbNumeroG_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double newValue = e.NewValue;

            // Sincronizar con A, R y B
            scbNumeroA.Value = newValue;
            scbNumeroR.Value = newValue;
            scbNumeroB.Value = newValue;

            // Aquí puedes actualizar el fondo del Canvas o realizar otras acciones según sea necesario
            UpdateCanvasColor();
        }

        private void scbNumeroB_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double newValue = e.NewValue;

            // Sincronizar con A, R y G
            scbNumeroA.Value = newValue;
            scbNumeroR.Value = newValue;
            scbNumeroG.Value = newValue;

            // Aquí puedes actualizar el fondo del Canvas o realizar otras acciones según sea necesario
            UpdateCanvasColor();
        }

        private void UpdateCanvasColor()
        {
            // Obtener los valores A, R, G y B de los controladores
            byte alpha = (byte)scbNumeroA.Value;
            byte red = (byte)scbNumeroR.Value;
            byte green = (byte)scbNumeroG.Value;
            byte blue = (byte)scbNumeroB.Value;

            // Crear un nuevo SolidColorBrush y aplicarlo al fondo del Canvas
            Color color = Color.FromArgb(alpha, red, green, blue);
            SolidColorBrush brush = new SolidColorBrush(color);
            cvColors.Background = brush;
        }



    }
}
