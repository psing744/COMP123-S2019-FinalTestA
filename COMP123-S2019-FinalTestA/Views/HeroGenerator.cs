using COMP123_S2019_FinalTestA.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
 * STUDENT NAME: PRITPAL SINGH
 * STUDENT ID  : 301045531
 * DESCRIPTION : This is the Hero Generator Form
 */

namespace COMP123_S2019_FinalTestA.Views
{
    public partial class HeroGenerator : COMP123_S2019_FinalTestA.Views.MasterForm
    {
        Random random = new Random();
        public static Power power;
        string[] firstNames;
        string[] lastNames;
        List<string> PowerList = new List<string>();

        public HeroGenerator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler for the backButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex != 0)
            {
                MainTabControl.SelectedIndex--;
            }
        }

        /// <summary>
        /// This is the event handler for the nextButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextButton_Click(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex < MainTabControl.TabPages.Count - 1)
            {
                MainTabControl.SelectedIndex++;
            }
        }

        private void generateNameButton_Click(object sender, EventArgs e)
        {
            GenerateNames();

            //giving names to character object of class hero
            Program.character.FirstName = firstNameDataLabel.Text;
            Program.character.LastName = lastNameDataLabel.Text;
            Program.character.HeroName = heroNameTextBox.Text;
        }

        private void LoadNames()
        {
            //Inputing First Name
            firstNames = File.ReadAllLines("../../Data/firstNames.txt");
            

            //Inputing Last Name
            lastNames = File.ReadAllLines("../../Data/lastNames.txt");
            
        }

        public void GenerateNames()
        {
            int indexFirstName = random.Next(firstNames.Length - 1);
            firstNameDataLabel.Text = firstNames[indexFirstName];

            int indexLastName = random.Next(lastNames.Length - 1);
            lastNameDataLabel.Text = lastNames[indexLastName];
        }

        private void generateAbilitiesButton_Click(object sender, EventArgs e)
        {
            //generating random abilities from 10 to 50
            fighitingDataLabel.Text = random.Next(10, 50).ToString();
            agilityDataLabel.Text = random.Next(10, 50).ToString();
            strengthDataLabel.Text = random.Next(10, 50).ToString();
            enduranceDataLabel.Text = random.Next(10, 50).ToString();
            reasonDataLabel.Text = random.Next(10, 50).ToString();
            intutionDataLabel.Text = random.Next(10, 50).ToString();
            psycheDataLabel.Text = random.Next(10, 50).ToString();
            popularityDataLabel.Text = random.Next(10, 50).ToString();

            //saving abilities in character object of hero class
            Program.character.Fighting = fighitingDataLabel.Text;
            Program.character.Agility = agilityDataLabel.Text;
            Program.character.Strength = strengthDataLabel.Text;
            Program.character.Endurance = enduranceDataLabel.Text;
            Program.character.Reason = reasonDataLabel.Text;
            Program.character.Intution = intutionDataLabel.Text;
            Program.character.Psyche = psycheDataLabel.Text;
            Program.character.Popularity = popularityDataLabel.Text;
        }

        private void HeroGenerator_Load(object sender, EventArgs e)
        {
            LoadNames();
            GenerateNames();
            LoadPowers();
        }

        public void LoadPowers()
        {
            //Inputing First Name
            PowerList = File.ReadAllLines("../../Data/powers.txt").ToList();
        }

        public void GenerateRandomPowers()
        {
            //generating random index for PowersList
            int indexPower1 = random.Next(PowerList.Count - 1);
            int indexPower2 = random.Next(PowerList.Count - 1);
            int indexPower3 = random.Next(PowerList.Count - 1);
            int indexPower4 = random.Next(PowerList.Count - 1);
        
            //generating random power and assigning it to appropriate field
            firstPowerDataLabel.Text = PowerList[indexPower1];
            secondPowerDataLabel.Text = PowerList[indexPower2];
            thirdPowerDataLabel.Text = PowerList[indexPower3];
            fourthPowerDataLabel.Text = PowerList[indexPower4];

            //instantiating power objects
            Power power1 = new Power();
            Power power2 = new Power();
            Power power3 = new Power();
            Power power4 = new Power();

            // giving valuw to power objects
            power1.Name = firstPowerDataLabel.Text;
            power2.Name = secondPowerDataLabel.Text;
            power3.Name = thirdPowerDataLabel.Text;
            power4.Name = fourthPowerDataLabel.Text;

            // copying values to character object of class Hero
            Program.character.Powers.Add(power1);
            Program.character.Powers.Add(power2);
            Program.character.Powers.Add(power3);
            Program.character.Powers.Add(power4);
        }

        private void generatePowersButton_Click(object sender, EventArgs e)
        {
            GenerateRandomPowers();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            // configuration for saveFileDialog
            characterSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            characterSaveFileDialog.FileName = "Hero.txt";
            characterSaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";


            var result = characterSaveFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                // open a stream to write
                using (StreamWriter outputStream = new StreamWriter(
                    File.Open(characterSaveFileDialog.FileName, FileMode.Create)))
                {
                    // write stuff to the file
                    outputStream.WriteLine(heroNameChDataLabel.Text);
                    outputStream.WriteLine(NameChDataLabel.Text);
                    outputStream.WriteLine(fightingChDataLabel.Text);
                    outputStream.WriteLine(agilityChDataLabel.Text);
                    outputStream.WriteLine(strengthChDataLabel.Text);
                    outputStream.WriteLine(enduranceChDataLabel.Text);
                    outputStream.WriteLine(reasonChDataLabel.Text);
                    outputStream.WriteLine(intutionChDataLabel.Text);
                    outputStream.WriteLine(psycheChDataLabel.Text);
                    outputStream.WriteLine(popularityChDataLabel.Text);
                    //outputStream.WriteLine(Program.character.Powers[1]);
                    //outputStream.WriteLine(Program.character.Powers[2]);
                    //outputStream.WriteLine(Program.character.Powers[3]);

                    // cleanup
                    outputStream.Close();
                    outputStream.Dispose();
                }

                MessageBox.Show("File Saved Successfully!", "Saving...",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            // configuration for openFileDialog
            CharacterOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            CharacterOpenFileDialog.FileName = "Hero.txt";
            CharacterOpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            var result = CharacterOpenFileDialog.ShowDialog();

            if (result != DialogResult.Cancel)
            {
                // open file stream to read
                using (StreamReader inputStream = new StreamReader(
                    File.Open(CharacterOpenFileDialog.FileName, FileMode.Open)))
                {
                    // read stuff from the file into the Student object
                    heroNameChDataLabel.Text = inputStream.ReadLine();
                    NameChDataLabel.Text = inputStream.ReadLine();
                    fightingChDataLabel.Text = inputStream.ReadLine();
                    agilityChDataLabel.Text = inputStream.ReadLine();
                    strengthChDataLabel.Text = inputStream.ReadLine();
                    enduranceChDataLabel.Text = inputStream.ReadLine();
                    reasonChDataLabel.Text = inputStream.ReadLine();
                    intutionChDataLabel.Text = inputStream.ReadLine();
                    psycheChDataLabel.Text = inputStream.ReadLine();
                    popularityChDataLabel.Text = inputStream.ReadLine();


                    //cleanup
                    inputStream.Close();
                    inputStream.Dispose();
                }

                MainTabControl_SelectedIndexChanged(sender, e)
            }
        }

        private void MainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex == 3)
            {
                heroNameChDataLabel.Text = Program.character.HeroName;
                NameChDataLabel.Text = Program.character.FirstName + " " + Program.character.LastName;
                fightingChDataLabel.Text = Program.character.Fighting;
                agilityChDataLabel.Text = Program.character.Agility;
                strengthChDataLabel.Text = Program.character.Strength;
                enduranceChDataLabel.Text = Program.character.Endurance;
                reasonChDataLabel.Text = Program.character.Reason;
                intutionChDataLabel.Text = Program.character.Intution;
                psycheChDataLabel.Text = Program.character.Psyche;
                popularityChDataLabel.Text = Program.character.Popularity;
                //firstPowerChDataLabel.Text = (Program.character.Powers[0]).ToString();
                //firstPowerChDataLabel.Text = (Program.character.Powers[1]).ToString();
                //firstPowerChDataLabel.Text = (Program.character.Powers[2]).ToString();
                //firstPowerChDataLabel.Text = (Program.character.Powers[3]).ToString();
            }
        }
    }
}
