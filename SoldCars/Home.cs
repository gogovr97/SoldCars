using SoldCars.Database;
using SoldCars.Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoldCars
{
    public partial class Home : Form
    {
        private readonly SoldCarsDbContext dbContext;
        private readonly int userId;
        private int noteId;
        public Home(SoldCarsDbContext dbContext, int userId)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            this.userId = userId;
            DisplayView();
            PopulateView();
            noteId = 0;
        }

        private void DisplayView()
        {
            this.TaskGridView.ColumnCount = 6;
            this.TaskGridView.Columns[0].Name = "Id";
            this.TaskGridView.Columns[1].Name = "Car";
            this.TaskGridView.Columns[2].Name = "Sold";
            this.TaskGridView.Columns[3].Name = "Date";
            this.TaskGridView.Columns[4].Name = "Creator";
            this.TaskGridView.Columns[5].Name = "Prise";
        }
        private void PopulateView()
        {
            this.TaskGridView.Rows.Clear();
            var notes = this.dbContext.Notes.Include(t => t.User).Select(t => new Database.Models.Note
            {
                Id = t.Id,
                Car = t.Car,
                Sold = t.Sold,
                Prise = t.Prise,
                CreatedAt = t.CreatedAt,
                User = new User
                {
                    Username = t.User.Username
                }
            }).ToList();
            foreach (var note in notes)
            {
                string[] currentRow = { note.Id.ToString(), note.Car, note.Sold.ToString(), note.CreatedAt.Date.ToString(), note.User.Username, note.Prise };
                this.TaskGridView.Rows.Add(currentRow);
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            var note = new Database.Models.Note();
            note.Car = this.TitleTextBox.Text;
            note.Description = this.DescriptionTextBox.Text;
            note.Prise = this.PriseTextBox.Text;
            note.UserId = this.userId;
            if (this.TrueCheckBox.Checked)
            {
                note.Sold = true;
            }
            else
            {
                note.Sold = false;
            }
            this.dbContext.Notes.Add(note);
            this.dbContext.SaveChanges();

            PopulateView();
            this.Clear();
        }

        private void Clear()
        {
            this.TitleTextBox.Text = "";
            this.DescriptionTextBox.Text = "";
            this.PriseTextBox.Text = "";
            this.TrueCheckBox.Checked = false;
            this.FalseCheckBox.Checked = false;
            this.noteId = 0;
        }

        private void TrueCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.TrueCheckBox.Checked)
            {
                this.TrueCheckBox.Checked = true;
                if (this.FalseCheckBox.Checked)
                {
                    this.FalseCheckBox.Checked = false;
                }
            }
        }

        private void FalseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.FalseCheckBox.Checked)
            {
                this.FalseCheckBox.Checked = true;
                if (this.TrueCheckBox.Checked)
                {
                    this.TrueCheckBox.Checked = false;
                }
            }
        }

        private void TaskGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.Clear();
            int rowIndex = e.RowIndex;
            int id = int.Parse(this.TaskGridView.Rows[rowIndex].Cells[0].Value.ToString());
            var note = this.dbContext.Notes.Find(id);

            this.noteId = note.Id;
            this.TitleTextBox.Text = note.Car;
            this.DescriptionTextBox.Text = note.Description;
            if (note.Sold == true)
            {
                this.TrueCheckBox.Checked = true;
            }
            else
            {
                this.FalseCheckBox.Checked = true;
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (this.noteId != 0)
            {
                var note = this.dbContext.Notes.Find(this.noteId);
                note.Car = this.TitleTextBox.Text;
                note.Description = this.DescriptionTextBox.Text;
                note.Prise = this.PriseTextBox.Text;
                if (this.TrueCheckBox.Checked)
                {
                    note.Sold = true;
                }
                else
                {
                    note.Sold = false;
                }
                this.dbContext.Notes.Update(note);
                this.dbContext.SaveChanges();
                this.Clear();
                this.PopulateView();
            }
            else
            {
                MessageBox.Show("Please select car archive to Update.");
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login(this.dbContext);
            loginForm.Show();
            this.Hide();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.Clear();
            if (this.noteId != 0)
            {
                var note = this.dbContext.Notes.Find(this.noteId);
                note.Car = this.TitleTextBox.Text;
                note.Description = this.DescriptionTextBox.Text;
                note.Prise = this.PriseTextBox.Text;
                if (this.TrueCheckBox.Checked)
                {
                    note.Sold = true;
                }
                else
                {
                    note.Sold = false;
                }
                this.dbContext.Notes.Update(note);
                this.dbContext.SaveChanges();
                this.Clear();
                this.PopulateView();
            }
            else
            {
                MessageBox.Show("Please select car archive to Clear.");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (this.noteId != 0)
            {
                var note = this.dbContext.Notes.Find(noteId);
                this.dbContext.Remove(note);
                this.dbContext.SaveChanges();

                this.Clear();
                this.PopulateView();
            }
            else
            {
                MessageBox.Show("Please select car archive to delete.");
            }
        }
    }
}
