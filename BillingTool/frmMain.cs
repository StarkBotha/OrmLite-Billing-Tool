using BillingTool.DataModels;
using BillingTool.DataModels.CombinedModel;
using BillingTool.DataModels.Pricing;
using Microsoft.Extensions.Configuration;
using ServiceStack.OrmLite;
using ServiceStack.OrmLite.SqlServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingTool
{
    public partial class frmMain : Form
    {
        private static ApplicationSettings appSettings;
        private OrmLiteConnectionFactory dbFactory;

        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            appSettings = Program.Configuration.GetSection("ApplicationSettings").Get<ApplicationSettings>();

            var currentDate = DateTime.Now;

            cmbYear.SelectedItem = currentDate.Year.ToString();
            cmbMonth.SelectedItem = $"{currentDate.Month} - {currentDate.ToString("MMMM")}";

            dbFactory = new OrmLiteConnectionFactory(appSettings.ConnectionString, SqlServerDialect.Provider);
        }

        private void Log(string text)
        {
            Logger.Info(text);
            wl(text);
        }

        private void w(string text)
        {
            rtbOutput.AppendText(text);
        }

        private void wl(string text)
        {
            w(text + Environment.NewLine);
        }

        private void btnGetMerchants_Click(object sender, EventArgs e)
        {
            lstMerchants.Items.Clear();

            using (var db = dbFactory.Open())
            {
                using (var tran = db.OpenTransaction(System.Data.IsolationLevel.ReadUncommitted))
                {
                    var merchants = db.Select<Merchants>().Where(m => m.IsActive && m.IsApproved && !m.IsDeleted && !m.IsRejected);

                    foreach (var merchant in merchants)
                    {
                        lstMerchants.Items.Add(merchant);
                    }
                }
            }
        }

        private void btnGetMerchantBranches_Click(object sender, EventArgs e)
        {
            lstMerchantBranches.Items.Clear();

            using (var db = dbFactory.Open())
            {
                using (var tran = db.OpenTransaction(System.Data.IsolationLevel.ReadUncommitted))
                {
                    var merchantBranchesQuery = db.From<MerchantBranches>()
                                        .Join<Merchants>((mb, m) => m.Id == mb.MerchantId, SqlServerTableHint.NoLock);

                    if (lstMerchants.SelectedItems.Count > 0)
                    {
                        //Get the Merchant Ids
                        var selectedItems = lstMerchants.SelectedItems.Cast<Merchants>().Select(i => i.Id).ToList();
                        merchantBranchesQuery.Where<Merchants>(m => Sql.In(m.Id, selectedItems));
                    }

                    var merchantBranches = db.Select(merchantBranchesQuery);

                    foreach (var merchant in merchantBranches)
                    {
                        lstMerchantBranches.Items.Add(merchant);
                    }
                }
            }
        }

        private void btnGetMBPs_Click(object sender, EventArgs e)
        {
            lstMBPs.Items.Clear();


            using (var db = dbFactory.Open())
            {
                using (var tran = db.OpenTransaction(System.Data.IsolationLevel.ReadUncommitted))
                {
                    var mbpQuery = db.From<MerchantBranchProducts>()
                                        .Join<MerchantBranches>((mbp, mb) => mbp.MerchantBranchId == mb.Id, SqlServerTableHint.NoLock)
                                        .Join<MerchantBranches, Merchants>((mb, m) => mb.MerchantId == m.Id, SqlServerTableHint.NoLock);

                    if (lstMerchantBranches.SelectedItems.Count > 0)
                    {
                        //Selected Merchant Branches
                        var selectedMerchantBranchIds = lstMerchantBranches.SelectedItems.Cast<MerchantBranches>().Select(i => i.Id).ToList();
                        mbpQuery.Where<MerchantBranches>(mb => Sql.In(mb.Id, selectedMerchantBranchIds));
                    }

                    if (lstMerchants.SelectedItems.Count > 0)
                    {
                        //selected merchatns
                        var selectedMerchantIds = lstMerchants.SelectedItems.Cast<Merchants>().Select(i => i.Id).ToList();
                        mbpQuery.Where<Merchants>(m => Sql.In(m.Id, selectedMerchantIds));
                    }

                    var mbps = db.Select(mbpQuery);

                    foreach (var mbp in mbps)
                    {
                        lstMBPs.Items.Add(mbp);
                    }
                }
            }
        }

        private void btnGetProducts_Click(object sender, EventArgs e)
        {
            lstProducts.Items.Clear();


            using (var db = dbFactory.Open())
            {
                using (var tran = db.OpenTransaction(System.Data.IsolationLevel.ReadUncommitted))
                {
                    var productQuery = db.From<Products>()
                                        .Join<MerchantBranchProducts>((p, mbp) => p.Id == mbp.ProductId, SqlServerTableHint.NoLock)
                                        .Join<MerchantBranchProducts, MerchantBranches>((mbp, mb) => mbp.MerchantBranchId == mb.Id, SqlServerTableHint.NoLock)
                                        .Join<MerchantBranches, Merchants>((mb, m) => mb.MerchantId == m.Id, SqlServerTableHint.NoLock);

                    if (lstMerchantBranches.SelectedItems.Count > 0)
                    {
                        //Selected Merchant Branches
                        var selectedMerchantBranchIds = lstMerchantBranches.SelectedItems.Cast<MerchantBranches>().Select(i => i.Id).ToList();
                        productQuery.Where<MerchantBranches>(mb => Sql.In(mb.Id, selectedMerchantBranchIds));
                    }

                    if (lstMerchants.SelectedItems.Count > 0)
                    {
                        //selected merchatns
                        var selectedMerchantIds = lstMerchants.SelectedItems.Cast<Merchants>().Select(i => i.Id).ToList();
                        productQuery.Where<Merchants>(m => Sql.In(m.Id, selectedMerchantIds));
                    }

                    if (lstMBPs.SelectedItems.Count > 0)
                    {
                        //Selected MerchantBranchProductIds
                        var selectedMerchantBranchProductId = lstMBPs.SelectedItems.Cast<MerchantBranchProducts>().Select(i => i.Id).ToList();
                        productQuery.Where<MerchantBranchProducts>(mbp => Sql.In(mbp.Id, selectedMerchantBranchProductId));
                    }

                    var products = db.Select(productQuery.SelectDistinct());

                    foreach (var product in products)
                    {
                        lstProducts.Items.Add(product);
                    }
                }
            }
        }

        private void btnCountBilled_Click(object sender, EventArgs e)
        {
            using (var db = dbFactory.Open())
            {
                using (var tran = db.OpenTransaction(System.Data.IsolationLevel.ReadUncommitted))
                {
                    var applicableDate = new DateTime(int.Parse(cmbYear.Text), int.Parse(cmbMonth.Text.Substring(0, 1)), 1);

                    var q = db.From<TransactionHistory>()
                        .Where(th => (th.Billed.HasValue && th.Billed.Value == true) && th.UpdateDate >= applicableDate)
                        .Select(Sql.Count("*"));

                    txtCountBilled.Text = db.Scalar<int>(q).ToString();
                }
            }
        }

        private void btnGetEligibleCount_Click(object sender, EventArgs e)
        {
            using (var db = dbFactory.Open())
            {
                using (var tran = db.OpenTransaction(System.Data.IsolationLevel.ReadUncommitted))
                {
                    var eligibleYear = int.Parse(cmbYear.Text);
                    var eligibleMonth = int.Parse(cmbMonth.Text.Substring(0, 1));

                    var applicableDate = new DateTime(eligibleYear, eligibleMonth, 1);

                    var q = db.From<TransactionHistory>()
                        .Join<BillableResponseCodes>((th, brc) => th.OutcomeCode == brc.ResponseCode)
                        .Where(th => (!th.Billed.HasValue || th.Billed.Value == false) && th.UpdateDate >= applicableDate)
                        .Select(Sql.Count("*"));

                    txtEligibleCount.Text = db.Scalar<int>(q).ToString();
                }
            }
        }

        private void btnDoBillingRun_Click(object sender, EventArgs e)
        {
            int limit = int.Parse(txtLotSize.Text);

            var eligibleYear = int.Parse(cmbYear.Text);
            var eligibleMonth = int.Parse(cmbMonth.Text.Substring(0, 1));
            var startMonth = new DateTime(eligibleYear, eligibleMonth, 1);
            var endMonth = startMonth.AddMonths(1);


            var mbps = GetMerchantBranchProductIds();

            

            foreach (var mbp in mbps)
            {
                //Log($"MBP: {mbp}");

                if (chkInstallments.Checked)
                {
                    //get a list of transaction histories for the given mbp that have billable outcomes and that have not already been billed
                    GetSomeBillableInstallmentTransactionHistoryRecordsForMBP(mbp, limit, startMonth, endMonth);
                }
            }
        }

        private List<Guid> GetMerchantBranchProductIds()
        {
            if (lstMBPs.SelectedItems.Count > 0)
            {
                return lstMBPs.SelectedItems.Cast<MerchantBranchProducts>().Select(i => i.Id).ToList();
            }

            using (var db = dbFactory.Open())
            {
                using (var tran = db.OpenTransaction(System.Data.IsolationLevel.ReadUncommitted))
                {
                    var mbpQuery = db.From<MerchantBranchProducts>()
                        .Select<MerchantBranchProducts>(mbp => mbp.Id);

                    return db.Column<Guid>(mbpQuery);
                }
            }
        }

        private void GetSomeBillableInstallmentTransactionHistoryRecordsForMBP(Guid merchantBranchProductId, int lotSize, DateTime startDate, DateTime endDate)
        {

            using (var db = dbFactory.Open())
            {
                using (var tran = db.OpenTransaction(System.Data.IsolationLevel.ReadCommitted))
                {
                    var query =
                        db.From<TransactionHistory>()
                        .Join<Transactions>()
                        .Join<Transactions, InstallmentTransactions>()
                        .Join<TransactionHistory, BillableResponseCodes>((th, brc) => th.OutcomeCode == brc.ResponseCode)
                        .Where<Transactions>(th => th.MerchantBranchProductId == merchantBranchProductId)
                        //.Where<Transactions>(t => t.UpdateTimestamp >= startDate && t.UpdateTimestamp <= endDate)
                        .Select<TransactionHistory, Transactions, BillableResponseCodes, InstallmentTransactions>(
                            (th, t, brc, instr) => new
                            {
                                Id=th.Id,
                                IsCancelled = brc.IsCancelled,
                                IsDispute = brc.IsDispute,
                                IsFailed = brc.IsFailed,
                                IsSuccess = brc.IsSuccess,
                                IsTracking = brc.IsTracking,
                                TotalCost = t.TotalCostInCents,
                                InstallmentId = instr.InstallmentId
                            }
                        );

                    var results = db.Select<(Guid Id, bool IsCancelled, bool IsDispute, bool IsFailed, bool IsSuccess, bool IsTracking, long TotalCost, Guid InstallmentId)>(query);

                    foreach(var result in results)
                    {
                        Log($"{result.Id} {result.IsCancelled} {result.TotalCost} {result.InstallmentId}");
                    }
                }
            }
        }






        private void GetBillableInstallmentTransactionHistoryRecords()
        {

            using (var db = dbFactory.Open())
            {
                using (var tran = db.OpenTransaction(System.Data.IsolationLevel.ReadCommitted))
                {
                    var query =
                            db.From<MerchantBranchProducts>()
                            .Join<Transactions>()
                            .Join<Transactions, InstallmentTransactions>()
                            .Join<Transactions, TransactionHistory>()
                            .Join<TransactionHistory, BillableResponseCodes>((th, brc) => th.OutcomeCode == brc.ResponseCode);

                    if (lstMBPs.SelectedItems.Count > 0)
                    {
                        //Selected MerchantBranchProductIds
                        var selectedMerchantBranchProductId = lstMBPs.SelectedItems.Cast<MerchantBranchProducts>().Select(i => i.Id).ToList();
                        query.Where<MerchantBranchProducts>(mbp => Sql.In(mbp.Id, selectedMerchantBranchProductId));
                    }


                }
            }
        }

        private void btnDeleteBillings_Click(object sender, EventArgs e)
        {

            using (var db = dbFactory.Open())
            {
                using (var tran = db.OpenTransaction(System.Data.IsolationLevel.ReadUncommitted))
                {

                }
            }
        }
    }
}
