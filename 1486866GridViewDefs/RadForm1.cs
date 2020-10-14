using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace _1486866GridViewDefs
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        private IGridViewDefinition _originalView;

        public RadForm1()
        {
            InitializeComponent();
        }


        private void RadForm1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nwindDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.nwindDataSet.Customers);

            this.radGridView1.DataSource = this.customersBindingSource;
            this.radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

            foreach (GridViewColumn col in this.radGridView1.Columns)
            {
                col.WrapText = true;
            }
             
            //ColumnGroupsViewDefinition view = new ColumnGroupsViewDefinition();
            //view.ColumnGroups.Add(new GridViewColumnGroup("Customer Contact"));
            //view.ColumnGroups.Add(new GridViewColumnGroup("Details"));
            //view.ColumnGroups[1].Groups.Add(new GridViewColumnGroup("Address"));
            //view.ColumnGroups[1].Groups.Add(new GridViewColumnGroup("Contact"));

            //view.ColumnGroups[0].Rows.Add(new GridViewColumnGroupRow());
            //view.ColumnGroups[0].Rows[0].ColumnNames.Add("CompanyName");
            //view.ColumnGroups[0].Rows[0].ColumnNames.Add("ContactName");
            //view.ColumnGroups[0].Rows[0].ColumnNames.Add("ContactTitle");
            //view.ColumnGroups[1].Groups[0].Rows.Add(new GridViewColumnGroupRow());
            //view.ColumnGroups[1].Groups[0].Rows[0].ColumnNames.Add("Address");
            //view.ColumnGroups[1].Groups[0].Rows[0].ColumnNames.Add("City");
            //view.ColumnGroups[1].Groups[0].Rows[0].ColumnNames.Add("Country");
            //view.ColumnGroups[1].Groups[1].Rows.Add(new GridViewColumnGroupRow());
            //view.ColumnGroups[1].Groups[1].Rows[0].ColumnNames.Add("Phone");
            //view.ColumnGroups[1].Groups[1].Rows[0].ColumnNames.Add("Fax");
            //radGridView1.ViewDefinition = view;

            //this.radGridView1.Columns["CustomerID"].HeaderText = "";
            //this.radGridView1.Columns["CustomerID"].HeaderImage = Properties.Resources.Alarm2;

            this.radGridView1.AutoSizeRows = true;
            _originalView = this.radGridView1.ViewDefinition;
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            HtmlViewDefinition view = new HtmlViewDefinition();
            view.RowTemplate.Rows.Add(new RowDefinition());
            view.RowTemplate.Rows.Add(new RowDefinition());
            view.RowTemplate.Rows[0].Cells.Add(new CellDefinition("CustomerID"));
            view.RowTemplate.Rows[0].Cells.Add(new CellDefinition("CompanyName"));
            view.RowTemplate.Rows[0].Cells.Add(new CellDefinition("City"));
            view.RowTemplate.Rows[0].Cells.Add(new CellDefinition("Country"));
            view.RowTemplate.Rows[1].Cells.Add(new CellDefinition("Phone"));
            view.RowTemplate.Rows[1].Cells[0].ColSpan = 2;
            view.RowTemplate.Rows[0].Cells[2].RowSpan = 2;
            view.RowTemplate.Rows[0].Cells[3].RowSpan = 2;
            view.RowTemplate.Rows[0].Height = 40;
            radGridView1.ViewDefinition = view;
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            HtmlViewDefinition view = new HtmlViewDefinition();
            view.RowTemplate.Rows.Add(new RowDefinition());
            view.RowTemplate.Rows.Add(new RowDefinition());            
            view.RowTemplate.Rows[0].Cells.Add(new CellDefinition("City"));
            view.RowTemplate.Rows[0].Cells.Add(new CellDefinition("Country"));    
            view.RowTemplate.Rows[0].Cells.Add(new CellDefinition("CompanyName"));
            view.RowTemplate.Rows[0].Cells.Add(new CellDefinition("CustomerID"));


            view.RowTemplate.Rows[1].Cells.Add(new CellDefinition("Phone"));
            view.RowTemplate.Rows[1].Cells[0].ColSpan = 2;
            view.RowTemplate.Rows[0].Cells[2].RowSpan = 2;
            view.RowTemplate.Rows[0].Cells[3].RowSpan = 2;
            view.RowTemplate.Rows[0].Height = 40;
            radGridView1.ViewDefinition = view;
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            ColumnGroupsViewDefinition view = new ColumnGroupsViewDefinition();
            view.ColumnGroups.Add(new GridViewColumnGroup("Customer Contact"));
            view.ColumnGroups.Add(new GridViewColumnGroup("Details"));
            view.ColumnGroups[1].Groups.Add(new GridViewColumnGroup("Address"));
            view.ColumnGroups[1].Groups.Add(new GridViewColumnGroup("Contact"));

            view.ColumnGroups[0].Rows.Add(new GridViewColumnGroupRow());
            view.ColumnGroups[0].Rows[0].ColumnNames.Add("CompanyName");
            view.ColumnGroups[0].Rows[0].ColumnNames.Add("ContactName");
            view.ColumnGroups[0].Rows[0].ColumnNames.Add("ContactTitle");
            view.ColumnGroups[1].Groups[0].Rows.Add(new GridViewColumnGroupRow());
            view.ColumnGroups[1].Groups[0].Rows[0].ColumnNames.Add("Address");
            view.ColumnGroups[1].Groups[0].Rows[0].ColumnNames.Add("City");
            view.ColumnGroups[1].Groups[0].Rows[0].ColumnNames.Add("Country");
            view.ColumnGroups[1].Groups[1].Rows.Add(new GridViewColumnGroupRow());
            view.ColumnGroups[1].Groups[1].Rows[0].ColumnNames.Add("Phone");
            view.ColumnGroups[1].Groups[1].Rows[0].ColumnNames.Add("Fax");
            radGridView1.ViewDefinition = view;
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            ColumnGroupsViewDefinition view = new ColumnGroupsViewDefinition();
            view.ColumnGroups.Add(new GridViewColumnGroup("Group Header"));
            view.ColumnGroups[0].ShowHeader = false;
            view.ColumnGroups[0].Rows.Add(new GridViewColumnGroupRow());
            view.ColumnGroups[0].Rows[0].ColumnNames.Add("ContactName");
            view.ColumnGroups[0].Rows[0].ColumnNames.Add("ContactTitle");
            view.ColumnGroups[0].Rows[0].ColumnNames.Add("Address");
            view.ColumnGroups[0].Rows[0].ColumnNames.Add("City");
            view.ColumnGroups[0].Rows[0].ColumnNames.Add("Country");
            view.ColumnGroups[0].Rows[0].ColumnNames.Add("Phone");
            view.ColumnGroups[0].Rows[0].ColumnNames.Add("Fax");
            view.ColumnGroups[0].Rows.Add(new GridViewColumnGroupRow());
            view.ColumnGroups[0].Rows[1].ColumnNames.Add("CompanyName");
            radGridView1.ViewDefinition = view;
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            radGridView1.ViewDefinition = _originalView;
        }
    }
}