using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace Presentation
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
        }
        private void getSalesReport(DateTime startDate, DateTime endDate)
        {
            SalesReport reportModel = new SalesReport();
            reportModel.createSalesOrderReport(startDate, endDate);
            SalesReportBindingSource.DataSource = reportModel;
            SalesListingBindingSource.DataSource = reportModel.salesListing;
            NetSalesByPeriodBindingSource.DataSource = reportModel.netSalesByPeriod;

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fromDate = DateTime.Today;
            var toDate = DateTime.Now;

            getSalesReport(fromDate, toDate);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var fromDate = DateTime.Today.AddDays(-7);
            var toDate = DateTime.Now;

            getSalesReport(fromDate, toDate);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var fromDate = new DateTime(
                DateTime.Now.Year,
                DateTime.Now.Month,
                1);
            var toDate = DateTime.Now;
            getSalesReport(fromDate, toDate);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var fromDate = DateTime.Today.AddDays(-30);
            var toDate = DateTime.Now;

            getSalesReport(fromDate, toDate);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var fromDate = new DateTime(
                DateTime.Now.Year,1,1);
            var toDate = DateTime.Now;
            getSalesReport(fromDate, toDate);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var fromDate = dateTimePicker1.Value;
            var toDate = dateTimePicker2.Value;

            getSalesReport(fromDate, new DateTime(
                toDate.Year,
                toDate.Month,
                toDate.Day, 23, 59, 59)
                );
        }
    }
}
