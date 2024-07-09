using System;

using DevExpress.Xpo;


namespace Atlas.Domain.Model
{
  public sealed class PublicHoliday : XPLiteObject
  {
    private int _publicHolidayId;
    [Key(AutoGenerate = true)]
    public int PublicHolidayId { get; set; }

    private string _name;
    [Persistent, Size(30)]
    public string Name
    {
      get { return _name; }
      set { SetPropertyValue("Name", ref _name, value); }
    }

    private DateTime _date;
    [Persistent]
    [Indexed]
    public DateTime Date
    {
      get { return _date; }
      set { SetPropertyValue("Date", ref _date, value); }
    }

        private string _BranchCode;
        [Persistent]
        public string BranchCode
        {
            get { return _BranchCode; }
            set { SetPropertyValue("BranchCode", ref _BranchCode, value); }
        }

        private int _Year;
        [Persistent]
        public int Year
        {
            get { return _Year; }
            set { SetPropertyValue("Year", ref _Year, value); }
        }

        private bool _IsHoliday;
        [Persistent]
        public bool IsHoliday
        {
            get { return _IsHoliday; }
            set { SetPropertyValue("IsHoliday", ref _IsHoliday, value); }
        }

        #region Constructors

        public PublicHoliday() : base() { }
    public PublicHoliday(Session session) : base(session) { }

    #endregion

  }
}
