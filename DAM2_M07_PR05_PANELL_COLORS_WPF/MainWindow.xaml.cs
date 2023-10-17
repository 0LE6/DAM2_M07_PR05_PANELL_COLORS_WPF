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
            }
        }
        // -------------------------- ZONA SCROLLBARS--------------------------------
        private void scbNumeroA_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (sldrA != null)
            {
                sldrA.Value = scbNumeroA.Value;
            }
            ActualizacionColorCanvas();
        }

        private void scbNumeroR_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (sldrR != null)
            {
                sldrR.Value = scbNumeroR.Value;
            }
            ActualizacionColorCanvas();
        }

        private void scbNumeroG_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (sldrG != null)
            {
                sldrG.Value = scbNumeroG.Value;
            }
            ActualizacionColorCanvas();
        }

        private void scbNumeroB_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (sldrB != null)
            {
                sldrB.Value = scbNumeroB.Value;
            }
            ActualizacionColorCanvas();
        }

        // ---------------------- ZONA SLIDERS ----------------------------
        private void sldrA_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (sldrA != null)
            {
                scbNumeroA.Value = sldrA.Value;
            }
        }

        private void sldrR_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (sldrR != null)
            {
                scbNumeroR.Value = sldrR.Value;
            }
        }

        private void sldrG_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (sldrG != null)
            {
                scbNumeroG.Value = sldrG.Value;
            }
        }

        private void sldrB_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (sldrB != null)
            {
                scbNumeroB.Value = sldrB.Value;
            }
        }

        // Método para pintar el canvas cuando se cambien números
        private void ActualizacionColorCanvas()
        {
            int a = Convert.ToInt32(scbNumeroA.Value);
            int r = Convert.ToInt32(scbNumeroR.Value);
            int g = Convert.ToInt32(scbNumeroG.Value);
            int b = Convert.ToInt32(scbNumeroB.Value);

            SolidColorBrush pincel = new SolidColorBrush();
            pincel.Color = Color.FromArgb(
                (byte)a,
                (byte)r,
                (byte)g,
                (byte)b
                );

            // Actualizamos el canvas
            cvColors.Background = pincel;

            // Actualizamos el color picker
            Color colorParaElColorPicker = Color.FromArgb((byte)a, (byte)r, (byte)g, (byte)b);
            colorPicker.SelectedColor = colorParaElColorPicker;
        }

        // ------------------------------------------------------------------------
        private void ipdA_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {

        }

        private void iudA_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {

        }

        private void iudR_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {

        }

        private void iudG_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {

        }

        private void iudB_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {

        }
    }
}
