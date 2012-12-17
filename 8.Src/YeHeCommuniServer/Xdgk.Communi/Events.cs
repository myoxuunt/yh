using System;
using System.Collections.Generic;
using System.Text;

namespace Xdgk.Communi
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public delegate void NotFindCommuniPortEventHandler(object sender, NotFindCommuniPortEventArgs e);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public delegate void TaskExecutingEventHandler(object sender, TaskExecutingEventArgs e);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public delegate void TaskExecutedEventHandler(object sender, TaskExecutedEventArgs e);


    #region TaskExecutingEventArgs
    public class TaskExecutingEventArgs : EventArgs
    {
        public TaskExecutingEventArgs(Task task)
        {
            if (task == null)
                throw new ArgumentNullException("task");
            this._task = task;
        }

        /// <summary>
        /// 
        /// </summary>
        public Task Task
        {
            get { return _task; }
        } private Task _task;
    }
    #endregion //TaskExecutingEventArgs

    #region TaskExecutedEventArgs
    public class TaskExecutedEventArgs : EventArgs
    {
        public TaskExecutedEventArgs(Task task, ParseResult parseResult)
        {
            if (task == null)
                throw new ArgumentNullException("task");
            this._task = task;

            if (parseResult == null)
                throw new ArgumentNullException("parseResult");
            this._parseResult = parseResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public Task Task
        {
            get { return _task; }
        } private Task _task;

        /// <summary>
        /// 
        /// </summary>
        public ParseResult ParseResult
        {
            get { return _parseResult; }
        } private ParseResult _parseResult;
    }
    #endregion //TaskExecutedEventArgs

    #region NotFindCommuniPortEventArgs
    public class NotFindCommuniPortEventArgs : EventArgs
    {
        public NotFindCommuniPortEventArgs(Task task)
        {
            if (task == null)
                throw new ArgumentNullException("task");
            this._task = task;
        }
        /// <summary>
        /// 
        /// </summary>
        public Task Task
        {
            get { return _task; }
        } private Task _task;
    }
    #endregion //NotFindCommuniPortEventArgs

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public delegate void ExceptionEventHandler ( object sender, ExceptionEventArgs e );


    #region CloseEventArgs
    /// <summary>
    /// 
    /// </summary>
    public class ExceptionEventArgs : System.EventArgs
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="closeException">can be null</param>
        public ExceptionEventArgs(Exception closeException)
        {
            this._exception = closeException;
        }

        /// <summary>
        /// 
        /// </summary>
        public Exception Exception
        {
            get { return _exception; }
        } private Exception _exception;
    }
    #endregion //CloseEventArgs 
    
    
    

    #region CommuniPortReceivedEventHandler
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public delegate void CommuniPortReceivedEventHandler( object sender, 
            CommuniPortReceivedEventArgs e );
    #endregion //CommuniPortReceivedEventHandler


    #region CommuniPortReceivedEventArgs
    /// <summary>
    /// 
    /// </summary>
    public class CommuniPortReceivedEventArgs : System.EventArgs
    {
        public CommuniPortReceivedEventArgs(CommuniPort cp, byte[] bytes)
        {
            if (cp == null)
                throw new ArgumentNullException("cp");
            this._communiPort = cp;

            this._receivedBytes = bytes;
        }

        /// <summary>
        /// 
        /// </summary>
        public CommuniPort CommuniPort
        {
            get { return _communiPort; }
        } private CommuniPort _communiPort;

        /// <summary>
        /// 
        /// </summary>
        public byte[] ReceivedBytes
        {
            get { return _receivedBytes; }
        } private byte[] _receivedBytes;
    }
    #endregion //CommuniPortReceivedEventArgs


    #region FDEventHandler
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public delegate void FDEventHandler( object sender, FDEventArgs e );
    #endregion //FDEventHandler

    #region FDEventArgs
    /// <summary>
    /// 
    /// </summary>
    public class FDEventArgs : EventArgs
    {

        #region FDEventArgs
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fromCommuniPort"></param>
        /// <param name="pr"></param>
        public FDEventArgs(CommuniPort fromCommuniPort, string deviceType, string operaName, ParseResult pr)
        {
            if (fromCommuniPort == null)
                throw new ArgumentNullException("fromCommuniPort");

            //if (opera == null)
                //throw new ArgumentNullException("opera");

            if (pr == null)
                throw new ArgumentNullException("pr");


            this._from = fromCommuniPort;
            this._pr = pr;
            this._deviceType = deviceType;
            this._operaName = operaName;
        }
        #endregion //FDEventArgs


        #region DeviceType
        /// <summary>
        /// 
        /// </summary>
        public string DeviceType
        {
            get { return _deviceType; }
        } private string _deviceType;
        #endregion //DeviceType


        #region OperaName
        /// <summary>
        /// 
        /// </summary>
        public string OperaName
        {
            get { return _operaName; }
        } private string _operaName;
        #endregion //OperaName

        #region From
        /// <summary>
        /// 
        /// </summary>
        public CommuniPort From
        {
            get { return _from; }
        } private CommuniPort _from;
        #endregion //From


        #region ParseResult
        /// <summary>
        /// 
        /// </summary>
        public ParseResult ParseResult
        {
            get { return _pr; }
        } private ParseResult _pr;
        #endregion //ParseResult
    }
    #endregion //FDEventArgs


    ///// <summary>
    ///// 
    ///// </summary>
    //public class AddCommuniPortEventArgs : EventArgs 
    //{
    //    #region AddCommuniPortEventArgs
    //    /// <summary>
    //    /// 
    //    /// </summary>
    //    /// <param name="cp"></param>
    //    public AddCommuniPortEventArgs(CommuniPort cp)
    //    {
    //        if (cp == null)
    //            throw new ArgumentNullException("cp");
    //        this._cp = cp;
    //    }
    //    #endregion //AddCommuniPortEventArgs


    //    #region CommuniPort
    //    /// <summary>
    //    /// 
    //    /// </summary>
    //    public CommuniPort CommuniPort
    //    {
    //        get { return _cp;}
    //    } private CommuniPort _cp;
    //    #endregion //CommuniPort

    //}

    ///// <summary>
    ///// 
    ///// </summary>
    ///// <param name="sender"></param>
    ///// <param name="e"></param>
    //public delegate void AddCommuniPortEventHandler( object sender, AddCommuniPortEventArgs e );




    #region ChangedType
    /// <summary>
    /// 
    /// </summary>
    public enum ChangedType
    {
        Add,
        Remove,
    }
    #endregion //ChangedType

    #region CollectionChangedEventHandler
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public delegate void CollectionChangedEventHandler( object sender, 
            CollectionChangedEventArgs e );
    #endregion //CollectionChangedEventHandler

    #region CollectionChangedEventArgs
    /// <summary>
    /// 
    /// </summary>
    public class CollectionChangedEventArgs : EventArgs
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        public CollectionChangedEventArgs(ChangedType changedType, object obj)
        {
            _changedType = changedType;
            _obj = obj;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChangedType ChangedType
        {
            get { return _changedType; }
        } private ChangedType _changedType;

        /// <summary>
        /// 
        /// </summary>
        public object Object
        {
            get { return _obj; }
        } private object _obj;
    }
    #endregion //CollectionChangedEventArgs
}
