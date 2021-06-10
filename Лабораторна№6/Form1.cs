﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторна_6
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            gvTowns.AutoGenerateColumns = false;
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "Модель";
            gvTowns.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Country";
            column.Name = "Країна виробника";
            gvTowns.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Type";
            column.Name = "Тип";
            gvTowns.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Printing";
            column.Name = "Технологія друку";
            gvTowns.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Warranty";
            column.Name = "Гарантійний термін";
            gvTowns.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Price";
            column.Name = "Ціна";
            column.Width = 65;
            gvTowns.Columns.Add(column);
            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "Wifi";
            column.Name = "Наявність Wifi";
            column.Width = 70;
            gvTowns.Columns.Add(column);
            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "Color";
            column.Name = "Кольоровий друк";
            column.Width = 75;
            gvTowns.Columns.Add(column);
            
            EventArgs args = new EventArgs();
            OnResize(args);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TheTown town = new TheTown();
            fTown ft = new fTown (town);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                bindSrcTowns.Add(town);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            TheTown town = (TheTown)bindSrcTowns.List[bindSrcTowns.Position];
            fTown ft = new fTown (town);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                bindSrcTowns.List[bindSrcTowns.Position] = town;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис?",
"Видалення запису", MessageBoxButtons.OKCancel,
MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindSrcTowns.RemoveCurrent();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
"Очистити таблицю?\n\nВсі дані будуть втрачені",
"Очищення даних", MessageBoxButtons.OKCancel,
MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindSrcTowns.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок?", "Вихід з програми",
MessageBoxButtons.OKCancel,
MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}