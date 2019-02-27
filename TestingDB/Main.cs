using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingDB
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string nrc = txtNrc.Text;
            string city = txtCity.Text;

            string sql = "insert  into Registration (Name,Nrc,City) values ('"+name+"','"+nrc+"','"+city+"')";
            Database.ExecuteNonQuery(sql);
            btnShow.PerformClick();          
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string sql = "select * from Registration";
            dgResult.DataSource = Database.Retrieve(sql);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int i = dgResultUp.CurrentCell.RowIndex;
            DataGridViewRow dr = dgResultUp.CurrentRow;
            int id = (int)dr.Cells[0].Value;
            string nameUp = txtNameUp.Text;
            string nrcUp = txtNrcUp.Text;
            string cityUp = txtCityUp.Text;
            
            string sql="update Registration set Name='"+nameUp+"' , Nrc='"+nrcUp+"' , City='"+cityUp+"' where ID="+id;
            Database.ExecuteNonQuery(sql);
            btnShowUp.PerformClick();
            dgResultUp.Rows[i].Selected = true;

        }

        private void dgResultUp_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow dr = dgResultUp.CurrentRow;
            txtNameUp.Text = dr.Cells[1].Value.ToString();
            txtNrcUp.Text = dr.Cells[2].Value.ToString();
            txtCityUp.Text = dr.Cells[3].Value.ToString();

        }

        private void btnShowUp_Click(object sender, EventArgs e)
        {
            string sql = "select * from Registration";
            dgResultUp.DataSource = Database.Retrieve(sql);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgResultDel.CurrentRow;
            int id = (int)dr.Cells[0].Value;

            string sql = "delete from Registration where ID=" + id;
            Database.ExecuteNonQuery(sql);
            btnShowDel.PerformClick();
        }

        private void btnShowDel_Click(object sender, EventArgs e)
        {
            string sql = "select * from Registration";
            dgResultDel.DataSource = Database.Retrieve(sql);
        }

        private void dgResultDel_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow dr = dgResultDel.CurrentRow;
            txtNameDel.Text = dr.Cells[1].Value.ToString();
            txtNrcDel.Text = dr.Cells[2].Value.ToString();
            txtCityDel.Text = dr.Cells[3].Value.ToString();
        }

    }
}
