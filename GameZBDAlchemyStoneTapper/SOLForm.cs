﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yolov7net;

namespace GameZBDAlchemyStoneTapper
{
    public partial class SOLForm : Form
    {
        private Rectangle snipLocation;
        private List<string> selectedAlchemyStone = new List<string>();
        private List<string> selectedMaterial = new List<string>();
        private Bitmap toDisplay;
        private bool isRunning = false;
        private ObjectDetection OBJ;
        private Thread thread;

        public SOLForm()
        {
            InitializeComponent();
        }

        #region select area

        private void Imperfect_Click(object sender, EventArgs e)
        {
            updateAlchemyStoneList(sender);
        }

        private void Rough_Click(object sender, EventArgs e)
        {
            updateAlchemyStoneList(sender);
        }

        private void Polished_Click(object sender, EventArgs e)
        {
            updateAlchemyStoneList(sender);
        }

        private void Sturdy_Click(object sender, EventArgs e)
        {
            updateAlchemyStoneList(sender);
        }

        private void Sharp_Click(object sender, EventArgs e)
        {
            updateAlchemyStoneList(sender);
        }

        private void Resplendent_Click(object sender, EventArgs e)
        {
            updateAlchemyStoneList(sender);
        }

        private void Splendid_Click(object sender, EventArgs e)
        {
            updateAlchemyStoneList(sender);
        }

        private void updateAlchemyStoneList(object sender)
        {
            if (selectedAlchemyStone.Contains(((PictureBox)sender).Name))
            {
                selectedAlchemyStone.Remove((((PictureBox)sender).Name));
                ((PictureBox)sender).BorderStyle = BorderStyle.None;
            }
            else
            {
                selectedAlchemyStone.Add((((PictureBox)sender).Name));
                ((PictureBox)sender).BorderStyle = BorderStyle.Fixed3D;
            }
        }

        private void Strawberry_Click(object sender, EventArgs e)
        {
            updateMaterialList(sender);
        }

        private void Purple_Click(object sender, EventArgs e)
        {
            updateMaterialList(sender);
        }

        private void Grape_Click(object sender, EventArgs e)
        {
            updateMaterialList(sender);
        }

        private void Arrow_Click(object sender, EventArgs e)
        {
            updateMaterialList(sender);
        }

        private void Cloud_Click(object sender, EventArgs e)
        {
            updateMaterialList(sender);
        }

        private void Ghost_Click(object sender, EventArgs e)
        {
            updateMaterialList(sender);
        }

        private void Sunflower_Click(object sender, EventArgs e)
        {
            updateMaterialList(sender);
        }

        private void updateMaterialList(object sender)
        {
            if (selectedMaterial.Contains(((PictureBox)sender).Name))
            {
                selectedMaterial.Remove((((PictureBox)sender).Name));
                ((PictureBox)sender).BorderStyle = BorderStyle.None;
            }
            else
            {
                selectedMaterial.Add((((PictureBox)sender).Name));
                ((PictureBox)sender).BorderStyle = BorderStyle.Fixed3D;
            }
        }

        #endregion select area

        private void startBtn_Click(object sender, EventArgs e)
        {
        }
    }
}