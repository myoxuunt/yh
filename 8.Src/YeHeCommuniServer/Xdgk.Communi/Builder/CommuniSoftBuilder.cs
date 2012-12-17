using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Diagnostics;
using System.Net;

namespace Xdgk.Communi.Builder
{
    public class CommuniSoftBuilder
    {
        #region ...
        ///// <summary>
        ///// 
        ///// </summary>
        //public void Build()
        //{
        //    _soft = new CommuniSoft();
        //    XmlDocument doc = new XmlDocument();
        //    doc.Load(_filename);
        //    XmlNode softnode = doc.SelectSingleNode(XmlNodeNames.Soft);

        //    //XmlNode stationsNode = softnode.SelectSingleNode(XmlNodeNames.StationCollection);
        //    //BuildStationCollection(_soft, stationsNode);

        //    //XmlNode deviceDefinesNode = softnode.SelectSingleNode(XmlNodeNames.DeviceDefineCollection);
        //    //_soft.OperaFactory.DeviceDefinesNode = deviceDefinesNode;

        //    XmlNode tasksNode = softnode.SelectSingleNode(XmlNodeNames.TaskCollection);
        //    if (tasksNode != null)
        //    {
        //        BuildTaskCollection(_soft, tasksNode);
        //    }
        //}
        #endregion //

        private DeviceDefineBuilderBase _deviceDefineBuilder;
        private HardwareBuilderBase _hardwareBuilder;
        private TaskFactoryCollectionBuilder _taskFactoriesBuilder;
        private ListenBuilderBase _listenBuilder;


        #region CommuniSoftBuilder
        /// <summary>
        /// 
        /// </summary>
        /// <param name="deviceDefineBuilder"></param>
        /// <param name="hardwareBuilder"></param>
        /// <param name="taskFactoriesBuilder"></param>
        public CommuniSoftBuilder( DeviceDefineBuilderBase deviceDefineBuilder,
            HardwareBuilderBase hardwareBuilder,
            TaskFactoryCollectionBuilder taskFactoriesBuilder,
            ListenBuilderBase listenBuilder)
        {
            if (hardwareBuilder == null)
                throw new ArgumentNullException("hardwareBuilder");
            if (deviceDefineBuilder == null)
                throw new ArgumentNullException("deviceDefineBuilder");
            if (taskFactoriesBuilder == null)
                throw new ArgumentNullException("taskFactoriesBuilder");
            if (listenBuilder == null)
                throw new ArgumentNullException("listenBuilder");

            _deviceDefineBuilder = deviceDefineBuilder;
            _hardwareBuilder = hardwareBuilder;
            _taskFactoriesBuilder = taskFactoriesBuilder;
            _listenBuilder = listenBuilder;
        }
        #endregion //CommuniSoftBuilder


        #region Build
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual void Build(CommuniSoft soft)
        {
            //CommuniSoft soft = new CommuniSoft();
            this._deviceDefineBuilder.Build(soft);
            this._hardwareBuilder.Build(soft);
            this._taskFactoriesBuilder.Build(soft);
            this._listenBuilder.Build(soft);
        }
        #endregion //Build

    }
}
