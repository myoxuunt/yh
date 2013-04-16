namespace PS6216DataImporter
{
    public class TransItem
    {
        public TransItem()
        {
        }

        #region FromDevice
        /// <summary>
        /// 
        /// </summary>
        public FromDevice FromDevice
        {
            get
            {
                if (_fromDevice == null)
                {
                }
                return _fromDevice;
            }
            set
            {
                _fromDevice = value;
            }
        } private FromDevice _fromDevice;
        #endregion //FromDevice

        #region ToDevice
        /// <summary>
        /// 
        /// </summary>
        public ToDevice ToDevice
        {
            get
            {
                if (_toDevice == null)
                {
                    _toDevice = new ToDevice();
                }
                return _toDevice;
            }
            set
            {
                _toDevice = value;
            }
        } private ToDevice _toDevice;
        #endregion //ToDevice

    }

}
