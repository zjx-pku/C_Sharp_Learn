using System.Windows;
using System.IO;
using System.Xml.Serialization;

namespace Karlicards.GUI
{
    /// <summary>
    /// OptionsWindow.xaml 的交互逻辑
    /// </summary>
    public partial class OptionsWindow : Window
    {
        private GameOptions gameOptions;
        public OptionsWindow()
        {
            if (gameOptions == null)
            {
                if (File.Exists("GameOptions.xml"))
                {
                    using (var stream = File.OpenRead("GameOptions.xml"))
                    {
                        var setializer = new XmlSerializer(typeof(GameOptions));
                        gameOptions = setializer.Deserialize(stream) as GameOptions;
                    }
                }
                else
                    gameOptions = new GameOptions();
            }
            InitializeComponent();
        }

        private void DumpAIRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            gameOptions.ComputerSkill = ComputerSkillLevel.Dumb;
        }

        private void GoodAIRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            gameOptions.ComputerSkill = ComputerSkillLevel.Good;
        }

        private void CheatingAIRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            gameOptions.ComputerSkill = ComputerSkillLevel.Cheats;
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            using (var stream = File.Open("GameOPtions.xml", FileMode.Create))
            {
                var serializer = new XmlSerializer(typeof(GameOptions));
                serializer.Serialize(stream, gameOptions);
            }
            Close();
        }

        private void CancleButton_Click(object sender, RoutedEventArgs e)
        {
            gameOptions = null;
            Close();
        }

        private void PlayAgainstComputerCheck_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
