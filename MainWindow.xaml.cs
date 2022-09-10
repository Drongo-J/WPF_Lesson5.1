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

namespace Wpf_Lesson5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Book> Books { get; set; } = new List<Book>()
        {
            new Book()
            {
                ID = 1,
                Author ="Fyodor Dostoevski",
                Genre = "Crime",
                Pages = 800,
                Publisher = "Teas Press",
                Title = "Crime And Punishment",
                ImagePath = "Images/CrimeAndPunishment.jpg"
            },
            new Book()
            {
                ID = 2,
                Author ="Napaleon Hill",
                Genre = "Self Improvement",
                Pages = 600,
                Publisher = "Teas Press",
                Title = "Think And Grow Rich",
                ImagePath = "Images/ThinkGrowRich.jpg"
            },
            new Book()
            {
                ID = 3, 
                Author ="Robert Kiyosoki",
                Genre = "Self Improvement",
                Pages = 300,
                Publisher = "Teas Press",
                Title = "Rich Dad, Poor Dad",
                ImagePath = "Images/RichDadPoorDad.jpg"
            }
        };

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this;
        }
    }
}
