using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using Xdgk.Communi.Builder;
using Xdgk.Communi.Factory;

namespace Xdgk.Communi.XmlBuilder
{
    public class XmlTaskFactoryCollectionBuilder : TaskFactoryCollectionBuilder
    {
        private string _filename;
        private TaskFactoryCollection _taskFactories = new TaskFactoryCollection();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filename"></param>
        public XmlTaskFactoryCollectionBuilder( string filename )
        {
            _filename = filename;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="soft"></param>
        public override void Build(CommuniSoft soft)
        {
            BuildTaskFactories();
            AddTasks(soft);
        }

        /// <summary>
        /// 
        /// </summary>
        private void AddTasks(CommuniSoft soft)
        {
            foreach (TaskFactory factory in this._taskFactories)
            {
                factory.Create( soft );
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void BuildTaskFactories()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(_filename);
            XmlNode tasksNode = doc.SelectSingleNode(TaskFactoryNodeNames.TaskFactoryCollection);
            if (tasksNode != null)
            {
                foreach (XmlNode node in tasksNode)
                {
                    switch (node.Name)
                    {
                        case TaskFactoryNodeNames.TaskFactory:
                            //TaskCollection tasks = DoTask(node);
                            //foreach (Task t in tasks)
                            //    _soft.TaskManager.Tasks.Add(t);
                            TaskFactory f = BuildTaskFactory(node);
                            this._taskFactories.Add(f);
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private TaskFactory BuildTaskFactory(XmlNode taskFactoryNode)
        {
            string devicetype = string.Empty;
            string opname = string.Empty;
            CycleStrategyFactory strategyFactory = null;

            foreach (XmlNode node in taskFactoryNode.ChildNodes)
            {
                switch (node.Name)
                {
                    case TaskFactoryNodeNames.DeviceType:
                        devicetype = node.InnerText;
                        break;
                    
                    case TaskFactoryNodeNames.TaskOperaName:
                        opname = node.InnerText;
                        break;

                    case TaskFactoryNodeNames.StrategyType:
                        {
                            string type = node.InnerText;
                            if (type == TaskFactoryNodeNames.CycleStrategy)
                            {
                                XmlNode n2 = taskFactoryNode.SelectSingleNode(type);

                                strategyFactory = DoCycleStartegyFactory(n2);
                            }
                        }
                        break;
                }
            }
            return new TaskFactory(devicetype, opname, strategyFactory);
        }

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="node"></param>
        ///// <returns></returns>
        //TaskCollection DoTask(XmlNode tasknode)
        //{
        //    if (tasknode == null)
        //        throw new ArgumentNullException("tasknode");

            //TaskCollection tasks = new TaskCollection();
            //string devicetype = string.Empty;
            //string opname = string.Empty;
            //CycleStrategyFactory strategyFactory = null;
            //foreach (XmlNode node in tasknode.ChildNodes)
            //{
            //    switch (node.Name)
            //    {
            //        case XmlNodeNames.DeviceType:
            //            devicetype = node.InnerText;
            //            break;
                    
            //        case XmlNodeNames.TaskOperaName:
            //            opname = node.InnerText;
            //            break;

            //        case XmlNodeNames.StrategyType:
            //            {
            //                string type = node.InnerText;
            //                if (type == XmlNodeNames.CycleStrategy)
            //                {
            //                    XmlNode n2 = tasknode.SelectSingleNode(type);

            //                    strategyFactory = DoCycleStartegyFactory(n2);
            //                }
            //            }
            //            break;
            //    }
            //}

            //foreach (Station st in _soft.HardwareManager.Stations)
            //{
            //    foreach (Device device in st.Devices)
            //    {
            //        if (device.DeviceType == devicetype)
            //        {
            //            // create op with opera name
            //            //
            //            Opera op = this._soft.OperaFactory.Create(devicetype, opname);
            //            Task t = new Task(device, op, strategyFactory.Create());
            //            tasks.Add(t);
            //        }
            //    }
            //}
            //return tasks;
        //    return null;
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private CycleStrategyFactory DoCycleStartegyFactory(XmlNode cyclenode)
        {
            if (cyclenode == null)
                throw new ArgumentNullException("cycleNode");

            XmlNode node = cyclenode.SelectSingleNode(TaskFactoryNodeNames.CycleValue);
            TimeSpan ts = TimeSpan.Parse(node.InnerText);
            return new CycleStrategyFactory(ts);
        }
    }
}
