using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Xdgk.Communi
{
    internal class StationCommuniPortBinder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stations"></param>
        /// <param name="cp"></param>
        static internal bool Bind(StationCollection stations, CommuniPort cp)
        {
            if (stations == null)
                throw new ArgumentNullException("stations");

            if (cp == null)
                throw new ArgumentNullException("cp");

            if (cp is SocketCommuniPort)
            {
                return Bind(stations, cp as SocketCommuniPort);
            }
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stations"></param>
        /// <param name="scp"></param>
        internal static bool Bind(StationCollection stations, SocketCommuniPort scp)
        {
            foreach (Station st in stations)
            {
                if (scp.Match(st.CommuniType))
                {    
                    ClearBind(st);
                    return Bind(st, scp);
                }
            }
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="st"></param>
        /// <param name="cp"></param>
        private static bool Bind(Station st, CommuniPort cp)
        {
            if (st == null)
                throw new ArgumentNullException("st");
            if (cp == null)
                throw new ArgumentNullException("cp");

            Debug.Assert(st.CommuniPort == null &&
                cp.Station == null, 
                "Bind fail, st.CommuniPort or cp.Station not null");

            //Unbind(st, cp);
            st.CommuniPort = cp;
            cp.Station = st;
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="st"></param>
        /// <param name="cp"></param>
        internal static void Unbind(Station st, CommuniPort cp)
        {
            if (st == null)
                throw new ArgumentNullException("st");
            if (cp == null)
                throw new ArgumentNullException("cp");

            if (st.CommuniPort == null && cp.Station == null)
                return;

            Debug.Assert(
                st.CommuniPort != null &&
                cp.Station != null &&
                st.CommuniPort == cp && 
                cp.Station == st,
                "Unbind(Station, CommuniPort) assert fail");

            st.CommuniPort = null;
            cp.Station = null;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="cp"></param>
        internal static void ClearBind(CommuniPort cp)
        {
            if (cp.Station != null)
            {
                Unbind(cp.Station, cp);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="st"></param>
        internal static void ClearBind(Station st)
        {
            if (st.CommuniPort != null)
            {
                Unbind(st, st.CommuniPort);
            }
        }
    }
}
