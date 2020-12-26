using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace myLabWebApi.Models.DB
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

        public virtual DbSet<AbnormalSmslog> AbnormalSmslog { get; set; }
        public virtual DbSet<AdminHomeVisitAllocated> AdminHomeVisitAllocated { get; set; }
        public virtual DbSet<AdminLogin> AdminLogin { get; set; }
        public virtual DbSet<AdminPackkage> AdminPackkage { get; set; }
        public virtual DbSet<Amountpaid> Amountpaid { get; set; }
        public virtual DbSet<AppointmentImage> AppointmentImage { get; set; }
        public virtual DbSet<Architect> Architect { get; set; }
        public virtual DbSet<BillDetail> BillDetail { get; set; }
        public virtual DbSet<BillHeader> BillHeader { get; set; }
        public virtual DbSet<BlackListMobiles> BlackListMobiles { get; set; }
        public virtual DbSet<BookAppointment> BookAppointment { get; set; }
        public virtual DbSet<Bookhomevisit> Bookhomevisit { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Cbcworksheet> Cbcworksheet { get; set; }
        public virtual DbSet<Cbcworksheet28012013> Cbcworksheet28012013 { get; set; }
        public virtual DbSet<CollectionCenterAmountReceived> CollectionCenterAmountReceived { get; set; }
        public virtual DbSet<Collectioncenter> Collectioncenter { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Docdet> Docdet { get; set; }
        public virtual DbSet<Dochdr> Dochdr { get; set; }
        public virtual DbSet<DochdrHistory> DochdrHistory { get; set; }
        public virtual DbSet<Doctor> Doctor { get; set; }
        public virtual DbSet<Doctorbk> Doctorbk { get; set; }
        public virtual DbSet<EmailLog> EmailLog { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeWithCollectionCenterMap> EmployeeWithCollectionCenterMap { get; set; }
        public virtual DbSet<Groupdet> Groupdet { get; set; }
        public virtual DbSet<Histogram> Histogram { get; set; }
        public virtual DbSet<HomevisitImage> HomevisitImage { get; set; }
        public virtual DbSet<Intgdet> Intgdet { get; set; }
        public virtual DbSet<LabMaster> LabMaster { get; set; }
        public virtual DbSet<LabMst> LabMst { get; set; }
        public virtual DbSet<Labelgroup> Labelgroup { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<MetroEmailLog> MetroEmailLog { get; set; }
        public virtual DbSet<MylabTestDetails> MylabTestDetails { get; set; }
        public virtual DbSet<MylabTestDetailsBa200> MylabTestDetailsBa200 { get; set; }
        public virtual DbSet<Narrations> Narrations { get; set; }
        public virtual DbSet<Nextgendata> Nextgendata { get; set; }
        public virtual DbSet<Param> Param { get; set; }
        public virtual DbSet<ParamHelpValues> ParamHelpValues { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<PatientBillDetails> PatientBillDetails { get; set; }
        public virtual DbSet<PatientHistory> PatientHistory { get; set; }
        public virtual DbSet<PatientMaster> PatientMaster { get; set; }
        public virtual DbSet<PatientPortal> PatientPortal { get; set; }
        public virtual DbSet<PatientProfilePic> PatientProfilePic { get; set; }
        public virtual DbSet<PayRemDetail> PayRemDetail { get; set; }
        public virtual DbSet<PayRemHeader> PayRemHeader { get; set; }
        public virtual DbSet<Pdflog> Pdflog { get; set; }
        public virtual DbSet<PhelobotomistHomeVisit> PhelobotomistHomeVisit { get; set; }
        public virtual DbSet<PhlebomistCollectedTest> PhlebomistCollectedTest { get; set; }
        public virtual DbSet<Predefval> Predefval { get; set; }
        public virtual DbSet<Profdet> Profdet { get; set; }
        public virtual DbSet<QerAmountpaid> QerAmountpaid { get; set; }
        public virtual DbSet<QerAmountpaidtype> QerAmountpaidtype { get; set; }
        public virtual DbSet<QerBalamt> QerBalamt { get; set; }
        public virtual DbSet<QerBidirection> QerBidirection { get; set; }
        public virtual DbSet<QerBill> QerBill { get; set; }
        public virtual DbSet<QerCbcWorkSheet> QerCbcWorkSheet { get; set; }
        public virtual DbSet<QerCollection> QerCollection { get; set; }
        public virtual DbSet<QerCollectionCenterBillDetail> QerCollectionCenterBillDetail { get; set; }
        public virtual DbSet<QerComparerate> QerComparerate { get; set; }
        public virtual DbSet<QerDailyregister> QerDailyregister { get; set; }
        public virtual DbSet<QerDailyregrefund> QerDailyregrefund { get; set; }
        public virtual DbSet<QerDispatchregister> QerDispatchregister { get; set; }
        public virtual DbSet<QerDoctorComm> QerDoctorComm { get; set; }
        public virtual DbSet<QerDoctorCommission> QerDoctorCommission { get; set; }
        public virtual DbSet<QerDoctorCommissionOld> QerDoctorCommissionOld { get; set; }
        public virtual DbSet<QerDoctorlist> QerDoctorlist { get; set; }
        public virtual DbSet<QerDoctorwiseCommission> QerDoctorwiseCommission { get; set; }
        public virtual DbSet<QerDoctorwiseCommissionOld> QerDoctorwiseCommissionOld { get; set; }
        public virtual DbSet<QerFilldata> QerFilldata { get; set; }
        public virtual DbSet<QerForMypathtest> QerForMypathtest { get; set; }
        public virtual DbSet<QerPaidrefund> QerPaidrefund { get; set; }
        public virtual DbSet<QerPatient> QerPatient { get; set; }
        public virtual DbSet<QerPatientHistory> QerPatientHistory { get; set; }
        public virtual DbSet<QerPatientreport> QerPatientreport { get; set; }
        public virtual DbSet<QerPatienttype> QerPatienttype { get; set; }
        public virtual DbSet<QerPayments> QerPayments { get; set; }
        public virtual DbSet<QerPaymentstype> QerPaymentstype { get; set; }
        public virtual DbSet<QerPendingTest> QerPendingTest { get; set; }
        public virtual DbSet<QerPendingTestsNew> QerPendingTestsNew { get; set; }
        public virtual DbSet<QerRatelist> QerRatelist { get; set; }
        public virtual DbSet<QerRefundamount> QerRefundamount { get; set; }
        public virtual DbSet<QerResultregister> QerResultregister { get; set; }
        public virtual DbSet<QerResultregister1> QerResultregister1 { get; set; }
        public virtual DbSet<QerResultregister2> QerResultregister2 { get; set; }
        public virtual DbSet<QerResultregisterreport> QerResultregisterreport { get; set; }
        public virtual DbSet<QerResultregisterreport1> QerResultregisterreport1 { get; set; }
        public virtual DbSet<QerResultregisterreportsms> QerResultregisterreportsms { get; set; }
        public virtual DbSet<QerResultregisterreportsmscritical> QerResultregisterreportsmscritical { get; set; }
        public virtual DbSet<QerResultregistersms> QerResultregistersms { get; set; }
        public virtual DbSet<QerResultregistersmscritical> QerResultregistersmscritical { get; set; }
        public virtual DbSet<QerSpecialtests> QerSpecialtests { get; set; }
        public virtual DbSet<QerTdscertificate> QerTdscertificate { get; set; }
        public virtual DbSet<QerTestcount> QerTestcount { get; set; }
        public virtual DbSet<QerTests> QerTests { get; set; }
        public virtual DbSet<QerWorkSheet> QerWorkSheet { get; set; }
        public virtual DbSet<QerWorkSheetOld> QerWorkSheetOld { get; set; }
        public virtual DbSet<QuantumTestMapp> QuantumTestMapp { get; set; }
        public virtual DbSet<RateListDiscountRate> RateListDiscountRate { get; set; }
        public virtual DbSet<Ratelist> Ratelist { get; set; }
        public virtual DbSet<Ratelisthdr> Ratelisthdr { get; set; }
        public virtual DbSet<RejectReason> RejectReason { get; set; }
        public virtual DbSet<ReportReadySmslog> ReportReadySmslog { get; set; }
        public virtual DbSet<ReportValuesCrsmslog> ReportValuesCrsmslog { get; set; }
        public virtual DbSet<ReportValuesSmslog> ReportValuesSmslog { get; set; }
        public virtual DbSet<Scheduler> Scheduler { get; set; }
        public virtual DbSet<SmsData> SmsData { get; set; }
        public virtual DbSet<SmsSet> SmsSet { get; set; }
        public virtual DbSet<Smsapi> Smsapi { get; set; }
        public virtual DbSet<Smstemplatedet> Smstemplatedet { get; set; }
        public virtual DbSet<Smstemplatehdr> Smstemplatehdr { get; set; }
        public virtual DbSet<Smstestregister> Smstestregister { get; set; }
        public virtual DbSet<TblAppointmentTrack> TblAppointmentTrack { get; set; }
        public virtual DbSet<TestFormatDet> TestFormatDet { get; set; }
        public virtual DbSet<TestValidation> TestValidation { get; set; }
        public virtual DbSet<Testdet> Testdet { get; set; }
        public virtual DbSet<Testmaster> Testmaster { get; set; }
        public virtual DbSet<Testmst> Testmst { get; set; }
        public virtual DbSet<Testregister> Testregister { get; set; }
        public virtual DbSet<Testtype> Testtype { get; set; }
        public virtual DbSet<TreeView> TreeView { get; set; }
        public virtual DbSet<UserMaster> UserMaster { get; set; }
        public virtual DbSet<Userrights> Userrights { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<V1> V1 { get; set; }
        public virtual DbSet<VwPatientBillDetails> VwPatientBillDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=103.131.93.13;Initial Catalog=MYLABWEB;User Id=MYLAB;Password=MYLAB@123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AbnormalSmslog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("AbnormalSMSLog");

                entity.HasIndex(e => e.PatientName)
                    .HasName("IX_AbnormalSMSLog_PatientName");

                entity.Property(e => e.LastSmsdate)
                    .HasColumnName("LastSMSDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PatientDate)
                    .HasColumnName("PATIENT_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PatientName)
                    .HasColumnName("PATIENT_Name")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PatientTelno)
                    .HasColumnName("PATIENT_Telno")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Sms)
                    .HasColumnName("SMS")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SysDate).HasColumnType("datetime");

                entity.Property(e => e.SysDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SysFlag)
                    .HasColumnName("sysFlag")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateName)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AdminHomeVisitAllocated>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ADMIN_HOME_VISIT_ALLOCATED");

                entity.Property(e => e.AllotTime)
                    .HasColumnName("ALLOT_TIME")
                    .HasMaxLength(50);

                entity.Property(e => e.BookedhomevisitId)
                    .HasColumnName("BOOKEDHOMEVISIT_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.BookingDate)
                    .HasColumnName("bookingDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .HasColumnName("FILE_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.FilePath)
                    .HasColumnName("FILE_PATH")
                    .HasMaxLength(250);

                entity.Property(e => e.Flag).HasColumnName("FLAG");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LabName).HasMaxLength(100);

                entity.Property(e => e.PatientAddress)
                    .HasColumnName("patient_address")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PatientArea)
                    .HasColumnName("PATIENT_AREA")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientContact)
                    .HasColumnName("PATIENT_CONTACT")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientName)
                    .HasColumnName("PATIENT_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.PhlebId)
                    .HasColumnName("PHLEB_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.PhlebName)
                    .HasColumnName("PHLEB_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Remark)
                    .HasColumnName("REMARK")
                    .HasMaxLength(50);

                entity.Property(e => e.SendDatetime)
                    .HasColumnName("SEND_DATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.SysDate).HasColumnType("datetime");

                entity.Property(e => e.Userid)
                    .HasColumnName("USERID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AdminLogin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ADMIN_LOGIN");

                entity.Property(e => e.Contact)
                    .HasColumnName("CONTACT")
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(50);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LabId).HasColumnName("LabID");

                entity.Property(e => e.LabName).HasMaxLength(50);

                entity.Property(e => e.Password)
                    .HasColumnName("PASSWORD")
                    .HasMaxLength(50);

                entity.Property(e => e.SysDate)
                    .HasColumnName("SYS_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.SysDate1)
                    .HasColumnName("SysDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(30);

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AdminPackkage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ADMIN_PACKKAGE");

                entity.Property(e => e.Contact)
                    .HasColumnName("CONTACT")
                    .HasMaxLength(50);

                entity.Property(e => e.Flag).HasColumnName("FLAG");

                entity.Property(e => e.FromDate)
                    .HasColumnName("FROM_DATE")
                    .HasMaxLength(50);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LabAddress).HasMaxLength(100);

                entity.Property(e => e.LabArea).HasMaxLength(50);

                entity.Property(e => e.LabCode).HasMaxLength(50);

                entity.Property(e => e.LabName).HasMaxLength(50);

                entity.Property(e => e.PackageCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PackkageName)
                    .HasColumnName("PACKKAGE_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasMaxLength(50);

                entity.Property(e => e.Sysdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TestName)
                    .HasColumnName("TEST_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.ToDate)
                    .HasColumnName("TO_DATE")
                    .HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .HasColumnName("USER_ID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Amountpaid>(entity =>
            {
                entity.HasKey(e => e.Paymentid);

                entity.ToTable("AMOUNTPAID");

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

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AppointmentImage>(entity =>
            {
                entity.Property(e => e.AppointmentId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ImageString).HasColumnType("ntext");
            });

            modelBuilder.Entity<Architect>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("architect");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MylabTestFieldnoOne).HasColumnName("MYLAB_TEST_FIELDNO_ONE");

                entity.Property(e => e.MylabTestFieldnoTwo).HasColumnName("MYLAB_TEST_FIELDNO_TWO");

                entity.Property(e => e.MylabTestMstid).HasColumnName("MYLAB_TEST_MSTID");

                entity.Property(e => e.TestId).HasColumnName("TEST_ID");

                entity.Property(e => e.TestName)
                    .IsRequired()
                    .HasColumnName("TEST_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BillDetail>(entity =>
            {
                entity.HasKey(e => e.BillDetId);

                entity.Property(e => e.AmtReceived)
                    .HasColumnName("Amt_received")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Concession).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DoctorName)
                    .HasColumnName("Doctor_Name")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NormalTest).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OtherCharges).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PatientDate)
                    .HasColumnName("Patient_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PatientId).HasColumnName("Patient_id");

                entity.Property(e => e.PatientName)
                    .IsRequired()
                    .HasColumnName("Patient_Name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProposalNo)
                    .HasColumnName("Proposal_No")
                    .HasMaxLength(255);

                entity.Property(e => e.Remark)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialTest).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TestAlias)
                    .HasColumnName("Test_alias")
                    .HasMaxLength(1000);

                entity.Property(e => e.TotalAmt).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<BillHeader>(entity =>
            {
                entity.HasKey(e => e.BillId);

                entity.Property(e => e.BillId).ValueGeneratedNever();

                entity.Property(e => e.Addition).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BillDate).HasColumnType("datetime");

                entity.Property(e => e.BillType)
                    .HasColumnName("Bill_Type")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CenterId).HasColumnName("Center_Id");

                entity.Property(e => e.Cess).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Deduction).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.FinYear)
                    .IsRequired()
                    .HasColumnName("Fin_Year")
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

                entity.Property(e => e.SysDate)
                    .HasColumnName("sysDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SysUserName)
                    .HasColumnName("sysUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BookAppointment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BOOK_APPOINTMENT");

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Age)
                    .HasColumnName("age")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AppointmentId)
                    .HasColumnName("AppointmentID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Area)
                    .HasColumnName("AREA")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.BookedBy).HasMaxLength(100);

                entity.Property(e => e.Cancel)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('NO')");

                entity.Property(e => e.CancleReason)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Contact)
                    .HasColumnName("CONTACT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Filename)
                    .HasColumnName("FILENAME")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Filepath)
                    .HasColumnName("FILEPATH")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Flag).HasColumnName("FLAG");

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LabCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PatientContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatientEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId)
                    .HasColumnName("PATIENT_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PreferedLab)
                    .HasColumnName("PREFERED_LAB")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("REMARK")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RowSent).HasDefaultValueSql("((0))");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'UPCOMING')");

                entity.Property(e => e.Time)
                    .HasColumnName("TIME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsernameBook)
                    .HasColumnName("USERNAME_Book")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Bookhomevisit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BOOKHOMEVISIT");

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(250);

                entity.Property(e => e.Age).HasMaxLength(5);

                entity.Property(e => e.Area)
                    .HasColumnName("AREA")
                    .HasMaxLength(50);

                entity.Property(e => e.BookedBy).HasMaxLength(100);

                entity.Property(e => e.BookedFlag)
                    .HasColumnName("BOOKED_FLAG")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cancel)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'NO')");

                entity.Property(e => e.CancleReason)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Contact)
                    .HasColumnName("CONTACT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentDate)
                    .HasColumnName("Current_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Filename)
                    .HasColumnName("FILENAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Filepath)
                    .HasColumnName("FILEPATH")
                    .HasMaxLength(250);

                entity.Property(e => e.Gender)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.HomevisitId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LabCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PatientContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatientEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId)
                    .HasColumnName("PATIENT_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatientName)
                    .HasColumnName("Patient_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PreferedLab)
                    .HasColumnName("PREFERED_LAB")
                    .HasMaxLength(50);

                entity.Property(e => e.Remark)
                    .HasColumnName("REMARK")
                    .HasMaxLength(250);

                entity.Property(e => e.RowSent).HasDefaultValueSql("((0))");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.SysDate)
                    .HasColumnName("Sys_Date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Time)
                    .HasColumnName("TIME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CATEGORY");

                entity.Property(e => e.CatDescription).HasMaxLength(150);

                entity.Property(e => e.CatName).HasMaxLength(50);

                entity.Property(e => e.CatRemark).HasMaxLength(150);

                entity.Property(e => e.CatRemark1).HasMaxLength(150);
            });

            modelBuilder.Entity<Cbcworksheet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CBCWorksheet");

                entity.Property(e => e.FieldName)
                    .HasColumnName("Field_name")
                    .HasMaxLength(50);

                entity.Property(e => e.FieldNo).HasColumnName("Field_No");

                entity.Property(e => e.TestCatId).HasColumnName("TestCat_ID");

                entity.Property(e => e.TestName)
                    .HasColumnName("Test_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Cbcworksheet28012013>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CBCWorksheet28012013");

                entity.Property(e => e.FieldName)
                    .HasColumnName("Field_name")
                    .HasMaxLength(50);

                entity.Property(e => e.FieldNo).HasColumnName("Field_No");

                entity.Property(e => e.TestCatId).HasColumnName("TestCat_ID");

                entity.Property(e => e.TestName)
                    .HasColumnName("Test_name")
                    .HasMaxLength(50);
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

                entity.Property(e => e.CenterId).HasColumnName("Center_Id");

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

                entity.Property(e => e.Tds)
                    .HasColumnName("TDS")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Collectioncenter>(entity =>
            {
                entity.HasKey(e => e.CenterId);

                entity.ToTable("COLLECTIONCENTER");

                entity.Property(e => e.CenterId)
                    .HasColumnName("CENTER_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CenterAddress1)
                    .HasColumnName("CENTER_Address1")
                    .HasMaxLength(255);

                entity.Property(e => e.CenterAddress2)
                    .HasColumnName("CENTER_Address2")
                    .HasMaxLength(255);

                entity.Property(e => e.CenterCity)
                    .HasColumnName("CENTER_City")
                    .HasMaxLength(255);

                entity.Property(e => e.CenterCompanyid).HasColumnName("CENTER_Companyid");

                entity.Property(e => e.CenterCountry)
                    .HasColumnName("CENTER_Country")
                    .HasMaxLength(255);

                entity.Property(e => e.CenterName)
                    .HasColumnName("CENTER_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.CenterPincode)
                    .HasColumnName("CENTER_Pincode")
                    .HasMaxLength(255);

                entity.Property(e => e.CenterRegion)
                    .HasColumnName("CENTER_Region")
                    .HasMaxLength(255);

                entity.Property(e => e.CenterState)
                    .HasColumnName("CENTER_State")
                    .HasMaxLength(255);

                entity.Property(e => e.CenterStatus).HasColumnName("CENTER_Status");

                entity.Property(e => e.CenterTelno)
                    .HasColumnName("CENTER_Telno")
                    .HasMaxLength(50);

                entity.Property(e => e.OutSourceLab)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("COMPANY");

                entity.Property(e => e.CompanyAbnormal)
                    .HasColumnName("COMPANY_Abnormal")
                    .HasMaxLength(200);

                entity.Property(e => e.CompanyAddress1)
                    .HasColumnName("COMPANY_Address1")
                    .HasMaxLength(255);

                entity.Property(e => e.CompanyAddress2)
                    .HasColumnName("COMPANY_Address2")
                    .HasMaxLength(255);

                entity.Property(e => e.CompanyBotMargin).HasColumnName("COMPANY_BotMargin");

                entity.Property(e => e.CompanyCardDegree1)
                    .HasColumnName("COMPANY_CardDegree1")
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyCardDegree2)
                    .HasColumnName("COMPANY_CardDegree2")
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyCardDegree3)
                    .HasColumnName("COMPANY_CardDegree3")
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyCardiologist1)
                    .HasColumnName("COMPANY_Cardiologist1")
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyCardiologist2)
                    .HasColumnName("COMPANY_Cardiologist2")
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyCardiologist3)
                    .HasColumnName("COMPANY_Cardiologist3")
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyCity)
                    .HasColumnName("COMPANY_City")
                    .HasMaxLength(255);

                entity.Property(e => e.CompanyCountry)
                    .HasColumnName("COMPANY_Country")
                    .HasMaxLength(255);

                entity.Property(e => e.CompanyDataLoc)
                    .HasColumnName("COMPANY_DataLoc")
                    .HasMaxLength(255);

                entity.Property(e => e.CompanyEmail)
                    .HasColumnName("COMPANY_Email")
                    .HasMaxLength(255);

                entity.Property(e => e.CompanyFaxnumber)
                    .HasColumnName("COMPANY_Faxnumber")
                    .HasMaxLength(50);

                entity.Property(e => e.CompanyName)
                    .HasColumnName("COMPANY_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.CompanyPaperSize).HasColumnName("COMPANY_PaperSize");

                entity.Property(e => e.CompanyPassword)
                    .HasColumnName("COMPANY_Password")
                    .HasMaxLength(50);

                entity.Property(e => e.CompanyPathoDegree1)
                    .HasColumnName("COMPANY_PathoDegree1")
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyPathoDegree2)
                    .HasColumnName("COMPANY_PathoDegree2")
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyPathoDegree3)
                    .HasColumnName("COMPANY_PathoDegree3")
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyPathologist1)
                    .HasColumnName("COMPANY_Pathologist1")
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyPathologist2)
                    .HasColumnName("COMPANY_Pathologist2")
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyPathologist3)
                    .HasColumnName("COMPANY_Pathologist3")
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyPhoneNumber)
                    .HasColumnName("COMPANY_PhoneNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.CompanyPostalCode)
                    .HasColumnName("COMPANY_PostalCode")
                    .HasMaxLength(255);

                entity.Property(e => e.CompanyRadDegree1)
                    .HasColumnName("COMPANY_RadDegree1")
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyRadDegree2)
                    .HasColumnName("COMPANY_RadDegree2")
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyRadDegree3)
                    .HasColumnName("COMPANY_RadDegree3")
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyRadiologist1)
                    .HasColumnName("COMPANY_Radiologist1")
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyRadiologist2)
                    .HasColumnName("COMPANY_Radiologist2")
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyRadiologist3)
                    .HasColumnName("COMPANY_Radiologist3")
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyReportLoc)
                    .HasColumnName("COMPANY_ReportLoc")
                    .HasMaxLength(255);

                entity.Property(e => e.CompanySeries)
                    .IsRequired()
                    .HasColumnName("COMPANY_Series")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.CompanySetupid).HasColumnName("COMPANY_Setupid");

                entity.Property(e => e.CompanySonoDegree)
                    .HasColumnName("COMPANY_SonoDegree")
                    .HasMaxLength(100);

                entity.Property(e => e.CompanySonoLogist)
                    .HasColumnName("COMPANY_SonoLogist")
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyState)
                    .HasColumnName("COMPANY_State")
                    .HasMaxLength(255);

                entity.Property(e => e.CompanyTopMargin).HasColumnName("COMPANY_TopMargin");

                entity.Property(e => e.CompanyUrl)
                    .HasColumnName("COMPANY_Url")
                    .HasMaxLength(255);

                entity.Property(e => e.CompanyUsername)
                    .HasColumnName("COMPANY_Username")
                    .HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(255);
            });

            modelBuilder.Entity<Docdet>(entity =>
            {
                entity.HasKey(e => new { e.DocdetLHeaderId, e.DocdetLFieldNo });

                entity.ToTable("DOCDET");

                entity.HasIndex(e => e.DocdetLHeaderId)
                    .HasName("IX_DOCDET");

                entity.HasIndex(e => new { e.DocdetLTestCatId, e.DocdetLFieldNo })
                    .HasName("IX_DOCDET_1");

                entity.Property(e => e.DocdetLHeaderId).HasColumnName("DOCDET_lHeaderId");

                entity.Property(e => e.DocdetLFieldNo).HasColumnName("DOCDET_lFieldNo");

                entity.Property(e => e.DocdetLTestCatId).HasColumnName("DOCDET_lTestCatId");

                entity.Property(e => e.DocdetTFieldValue)
                    .HasColumnName("DOCDET_tFieldValue")
                    .HasMaxLength(255);

                entity.Property(e => e.DocdetTFieldValue1)
                    .HasColumnName("DOCDET_tFieldValue1")
                    .HasColumnType("ntext");

                entity.Property(e => e.IsResRec)
                    .HasColumnName("isResRec")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Rerun).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Dochdr>(entity =>
            {
                entity.HasKey(e => e.DochdrLDocumentId);

                entity.ToTable("DOCHDR");

                entity.HasIndex(e => e.DochdrDDate)
                    .HasName("IX_DOCHDR_Date");

                entity.HasIndex(e => e.DochdrLDoctorId)
                    .HasName("IX_DOCHDR_DOCTORID");

                entity.HasIndex(e => e.DochdrLPatientId)
                    .HasName("IX_DOCHDR_PATIENTID");

                entity.HasIndex(e => e.DochdrSample)
                    .HasName("IX_DOCHDR_SAMPLE");

                entity.HasIndex(e => e.DochdrTestCatId)
                    .HasName("IX_DOCHDR_TESTCATID");

                entity.HasIndex(e => e.MarkComplete)
                    .HasName("IX_DOCHDR_markcomplete");

                entity.Property(e => e.DochdrLDocumentId)
                    .HasColumnName("DOCHDR_lDocumentId")
                    .ValueGeneratedNever();

                entity.Property(e => e.AuntheticateDate).HasColumnType("datetime");

                entity.Property(e => e.AuthenticateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Currentdate).HasColumnType("smalldatetime");

                entity.Property(e => e.DataEntryDate).HasColumnType("datetime");

                entity.Property(e => e.DataEntryUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DochdrAge)
                    .HasColumnName("DOCHDR_Age")
                    .HasMaxLength(50);

                entity.Property(e => e.DochdrAgeFlag)
                    .IsRequired()
                    .HasColumnName("DOCHDR_AgeFlag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DochdrBCommission).HasColumnName("DOCHDR_bCommission");

                entity.Property(e => e.DochdrDDate)
                    .HasColumnName("DOCHDR_dDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DochdrLDoctorId).HasColumnName("DOCHDR_lDoctorId");

                entity.Property(e => e.DochdrLEmployeeId).HasColumnName("DOCHDR_lEmployeeId");

                entity.Property(e => e.DochdrLPatientId).HasColumnName("DOCHDR_lPatientId");

                entity.Property(e => e.DochdrPid)
                    .HasColumnName("DOCHDR_PID")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DochdrRate).HasColumnName("DOCHDR_Rate");

                entity.Property(e => e.DochdrSDescription)
                    .HasColumnName("DOCHDR_sDescription")
                    .HasColumnType("ntext");

                entity.Property(e => e.DochdrSDocNo)
                    .HasColumnName("DOCHDR_sDocNo")
                    .HasMaxLength(50);

                entity.Property(e => e.DochdrSample).HasColumnName("DOCHDR_Sample");

                entity.Property(e => e.DochdrSex)
                    .HasColumnName("DOCHDR_Sex")
                    .HasMaxLength(50);

                entity.Property(e => e.DochdrTestCatId).HasColumnName("DOCHDR_TestCatID");

                entity.Property(e => e.EmailDate).HasColumnType("datetime");

                entity.Property(e => e.EmailUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Hosptype)
                    .HasColumnName("HOSPTYPE")
                    .HasMaxLength(50);

                entity.Property(e => e.IntegrationDate).HasColumnType("datetime");

                entity.Property(e => e.IsAllResRec)
                    .HasColumnName("isAllResRec")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsProfile)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IssampleReceived)
                    .HasColumnName("issampleReceived")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Issent)
                    .HasColumnName("issent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LableSample)
                    .HasColumnName("Lable_Sample")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Labno).HasColumnName("labno");

                entity.Property(e => e.MarkComplete).HasMaxLength(1);

                entity.Property(e => e.Pdfdate)
                    .HasColumnName("PDFDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pdfuser)
                    .HasColumnName("PDFUser")
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

                entity.Property(e => e.SampleDate)
                    .HasColumnName("Sample_Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.SampleReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.SampleReceivedRemark)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SampleReceivedUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(50);

                entity.Property(e => e.ValidateDate).HasColumnType("datetime");

                entity.Property(e => e.ValidateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WardNo).HasMaxLength(50);
            });

            modelBuilder.Entity<DochdrHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DOCHDR_HISTORY");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Currentdate).HasColumnType("smalldatetime");

                entity.Property(e => e.DochdrAge)
                    .HasColumnName("DOCHDR_Age")
                    .HasMaxLength(50);

                entity.Property(e => e.DochdrAgeFlag)
                    .IsRequired()
                    .HasColumnName("DOCHDR_AgeFlag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DochdrBCommission).HasColumnName("DOCHDR_bCommission");

                entity.Property(e => e.DochdrDDate)
                    .HasColumnName("DOCHDR_dDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DochdrLDoctorId).HasColumnName("DOCHDR_lDoctorId");

                entity.Property(e => e.DochdrLDocumentId).HasColumnName("DOCHDR_lDocumentId");

                entity.Property(e => e.DochdrLEmployeeId).HasColumnName("DOCHDR_lEmployeeId");

                entity.Property(e => e.DochdrLPatientId).HasColumnName("DOCHDR_lPatientId");

                entity.Property(e => e.DochdrPid)
                    .HasColumnName("DOCHDR_PID")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DochdrRate).HasColumnName("DOCHDR_Rate");

                entity.Property(e => e.DochdrSDescription)
                    .HasColumnName("DOCHDR_sDescription")
                    .HasColumnType("ntext");

                entity.Property(e => e.DochdrSDocNo)
                    .HasColumnName("DOCHDR_sDocNo")
                    .HasMaxLength(50);

                entity.Property(e => e.DochdrSample).HasColumnName("DOCHDR_Sample");

                entity.Property(e => e.DochdrSex)
                    .HasColumnName("DOCHDR_Sex")
                    .HasMaxLength(50);

                entity.Property(e => e.DochdrTestCatId).HasColumnName("DOCHDR_TestCatID");

                entity.Property(e => e.FlagU)
                    .HasColumnName("flag_u")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HistoryId).HasColumnName("HISTORY_ID");

                entity.Property(e => e.Hosptype)
                    .HasColumnName("HOSPTYPE")
                    .HasMaxLength(50);

                entity.Property(e => e.IsAllResRec)
                    .HasColumnName("isAllResRec")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IsProfile)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IssampleReceived)
                    .HasColumnName("issampleReceived")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Issent)
                    .HasColumnName("issent")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Labno).HasColumnName("labno");

                entity.Property(e => e.MarkComplete).HasMaxLength(1);

                entity.Property(e => e.SampleDate)
                    .HasColumnName("Sample_Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(50);

                entity.Property(e => e.WardNo).HasMaxLength(50);
            });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.ToTable("DOCTOR");

                entity.HasIndex(e => e.DoctorName)
                    .HasName("IX_DOCTOR_Name");

                entity.Property(e => e.DoctorId)
                    .HasColumnName("DOCTOR_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.DoctorAddress1)
                    .HasColumnName("DOCTOR_Address1")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorAddress2)
                    .HasColumnName("DOCTOR_Address2")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorCity)
                    .HasColumnName("DOCTOR_City")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorCode)
                    .HasColumnName("doctor_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DoctorCommission).HasColumnName("DOCTOR_Commission");

                entity.Property(e => e.DoctorCompanyid).HasColumnName("DOCTOR_Companyid");

                entity.Property(e => e.DoctorCountry)
                    .HasColumnName("DOCTOR_Country")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorEmail)
                    .HasColumnName("DOCTOR_Email")
                    .HasMaxLength(100);

                entity.Property(e => e.DoctorEx1commission)
                    .HasColumnName("DOCTOR_EX1Commission")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DoctorExcommission)
                    .HasColumnName("DOCTOR_EXCommission")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DoctorHcommission)
                    .HasColumnName("DOCTOR_HCommission")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DoctorMcommission)
                    .HasColumnName("DOCTOR_MCommission")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DoctorMobileNo)
                    .HasColumnName("DOCTOR_MobileNo")
                    .HasMaxLength(50);

                entity.Property(e => e.DoctorName)
                    .HasColumnName("DOCTOR_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorOcommission)
                    .HasColumnName("DOCTOR_OCommission")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DoctorPassword)
                    .HasColumnName("DOCTOR_Password")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DoctorPermanent)
                    .IsRequired()
                    .HasColumnName("DOCTOR_Permanent")
                    .HasMaxLength(1);

                entity.Property(e => e.DoctorPfcommission)
                    .HasColumnName("DOCTOR_PFCommission")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DoctorPincode)
                    .HasColumnName("DOCTOR_Pincode")
                    .HasMaxLength(50);

                entity.Property(e => e.DoctorQualification)
                    .HasColumnName("DOCTOR_Qualification")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorRcommission)
                    .HasColumnName("DOCTOR_RCommission")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DoctorRegion)
                    .HasColumnName("DOCTOR_Region")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorScommission).HasColumnName("DOCTOR_SCommission");

                entity.Property(e => e.DoctorSpcommission)
                    .HasColumnName("DOCTOR_SPCommission")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DoctorState)
                    .HasColumnName("DOCTOR_State")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorTelno)
                    .HasColumnName("DOCTOR_Telno")
                    .HasMaxLength(50);

                entity.Property(e => e.DoctorUserName)
                    .HasColumnName("DOCTOR_UserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DoctorXcommission).HasColumnName("DOCTOR_XCommission");

                entity.Property(e => e.OfficeAddress1)
                    .HasColumnName("OFFICE_Address1")
                    .HasMaxLength(255);

                entity.Property(e => e.OfficeAddress2)
                    .HasColumnName("OFFICE_Address2")
                    .HasMaxLength(255);

                entity.Property(e => e.OfficeCity)
                    .HasColumnName("OFFICE_City")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficeCountry)
                    .HasColumnName("OFFICE_Country")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficePincode)
                    .HasColumnName("OFFICE_Pincode")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficeRegion)
                    .HasColumnName("OFFICE_Region")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficeState)
                    .HasColumnName("OFFICE_State")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficeTelno)
                    .HasColumnName("OFFICE_Telno")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficeUrl)
                    .HasColumnName("OFFICE_url")
                    .HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.SendSms).HasColumnName("SendSMS");
            });

            modelBuilder.Entity<Doctorbk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DOCTORBK");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.DoctorAddress1)
                    .HasColumnName("DOCTOR_Address1")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorAddress2)
                    .HasColumnName("DOCTOR_Address2")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorCity)
                    .HasColumnName("DOCTOR_City")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorCode)
                    .HasColumnName("doctor_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DoctorCommission).HasColumnName("DOCTOR_Commission");

                entity.Property(e => e.DoctorCompanyid).HasColumnName("DOCTOR_Companyid");

                entity.Property(e => e.DoctorCountry)
                    .HasColumnName("DOCTOR_Country")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorEmail)
                    .HasColumnName("DOCTOR_Email")
                    .HasMaxLength(50);

                entity.Property(e => e.DoctorEx1commission).HasColumnName("DOCTOR_EX1Commission");

                entity.Property(e => e.DoctorExcommission).HasColumnName("DOCTOR_EXCommission");

                entity.Property(e => e.DoctorHcommission).HasColumnName("DOCTOR_HCommission");

                entity.Property(e => e.DoctorId).HasColumnName("DOCTOR_id");

                entity.Property(e => e.DoctorMcommission).HasColumnName("DOCTOR_MCommission");

                entity.Property(e => e.DoctorMobileNo)
                    .HasColumnName("DOCTOR_MobileNo")
                    .HasMaxLength(50);

                entity.Property(e => e.DoctorName)
                    .HasColumnName("DOCTOR_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorOcommission).HasColumnName("DOCTOR_OCommission");

                entity.Property(e => e.DoctorPassword)
                    .HasColumnName("DOCTOR_Password")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DoctorPermanent)
                    .IsRequired()
                    .HasColumnName("DOCTOR_Permanent")
                    .HasMaxLength(1);

                entity.Property(e => e.DoctorPfcommission).HasColumnName("DOCTOR_PFCommission");

                entity.Property(e => e.DoctorPincode)
                    .HasColumnName("DOCTOR_Pincode")
                    .HasMaxLength(50);

                entity.Property(e => e.DoctorQualification)
                    .HasColumnName("DOCTOR_Qualification")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorRcommission).HasColumnName("DOCTOR_RCommission");

                entity.Property(e => e.DoctorRegion)
                    .HasColumnName("DOCTOR_Region")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorScommission).HasColumnName("DOCTOR_SCommission");

                entity.Property(e => e.DoctorSpcommission).HasColumnName("DOCTOR_SPCommission");

                entity.Property(e => e.DoctorState)
                    .HasColumnName("DOCTOR_State")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorTelno)
                    .HasColumnName("DOCTOR_Telno")
                    .HasMaxLength(50);

                entity.Property(e => e.DoctorUserName)
                    .HasColumnName("DOCTOR_UserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DoctorXcommission).HasColumnName("DOCTOR_XCommission");

                entity.Property(e => e.OfficeAddress1)
                    .HasColumnName("OFFICE_Address1")
                    .HasMaxLength(255);

                entity.Property(e => e.OfficeAddress2)
                    .HasColumnName("OFFICE_Address2")
                    .HasMaxLength(255);

                entity.Property(e => e.OfficeCity)
                    .HasColumnName("OFFICE_City")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficeCountry)
                    .HasColumnName("OFFICE_Country")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficePincode)
                    .HasColumnName("OFFICE_Pincode")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficeRegion)
                    .HasColumnName("OFFICE_Region")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficeState)
                    .HasColumnName("OFFICE_State")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficeTelno)
                    .HasColumnName("OFFICE_Telno")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficeUrl)
                    .HasColumnName("OFFICE_url")
                    .HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.SendSms).HasColumnName("SendSMS");
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

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EMPLOYEE");

                entity.Property(e => e.CollectionBoyFlag).HasColumnName("CollectionBoy_Flag");

                entity.Property(e => e.EmployeeAddress1)
                    .HasColumnName("EMPLOYEE_Address1")
                    .HasMaxLength(255);

                entity.Property(e => e.EmployeeAddress2)
                    .HasColumnName("EMPLOYEE_Address2")
                    .HasMaxLength(255);

                entity.Property(e => e.EmployeeCity)
                    .HasColumnName("EMPLOYEE_City")
                    .HasMaxLength(255);

                entity.Property(e => e.EmployeeCompanyid).HasColumnName("EMPLOYEE_Companyid");

                entity.Property(e => e.EmployeeCountry)
                    .HasColumnName("EMPLOYEE_Country")
                    .HasMaxLength(255);

                entity.Property(e => e.EmployeeDateofBirth)
                    .HasColumnName("EMPLOYEE_DateofBirth")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.EmployeeDateofJoining)
                    .HasColumnName("EMPLOYEE_DateofJoining")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.EmployeeEmail)
                    .HasColumnName("EMPLOYEE_Email")
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeGender).HasColumnName("EMPLOYEE_Gender");

                entity.Property(e => e.EmployeeId).HasColumnName("EMPLOYEE_id");

                entity.Property(e => e.EmployeeMobileNo)
                    .HasColumnName("EMPLOYEE_MobileNo")
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("EMPLOYEE_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.EmployeePincode)
                    .HasColumnName("EMPLOYEE_Pincode")
                    .HasMaxLength(255);

                entity.Property(e => e.EmployeeQualification)
                    .HasColumnName("EMPLOYEE_Qualification")
                    .HasMaxLength(255);

                entity.Property(e => e.EmployeeRegion)
                    .HasColumnName("EMPLOYEE_Region")
                    .HasMaxLength(255);

                entity.Property(e => e.EmployeeSalary).HasColumnName("EMPLOYEE_Salary");

                entity.Property(e => e.EmployeeSalaryType)
                    .HasColumnName("EMPLOYEE_SalaryType")
                    .HasMaxLength(1);

                entity.Property(e => e.EmployeeState)
                    .HasColumnName("EMPLOYEE_State")
                    .HasMaxLength(255);

                entity.Property(e => e.EmployeeStatus).HasColumnName("EMPLOYEE_Status");

                entity.Property(e => e.EmployeeTelno)
                    .HasColumnName("EMPLOYEE_Telno")
                    .HasMaxLength(50);

                entity.Property(e => e.LabId).HasColumnName("LabID");

                entity.Property(e => e.Password).HasMaxLength(50);
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

            modelBuilder.Entity<Groupdet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GROUPDET");

                entity.Property(e => e.AutoId)
                    .HasColumnName("Auto Id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Grpid).HasColumnName("GRPID");

                entity.Property(e => e.Testid).HasColumnName("TESTID");
            });

            modelBuilder.Entity<Histogram>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HISTOGRAM");

                entity.Property(e => e.DochdrLDocumentId).HasColumnName("DOCHDR_lDocumentID");

                entity.Property(e => e.DochdrLPatientId).HasColumnName("DOCHDR_lPatientId");

                entity.Property(e => e.LabDate)
                    .HasColumnName("LAB_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.LabNo).HasColumnName("LAB_NO");

                entity.Property(e => e.PltHisto)
                    .HasColumnName("PLT_HISTO")
                    .HasColumnType("image");

                entity.Property(e => e.RbcHisto)
                    .HasColumnName("RBC_HISTO")
                    .HasColumnType("image");

                entity.Property(e => e.Srno)
                    .HasColumnName("SRNO")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WbcHisto)
                    .HasColumnName("WBC_HISTO")
                    .HasColumnType("image");
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

            modelBuilder.Entity<Intgdet>(entity =>
            {
                entity.ToTable("INTGDET");

                entity.HasIndex(e => e.HeaderId)
                    .HasName("INTGDET_dochdrid");

                entity.Property(e => e.FieldValue).HasMaxLength(255);

                entity.Property(e => e.SysDateTime)
                    .HasColumnName("sysDateTime")
                    .HasColumnType("datetime");
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

            modelBuilder.Entity<LabMst>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LabMST");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

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

                entity.Property(e => e.LabWebserviceUrl)
                    .HasColumnName("LabWebserviceURL")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Labelgroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LABELGROUP");

                entity.Property(e => e.Active)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Grpid).HasColumnName("GRPID");

                entity.Property(e => e.Grpname)
                    .HasColumnName("GRPNAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Prefix)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Userid).HasMaxLength(50);
            });

            modelBuilder.Entity<MetroEmailLog>(entity =>
            {
                entity.HasKey(e => e.Logid)
                    .HasName("PK_MetroEmailLog_1");

                entity.Property(e => e.Pdfname)
                    .HasColumnName("PDFName")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SysDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Time)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Vid)
                    .HasColumnName("VID")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MylabTestDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MYLAB_TEST_DETAILS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MylabTestFieldnoOne).HasColumnName("MYLAB_TEST_FIELDNO_ONE");

                entity.Property(e => e.MylabTestFieldnoTwo).HasColumnName("MYLAB_TEST_FIELDNO_TWO");

                entity.Property(e => e.MylabTestMstid).HasColumnName("MYLAB_TEST_MSTID");

                entity.Property(e => e.TestId).HasColumnName("TEST_ID");

                entity.Property(e => e.TestName)
                    .IsRequired()
                    .HasColumnName("TEST_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MylabTestDetailsBa200>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MYLAB_TEST_DETAILS_BA200");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MylabTestFieldnoOne).HasColumnName("MYLAB_TEST_FIELDNO_ONE");

                entity.Property(e => e.MylabTestFieldnoTwo).HasColumnName("MYLAB_TEST_FIELDNO_TWO");

                entity.Property(e => e.MylabTestMstid).HasColumnName("MYLAB_TEST_MSTID");

                entity.Property(e => e.TestId).HasColumnName("TEST_ID");

                entity.Property(e => e.TestName)
                    .IsRequired()
                    .HasColumnName("TEST_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Narrations>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NARRATIONS");

                entity.Property(e => e.NarrationText).HasColumnType("ntext");
            });

            modelBuilder.Entity<Nextgendata>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NEXTGENDATA");

                entity.Property(e => e.BasPer)
                    .HasColumnName("BAS_PER")
                    .HasMaxLength(255);

                entity.Property(e => e.EosPer)
                    .HasColumnName("EOS_PER")
                    .HasMaxLength(255);

                entity.Property(e => e.GranNum)
                    .HasColumnName("GRAN_NUM")
                    .HasMaxLength(255);

                entity.Property(e => e.GranPer)
                    .HasColumnName("GRAN_PER")
                    .HasMaxLength(255);

                entity.Property(e => e.Hct)
                    .HasColumnName("HCT")
                    .HasMaxLength(255);

                entity.Property(e => e.Hgb)
                    .HasColumnName("HGB")
                    .HasMaxLength(255);

                entity.Property(e => e.LabDate)
                    .HasColumnName("LAB_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.LabNo).HasColumnName("LAB_NO");

                entity.Property(e => e.LymphNum)
                    .HasColumnName("LYMPH_NUM")
                    .HasMaxLength(255);

                entity.Property(e => e.LymphPer)
                    .HasColumnName("LYMPH_PER")
                    .HasMaxLength(255);

                entity.Property(e => e.Mch)
                    .HasColumnName("MCH")
                    .HasMaxLength(255);

                entity.Property(e => e.Mchc)
                    .HasColumnName("MCHC")
                    .HasMaxLength(255);

                entity.Property(e => e.Mcv)
                    .HasColumnName("MCV")
                    .HasMaxLength(255);

                entity.Property(e => e.MidNum)
                    .HasColumnName("MID_NUM")
                    .HasMaxLength(255);

                entity.Property(e => e.MidPer)
                    .HasColumnName("MID_PER")
                    .HasMaxLength(255);

                entity.Property(e => e.MonPer)
                    .HasColumnName("MON_PER")
                    .HasMaxLength(255);

                entity.Property(e => e.Mpv)
                    .HasColumnName("MPV")
                    .HasMaxLength(255);

                entity.Property(e => e.NeuPer)
                    .HasColumnName("NEU_PER")
                    .HasMaxLength(255);

                entity.Property(e => e.Pct)
                    .HasColumnName("PCT")
                    .HasMaxLength(255);

                entity.Property(e => e.Pdw)
                    .HasColumnName("PDW")
                    .HasMaxLength(255);

                entity.Property(e => e.Plt)
                    .HasColumnName("PLT")
                    .HasMaxLength(255);

                entity.Property(e => e.PltHistogram)
                    .HasColumnName("PLT_HISTOGRAM")
                    .HasColumnType("image");

                entity.Property(e => e.Rbc)
                    .HasColumnName("RBC")
                    .HasMaxLength(255);

                entity.Property(e => e.RbcHistogram)
                    .HasColumnName("RBC_HISTOGRAM")
                    .HasColumnType("image");

                entity.Property(e => e.RdwCv)
                    .HasColumnName("RDW_CV")
                    .HasMaxLength(255);

                entity.Property(e => e.RdwSd)
                    .HasColumnName("RDW_SD")
                    .HasMaxLength(255);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Wbc)
                    .HasColumnName("WBC")
                    .HasMaxLength(255);

                entity.Property(e => e.WbcHistogram)
                    .HasColumnName("WBC_HISTOGRAM")
                    .HasColumnType("image");
            });

            modelBuilder.Entity<Param>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Dc)
                    .HasColumnName("DC")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Formula)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PPrecision).HasColumnName("pPrecision");

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

                entity.Property(e => e.Sendsms)
                    .HasColumnName("SENDSMS")
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

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.ToTable("PATIENT");

                entity.HasIndex(e => e.Labno);

                entity.HasIndex(e => e.PatientDate)
                    .HasName("IX_PATIENT_PATIENT_DATE");

                entity.HasIndex(e => e.PatientDoctorid)
                    .HasName("IX_PATIENT_PATIENT_DOCTORID");

                entity.HasIndex(e => e.PatientSampleCollected)
                    .HasName("PATIENT_PATIENT_COLLECTIONCENTER");

                entity.HasIndex(e => e.PatientTelno)
                    .HasName("IX_PATIENT_Telno");

                entity.Property(e => e.PatientId)
                    .HasColumnName("PATIENT_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppointmentId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BarCopiese).HasColumnName("Bar_Copiese");

                entity.Property(e => e.BlnCommission)
                    .HasColumnName("blnCommission")
                    .HasMaxLength(1);

                entity.Property(e => e.Currentdate).HasColumnType("smalldatetime");

                entity.Property(e => e.Hosptype)
                    .HasColumnName("HOSPTYPE")
                    .HasMaxLength(50);

                entity.Property(e => e.Labno).HasColumnName("labno");

                entity.Property(e => e.PatientAddress1)
                    .HasColumnName("PATIENT_Address1")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientAddress2)
                    .HasColumnName("PATIENT_Address2")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientAge)
                    .HasColumnName("PATIENT_Age")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientAgeFlag)
                    .IsRequired()
                    .HasColumnName("PATIENT_AgeFlag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('E')");

                entity.Property(e => e.PatientAmountPaid).HasColumnName("PATIENT_AmountPaid");

                entity.Property(e => e.PatientCity)
                    .HasColumnName("PATIENT_City")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientCompanyid).HasColumnName("PATIENT_Companyid");

                entity.Property(e => e.PatientCountry).HasColumnName("PATIENT_Country");

                entity.Property(e => e.PatientDate)
                    .HasColumnName("PATIENT_Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PatientDoctorid).HasColumnName("PATIENT_Doctorid");

                entity.Property(e => e.PatientEmail)
                    .HasColumnName("PATIENT_Email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatientGender)
                    .HasColumnName("PATIENT_Gender")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientKey)
                    .HasColumnName("Patient_key")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PatientName)
                    .HasColumnName("PATIENT_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientPincode)
                    .HasColumnName("PATIENT_Pincode")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientRegion)
                    .HasColumnName("PATIENT_Region")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientSampleCollected).HasColumnName("PATIENT_SampleCollected");

                entity.Property(e => e.PatientState)
                    .HasColumnName("PATIENT_State")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientTelno)
                    .HasColumnName("PATIENT_Telno")
                    .HasMaxLength(50);

                entity.Property(e => e.PrintUrgent).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.SampleDate)
                    .HasColumnName("Sample_Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.TestAlias)
                    .HasColumnName("TEST_ALIAS")
                    .HasColumnType("ntext");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(50);

                entity.Property(e => e.WardNo).HasMaxLength(50);
            });

            modelBuilder.Entity<PatientBillDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PATIENT_BILL_DETAILS");

                entity.Property(e => e.BillCategory)
                    .IsRequired()
                    .HasColumnName("Bill_Category")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BillDate)
                    .HasColumnName("Bill_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.BillId)
                    .HasColumnName("Bill_id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.BillNo)
                    .HasColumnName("Bill_No")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CashPaid).HasColumnName("cashPaid");

                entity.Property(e => e.DoctorName1).HasMaxLength(255);

                entity.Property(e => e.DoctorName2).HasMaxLength(255);

                entity.Property(e => e.EmergencyCharge).HasColumnName("Emergency_Charge");

                entity.Property(e => e.Labno).HasColumnName("labno");

                entity.Property(e => e.Neftpaid)
                    .HasColumnName("NEFTPAID")
                    .HasColumnType("decimal(9, 2)");

                entity.Property(e => e.PatientAddress1)
                    .HasColumnName("Patient_address1")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientAddress2)
                    .HasColumnName("Patient_address2")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientAge)
                    .HasColumnName("Patient_Age")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientBillDetId)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PatientCity)
                    .HasColumnName("Patient_City")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientCollectionCenter)
                    .HasColumnName("Patient_Collection_Center")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientCountry)
                    .HasColumnName("Patient_Country")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientDate)
                    .HasColumnName("Patient_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PatientId).HasColumnName("Patient_id");

                entity.Property(e => e.PatientName)
                    .HasColumnName("Patient_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientPincode)
                    .HasColumnName("Patient_Pincode")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientRegion)
                    .HasColumnName("Patient_Region")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientSex)
                    .HasColumnName("Patient_Sex")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientState)
                    .HasColumnName("Patient_State")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientTelNo)
                    .HasColumnName("Patient_TelNo")
                    .HasMaxLength(50);

                entity.Property(e => e.TestName).HasMaxLength(255);

                entity.Property(e => e.Upipaid)
                    .HasColumnName("UPIPaid")
                    .HasColumnType("decimal(9, 2)");
            });

            modelBuilder.Entity<PatientHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PATIENT_history");

                entity.Property(e => e.BarCopiese).HasColumnName("Bar_Copiese");

                entity.Property(e => e.BlnCommission)
                    .HasColumnName("blnCommission")
                    .HasMaxLength(1);

                entity.Property(e => e.Currentdate).HasColumnType("smalldatetime");

                entity.Property(e => e.HistoryDate)
                    .HasColumnName("History_Date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HistoryId)
                    .HasColumnName("History_Id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Hosptype)
                    .HasColumnName("HOSPTYPE")
                    .HasMaxLength(50);

                entity.Property(e => e.Labno).HasColumnName("labno");

                entity.Property(e => e.PatientAddress1)
                    .HasColumnName("PATIENT_Address1")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientAddress2)
                    .HasColumnName("PATIENT_Address2")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientAge)
                    .HasColumnName("PATIENT_Age")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientAgeFlag)
                    .IsRequired()
                    .HasColumnName("PATIENT_AgeFlag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PatientAmountPaid).HasColumnName("PATIENT_AmountPaid");

                entity.Property(e => e.PatientCity)
                    .HasColumnName("PATIENT_City")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientCompanyid).HasColumnName("PATIENT_Companyid");

                entity.Property(e => e.PatientCountry)
                    .HasColumnName("PATIENT_Country")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientDate)
                    .HasColumnName("PATIENT_Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PatientDoctorid).HasColumnName("PATIENT_Doctorid");

                entity.Property(e => e.PatientGender)
                    .HasColumnName("PATIENT_Gender")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientId).HasColumnName("PATIENT_id");

                entity.Property(e => e.PatientName)
                    .HasColumnName("PATIENT_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientPincode)
                    .HasColumnName("PATIENT_Pincode")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientRegion)
                    .HasColumnName("PATIENT_Region")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientSampleCollected).HasColumnName("PATIENT_SampleCollected");

                entity.Property(e => e.PatientState)
                    .HasColumnName("PATIENT_State")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientTelno)
                    .HasColumnName("PATIENT_Telno")
                    .HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.SampleDate)
                    .HasColumnName("Sample_Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.TestAlias)
                    .HasColumnName("TEST_ALIAS")
                    .HasColumnType("ntext");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(50);

                entity.Property(e => e.WardNo).HasMaxLength(50);
            });

            modelBuilder.Entity<PatientMaster>(entity =>
            {
                entity.HasKey(e => e.PatientId);

                entity.ToTable("PATIENT_MASTER");

                entity.HasIndex(e => e.PatientCode)
                    .HasName("IX_PATIENT_MASTER_patientcode");

                entity.HasIndex(e => e.PatientDateofJoining)
                    .HasName("IX_PATIENT_MASTER_dateofjoining");

                entity.HasIndex(e => e.PatientMobileNo)
                    .HasName("IX_PATIENT_MASTER_1");

                entity.Property(e => e.PatientId)
                    .HasColumnName("PATIENT_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CenterId).HasColumnName("Center_id");

                entity.Property(e => e.PatientAddress1)
                    .HasColumnName("PATIENT_Address1")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientAddress2)
                    .HasColumnName("PATIENT_Address2")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientAge)
                    .HasColumnName("Patient_Age")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientCity)
                    .HasColumnName("PATIENT_City")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientCode)
                    .HasColumnName("Patient_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PatientCompanyid).HasColumnName("PATIENT_Companyid");

                entity.Property(e => e.PatientCountry)
                    .HasColumnName("PATIENT_Country")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientDateofBirth)
                    .HasColumnName("Patient_DateofBirth")
                    .HasColumnType("datetime");

                entity.Property(e => e.PatientDateofJoining)
                    .HasColumnName("PATIENT_DateofJoining")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientDoctorId).HasColumnName("PATIENT_DOCTOR_ID");

                entity.Property(e => e.PatientEmail)
                    .HasColumnName("PATIENT_Email")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientGender).HasColumnName("PATIENT_Gender");

                entity.Property(e => e.PatientMobileNo)
                    .HasColumnName("PATIENT_MobileNo")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientName)
                    .HasColumnName("PATIENT_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientPincode)
                    .HasColumnName("PATIENT_Pincode")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientQualification)
                    .HasColumnName("PATIENT_Qualification")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientRegion)
                    .HasColumnName("PATIENT_Region")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientSalary).HasColumnName("PATIENT_Salary");

                entity.Property(e => e.PatientSalaryType)
                    .HasColumnName("PATIENT_SalaryType")
                    .HasMaxLength(1);

                entity.Property(e => e.PatientState)
                    .HasColumnName("PATIENT_State")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientStatus).HasColumnName("PATIENT_Status");

                entity.Property(e => e.PatientTelno)
                    .HasColumnName("PATIENT_Telno")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PatientPortal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Patient_Portal");

                entity.Property(e => e.Age)
                    .HasColumnName("age")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNo)
                    .HasColumnName("Contact_no")
                    .HasMaxLength(50);

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.PatientId)
                    .HasColumnName("Patient_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PatientName)
                    .HasColumnName("Patient_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Pincode).HasMaxLength(10);

                entity.Property(e => e.RegDate).HasColumnType("datetime");

                entity.Property(e => e.RowSent)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.State).HasMaxLength(50);
            });

            modelBuilder.Entity<PatientProfilePic>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ContactNumber)
                    .HasColumnName("Contact_Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProfilePic)
                    .HasColumnName("Profile_Pic")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<PayRemDetail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BillAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BillDate).HasColumnType("datetime");

                entity.Property(e => e.Deduction).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FinYear)
                    .IsRequired()
                    .HasColumnName("Fin_year")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PayRemDetlId).ValueGeneratedOnAdd();

                entity.Property(e => e.RecAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Tds)
                    .HasColumnName("TDS")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<PayRemHeader>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BillType)
                    .HasColumnName("Bill_Type")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CenterId).HasColumnName("Center_id");

                entity.Property(e => e.PayRemId).HasColumnName("PayRemID");

                entity.Property(e => e.RefDate).HasColumnType("datetime");

                entity.Property(e => e.RefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pdflog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PDFLog");
            });

            modelBuilder.Entity<PhelobotomistHomeVisit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Phelobotomist_HomeVisit");

                entity.Property(e => e.Age)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Area)
                    .HasColumnName("AREA")
                    .HasMaxLength(50);

                entity.Property(e => e.Attachment)
                    .HasColumnName("ATTACHMENT")
                    .HasMaxLength(50);

                entity.Property(e => e.BookingDate).HasColumnType("datetime");

                entity.Property(e => e.Decision)
                    .HasColumnName("DECISION")
                    .HasMaxLength(50);

                entity.Property(e => e.Discount)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Flag).HasColumnName("FLAG");

                entity.Property(e => e.Gender)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.HomeVisitId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NewPheloId).HasMaxLength(50);

                entity.Property(e => e.NewPheloName).HasMaxLength(100);

                entity.Property(e => e.PatientAdd)
                    .HasColumnName("patient_add")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PatientContact)
                    .HasColumnName("PATIENT_CONTACT")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatientName)
                    .HasColumnName("PATIENT_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.PaybleAmount).HasMaxLength(20);

                entity.Property(e => e.PaymentMode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhelobotomistId)
                    .HasColumnName("Phelobotomist_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.PhlebomistContact)
                    .HasColumnName("PHLEBOMIST_CONTACT")
                    .HasMaxLength(50);

                entity.Property(e => e.PhlebomistUsername)
                    .HasColumnName("PHLEBOMIST_USERNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Reason)
                    .HasColumnName("REASON")
                    .HasMaxLength(50);

                entity.Property(e => e.ReferenceDoctor)
                    .HasColumnName("Reference_Doctor")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SampleCollected)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SystDate)
                    .HasColumnName("SYST_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Time)
                    .HasColumnName("TIME")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PhlebomistCollectedTest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PHLEBOMIST_COLLECTED_TEST");

                entity.Property(e => e.AccepthmvstId)
                    .HasColumnName("ACCEPTHMVST_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.Flag).HasColumnName("FLAG");

                entity.Property(e => e.HomeVisitId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PatientContact)
                    .HasColumnName("PAtientContact")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PatientName)
                    .HasColumnName("PATIENT_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.PhlebotomistId)
                    .HasColumnName("PHLEBOTOMIST_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.PhlebotomistName)
                    .HasColumnName("PHLEBOTOMIST_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.SystDate)
                    .HasColumnName("SYST_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.TestId)
                    .HasColumnName("TestID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TestName)
                    .HasColumnName("TEST_NAME")
                    .HasMaxLength(500);

                entity.Property(e => e.TestType).HasMaxLength(50);
            });

            modelBuilder.Entity<Predefval>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PREDEFVAL");

                entity.Property(e => e.PredefvalFieldid).HasColumnName("PREDEFVAL_Fieldid");

                entity.Property(e => e.PredefvalId).HasColumnName("PREDEFVAL_Id");

                entity.Property(e => e.PredefvalValNo).HasColumnName("PREDEFVAL_ValNo");

                entity.Property(e => e.PredefvalValue)
                    .HasColumnName("PREDEFVAL_Value")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Profdet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PROFDET");

                entity.Property(e => e.TestId).HasColumnName("testId");
            });

            modelBuilder.Entity<QerAmountpaid>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_AMOUNTPAID");
            });

            modelBuilder.Entity<QerAmountpaidtype>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_AMOUNTPAIDType");

                entity.Property(e => e.CollectedatHospitalPaid).HasColumnName("COLLECTEDAtHospitalPaid");

                entity.Property(e => e.Neftpaid).HasColumnName("NEFTPaid");

                entity.Property(e => e.Upipaid).HasColumnName("UPIPaid");
            });

            modelBuilder.Entity<QerBalamt>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_BALAMT");

                entity.Property(e => e.CenterId).HasColumnName("CENTER_id");

                entity.Property(e => e.CenterName)
                    .HasColumnName("CENTER_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.CenterRegion)
                    .HasColumnName("CENTER_Region")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorMobileNo)
                    .HasColumnName("DOCTOR_MobileNo")
                    .HasMaxLength(50);

                entity.Property(e => e.DoctorName)
                    .HasColumnName("DOCTOR_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Labno).HasColumnName("labno");

                entity.Property(e => e.PatientDate)
                    .HasColumnName("PATIENT_Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PatientId).HasColumnName("PATIENT_id");

                entity.Property(e => e.PatientName)
                    .HasColumnName("PATIENT_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientPincode)
                    .HasColumnName("PATIENT_Pincode")
                    .HasMaxLength(50);

                entity.Property(e => e.TestAlias)
                    .HasColumnName("TEST_ALIAS")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<QerBidirection>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_BIDIRECTION");

                entity.Property(e => e.DochdrDDate)
                    .HasColumnName("DOCHDR_dDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DochdrLDocumentId).HasColumnName("DOCHDR_lDocumentId");

                entity.Property(e => e.DochdrLPatientId).HasColumnName("DOCHDR_lPatientId");

                entity.Property(e => e.DochdrSDocNo)
                    .HasColumnName("DOCHDR_sDocNo")
                    .HasMaxLength(50);

                entity.Property(e => e.DochdrTestCatId).HasColumnName("DOCHDR_TestCatID");

                entity.Property(e => e.DoctorName)
                    .HasColumnName("DOCTOR_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Labno).HasColumnName("labno");

                entity.Property(e => e.MarkComplete).HasMaxLength(1);

                entity.Property(e => e.PatientAge)
                    .HasColumnName("PATIENT_Age")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientGender)
                    .HasColumnName("PATIENT_Gender")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientName)
                    .HasColumnName("PATIENT_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.ProfileName).HasMaxLength(255);

                entity.Property(e => e.SampleDate)
                    .HasColumnName("Sample_Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.TestmstCurrentId).HasColumnName("TESTMST_CurrentId");

                entity.Property(e => e.TestmstName)
                    .HasColumnName("TESTMST_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.TestmstPrintFormat)
                    .HasColumnName("TESTMST_PrintFormat")
                    .HasMaxLength(255);

                entity.Property(e => e.TestmstTestTypeId).HasColumnName("TESTMST_TestTypeId");

                entity.Property(e => e.Type).HasMaxLength(1);

                entity.Property(e => e.WardNo).HasMaxLength(50);
            });

            modelBuilder.Entity<QerBill>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_BILL");

                entity.Property(e => e.Active).HasMaxLength(1);

                entity.Property(e => e.BarCopiese).HasColumnName("Bar_Copiese");

                entity.Property(e => e.BlnCommission)
                    .HasColumnName("blnCommission")
                    .HasMaxLength(1);

                entity.Property(e => e.CenterName)
                    .HasColumnName("CENTER_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Comments).HasColumnType("ntext");

                entity.Property(e => e.Currentdate).HasColumnType("smalldatetime");

                entity.Property(e => e.DochdrRate).HasColumnName("DOCHDR_Rate");

                entity.Property(e => e.DoctorName)
                    .HasColumnName("DOCTOR_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorName1)
                    .HasColumnName("DOCTOR_Name1")
                    .HasMaxLength(255);

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("EMPLOYEE_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Hosptype)
                    .HasColumnName("HOSPTYPE")
                    .HasMaxLength(50);

                entity.Property(e => e.Labno).HasColumnName("labno");

                entity.Property(e => e.PatientAddress1)
                    .HasColumnName("PATIENT_Address1")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientAddress2)
                    .HasColumnName("PATIENT_Address2")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientAge)
                    .HasColumnName("PATIENT_Age")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientAgeFlag)
                    .HasColumnName("PATIENT_AgeFlag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PatientAmountPaid).HasColumnName("PATIENT_AmountPaid");

                entity.Property(e => e.PatientCity)
                    .HasColumnName("PATIENT_City")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientCompanyid).HasColumnName("PATIENT_Companyid");

                entity.Property(e => e.PatientCountry).HasColumnName("PATIENT_Country");

                entity.Property(e => e.PatientDate)
                    .HasColumnName("PATIENT_Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PatientDoctorid).HasColumnName("PATIENT_Doctorid");

                entity.Property(e => e.PatientGender)
                    .HasColumnName("PATIENT_Gender")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientId).HasColumnName("PATIENT_id");

                entity.Property(e => e.PatientName)
                    .HasColumnName("PATIENT_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientPincode)
                    .HasColumnName("PATIENT_Pincode")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientRegion)
                    .HasColumnName("PATIENT_Region")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientSampleCollected).HasColumnName("PATIENT_SampleCollected");

                entity.Property(e => e.PatientState)
                    .HasColumnName("PATIENT_State")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientTelno)
                    .HasColumnName("PATIENT_Telno")
                    .HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.SampleDate)
                    .HasColumnName("Sample_Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.SpecialTest).HasMaxLength(1);

                entity.Property(e => e.TestAlias)
                    .HasColumnName("TEST_ALIAS")
                    .HasColumnType("ntext");

                entity.Property(e => e.TestmstAlias)
                    .HasColumnName("TESTMST_Alias")
                    .HasMaxLength(50);

                entity.Property(e => e.TestmstCatType)
                    .HasColumnName("TESTMST_CatType")
                    .HasMaxLength(3);

                entity.Property(e => e.TestmstCompanyid).HasColumnName("TESTMST_Companyid");

                entity.Property(e => e.TestmstCurrentId).HasColumnName("TESTMST_CurrentId");

                entity.Property(e => e.TestmstLumsum).HasColumnName("TESTMST_Lumsum");

                entity.Property(e => e.TestmstName)
                    .HasColumnName("TESTMST_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.TestmstPercentage).HasColumnName("TESTMST_Percentage");

                entity.Property(e => e.TestmstPrintFormat)
                    .HasColumnName("TESTMST_PrintFormat")
                    .HasMaxLength(255);

                entity.Property(e => e.TestmstRate).HasColumnName("TESTMST_Rate");

                entity.Property(e => e.TestmstReportHeading)
                    .HasColumnName("TESTMST_ReportHeading")
                    .HasMaxLength(255);

                entity.Property(e => e.TestmstSample)
                    .HasColumnName("TESTMST_sample")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TestmstTestTypeId).HasColumnName("TESTMST_TestTypeId");

                entity.Property(e => e.TestmstTestcost).HasColumnName("TESTMST_Testcost");

                entity.Property(e => e.Type).HasMaxLength(1);

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(50);

                entity.Property(e => e.WardNo).HasMaxLength(50);
            });

            modelBuilder.Entity<QerCbcWorkSheet>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_CBC_WorkSheet");

                entity.Property(e => e.DocdetLFieldNo).HasColumnName("DOCDET_lFieldNo");

                entity.Property(e => e.DocdetTFieldValue)
                    .HasColumnName("DOCDET_tFieldValue")
                    .HasMaxLength(255);

                entity.Property(e => e.DochdrAge)
                    .HasColumnName("DOCHDR_Age")
                    .HasMaxLength(50);

                entity.Property(e => e.DochdrDDate)
                    .HasColumnName("DOCHDR_dDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DochdrLDoctorId).HasColumnName("DOCHDR_lDoctorId");

                entity.Property(e => e.DochdrLDocumentId).HasColumnName("DOCHDR_lDocumentId");

                entity.Property(e => e.DochdrSex)
                    .HasColumnName("DOCHDR_Sex")
                    .HasMaxLength(50);

                entity.Property(e => e.DochdrTestCatId).HasColumnName("DOCHDR_TestCatID");

                entity.Property(e => e.Labno).HasColumnName("labno");

                entity.Property(e => e.PatientId).HasColumnName("PATIENT_id");

                entity.Property(e => e.PatientName)
                    .HasColumnName("PATIENT_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.TestdetFieldName)
                    .HasColumnName("TESTDET_FieldName")
                    .HasMaxLength(255);

                entity.Property(e => e.TestdetSAlias)
                    .HasColumnName("TESTDET_sAlias")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<QerCollection>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_COLLECTION");

                entity.Property(e => e.DochdrDDate)
                    .HasColumnName("DOCHDR_dDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DochdrLPatientId).HasColumnName("DOCHDR_lPatientId");

                entity.Property(e => e.DochdrRate).HasColumnName("DOCHDR_Rate");

                entity.Property(e => e.IsProfile)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TestmstAlias)
                    .HasColumnName("TESTMST_Alias")
                    .HasMaxLength(50);

                entity.Property(e => e.TestmstName)
                    .HasColumnName("TESTMST_Name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<QerCollectionCenterBillDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QerCollectionCenterBillDetail");

                entity.Property(e => e.CenterId).HasColumnName("CENTER_id");

                entity.Property(e => e.DoctorName)
                    .HasColumnName("DOCTOR_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientDate)
                    .HasColumnName("PATIENT_Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PatientId).HasColumnName("PATIENT_id");

                entity.Property(e => e.PatientName)
                    .HasColumnName("PATIENT_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientPincode)
                    .HasColumnName("PATIENT_Pincode")
                    .HasMaxLength(50);

                entity.Property(e => e.ProposalNo)
                    .IsRequired()
                    .HasColumnName("Proposal_No")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QerComparerate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_COMPARERATE");

                entity.Property(e => e.CenterName)
                    .HasColumnName("CENTER_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.TestmstName)
                    .HasColumnName("TESTMST_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Type).HasMaxLength(1);
            });

            modelBuilder.Entity<QerDailyregister>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_DAILYREGISTER");

                entity.Property(e => e.BarCopiese).HasColumnName("Bar_Copiese");

                entity.Property(e => e.BlnCommission)
                    .HasColumnName("blnCommission")
                    .HasMaxLength(1);

                entity.Property(e => e.CenterName)
                    .HasColumnName("CENTER_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Currentdate).HasColumnType("smalldatetime");

                entity.Property(e => e.DoctorName)
                    .HasColumnName("DOCTOR_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Hosptype)
                    .HasColumnName("HOSPTYPE")
                    .HasMaxLength(50);

                entity.Property(e => e.Labno).HasColumnName("labno");

                entity.Property(e => e.PatientAddress1)
                    .HasColumnName("PATIENT_Address1")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientAddress2)
                    .HasColumnName("PATIENT_Address2")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientAge)
                    .HasColumnName("PATIENT_Age")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientAgeFlag)
                    .IsRequired()
                    .HasColumnName("PATIENT_AgeFlag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PatientAmountPaid).HasColumnName("PATIENT_AmountPaid");

                entity.Property(e => e.PatientCity)
                    .HasColumnName("PATIENT_City")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientCompanyid).HasColumnName("PATIENT_Companyid");

                entity.Property(e => e.PatientCountry).HasColumnName("PATIENT_Country");

                entity.Property(e => e.PatientDate)
                    .HasColumnName("PATIENT_Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PatientDoctorid).HasColumnName("PATIENT_Doctorid");

                entity.Property(e => e.PatientGender)
                    .HasColumnName("PATIENT_Gender")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientId).HasColumnName("PATIENT_id");

                entity.Property(e => e.PatientName)
                    .HasColumnName("PATIENT_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientPincode)
                    .HasColumnName("PATIENT_Pincode")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientRegion)
                    .HasColumnName("PATIENT_Region")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientSampleCollected).HasColumnName("PATIENT_SampleCollected");

                entity.Property(e => e.PatientState)
                    .HasColumnName("PATIENT_State")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientTelno)
                    .HasColumnName("PATIENT_Telno")
                    .HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.SampleDate)
                    .HasColumnName("Sample_Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.TestAlias)
                    .HasColumnName("TEST_ALIAS")
                    .HasColumnType("ntext");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(50);

                entity.Property(e => e.WardNo).HasMaxLength(50);
            });

            modelBuilder.Entity<QerDailyregrefund>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_DAILYREGREFUND");

                entity.Property(e => e.BarCopiese).HasColumnName("Bar_Copiese");

                entity.Property(e => e.BlnCommission)
                    .HasColumnName("blnCommission")
                    .HasMaxLength(1);

                entity.Property(e => e.CenterName)
                    .HasColumnName("CENTER_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Currentdate).HasColumnType("smalldatetime");

                entity.Property(e => e.DoctorName)
                    .HasColumnName("DOCTOR_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Hosptype)
                    .HasColumnName("HOSPTYPE")
                    .HasMaxLength(50);

                entity.Property(e => e.Labno).HasColumnName("labno");

                entity.Property(e => e.PatientAddress1)
                    .HasColumnName("PATIENT_Address1")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientAddress2)
                    .HasColumnName("PATIENT_Address2")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientAge)
                    .HasColumnName("PATIENT_Age")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientAgeFlag)
                    .IsRequired()
                    .HasColumnName("PATIENT_AgeFlag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PatientAmountPaid).HasColumnName("PATIENT_AmountPaid");

                entity.Property(e => e.PatientCity)
                    .HasColumnName("PATIENT_City")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientCompanyid).HasColumnName("PATIENT_Companyid");

                entity.Property(e => e.PatientCountry).HasColumnName("PATIENT_Country");

                entity.Property(e => e.PatientDate)
                    .HasColumnName("PATIENT_Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PatientDoctorid).HasColumnName("PATIENT_Doctorid");

                entity.Property(e => e.PatientGender)
                    .HasColumnName("PATIENT_Gender")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientId).HasColumnName("PATIENT_id");

                entity.Property(e => e.PatientName)
                    .HasColumnName("PATIENT_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientPincode)
                    .HasColumnName("PATIENT_Pincode")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientRegion)
                    .HasColumnName("PATIENT_Region")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientSampleCollected).HasColumnName("PATIENT_SampleCollected");

                entity.Property(e => e.PatientState)
                    .HasColumnName("PATIENT_State")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientTelno)
                    .HasColumnName("PATIENT_Telno")
                    .HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.SampleDate)
                    .HasColumnName("Sample_Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.TestAlias)
                    .HasColumnName("TEST_ALIAS")
                    .HasColumnType("ntext");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(50);

                entity.Property(e => e.WardNo).HasMaxLength(50);
            });

            modelBuilder.Entity<QerDispatchregister>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_DISPATCHREGISTER");

                entity.Property(e => e.BlnCommission)
                    .HasColumnName("blnCommission")
                    .HasMaxLength(1);

                entity.Property(e => e.CenterName)
                    .HasColumnName("CENTER_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.CenterRegion)
                    .HasColumnName("CENTER_Region")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorName)
                    .HasColumnName("DOCTOR_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorName2)
                    .HasColumnName("DOCTOR_Name2")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorRegion)
                    .HasColumnName("DOCTOR_Region")
                    .HasMaxLength(255);

                entity.Property(e => e.Labno).HasColumnName("labno");

                entity.Property(e => e.PatientDate)
                    .HasColumnName("PATIENT_Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PatientEmail)
                    .HasColumnName("PATIENT_Email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("PATIENT_id");

                entity.Property(e => e.PatientName)
                    .HasColumnName("PATIENT_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientPincode)
                    .HasColumnName("PATIENT_Pincode")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientSampleCollected).HasColumnName("PATIENT_SampleCollected");

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.TamtPaid).HasColumnName("TAmtPaid");

                entity.Property(e => e.TamtRefund).HasColumnName("TAmtRefund");

                entity.Property(e => e.TestAlias)
                    .HasColumnName("TEST_ALIAS")
                    .HasColumnType("ntext");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<QerDoctorComm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_DOCTOR_COMM");

                entity.Property(e => e.CenterName)
                    .HasColumnName("CENTER_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.DochdrDDate)
                    .HasColumnName("DOCHDR_dDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DochdrRate).HasColumnName("DOCHDR_Rate");

                entity.Property(e => e.DochdrSDocNo)
                    .HasColumnName("DOCHDR_sDocNo")
                    .HasMaxLength(50);

                entity.Property(e => e.DochdrTestCatId).HasColumnName("DOCHDR_TestCatID");

                entity.Property(e => e.DoctorCommission).HasColumnName("DOCTOR_Commission");

                entity.Property(e => e.DoctorEx1commission).HasColumnName("DOCTOR_EX1Commission");

                entity.Property(e => e.DoctorExcommission).HasColumnName("DOCTOR_EXCommission");

                entity.Property(e => e.DoctorHcommission).HasColumnName("DOCTOR_HCommission");

                entity.Property(e => e.DoctorMcommission).HasColumnName("DOCTOR_MCommission");

                entity.Property(e => e.DoctorName)
                    .HasColumnName("DOCTOR_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorOcommission).HasColumnName("DOCTOR_OCommission");

                entity.Property(e => e.DoctorPfcommission).HasColumnName("DOCTOR_PFCommission");

                entity.Property(e => e.DoctorRcommission).HasColumnName("DOCTOR_RCommission");

                entity.Property(e => e.DoctorScommission).HasColumnName("DOCTOR_SCommission");

                entity.Property(e => e.DoctorSpcommission).HasColumnName("DOCTOR_SPCommission");

                entity.Property(e => e.DoctorXcommission).HasColumnName("DOCTOR_XCommission");

                entity.Property(e => e.Labno).HasColumnName("labno");

                entity.Property(e => e.PatientAmountPaid).HasColumnName("PATIENT_AmountPaid");

                entity.Property(e => e.PatientDate)
                    .HasColumnName("PATIENT_Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PatientDoctorid).HasColumnName("PATIENT_Doctorid");

                entity.Property(e => e.PatientId).HasColumnName("PATIENT_id");

                entity.Property(e => e.PatientName)
                    .HasColumnName("PATIENT_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientSampleCollected).HasColumnName("PATIENT_SampleCollected");

                entity.Property(e => e.TestmstName)
                    .HasColumnName("TESTMST_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Type).HasMaxLength(1);

                entity.Property(e => e.WardNo).HasMaxLength(50);
            });

            modelBuilder.Entity<QerDoctorCommission>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_DOCTOR_COMMISSION");

                entity.Property(e => e.CenterName)
                    .HasColumnName("CENTER_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.CenterRegion)
                    .HasColumnName("CENTER_Region")
                    .HasMaxLength(255);

                entity.Property(e => e.DochdrBCommission).HasColumnName("DOCHDR_bCommission");

                entity.Property(e => e.DochdrLDoctorId).HasColumnName("DOCHDR_lDoctorId");

                entity.Property(e => e.DochdrLPatientId).HasColumnName("DOCHDR_lPatientId");

                entity.Property(e => e.DochdrRate).HasColumnName("DOCHDR_Rate");

                entity.Property(e => e.DochdrSample).HasColumnName("DOCHDR_Sample");

                entity.Property(e => e.DochdrTestCatId).HasColumnName("DOCHDR_TestCatID");

                entity.Property(e => e.DoctorAddress1)
                    .HasColumnName("DOCTOR_Address1")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorCity)
                    .HasColumnName("DOCTOR_City")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorName)
                    .HasColumnName("DOCTOR_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorRegion)
                    .HasColumnName("DOCTOR_Region")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorState)
                    .HasColumnName("DOCTOR_State")
                    .HasMaxLength(255);

                entity.Property(e => e.Labno).HasColumnName("labno");

                entity.Property(e => e.PatientDate)
                    .HasColumnName("PATIENT_Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PatientDiscount).HasColumnName("Patient_Discount");

                entity.Property(e => e.PatientName)
                    .HasColumnName("PATIENT_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.SpecialTest).HasMaxLength(1);

                entity.Property(e => e.TestmstAlias)
                    .HasColumnName("TESTMST_Alias")
                    .HasMaxLength(50);

                entity.Property(e => e.WardNo).HasMaxLength(50);
            });

            modelBuilder.Entity<QerDoctorCommissionOld>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_DOCTOR_COMMISSION_OLD");

                entity.Property(e => e.CenterName)
                    .HasColumnName("CENTER_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.CenterRegion)
                    .HasColumnName("CENTER_Region")
                    .HasMaxLength(255);

                entity.Property(e => e.DochdrBCommission).HasColumnName("DOCHDR_bCommission");

                entity.Property(e => e.DochdrLDoctorId).HasColumnName("DOCHDR_lDoctorId");

                entity.Property(e => e.DochdrLPatientId).HasColumnName("DOCHDR_lPatientId");

                entity.Property(e => e.DochdrRate).HasColumnName("DOCHDR_Rate");

                entity.Property(e => e.DochdrSample).HasColumnName("DOCHDR_Sample");

                entity.Property(e => e.DochdrTestCatId).HasColumnName("DOCHDR_TestCatID");

                entity.Property(e => e.DoctorName)
                    .HasColumnName("DOCTOR_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Labno).HasColumnName("labno");

                entity.Property(e => e.PatientDate)
                    .HasColumnName("PATIENT_Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PatientDiscount).HasColumnName("Patient_Discount");

                entity.Property(e => e.PatientName)
                    .HasColumnName("PATIENT_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.SpecialTest).HasMaxLength(1);

                entity.Property(e => e.TestmstAlias)
                    .HasColumnName("TESTMST_Alias")
                    .HasMaxLength(50);

                entity.Property(e => e.WardNo).HasMaxLength(50);
            });

            modelBuilder.Entity<QerDoctorlist>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_DOCTORLIST");

                entity.Property(e => e.CenterName)
                    .HasColumnName("CENTER_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorEmail)
                    .HasColumnName("DOCTOR_Email")
                    .HasMaxLength(50);

                entity.Property(e => e.DoctorMobileNo)
                    .HasColumnName("DOCTOR_MobileNo")
                    .HasMaxLength(50);

                entity.Property(e => e.DoctorName)
                    .HasColumnName("DOCTOR_Name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<QerDoctorwiseCommission>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_DOCTORWISE_COMMISSION");

                entity.Property(e => e.CenterName)
                    .HasColumnName("CENTER_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.DochdrBCommission).HasColumnName("DOCHDR_bCommission");

                entity.Property(e => e.DochdrLDoctorId).HasColumnName("DOCHDR_lDoctorId");

                entity.Property(e => e.DochdrLPatientId).HasColumnName("DOCHDR_lPatientId");

                entity.Property(e => e.DochdrRate).HasColumnName("DOCHDR_Rate");

                entity.Property(e => e.DochdrSample).HasColumnName("DOCHDR_Sample");

                entity.Property(e => e.DochdrTestCatId).HasColumnName("DOCHDR_TestCatID");

                entity.Property(e => e.DoctorName)
                    .HasColumnName("DOCTOR_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Ex1Comm).HasColumnName("EX1_COMM");

                entity.Property(e => e.ExComm).HasColumnName("EX_COMM");

                entity.Property(e => e.HcComm).HasColumnName("HC_COMM");

                entity.Property(e => e.Labno).HasColumnName("labno");

                entity.Property(e => e.MComm).HasColumnName("M_COMM");

                entity.Property(e => e.OComm).HasColumnName("O_COMM");

                entity.Property(e => e.PatientDate)
                    .HasColumnName("PATIENT_Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PatientName)
                    .HasColumnName("PATIENT_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.PfComm).HasColumnName("PF_COMM");

                entity.Property(e => e.RComm).HasColumnName("R_COMM");

                entity.Property(e => e.SComm).HasColumnName("S_Comm");

                entity.Property(e => e.SpComm).HasColumnName("SP_COMM");

                entity.Property(e => e.SpecialTest).HasMaxLength(1);

                entity.Property(e => e.TestmstCatType)
                    .HasColumnName("TESTMST_CatType")
                    .HasMaxLength(3);

                entity.Property(e => e.TestmstName)
                    .HasColumnName("TESTMST_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.WardNo).HasMaxLength(50);

                entity.Property(e => e.XComm).HasColumnName("X_Comm");
            });

            modelBuilder.Entity<QerDoctorwiseCommissionOld>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_DOCTORWISE_COMMISSION_OLD");

                entity.Property(e => e.CenterName)
                    .HasColumnName("CENTER_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.DochdrBCommission).HasColumnName("DOCHDR_bCommission");

                entity.Property(e => e.DochdrLDoctorId).HasColumnName("DOCHDR_lDoctorId");

                entity.Property(e => e.DochdrLPatientId).HasColumnName("DOCHDR_lPatientId");

                entity.Property(e => e.DochdrRate).HasColumnName("DOCHDR_Rate");

                entity.Property(e => e.DochdrSample).HasColumnName("DOCHDR_SAMPLE");

                entity.Property(e => e.DochdrTestCatId).HasColumnName("DOCHDR_TestCatID");

                entity.Property(e => e.DoctorName)
                    .HasColumnName("DOCTOR_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Ex1Comm).HasColumnName("EX1_COMM");

                entity.Property(e => e.ExComm).HasColumnName("EX_COMM");

                entity.Property(e => e.HcComm).HasColumnName("HC_COMM");

                entity.Property(e => e.Labno).HasColumnName("labno");

                entity.Property(e => e.MComm).HasColumnName("M_COMM");

                entity.Property(e => e.OComm).HasColumnName("O_COMM");

                entity.Property(e => e.PatientDate)
                    .HasColumnName("PATIENT_Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PatientName)
                    .HasColumnName("PATIENT_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.PfComm).HasColumnName("PF_COMM");

                entity.Property(e => e.RComm).HasColumnName("R_COMM");

                entity.Property(e => e.SComm).HasColumnName("S_Comm");

                entity.Property(e => e.SpComm).HasColumnName("SP_COMM");

                entity.Property(e => e.SpecialTest).HasMaxLength(1);

                entity.Property(e => e.TestmstCattype)
                    .HasColumnName("TESTMST_CATTYPE")
                    .HasMaxLength(3);

                entity.Property(e => e.TestmstName)
                    .HasColumnName("TESTMST_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.WardNo).HasMaxLength(50);

                entity.Property(e => e.XComm).HasColumnName("X_Comm");
            });

            modelBuilder.Entity<QerFilldata>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_FILLDATA");

                entity.Property(e => e.CenterName)
                    .HasColumnName("CENTER_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.DochdrDDate)
                    .HasColumnName("DOCHDR_dDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DochdrLDocumentId).HasColumnName("DOCHDR_lDocumentId");

                entity.Property(e => e.DochdrLPatientId).HasColumnName("DOCHDR_lPatientId");

                entity.Property(e => e.DochdrSDocNo)
                    .HasColumnName("DOCHDR_sDocNo")
                    .HasMaxLength(50);

                entity.Property(e => e.DochdrTestCatId).HasColumnName("DOCHDR_TestCatID");

                entity.Property(e => e.DoctorMobileNo)
                    .HasColumnName("DOCTOR_MobileNo")
                    .HasMaxLength(50);

                entity.Property(e => e.DoctorName)
                    .HasColumnName("DOCTOR_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.EmailDate).HasColumnType("datetime");

                entity.Property(e => e.Labno).HasColumnName("labno");

                entity.Property(e => e.MarkComplete).HasMaxLength(1);

                entity.Property(e => e.PatientName)
                    .HasColumnName("PATIENT_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientTelno)
                    .HasColumnName("PATIENT_Telno")
                    .HasMaxLength(50);

                entity.Property(e => e.ProfileName).HasMaxLength(255);

                entity.Property(e => e.TestmstCurrentId).HasColumnName("TESTMST_CurrentId");

                entity.Property(e => e.TestmstName)
                    .HasColumnName("TESTMST_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.TestmstPrintFormat)
                    .HasColumnName("TESTMST_PrintFormat")
                    .HasMaxLength(255);

                entity.Property(e => e.TestmstTestTypeId).HasColumnName("TESTMST_TestTypeId");

                entity.Property(e => e.Type).HasMaxLength(1);

                entity.Property(e => e.WardNo).HasMaxLength(50);
            });

            modelBuilder.Entity<QerForMypathtest>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_FOR_MYPATHTEST");

                entity.Property(e => e.Active).HasMaxLength(1);

                entity.Property(e => e.CenterName)
                    .HasColumnName("CENTER_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Comments).HasColumnType("ntext");

                entity.Property(e => e.CompanyCardDegree1)
                    .HasColumnName("COMPANY_CardDegree1")
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyCardDegree2)
                    .HasColumnName("COMPANY_CardDegree2")
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyCardiologist1)
                    .HasColumnName("COMPANY_Cardiologist1")
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyCardiologist2)
                    .HasColumnName("COMPANY_Cardiologist2")
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyPathoDegree1)
                    .HasColumnName("COMPANY_PathoDegree1")
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyPathoDegree2)
                    .HasColumnName("COMPANY_PathoDegree2")
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyPathologist1)
                    .HasColumnName("COMPANY_Pathologist1")
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyPathologist2)
                    .HasColumnName("COMPANY_Pathologist2")
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyRadDegree1)
                    .HasColumnName("COMPANY_RadDegree1")
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyRadDegree2)
                    .HasColumnName("COMPANY_RadDegree2")
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyRadiologist1)
                    .HasColumnName("COMPANY_Radiologist1")
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyRadiologist2)
                    .HasColumnName("COMPANY_Radiologist2")
                    .HasMaxLength(100);

                entity.Property(e => e.Currentdate).HasColumnType("smalldatetime");

                entity.Property(e => e.Doc2)
                    .HasColumnName("DOC2")
                    .HasMaxLength(255);

                entity.Property(e => e.DocdetLFieldNo).HasColumnName("DOCDET_lFieldNo");

                entity.Property(e => e.DocdetLHeaderId).HasColumnName("DOCDET_lHeaderId");

                entity.Property(e => e.DocdetLTestCatId).HasColumnName("DOCDET_lTestCatId");

                entity.Property(e => e.DocdetTFieldValue)
                    .HasColumnName("DOCDET_tFieldValue")
                    .HasMaxLength(255);

                entity.Property(e => e.DocdetTFieldValue1)
                    .HasColumnName("DOCDET_tFieldValue1")
                    .HasColumnType("ntext");

                entity.Property(e => e.DochdrAge)
                    .HasColumnName("DOCHDR_Age")
                    .HasMaxLength(50);

                entity.Property(e => e.DochdrBCommission).HasColumnName("DOCHDR_bCommission");

                entity.Property(e => e.DochdrDDate)
                    .HasColumnName("DOCHDR_dDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DochdrLDoctorId).HasColumnName("DOCHDR_lDoctorId");

                entity.Property(e => e.DochdrLDocumentId).HasColumnName("DOCHDR_lDocumentId");

                entity.Property(e => e.DochdrLEmployeeId).HasColumnName("DOCHDR_lEmployeeId");

                entity.Property(e => e.DochdrLPatientId).HasColumnName("DOCHDR_lPatientId");

                entity.Property(e => e.DochdrPid)
                    .HasColumnName("DOCHDR_PID")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DochdrRate).HasColumnName("DOCHDR_Rate");

                entity.Property(e => e.DochdrSDescription)
                    .HasColumnName("DOCHDR_sDescription")
                    .HasColumnType("ntext");

                entity.Property(e => e.DochdrSDocNo)
                    .HasColumnName("DOCHDR_sDocNo")
                    .HasMaxLength(50);

                entity.Property(e => e.DochdrSample).HasColumnName("DOCHDR_Sample");

                entity.Property(e => e.DochdrSex)
                    .HasColumnName("DOCHDR_Sex")
                    .HasMaxLength(50);

                entity.Property(e => e.DochdrTestCatId).HasColumnName("DOCHDR_TestCatID");

                entity.Property(e => e.Docq2)
                    .HasColumnName("docq2")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorAddress1)
                    .HasColumnName("DOCTOR_Address1")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorAddress2)
                    .HasColumnName("DOCTOR_Address2")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorCity)
                    .HasColumnName("DOCTOR_City")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorCommission).HasColumnName("DOCTOR_Commission");

                entity.Property(e => e.DoctorCompanyid).HasColumnName("DOCTOR_Companyid");

                entity.Property(e => e.DoctorCountry)
                    .HasColumnName("DOCTOR_Country")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorEmail)
                    .HasColumnName("DOCTOR_Email")
                    .HasMaxLength(50);

                entity.Property(e => e.DoctorEx1commission).HasColumnName("DOCTOR_EX1Commission");

                entity.Property(e => e.DoctorExcommission).HasColumnName("DOCTOR_EXCommission");

                entity.Property(e => e.DoctorHcommission).HasColumnName("DOCTOR_HCommission");

                entity.Property(e => e.DoctorId).HasColumnName("DOCTOR_id");

                entity.Property(e => e.DoctorMcommission).HasColumnName("DOCTOR_MCommission");

                entity.Property(e => e.DoctorMobileNo)
                    .HasColumnName("DOCTOR_MobileNo")
                    .HasMaxLength(50);

                entity.Property(e => e.DoctorName)
                    .HasColumnName("DOCTOR_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorOcommission).HasColumnName("DOCTOR_OCommission");

                entity.Property(e => e.DoctorPermanent)
                    .HasColumnName("DOCTOR_Permanent")
                    .HasMaxLength(1);

                entity.Property(e => e.DoctorPfcommission).HasColumnName("DOCTOR_PFCommission");

                entity.Property(e => e.DoctorPincode)
                    .HasColumnName("DOCTOR_Pincode")
                    .HasMaxLength(50);

                entity.Property(e => e.DoctorQualification)
                    .HasColumnName("DOCTOR_Qualification")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorRcommission).HasColumnName("DOCTOR_RCommission");

                entity.Property(e => e.DoctorRegion)
                    .HasColumnName("DOCTOR_Region")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorScommission).HasColumnName("DOCTOR_SCommission");

                entity.Property(e => e.DoctorSpcommission).HasColumnName("DOCTOR_SPCommission");

                entity.Property(e => e.DoctorState)
                    .HasColumnName("DOCTOR_State")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorTelno)
                    .HasColumnName("DOCTOR_Telno")
                    .HasMaxLength(50);

                entity.Property(e => e.DoctorXcommission).HasColumnName("DOCTOR_XCommission");

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("EMPLOYEE_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Hosptype)
                    .HasColumnName("HOSPTYPE")
                    .HasMaxLength(50);

                entity.Property(e => e.IsProfile)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Labno).HasColumnName("labno");

                entity.Property(e => e.MarkComplete).HasMaxLength(1);

                entity.Property(e => e.OfficeAddress1)
                    .HasColumnName("OFFICE_Address1")
                    .HasMaxLength(255);

                entity.Property(e => e.OfficeAddress2)
                    .HasColumnName("OFFICE_Address2")
                    .HasMaxLength(255);

                entity.Property(e => e.OfficeCity)
                    .HasColumnName("OFFICE_City")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficeCountry)
                    .HasColumnName("OFFICE_Country")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficePincode)
                    .HasColumnName("OFFICE_Pincode")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficeRegion)
                    .HasColumnName("OFFICE_Region")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficeState)
                    .HasColumnName("OFFICE_State")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficeTelno)
                    .HasColumnName("OFFICE_Telno")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficeUrl)
                    .HasColumnName("OFFICE_url")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientAddress1)
                    .HasColumnName("PATIENT_Address1")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientAddress2)
                    .HasColumnName("PATIENT_Address2")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientAge)
                    .HasColumnName("PATIENT_Age")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientAmountPaid).HasColumnName("PATIENT_AmountPaid");

                entity.Property(e => e.PatientCity)
                    .HasColumnName("PATIENT_City")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientCompanyid).HasColumnName("PATIENT_Companyid");

                entity.Property(e => e.PatientCountry).HasColumnName("PATIENT_Country");

                entity.Property(e => e.PatientDate)
                    .HasColumnName("PATIENT_Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PatientGender)
                    .HasColumnName("PATIENT_Gender")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientId).HasColumnName("PATIENT_id");

                entity.Property(e => e.PatientName)
                    .HasColumnName("PATIENT_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientPincode)
                    .HasColumnName("PATIENT_Pincode")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientRegion)
                    .HasColumnName("PATIENT_Region")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientSample)
                    .HasColumnName("PATIENT_Sample")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PatientSampleCollected).HasColumnName("PATIENT_SampleCollected");

                entity.Property(e => e.PatientState)
                    .HasColumnName("PATIENT_State")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientTelno)
                    .HasColumnName("PATIENT_Telno")
                    .HasMaxLength(50);

                entity.Property(e => e.Plt)
                    .HasColumnName("PLT")
                    .HasColumnType("image");

                entity.Property(e => e.RbcHisto)
                    .HasColumnName("RBC_HISTO")
                    .HasColumnType("image");

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.SampleDate)
                    .HasColumnName("Sample_Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.SpecialTest).HasMaxLength(1);

                entity.Property(e => e.TestdetCatTypeId).HasColumnName("TESTDET_CatTypeId");

                entity.Property(e => e.TestdetCompulsory).HasColumnName("TESTDET_Compulsory");

                entity.Property(e => e.TestdetCurrentId).HasColumnName("TESTDET_CurrentId");

                entity.Property(e => e.TestdetDescription)
                    .HasColumnName("TESTDET_Description")
                    .HasMaxLength(255);

                entity.Property(e => e.TestdetFieldName)
                    .HasColumnName("TESTDET_FieldName")
                    .HasMaxLength(255);

                entity.Property(e => e.TestdetFieldNo).HasColumnName("TESTDET_FieldNo");

                entity.Property(e => e.TestdetFieldStyle).HasColumnName("TESTDET_FieldStyle");

                entity.Property(e => e.TestdetFieldType).HasColumnName("TESTDET_FieldType");

                entity.Property(e => e.TestdetGroupName)
                    .HasColumnName("TESTDET_GroupName")
                    .HasMaxLength(255);

                entity.Property(e => e.TestdetGroupNo).HasColumnName("TESTDET_GroupNo");

                entity.Property(e => e.TestdetMaxLimit).HasColumnName("TESTDET_MaxLimit");

                entity.Property(e => e.TestdetMaxValue).HasColumnName("TESTDET_MaxValue");

                entity.Property(e => e.TestdetMinLimit).HasColumnName("TESTDET_MinLimit");

                entity.Property(e => e.TestdetMinValue).HasColumnName("TESTDET_MinValue");

                entity.Property(e => e.TestdetNormalValue)
                    .HasColumnName("TESTDET_NormalValue")
                    .HasMaxLength(255);

                entity.Property(e => e.TestdetSAlias)
                    .HasColumnName("TESTDET_sAlias")
                    .HasMaxLength(50);

                entity.Property(e => e.TestdetSDefault)
                    .HasColumnName("TESTDET_sDefault")
                    .HasColumnType("ntext");

                entity.Property(e => e.TestdetSFormula)
                    .HasColumnName("TESTDET_sFormula")
                    .HasMaxLength(50);

                entity.Property(e => e.TestdetSUnit)
                    .HasColumnName("TESTDET_sUnit")
                    .HasMaxLength(50);

                entity.Property(e => e.TestdetTestMasterId).HasColumnName("TESTDET_TestMasterID");

                entity.Property(e => e.TestdetTestTypeId).HasColumnName("TESTDET_TestTypeId");

                entity.Property(e => e.TestdetValidate).HasColumnName("TESTDET_Validate");

                entity.Property(e => e.TestmstAlias)
                    .HasColumnName("TESTMST_Alias")
                    .HasMaxLength(50);

                entity.Property(e => e.TestmstCatType)
                    .HasColumnName("TESTMST_CatType")
                    .HasMaxLength(3);

                entity.Property(e => e.TestmstCompanyid).HasColumnName("TESTMST_Companyid");

                entity.Property(e => e.TestmstCurrentId).HasColumnName("TESTMST_CurrentId");

                entity.Property(e => e.TestmstLumsum).HasColumnName("TESTMST_Lumsum");

                entity.Property(e => e.TestmstName)
                    .HasColumnName("TESTMST_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.TestmstPercentage).HasColumnName("TESTMST_Percentage");

                entity.Property(e => e.TestmstPrintFormat)
                    .HasColumnName("TESTMST_PrintFormat")
                    .HasMaxLength(255);

                entity.Property(e => e.TestmstRate).HasColumnName("TESTMST_Rate");

                entity.Property(e => e.TestmstReportHeading)
                    .HasColumnName("TESTMST_ReportHeading")
                    .HasMaxLength(255);

                entity.Property(e => e.TestmstSample)
                    .HasColumnName("TESTMST_sample")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TestmstTestTypeId).HasColumnName("TESTMST_TestTypeId");

                entity.Property(e => e.TestmstTestcost).HasColumnName("TESTMST_Testcost");

                entity.Property(e => e.Type).HasMaxLength(1);

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(50);

                entity.Property(e => e.ValidateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WardNo).HasMaxLength(50);

                entity.Property(e => e.Wbc)
                    .HasColumnName("WBC")
                    .HasColumnType("image");
            });

            modelBuilder.Entity<QerPaidrefund>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("qer_paidrefund");
            });

            modelBuilder.Entity<QerPatient>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_PATIENT");

                entity.Property(e => e.BarCopiese).HasColumnName("Bar_Copiese");

                entity.Property(e => e.BlnCommission)
                    .HasColumnName("blnCommission")
                    .HasMaxLength(1);

                entity.Property(e => e.CenterName)
                    .HasColumnName("CENTER_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Currentdate).HasColumnType("smalldatetime");

                entity.Property(e => e.DoctorName)
                    .HasColumnName("DOCTOR_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorName1)
                    .HasColumnName("DOCTOR_Name1")
                    .HasMaxLength(255);

                entity.Property(e => e.Hosptype)
                    .HasColumnName("HOSPTYPE")
                    .HasMaxLength(50);

                entity.Property(e => e.Labno).HasColumnName("labno");

                entity.Property(e => e.PatientAddress1)
                    .HasColumnName("PATIENT_Address1")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientAddress2)
                    .HasColumnName("PATIENT_Address2")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientAge)
                    .HasColumnName("PATIENT_Age")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientAgeFlag)
                    .IsRequired()
                    .HasColumnName("PATIENT_AgeFlag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PatientAmountPaid).HasColumnName("PATIENT_AmountPaid");

                entity.Property(e => e.PatientCity)
                    .HasColumnName("PATIENT_City")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientCompanyid).HasColumnName("PATIENT_Companyid");

                entity.Property(e => e.PatientCountry).HasColumnName("PATIENT_Country");

                entity.Property(e => e.PatientDate)
                    .HasColumnName("PATIENT_Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PatientDoctorid).HasColumnName("PATIENT_Doctorid");

                entity.Property(e => e.PatientGender)
                    .HasColumnName("PATIENT_Gender")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientId).HasColumnName("PATIENT_id");

                entity.Property(e => e.PatientName)
                    .HasColumnName("PATIENT_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientPincode)
                    .HasColumnName("PATIENT_Pincode")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientRegion)
                    .HasColumnName("PATIENT_Region")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientSampleCollected).HasColumnName("PATIENT_SampleCollected");

                entity.Property(e => e.PatientState)
                    .HasColumnName("PATIENT_State")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientTelno)
                    .HasColumnName("PATIENT_Telno")
                    .HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.SampleDate)
                    .HasColumnName("Sample_Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.TestAlias)
                    .HasColumnName("TEST_ALIAS")
                    .HasColumnType("ntext");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(50);

                entity.Property(e => e.WardNo).HasMaxLength(50);
            });

            modelBuilder.Entity<QerPatientHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_PATIENT_HISTORY");

                entity.Property(e => e.Currentdate).HasColumnType("smalldatetime");

                entity.Property(e => e.DochdrRate).HasColumnName("DOCHDR_Rate");

                entity.Property(e => e.Flag)
                    .HasColumnName("flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HistoryDate)
                    .HasColumnName("History_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.HistoryId).HasColumnName("History_Id");

                entity.Property(e => e.Labno).HasColumnName("labno");

                entity.Property(e => e.PatientDate)
                    .HasColumnName("PATIENT_Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PatientId).HasColumnName("PATIENT_id");

                entity.Property(e => e.PatientName)
                    .HasColumnName("PATIENT_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientState)
                    .HasColumnName("PATIENT_State")
                    .HasMaxLength(255);

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.TestmstName)
                    .HasColumnName("TESTMST_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<QerPatientreport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_PATIENTREPORT");

                entity.Property(e => e.Active).HasMaxLength(1);

                entity.Property(e => e.AuntheticateDate).HasColumnType("datetime");

                entity.Property(e => e.AuthenticateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BarCopiese).HasColumnName("Bar_Copiese");

                entity.Property(e => e.BlnCommission)
                    .HasColumnName("blnCommission")
                    .HasMaxLength(1);

                entity.Property(e => e.CenterName)
                    .HasColumnName("CENTER_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Comments).HasColumnType("ntext");

                entity.Property(e => e.Currentdate).HasColumnType("smalldatetime");

                entity.Property(e => e.DataEntryDate).HasColumnType("datetime");

                entity.Property(e => e.DataEntryUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.DochdrAge)
                    .HasColumnName("DOCHDR_Age")
                    .HasMaxLength(50);

                entity.Property(e => e.DochdrBCommission).HasColumnName("DOCHDR_bCommission");

                entity.Property(e => e.DochdrDDate)
                    .HasColumnName("DOCHDR_dDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DochdrLDoctorId).HasColumnName("DOCHDR_lDoctorId");

                entity.Property(e => e.DochdrLDocumentId).HasColumnName("DOCHDR_lDocumentId");

                entity.Property(e => e.DochdrLEmployeeId).HasColumnName("DOCHDR_lEmployeeId");

                entity.Property(e => e.DochdrLPatientId).HasColumnName("DOCHDR_lPatientId");

                entity.Property(e => e.DochdrRate).HasColumnName("DOCHDR_Rate");

                entity.Property(e => e.DochdrSDescription)
                    .HasColumnName("DOCHDR_sDescription")
                    .HasColumnType("ntext");

                entity.Property(e => e.DochdrSDocNo)
                    .HasColumnName("DOCHDR_sDocNo")
                    .HasMaxLength(50);

                entity.Property(e => e.DochdrSample).HasColumnName("DOCHDR_Sample");

                entity.Property(e => e.DochdrSex)
                    .HasColumnName("DOCHDR_Sex")
                    .HasMaxLength(50);

                entity.Property(e => e.DochdrTestCatId).HasColumnName("DOCHDR_TestCatID");

                entity.Property(e => e.DoctorAddress1)
                    .HasColumnName("DOCTOR_Address1")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorAddress2)
                    .HasColumnName("DOCTOR_Address2")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorCity)
                    .HasColumnName("DOCTOR_City")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorCode)
                    .HasColumnName("doctor_Code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DoctorCommission).HasColumnName("DOCTOR_Commission");

                entity.Property(e => e.DoctorCompanyid).HasColumnName("DOCTOR_Companyid");

                entity.Property(e => e.DoctorCountry)
                    .HasColumnName("DOCTOR_Country")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorEmail)
                    .HasColumnName("DOCTOR_Email")
                    .HasMaxLength(50);

                entity.Property(e => e.DoctorEx1commission).HasColumnName("DOCTOR_EX1Commission");

                entity.Property(e => e.DoctorExcommission).HasColumnName("DOCTOR_EXCommission");

                entity.Property(e => e.DoctorHcommission).HasColumnName("DOCTOR_HCommission");

                entity.Property(e => e.DoctorId).HasColumnName("DOCTOR_id");

                entity.Property(e => e.DoctorMcommission).HasColumnName("DOCTOR_MCommission");

                entity.Property(e => e.DoctorMobileNo)
                    .HasColumnName("DOCTOR_MobileNo")
                    .HasMaxLength(50);

                entity.Property(e => e.DoctorName)
                    .HasColumnName("DOCTOR_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorOcommission).HasColumnName("DOCTOR_OCommission");

                entity.Property(e => e.DoctorPassword)
                    .HasColumnName("DOCTOR_Password")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DoctorPermanent)
                    .HasColumnName("DOCTOR_Permanent")
                    .HasMaxLength(1);

                entity.Property(e => e.DoctorPfcommission).HasColumnName("DOCTOR_PFCommission");

                entity.Property(e => e.DoctorPincode)
                    .HasColumnName("DOCTOR_Pincode")
                    .HasMaxLength(50);

                entity.Property(e => e.DoctorQualification)
                    .HasColumnName("DOCTOR_Qualification")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorRcommission).HasColumnName("DOCTOR_RCommission");

                entity.Property(e => e.DoctorRegion)
                    .HasColumnName("DOCTOR_Region")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorScommission).HasColumnName("DOCTOR_SCommission");

                entity.Property(e => e.DoctorSpcommission).HasColumnName("DOCTOR_SPCommission");

                entity.Property(e => e.DoctorState)
                    .HasColumnName("DOCTOR_State")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorTelno)
                    .HasColumnName("DOCTOR_Telno")
                    .HasMaxLength(50);

                entity.Property(e => e.DoctorUserName)
                    .HasColumnName("DOCTOR_UserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DoctorXcommission).HasColumnName("DOCTOR_XCommission");

                entity.Property(e => e.EmailDate).HasColumnType("datetime");

                entity.Property(e => e.EmailUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("EMPLOYEE_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Hosptype)
                    .HasColumnName("HOSPTYPE")
                    .HasMaxLength(50);

                entity.Property(e => e.IntegrationDate).HasColumnType("datetime");

                entity.Property(e => e.IsKitImageCompulsary)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsProfile)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LableSample)
                    .HasColumnName("Lable_Sample")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Labno).HasColumnName("labno");

                entity.Property(e => e.MarkComplete).HasMaxLength(1);

                entity.Property(e => e.OfficeAddress1)
                    .HasColumnName("OFFICE_Address1")
                    .HasMaxLength(255);

                entity.Property(e => e.OfficeAddress2)
                    .HasColumnName("OFFICE_Address2")
                    .HasMaxLength(255);

                entity.Property(e => e.OfficeCity)
                    .HasColumnName("OFFICE_City")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficeCountry)
                    .HasColumnName("OFFICE_Country")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficePincode)
                    .HasColumnName("OFFICE_Pincode")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficeRegion)
                    .HasColumnName("OFFICE_Region")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficeState)
                    .HasColumnName("OFFICE_State")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficeTelno)
                    .HasColumnName("OFFICE_Telno")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficeUrl)
                    .HasColumnName("OFFICE_url")
                    .HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.PatientAddress1)
                    .HasColumnName("PATIENT_Address1")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientAddress2)
                    .HasColumnName("PATIENT_Address2")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientAge)
                    .HasColumnName("PATIENT_Age")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientAgeFlag)
                    .IsRequired()
                    .HasColumnName("PATIENT_AgeFlag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PatientAmountPaid).HasColumnName("PATIENT_AmountPaid");

                entity.Property(e => e.PatientCity)
                    .HasColumnName("PATIENT_City")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientCompanyid).HasColumnName("PATIENT_Companyid");

                entity.Property(e => e.PatientCountry).HasColumnName("PATIENT_Country");

                entity.Property(e => e.PatientDate)
                    .HasColumnName("PATIENT_Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PatientDoctorid).HasColumnName("PATIENT_Doctorid");

                entity.Property(e => e.PatientGender)
                    .HasColumnName("PATIENT_Gender")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientId).HasColumnName("PATIENT_id");

                entity.Property(e => e.PatientName)
                    .HasColumnName("PATIENT_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientPincode)
                    .HasColumnName("PATIENT_Pincode")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientRegion)
                    .HasColumnName("PATIENT_Region")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientSampleCollected).HasColumnName("PATIENT_SampleCollected");

                entity.Property(e => e.PatientState)
                    .HasColumnName("PATIENT_State")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientTelno)
                    .HasColumnName("PATIENT_Telno")
                    .HasMaxLength(50);

                entity.Property(e => e.Pdfdate)
                    .HasColumnName("PDFDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pdfuser)
                    .HasColumnName("PDFUser")
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

                entity.Property(e => e.SampleDate)
                    .HasColumnName("Sample_Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.SampleReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.SampleReceivedRemark)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SampleReceivedUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SendSms).HasColumnName("SendSMS");

                entity.Property(e => e.SpecialTest).HasMaxLength(1);

                entity.Property(e => e.Tat).HasColumnName("TAT");

                entity.Property(e => e.TestAlias)
                    .HasColumnName("TEST_ALIAS")
                    .HasColumnType("ntext");

                entity.Property(e => e.TestTypeName).HasMaxLength(50);

                entity.Property(e => e.TestmstAlias)
                    .HasColumnName("TESTMST_Alias")
                    .HasMaxLength(50);

                entity.Property(e => e.TestmstCatType)
                    .HasColumnName("TESTMST_CatType")
                    .HasMaxLength(3);

                entity.Property(e => e.TestmstCompanyid).HasColumnName("TESTMST_Companyid");

                entity.Property(e => e.TestmstCurrentId).HasColumnName("TESTMST_CurrentId");

                entity.Property(e => e.TestmstLumsum).HasColumnName("TESTMST_Lumsum");

                entity.Property(e => e.TestmstName)
                    .HasColumnName("TESTMST_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.TestmstPercentage).HasColumnName("TESTMST_Percentage");

                entity.Property(e => e.TestmstPrintFormat)
                    .HasColumnName("TESTMST_PrintFormat")
                    .HasMaxLength(255);

                entity.Property(e => e.TestmstRate).HasColumnName("TESTMST_Rate");

                entity.Property(e => e.TestmstReportHeading)
                    .HasColumnName("TESTMST_ReportHeading")
                    .HasMaxLength(255);

                entity.Property(e => e.TestmstSample)
                    .HasColumnName("TESTMST_sample")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TestmstTestTypeId).HasColumnName("TESTMST_TestTypeId");

                entity.Property(e => e.TestmstTestcost).HasColumnName("TESTMST_Testcost");

                entity.Property(e => e.Type).HasMaxLength(1);

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(50);

                entity.Property(e => e.ValidateDate).HasColumnType("datetime");

                entity.Property(e => e.ValidateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WardNo).HasMaxLength(50);
            });

            modelBuilder.Entity<QerPatienttype>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_PATIENTTYPE");

                entity.Property(e => e.CenterName)
                    .HasColumnName("Center_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.CurrentDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Hosptype)
                    .HasColumnName("HOSPTYPE")
                    .HasMaxLength(50);

                entity.Property(e => e.Labno).HasColumnName("labno");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientAge)
                    .HasColumnName("PATIENT_Age")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientAmountPaid).HasColumnName("PATIENT_AmountPaid");

                entity.Property(e => e.PatientCompanyid).HasColumnName("PATIENT_Companyid");

                entity.Property(e => e.PatientCountry).HasColumnName("PATIENT_Country");

                entity.Property(e => e.PatientDate)
                    .HasColumnName("PATIENT_Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PatientDoctorid).HasColumnName("PATIENT_Doctorid");

                entity.Property(e => e.PatientGender)
                    .HasColumnName("PATIENT_Gender")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientId).HasColumnName("Patient_id");

                entity.Property(e => e.PatientPincode)
                    .HasColumnName("PATIENT_Pincode")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientRegion)
                    .HasColumnName("PATIENT_Region")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientSampleCollected).HasColumnName("Patient_SampleCollected");

                entity.Property(e => e.PatientTelno)
                    .HasColumnName("PATIENT_Telno")
                    .HasMaxLength(50);

                entity.Property(e => e.Paymode)
                    .HasColumnName("paymode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.SampleDate)
                    .HasColumnName("Sample_Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(50);

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<QerPayments>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_PAYMENTS");

                entity.Property(e => e.CenterId).HasColumnName("CENTER_id");

                entity.Property(e => e.CenterName)
                    .HasColumnName("CENTER_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.CenterRegion)
                    .HasColumnName("CENTER_Region")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorName)
                    .HasColumnName("DOCTOR_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Labno).HasColumnName("labno");

                entity.Property(e => e.PatientDate)
                    .HasColumnName("PATIENT_Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PatientId).HasColumnName("PATIENT_id");

                entity.Property(e => e.PatientName)
                    .HasColumnName("PATIENT_Name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<QerPaymentstype>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_PAYMENTSTYPE");

                entity.Property(e => e.CenterId).HasColumnName("CENTER_id");

                entity.Property(e => e.CenterName)
                    .HasColumnName("CENTER_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.CenterRegion)
                    .HasColumnName("CENTER_Region")
                    .HasMaxLength(255);

                entity.Property(e => e.CollectedatHospitalPaid).HasColumnName("COLLECTEDAtHospitalPaid");

                entity.Property(e => e.DoctorName)
                    .HasColumnName("DOCTOR_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Labno).HasColumnName("labno");

                entity.Property(e => e.Neftpaid).HasColumnName("NEFTPaid");

                entity.Property(e => e.PatientDate)
                    .HasColumnName("PATIENT_Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PatientId).HasColumnName("PATIENT_id");

                entity.Property(e => e.PatientName)
                    .HasColumnName("PATIENT_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Patientid1).HasColumnName("Patientid");

                entity.Property(e => e.Upipaid).HasColumnName("UPIPaid");
            });

            modelBuilder.Entity<QerPendingTest>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_PENDING_TEST");

                entity.Property(e => e.DochdrDDate)
                    .HasColumnName("DOCHDR_dDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DochdrLPatientId).HasColumnName("DOCHDR_lPatientId");

                entity.Property(e => e.DoctorName)
                    .HasColumnName("DOCTOR_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.IntRecords).HasColumnName("intRecords");

                entity.Property(e => e.Labno).HasColumnName("labno");

                entity.Property(e => e.PatientName)
                    .HasColumnName("PATIENT_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.TestmstName)
                    .HasColumnName("TESTMST_Name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<QerPendingTestsNew>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_PendingTestsNew");

                entity.Property(e => e.DochdrLDocumentId).HasColumnName("DOCHDR_lDocumentId");

                entity.Property(e => e.DochdrLPatientId).HasColumnName("DOCHDR_lPatientId");

                entity.Property(e => e.TestmstAlias)
                    .HasColumnName("TESTMST_Alias")
                    .HasMaxLength(50);

                entity.Property(e => e.TestmstCurrentId).HasColumnName("TESTMST_CurrentId");

                entity.Property(e => e.TestmstName)
                    .HasColumnName("TESTMST_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.TestmstRate).HasColumnName("TESTMST_Rate");

                entity.Property(e => e.Type).HasMaxLength(1);
            });

            modelBuilder.Entity<QerRatelist>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_RATELIST");

                entity.Property(e => e.TestTypeName).HasMaxLength(50);

                entity.Property(e => e.TestmstName)
                    .HasColumnName("TESTMST_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Type).HasMaxLength(1);
            });

            modelBuilder.Entity<QerRefundamount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_REFUNDAMOUNT");

                entity.Property(e => e.Refundamount).HasColumnName("REFUNDAMOUNT");
            });

            modelBuilder.Entity<QerResultregister>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_RESULTREGISTER");

                entity.Property(e => e.TestTypeName).HasMaxLength(50);

                entity.Property(e => e.TestdetFieldName)
                    .HasColumnName("TESTDET_FieldName")
                    .HasMaxLength(255);

                entity.Property(e => e.TestdetFieldNo).HasColumnName("TESTDET_FieldNo");

                entity.Property(e => e.TestdetSAlias)
                    .HasColumnName("TESTDET_sAlias")
                    .HasMaxLength(50);

                entity.Property(e => e.TestdetTestMasterId).HasColumnName("TESTDET_TestMasterID");

                entity.Property(e => e.TestmstId).HasColumnName("TESTMST_ID");

                entity.Property(e => e.TestmstName)
                    .HasColumnName("TESTMST_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.TestmstTestTypeId).HasColumnName("TESTMST_TestTypeId");
            });

            modelBuilder.Entity<QerResultregister1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_RESULTREGISTER1");

                entity.Property(e => e.TestdetFieldName)
                    .HasColumnName("TESTDET_FieldName")
                    .HasMaxLength(255);

                entity.Property(e => e.TestdetFieldNo).HasColumnName("TESTDET_FieldNo");

                entity.Property(e => e.TestdetSAlias)
                    .HasColumnName("TESTDET_sAlias")
                    .HasMaxLength(50);

                entity.Property(e => e.TestdetTestMasterId).HasColumnName("TESTDET_TestMasterID");

                entity.Property(e => e.TestmstId).HasColumnName("TESTMST_ID");

                entity.Property(e => e.TestmstName)
                    .HasColumnName("TESTMST_Name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<QerResultregister2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_RESULTREGISTER2");

                entity.Property(e => e.TestTypeName).HasMaxLength(50);

                entity.Property(e => e.TestdetFieldName)
                    .HasColumnName("TESTDET_FieldName")
                    .HasMaxLength(255);

                entity.Property(e => e.TestdetFieldNo).HasColumnName("TESTDET_FieldNo");

                entity.Property(e => e.TestdetSAlias)
                    .HasColumnName("TESTDET_sAlias")
                    .HasMaxLength(50);

                entity.Property(e => e.TestdetTestMasterId).HasColumnName("TESTDET_TestMasterID");

                entity.Property(e => e.TestmstId).HasColumnName("TESTMST_ID");

                entity.Property(e => e.TestmstName)
                    .HasColumnName("TESTMST_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.TestmstTestTypeId).HasColumnName("TESTMST_TestTypeId");
            });

            modelBuilder.Entity<QerResultregisterreport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_RESULTREGISTERREPORT");

                entity.Property(e => e.AuntheticateDate).HasColumnType("datetime");

                entity.Property(e => e.AuthenticateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CenterName)
                    .HasColumnName("CENTER_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.DataEntryDate).HasColumnType("datetime");

                entity.Property(e => e.DataEntryUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DoctorName)
                    .HasColumnName("DOCTOR_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Issent).HasColumnName("issent");

                entity.Property(e => e.Labno).HasColumnName("labno");

                entity.Property(e => e.PatientAge)
                    .HasColumnName("PATIENT_Age")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientDate)
                    .HasColumnName("PATIENT_Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PatientGender)
                    .HasColumnName("PATIENT_Gender")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientId).HasColumnName("PATIENT_id");

                entity.Property(e => e.PatientName)
                    .HasColumnName("PATIENT_Name")
                    .HasMaxLength(255);

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

                entity.Property(e => e.Rs)
                    .HasColumnName("rs")
                    .HasMaxLength(308);

                entity.Property(e => e.SampleReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.SampleReceivedUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TestTypeName).HasMaxLength(50);

                entity.Property(e => e.TestmstTestTypeId).HasColumnName("TESTMST_TestTypeId");

                entity.Property(e => e.ValidateDate).HasColumnType("datetime");

                entity.Property(e => e.ValidateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QerResultregisterreport1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_RESULTREGISTERREPORT1");

                entity.Property(e => e.Labno).HasColumnName("labno");

                entity.Property(e => e.PatientDate)
                    .HasColumnName("PATIENT_Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PatientId).HasColumnName("PATIENT_id");

                entity.Property(e => e.PatientName)
                    .HasColumnName("PATIENT_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Rs)
                    .HasColumnName("rs")
                    .HasMaxLength(308);

                entity.Property(e => e.TestCatId).HasColumnName("TestCatID");
            });

            modelBuilder.Entity<QerResultregisterreportsms>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_RESULTREGISTERREPORTSMS");

                entity.Property(e => e.CenterId).HasColumnName("CENTER_id");

                entity.Property(e => e.CenterName)
                    .HasColumnName("CENTER_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.CenterTelno)
                    .HasColumnName("CENTER_Telno")
                    .HasMaxLength(50);

                entity.Property(e => e.DochdrLDocumentId).HasColumnName("DOCHDR_lDocumentId");

                entity.Property(e => e.DochdrTestCatId).HasColumnName("DOCHDR_TestCatID");

                entity.Property(e => e.DoctorId).HasColumnName("DOCTOR_id");

                entity.Property(e => e.DoctorMobileNo)
                    .HasColumnName("DOCTOR_MobileNo")
                    .HasMaxLength(50);

                entity.Property(e => e.DoctorName)
                    .HasColumnName("DOCTOR_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Labno).HasColumnName("labno");

                entity.Property(e => e.PatientDate)
                    .HasColumnName("PATIENT_Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PatientId).HasColumnName("PATIENT_id");

                entity.Property(e => e.PatientName)
                    .HasColumnName("PATIENT_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientTelno)
                    .HasColumnName("PATIENT_Telno")
                    .HasMaxLength(50);

                entity.Property(e => e.Rs)
                    .HasColumnName("rs")
                    .HasMaxLength(308);

                entity.Property(e => e.TestdetSUnit)
                    .HasColumnName("TESTDET_sUnit")
                    .HasMaxLength(50);

                entity.Property(e => e.TestmstAlias)
                    .HasColumnName("TESTMST_Alias")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<QerResultregisterreportsmscritical>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_RESULTREGISTERREPORTSMSCRITICAL");

                entity.Property(e => e.CenterId).HasColumnName("CENTER_id");

                entity.Property(e => e.CenterName)
                    .HasColumnName("CENTER_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.CenterTelno)
                    .HasColumnName("CENTER_Telno")
                    .HasMaxLength(50);

                entity.Property(e => e.DochdrLDocumentId).HasColumnName("DOCHDR_lDocumentId");

                entity.Property(e => e.DochdrTestCatId).HasColumnName("DOCHDR_TestCatID");

                entity.Property(e => e.DoctorId).HasColumnName("DOCTOR_id");

                entity.Property(e => e.DoctorMobileNo)
                    .HasColumnName("DOCTOR_MobileNo")
                    .HasMaxLength(50);

                entity.Property(e => e.DoctorName)
                    .HasColumnName("DOCTOR_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Labno).HasColumnName("labno");

                entity.Property(e => e.PatientDate)
                    .HasColumnName("PATIENT_Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PatientId).HasColumnName("PATIENT_id");

                entity.Property(e => e.PatientName)
                    .HasColumnName("PATIENT_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientTelno)
                    .HasColumnName("PATIENT_Telno")
                    .HasMaxLength(50);

                entity.Property(e => e.Rs)
                    .HasColumnName("rs")
                    .HasMaxLength(308);

                entity.Property(e => e.TestdetSUnit)
                    .HasColumnName("TESTDET_sUnit")
                    .HasMaxLength(50);

                entity.Property(e => e.TestmstAlias)
                    .HasColumnName("TESTMST_Alias")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<QerResultregistersms>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_RESULTREGISTERSMS");

                entity.Property(e => e.TestdetFieldName)
                    .HasColumnName("TESTDET_FieldName")
                    .HasMaxLength(255);

                entity.Property(e => e.TestdetFieldNo).HasColumnName("TESTDET_FieldNo");

                entity.Property(e => e.TestdetSAlias)
                    .HasColumnName("TESTDET_sAlias")
                    .HasMaxLength(50);

                entity.Property(e => e.TestdetSUnit)
                    .HasColumnName("TESTDET_sUnit")
                    .HasMaxLength(50);

                entity.Property(e => e.TestdetTestMasterId).HasColumnName("TESTDET_TestMasterID");

                entity.Property(e => e.TestmstId).HasColumnName("TESTMST_ID");

                entity.Property(e => e.TestmstName)
                    .HasColumnName("TESTMST_Name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<QerResultregistersmscritical>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_RESULTREGISTERSMSCRITICAL");

                entity.Property(e => e.TestdetFieldName)
                    .HasColumnName("TESTDET_FieldName")
                    .HasMaxLength(255);

                entity.Property(e => e.TestdetFieldNo).HasColumnName("TESTDET_FieldNo");

                entity.Property(e => e.TestdetMaxLimit).HasColumnName("TESTDET_MaxLimit");

                entity.Property(e => e.TestdetMinLimit).HasColumnName("TESTDET_MinLimit");

                entity.Property(e => e.TestdetSAlias)
                    .HasColumnName("TESTDET_sAlias")
                    .HasMaxLength(50);

                entity.Property(e => e.TestdetSUnit)
                    .HasColumnName("TESTDET_sUnit")
                    .HasMaxLength(50);

                entity.Property(e => e.TestdetTestMasterId).HasColumnName("TESTDET_TestMasterID");

                entity.Property(e => e.TestmstId).HasColumnName("TESTMST_ID");

                entity.Property(e => e.TestmstName)
                    .HasColumnName("TESTMST_Name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<QerSpecialtests>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_SPECIALTESTS");

                entity.Property(e => e.DochdrLPatientId).HasColumnName("DOCHDR_lPatientId");
            });

            modelBuilder.Entity<QerTdscertificate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QerTDSCertificate");

                entity.Property(e => e.BillDate).HasColumnType("datetime");

                entity.Property(e => e.CenterId).HasColumnName("Center_Id");

                entity.Property(e => e.CenterName)
                    .HasColumnName("CENTER_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.FinYear)
                    .IsRequired()
                    .HasColumnName("Fin_Year")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Tds)
                    .HasColumnName("TDS")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.TdsCertificateRecDate).HasColumnType("datetime");

                entity.Property(e => e.TdsCertificateRecNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<QerTestcount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_TESTCOUNT");

                entity.Property(e => e.DochdrLPatientId).HasColumnName("DOCHDR_lPatientId");

                entity.Property(e => e.Tests).HasColumnName("tests");
            });

            modelBuilder.Entity<QerTests>(entity =>
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

                entity.Property(e => e.CenterName)
                    .HasColumnName("CENTER_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Comments).HasColumnType("ntext");

                entity.Property(e => e.Currentdate).HasColumnType("smalldatetime");

                entity.Property(e => e.DataEntryDate).HasColumnType("datetime");

                entity.Property(e => e.DataEntryUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Doc2)
                    .HasColumnName("DOC2")
                    .HasMaxLength(255);

                entity.Property(e => e.DocdetLFieldNo).HasColumnName("DOCDET_lFieldNo");

                entity.Property(e => e.DocdetLHeaderId).HasColumnName("DOCDET_lHeaderId");

                entity.Property(e => e.DocdetLTestCatId).HasColumnName("DOCDET_lTestCatId");

                entity.Property(e => e.DocdetTFieldValue)
                    .HasColumnName("DOCDET_tFieldValue")
                    .HasMaxLength(255);

                entity.Property(e => e.DocdetTFieldValue1)
                    .HasColumnName("DOCDET_tFieldValue1")
                    .HasColumnType("ntext");

                entity.Property(e => e.DochdrAge)
                    .HasColumnName("DOCHDR_Age")
                    .HasMaxLength(50);

                entity.Property(e => e.DochdrAgeFlag)
                    .IsRequired()
                    .HasColumnName("DOCHDR_AgeFlag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DochdrBCommission).HasColumnName("DOCHDR_bCommission");

                entity.Property(e => e.DochdrDDate)
                    .HasColumnName("DOCHDR_dDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DochdrLDoctorId).HasColumnName("DOCHDR_lDoctorId");

                entity.Property(e => e.DochdrLDocumentId).HasColumnName("DOCHDR_lDocumentId");

                entity.Property(e => e.DochdrLEmployeeId).HasColumnName("DOCHDR_lEmployeeId");

                entity.Property(e => e.DochdrLPatientId).HasColumnName("DOCHDR_lPatientId");

                entity.Property(e => e.DochdrRate).HasColumnName("DOCHDR_Rate");

                entity.Property(e => e.DochdrSDescription)
                    .HasColumnName("DOCHDR_sDescription")
                    .HasColumnType("ntext");

                entity.Property(e => e.DochdrSDocNo)
                    .HasColumnName("DOCHDR_sDocNo")
                    .HasMaxLength(50);

                entity.Property(e => e.DochdrSample).HasColumnName("DOCHDR_Sample");

                entity.Property(e => e.DochdrSex)
                    .HasColumnName("DOCHDR_Sex")
                    .HasMaxLength(50);

                entity.Property(e => e.DochdrTestCatId).HasColumnName("DOCHDR_TestCatID");

                entity.Property(e => e.Docq2)
                    .HasColumnName("docq2")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorAddress1)
                    .HasColumnName("DOCTOR_Address1")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorAddress2)
                    .HasColumnName("DOCTOR_Address2")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorCity)
                    .HasColumnName("DOCTOR_City")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorCommission).HasColumnName("DOCTOR_Commission");

                entity.Property(e => e.DoctorCompanyid).HasColumnName("DOCTOR_Companyid");

                entity.Property(e => e.DoctorCountry)
                    .HasColumnName("DOCTOR_Country")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorEmail)
                    .HasColumnName("DOCTOR_Email")
                    .HasMaxLength(50);

                entity.Property(e => e.DoctorEx1commission).HasColumnName("DOCTOR_EX1Commission");

                entity.Property(e => e.DoctorExcommission).HasColumnName("DOCTOR_EXCommission");

                entity.Property(e => e.DoctorHcommission).HasColumnName("DOCTOR_HCommission");

                entity.Property(e => e.DoctorId).HasColumnName("DOCTOR_id");

                entity.Property(e => e.DoctorMcommission).HasColumnName("DOCTOR_MCommission");

                entity.Property(e => e.DoctorMobileNo)
                    .HasColumnName("DOCTOR_MobileNo")
                    .HasMaxLength(50);

                entity.Property(e => e.DoctorName)
                    .HasColumnName("DOCTOR_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorOcommission).HasColumnName("DOCTOR_OCommission");

                entity.Property(e => e.DoctorPermanent)
                    .HasColumnName("DOCTOR_Permanent")
                    .HasMaxLength(1);

                entity.Property(e => e.DoctorPfcommission).HasColumnName("DOCTOR_PFCommission");

                entity.Property(e => e.DoctorPincode)
                    .HasColumnName("DOCTOR_Pincode")
                    .HasMaxLength(50);

                entity.Property(e => e.DoctorQualification)
                    .HasColumnName("DOCTOR_Qualification")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorRcommission).HasColumnName("DOCTOR_RCommission");

                entity.Property(e => e.DoctorRegion)
                    .HasColumnName("DOCTOR_Region")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorScommission).HasColumnName("DOCTOR_SCommission");

                entity.Property(e => e.DoctorSpcommission).HasColumnName("DOCTOR_SPCommission");

                entity.Property(e => e.DoctorState)
                    .HasColumnName("DOCTOR_State")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorTelno)
                    .HasColumnName("DOCTOR_Telno")
                    .HasMaxLength(50);

                entity.Property(e => e.DoctorXcommission).HasColumnName("DOCTOR_XCommission");

                entity.Property(e => e.EmailDate).HasColumnType("datetime");

                entity.Property(e => e.EmailUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("EMPLOYEE_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Hosptype)
                    .HasColumnName("HOSPTYPE")
                    .HasMaxLength(50);

                entity.Property(e => e.IntegrationDate).HasColumnType("datetime");

                entity.Property(e => e.IsNabl)
                    .HasColumnName("IsNABL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsProfile)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LableSample)
                    .HasColumnName("Lable_Sample")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Labno).HasColumnName("labno");

                entity.Property(e => e.MarkComplete).HasMaxLength(1);

                entity.Property(e => e.OfficeAddress1)
                    .HasColumnName("OFFICE_Address1")
                    .HasMaxLength(255);

                entity.Property(e => e.OfficeAddress2)
                    .HasColumnName("OFFICE_Address2")
                    .HasMaxLength(255);

                entity.Property(e => e.OfficeCity)
                    .HasColumnName("OFFICE_City")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficeCountry)
                    .HasColumnName("OFFICE_Country")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficePincode)
                    .HasColumnName("OFFICE_Pincode")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficeRegion)
                    .HasColumnName("OFFICE_Region")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficeState)
                    .HasColumnName("OFFICE_State")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficeTelno)
                    .HasColumnName("OFFICE_Telno")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficeUrl)
                    .HasColumnName("OFFICE_url")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientAddress1)
                    .HasColumnName("PATIENT_Address1")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientAddress2)
                    .HasColumnName("PATIENT_Address2")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientAge)
                    .HasColumnName("PATIENT_Age")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientAgeFlag)
                    .IsRequired()
                    .HasColumnName("PATIENT_AgeFlag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PatientAmountPaid).HasColumnName("PATIENT_AmountPaid");

                entity.Property(e => e.PatientCity)
                    .HasColumnName("PATIENT_City")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientCountry).HasColumnName("PATIENT_Country");

                entity.Property(e => e.PatientDate)
                    .HasColumnName("PATIENT_Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PatientDiscount).HasColumnName("PATIENT_Discount");

                entity.Property(e => e.PatientGender)
                    .HasColumnName("PATIENT_Gender")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientName)
                    .HasColumnName("PATIENT_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientPincode)
                    .HasColumnName("PATIENT_Pincode")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientRegion)
                    .HasColumnName("PATIENT_Region")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientSampleCollected).HasColumnName("PATIENT_SampleCollected");

                entity.Property(e => e.PatientState)
                    .HasColumnName("PATIENT_State")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientTelno)
                    .HasColumnName("PATIENT_Telno")
                    .HasMaxLength(50);

                entity.Property(e => e.Pdfdate)
                    .HasColumnName("PDFDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pdfuser)
                    .HasColumnName("PDFUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Plt)
                    .HasColumnName("PLT")
                    .HasColumnType("image");

                entity.Property(e => e.PrintDate).HasColumnType("datetime");

                entity.Property(e => e.PrintUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProfileName).HasMaxLength(255);

                entity.Property(e => e.Rbc)
                    .HasColumnName("RBC")
                    .HasColumnType("image");

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

                entity.Property(e => e.SampleDate)
                    .HasColumnName("Sample_Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.SampleReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.SampleReceivedRemark)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SampleReceivedUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialTest).HasMaxLength(1);

                entity.Property(e => e.Tat).HasColumnName("TAT");

                entity.Property(e => e.TestdetCompulsory).HasColumnName("TESTDET_Compulsory");

                entity.Property(e => e.TestdetCurrentId).HasColumnName("TESTDET_CurrentId");

                entity.Property(e => e.TestdetDescription)
                    .HasColumnName("TESTDET_Description")
                    .HasMaxLength(255);

                entity.Property(e => e.TestdetFieldName)
                    .HasColumnName("TESTDET_FieldName")
                    .HasMaxLength(255);

                entity.Property(e => e.TestdetFieldNo).HasColumnName("TESTDET_FieldNo");

                entity.Property(e => e.TestdetFieldStyle).HasColumnName("TESTDET_FieldStyle");

                entity.Property(e => e.TestdetFieldType).HasColumnName("TESTDET_FieldType");

                entity.Property(e => e.TestdetGroupName)
                    .HasColumnName("TESTDET_GroupName")
                    .HasMaxLength(255);

                entity.Property(e => e.TestdetGroupNo).HasColumnName("TESTDET_GroupNo");

                entity.Property(e => e.TestdetMaxLimit).HasColumnName("TESTDET_MaxLimit");

                entity.Property(e => e.TestdetMaxValue).HasColumnName("TESTDET_MaxValue");

                entity.Property(e => e.TestdetMinLimit).HasColumnName("TESTDET_MinLimit");

                entity.Property(e => e.TestdetMinValue).HasColumnName("TESTDET_MinValue");

                entity.Property(e => e.TestdetNormalValue)
                    .HasColumnName("TESTDET_NormalValue")
                    .HasMaxLength(255);

                entity.Property(e => e.TestdetSAlias)
                    .HasColumnName("TESTDET_sAlias")
                    .HasMaxLength(50);

                entity.Property(e => e.TestdetSDefault)
                    .HasColumnName("TESTDET_sDefault")
                    .HasColumnType("ntext");

                entity.Property(e => e.TestdetSFormula)
                    .HasColumnName("TESTDET_sFormula")
                    .HasMaxLength(50);

                entity.Property(e => e.TestdetSUnit)
                    .HasColumnName("TESTDET_sUnit")
                    .HasMaxLength(50);

                entity.Property(e => e.TestdetTestMasterId).HasColumnName("TESTDET_TestMasterID");

                entity.Property(e => e.TestdetValidate).HasColumnName("TESTDET_Validate");

                entity.Property(e => e.TestmstAlias)
                    .HasColumnName("TESTMST_Alias")
                    .HasMaxLength(50);

                entity.Property(e => e.TestmstCatType)
                    .HasColumnName("TESTMST_CatType")
                    .HasMaxLength(3);

                entity.Property(e => e.TestmstCompanyid).HasColumnName("TESTMST_Companyid");

                entity.Property(e => e.TestmstCurrentId).HasColumnName("TESTMST_CurrentId");

                entity.Property(e => e.TestmstLumsum).HasColumnName("TESTMST_Lumsum");

                entity.Property(e => e.TestmstName)
                    .HasColumnName("TESTMST_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.TestmstPercentage).HasColumnName("TESTMST_Percentage");

                entity.Property(e => e.TestmstPrintFormat)
                    .HasColumnName("TESTMST_PrintFormat")
                    .HasMaxLength(255);

                entity.Property(e => e.TestmstRate).HasColumnName("TESTMST_Rate");

                entity.Property(e => e.TestmstReportHeading)
                    .HasColumnName("TESTMST_ReportHeading")
                    .HasMaxLength(255);

                entity.Property(e => e.TestmstSample)
                    .HasColumnName("TESTMST_sample")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TestmstTestTypeId).HasColumnName("TESTMST_TestTypeId");

                entity.Property(e => e.TestmstTestcost).HasColumnName("TESTMST_Testcost");

                entity.Property(e => e.Type).HasMaxLength(1);

                entity.Property(e => e.UrgentFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(50);

                entity.Property(e => e.ValidateDate).HasColumnType("datetime");

                entity.Property(e => e.ValidateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WardNo).HasMaxLength(50);

                entity.Property(e => e.Wbc)
                    .HasColumnName("WBC")
                    .HasColumnType("image");
            });

            modelBuilder.Entity<QerWorkSheet>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_WORK_SHEET");

                entity.Property(e => e.DochdrDDate)
                    .HasColumnName("DOCHDR_dDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DochdrLPatientId).HasColumnName("DOCHDR_lPatientId");

                entity.Property(e => e.DoctorName)
                    .HasColumnName("DOCTOR_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Labno).HasColumnName("labno");

                entity.Property(e => e.PatientAge)
                    .HasColumnName("PATIENT_Age")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientAgeFlag)
                    .HasColumnName("PATIENT_AgeFlag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PatientGender)
                    .HasColumnName("PATIENT_Gender")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientName)
                    .HasColumnName("PATIENT_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.TestTypeName).HasMaxLength(50);

                entity.Property(e => e.TestmstAlias)
                    .HasColumnName("TESTMST_Alias")
                    .HasMaxLength(50);

                entity.Property(e => e.TestmstTestTypeId).HasColumnName("TESTMST_TestTypeId");
            });

            modelBuilder.Entity<QerWorkSheetOld>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QER_WORK_SHEET_OLD");

                entity.Property(e => e.DochdrDDate)
                    .HasColumnName("DOCHDR_dDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DochdrLPatientId).HasColumnName("DOCHDR_lPatientId");

                entity.Property(e => e.Labno).HasColumnName("labno");

                entity.Property(e => e.PatientName)
                    .HasColumnName("PATIENT_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.TestTypeName).HasMaxLength(50);

                entity.Property(e => e.TestmstAlias)
                    .HasColumnName("TESTMST_Alias")
                    .HasMaxLength(50);

                entity.Property(e => e.TestmstTestTypeId).HasColumnName("TESTMST_TestTypeId");
            });

            modelBuilder.Entity<QuantumTestMapp>(entity =>
            {
                entity.HasKey(e => e.Testid);

                entity.Property(e => e.Testid)
                    .HasColumnName("testid")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<RateListDiscountRate>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.TestCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ratelist>(entity =>
            {
                entity.HasKey(e => new { e.Centerid, e.TestId });

                entity.ToTable("RATELIST");

                entity.Property(e => e.BaseRate).HasDefaultValueSql("(0)");

                entity.Property(e => e.Discount1).HasDefaultValueSql("(0)");

                entity.Property(e => e.SpecialTest)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'N')");
            });

            modelBuilder.Entity<Ratelisthdr>(entity =>
            {
                entity.HasKey(e => e.RateListId);

                entity.ToTable("RATELISTHDR");

                entity.Property(e => e.RateListId).ValueGeneratedNever();

                entity.Property(e => e.Other).HasColumnName("other");

                entity.Property(e => e.Other1).HasColumnName("other1");

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

            modelBuilder.Entity<RejectReason>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Reject_Reason");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ReportReadySmslog>(entity =>
            {
                entity.HasKey(e => e.AutoId);

                entity.ToTable("ReportReadySMSLog");
            });

            modelBuilder.Entity<ReportValuesCrsmslog>(entity =>
            {
                entity.HasKey(e => e.Autoid);

                entity.ToTable("ReportValuesCRSMSLOG");

                entity.Property(e => e.Autoid)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReportValuesSmslog>(entity =>
            {
                entity.HasKey(e => e.Autoid);

                entity.ToTable("ReportValuesSMSLOG");

                entity.Property(e => e.Autoid)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Scheduler>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Path)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SmsData>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("smsData");

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Mobileno)
                    .HasColumnName("mobileno")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Regno).HasColumnName("regno");

                entity.Property(e => e.Smsdate)
                    .HasColumnName("smsdate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Smsid)
                    .HasColumnName("smsid")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Sndstatus)
                    .HasColumnName("sndstatus")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SmsSet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SMS_SET");

                entity.Property(e => e.Msgcenter)
                    .IsRequired()
                    .HasColumnName("msgcenter")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Portno)
                    .HasColumnName("portno")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Settings)
                    .IsRequired()
                    .HasColumnName("settings")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sign)
                    .IsRequired()
                    .HasColumnName("sign")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebSign)
                    .HasColumnName("web_sign")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<Smsapi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SMSAPI");

                entity.Property(e => e.EnableSms).HasColumnName("EnableSMS");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sender)
                    .HasColumnName("sender")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Smstemplatedet>(entity =>
            {
                entity.HasKey(e => e.TemplateDetailId);

                entity.ToTable("SMSTEMPLATEDET");

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

            modelBuilder.Entity<Smstemplatehdr>(entity =>
            {
                entity.HasKey(e => e.TemplateId)
                    .HasName("PK_SMSTEMPLATE");

                entity.ToTable("SMSTEMPLATEHDR");

                entity.Property(e => e.TemplateId).ValueGeneratedNever();

                entity.Property(e => e.Smstemplate)
                    .HasColumnName("SMSTemplate")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SysDate).HasColumnType("datetime");

                entity.Property(e => e.SysUserName)
                    .HasColumnName("sysUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateSmsname)
                    .IsRequired()
                    .HasColumnName("TemplateSMSName")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Smstestregister>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SMSTESTREGISTER");

                entity.Property(e => e.TestdetFieldno).HasColumnName("TESTDET_Fieldno");

                entity.Property(e => e.TestmstId).HasColumnName("TESTMST_ID");
            });

            modelBuilder.Entity<TblAppointmentTrack>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblAppointmentTrack");

                entity.Property(e => e.AppointmentId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNo)
                    .HasColumnName("contactNo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Sysdate)
                    .HasColumnName("sysdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TestFormatDet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEST_FORMAT_DET");

                entity.Property(e => e.TestFieldName)
                    .HasColumnName("TEST_FieldName")
                    .HasMaxLength(255);

                entity.Property(e => e.TestFormatSrNo).HasColumnName("TEST_FormatSrNo");

                entity.Property(e => e.TestSDefault)
                    .HasColumnName("TEST_sDefault")
                    .HasColumnType("ntext");

                entity.Property(e => e.TestTestMasterId).HasColumnName("TEST_TestMasterID");
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

                entity.Property(e => e.TestmstCurrentId).HasColumnName("TESTMST_CurrentId");

                entity.Property(e => e.TotalVal).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<Testdet>(entity =>
            {
                entity.HasKey(e => e.TestdetCurrentId);

                entity.ToTable("TESTDET");

                entity.HasIndex(e => e.TestdetTestMasterId)
                    .HasName("IX_TESTDET_TESTMASTERID");

                entity.Property(e => e.TestdetCurrentId)
                    .HasColumnName("TESTDET_CurrentId")
                    .ValueGeneratedNever();

                entity.Property(e => e.TestdetAmaxValue).HasColumnName("TESTDET_AMaxValue");

                entity.Property(e => e.TestdetAminValue).HasColumnName("TESTDET_AMinValue");

                entity.Property(e => e.TestdetAnormalValue)
                    .HasColumnName("TESTDET_ANormalValue")
                    .HasMaxLength(255);

                entity.Property(e => e.TestdetBmaxValue).HasColumnName("TESTDET_BMaxValue");

                entity.Property(e => e.TestdetBminValue).HasColumnName("TESTDET_BMinValue");

                entity.Property(e => e.TestdetBnormalValue)
                    .HasColumnName("TESTDET_BNormalValue")
                    .HasMaxLength(255);

                entity.Property(e => e.TestdetCatTypeId).HasColumnName("TESTDET_CatTypeId");

                entity.Property(e => e.TestdetCmaxValue).HasColumnName("TESTDET_CMaxValue");

                entity.Property(e => e.TestdetCminValue).HasColumnName("TESTDET_CMinValue");

                entity.Property(e => e.TestdetCnormalValue)
                    .HasColumnName("TESTDET_CNormalValue")
                    .HasMaxLength(255);

                entity.Property(e => e.TestdetCompulsory).HasColumnName("TESTDET_Compulsory");

                entity.Property(e => e.TestdetDescription)
                    .HasColumnName("TESTDET_Description")
                    .HasMaxLength(255);

                entity.Property(e => e.TestdetDmaxValue).HasColumnName("TESTDET_DMaxValue");

                entity.Property(e => e.TestdetDminValue).HasColumnName("TESTDET_DMinValue");

                entity.Property(e => e.TestdetDnormalValue)
                    .HasColumnName("TESTDET_DNormalValue")
                    .HasMaxLength(255);

                entity.Property(e => e.TestdetFieldName)
                    .HasColumnName("TESTDET_FieldName")
                    .HasMaxLength(255);

                entity.Property(e => e.TestdetFieldNo).HasColumnName("TESTDET_FieldNo");

                entity.Property(e => e.TestdetFieldStyle).HasColumnName("TESTDET_FieldStyle");

                entity.Property(e => e.TestdetFieldType).HasColumnName("TESTDET_FieldType");

                entity.Property(e => e.TestdetGroupName)
                    .HasColumnName("TESTDET_GroupName")
                    .HasMaxLength(255);

                entity.Property(e => e.TestdetGroupNo).HasColumnName("TESTDET_GroupNo");

                entity.Property(e => e.TestdetMaxLimit).HasColumnName("TESTDET_MaxLimit");

                entity.Property(e => e.TestdetMaxValue).HasColumnName("TESTDET_MaxValue");

                entity.Property(e => e.TestdetMinLimit).HasColumnName("TESTDET_MinLimit");

                entity.Property(e => e.TestdetMinValue).HasColumnName("TESTDET_MinValue");

                entity.Property(e => e.TestdetNormalValue)
                    .HasColumnName("TESTDET_NormalValue")
                    .HasMaxLength(255);

                entity.Property(e => e.TestdetSAlias)
                    .HasColumnName("TESTDET_sAlias")
                    .HasMaxLength(50);

                entity.Property(e => e.TestdetSDefault)
                    .HasColumnName("TESTDET_sDefault")
                    .HasColumnType("ntext");

                entity.Property(e => e.TestdetSFormula)
                    .HasColumnName("TESTDET_sFormula")
                    .HasMaxLength(50);

                entity.Property(e => e.TestdetSUnit)
                    .HasColumnName("TESTDET_sUnit")
                    .HasMaxLength(50);

                entity.Property(e => e.TestdetTestMasterId).HasColumnName("TESTDET_TestMasterID");

                entity.Property(e => e.TestdetTestTypeId).HasColumnName("TESTDET_TestTypeId");

                entity.Property(e => e.TestdetValidate).HasColumnName("TESTDET_Validate");
            });

            modelBuilder.Entity<Testmaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TESTMASTER");

                entity.Property(e => e.Active).HasMaxLength(1);

                entity.Property(e => e.Comments).HasColumnType("ntext");

                entity.Property(e => e.PredefvalFieldid).HasColumnName("PREDEFVAL_Fieldid");

                entity.Property(e => e.PredefvalId).HasColumnName("PREDEFVAL_Id");

                entity.Property(e => e.PredefvalValNo).HasColumnName("PREDEFVAL_ValNo");

                entity.Property(e => e.PredefvalValue)
                    .HasColumnName("PREDEFVAL_Value")
                    .HasMaxLength(255);

                entity.Property(e => e.SpecialTest).HasMaxLength(1);

                entity.Property(e => e.TestdetAmaxValue).HasColumnName("TESTDET_AMaxValue");

                entity.Property(e => e.TestdetAminValue).HasColumnName("TESTDET_AMinValue");

                entity.Property(e => e.TestdetAnormalValue)
                    .HasColumnName("TESTDET_ANormalValue")
                    .HasMaxLength(255);

                entity.Property(e => e.TestdetBmaxValue).HasColumnName("TESTDET_BMaxValue");

                entity.Property(e => e.TestdetBminValue).HasColumnName("TESTDET_BMinValue");

                entity.Property(e => e.TestdetBnormalValue)
                    .HasColumnName("TESTDET_BNormalValue")
                    .HasMaxLength(255);

                entity.Property(e => e.TestdetCmaxValue).HasColumnName("TESTDET_CMaxValue");

                entity.Property(e => e.TestdetCminValue).HasColumnName("TESTDET_CMinValue");

                entity.Property(e => e.TestdetCnormalValue)
                    .HasColumnName("TESTDET_CNormalValue")
                    .HasMaxLength(255);

                entity.Property(e => e.TestdetCompulsory).HasColumnName("TESTDET_Compulsory");

                entity.Property(e => e.TestdetCurrentId).HasColumnName("TESTDET_CurrentId");

                entity.Property(e => e.TestdetDescription)
                    .HasColumnName("TESTDET_Description")
                    .HasMaxLength(255);

                entity.Property(e => e.TestdetDmaxValue).HasColumnName("TESTDET_DMaxValue");

                entity.Property(e => e.TestdetDminValue).HasColumnName("TESTDET_DMinValue");

                entity.Property(e => e.TestdetDnormalValue)
                    .HasColumnName("TESTDET_DNormalValue")
                    .HasMaxLength(255);

                entity.Property(e => e.TestdetFieldName)
                    .HasColumnName("TESTDET_FieldName")
                    .HasMaxLength(255);

                entity.Property(e => e.TestdetFieldNo).HasColumnName("TESTDET_FieldNo");

                entity.Property(e => e.TestdetFieldStyle).HasColumnName("TESTDET_FieldStyle");

                entity.Property(e => e.TestdetFieldType).HasColumnName("TESTDET_FieldType");

                entity.Property(e => e.TestdetGroupName)
                    .HasColumnName("TESTDET_GroupName")
                    .HasMaxLength(255);

                entity.Property(e => e.TestdetGroupNo).HasColumnName("TESTDET_GroupNo");

                entity.Property(e => e.TestdetMaxLimit).HasColumnName("TESTDET_MaxLimit");

                entity.Property(e => e.TestdetMaxValue).HasColumnName("TESTDET_MaxValue");

                entity.Property(e => e.TestdetMinLimit).HasColumnName("TESTDET_MinLimit");

                entity.Property(e => e.TestdetMinValue).HasColumnName("TESTDET_MinValue");

                entity.Property(e => e.TestdetNormalValue)
                    .HasColumnName("TESTDET_NormalValue")
                    .HasMaxLength(255);

                entity.Property(e => e.TestdetSAlias)
                    .HasColumnName("TESTDET_sAlias")
                    .HasMaxLength(50);

                entity.Property(e => e.TestdetSDefault)
                    .HasColumnName("TESTDET_sDefault")
                    .HasColumnType("ntext");

                entity.Property(e => e.TestdetSFormula)
                    .HasColumnName("TESTDET_sFormula")
                    .HasMaxLength(50);

                entity.Property(e => e.TestdetSUnit)
                    .HasColumnName("TESTDET_sUnit")
                    .HasMaxLength(50);

                entity.Property(e => e.TestdetTestMasterId).HasColumnName("TESTDET_TestMasterID");

                entity.Property(e => e.TestdetValidate).HasColumnName("TESTDET_Validate");

                entity.Property(e => e.TestmstAlias)
                    .HasColumnName("TESTMST_Alias")
                    .HasMaxLength(50);

                entity.Property(e => e.TestmstCatType)
                    .HasColumnName("TESTMST_CatType")
                    .HasMaxLength(3);

                entity.Property(e => e.TestmstCompanyid).HasColumnName("TESTMST_Companyid");

                entity.Property(e => e.TestmstCurrentId).HasColumnName("TESTMST_CurrentId");

                entity.Property(e => e.TestmstLumsum).HasColumnName("TESTMST_Lumsum");

                entity.Property(e => e.TestmstName)
                    .HasColumnName("TESTMST_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.TestmstPercentage).HasColumnName("TESTMST_Percentage");

                entity.Property(e => e.TestmstPrintFormat)
                    .HasColumnName("TESTMST_PrintFormat")
                    .HasMaxLength(255);

                entity.Property(e => e.TestmstRate).HasColumnName("TESTMST_Rate");

                entity.Property(e => e.TestmstReportHeading)
                    .HasColumnName("TESTMST_ReportHeading")
                    .HasMaxLength(255);

                entity.Property(e => e.TestmstSample)
                    .HasColumnName("TESTMST_sample")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TestmstTestTypeId).HasColumnName("TESTMST_TestTypeId");

                entity.Property(e => e.TestmstTestcost).HasColumnName("TESTMST_Testcost");

                entity.Property(e => e.Type).HasMaxLength(1);
            });

            modelBuilder.Entity<Testmst>(entity =>
            {
                entity.HasKey(e => e.TestmstCurrentId);

                entity.ToTable("TESTMST");

                entity.HasIndex(e => e.TestmstCurrentId)
                    .HasName("IX_TESTMST");

                entity.Property(e => e.TestmstCurrentId)
                    .HasColumnName("TESTMST_CurrentId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Active).HasMaxLength(1);

                entity.Property(e => e.Comments).HasColumnType("ntext");

                entity.Property(e => e.IsKitImageCompulsary)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.IsNabl)
                    .HasColumnName("IsNABL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialTest)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'N')");

                entity.Property(e => e.Tat).HasColumnName("TAT");

                entity.Property(e => e.TestmstAlias)
                    .HasColumnName("TESTMST_Alias")
                    .HasMaxLength(50);

                entity.Property(e => e.TestmstCatType)
                    .HasColumnName("TESTMST_CatType")
                    .HasMaxLength(3)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TestmstCompanyid).HasColumnName("TESTMST_Companyid");

                entity.Property(e => e.TestmstLumsum).HasColumnName("TESTMST_Lumsum");

                entity.Property(e => e.TestmstName)
                    .HasColumnName("TESTMST_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.TestmstPercentage).HasColumnName("TESTMST_Percentage");

                entity.Property(e => e.TestmstPrintFormat)
                    .HasColumnName("TESTMST_PrintFormat")
                    .HasMaxLength(255);

                entity.Property(e => e.TestmstRate).HasColumnName("TESTMST_Rate");

                entity.Property(e => e.TestmstReportHeading)
                    .HasColumnName("TESTMST_ReportHeading")
                    .HasMaxLength(255);

                entity.Property(e => e.TestmstSample)
                    .HasColumnName("TESTMST_sample")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TestmstTestTypeId)
                    .HasColumnName("TESTMST_TestTypeId")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TestmstTestcost).HasColumnName("TESTMST_Testcost");

                entity.Property(e => e.Type)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('P')");
            });

            modelBuilder.Entity<Testregister>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TESTREGISTER");

                entity.Property(e => e.TestdetFieldno).HasColumnName("TESTDET_Fieldno");

                entity.Property(e => e.TestmstId).HasColumnName("TESTMST_ID");
            });

            modelBuilder.Entity<Testtype>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TESTTYPE");

                entity.Property(e => e.TestTypeDescription).HasMaxLength(150);

                entity.Property(e => e.TestTypeName).HasMaxLength(50);

                entity.Property(e => e.TestTypeRemark).HasMaxLength(150);

                entity.Property(e => e.TestTypeRemark1).HasMaxLength(150);
            });

            modelBuilder.Entity<TreeView>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Parentid).HasColumnName("parentid");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UserMaster>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address).HasMaxLength(250);

                entity.Property(e => e.Age).HasMaxLength(50);

                entity.Property(e => e.Area).HasMaxLength(50);

                entity.Property(e => e.CentrId).HasColumnName("CentrID");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.ContactNo)
                    .HasColumnName("Contact_No")
                    .HasMaxLength(50);

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.LabCode).HasMaxLength(50);

                entity.Property(e => e.LabId).HasColumnName("LabID");

                entity.Property(e => e.LabName).HasMaxLength(350);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Pincode).HasMaxLength(50);

                entity.Property(e => e.Qualification).HasMaxLength(100);

                entity.Property(e => e.RegDate).HasColumnType("datetime");

                entity.Property(e => e.RowSent).HasMaxLength(50);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.SysDate)
                    .HasColumnName("Sys_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(5);

                entity.Property(e => e.UserName).HasMaxLength(150);
            });

            modelBuilder.Entity<Userrights>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("USERRIGHTS");

                entity.Property(e => e.MenuName).HasMaxLength(255);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("USERS");

                entity.Property(e => e.Admin).HasColumnName("admin");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_Id")
                    .HasDefaultValueSql("(2)");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.Userid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<V1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v1");

                entity.Property(e => e.CenterName)
                    .HasColumnName("CENTER_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.CenterRegion)
                    .HasColumnName("CENTER_Region")
                    .HasMaxLength(255);

                entity.Property(e => e.DochdrBCommission).HasColumnName("DOCHDR_bCommission");

                entity.Property(e => e.DochdrLDoctorId).HasColumnName("DOCHDR_lDoctorId");

                entity.Property(e => e.DochdrLPatientId).HasColumnName("DOCHDR_lPatientId");

                entity.Property(e => e.DochdrRate).HasColumnName("DOCHDR_Rate");

                entity.Property(e => e.DochdrSample).HasColumnName("DOCHDR_Sample");

                entity.Property(e => e.DochdrTestCatId).HasColumnName("DOCHDR_TestCatID");

                entity.Property(e => e.DoctorName)
                    .HasColumnName("DOCTOR_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Labno).HasColumnName("labno");

                entity.Property(e => e.PatientDate)
                    .HasColumnName("PATIENT_Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PatientDiscount).HasColumnName("Patient_Discount");

                entity.Property(e => e.PatientName)
                    .HasColumnName("PATIENT_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.SpecialTest).HasMaxLength(1);

                entity.Property(e => e.TestmstAlias)
                    .HasColumnName("TESTMST_Alias")
                    .HasMaxLength(50);

                entity.Property(e => e.WardNo).HasMaxLength(50);
            });

            modelBuilder.Entity<VwPatientBillDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_PATIENT_BILL_DETAILS");

                entity.Property(e => e.BlnCommission)
                    .HasColumnName("blnCommission")
                    .HasMaxLength(1);

                entity.Property(e => e.CenterName)
                    .HasColumnName("CENTER_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.CollectedatHospitalPaid).HasColumnName("COLLECTEDAtHospitalPaid");

                entity.Property(e => e.DochdrRate).HasColumnName("DOCHDR_Rate");

                entity.Property(e => e.DochdrTestCatId).HasColumnName("DOCHDR_TestCatID");

                entity.Property(e => e.DoctorName1)
                    .HasColumnName("Doctor_Name1")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorName2)
                    .HasColumnName("Doctor_Name2")
                    .HasMaxLength(255);

                entity.Property(e => e.IsProfile)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Labno).HasColumnName("labno");

                entity.Property(e => e.Neftpaid).HasColumnName("NEFTPAID");

                entity.Property(e => e.PatientAddress1)
                    .HasColumnName("PATIENT_Address1")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientAddress2)
                    .HasColumnName("PATIENT_Address2")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientAge)
                    .HasColumnName("PATIENT_Age")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientAmountPaid).HasColumnName("PATIENT_AmountPaid");

                entity.Property(e => e.PatientCity)
                    .HasColumnName("PATIENT_City")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientCountry).HasColumnName("PATIENT_Country");

                entity.Property(e => e.PatientDate)
                    .HasColumnName("PATIENT_Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PatientDoctorid).HasColumnName("PATIENT_Doctorid");

                entity.Property(e => e.PatientGender)
                    .HasColumnName("PATIENT_Gender")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientId).HasColumnName("PATIENT_id");

                entity.Property(e => e.PatientName)
                    .HasColumnName("PATIENT_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientPincode)
                    .HasColumnName("PATIENT_Pincode")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientRegion)
                    .HasColumnName("PATIENT_Region")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientSampleCollected).HasColumnName("PATIENT_SampleCollected");

                entity.Property(e => e.PatientState)
                    .HasColumnName("PATIENT_State")
                    .HasMaxLength(255);

                entity.Property(e => e.PatientTelno)
                    .HasColumnName("PATIENT_Telno")
                    .HasMaxLength(50);

                entity.Property(e => e.TestmstName)
                    .HasColumnName("TESTMST_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Type).HasMaxLength(1);

                entity.Property(e => e.Upipaid).HasColumnName("UPIPaid");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
