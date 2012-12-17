using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Common;

namespace Xdgk.Communi.Processor
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class ParseResultProcessorBase : IParseResultProcessor
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        protected ParseResultProcessorBase(string name, string forDevice, string description)
        {
            if (name == null)
                throw new ArgumentNullException("name");
            if (name.Trim().Length == 0)
                throw new ArgumentException("name empty");
            _name = name;

            if (forDevice == null)
                throw new ArgumentNullException("forDevice");
            if (forDevice.Trim().Length == 0)
                throw new ArgumentException("forDevice empty");
            _forDevice = forDevice;

            if (name == null)
                throw new ArgumentNullException("description");
            _description = description;
        }
        #region IParseResultProcessor 成员

        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get { return _name; }
        } private string _name;

        /// <summary>
        /// 
        /// </summary>
        public string FromStation
        {
            get { return _fromStation; }
            set { _fromStation = value; }
        } private string _fromStation;

        /// <summary>
        /// 
        /// </summary>
        public string FromDevice
        {
            get { return _fromDevice; }
            set { _fromDevice = value; }
        } private string _fromDevice;

        /// <summary>
        /// 
        /// </summary>
        public int FromAddress
        {
            get { return _fromAddress; }
            set { _fromAddress = value; }
        } private int _fromAddress;

        /// <summary>
        /// 
        /// </summary>
        public string FromOpera
        {
            get { return _fromOpera; }
            set { _fromOpera = value; }
        } private string _fromOpera;

        /// <summary>
        /// 
        /// </summary>
        public string Description
        {
            get { return _description; }
        } private string _description;

        /// <summary>
        /// 
        /// </summary>
        public string ForDevice
        {
            get { return _forDevice; }
        } private string _forDevice;

        /// <summary>
        /// 
        /// </summary>
        public string FromReceivePart
        {
            get { return _fromReceivePart; }
            set { _fromReceivePart = value; }
        } private string _fromReceivePart;


        /// <summary>
        /// 
        /// </summary>
        public DBIBase DBIBase
        {
            get { return _dbiBase; }
            set { _dbiBase = value; }
        } private DBIBase _dbiBase;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="communiSoft"></param>
        /// <param name="pr"></param>
        abstract public void ProcessParseResult(CommuniSoft communiSoft, ParseResult pr);

        #endregion
    }
}
