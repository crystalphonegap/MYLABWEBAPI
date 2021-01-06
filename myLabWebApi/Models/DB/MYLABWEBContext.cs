using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace myLabWebApi.Models.New
{
    public partial class MYLABWEBContext : DbContext
    {
        public MYLABWEBContext()
        {
        }

        public MYLABWEBContext(DbContextOptions<MYLABWEBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ADMIN_HOME_VISIT_ALLOCATED> ADMIN_HOME_VISIT_ALLOCATED { get; set; }
        public virtual DbSet<ADMIN_LOGIN> ADMIN_LOGIN { get; set; }
        public virtual DbSet<ADMIN_PACKKAGE> ADMIN_PACKKAGE { get; set; }
        public virtual DbSet<AMOUNTPAID> AMOUNTPAID { get; set; }
        public virtual DbSet<AbnormalSMSLog> AbnormalSMSLog { get; set; }
        public virtual DbSet<AppointmentImage> AppointmentImage { get; set; }
        public virtual DbSet<BOOKHOMEVISIT> BOOKHOMEVISIT { get; set; }
        public virtual DbSet<BOOK_APPOINTMENT> BOOK_APPOINTMENT { get; set; }
        public virtual DbSet<BillDetail> BillDetail { get; set; }
        public virtual DbSet<BillHeader> BillHeader { get; set; }
        public virtual DbSet<BlackListMobiles> BlackListMobiles { get; set; }
        public virtual DbSet<CATEGORY> CATEGORY { get; set; }
        public virtual DbSet<CBCWorksheet> CBCWorksheet { get; set; }
        public virtual DbSet<CBCWorksheet28012013> CBCWorksheet28012013 { get; set; }
        public virtual DbSet<COLLECTIONCENTER> COLLECTIONCENTER { get; set; }
        public virtual DbSet<COMPANY> COMPANY { get; set; }
        public virtual DbSet<CollectionCenterAmountReceived> CollectionCenterAmountReceived { get; set; }
        public virtual DbSet<DOCDET> DOCDET { get; set; }
        public virtual DbSet<DOCHDR> DOCHDR { get; set; }
        public virtual DbSet<DOCHDR_HISTORY> DOCHDR_HISTORY { get; set; }
        public virtual DbSet<DOCTOR> DOCTOR { get; set; }
        public virtual DbSet<DOCTORBK> DOCTORBK { get; set; }
        public virtual DbSet<EMPLOYEE> EMPLOYEE { get; set; }
        public virtual DbSet<EmailLog> EmailLog { get; set; }
        public virtual DbSet<EmployeeWithCollectionCenterMap> EmployeeWithCollectionCenterMap { get; set; }
        public virtual DbSet<GROUPDET> GROUPDET { get; set; }
        public virtual DbSet<HISTOGRAM> HISTOGRAM { get; set; }
        public virtual DbSet<HomevisitImage> HomevisitImage { get; set; }
        public virtual DbSet<INTGDET> INTGDET { get; set; }
        public virtual DbSet<LABELGROUP> LABELGROUP { get; set; }
        public virtual DbSet<LabMST> LabMST { get; set; }
        public virtual DbSet<LabMaster> LabMaster { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<MYLAB_TEST_DETAILS> MYLAB_TEST_DETAILS { get; set; }
        public virtual DbSet<MYLAB_TEST_DETAILS_BA200> MYLAB_TEST_DETAILS_BA200 { get; set; }
        public virtual DbSet<MetroEmailLog> MetroEmailLog { get; set; }
        public virtual DbSet<NARRATIONS> NARRATIONS { get; set; }
        public virtual DbSet<NEXTGENDATA> NEXTGENDATA { get; set; }
        public virtual DbSet<PATIENT> PATIENT { get; set; }
        public virtual DbSet<PATIENT_BILL_DETAILS> PATIENT_BILL_DETAILS { get; set; }
        public virtual DbSet<PATIENT_MASTER> PATIENT_MASTER { get; set; }
        public virtual DbSet<PATIENT_history> PATIENT_history { get; set; }
        public virtual DbSet<PDFLog> PDFLog { get; set; }
        public virtual DbSet<PHLEBOMIST_COLLECTED_TEST> PHLEBOMIST_COLLECTED_TEST { get; set; }
        public virtual DbSet<PREDEFVAL> PREDEFVAL { get; set; }
        public virtual DbSet<PROFDET> PROFDET { get; set; }
        public virtual DbSet<Param> Param { get; set; }
        public virtual DbSet<ParamHelpValues> ParamHelpValues { get; set; }
        public virtual DbSet<PatientProfilePic> PatientProfilePic { get; set; }
        public virtual DbSet<Patient_Portal> Patient_Portal { get; set; }
        public virtual DbSet<PayRemDetail> PayRemDetail { get; set; }
        public virtual DbSet<PayRemHeader> PayRemHeader { get; set; }
        public virtual DbSet<Phelobotomist_HomeVisit> Phelobotomist_HomeVisit { get; set; }
        public virtual DbSet<QER_AMOUNTPAID> QER_AMOUNTPAID { get; set; }
        public virtual DbSet<QER_AMOUNTPAIDType> QER_AMOUNTPAIDType { get; set; }
        public virtual DbSet<QER_BALAMT> QER_BALAMT { get; set; }
        public virtual DbSet<QER_BIDIRECTION> QER_BIDIRECTION { get; set; }
        public virtual DbSet<QER_BILL> QER_BILL { get; set; }
        public virtual DbSet<QER_CBC_WorkSheet> QER_CBC_WorkSheet { get; set; }
        public virtual DbSet<QER_COLLECTION> QER_COLLECTION { get; set; }
        public virtual DbSet<QER_COMPARERATE> QER_COMPARERATE { get; set; }
        public virtual DbSet<QER_DAILYREGISTER> QER_DAILYREGISTER { get; set; }
        public virtual DbSet<QER_DAILYREGREFUND> QER_DAILYREGREFUND { get; set; }
        public virtual DbSet<QER_DISPATCHREGISTER> QER_DISPATCHREGISTER { get; set; }
        public virtual DbSet<QER_DOCTORLIST> QER_DOCTORLIST { get; set; }
        public virtual DbSet<QER_DOCTORWISE_COMMISSION> QER_DOCTORWISE_COMMISSION { get; set; }
        public virtual DbSet<QER_DOCTORWISE_COMMISSION_OLD> QER_DOCTORWISE_COMMISSION_OLD { get; set; }
        public virtual DbSet<QER_DOCTOR_COMM> QER_DOCTOR_COMM { get; set; }
        public virtual DbSet<QER_DOCTOR_COMMISSION> QER_DOCTOR_COMMISSION { get; set; }
        public virtual DbSet<QER_DOCTOR_COMMISSION_OLD> QER_DOCTOR_COMMISSION_OLD { get; set; }
        public virtual DbSet<QER_FILLDATA> QER_FILLDATA { get; set; }
        public virtual DbSet<QER_FOR_MYPATHTEST> QER_FOR_MYPATHTEST { get; set; }
        public virtual DbSet<QER_PATIENT> QER_PATIENT { get; set; }
        public virtual DbSet<QER_PATIENTREPORT> QER_PATIENTREPORT { get; set; }
        public virtual DbSet<QER_PATIENTTYPE> QER_PATIENTTYPE { get; set; }
        public virtual DbSet<QER_PATIENT_HISTORY> QER_PATIENT_HISTORY { get; set; }
        public virtual DbSet<QER_PAYMENTS> QER_PAYMENTS { get; set; }
        public virtual DbSet<QER_PAYMENTSTYPE> QER_PAYMENTSTYPE { get; set; }
        public virtual DbSet<QER_PENDING_TEST> QER_PENDING_TEST { get; set; }
        public virtual DbSet<QER_PendingTestsNew> QER_PendingTestsNew { get; set; }
        public virtual DbSet<QER_RATELIST> QER_RATELIST { get; set; }
        public virtual DbSet<QER_REFUNDAMOUNT> QER_REFUNDAMOUNT { get; set; }
        public virtual DbSet<QER_RESULTREGISTER> QER_RESULTREGISTER { get; set; }
        public virtual DbSet<QER_RESULTREGISTER1> QER_RESULTREGISTER1 { get; set; }
        public virtual DbSet<QER_RESULTREGISTER2> QER_RESULTREGISTER2 { get; set; }
        public virtual DbSet<QER_RESULTREGISTERREPORT> QER_RESULTREGISTERREPORT { get; set; }
        public virtual DbSet<QER_RESULTREGISTERREPORT1> QER_RESULTREGISTERREPORT1 { get; set; }
        public virtual DbSet<QER_RESULTREGISTERREPORTSMS> QER_RESULTREGISTERREPORTSMS { get; set; }
        public virtual DbSet<QER_RESULTREGISTERREPORTSMSCRITICAL> QER_RESULTREGISTERREPORTSMSCRITICAL { get; set; }
        public virtual DbSet<QER_RESULTREGISTERSMS> QER_RESULTREGISTERSMS { get; set; }
        public virtual DbSet<QER_RESULTREGISTERSMSCRITICAL> QER_RESULTREGISTERSMSCRITICAL { get; set; }
        public virtual DbSet<QER_SPECIALTESTS> QER_SPECIALTESTS { get; set; }
        public virtual DbSet<QER_TESTCOUNT> QER_TESTCOUNT { get; set; }
        public virtual DbSet<QER_TESTS> QER_TESTS { get; set; }
        public virtual DbSet<QER_WORK_SHEET> QER_WORK_SHEET { get; set; }
        public virtual DbSet<QER_WORK_SHEET_OLD> QER_WORK_SHEET_OLD { get; set; }
        public virtual DbSet<QerCollectionCenterBillDetail> QerCollectionCenterBillDetail { get; set; }
        public virtual DbSet<QerTDSCertificate> QerTDSCertificate { get; set; }
        public virtual DbSet<QuantumTestMapp> QuantumTestMapp { get; set; }
        public virtual DbSet<RATELIST> RATELIST { get; set; }
        public virtual DbSet<RATELISTHDR> RATELISTHDR { get; set; }
        public virtual DbSet<RateListDiscountRate> RateListDiscountRate { get; set; }
        public virtual DbSet<Reject_Reason> Reject_Reason { get; set; }
        public virtual DbSet<ReportReadySMSLog> ReportReadySMSLog { get; set; }
        public virtual DbSet<ReportValuesCRSMSLOG> ReportValuesCRSMSLOG { get; set; }
        public virtual DbSet<ReportValuesSMSLOG> ReportValuesSMSLOG { get; set; }
        public virtual DbSet<SMSAPI> SMSAPI { get; set; }
        public virtual DbSet<SMSTEMPLATEDET> SMSTEMPLATEDET { get; set; }
        public virtual DbSet<SMSTEMPLATEHDR> SMSTEMPLATEHDR { get; set; }
        public virtual DbSet<SMSTESTREGISTER> SMSTESTREGISTER { get; set; }
        public virtual DbSet<SMS_SET> SMS_SET { get; set; }
        public virtual DbSet<Scheduler> Scheduler { get; set; }
        public virtual DbSet<TESTDET> TESTDET { get; set; }
        public virtual DbSet<TESTMASTER> TESTMASTER { get; set; }
        public virtual DbSet<TESTMST> TESTMST { get; set; }
        public virtual DbSet<TESTREGISTER> TESTREGISTER { get; set; }
        public virtual DbSet<TESTTYPE> TESTTYPE { get; set; }
        public virtual DbSet<TEST_FORMAT_DET> TEST_FORMAT_DET { get; set; }
        public virtual DbSet<TestValidation> TestValidation { get; set; }
        public virtual DbSet<TreeView> TreeView { get; set; }
        public virtual DbSet<USERRIGHTS> USERRIGHTS { get; set; }
        public virtual DbSet<USERS> USERS { get; set; }
        public virtual DbSet<UserMaster> UserMaster { get; set; }
        public virtual DbSet<VW_PATIENT_BILL_DETAILS> VW_PATIENT_BILL_DETAILS { get; set; }
        public virtual DbSet<architect> architect { get; set; }
        public virtual DbSet<qer_paidrefund> qer_paidrefund { get; set; }
        public virtual DbSet<smsData> smsData { get; set; }
        public virtual DbSet<tblAppointmentTrack> tblAppointmentTrack { get; set; }
        public virtual DbSet<v1> v1 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=103.131.93.13;Initial Catalog=MYLABWEB;User Id=MYLAB;Password=MYLAB@123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ADMIN_HOME_VISIT_ALLOCATED>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ALLOT_TIME).HasMaxLength(50);

                entity.Property(e => e.BOOKEDHOMEVISIT_ID).HasMaxLength(50);

                entity.Property(e => e.FILE_NAME).HasMaxLength(50);

                entity.Property(e => e.FILE_PATH).HasMaxLength(250);

                entity.Property(e => e.ID).ValueGeneratedOnAdd();

                entity.Property(e => e.LabName).HasMaxLength(100);

                entity.Property(e => e.PATIENT_AREA).HasMaxLength(50);

                entity.Property(e => e.PATIENT_CONTACT).HasMaxLength(50);

                entity.Property(e => e.PATIENT_NAME).HasMaxLength(50);

                entity.Property(e => e.PHLEB_ID).HasMaxLength(50);

                entity.Property(e => e.PHLEB_NAME).HasMaxLength(50);

                entity.Property(e => e.REMARK).HasMaxLength(50);

                entity.Property(e => e.SEND_DATETIME).HasColumnType("datetime");

                entity.Property(e => e.SysDate).HasColumnType("datetime");

                entity.Property(e => e.USERID).HasMaxLength(50);

                entity.Property(e => e.bookingDate).HasColumnType("datetime");

                entity.Property(e => e.patient_address)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ADMIN_LOGIN>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CONTACT).HasMaxLength(50);

                entity.Property(e => e.EMAIL).HasMaxLength(50);

                entity.Property(e => e.ID).ValueGeneratedOnAdd();

                entity.Property(e => e.LabName).HasMaxLength(50);

                entity.Property(e => e.PASSWORD).HasMaxLength(50);

                entity.Property(e => e.SYS_DATE).HasColumnType("datetime");

                entity.Property(e => e.SysDate).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(30);

                entity.Property(e => e.USERNAME).HasMaxLength(50);
            });

            modelBuilder.Entity<ADMIN_PACKKAGE>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CONTACT).HasMaxLength(50);

                entity.Property(e => e.FROM_DATE).HasMaxLength(50);

                entity.Property(e => e.ID).ValueGeneratedOnAdd();

                entity.Property(e => e.LabAddress).HasMaxLength(100);

                entity.Property(e => e.LabArea).HasMaxLength(50);

                entity.Property(e => e.LabCode).HasMaxLength(50);

                entity.Property(e => e.LabName).HasMaxLength(50);

                entity.Property(e => e.PACKKAGE_NAME).HasMaxLength(50);

                entity.Property(e => e.PRICE).HasMaxLength(50);

                entity.Property(e => e.PackageCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sysdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TEST_NAME).HasMaxLength(50);

                entity.Property(e => e.TO_DATE).HasMaxLength(50);

                entity.Property(e => e.USER_ID).HasMaxLength(50);
            });

            modelBuilder.Entity<AMOUNTPAID>(entity =>
            {
                entity.HasKey(e => e.Paymentid);

                entity.HasIndex(e => e.Patientid)
                    .HasName("IX_AMOUNTPAID_PATIENTID");

                entity.Property(e => e.AmountPaid1).HasColumnName("AmountPaid");

                entity.Property(e => e.CurrentDate).HasColumnType("smalldatetime");

                entity.Property(e => e.PayDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Paymode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.userid).HasMaxLength(50);
            });

            modelBuilder.Entity<AbnormalSMSLog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.HasIndex(e => e.PATIENT_Name)
                    .HasName("IX_AbnormalSMSLog_PatientName");

                entity.Property(e => e.LastSMSDate).HasColumnType("datetime");

                entity.Property(e => e.PATIENT_Date).HasColumnType("datetime");

                entity.Property(e => e.PATIENT_Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PATIENT_Telno)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SMS)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SysDate).HasColumnType("datetime");

                entity.Property(e => e.SysDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TemplateName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.sysFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AppointmentImage>(entity =>
            {
                entity.Property(e => e.AppointmentId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ImageString).HasColumnType("ntext");
            });

            modelBuilder.Entity<BOOKHOMEVISIT>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ADDRESS).HasMaxLength(250);

                entity.Property(e => e.AREA).HasMaxLength(50);

                entity.Property(e => e.Age).HasMaxLength(5);

                entity.Property(e => e.BOOKED_FLAG).HasDefaultValueSql("((0))");

                entity.Property(e => e.BookedBy).HasMaxLength(100);

                entity.Property(e => e.CONTACT)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cancel)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'NO')");

                entity.Property(e => e.CancleReason)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Current_date)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DATE).HasColumnType("datetime");

                entity.Property(e => e.FILENAME).HasMaxLength(50);

                entity.Property(e => e.FILEPATH).HasMaxLength(250);

                entity.Property(e => e.Gender)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.HomevisitId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ID).ValueGeneratedOnAdd();

                entity.Property(e => e.LabCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PATIENT_ID)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PREFERED_LAB).HasMaxLength(50);

                entity.Property(e => e.PatientContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatientEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Patient_name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.REMARK).HasMaxLength(250);

                entity.Property(e => e.RowSent).HasDefaultValueSql("((0))");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.Sys_Date)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TIME)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BOOK_APPOINTMENT>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ADDRESS)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.AREA)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.AppointmentID)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BookedBy).HasMaxLength(100);

                entity.Property(e => e.CONTACT)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cancel)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('NO')");

                entity.Property(e => e.CancleReason)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DATE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FILENAME)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FILEPATH)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ID).ValueGeneratedOnAdd();

                entity.Property(e => e.LabCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PATIENT_ID)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PREFERED_LAB)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatientContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatientEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.REMARK)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RowSent).HasDefaultValueSql("((0))");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'UPCOMING')");

                entity.Property(e => e.TIME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.USERNAME_Book)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.age)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.gender)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BillDetail>(entity =>
            {
                entity.HasKey(e => e.BillDetId);

                entity.Property(e => e.Amt_received).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Concession).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Doctor_Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NormalTest).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OtherCharges).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Patient_Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Patient_date).HasColumnType("datetime");

                entity.Property(e => e.Proposal_No).HasMaxLength(255);

                entity.Property(e => e.Remark)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialTest).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Test_alias).HasMaxLength(1000);

                entity.Property(e => e.TotalAmt).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<BillHeader>(entity =>
            {
                entity.HasKey(e => e.BillId);

                entity.Property(e => e.BillId).ValueGeneratedNever();

                entity.Property(e => e.Addition).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BillDate).HasColumnType("datetime");

                entity.Property(e => e.Bill_Type)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cess).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Deduction).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Fin_Year)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Hscess).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ServiceTax).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.SubTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TdsCertificateRecDate).HasColumnType("datetime");

                entity.Property(e => e.TdsCertificateRecNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<BlackListMobiles>(entity =>
            {
                entity.HasKey(e => e.BlacklistId)
                    .HasName("PK_BlackListMobile");

                entity.HasIndex(e => e.Mobile)
                    .HasName("IX_BlackListMobiles");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.sysDate).HasColumnType("datetime");

                entity.Property(e => e.sysUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CATEGORY>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CatDescription).HasMaxLength(150);

                entity.Property(e => e.CatName).HasMaxLength(50);

                entity.Property(e => e.CatRemark).HasMaxLength(150);

                entity.Property(e => e.CatRemark1).HasMaxLength(150);
            });

            modelBuilder.Entity<CBCWorksheet>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Field_name).HasMaxLength(50);

                entity.Property(e => e.Test_name).HasMaxLength(50);
            });

            modelBuilder.Entity<CBCWorksheet28012013>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Field_name).HasMaxLength(50);

                entity.Property(e => e.Test_name).HasMaxLength(50);
            });

            modelBuilder.Entity<COLLECTIONCENTER>(entity =>
            {
                entity.HasKey(e => e.CENTER_id);

                entity.Property(e => e.CENTER_id).ValueGeneratedNever();

                entity.Property(e => e.CENTER_Address1).HasMaxLength(255);

                entity.Property(e => e.CENTER_Address2).HasMaxLength(255);

                entity.Property(e => e.CENTER_City).HasMaxLength(255);

                entity.Property(e => e.CENTER_Country).HasMaxLength(255);

                entity.Property(e => e.CENTER_Name).HasMaxLength(255);

                entity.Property(e => e.CENTER_Pincode).HasMaxLength(255);

                entity.Property(e => e.CENTER_Region).HasMaxLength(255);

                entity.Property(e => e.CENTER_State).HasMaxLength(255);

                entity.Property(e => e.CENTER_Telno).HasMaxLength(50);

                entity.Property(e => e.OutSourceLab)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<COMPANY>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.COMPANY_Abnormal).HasMaxLength(200);

                entity.Property(e => e.COMPANY_Address1).HasMaxLength(255);

                entity.Property(e => e.COMPANY_Address2).HasMaxLength(255);

                entity.Property(e => e.COMPANY_CardDegree1).HasMaxLength(100);

                entity.Property(e => e.COMPANY_CardDegree2).HasMaxLength(100);

                entity.Property(e => e.COMPANY_CardDegree3).HasMaxLength(100);

                entity.Property(e => e.COMPANY_Cardiologist1).HasMaxLength(100);

                entity.Property(e => e.COMPANY_Cardiologist2).HasMaxLength(100);

                entity.Property(e => e.COMPANY_Cardiologist3).HasMaxLength(100);

                entity.Property(e => e.COMPANY_City).HasMaxLength(255);

                entity.Property(e => e.COMPANY_Country).HasMaxLength(255);

                entity.Property(e => e.COMPANY_DataLoc).HasMaxLength(255);

                entity.Property(e => e.COMPANY_Email).HasMaxLength(255);

                entity.Property(e => e.COMPANY_Faxnumber).HasMaxLength(50);

                entity.Property(e => e.COMPANY_Name).HasMaxLength(255);

                entity.Property(e => e.COMPANY_Password).HasMaxLength(50);

                entity.Property(e => e.COMPANY_PathoDegree1).HasMaxLength(100);

                entity.Property(e => e.COMPANY_PathoDegree2).HasMaxLength(100);

                entity.Property(e => e.COMPANY_PathoDegree3).HasMaxLength(100);

                entity.Property(e => e.COMPANY_Pathologist1).HasMaxLength(100);

                entity.Property(e => e.COMPANY_Pathologist2).HasMaxLength(100);

                entity.Property(e => e.COMPANY_Pathologist3).HasMaxLength(100);

                entity.Property(e => e.COMPANY_PhoneNumber).HasMaxLength(50);

                entity.Property(e => e.COMPANY_PostalCode).HasMaxLength(255);

                entity.Property(e => e.COMPANY_RadDegree1).HasMaxLength(100);

                entity.Property(e => e.COMPANY_RadDegree2).HasMaxLength(100);

                entity.Property(e => e.COMPANY_RadDegree3).HasMaxLength(100);

                entity.Property(e => e.COMPANY_Radiologist1).HasMaxLength(100);

                entity.Property(e => e.COMPANY_Radiologist2).HasMaxLength(100);

                entity.Property(e => e.COMPANY_Radiologist3).HasMaxLength(100);

                entity.Property(e => e.COMPANY_ReportLoc).HasMaxLength(255);

                entity.Property(e => e.COMPANY_Series)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.COMPANY_SonoDegree).HasMaxLength(100);

                entity.Property(e => e.COMPANY_SonoLogist).HasMaxLength(100);

                entity.Property(e => e.COMPANY_State).HasMaxLength(255);

                entity.Property(e => e.COMPANY_Url).HasMaxLength(255);

                entity.Property(e => e.COMPANY_Username).HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(255);
            });

            modelBuilder.Entity<CollectionCenterAmountReceived>(entity =>
            {
                entity.HasKey(e => e.PayRecId);

                entity.Property(e => e.BankBranch)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ChequeDate).HasColumnType("datetime");

                entity.Property(e => e.ChequeNo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Deduction).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PayRecDate).HasColumnType("datetime");

                entity.Property(e => e.PayRecMode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RecAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TDS).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<DOCDET>(entity =>
            {
                entity.HasKey(e => new { e.DOCDET_lHeaderId, e.DOCDET_lFieldNo });

                entity.HasIndex(e => e.DOCDET_lHeaderId)
                    .HasName("IX_DOCDET");

                entity.HasIndex(e => new { e.DOCDET_lTestCatId, e.DOCDET_lFieldNo })
                    .HasName("IX_DOCDET_1");

                entity.Property(e => e.DOCDET_tFieldValue).HasMaxLength(255);

                entity.Property(e => e.DOCDET_tFieldValue1).HasColumnType("ntext");

                entity.Property(e => e.LowH_High)
                    .HasColumnName("LowH/High")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NormalValue)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Rerun).HasDefaultValueSql("((0))");

                entity.Property(e => e.ValueForNormal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.isResRec).HasDefaultValueSql("(0)");

                entity.Property(e => e.sUnit)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DOCHDR>(entity =>
            {
                entity.HasKey(e => e.DOCHDR_lDocumentId);

                entity.HasIndex(e => e.DOCHDR_Sample)
                    .HasName("IX_DOCHDR_SAMPLE");

                entity.HasIndex(e => e.DOCHDR_TestCatID)
                    .HasName("IX_DOCHDR_TESTCATID");

                entity.HasIndex(e => e.DOCHDR_dDate)
                    .HasName("IX_DOCHDR_Date");

                entity.HasIndex(e => e.DOCHDR_lDoctorId)
                    .HasName("IX_DOCHDR_DOCTORID");

                entity.HasIndex(e => e.DOCHDR_lPatientId)
                    .HasName("IX_DOCHDR_PATIENTID");

                entity.HasIndex(e => e.MarkComplete)
                    .HasName("IX_DOCHDR_markcomplete");

                entity.Property(e => e.DOCHDR_lDocumentId).ValueGeneratedNever();

                entity.Property(e => e.AuntheticateDate).HasColumnType("datetime");

                entity.Property(e => e.AuthenticateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Currentdate).HasColumnType("smalldatetime");

                entity.Property(e => e.DOCHDR_Age).HasMaxLength(50);

                entity.Property(e => e.DOCHDR_AgeFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOCHDR_PID)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOCHDR_Sex).HasMaxLength(50);

                entity.Property(e => e.DOCHDR_dDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DOCHDR_sDescription).HasColumnType("ntext");

                entity.Property(e => e.DOCHDR_sDocNo).HasMaxLength(50);

                entity.Property(e => e.DataEntryDate).HasColumnType("datetime");

                entity.Property(e => e.DataEntryUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailDate).HasColumnType("datetime");

                entity.Property(e => e.EmailUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HOSPTYPE).HasMaxLength(50);

                entity.Property(e => e.IntegrationDate).HasColumnType("datetime");

                entity.Property(e => e.IsProfile)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Lable_Sample)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MarkComplete).HasMaxLength(1);

                entity.Property(e => e.PDFDate).HasColumnType("datetime");

                entity.Property(e => e.PDFUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrintDate).HasColumnType("datetime");

                entity.Property(e => e.PrintUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegistationDate).HasColumnType("datetime");

                entity.Property(e => e.RegistationUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RequestDate).HasColumnType("date");

                entity.Property(e => e.RequestUser)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RerunDate).HasColumnType("datetime");

                entity.Property(e => e.RerunUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResampleDate).HasColumnType("datetime");

                entity.Property(e => e.ResampleUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SampleReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.SampleReceivedRemark)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SampleReceivedUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sample_Date).HasColumnType("smalldatetime");

                entity.Property(e => e.ValidateDate).HasColumnType("datetime");

                entity.Property(e => e.ValidateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WardNo).HasMaxLength(50);

                entity.Property(e => e.isAllResRec).HasDefaultValueSql("((0))");

                entity.Property(e => e.issampleReceived).HasDefaultValueSql("((0))");

                entity.Property(e => e.issent).HasDefaultValueSql("((0))");

                entity.Property(e => e.userid).HasMaxLength(50);
            });

            modelBuilder.Entity<DOCHDR_HISTORY>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoID).ValueGeneratedOnAdd();

                entity.Property(e => e.Currentdate).HasColumnType("smalldatetime");

                entity.Property(e => e.DOCHDR_Age).HasMaxLength(50);

                entity.Property(e => e.DOCHDR_AgeFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOCHDR_PID)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOCHDR_Sex).HasMaxLength(50);

                entity.Property(e => e.DOCHDR_dDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DOCHDR_sDescription).HasColumnType("ntext");

                entity.Property(e => e.DOCHDR_sDocNo).HasMaxLength(50);

                entity.Property(e => e.HOSPTYPE).HasMaxLength(50);

                entity.Property(e => e.IsProfile)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MarkComplete).HasMaxLength(1);

                entity.Property(e => e.Sample_Date).HasColumnType("smalldatetime");

                entity.Property(e => e.WardNo).HasMaxLength(50);

                entity.Property(e => e.flag_u)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.isAllResRec).HasDefaultValueSql("(0)");

                entity.Property(e => e.issampleReceived).HasDefaultValueSql("(0)");

                entity.Property(e => e.issent).HasDefaultValueSql("(0)");

                entity.Property(e => e.userid).HasMaxLength(50);
            });

            modelBuilder.Entity<DOCTOR>(entity =>
            {
                entity.HasKey(e => e.DOCTOR_id);

                entity.HasIndex(e => e.DOCTOR_Name)
                    .HasName("IX_DOCTOR_Name");

                entity.Property(e => e.DOCTOR_id).ValueGeneratedNever();

                entity.Property(e => e.Collection_Center).HasMaxLength(255);

                entity.Property(e => e.DOB).HasColumnType("datetime");

                entity.Property(e => e.DOCTOR_Address1).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_Address2).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_Bill).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_City).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_EX1Commission).HasDefaultValueSql("((0))");

                entity.Property(e => e.DOCTOR_EXCommission).HasDefaultValueSql("((0))");

                entity.Property(e => e.DOCTOR_Email).HasMaxLength(100);

                entity.Property(e => e.DOCTOR_HCommission).HasDefaultValueSql("((0))");

                entity.Property(e => e.DOCTOR_MCommission).HasDefaultValueSql("((0))");

                entity.Property(e => e.DOCTOR_MobileNo).HasMaxLength(50);

                entity.Property(e => e.DOCTOR_Name).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_OCommission).HasDefaultValueSql("((0))");

                entity.Property(e => e.DOCTOR_PFCommission).HasDefaultValueSql("((0))");

                entity.Property(e => e.DOCTOR_Password)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DOCTOR_Pincode).HasMaxLength(50);

                entity.Property(e => e.DOCTOR_Qualification).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_RCommission).HasDefaultValueSql("((0))");

                entity.Property(e => e.DOCTOR_SPCommission).HasDefaultValueSql("((0))");

                entity.Property(e => e.DOCTOR_State).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_Telno).HasMaxLength(50);

                entity.Property(e => e.DOCTOR_UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OFFICE_Address1).HasMaxLength(255);

                entity.Property(e => e.OFFICE_Address2).HasMaxLength(255);

                entity.Property(e => e.OFFICE_City).HasMaxLength(50);

                entity.Property(e => e.OFFICE_Country).HasMaxLength(50);

                entity.Property(e => e.OFFICE_Pincode).HasMaxLength(50);

                entity.Property(e => e.OFFICE_Region).HasMaxLength(50);

                entity.Property(e => e.OFFICE_State).HasMaxLength(50);

                entity.Property(e => e.OFFICE_Telno).HasMaxLength(50);

                entity.Property(e => e.OFFICE_url).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.TDS).HasMaxLength(255);

                entity.Property(e => e.doctor_Code)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DOCTORBK>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DOB).HasColumnType("datetime");

                entity.Property(e => e.DOCTOR_Address1).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_Address2).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_City).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_Country).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_Email).HasMaxLength(50);

                entity.Property(e => e.DOCTOR_MobileNo).HasMaxLength(50);

                entity.Property(e => e.DOCTOR_Name).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_Password)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DOCTOR_Permanent)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.DOCTOR_Pincode).HasMaxLength(50);

                entity.Property(e => e.DOCTOR_Qualification).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_Region).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_State).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_Telno).HasMaxLength(50);

                entity.Property(e => e.DOCTOR_UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OFFICE_Address1).HasMaxLength(255);

                entity.Property(e => e.OFFICE_Address2).HasMaxLength(255);

                entity.Property(e => e.OFFICE_City).HasMaxLength(50);

                entity.Property(e => e.OFFICE_Country).HasMaxLength(50);

                entity.Property(e => e.OFFICE_Pincode).HasMaxLength(50);

                entity.Property(e => e.OFFICE_Region).HasMaxLength(50);

                entity.Property(e => e.OFFICE_State).HasMaxLength(50);

                entity.Property(e => e.OFFICE_Telno).HasMaxLength(50);

                entity.Property(e => e.OFFICE_url).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.doctor_Code)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EMPLOYEE>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.EMPLOYEE_Address1).HasMaxLength(255);

                entity.Property(e => e.EMPLOYEE_Address2).HasMaxLength(255);

                entity.Property(e => e.EMPLOYEE_City).HasMaxLength(255);

                entity.Property(e => e.EMPLOYEE_Country).HasMaxLength(255);

                entity.Property(e => e.EMPLOYEE_DateofBirth).HasColumnType("smalldatetime");

                entity.Property(e => e.EMPLOYEE_DateofJoining).HasColumnType("smalldatetime");

                entity.Property(e => e.EMPLOYEE_Email).HasMaxLength(50);

                entity.Property(e => e.EMPLOYEE_MobileNo).HasMaxLength(50);

                entity.Property(e => e.EMPLOYEE_Name).HasMaxLength(255);

                entity.Property(e => e.EMPLOYEE_Pincode).HasMaxLength(255);

                entity.Property(e => e.EMPLOYEE_Qualification).HasMaxLength(255);

                entity.Property(e => e.EMPLOYEE_Region).HasMaxLength(255);

                entity.Property(e => e.EMPLOYEE_SalaryType).HasMaxLength(1);

                entity.Property(e => e.EMPLOYEE_State).HasMaxLength(255);

                entity.Property(e => e.EMPLOYEE_Telno).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);
            });

            modelBuilder.Entity<EmailLog>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.Docid, e.Type })
                    .HasName("IX_EmailLog_docidtype");

                entity.Property(e => e.SysDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeWithCollectionCenterMap>(entity =>
            {
                entity.Property(e => e.CenterName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeContact).HasMaxLength(50);

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SysDatetime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<GROUPDET>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Auto_Id)
                    .HasColumnName("Auto Id")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HISTOGRAM>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.LAB_DATE).HasColumnType("datetime");

                entity.Property(e => e.PLT_HISTO).HasColumnType("image");

                entity.Property(e => e.RBC_HISTO).HasColumnType("image");

                entity.Property(e => e.SRNO)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.STATUS)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WBC_HISTO).HasColumnType("image");
            });

            modelBuilder.Entity<HomevisitImage>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.HomeVisitId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ImageString)
                    .IsRequired()
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<INTGDET>(entity =>
            {
                entity.HasIndex(e => e.HeaderId)
                    .HasName("INTGDET_dochdrid");

                entity.Property(e => e.FieldValue).HasMaxLength(255);

                entity.Property(e => e.sysDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<LABELGROUP>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Active)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GRPNAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Prefix)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");
            });

            modelBuilder.Entity<LabMST>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.LabAddress)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LabCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LabContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LabEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LabName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LabWebserviceURL)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<LabMaster>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.LabCode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(2)");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Userid).HasMaxLength(50);
            });

            modelBuilder.Entity<MYLAB_TEST_DETAILS>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ID).ValueGeneratedOnAdd();

                entity.Property(e => e.TEST_NAME)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TYPE)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MYLAB_TEST_DETAILS_BA200>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ID).ValueGeneratedOnAdd();

                entity.Property(e => e.TEST_NAME)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TYPE)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MetroEmailLog>(entity =>
            {
                entity.HasKey(e => e.Logid)
                    .HasName("PK_MetroEmailLog_1");

                entity.Property(e => e.PDFName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SysDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Time)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VID)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NARRATIONS>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.NarrationText).HasColumnType("ntext");
            });

            modelBuilder.Entity<NEXTGENDATA>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BAS_PER).HasMaxLength(255);

                entity.Property(e => e.EOS_PER).HasMaxLength(255);

                entity.Property(e => e.GRAN_NUM).HasMaxLength(255);

                entity.Property(e => e.GRAN_PER).HasMaxLength(255);

                entity.Property(e => e.HCT).HasMaxLength(255);

                entity.Property(e => e.HGB).HasMaxLength(255);

                entity.Property(e => e.LAB_DATE).HasColumnType("datetime");

                entity.Property(e => e.LYMPH_NUM).HasMaxLength(255);

                entity.Property(e => e.LYMPH_PER).HasMaxLength(255);

                entity.Property(e => e.MCH).HasMaxLength(255);

                entity.Property(e => e.MCHC).HasMaxLength(255);

                entity.Property(e => e.MCV).HasMaxLength(255);

                entity.Property(e => e.MID_NUM).HasMaxLength(255);

                entity.Property(e => e.MID_PER).HasMaxLength(255);

                entity.Property(e => e.MON_PER).HasMaxLength(255);

                entity.Property(e => e.MPV).HasMaxLength(255);

                entity.Property(e => e.NEU_PER).HasMaxLength(255);

                entity.Property(e => e.PCT).HasMaxLength(255);

                entity.Property(e => e.PDW).HasMaxLength(255);

                entity.Property(e => e.PLT).HasMaxLength(255);

                entity.Property(e => e.PLT_HISTOGRAM).HasColumnType("image");

                entity.Property(e => e.RBC).HasMaxLength(255);

                entity.Property(e => e.RBC_HISTOGRAM).HasColumnType("image");

                entity.Property(e => e.RDW_CV).HasMaxLength(255);

                entity.Property(e => e.RDW_SD).HasMaxLength(255);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WBC).HasMaxLength(255);

                entity.Property(e => e.WBC_HISTOGRAM).HasColumnType("image");
            });

            modelBuilder.Entity<PATIENT>(entity =>
            {
                entity.HasKey(e => e.PATIENT_id);

                entity.HasIndex(e => e.PATIENT_Date)
                    .HasName("IX_PATIENT_PATIENT_DATE");

                entity.HasIndex(e => e.PATIENT_Doctorid)
                    .HasName("IX_PATIENT_PATIENT_DOCTORID");

                entity.HasIndex(e => e.PATIENT_SampleCollected)
                    .HasName("PATIENT_PATIENT_COLLECTIONCENTER");

                entity.HasIndex(e => e.PATIENT_Telno)
                    .HasName("IX_PATIENT_Telno");

                entity.HasIndex(e => e.labno);

                entity.Property(e => e.PATIENT_id).ValueGeneratedNever();

                entity.Property(e => e.AppointmentId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Currentdate).HasColumnType("smalldatetime");

                entity.Property(e => e.HOSPTYPE).HasMaxLength(50);

                entity.Property(e => e.PATIENT_Address1).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Address2).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Age).HasMaxLength(50);

                entity.Property(e => e.PATIENT_AgeFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('E')");

                entity.Property(e => e.PATIENT_City).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Date).HasColumnType("smalldatetime");

                entity.Property(e => e.PATIENT_Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PATIENT_Gender).HasMaxLength(50);

                entity.Property(e => e.PATIENT_Name).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Pincode).HasMaxLength(50);

                entity.Property(e => e.PATIENT_Region).HasMaxLength(255);

                entity.Property(e => e.PATIENT_State).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Telno).HasMaxLength(50);

                entity.Property(e => e.Patient_key)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrintUrgent).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.Sample_Date).HasColumnType("smalldatetime");

                entity.Property(e => e.TEST_ALIAS).HasColumnType("ntext");

                entity.Property(e => e.WardNo).HasMaxLength(50);

                entity.Property(e => e.blnCommission).HasMaxLength(1);

                entity.Property(e => e.userid).HasMaxLength(50);
            });

            modelBuilder.Entity<PATIENT_BILL_DETAILS>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Bill_Category)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Bill_No).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Bill_date).HasColumnType("datetime");

                entity.Property(e => e.Bill_id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DoctorName1).HasMaxLength(255);

                entity.Property(e => e.DoctorName2).HasMaxLength(255);

                entity.Property(e => e.NEFTPAID).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.PatientBillDetId)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Patient_Age).HasMaxLength(50);

                entity.Property(e => e.Patient_City).HasMaxLength(255);

                entity.Property(e => e.Patient_Collection_Center).HasMaxLength(50);

                entity.Property(e => e.Patient_Country).HasMaxLength(50);

                entity.Property(e => e.Patient_Date).HasColumnType("datetime");

                entity.Property(e => e.Patient_Name).HasMaxLength(255);

                entity.Property(e => e.Patient_Pincode).HasMaxLength(50);

                entity.Property(e => e.Patient_Region).HasMaxLength(255);

                entity.Property(e => e.Patient_Sex).HasMaxLength(50);

                entity.Property(e => e.Patient_State).HasMaxLength(255);

                entity.Property(e => e.Patient_TelNo).HasMaxLength(50);

                entity.Property(e => e.Patient_address1).HasMaxLength(255);

                entity.Property(e => e.Patient_address2).HasMaxLength(255);

                entity.Property(e => e.TestName).HasMaxLength(255);

                entity.Property(e => e.UPIPaid).HasColumnType("decimal(9, 2)");
            });

            modelBuilder.Entity<PATIENT_MASTER>(entity =>
            {
                entity.HasKey(e => e.PATIENT_id);

                entity.HasIndex(e => e.PATIENT_DateofJoining)
                    .HasName("IX_PATIENT_MASTER_dateofjoining");

                entity.HasIndex(e => e.PATIENT_MobileNo)
                    .HasName("IX_PATIENT_MASTER_1");

                entity.HasIndex(e => e.Patient_Code)
                    .HasName("IX_PATIENT_MASTER_patientcode");

                entity.Property(e => e.PATIENT_id).ValueGeneratedNever();

                entity.Property(e => e.PATIENT_Address1).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Address2).HasMaxLength(255);

                entity.Property(e => e.PATIENT_City).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Country).HasMaxLength(255);

                entity.Property(e => e.PATIENT_DateofJoining).HasMaxLength(50);

                entity.Property(e => e.PATIENT_Email).HasMaxLength(50);

                entity.Property(e => e.PATIENT_MobileNo).HasMaxLength(50);

                entity.Property(e => e.PATIENT_Name).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Pincode).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Qualification).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Region).HasMaxLength(255);

                entity.Property(e => e.PATIENT_SalaryType).HasMaxLength(1);

                entity.Property(e => e.PATIENT_State).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Telno).HasMaxLength(50);

                entity.Property(e => e.Patient_Age).HasMaxLength(50);

                entity.Property(e => e.Patient_Code)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Patient_DateofBirth).HasColumnType("datetime");
            });

            modelBuilder.Entity<PATIENT_history>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Currentdate).HasColumnType("smalldatetime");

                entity.Property(e => e.HOSPTYPE).HasMaxLength(50);

                entity.Property(e => e.History_Date)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.History_Id).ValueGeneratedOnAdd();

                entity.Property(e => e.PATIENT_Address1).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Address2).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Age).HasMaxLength(50);

                entity.Property(e => e.PATIENT_AgeFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PATIENT_City).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Country).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Date).HasColumnType("smalldatetime");

                entity.Property(e => e.PATIENT_Gender).HasMaxLength(50);

                entity.Property(e => e.PATIENT_Name).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Pincode).HasMaxLength(50);

                entity.Property(e => e.PATIENT_Region).HasMaxLength(255);

                entity.Property(e => e.PATIENT_State).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Telno).HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.Sample_Date).HasColumnType("smalldatetime");

                entity.Property(e => e.TEST_ALIAS).HasColumnType("ntext");

                entity.Property(e => e.WardNo).HasMaxLength(50);

                entity.Property(e => e.blnCommission).HasMaxLength(1);

                entity.Property(e => e.userid).HasMaxLength(50);
            });

            modelBuilder.Entity<PDFLog>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<PHLEBOMIST_COLLECTED_TEST>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ACCEPTHMVST_ID).HasMaxLength(50);

                entity.Property(e => e.HomeVisitId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ID).ValueGeneratedOnAdd();

                entity.Property(e => e.PATIENT_NAME).HasMaxLength(50);

                entity.Property(e => e.PAtientContact)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PHLEBOTOMIST_ID).HasMaxLength(50);

                entity.Property(e => e.PHLEBOTOMIST_NAME).HasMaxLength(50);

                entity.Property(e => e.SYST_DATE).HasColumnType("datetime");

                entity.Property(e => e.TEST_NAME).HasMaxLength(500);

                entity.Property(e => e.TestID)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TestType).HasMaxLength(50);
            });

            modelBuilder.Entity<PREDEFVAL>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.PREDEFVAL_Value).HasMaxLength(255);
            });

            modelBuilder.Entity<PROFDET>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Param>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DC)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Formula)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ParamChild1Def)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ParamChild1Normal)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ParamChild6Def)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ParamChild6Normal)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ParamChildDef)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ParamChildNormal)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ParamDef2).HasColumnType("ntext");

                entity.Property(e => e.ParamFemaleDef)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ParamFemaleNormal)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ParamFooter).HasColumnType("text");

                entity.Property(e => e.ParamMaleDef)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ParamMaleNormal)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ParamMethod)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ParamName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ParamPrintHead)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ParamRate).HasColumnType("money");

                entity.Property(e => e.ParamType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ParamUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParamValidFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SENDSMS)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Suffix)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ParamHelpValues>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ParamHelpValue).HasColumnType("ntext");
            });

            modelBuilder.Entity<PatientProfilePic>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Contact_Number)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Profile_Pic).HasColumnType("ntext");
            });

            modelBuilder.Entity<Patient_Portal>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.City)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Contact_no).HasMaxLength(50);

                entity.Property(e => e.DOB).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Patient_id).ValueGeneratedOnAdd();

                entity.Property(e => e.Patient_name).HasMaxLength(50);

                entity.Property(e => e.Pincode).HasMaxLength(10);

                entity.Property(e => e.RegDate).HasColumnType("datetime");

                entity.Property(e => e.RowSent)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.age)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayRemDetail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BillAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BillDate).HasColumnType("datetime");

                entity.Property(e => e.Deduction).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Fin_year)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PayRemDetlId).ValueGeneratedOnAdd();

                entity.Property(e => e.RecAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TDS).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<PayRemHeader>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Bill_Type)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RefDate).HasColumnType("datetime");

                entity.Property(e => e.RefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Phelobotomist_HomeVisit>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AREA).HasMaxLength(50);

                entity.Property(e => e.ATTACHMENT).HasMaxLength(50);

                entity.Property(e => e.Age)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BookingDate).HasColumnType("datetime");

                entity.Property(e => e.DECISION).HasMaxLength(50);

                entity.Property(e => e.Discount)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.HomeVisitId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ID).ValueGeneratedOnAdd();

                entity.Property(e => e.NewPheloId).HasMaxLength(50);

                entity.Property(e => e.NewPheloName).HasMaxLength(100);

                entity.Property(e => e.PATIENT_CONTACT).HasMaxLength(50);

                entity.Property(e => e.PATIENT_NAME).HasMaxLength(50);

                entity.Property(e => e.PHLEBOMIST_CONTACT).HasMaxLength(50);

                entity.Property(e => e.PHLEBOMIST_USERNAME).HasMaxLength(50);

                entity.Property(e => e.PatientEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaybleAmount).HasMaxLength(20);

                entity.Property(e => e.PaymentMode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phelobotomist_ID).HasMaxLength(50);

                entity.Property(e => e.REASON).HasMaxLength(50);

                entity.Property(e => e.Reference_Doctor)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SYST_DATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SampleCollected)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TIME).HasMaxLength(50);

                entity.Property(e => e.patient_add)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QER_AMOUNTPAID>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_AMOUNTPAID");
            });

            modelBuilder.Entity<QER_AMOUNTPAIDType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_AMOUNTPAIDType");
            });

            modelBuilder.Entity<QER_BALAMT>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_BALAMT");

                entity.Property(e => e.CENTER_Name).HasMaxLength(255);

                entity.Property(e => e.CENTER_Region).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_MobileNo).HasMaxLength(50);

                entity.Property(e => e.DOCTOR_Name).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Date).HasColumnType("smalldatetime");

                entity.Property(e => e.PATIENT_Name).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Pincode).HasMaxLength(50);

                entity.Property(e => e.TEST_ALIAS).HasColumnType("ntext");
            });

            modelBuilder.Entity<QER_BIDIRECTION>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_BIDIRECTION");

                entity.Property(e => e.DOCHDR_dDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DOCHDR_sDocNo).HasMaxLength(50);

                entity.Property(e => e.DOCTOR_Name).HasMaxLength(255);

                entity.Property(e => e.MarkComplete).HasMaxLength(1);

                entity.Property(e => e.PATIENT_Age).HasMaxLength(50);

                entity.Property(e => e.PATIENT_Gender).HasMaxLength(50);

                entity.Property(e => e.PATIENT_Name).HasMaxLength(255);

                entity.Property(e => e.ProfileName).HasMaxLength(255);

                entity.Property(e => e.Sample_Date).HasColumnType("smalldatetime");

                entity.Property(e => e.TESTMST_Name).HasMaxLength(255);

                entity.Property(e => e.TESTMST_PrintFormat).HasMaxLength(255);

                entity.Property(e => e.Type).HasMaxLength(1);

                entity.Property(e => e.WardNo).HasMaxLength(50);
            });

            modelBuilder.Entity<QER_BILL>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_BILL");

                entity.Property(e => e.Active).HasMaxLength(1);

                entity.Property(e => e.CENTER_Name).HasMaxLength(255);

                entity.Property(e => e.Comments).HasColumnType("ntext");

                entity.Property(e => e.Currentdate).HasColumnType("smalldatetime");

                entity.Property(e => e.DOCTOR_Name).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_Name1).HasMaxLength(255);

                entity.Property(e => e.EMPLOYEE_Name).HasMaxLength(255);

                entity.Property(e => e.HOSPTYPE).HasMaxLength(50);

                entity.Property(e => e.PATIENT_Address1).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Address2).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Age).HasMaxLength(50);

                entity.Property(e => e.PATIENT_AgeFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PATIENT_City).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Date).HasColumnType("smalldatetime");

                entity.Property(e => e.PATIENT_Gender).HasMaxLength(50);

                entity.Property(e => e.PATIENT_Name).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Pincode).HasMaxLength(50);

                entity.Property(e => e.PATIENT_Region).HasMaxLength(255);

                entity.Property(e => e.PATIENT_State).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Telno).HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.Sample_Date).HasColumnType("smalldatetime");

                entity.Property(e => e.SpecialTest).HasMaxLength(1);

                entity.Property(e => e.TESTMST_Alias).HasMaxLength(50);

                entity.Property(e => e.TESTMST_CatType).HasMaxLength(3);

                entity.Property(e => e.TESTMST_Name).HasMaxLength(255);

                entity.Property(e => e.TESTMST_PrintFormat).HasMaxLength(255);

                entity.Property(e => e.TESTMST_ReportHeading).HasMaxLength(255);

                entity.Property(e => e.TESTMST_sample)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TEST_ALIAS).HasColumnType("ntext");

                entity.Property(e => e.Type).HasMaxLength(1);

                entity.Property(e => e.WardNo).HasMaxLength(50);

                entity.Property(e => e.blnCommission).HasMaxLength(1);

                entity.Property(e => e.userid).HasMaxLength(50);
            });

            modelBuilder.Entity<QER_CBC_WorkSheet>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_CBC_WorkSheet");

                entity.Property(e => e.DOCDET_tFieldValue).HasMaxLength(255);

                entity.Property(e => e.DOCHDR_Age).HasMaxLength(50);

                entity.Property(e => e.DOCHDR_Sex).HasMaxLength(50);

                entity.Property(e => e.DOCHDR_dDate).HasColumnType("smalldatetime");

                entity.Property(e => e.PATIENT_Name).HasMaxLength(255);

                entity.Property(e => e.TESTDET_FieldName).HasMaxLength(255);

                entity.Property(e => e.TESTDET_sAlias).HasMaxLength(50);
            });

            modelBuilder.Entity<QER_COLLECTION>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_COLLECTION");

                entity.Property(e => e.DOCHDR_dDate).HasColumnType("smalldatetime");

                entity.Property(e => e.IsProfile)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TESTMST_Alias).HasMaxLength(50);

                entity.Property(e => e.TESTMST_Name).HasMaxLength(255);
            });

            modelBuilder.Entity<QER_COMPARERATE>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_COMPARERATE");

                entity.Property(e => e.CENTER_Name).HasMaxLength(255);

                entity.Property(e => e.TESTMST_Name).HasMaxLength(255);

                entity.Property(e => e.Type).HasMaxLength(1);
            });

            modelBuilder.Entity<QER_DAILYREGISTER>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_DAILYREGISTER");

                entity.Property(e => e.CENTER_Name).HasMaxLength(255);

                entity.Property(e => e.Currentdate).HasColumnType("smalldatetime");

                entity.Property(e => e.DOCTOR_Name).HasMaxLength(255);

                entity.Property(e => e.HOSPTYPE).HasMaxLength(50);

                entity.Property(e => e.PATIENT_Address1).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Address2).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Age).HasMaxLength(50);

                entity.Property(e => e.PATIENT_AgeFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PATIENT_City).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Date).HasColumnType("smalldatetime");

                entity.Property(e => e.PATIENT_Gender).HasMaxLength(50);

                entity.Property(e => e.PATIENT_Name).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Pincode).HasMaxLength(50);

                entity.Property(e => e.PATIENT_Region).HasMaxLength(255);

                entity.Property(e => e.PATIENT_State).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Telno).HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.Sample_Date).HasColumnType("smalldatetime");

                entity.Property(e => e.TEST_ALIAS).HasColumnType("ntext");

                entity.Property(e => e.WardNo).HasMaxLength(50);

                entity.Property(e => e.blnCommission).HasMaxLength(1);

                entity.Property(e => e.userid).HasMaxLength(50);
            });

            modelBuilder.Entity<QER_DAILYREGREFUND>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_DAILYREGREFUND");

                entity.Property(e => e.CENTER_Name).HasMaxLength(255);

                entity.Property(e => e.Currentdate).HasColumnType("smalldatetime");

                entity.Property(e => e.DOCTOR_Name).HasMaxLength(255);

                entity.Property(e => e.HOSPTYPE).HasMaxLength(50);

                entity.Property(e => e.PATIENT_Address1).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Address2).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Age).HasMaxLength(50);

                entity.Property(e => e.PATIENT_AgeFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PATIENT_City).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Date).HasColumnType("smalldatetime");

                entity.Property(e => e.PATIENT_Gender).HasMaxLength(50);

                entity.Property(e => e.PATIENT_Name).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Pincode).HasMaxLength(50);

                entity.Property(e => e.PATIENT_Region).HasMaxLength(255);

                entity.Property(e => e.PATIENT_State).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Telno).HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.Sample_Date).HasColumnType("smalldatetime");

                entity.Property(e => e.TEST_ALIAS).HasColumnType("ntext");

                entity.Property(e => e.WardNo).HasMaxLength(50);

                entity.Property(e => e.blnCommission).HasMaxLength(1);

                entity.Property(e => e.userid).HasMaxLength(50);
            });

            modelBuilder.Entity<QER_DISPATCHREGISTER>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_DISPATCHREGISTER");

                entity.Property(e => e.CENTER_Name).HasMaxLength(255);

                entity.Property(e => e.CENTER_Region).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_Name).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_Name2).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_Region).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Date).HasColumnType("smalldatetime");

                entity.Property(e => e.PATIENT_Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PATIENT_Name).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Pincode).HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.TEST_ALIAS).HasColumnType("ntext");

                entity.Property(e => e.blnCommission).HasMaxLength(1);

                entity.Property(e => e.userid).HasMaxLength(50);
            });

            modelBuilder.Entity<QER_DOCTORLIST>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_DOCTORLIST");

                entity.Property(e => e.CENTER_Name).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_Email).HasMaxLength(50);

                entity.Property(e => e.DOCTOR_MobileNo).HasMaxLength(50);

                entity.Property(e => e.DOCTOR_Name).HasMaxLength(255);
            });

            modelBuilder.Entity<QER_DOCTORWISE_COMMISSION>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_DOCTORWISE_COMMISSION");

                entity.Property(e => e.CENTER_Name).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_Name).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Date).HasColumnType("smalldatetime");

                entity.Property(e => e.PATIENT_Name).HasMaxLength(255);

                entity.Property(e => e.SpecialTest).HasMaxLength(1);

                entity.Property(e => e.TESTMST_CatType).HasMaxLength(3);

                entity.Property(e => e.TESTMST_Name).HasMaxLength(255);

                entity.Property(e => e.WardNo).HasMaxLength(50);
            });

            modelBuilder.Entity<QER_DOCTORWISE_COMMISSION_OLD>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_DOCTORWISE_COMMISSION_OLD");

                entity.Property(e => e.CENTER_Name).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_Name).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Date).HasColumnType("smalldatetime");

                entity.Property(e => e.PATIENT_Name).HasMaxLength(255);

                entity.Property(e => e.SpecialTest).HasMaxLength(1);

                entity.Property(e => e.TESTMST_CATTYPE).HasMaxLength(3);

                entity.Property(e => e.TESTMST_Name).HasMaxLength(255);

                entity.Property(e => e.WardNo).HasMaxLength(50);
            });

            modelBuilder.Entity<QER_DOCTOR_COMM>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_DOCTOR_COMM");

                entity.Property(e => e.CENTER_Name).HasMaxLength(255);

                entity.Property(e => e.DOCHDR_dDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DOCHDR_sDocNo).HasMaxLength(50);

                entity.Property(e => e.DOCTOR_Name).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Date).HasColumnType("smalldatetime");

                entity.Property(e => e.PATIENT_Name).HasMaxLength(255);

                entity.Property(e => e.TESTMST_Name).HasMaxLength(255);

                entity.Property(e => e.Type).HasMaxLength(1);

                entity.Property(e => e.WardNo).HasMaxLength(50);
            });

            modelBuilder.Entity<QER_DOCTOR_COMMISSION>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_DOCTOR_COMMISSION");

                entity.Property(e => e.CENTER_Name).HasMaxLength(255);

                entity.Property(e => e.CENTER_Region).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_Address1).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_City).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_Name).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_Region).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_State).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Date).HasColumnType("smalldatetime");

                entity.Property(e => e.PATIENT_Name).HasMaxLength(255);

                entity.Property(e => e.SpecialTest).HasMaxLength(1);

                entity.Property(e => e.TESTMST_Alias).HasMaxLength(50);

                entity.Property(e => e.WardNo).HasMaxLength(50);
            });

            modelBuilder.Entity<QER_DOCTOR_COMMISSION_OLD>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_DOCTOR_COMMISSION_OLD");

                entity.Property(e => e.CENTER_Name).HasMaxLength(255);

                entity.Property(e => e.CENTER_Region).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_Name).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Date).HasColumnType("smalldatetime");

                entity.Property(e => e.PATIENT_Name).HasMaxLength(255);

                entity.Property(e => e.SpecialTest).HasMaxLength(1);

                entity.Property(e => e.TESTMST_Alias).HasMaxLength(50);

                entity.Property(e => e.WardNo).HasMaxLength(50);
            });

            modelBuilder.Entity<QER_FILLDATA>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_FILLDATA");

                entity.Property(e => e.CENTER_Name).HasMaxLength(255);

                entity.Property(e => e.DOCHDR_dDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DOCHDR_sDocNo).HasMaxLength(50);

                entity.Property(e => e.DOCTOR_MobileNo).HasMaxLength(50);

                entity.Property(e => e.DOCTOR_Name).HasMaxLength(255);

                entity.Property(e => e.EmailDate).HasColumnType("datetime");

                entity.Property(e => e.MarkComplete).HasMaxLength(1);

                entity.Property(e => e.PATIENT_Name).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Telno).HasMaxLength(50);

                entity.Property(e => e.ProfileName).HasMaxLength(255);

                entity.Property(e => e.TESTMST_Name).HasMaxLength(255);

                entity.Property(e => e.TESTMST_PrintFormat).HasMaxLength(255);

                entity.Property(e => e.Type).HasMaxLength(1);

                entity.Property(e => e.WardNo).HasMaxLength(50);
            });

            modelBuilder.Entity<QER_FOR_MYPATHTEST>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_FOR_MYPATHTEST");

                entity.Property(e => e.Active).HasMaxLength(1);

                entity.Property(e => e.CENTER_Name).HasMaxLength(255);

                entity.Property(e => e.COMPANY_CardDegree1).HasMaxLength(100);

                entity.Property(e => e.COMPANY_CardDegree2).HasMaxLength(100);

                entity.Property(e => e.COMPANY_Cardiologist1).HasMaxLength(100);

                entity.Property(e => e.COMPANY_Cardiologist2).HasMaxLength(100);

                entity.Property(e => e.COMPANY_PathoDegree1).HasMaxLength(100);

                entity.Property(e => e.COMPANY_PathoDegree2).HasMaxLength(100);

                entity.Property(e => e.COMPANY_Pathologist1).HasMaxLength(100);

                entity.Property(e => e.COMPANY_Pathologist2).HasMaxLength(100);

                entity.Property(e => e.COMPANY_RadDegree1).HasMaxLength(100);

                entity.Property(e => e.COMPANY_RadDegree2).HasMaxLength(100);

                entity.Property(e => e.COMPANY_Radiologist1).HasMaxLength(100);

                entity.Property(e => e.COMPANY_Radiologist2).HasMaxLength(100);

                entity.Property(e => e.Comments).HasColumnType("ntext");

                entity.Property(e => e.Currentdate).HasColumnType("smalldatetime");

                entity.Property(e => e.DOC2).HasMaxLength(255);

                entity.Property(e => e.DOCDET_tFieldValue).HasMaxLength(255);

                entity.Property(e => e.DOCDET_tFieldValue1).HasColumnType("ntext");

                entity.Property(e => e.DOCHDR_Age).HasMaxLength(50);

                entity.Property(e => e.DOCHDR_PID)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOCHDR_Sex).HasMaxLength(50);

                entity.Property(e => e.DOCHDR_dDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DOCHDR_sDescription).HasColumnType("ntext");

                entity.Property(e => e.DOCHDR_sDocNo).HasMaxLength(50);

                entity.Property(e => e.DOCTOR_Address1).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_Address2).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_City).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_Country).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_Email).HasMaxLength(50);

                entity.Property(e => e.DOCTOR_MobileNo).HasMaxLength(50);

                entity.Property(e => e.DOCTOR_Name).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_Permanent).HasMaxLength(1);

                entity.Property(e => e.DOCTOR_Pincode).HasMaxLength(50);

                entity.Property(e => e.DOCTOR_Qualification).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_Region).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_State).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_Telno).HasMaxLength(50);

                entity.Property(e => e.EMPLOYEE_Name).HasMaxLength(255);

                entity.Property(e => e.HOSPTYPE).HasMaxLength(50);

                entity.Property(e => e.IsProfile)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MarkComplete).HasMaxLength(1);

                entity.Property(e => e.OFFICE_Address1).HasMaxLength(255);

                entity.Property(e => e.OFFICE_Address2).HasMaxLength(255);

                entity.Property(e => e.OFFICE_City).HasMaxLength(50);

                entity.Property(e => e.OFFICE_Country).HasMaxLength(50);

                entity.Property(e => e.OFFICE_Pincode).HasMaxLength(50);

                entity.Property(e => e.OFFICE_Region).HasMaxLength(50);

                entity.Property(e => e.OFFICE_State).HasMaxLength(50);

                entity.Property(e => e.OFFICE_Telno).HasMaxLength(50);

                entity.Property(e => e.OFFICE_url).HasMaxLength(50);

                entity.Property(e => e.PATIENT_Address1).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Address2).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Age).HasMaxLength(50);

                entity.Property(e => e.PATIENT_City).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Date).HasColumnType("smalldatetime");

                entity.Property(e => e.PATIENT_Gender).HasMaxLength(50);

                entity.Property(e => e.PATIENT_Name).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Pincode).HasMaxLength(50);

                entity.Property(e => e.PATIENT_Region).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Sample).HasColumnType("smalldatetime");

                entity.Property(e => e.PATIENT_State).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Telno).HasMaxLength(50);

                entity.Property(e => e.PLT).HasColumnType("image");

                entity.Property(e => e.RBC_HISTO).HasColumnType("image");

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.Sample_Date).HasColumnType("smalldatetime");

                entity.Property(e => e.SpecialTest).HasMaxLength(1);

                entity.Property(e => e.TESTDET_Description).HasMaxLength(255);

                entity.Property(e => e.TESTDET_FieldName).HasMaxLength(255);

                entity.Property(e => e.TESTDET_GroupName).HasMaxLength(255);

                entity.Property(e => e.TESTDET_NormalValue).HasMaxLength(255);

                entity.Property(e => e.TESTDET_sAlias).HasMaxLength(50);

                entity.Property(e => e.TESTDET_sDefault).HasColumnType("ntext");

                entity.Property(e => e.TESTDET_sFormula).HasMaxLength(50);

                entity.Property(e => e.TESTDET_sUnit).HasMaxLength(50);

                entity.Property(e => e.TESTMST_Alias).HasMaxLength(50);

                entity.Property(e => e.TESTMST_CatType).HasMaxLength(3);

                entity.Property(e => e.TESTMST_Name).HasMaxLength(255);

                entity.Property(e => e.TESTMST_PrintFormat).HasMaxLength(255);

                entity.Property(e => e.TESTMST_ReportHeading).HasMaxLength(255);

                entity.Property(e => e.TESTMST_sample)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Type).HasMaxLength(1);

                entity.Property(e => e.ValidateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WBC).HasColumnType("image");

                entity.Property(e => e.WardNo).HasMaxLength(50);

                entity.Property(e => e.docq2).HasMaxLength(255);

                entity.Property(e => e.userid).HasMaxLength(50);
            });

            modelBuilder.Entity<QER_PATIENT>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_PATIENT");

                entity.Property(e => e.CENTER_Name).HasMaxLength(255);

                entity.Property(e => e.Currentdate).HasColumnType("smalldatetime");

                entity.Property(e => e.DOCTOR_Name).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_Name1).HasMaxLength(255);

                entity.Property(e => e.HOSPTYPE).HasMaxLength(50);

                entity.Property(e => e.PATIENT_Address1).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Address2).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Age).HasMaxLength(50);

                entity.Property(e => e.PATIENT_AgeFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PATIENT_City).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Date).HasColumnType("smalldatetime");

                entity.Property(e => e.PATIENT_Gender).HasMaxLength(50);

                entity.Property(e => e.PATIENT_Name).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Pincode).HasMaxLength(50);

                entity.Property(e => e.PATIENT_Region).HasMaxLength(255);

                entity.Property(e => e.PATIENT_State).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Telno).HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.Sample_Date).HasColumnType("smalldatetime");

                entity.Property(e => e.TEST_ALIAS).HasColumnType("ntext");

                entity.Property(e => e.WardNo).HasMaxLength(50);

                entity.Property(e => e.blnCommission).HasMaxLength(1);

                entity.Property(e => e.userid).HasMaxLength(50);
            });

            modelBuilder.Entity<QER_PATIENTREPORT>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_PATIENTREPORT");

                entity.Property(e => e.Active).HasMaxLength(1);

                entity.Property(e => e.AuntheticateDate).HasColumnType("datetime");

                entity.Property(e => e.AuthenticateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CENTER_Name).HasMaxLength(255);

                entity.Property(e => e.Comments).HasColumnType("ntext");

                entity.Property(e => e.Currentdate).HasColumnType("smalldatetime");

                entity.Property(e => e.DOB).HasColumnType("datetime");

                entity.Property(e => e.DOCHDR_Age).HasMaxLength(50);

                entity.Property(e => e.DOCHDR_Sex).HasMaxLength(50);

                entity.Property(e => e.DOCHDR_dDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DOCHDR_sDescription).HasColumnType("ntext");

                entity.Property(e => e.DOCHDR_sDocNo).HasMaxLength(50);

                entity.Property(e => e.DOCTOR_Address1).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_Address2).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_City).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_Country).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_Email).HasMaxLength(50);

                entity.Property(e => e.DOCTOR_MobileNo).HasMaxLength(50);

                entity.Property(e => e.DOCTOR_Name).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_Password)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DOCTOR_Permanent).HasMaxLength(1);

                entity.Property(e => e.DOCTOR_Pincode).HasMaxLength(50);

                entity.Property(e => e.DOCTOR_Qualification).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_Region).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_State).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_Telno).HasMaxLength(50);

                entity.Property(e => e.DOCTOR_UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataEntryDate).HasColumnType("datetime");

                entity.Property(e => e.DataEntryUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EMPLOYEE_Name).HasMaxLength(255);

                entity.Property(e => e.EmailDate).HasColumnType("datetime");

                entity.Property(e => e.EmailUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HOSPTYPE).HasMaxLength(50);

                entity.Property(e => e.IntegrationDate).HasColumnType("datetime");

                entity.Property(e => e.IsKitImageCompulsary)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsProfile)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Lable_Sample)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MarkComplete).HasMaxLength(1);

                entity.Property(e => e.OFFICE_Address1).HasMaxLength(255);

                entity.Property(e => e.OFFICE_Address2).HasMaxLength(255);

                entity.Property(e => e.OFFICE_City).HasMaxLength(50);

                entity.Property(e => e.OFFICE_Country).HasMaxLength(50);

                entity.Property(e => e.OFFICE_Pincode).HasMaxLength(50);

                entity.Property(e => e.OFFICE_Region).HasMaxLength(50);

                entity.Property(e => e.OFFICE_State).HasMaxLength(50);

                entity.Property(e => e.OFFICE_Telno).HasMaxLength(50);

                entity.Property(e => e.OFFICE_url).HasMaxLength(50);

                entity.Property(e => e.PATIENT_Address1).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Address2).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Age).HasMaxLength(50);

                entity.Property(e => e.PATIENT_AgeFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PATIENT_City).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Date).HasColumnType("smalldatetime");

                entity.Property(e => e.PATIENT_Gender).HasMaxLength(50);

                entity.Property(e => e.PATIENT_Name).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Pincode).HasMaxLength(50);

                entity.Property(e => e.PATIENT_Region).HasMaxLength(255);

                entity.Property(e => e.PATIENT_State).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Telno).HasMaxLength(50);

                entity.Property(e => e.PDFDate).HasColumnType("datetime");

                entity.Property(e => e.PDFUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.PrintDate).HasColumnType("datetime");

                entity.Property(e => e.PrintUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegistationDate).HasColumnType("datetime");

                entity.Property(e => e.RegistationUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.RequestDate).HasColumnType("date");

                entity.Property(e => e.RequestUser)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RerunDate).HasColumnType("datetime");

                entity.Property(e => e.RerunUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResampleDate).HasColumnType("datetime");

                entity.Property(e => e.ResampleUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SampleReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.SampleReceivedRemark)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SampleReceivedUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sample_Date).HasColumnType("smalldatetime");

                entity.Property(e => e.SpecialTest).HasMaxLength(1);

                entity.Property(e => e.TESTMST_Alias).HasMaxLength(50);

                entity.Property(e => e.TESTMST_CatType).HasMaxLength(3);

                entity.Property(e => e.TESTMST_Name).HasMaxLength(255);

                entity.Property(e => e.TESTMST_PrintFormat).HasMaxLength(255);

                entity.Property(e => e.TESTMST_ReportHeading).HasMaxLength(255);

                entity.Property(e => e.TESTMST_sample)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TEST_ALIAS).HasColumnType("ntext");

                entity.Property(e => e.TestTypeName).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(1);

                entity.Property(e => e.ValidateDate).HasColumnType("datetime");

                entity.Property(e => e.ValidateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WardNo).HasMaxLength(50);

                entity.Property(e => e.blnCommission).HasMaxLength(1);

                entity.Property(e => e.doctor_Code)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.userid).HasMaxLength(50);
            });

            modelBuilder.Entity<QER_PATIENTTYPE>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_PATIENTTYPE");

                entity.Property(e => e.Center_Name).HasMaxLength(255);

                entity.Property(e => e.CurrentDate).HasColumnType("smalldatetime");

                entity.Property(e => e.HOSPTYPE).HasMaxLength(50);

                entity.Property(e => e.NAME).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Age).HasMaxLength(50);

                entity.Property(e => e.PATIENT_Date).HasColumnType("smalldatetime");

                entity.Property(e => e.PATIENT_Gender).HasMaxLength(50);

                entity.Property(e => e.PATIENT_Pincode).HasMaxLength(50);

                entity.Property(e => e.PATIENT_Region).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Telno).HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.Sample_Date).HasColumnType("smalldatetime");

                entity.Property(e => e.TYPE).HasMaxLength(50);

                entity.Property(e => e.paymode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.userid).HasMaxLength(50);
            });

            modelBuilder.Entity<QER_PATIENT_HISTORY>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_PATIENT_HISTORY");

                entity.Property(e => e.Currentdate).HasColumnType("smalldatetime");

                entity.Property(e => e.History_date).HasColumnType("datetime");

                entity.Property(e => e.PATIENT_Date).HasColumnType("smalldatetime");

                entity.Property(e => e.PATIENT_Name).HasMaxLength(255);

                entity.Property(e => e.PATIENT_State).HasMaxLength(255);

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.TESTMST_Name).HasMaxLength(255);

                entity.Property(e => e.flag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.userid).HasMaxLength(50);
            });

            modelBuilder.Entity<QER_PAYMENTS>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_PAYMENTS");

                entity.Property(e => e.CENTER_Name).HasMaxLength(255);

                entity.Property(e => e.CENTER_Region).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_Name).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Date).HasColumnType("smalldatetime");

                entity.Property(e => e.PATIENT_Name).HasMaxLength(255);
            });

            modelBuilder.Entity<QER_PAYMENTSTYPE>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_PAYMENTSTYPE");

                entity.Property(e => e.CENTER_Name).HasMaxLength(255);

                entity.Property(e => e.CENTER_Region).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_Name).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Date).HasColumnType("smalldatetime");

                entity.Property(e => e.PATIENT_Name).HasMaxLength(255);
            });

            modelBuilder.Entity<QER_PENDING_TEST>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_PENDING_TEST");

                entity.Property(e => e.DOCHDR_dDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DOCTOR_Name).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Name).HasMaxLength(255);

                entity.Property(e => e.TESTMST_Name).HasMaxLength(255);
            });

            modelBuilder.Entity<QER_PendingTestsNew>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_PendingTestsNew");

                entity.Property(e => e.TESTMST_Alias).HasMaxLength(50);

                entity.Property(e => e.TESTMST_Name).HasMaxLength(255);

                entity.Property(e => e.Type).HasMaxLength(1);
            });

            modelBuilder.Entity<QER_RATELIST>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_RATELIST");

                entity.Property(e => e.TESTMST_Name).HasMaxLength(255);

                entity.Property(e => e.TestTypeName).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(1);
            });

            modelBuilder.Entity<QER_REFUNDAMOUNT>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_REFUNDAMOUNT");
            });

            modelBuilder.Entity<QER_RESULTREGISTER>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_RESULTREGISTER");

                entity.Property(e => e.TESTDET_FieldName).HasMaxLength(255);

                entity.Property(e => e.TESTDET_sAlias).HasMaxLength(50);

                entity.Property(e => e.TESTMST_Name).HasMaxLength(255);

                entity.Property(e => e.TestTypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<QER_RESULTREGISTER1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_RESULTREGISTER1");

                entity.Property(e => e.TESTDET_FieldName).HasMaxLength(255);

                entity.Property(e => e.TESTDET_sAlias).HasMaxLength(50);

                entity.Property(e => e.TESTMST_Name).HasMaxLength(255);
            });

            modelBuilder.Entity<QER_RESULTREGISTER2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_RESULTREGISTER2");

                entity.Property(e => e.TESTDET_FieldName).HasMaxLength(255);

                entity.Property(e => e.TESTDET_sAlias).HasMaxLength(50);

                entity.Property(e => e.TESTMST_Name).HasMaxLength(255);

                entity.Property(e => e.TestTypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<QER_RESULTREGISTERREPORT>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_RESULTREGISTERREPORT");

                entity.Property(e => e.AuntheticateDate).HasColumnType("datetime");

                entity.Property(e => e.AuthenticateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CENTER_Name).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_Name).HasMaxLength(255);

                entity.Property(e => e.DataEntryDate).HasColumnType("datetime");

                entity.Property(e => e.DataEntryUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PATIENT_Age).HasMaxLength(50);

                entity.Property(e => e.PATIENT_Date).HasColumnType("smalldatetime");

                entity.Property(e => e.PATIENT_Gender).HasMaxLength(50);

                entity.Property(e => e.PATIENT_Name).HasMaxLength(255);

                entity.Property(e => e.PrintDate).HasColumnType("datetime");

                entity.Property(e => e.PrintUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegistationDate).HasColumnType("datetime");

                entity.Property(e => e.RegistationUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RerunDate).HasColumnType("datetime");

                entity.Property(e => e.RerunUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResampleDate).HasColumnType("datetime");

                entity.Property(e => e.ResampleUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SampleReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.SampleReceivedUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TestTypeName).HasMaxLength(50);

                entity.Property(e => e.ValidateDate).HasColumnType("datetime");

                entity.Property(e => e.ValidateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.rs).HasMaxLength(308);
            });

            modelBuilder.Entity<QER_RESULTREGISTERREPORT1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_RESULTREGISTERREPORT1");

                entity.Property(e => e.PATIENT_Date).HasColumnType("smalldatetime");

                entity.Property(e => e.PATIENT_Name).HasMaxLength(255);

                entity.Property(e => e.rs).HasMaxLength(308);
            });

            modelBuilder.Entity<QER_RESULTREGISTERREPORTSMS>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_RESULTREGISTERREPORTSMS");

                entity.Property(e => e.CENTER_Name).HasMaxLength(255);

                entity.Property(e => e.CENTER_Telno).HasMaxLength(50);

                entity.Property(e => e.DOCTOR_MobileNo).HasMaxLength(50);

                entity.Property(e => e.DOCTOR_Name).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Date).HasColumnType("smalldatetime");

                entity.Property(e => e.PATIENT_Name).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Telno).HasMaxLength(50);

                entity.Property(e => e.TESTDET_sUnit).HasMaxLength(50);

                entity.Property(e => e.TESTMST_Alias).HasMaxLength(50);

                entity.Property(e => e.rs).HasMaxLength(308);
            });

            modelBuilder.Entity<QER_RESULTREGISTERREPORTSMSCRITICAL>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_RESULTREGISTERREPORTSMSCRITICAL");

                entity.Property(e => e.CENTER_Name).HasMaxLength(255);

                entity.Property(e => e.CENTER_Telno).HasMaxLength(50);

                entity.Property(e => e.DOCTOR_MobileNo).HasMaxLength(50);

                entity.Property(e => e.DOCTOR_Name).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Date).HasColumnType("smalldatetime");

                entity.Property(e => e.PATIENT_Name).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Telno).HasMaxLength(50);

                entity.Property(e => e.TESTDET_sUnit).HasMaxLength(50);

                entity.Property(e => e.TESTMST_Alias).HasMaxLength(50);

                entity.Property(e => e.rs).HasMaxLength(308);
            });

            modelBuilder.Entity<QER_RESULTREGISTERSMS>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_RESULTREGISTERSMS");

                entity.Property(e => e.TESTDET_FieldName).HasMaxLength(255);

                entity.Property(e => e.TESTDET_sAlias).HasMaxLength(50);

                entity.Property(e => e.TESTDET_sUnit).HasMaxLength(50);

                entity.Property(e => e.TESTMST_Name).HasMaxLength(255);
            });

            modelBuilder.Entity<QER_RESULTREGISTERSMSCRITICAL>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_RESULTREGISTERSMSCRITICAL");

                entity.Property(e => e.TESTDET_FieldName).HasMaxLength(255);

                entity.Property(e => e.TESTDET_sAlias).HasMaxLength(50);

                entity.Property(e => e.TESTDET_sUnit).HasMaxLength(50);

                entity.Property(e => e.TESTMST_Name).HasMaxLength(255);
            });

            modelBuilder.Entity<QER_SPECIALTESTS>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_SPECIALTESTS");
            });

            modelBuilder.Entity<QER_TESTCOUNT>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_TESTCOUNT");
            });

            modelBuilder.Entity<QER_TESTS>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_TESTS");

                entity.Property(e => e.Active).HasMaxLength(1);

                entity.Property(e => e.AuntheticateDate).HasColumnType("datetime");

                entity.Property(e => e.AuthenticateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BalanceFlag)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CENTER_Name).HasMaxLength(255);

                entity.Property(e => e.Comments).HasColumnType("ntext");

                entity.Property(e => e.Currentdate).HasColumnType("smalldatetime");

                entity.Property(e => e.DOC2).HasMaxLength(255);

                entity.Property(e => e.DOCDET_tFieldValue).HasMaxLength(255);

                entity.Property(e => e.DOCDET_tFieldValue1).HasColumnType("ntext");

                entity.Property(e => e.DOCHDR_Age).HasMaxLength(50);

                entity.Property(e => e.DOCHDR_AgeFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOCHDR_Sex).HasMaxLength(50);

                entity.Property(e => e.DOCHDR_dDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DOCHDR_sDescription).HasColumnType("ntext");

                entity.Property(e => e.DOCHDR_sDocNo).HasMaxLength(50);

                entity.Property(e => e.DOCTOR_Address1).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_Address2).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_City).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_Country).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_Email).HasMaxLength(50);

                entity.Property(e => e.DOCTOR_MobileNo).HasMaxLength(50);

                entity.Property(e => e.DOCTOR_Name).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_Permanent).HasMaxLength(1);

                entity.Property(e => e.DOCTOR_Pincode).HasMaxLength(50);

                entity.Property(e => e.DOCTOR_Qualification).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_Region).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_State).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_Telno).HasMaxLength(50);

                entity.Property(e => e.DataEntryDate).HasColumnType("datetime");

                entity.Property(e => e.DataEntryUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EMPLOYEE_Name).HasMaxLength(255);

                entity.Property(e => e.EmailDate).HasColumnType("datetime");

                entity.Property(e => e.EmailUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HOSPTYPE).HasMaxLength(50);

                entity.Property(e => e.IntegrationDate).HasColumnType("datetime");

                entity.Property(e => e.IsNABL)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsProfile)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Lable_Sample)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MarkComplete).HasMaxLength(1);

                entity.Property(e => e.OFFICE_Address1).HasMaxLength(255);

                entity.Property(e => e.OFFICE_Address2).HasMaxLength(255);

                entity.Property(e => e.OFFICE_City).HasMaxLength(50);

                entity.Property(e => e.OFFICE_Country).HasMaxLength(50);

                entity.Property(e => e.OFFICE_Pincode).HasMaxLength(50);

                entity.Property(e => e.OFFICE_Region).HasMaxLength(50);

                entity.Property(e => e.OFFICE_State).HasMaxLength(50);

                entity.Property(e => e.OFFICE_Telno).HasMaxLength(50);

                entity.Property(e => e.OFFICE_url).HasMaxLength(50);

                entity.Property(e => e.PATIENT_Address1).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Address2).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Age).HasMaxLength(50);

                entity.Property(e => e.PATIENT_AgeFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PATIENT_City).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Date).HasColumnType("smalldatetime");

                entity.Property(e => e.PATIENT_Gender).HasMaxLength(50);

                entity.Property(e => e.PATIENT_Name).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Pincode).HasMaxLength(50);

                entity.Property(e => e.PATIENT_Region).HasMaxLength(255);

                entity.Property(e => e.PATIENT_State).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Telno).HasMaxLength(50);

                entity.Property(e => e.PDFDate).HasColumnType("datetime");

                entity.Property(e => e.PDFUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PLT).HasColumnType("image");

                entity.Property(e => e.PrintDate).HasColumnType("datetime");

                entity.Property(e => e.PrintUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProfileName).HasMaxLength(255);

                entity.Property(e => e.RBC).HasColumnType("image");

                entity.Property(e => e.RegistationDate).HasColumnType("datetime");

                entity.Property(e => e.RegistationUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.RequestDate).HasColumnType("date");

                entity.Property(e => e.RequestUser)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RerunDate).HasColumnType("datetime");

                entity.Property(e => e.RerunUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResampleDate).HasColumnType("datetime");

                entity.Property(e => e.ResampleUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SampleReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.SampleReceivedRemark)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SampleReceivedUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sample_Date).HasColumnType("smalldatetime");

                entity.Property(e => e.SpecialTest).HasMaxLength(1);

                entity.Property(e => e.TESTDET_Description).HasMaxLength(255);

                entity.Property(e => e.TESTDET_FieldName).HasMaxLength(255);

                entity.Property(e => e.TESTDET_GroupName).HasMaxLength(255);

                entity.Property(e => e.TESTDET_NormalValue).HasMaxLength(255);

                entity.Property(e => e.TESTDET_sAlias).HasMaxLength(50);

                entity.Property(e => e.TESTDET_sDefault).HasColumnType("ntext");

                entity.Property(e => e.TESTDET_sFormula).HasMaxLength(50);

                entity.Property(e => e.TESTDET_sUnit).HasMaxLength(50);

                entity.Property(e => e.TESTMST_Alias).HasMaxLength(50);

                entity.Property(e => e.TESTMST_CatType).HasMaxLength(3);

                entity.Property(e => e.TESTMST_Name).HasMaxLength(255);

                entity.Property(e => e.TESTMST_PrintFormat).HasMaxLength(255);

                entity.Property(e => e.TESTMST_ReportHeading).HasMaxLength(255);

                entity.Property(e => e.TESTMST_sample)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Type).HasMaxLength(1);

                entity.Property(e => e.UrgentFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ValidateDate).HasColumnType("datetime");

                entity.Property(e => e.ValidateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WBC).HasColumnType("image");

                entity.Property(e => e.WardNo).HasMaxLength(50);

                entity.Property(e => e.docq2).HasMaxLength(255);

                entity.Property(e => e.userid).HasMaxLength(50);
            });

            modelBuilder.Entity<QER_WORK_SHEET>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_WORK_SHEET");

                entity.Property(e => e.DOCHDR_dDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DOCTOR_Name).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Age).HasMaxLength(50);

                entity.Property(e => e.PATIENT_AgeFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PATIENT_Gender).HasMaxLength(50);

                entity.Property(e => e.PATIENT_Name).HasMaxLength(255);

                entity.Property(e => e.TESTMST_Alias).HasMaxLength(50);

                entity.Property(e => e.TestTypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<QER_WORK_SHEET_OLD>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_WORK_SHEET_OLD");

                entity.Property(e => e.DOCHDR_dDate).HasColumnType("smalldatetime");

                entity.Property(e => e.PATIENT_Name).HasMaxLength(255);

                entity.Property(e => e.TESTMST_Alias).HasMaxLength(50);

                entity.Property(e => e.TestTypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<QerCollectionCenterBillDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QerCollectionCenterBillDetail");

                entity.Property(e => e.DOCTOR_NAME).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Date).HasColumnType("smalldatetime");

                entity.Property(e => e.PATIENT_Name).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Pincode).HasMaxLength(50);

                entity.Property(e => e.Proposal_No)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QerTDSCertificate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QerTDSCertificate");

                entity.Property(e => e.BillDate).HasColumnType("datetime");

                entity.Property(e => e.CENTER_Name).HasMaxLength(255);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Fin_Year)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TDS).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.TdsCertificateRecDate).HasColumnType("datetime");

                entity.Property(e => e.TdsCertificateRecNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<QuantumTestMapp>(entity =>
            {
                entity.HasKey(e => e.testid);

                entity.Property(e => e.testid).ValueGeneratedNever();
            });

            modelBuilder.Entity<RATELIST>(entity =>
            {
                entity.HasKey(e => new { e.Centerid, e.TestId });

                entity.Property(e => e.BaseRate).HasDefaultValueSql("(0)");

                entity.Property(e => e.Discount1).HasDefaultValueSql("(0)");

                entity.Property(e => e.SpecialTest)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'N')");
            });

            modelBuilder.Entity<RATELISTHDR>(entity =>
            {
                entity.HasKey(e => e.RateListId);

                entity.Property(e => e.RateListId).ValueGeneratedNever();

                entity.Property(e => e.RateListName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SysDate).HasColumnType("datetime");

                entity.Property(e => e.SysUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RateListDiscountRate>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.TestCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Reject_Reason>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ReportReadySMSLog>(entity =>
            {
                entity.HasKey(e => e.AutoId);
            });

            modelBuilder.Entity<ReportValuesCRSMSLOG>(entity =>
            {
                entity.HasKey(e => e.Autoid);

                entity.Property(e => e.Autoid)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReportValuesSMSLOG>(entity =>
            {
                entity.HasKey(e => e.Autoid);

                entity.Property(e => e.Autoid)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SMSAPI>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.URL)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.password)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.sender)
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SMSTEMPLATEDET>(entity =>
            {
                entity.HasKey(e => e.TemplateDetailId);

                entity.HasIndex(e => e.FieldNo)
                    .HasName("IX_SMSTEMPLATEDET_Fieldno");

                entity.HasIndex(e => e.TemplateId)
                    .HasName("IX_SMSTEMPLATEDET_TemplateID");

                entity.HasIndex(e => e.TestId)
                    .HasName("IX_SMSTEMPLATEDET_Testid");

                entity.Property(e => e.IsList)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ListValue)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SMSTEMPLATEHDR>(entity =>
            {
                entity.HasKey(e => e.TemplateId)
                    .HasName("PK_SMSTEMPLATE");

                entity.Property(e => e.TemplateId).ValueGeneratedNever();

                entity.Property(e => e.SMSTemplate)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SysDate).HasColumnType("datetime");

                entity.Property(e => e.TemplateName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateSMSName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.sysUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SMSTESTREGISTER>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<SMS_SET>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.msgcenter)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.portno).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.settings)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.sign)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.web_sign).HasColumnType("ntext");
            });

            modelBuilder.Entity<Scheduler>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Path)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TESTDET>(entity =>
            {
                entity.HasKey(e => e.TESTDET_CurrentId);

                entity.HasIndex(e => e.TESTDET_TestMasterID)
                    .HasName("IX_TESTDET_TESTMASTERID");

                entity.Property(e => e.TESTDET_CurrentId).ValueGeneratedNever();

                entity.Property(e => e.TESTDET_ANormalValue).HasMaxLength(255);

                entity.Property(e => e.TESTDET_BNormalValue).HasMaxLength(255);

                entity.Property(e => e.TESTDET_CNormalValue).HasMaxLength(255);

                entity.Property(e => e.TESTDET_DNormalValue).HasMaxLength(255);

                entity.Property(e => e.TESTDET_Description).HasMaxLength(255);

                entity.Property(e => e.TESTDET_FieldName).HasMaxLength(255);

                entity.Property(e => e.TESTDET_GroupName).HasMaxLength(255);

                entity.Property(e => e.TESTDET_NormalValue).HasMaxLength(255);

                entity.Property(e => e.TESTDET_sAlias).HasMaxLength(50);

                entity.Property(e => e.TESTDET_sDefault).HasColumnType("ntext");

                entity.Property(e => e.TESTDET_sFormula).HasMaxLength(50);

                entity.Property(e => e.TESTDET_sUnit).HasMaxLength(50);

                entity.Property(e => e.ValueForNormal)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TESTMASTER>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TESTMASTER");

                entity.Property(e => e.Active).HasMaxLength(1);

                entity.Property(e => e.Comments).HasColumnType("ntext");

                entity.Property(e => e.PREDEFVAL_Value).HasMaxLength(255);

                entity.Property(e => e.SpecialTest).HasMaxLength(1);

                entity.Property(e => e.TESTDET_ANormalValue).HasMaxLength(255);

                entity.Property(e => e.TESTDET_BNormalValue).HasMaxLength(255);

                entity.Property(e => e.TESTDET_CNormalValue).HasMaxLength(255);

                entity.Property(e => e.TESTDET_DNormalValue).HasMaxLength(255);

                entity.Property(e => e.TESTDET_Description).HasMaxLength(255);

                entity.Property(e => e.TESTDET_FieldName).HasMaxLength(255);

                entity.Property(e => e.TESTDET_GroupName).HasMaxLength(255);

                entity.Property(e => e.TESTDET_NormalValue).HasMaxLength(255);

                entity.Property(e => e.TESTDET_sAlias).HasMaxLength(50);

                entity.Property(e => e.TESTDET_sDefault).HasColumnType("ntext");

                entity.Property(e => e.TESTDET_sFormula).HasMaxLength(50);

                entity.Property(e => e.TESTDET_sUnit).HasMaxLength(50);

                entity.Property(e => e.TESTMST_Alias).HasMaxLength(50);

                entity.Property(e => e.TESTMST_CatType).HasMaxLength(3);

                entity.Property(e => e.TESTMST_Name).HasMaxLength(255);

                entity.Property(e => e.TESTMST_PrintFormat).HasMaxLength(255);

                entity.Property(e => e.TESTMST_ReportHeading).HasMaxLength(255);

                entity.Property(e => e.TESTMST_sample)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Type).HasMaxLength(1);
            });

            modelBuilder.Entity<TESTMST>(entity =>
            {
                entity.HasKey(e => e.TESTMST_CurrentId);

                entity.HasIndex(e => e.TESTMST_CurrentId)
                    .HasName("IX_TESTMST");

                entity.Property(e => e.TESTMST_CurrentId).ValueGeneratedNever();

                entity.Property(e => e.Active).HasMaxLength(1);

                entity.Property(e => e.Comments).HasColumnType("ntext");

                entity.Property(e => e.IsKitImageCompulsary)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.IsNABL)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialTest)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'N')");

                entity.Property(e => e.TESTMST_Alias).HasMaxLength(50);

                entity.Property(e => e.TESTMST_CatType)
                    .HasMaxLength(3)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TESTMST_Name).HasMaxLength(255);

                entity.Property(e => e.TESTMST_PrintFormat).HasMaxLength(255);

                entity.Property(e => e.TESTMST_ReportHeading).HasMaxLength(255);

                entity.Property(e => e.TESTMST_TestTypeId).HasDefaultValueSql("(0)");

                entity.Property(e => e.TESTMST_sample)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('P')");
            });

            modelBuilder.Entity<TESTREGISTER>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<TESTTYPE>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.TestTypeDescription).HasMaxLength(150);

                entity.Property(e => e.TestTypeName).HasMaxLength(50);

                entity.Property(e => e.TestTypeRemark).HasMaxLength(150);

                entity.Property(e => e.TestTypeRemark1).HasMaxLength(150);
            });

            modelBuilder.Entity<TEST_FORMAT_DET>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.TEST_FieldName).HasMaxLength(255);

                entity.Property(e => e.TEST_sDefault).HasColumnType("ntext");
            });

            modelBuilder.Entity<TestValidation>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.FieldNos)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Msg)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.TotalVal).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<TreeView>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.title).HasMaxLength(50);
            });

            modelBuilder.Entity<USERRIGHTS>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.MenuName).HasMaxLength(255);
            });

            modelBuilder.Entity<USERS>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Company_Id).HasDefaultValueSql("(2)");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.Userid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<UserMaster>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(250);

                entity.Property(e => e.Age).HasMaxLength(50);

                entity.Property(e => e.Area).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Contact_No).HasMaxLength(50);

                entity.Property(e => e.DOB).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.LabCode).HasMaxLength(50);

                entity.Property(e => e.LabName).HasMaxLength(350);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Pincode).HasMaxLength(50);

                entity.Property(e => e.Qualification).HasMaxLength(100);

                entity.Property(e => e.RegDate).HasColumnType("datetime");

                entity.Property(e => e.RowSent).HasMaxLength(50);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.Sys_Date).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(5);

                entity.Property(e => e.UserName).HasMaxLength(150);
            });

            modelBuilder.Entity<VW_PATIENT_BILL_DETAILS>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_PATIENT_BILL_DETAILS");

                entity.Property(e => e.CENTER_Name).HasMaxLength(255);

                entity.Property(e => e.Doctor_Name1).HasMaxLength(255);

                entity.Property(e => e.Doctor_Name2).HasMaxLength(255);

                entity.Property(e => e.IsProfile)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PATIENT_Address1).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Address2).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Age).HasMaxLength(50);

                entity.Property(e => e.PATIENT_City).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Date).HasColumnType("smalldatetime");

                entity.Property(e => e.PATIENT_Gender).HasMaxLength(50);

                entity.Property(e => e.PATIENT_Name).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Pincode).HasMaxLength(50);

                entity.Property(e => e.PATIENT_Region).HasMaxLength(255);

                entity.Property(e => e.PATIENT_State).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Telno).HasMaxLength(50);

                entity.Property(e => e.TESTMST_Name).HasMaxLength(255);

                entity.Property(e => e.Type).HasMaxLength(1);

                entity.Property(e => e.blnCommission).HasMaxLength(1);
            });

            modelBuilder.Entity<architect>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ID).ValueGeneratedOnAdd();

                entity.Property(e => e.TEST_NAME)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<qer_paidrefund>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("qer_paidrefund");
            });

            modelBuilder.Entity<smsData>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.message)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.mobileno)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.smsdate).HasColumnType("smalldatetime");

                entity.Property(e => e.smsid).ValueGeneratedOnAdd();

                entity.Property(e => e.sndstatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tblAppointmentTrack>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AppointmentId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.contactNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.id).ValueGeneratedOnAdd();

                entity.Property(e => e.sysdate).HasColumnType("datetime");
            });

            modelBuilder.Entity<v1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v1");

                entity.Property(e => e.CENTER_Name).HasMaxLength(255);

                entity.Property(e => e.CENTER_Region).HasMaxLength(255);

                entity.Property(e => e.DOCTOR_Name).HasMaxLength(255);

                entity.Property(e => e.PATIENT_Date).HasColumnType("smalldatetime");

                entity.Property(e => e.PATIENT_Name).HasMaxLength(255);

                entity.Property(e => e.SpecialTest).HasMaxLength(1);

                entity.Property(e => e.TESTMST_Alias).HasMaxLength(50);

                entity.Property(e => e.WardNo).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
