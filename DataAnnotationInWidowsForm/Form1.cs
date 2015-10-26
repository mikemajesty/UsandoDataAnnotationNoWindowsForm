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
                Enrereço = txtEndereço.Text,
                Cidade = txtCidade.Text,
                País = txtPaís.Text,
                Email = txtEmail.Text,
                Nome = txtNome.Text,
                Sobrenome = txtSobrenome.Text,
                Telefone = txtTelefone.Text,
                CodigoPostal = txtCódigoPostal.Text,
                Estado = txtEstado.Text,
                Username = txtUserName.Text


            };
            IList<ValidationResult> erros = new List<ValidationResult>();
            
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    (item as TextBox).BackColor = System.Drawing.Color.White;
                }
            }
            if (!Validator.TryValidateObject(order, new ValidationContext(order), erros, true))
            {

                var errosMessage = "";
                int cont = 0;
                var txtList = new List<Control>();
                foreach (var c in erros)
                {
                    cont++;
                    errosMessage += c.ErrorMessage + "\n";
                    var txt = Controls.Find("txt"+c.MemberNames.FirstOrDefault(), true).FirstOrDefault();
                    txtList.Add(txt); 
                }
                cont = 0;
                foreach (var txt in txtList.Where(c=>c.GetType() == typeof(TextBox)))
                {
                    cont++;
                    if (cont == 1 && txt is TextBox)
                    {
                        FocarNoTxt(txt as TextBox);
                    }
                }
                txtList.ForEach(d => d.BackColor = System.Drawing.Color.Yellow);
                MessageBox.Show(errosMessage);
            }
            else
            {
                MessageBox.Show("Validated");
            }
        }
        public void FocarNoTxt(TextBox txt)
        {
            this.ActiveControl = txt;
        }
    }
}
