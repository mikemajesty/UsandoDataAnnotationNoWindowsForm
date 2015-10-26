using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;

namespace DataAnnotationInWidowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var order = new Pedido
            {
                Address = txtAdreess.Text,
                City = txtCity.Text,
                Country = txtCountry.Text,
                Email = txtEmail.Text,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Phone = txtPhone.Text,
                PostalCode = txtPostCode.Text,
                State = txtState.Text,
                Username = txtUserName.Text


            };
            IList<ValidationResult> erros = new List<ValidationResult>();
            if (!Validator.TryValidateObject(order, new ValidationContext(order), erros, true))
            {
                var errosMessage = "";
                erros.ToList().ForEach(c => errosMessage += c.ErrorMessage + "\n");
                MessageBox.Show(errosMessage);
            }
            else
            {
                MessageBox.Show("Validated");
            }
        }
    }
}
