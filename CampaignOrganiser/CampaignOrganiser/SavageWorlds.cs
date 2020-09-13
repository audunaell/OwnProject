using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace CampaignOrganiser
{
    public class SavageWorlds : RulesSuper
    {
        private MainWindow SavageWindow = Application.Current.Windows.Cast<Window>().FirstOrDefault(window => window is MainWindow) as MainWindow;
        public void RunRuleset()
        {
            LoadNpcAndMonsters();
            SavageWindow.SettingsForRules.Items.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load("XMLSavage.xml");
            XmlNodeList docList = doc.SelectNodes("/DataOverview/ruleset/campaing");
            foreach (XmlNode node in docList)
            {
                string nameOfItem = node["name"].InnerText;
                SavageWindow.SettingsForRules.Items.Add(nameOfItem);
            }
        }

        public void LoadNpcAndMonsters()
        {
            Frame tabframe = new Frame();
            Page page1 = new PageSavageWorlds();
            tabframe.Content = page1;
            SavageWindow.NpcAndMonstersGUI.Content = tabframe;
        }
    }
}
