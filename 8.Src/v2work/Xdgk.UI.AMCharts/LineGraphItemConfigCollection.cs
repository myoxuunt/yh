using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Common;

namespace Xdgk.UI.AMCharts
{
    /// <summary>
    /// 
    /// </summary>
    public class LineGraphItemConfigCollection
        : Collection<LineGraphItemConfig>
    {

        public void Sort(List<string> stationOrderList)
        {
            for (int i = stationOrderList.Count - 1; i >= 0; i--)
            {
                string stationName = stationOrderList[i];
                LineGraphItemConfig item = Find(stationName);
                if (item != null)
                {
                    this.Remove(item);
                    this.Insert(0, item);
                }
            }
        }

        private LineGraphItemConfig Find(string name)
        {
            foreach (LineGraphItemConfig item in this)
            {
                if (StringHelper.Equal(item.Title, name))
                {
                    return item;
                }
            }
            return null;
        }
    }
}
