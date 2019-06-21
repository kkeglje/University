﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsWorldCup
{
    public partial class ChooseLanguage : Form
    {
        private Form1 f;
        private bool first = true;
        public ChooseLanguage(Form1 f)
        {
            InitializeComponent();
            this.f = f;
        }

        
        public async void btn_english_Click(object sender, EventArgs e)
        {
            f.changeLanguageToENG();
            Hide();

            if (first)
            {
                f.img_loading.Visible = true;
                await Task.Run(() => f.SetTeams());
                f.showTeamChooser();
                first = false;
            }
        }

        public async void btn_croatian_Click_1(object sender, EventArgs e)
        {
            f.changeLanguageToCRO();
            Hide();

            if (first)
            {
                f.img_loading.Visible = true;
                await Task.Run(() => f.SetTeams());
                f.showTeamChooser();
                first = false;
            }
        }

    }
}
