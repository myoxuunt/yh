namespace Xdgk.Common
{
    public class DGVColumnConfig
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataPropertyName"></param>
        /// <param name="format"></param>
        /// <param name="text"></param>
        public DGVColumnConfig(string dataPropertyName, string format, string text)
            : this(dataPropertyName, format, text, 90)
        {

        }

        #region DGVColumnConfig
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataPropertyName"></param>
        /// <param name="format"></param>
        /// <param name="text"></param>
        public DGVColumnConfig(string dataPropertyName, string format, string text, int width)
        {
            this.DataPropertyName = dataPropertyName;
            this.Format = format;
            this.Text = text;
            this.Width = width;
        }
        #endregion //DGVColumnConfig


        #region DataPropertyName
        /// <summary>
        /// 
        /// </summary>
        public string DataPropertyName
        {
            get
            {
                if (_dataPropertyName == null)
                    _dataPropertyName = string.Empty;
                return _dataPropertyName;
            }
            set { _dataPropertyName = value; }
        } private string _dataPropertyName;
        #endregion //DataPropertyName

        #region Format
        /// <summary>
        /// 
        /// </summary>
        public string Format
        {
            get
            {
                if (_format == null)
                    _format = string.Empty;
                return _format;
            }
            set { _format = value; }
        } private string _format;
        #endregion //Format

        #region Width
        /// <summary>
        /// 
        /// </summary>
        public int Width
        {
            get
            {
                if( _width < 0)
                    _width = 90;
                return _width;
            }
            set { _width = value; }
        } private int _width;
        #endregion //Width


        #region Text
        /// <summary>
        /// 
        /// </summary>
        public string Text
        {
            get
            {
                if (_text == null)
                    _text = string.Empty;
                return _text;
            }
            set { _text = value; }
        } private string _text;
        #endregion //Text

        #region Visible
        /// <summary>
        /// 
        /// </summary>
        public bool Visible
        {
            get { return _visible; }
            set { _visible = value; }
        } private bool _visible = true;
        #endregion //Visible

    }


    /// <summary>
    /// 
    /// </summary>
    public class DGVColumnConfigCollection : Xdgk.Common.Collection<DGVColumnConfig>
    {
    }
}