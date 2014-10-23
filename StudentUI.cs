using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBoxApp
{
    public partial class StudentUI : Form
    {
        public StudentUI()
        {
            InitializeComponent();
            studentComboBox.DisplayMember = "RegNo";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student(regNoTextBox.Text, nameTextBox.Text, addressTextBox.Text);
            studentComboBox.Items.Add(aStudent);
            MessageBox.Show("Student has been added");
        }

        private void studentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student selecteStudent = (Student) studentComboBox.SelectedItem;
            displayNameTextBox.Text = selecteStudent.Name;
            displayAddressTextBox.Text = selecteStudent.Address;
        }
    }
}
