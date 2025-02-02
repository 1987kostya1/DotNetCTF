﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Be.Windows.Forms;
using CTFAK.Utils;

namespace CTFAK.GUI
{
    public partial class HexViewForm : Form
    {
        public byte[] parsedData;
        public byte[] rawData;
        
        public HexViewForm(byte[] parsedData, byte[] rawData,Color color)
        {
            InitializeComponent();
            foreach (Control item in Controls)
            {
                item.ForeColor = color;
            }
            hexBox1.InfoForeColor = Color.FromArgb(color.R/2, color.G/2, color.B/2);
            hexBox1.SelectionForeColor=Color.FromArgb(color.R, color.G, color.B);
            hexBox1.SelectionBackColor=Color.FromArgb(color.R/4, color.G/4, color.B/4);
            hexBox1.ShadowSelectionColor=Color.FromArgb(150,color.R/4, color.G/4, color.B/4);
            this.parsedData = parsedData;
            this.rawData = rawData;
           
            UpdateInfo(false);
        }

        public HexViewForm(byte[] parsedData, byte[] rawData, Color color, string name)
        {
            InitializeComponent();           
            sizeLabel.ForeColor = color;
            rawBox.ForeColor = color;
            hexBox1.ForeColor = color;
            hexBox1.InfoForeColor = Color.FromArgb(color.R/2, color.G/2, color.B/2);
            hexBox1.SelectionForeColor=Color.FromArgb(color.R, color.G, color.B);
            hexBox1.SelectionBackColor=Color.FromArgb(color.R/4, color.G/4, color.B/4);
            hexBox1.ShadowSelectionColor=Color.FromArgb(150,color.R/4, color.G/4, color.B/4);
            this.parsedData = parsedData;
            this.rawData = rawData;
            this.Text = name;
           
            UpdateInfo(false);
            
            
        }

        private void HexViewForm_Load(object sender, EventArgs e)
        {
            
        }

        

        

        public void UpdateInfo(bool raw)
        {
            var bytes = raw ? rawData : parsedData;
            hexBox1.ByteProvider = new DynamicByteProvider(bytes);
            sizeLabel.Text = "Size: "+bytes.Length.ToPrettySize();

        }

        private void rawBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateInfo(rawBox.Checked);
        }

        private void hexBox1_Click(object sender, EventArgs e)
        {
            
        }
    }

    
}