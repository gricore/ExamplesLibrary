using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomControlLibrary
{
    /// <summary>
    /// Interaction logic for CustomListBox.xaml
    /// </summary>
    public partial class CustomListBox : UserControl
    {       
        public CustomListBox()
        {
            InitializeComponent();
        }

        // DependencyProperty 'ItemsSource'
        public static readonly DependencyProperty ItemsSourceProperty = DependencyProperty.Register("ItemsSource", typeof(IEnumerable<string>),
            typeof(CustomListBox), new PropertyMetadata(default(IEnumerable<string>)));
        // Property 'ItemsSource'
        public IEnumerable<string> ItemsSource
        {
            get { return (IEnumerable<string>) GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }

        // DependencyProperty 'SelectedIndex'
        public static readonly DependencyProperty SelectedIndexProperty =
            DependencyProperty.Register("SelectedIndex", typeof(int), typeof(CustomListBox), new PropertyMetadata(default(int)));
        // Property 'SelectedIndex'
        public int SelectedIndex
        {
            get { return (int) GetValue(SelectedIndexProperty); }
            set { SetValue(SelectedIndexProperty, value); }
        }
    }
}
