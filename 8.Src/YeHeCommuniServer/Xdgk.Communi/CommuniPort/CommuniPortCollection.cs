using System.Diagnostics;

namespace Xdgk.Communi
{
    /// <summary>
    /// 通讯口集合
    /// </summary>
    public class CommuniPortCollection : Xdgk.Common.Collection<CommuniPort>
    {
        /// <summary>
        /// 
        /// </summary>
        public CommuniPortCollection()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="item"></param>
        protected override void InsertItem(int index, CommuniPort item)
        {
            base.InsertItem(index, item);
            Debug.Assert(item.CommuniPorts == null, "item.CommuniPorts != null");
            item.CommuniPorts = this;
        }
    }
}