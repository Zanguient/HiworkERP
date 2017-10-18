//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HiWork.DAL.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }
    
        public System.Guid ID { get; set; }
        public long RegistrationID { get; set; }
        public Nullable<long> ApplicationID { get; set; }
        public string OrderNo { get; set; }
        public string InvoiceNo { get; set; }
        public System.Guid EstimationID { get; set; }
        public System.Guid CompanyID { get; set; }
        public string DeliveryDescription_en { get; set; }
        public string DeliveryDescription_jp { get; set; }
        public string DeliveryDescription_kr { get; set; }
        public string DeliveryDescription_cn { get; set; }
        public string DeliveryDescription_fr { get; set; }
        public string DeliveryDescription_tl { get; set; }
        public Nullable<decimal> QuoatedPrice { get; set; }
        public Nullable<decimal> ConsumptionTax { get; set; }
        public Nullable<decimal> CostExclTax { get; set; }
        public Nullable<decimal> BillingAmount { get; set; }
        public Nullable<decimal> OriginalCost { get; set; }
        public Nullable<decimal> WithdrawlAmount { get; set; }
        public Nullable<decimal> Profit { get; set; }
        public Nullable<int> OrderStatus { get; set; }
        public Nullable<int> PaymentStatus { get; set; }
        public Nullable<decimal> GrossInterestProfit { get; set; }
        public Nullable<bool> IsDeposited { get; set; }
        public string Remarks { get; set; }
        public Nullable<System.DateTime> Deadline { get; set; }
        public Nullable<System.DateTime> EstimatedDateOfDeposit { get; set; }
        public Nullable<int> ClientComplain { get; set; }
        public Nullable<int> StaffComplain { get; set; }
        public Nullable<int> NonStaffComplain { get; set; }
        public Nullable<System.DateTime> ComplainDate { get; set; }
        public Nullable<System.DateTime> ResponseComplainDate { get; set; }
        public string ComplainDetails { get; set; }
        public string AccountingRelatedMemo { get; set; }
        public Nullable<decimal> CostInclTax { get; set; }
        public Nullable<decimal> PaymentinInstallment { get; set; }
        public Nullable<decimal> InternalPayment { get; set; }
        public Nullable<decimal> FrontSalesCharge { get; set; }
        public Nullable<decimal> SCharge { get; set; }
        public Nullable<decimal> BCharge { get; set; }
        public Nullable<decimal> CCharge { get; set; }
        public Nullable<decimal> PartnerCharge { get; set; }
        public Nullable<decimal> NetProfit { get; set; }
        public Nullable<decimal> NetMarginRate { get; set; }
        public Nullable<decimal> GrossProfit { get; set; }
        public Nullable<decimal> GrossMarginRate { get; set; }
        public Nullable<decimal> OrderAmount { get; set; }
        public string CoordinatorMemo { get; set; }
        public string CoordinatorPrecautions { get; set; }
        public string CoordinatorNotes { get; set; }
        public string NotesToStaff { get; set; }
        public Nullable<bool> IsInternalComplain { get; set; }
        public Nullable<bool> IsClientComplain { get; set; }
        public string DirectManuscript_en { get; set; }
        public string DirectManuscript_cn { get; set; }
        public string DirectManuscript_jp { get; set; }
        public string DirectManuscript_kr { get; set; }
        public string DirectManuscript_tl { get; set; }
        public string DirectManuscript_fr { get; set; }
        public string CoordinatorNotes_en { get; set; }
        public string CoordinatorNotes_cn { get; set; }
        public string CoordinatorNotes_jp { get; set; }
        public string CoordinatorNotes_kr { get; set; }
        public string CoordinatorNotes_tl { get; set; }
        public string CoordinatorNotes_fr { get; set; }
        public string NotesToStaff_en { get; set; }
        public string NotesToStaff_cn { get; set; }
        public string NotesToStaff_jp { get; set; }
        public string NotesToStaff_kr { get; set; }
        public string NotesToStaff_tl { get; set; }
        public string NotesToStaff_fr { get; set; }
        public string CoordinatorMemo_en { get; set; }
        public string CoordinatorMemo_cn { get; set; }
        public string CoordinatorMemo_jp { get; set; }
        public string CoordinatorMemo_kr { get; set; }
        public string CoordinatorMemo_tl { get; set; }
        public string CoordinatorMemo_fr { get; set; }
        public string Remarks_en { get; set; }
        public string Remarks_cn { get; set; }
        public string Remarks_jp { get; set; }
        public string Remarks_kr { get; set; }
        public string Remarks_tl { get; set; }
        public string Remarks_fr { get; set; }
        public string ComplainDetails_en { get; set; }
        public string ComplainDetails_cn { get; set; }
        public string ComplainDetails_jp { get; set; }
        public string ComplainDetails_kr { get; set; }
        public string ComplainDetails_tl { get; set; }
        public string ComplainDetails_fr { get; set; }
        public string AccountingRelatedMemo_en { get; set; }
        public string AccountingRelatedMemo_cn { get; set; }
        public string AccountingRelatedMemo_jp { get; set; }
        public string AccountingRelatedMemo_kr { get; set; }
        public string AccountingRelatedMemo_tl { get; set; }
        public string AccountingRelatedMemo_fr { get; set; }
        public Nullable<System.Guid> Coordinator2ID { get; set; }
        public string EmailCCFullString { get; set; }
        public Nullable<int> PaymentDateByMonth { get; set; }
        public string CoordinatorPrecautions_en { get; set; }
        public string CoordinatorPrecautions_jp { get; set; }
        public string CoordinatorPrecautions_kr { get; set; }
        public string CoordinatorPrecautions_cn { get; set; }
        public string CoordinatorPrecautions_fr { get; set; }
        public string CoordinatorPrecautions_tl { get; set; }
        public Nullable<decimal> StaffPaymentCost { get; set; }
        public Nullable<decimal> StaffBillingCost { get; set; }
        public Nullable<decimal> GrossInterestRate { get; set; }
        public Nullable<System.DateTime> BillingDate { get; set; }
        public Nullable<bool> IsInternalResponse { get; set; }
        public Nullable<decimal> OutwardsSalesPersonShare { get; set; }
        public Nullable<decimal> Sales { get; set; }
        public Nullable<decimal> PersonCharge1 { get; set; }
        public Nullable<decimal> PersonCharge2 { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual Estimation Estimation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}