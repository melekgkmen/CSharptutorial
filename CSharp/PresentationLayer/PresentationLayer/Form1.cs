using EntityLayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            List<EntityEmployee> empList = LogicEmployee.LLListOfStaff();
            dataGridView1.DataSource=empList;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            EntityEmployee emp = new EntityEmployee();
            emp.Name = TxtName.Text;
            emp.Surname = TxtSurname.Text;
            emp.City = TxtCity.Text;
            emp.Duty = TxtDuty.Text;

            LogicEmployee.LLAddStaff(emp);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            EntityEmployee emp = new EntityEmployee();
            emp.Id = Convert.ToInt32(TxtId.Text);
            LogicEmployee.LLDeleteStaff(emp.Id);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            EntityEmployee emp = new EntityEmployee();
            emp.Id = Convert.ToInt32(TxtId.Text);
            emp.Name =TxtName.Text;
            emp.Surname = TxtSurname.Text;
            emp.City = TxtCity.Text;
            emp.Duty = TxtDuty.Text;
            LogicEmployee.LLUpdateStaff(emp);

        }
    }
}
