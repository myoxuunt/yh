using System;

namespace Xdgk.Communi
{
    /// <summary>
    /// 通讯口基类
    /// </summary>
    public abstract class CommuniPort
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        abstract public bool Write(byte[] bytes);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        abstract public byte[] Read();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ct"></param>
        /// <returns></returns>
        abstract public bool Match(CommuniType communiType);

        private DateTime _occupyBeginDT;
        private TimeSpan _occupyTS;

        private bool _occupy = false;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        public void Occupy(TimeSpan ts)
        {
            if (ts < TimeSpan.Zero)
                throw new ArgumentOutOfRangeException("ts", ts, "must > TimeSpan.Zero");
            if (_occupy)
                throw new InvalidOperationException("cannot Occupy");

            _occupyBeginDT = DateTime.Now;
            _occupyTS = ts;
            _occupy = true;
        }

        /// <summary>
        /// 获取该CommuniPort是够被占用标志
        /// </summary>
        public bool IsOccupy
        {
            get 
            {
                if (_occupy)
                {
                    TimeSpan ts = DateTime.Now - _occupyBeginDT;
                    if (ts >= _occupyTS || ts < TimeSpan.Zero)
                    {
                        _occupy = false;
                        return _occupy;
                    }
                    else
                    {
                        return true;
                    }
                }
                return _occupy;
            }
        }


        /// <summary>
        /// 从所属集合中删除该对象
        /// </summary>
        public virtual void Remove()
        {
            if (this.CommuniPorts != null)
            {
                this.CommuniPorts.Remove(this);
            }
        }

        /// <summary>
        /// 获取或设置与该CommuniPort相关的Station
        /// </summary>
        public Station Station
        {
            get { return _station; }
            set
            {
                if( _station != value )
                    _station = value;
            }
        } private Station _station;

        /// <summary>
        /// 获取或设置所属集合
        /// </summary>
        public CommuniPortCollection CommuniPorts
        {
            get { return _communiPorts; }
            set
            {
                if (this._communiPorts != value)
                {
                    _communiPorts = value;
                }
            }
        } private CommuniPortCollection _communiPorts;
    }
}