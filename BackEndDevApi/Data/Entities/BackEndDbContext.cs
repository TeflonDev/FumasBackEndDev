using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Crypto.Utilities;

namespace BackEndDevApi.Data.Entities
{
	
	public class BackEndDbContext:DbContext

	{
		public BackEndDbContext(DbContextOptions<BackEndDbContext> options): base(options)
		{
			
		}
		public	virtual DbSet<Users> users { get; set; }
		public virtual DbSet<Accounts> accounts { get; set; }
		public virtual DbSet<si> si { get; set; }
		public virtual DbSet<SubCateg> sub_sc { get; set; }
		public virtual DbSet<Locations> sl { get; set; }
		public virtual DbSet<Categ> sc { get; set; }
		public virtual DbSet<Pu> pu { get; set; }

		public virtual DbSet<Staff> staff { get; set; }
		public virtual DbSet<Clients> clients { get; set; }
		public virtual DbSet<Invoices> invoices { get; set; }
		public virtual DbSet<Orders> orders { get; set; }
		public virtual DbSet<Adjust> adjust { get; set; }
		public virtual DbSet<Lpo> lpo { get; set; }
		public virtual DbSet<Quotations> quotations { get; set; }
		public virtual DbSet<Grn> grn { get; set; }
		public virtual DbSet<Credit> credit { get; set; }
		public virtual DbSet<Issue> issue { get; set; }
		public virtual DbSet<Journals> journals { get; set; }
		public virtual DbSet<Stran> stran { get; set; }
		public virtual DbSet<Cashout> cashout { get; set; }
		public virtual DbSet<CompanySettings> company_settings { get; set; }
		public virtual DbSet<ApPrepayment> ap_prepayment { get; set; }
		public virtual DbSet<ArPrepayment> ar_prepayment { get; set; }
		public virtual DbSet<ArReceipts> ar_receipts { get; set; }
		public virtual DbSet<BankTransfer> bank_transfer { get; set; }
		public virtual DbSet<Autosettings> autosettings { get; set; }
		public virtual DbSet<PosHeader> pos_header { get; set; }
		public virtual DbSet<Systemaudit> systemaudit { get; set; }
		public virtual DbSet<UsersRights> users_rights { get; set; }
		public virtual DbSet<UsersRoles> users_roles { get; set; }
		public virtual DbSet<Pcv> pcv { get; set; }
		public virtual DbSet<Commissionlist> commissionlist { get; set; }
		public virtual DbSet<Stockcard> stockcard { get; set; }
		public virtual DbSet<Stocktakes> stocktakes { get; set; }
		public virtual DbSet<Inventories> inventories { get; set; }
		public virtual DbSet<Cashsale> cashsale { get; set; }
		public virtual DbSet<Details> details { get; set; }
		public virtual DbSet<Deposits> deposits { get; set; }
		public virtual DbSet<Approvals> approvals { get; set; }
		public virtual DbSet<Reporttables> reporttables { get; set; }
		public virtual DbSet<Reportsfields> reportsfields { get; set; }
		public virtual DbSet<Budget> budget { get; set; }
		public virtual DbSet<Budgetitems> budgetitems { get; set; }
		public virtual DbSet<Expenses> expenses { get; set; }
		public virtual DbSet<Assets> assets { get; set; }
		public virtual DbSet<Payroll> payroll { get; set; }
		public virtual DbSet<AdjustD> adjust_d { get; set; }
		public virtual DbSet<ApPrepaymentDetails> ap_prepayment_details { get; set; }
		public virtual DbSet<ArCreditDetails> ar_credit_details { get; set; }
		public virtual DbSet<ArPrepaymentDetails> ar_prepayment_details { get; set; }
		public virtual DbSet<CreditorsTransactions> creditors_transactions { get; set; }
		public virtual DbSet<Nauto> nauto { get; set; }
		public virtual DbSet<PosDetails> pos_details { get; set; }
		public virtual DbSet<GrnD> grn_d { get; set; }
		public virtual DbSet<InvoicesDdetails> invoices_ddetails { get; set; }
		public virtual DbSet<IssueD> issue_d { get; set; }
		public virtual DbSet<LpoD> lpo_d { get; set; }
		public virtual DbSet<OrdersD> orders_d { get; set; }
		public virtual DbSet<JournalDetails> journal_details { get; set; }
		public virtual DbSet<JournalTransactions> journal_transactions { get; set; }
		public virtual DbSet<BankReconEntries> bankreconentries { get; set; }
		public virtual DbSet<PosPaymentDetails> pospaymentdetails { get; set; }
		public virtual DbSet<PosPaymentMode> pospaymentmode { get; set; }
		public virtual DbSet<PosSettings> possettings { get; set; }
		public virtual DbSet<SysForms> sysforms { get; set; }
		public virtual DbSet<SysSettings> syssettings { get; set; }
	}
}
