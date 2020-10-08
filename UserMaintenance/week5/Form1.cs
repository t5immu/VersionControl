﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using week5.Entities;

namespace week5
{
    public partial class Form1 : Form
    {
        PortfolioEntities context = new PortfolioEntities();
        List<Tick> Ticks;
        List<Portfolioitem> Portfolio = new List<Portfolioitem>();
        public Form1()
        {
            InitializeComponent();
            Ticks = context.Ticks.ToList();
            dataGridView1.DataSource = Ticks;
        }

        private void CreatePortfolio()
        {
            Portfolio.Add(new Portfolioitem() { Index = "OTP", Volume = 10 });
            Portfolio.Add(new Portfolioitem() { Index = "ZWACK", Volume = 10 });
            Portfolio.Add(new Portfolioitem() { Index = "ELMU", Volume = 10 });

            dataGridView2.DataSource = Portfolio;
        }
    }
}
