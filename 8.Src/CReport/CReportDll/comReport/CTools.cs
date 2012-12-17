using System;

namespace CReportDll.comReport
{
	/// <summary>
	/// CTools 的摘要说明。
	/// </summary>
	public class CTools
	{
		public CTools()
		{			
		}
		public DateTime LastDayOfMonth(DateTime pdtmDate)
		{
			DateTime dtmDate = new DateTime(pdtmDate.Year, pdtmDate.Month, 1);
			return dtmDate.AddMonths(1).AddDays(-1);
		}
	}
}
