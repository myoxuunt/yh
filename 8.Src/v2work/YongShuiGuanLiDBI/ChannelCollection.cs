using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class ChannelCollection : Xdgk.Common.Collection<ChannelClass>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="selectedChannelID"></param>
        public void RemoveByID(int channelID)
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                ChannelClass c = this[i];
                if (c.ChannelID == channelID)
                {
                    this.RemoveAt(i);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int[] GetChannelIDs()
        {
            ArrayList list = new ArrayList();
            foreach (ChannelClass c in this)
            {
                list.Add(c.ChannelID);
            }
            return (int[])list.ToArray(typeof(int));
        }

        /// <summary>
        /// 
        /// </summary>
        public StationCollection StationCollection
        {
            get
            {
                StationCollection temp = new StationCollection();
                foreach (ChannelClass c in this)
                {
                    temp.Add(c.StationCollection);
                }
                return temp;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ChannelClass GetChannelByID(int id)
        {
            foreach (ChannelClass c in this)
            {
                if (c.ChannelID == id)
                {
                    return c; 
                }
            }
            return null;
        }
    }
}
