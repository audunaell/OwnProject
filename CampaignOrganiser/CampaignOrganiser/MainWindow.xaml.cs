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

namespace CampaignOrganiser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string[] TestList = new string[3];
            TestList[0] = "Savage Worlds";
            TestList[1] = "Dungeons and Dragons";
            TestList[2] = "The dark eye";

            foreach (var name in TestList)
            {
                SystemListView.Items.Add((string) name);
            }
        }

        private void SystemListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            string[] test3 = { "Forgotten Realms", "Ebberon", "Dark sun" };
            string[] test4 = { "Sandefjord", "Larvik" };
            if (SystemListView.SelectedItem.ToString() == "Savage Worlds")
            {
                SavageWorlds StartSwRunRules = new SavageWorlds();
                StartSwRunRules.RunRuleset();
            }
            if (SystemListView.SelectedItem.ToString() == "Dungeons and Dragons")
            {
                NpcAndMonstersGUI.Content = "";
                SettingsForRules.Items.Clear();
                foreach (var s in test3)
                {
                    SettingsForRules.Items.Add((string)s);
                }
            }
            if (SystemListView.SelectedItem.ToString() == "The dark eye")
            {
                NpcAndMonstersGUI.Content = "";
                SettingsForRules.Items.Clear();
                foreach (var s in test4)
                {
                    SettingsForRules.Items.Add((string)s);
                }
            }
        }
    }
}
