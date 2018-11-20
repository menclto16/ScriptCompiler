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
using System.IO;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using Microsoft.Win32;

namespace ScriptCompiler
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ScriptApp ScriptApp = new ScriptApp();
        Game GameClass = new Game();
        private List<string> filenames = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
            GameClass.PlayerCharacter = new Mage();
            refreshTextBlocks();
        }

        private void btnRunScripts_Click(object sender, RoutedEventArgs e)
        {
            lbScriptsReturnValues.Items.Clear();

            List<string> returnValues = ScriptApp.RunAll(GameClass.PlayerCharacter);

            foreach (var returnValue in returnValues)
            {
                lbScriptsReturnValues.Items.Add(System.IO.Path.GetFileName(returnValue));
                refreshTextBlocks();
            }
        }

        private void refreshTextBlocks()
        {
            characterType.Text = GameClass.PlayerCharacter.GetType().Name.ToString();
            healthValue.Text = "Health: " + GameClass.PlayerCharacter.Health.ToString();
            strengthValue.Text = "Strength: " + GameClass.PlayerCharacter.Strength.ToString();
            intelligenceValue.Text = "Intelligence: " + GameClass.PlayerCharacter.Intelligence.ToString();
            spiritValue.Text = "Spirit: " + GameClass.PlayerCharacter.Spirit.ToString();

            if (GameClass.PlayerCharacter.EquippedWeapon != null)
            {
                weaponName.Text = GameClass.PlayerCharacter.EquippedWeapon.GetName();
                weaponType.Text = "Type: " + GameClass.PlayerCharacter.EquippedWeapon.GetType().Name.ToString();
                weaponWeightValue.Text = "Weight: " + GameClass.PlayerCharacter.EquippedWeapon.Weight.ToString();
                weaponValue.Text = "Value: " + GameClass.PlayerCharacter.EquippedWeapon.Value.ToString();
            }
        }

        private void btnOpenScripts_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == true)
            {
                filenames.Clear();
                lbScripts.Items.Clear();
                ScriptApp.ScriptFiles.Clear();

                foreach (string filename in openFileDialog.FileNames)
                {
                    filenames.Add(System.IO.Path.GetFileName(filename));
                }
                ScriptApp.AddScriptFiles(filenames);
                
                foreach (var scriptFileFromApp in ScriptApp.ScriptFiles)
                {
                    lbScripts.Items.Add(scriptFileFromApp.FileName);
                }
            }
        }
    }
}
