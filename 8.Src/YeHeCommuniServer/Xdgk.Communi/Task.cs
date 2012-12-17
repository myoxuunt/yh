using System;
using NUnit.Core;

namespace Xdgk.Communi
{     
    /// <summary>
    /// 通讯任务
    /// </summary>
    public class Task : Xdgk.Common.ObjectBase
    {
        static private Logger log = InternalTrace.GetLogger(typeof(Task));

        /// <summary>
        /// 
        /// </summary>
        private byte[] _lastSendBytes = null;

        #region Constructor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="opera"></param>
        public Task(Device device, Opera opera, Strategy strategy)
        {
            this.Device = device;
            this.Opera = opera;
            this.Strategy = strategy;
        }
        #endregion //

        #region Device
        /// <summary>
        /// 
        /// </summary>
        public Device Device
        {
            get { return _device; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("device");
                if (this._device != value)
                    this._device = value;
            }
        }private Device _device;
        #endregion //

        #region LastExecute
        /// <summary>
        /// 获取或设置最后执行时间
        /// </summary>
        public DateTime LastExecute
        {
            get { return _lastExecute; }
            set { _lastExecute = value; }
        } private DateTime _lastExecute;
        #endregion //

        #region Strategy
        /// <summary>
        /// 
        /// </summary>
        public Strategy Strategy
        {
            get { return _strategy; }
            //set
            //{
            //    if (value == null)
            //        throw new ArgumentNullException("strategy");
            //    if (this._strategy != value)
            //        this._strategy = value;
            //}
            set 
            { 
                if (value == null)
                    throw new ArgumentNullException ("Strategy");
                
                // taskStrategy value != current taskStrategy
                //
                if (this._strategy != value)
                {
                    // taskStrategy value not associate to other task
                    //
                    if (value.Owning != null)
                    {
                        throw new ArgumentException("Strategy.Owning must be null");
                    }

                    // if current taskStrategy not null, release it.
                    //
                    if ( this._strategy != null)
                        this._strategy.Owning = null;

                    // associate 
                    //
                    _strategy = value;
                    _strategy.Owning = this;
                }
            }
        } private Strategy _strategy;
        #endregion //

        #region Opera
        /// <summary>
        /// 
        /// </summary>
        public Opera Opera
        {
            get { return _opera; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("opera");

                if (this._opera != value)
                    this._opera = value;
            }
        } private Opera _opera;
        #endregion //Opera

        #region CanRemove
        /// <summary>
        /// 获取该Task是否可以删除标记
        /// </summary>
        virtual public bool CanRemove
        {
            get
            {
                return this.Strategy.CanRemove;
            }
        }
        #endregion //

        #region NeedExecute
        /// <summary>
        /// 在当前时间，该Task是否需要执行
        /// </summary>
        /// <returns></returns>
        public bool NeedExecute()
        {
            return this.NeedExecute(DateTime.Now);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns></returns>
        public bool NeedExecute(DateTime datetime)
        {
            return this.Strategy.NeedExecute(datetime);
        }
        #endregion //

        #region GetSendBytes
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public byte[] GetSendBytes()
        {
            this.Opera.SendPart["Address"] = this.Device.Address;
            //return this.Opera.SendPart.ToBytes();
            byte[] bs = this.Opera.SendPart.ToBytes();
            this._lastSendBytes = bs;
            return bs;
        }
        #endregion //GetSendBytes

        #region ParseReceiced
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public ParseResult ParseReceiced(byte[] bytes)
        {
            ParseResult pr = this.Opera.ReceiveParts.ToValues(bytes);

            // add send received log
            //
            AddCommuniDetail(this._lastSendBytes, bytes, pr);

            if (!pr.Success)
            {
                AddCommuniFailDetail(bytes, pr);
            }

            // match address
            //
            object addressObject = pr.NameObjects.GetObject("ADDRESS");
            if (addressObject != null)
            {
                
                //int address = (int)addressObject;
                int address = Convert.ToInt32(addressObject);
                if (address != this.Device.Address)
                {
                    //return new DataErrorResult( pr.ReceivePartName, pr
                    pr = new AddressErrorResult(pr.ReceivePartName, this.Device.Address, address);
                    AddCommuniFailDetail(bytes, pr);
                }
            }

            return pr;
        }


        #endregion //ParseReceiced

        #region AddCommuniFailDetail
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        /// <param name="pr"></param>
        private void AddCommuniFailDetail(byte[] bytes, ParseResult pr)
        {
            CommuniFailDetail cfd = new CommuniFailDetail(
                this.Device.DeviceType,
                this.Opera.ToString(), 
                pr.ToString(), 
                bytes);

            this.Device.CommuniFailDetails.Add(cfd);

            string s = string.Format("Parse '{0} {1}' fail, opera '{2}', bytes '{3}'",
                Device.DeviceType, Opera.Name, pr,
                bytes == null ? "" : BitConverter.ToString(bytes));
            log.Debug(s);
        }
        #endregion //AddCommuniFailDetail
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        /// <param name="pr"></param>
        private void AddCommuniDetail(byte[] send, byte[] received, ParseResult pr)
        {
            ParseResultEnum pre = pr.Success ? ParseResultEnum.Success : ParseResultEnum.Fail;
            CommuniDetail detail = new CommuniDetail(
                this.Opera.ToString(),
                pr.ToString(),
                send,
                received,
                pre);
            this.Device.CommuniDetailQueue.Enqueue(detail);
        }
    }
}
