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
using System.Collections.Generic;
using MoveMove.Rules;

namespace MoveMove.Pages
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Label l = (Label)this.FindName("resultLbl");
            string director = ((ComboBox)this.FindName("directorCbox")).Text;
            if(director == "")
            {
                return;
            }
            string season = ((ComboBox)this.FindName("seasonCbox")).Text;
            if(season == "")
            {
                return;
            }
            string production = ((ComboBox)this.FindName("productionCompanyCbox")).Text;
            if(production == "")
            {
                return;
            }
            string genre = ((ComboBox)this.FindName("genreCbox")).Text;
            if(genre == "")
            {
                return;

            }
            string grade = ((ComboBox)this.FindName("gradeCbox")).Text;
            if(grade == "")
            {
                return;

            }
            string distributor = ((ComboBox)this.FindName("distributorCbox")).Text;
            if(distributor == "")
            {
                return;

            }
            RadioButton dicision = (RadioButton)this.FindName("dicisionTreeRbtn");
            if(dicision.IsChecked == true)
            {
                l.Content = "Number of spectator : " + DecistionTree.get(director, season, production, genre, grade, distributor);

                Label a = (Label)this.FindName("accuracy");
                a.Content = "Accuracy : 91.7073"; 
            }
            RadioButton covering = (RadioButton)this.FindName("coveringAlgoRbtn");
            if(covering.IsChecked == true)
            {
                l.Content = "Number of spectator : " + Covering.get(director, season, production, genre, grade, distributor);
                
                Label a = (Label)this.FindName("accuracy");
                a.Content = "Accuracy : 82.7988";
            }
        }
    }
}
