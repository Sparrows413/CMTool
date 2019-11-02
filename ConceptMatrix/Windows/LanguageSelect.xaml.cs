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
using System.Windows.Shapes;

namespace ConceptMatrix.Windows
{
    /// <summary>
    /// Interaction logic for LanguageSelect.xaml
    /// </summary>
    public partial class LanguageSelect : Window
    {
        public LanguageSelect()
        {
            InitializeComponent();
        }
        public string LanguageCode { get; set; }

        private void EnglishButton_Click(object sender, RoutedEventArgs e)
        {
            LanguageCode = "en";
            Close();
        }

        private void JapaneseButton_Click(object sender, RoutedEventArgs e)
        {
            LanguageCode = "ja";
            Close();
        }

        private void GermanButton_Click(object sender, RoutedEventArgs e)
        {
            LanguageCode = "de";
            Close();
        }

        private void FrenchButton_Click(object sender, RoutedEventArgs e)
        {
            LanguageCode = "fr";
            Close();
        }

        private void KoreanButton_Click(object sender, RoutedEventArgs e)
        {
            LanguageCode = "ko";
            Close();
        }

        private void ChineseButton_Click(object sender, RoutedEventArgs e)
        {
            LanguageCode = "zh";
            Close();
        }
    }
}
