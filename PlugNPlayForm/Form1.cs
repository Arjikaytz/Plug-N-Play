using PlugAndPlay.Common;
using PlugAndPlay.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using System.Xml.Linq;

namespace PlugNPlayForm
{
    public partial class Form1 : Form
    {
        private readonly IGearRepository repo = new DBGearRepository();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void RefreshList(IEnumerable<GearItem>? items = null)
        {
            listBox1.Items.Clear();
            var all = items?.ToList() ?? repo.GetGuitars().Concat(repo.GetPedals()).Concat(repo.GetAmplifiers()).ToList();
            foreach (var item in all)
                listBox1.Items.Add(item);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string term = tbSearch.Text.Trim();
            if (string.IsNullOrEmpty(term))
            {
                RefreshList();
                return;
            }

            var found = repo.SearchByName(term);
            if (found != null)
                RefreshList(new[] { found });
            else
                MessageBox.Show("Gear not found.");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = tbName.Text.Trim();
            string type = GetSelectedType();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(type))
            {
                MessageBox.Show("Please enter both name and type.");
                return;
            }

            repo.Add(new GearItem(0, name, type));
            RefreshList();
            MessageBox.Show("Gear added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is not GearItem selected)
            {
                MessageBox.Show("Select an item to edit.");
                return;
            }

            string name = tbName.Text.Trim();
            string type = GetSelectedType();
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(type))
            {
                MessageBox.Show("Name and type must be provided.");
                return;
            }

            repo.Update(new GearItem(selected.Id, name, type));
            RefreshList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is not GearItem selected)
            {
                MessageBox.Show("Select an item to delete.");
                return;
            }

            repo.Delete(selected.Id);
            RefreshList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is GearItem selected)
            {
                tbName.Text = selected.Name;
                SetSelectedType(selected.Type);
            }
        }

        private string GetSelectedType()
        {
            if (rbGuitar.Checked) return "Guitar";
            if (rbPedal.Checked) return "Pedal";
            if (rbAmplifier.Checked) return "Amplifier";
            return string.Empty;
        }

        private void SetSelectedType(string type)
        {
            rbGuitar.Checked = type == "Guitar";
            rbPedal.Checked = type == "Pedal";
            rbAmplifier.Checked = type == "Amplifier";
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            // Optional: implement live-filter
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // If `textBox1` is unused, consider removing it.
        }

        private void rbGuitar_CheckedChanged(object sender, EventArgs e) { }
        private void rbPedal_CheckedChanged(object sender, EventArgs e) { }
        private void rbAmplifier_CheckedChanged(object sender, EventArgs e) { }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}

