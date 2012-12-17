using System;
using System.Collections.Generic;
using System.Text;

namespace Xdgk.Communi.Interface
{

    /// <summary>
    /// 
    /// </summary>
    public enum PumpTypeEnum
    {
        CyclePump,
        RecruitPump,
    }

    /// <summary>
    /// 
    /// </summary>
    public enum PumpStateEnum
    {
        Stop = 0,
        Run = 1,
    }

    /// <summary>
    /// 
    /// </summary>
    public class PumpState
    {
        public PumpState(PumpTypeEnum type, int no, PumpStateEnum state)
        {
            this.PumpTypeEnum = type;
            this.PumpNO = no;
            this.PumpStateEnum = state;
        }
        /// <summary>
        /// 
        /// </summary>
        public PumpTypeEnum PumpTypeEnum
        {
            get { return _pumpTypeEnum; }
            set { _pumpTypeEnum = value; }
        } private PumpTypeEnum _pumpTypeEnum;

        /// <summary>
        /// 
        /// </summary>
        public int PumpNO
        {
            get { return _pumpNO; }
            set { _pumpNO = value; }
        } private int _pumpNO;

        /// <summary>
        /// 
        /// </summary>
        public PumpStateEnum PumpStateEnum
        {
            get { return _pumpStateEnum; }
            set { _pumpStateEnum = value; }
        } private PumpStateEnum _pumpStateEnum;
    }

    /// <summary>
    /// 
    /// </summary>
    public class PumpStateCollection : System.Collections.ObjectModel.Collection<PumpState>
    {
    }
}
