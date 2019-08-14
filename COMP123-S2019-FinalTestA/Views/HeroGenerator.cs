﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        string[] firstNames;
        string[] lastNames;

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
            
            fighitingDataLabel.Text = random.Next(10, 50).ToString();
            agilityDataLabel.Text = random.Next(10, 50).ToString();
            strengthDataLabel.Text = random.Next(10, 50).ToString();
            enduranceDataLabel.Text = random.Next(10, 50).ToString();
            reasonDataLabel.Text = random.Next(10, 50).ToString();
            intutionDataLabel.Text = random.Next(10, 50).ToString();
            psycheDataLabel.Text = random.Next(10, 50).ToString();
            popularityDataLabel.Text = random.Next(10, 50).ToString();
        }

        private void HeroGenerator_Load(object sender, EventArgs e)
        {
            LoadNames();
            GenerateNames();
        }
    }
}
