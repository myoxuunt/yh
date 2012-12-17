
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xdgk.Common;

namespace Xdgk.Communi
{
    /// <summary>
    /// 任务集合
    /// </summary>
    public class TaskCollection : Xdgk.Common.Collection<Task>
    {

        #region TaskCollection
        /// <summary>
        /// 
        /// </summary>
        public TaskCollection()
        {
        }
        #endregion //TaskCollection


        #region AddToHead
        /// <summary>
        /// 
        /// </summary>
        /// <param name="task"></param>
        public void AddToHead(Task task)
        {
            this.Insert(0, task);
        }
        #endregion //AddToHead


        #region AddToTail
        /// <summary>
        /// 
        /// </summary>
        /// <param name="task"></param>
        public void AddToTail(Task task)
        {
            this.Add(task);
        }
        #endregion //AddToTail


        #region Pick
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Task Pick()
        {
            if (this.Count > 0)
            {
                Task t = this[0];
                this.RemoveAt(0);
                return t;
            }
            return null;
        }
        #endregion //Pick


        #region GetTasks
        /// <summary>
        /// 获取该设备的Task
        /// </summary>
        /// <param name="device"></param>
        /// <param name="taskList"></param>
        /// <returns></returns>
        public void GetTasks(Device device, List<Task> taskList)
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                Task t = this[i];
                if (t.Device == device)
                {
                    taskList.Add(t);
                }
            }
        }
        #endregion //GetTasks

        /// <summary>
        /// 
        /// </summary>
        /// <param name="device"></param>
        public void RemoveByDevice(Device device)
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                Task task = this[i];
                if (task.Device == device)
                {
                    this.Remove(task);
                }
            }
        }
    }
}
