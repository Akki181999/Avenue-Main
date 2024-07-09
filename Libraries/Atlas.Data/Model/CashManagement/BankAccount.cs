using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.CashManagement
{
   public class BankAccount : XPLiteObject
	{
		private long _bankAccountId;
		[Key(AutoGenerate = true)]
		[Persistent]
		public long BankAccountId
		{
			get
			{
				return _bankAccountId;
			}
			set
			{
				_bankAccountId = value;
			}
		}

		private long _region;
		[Persistent]
		public long Region
        {
            get
            {
				return _region;
            }
            set
            {
				_region = value;
            }
        }

		private string _accountNumber;
		[Persistent]
		public string AccountNumber
		{
			get
			{
				return _accountNumber;
			}
			set
			{
				_accountNumber = value;
			}
		}
		private string _accountName;
		[Persistent]
		public string AccountName
		{
			get
			{
				return _accountName;
			}
			set
			{
				_accountName = value;
			}
		}
		private int _createdBy;
		[Persistent]
		public int CreatedBy
		{
			get
			{
				return _createdBy;
			}
			set
			{
				_createdBy = value;
			}
		}

		
		private DateTime? _updatedDT;
		[Persistent]
		public DateTime? UpdatedDate
		{
			get
			{
				return _updatedDT;
			}
			set
			{
				SetPropertyValue("UpdatedDate", ref _updatedDT, value);
			}
		}
		private DateTime? _createdDT;
		[Persistent]
		public DateTime? CreatedDate
		{
			get
			{
				return _createdDT;
			}
			set
			{
				SetPropertyValue("CreatedDate", ref _createdDT, value);
			}
		}
		private int _updatedBy;
		[Persistent]
		public int UpdatedBy
		{
			get
			{
				return _updatedBy;
			}
			set
			{
				_updatedBy = value;
			}
		}
		private int _bankCode;
		[Persistent]
		public int BankCode
		{
			get
			{
				return _bankCode;
			}
			set
			{
				_bankCode = value;
			}
		}

		public BankAccount() : base() { }
		public BankAccount(Session session) : base(session) { }
	}
}
