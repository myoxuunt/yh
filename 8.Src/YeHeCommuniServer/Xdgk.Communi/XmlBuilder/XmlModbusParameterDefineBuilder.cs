using System;
using System.Xml;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using Xdgk.Common;

namespace Xdgk.Communi.XmlBuilder
{

    /// <summary>
    /// 
    /// </summary>
    public class XmlNameValueBuilder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        static public NameValueCollection BuildNameValueCollection(XmlNode node)
        {
            NameValueCollection nvc = new NameValueCollection();
            XmlNodeList nameValueNodeList = node.SelectNodes(NameValueNodeNames.NameValue);
            foreach (XmlNode nvNode in nameValueNodeList)
            {
                NameValue nv = BuildNameValue(nvNode);
                nvc.Add(nv);
            }
            return nvc;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        static public NameValue BuildNameValue(XmlNode node)
        {
            string name = XmlHelper.GetAttribute(node, NameValueNodeNames.Name);

            string value = XmlHelper.GetAttribute(node, NameValueNodeNames.Value);

            // TODO: change value to special type
            //
            //TypeCode typecode = TypeCode.Int32;
            //object valueObj = Convert.ChangeType(value, typecode);

            return new NameValue(name, value);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class XmlModbusParameterDefineBuilder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        static public ModbusParameterDefine Build(XmlNode node)
        {
            ModbusParameterDefine mpd = null;

            string temp = string.Empty;
            string name = string.Empty;
            string converter = string.Empty;
            string unit = string.Empty;
            int offset = 0;
            TypeCode tp = TypeCode.Int32;
            bool enableNameValue = false;

            //Xdgk.Common
            name = XmlHelper.GetAttribute(node, ParameterNodeNames.Name, false);
            temp = XmlHelper.GetAttribute(node, ParameterNodeNames.Offset, false);
            offset = int.Parse(temp);

            Debug.Assert(offset > 0, "offset must > 0");

            temp = XmlHelper.GetAttribute(node, ParameterNodeNames.TypeCode);
            tp = (TypeCode)Enum.Parse(typeof(TypeCode), temp, true);
            unit = XmlHelper.GetAttribute(node, ParameterNodeNames.Unit, true);
            converter = XmlHelper.GetAttribute(node, ParameterNodeNames.Converter, false);
            temp = XmlHelper.GetAttribute(node, ParameterNodeNames.EnableNameValues, true);
            if (temp != null && temp.Trim().Length > 0)
            {
                enableNameValue = bool.Parse(temp);
            }

            mpd = new ModbusParameterDefine(name, tp, converter, offset);
            mpd.EnableNameValue = enableNameValue;
            mpd.Unit = unit;
            
            // parse NameValueCollection
            //
            XmlNode nameValuesNode = node.SelectSingleNode(NameValueNodeNames.NameValueCollection);
            if (nameValuesNode != null)
            {
                NameValueCollection nameValueCollectioin = XmlNameValueBuilder.BuildNameValueCollection(nameValuesNode);
                mpd.NameValueCollection = nameValueCollectioin;
            }

            // TODO: 2010-07-29 Parse constraint
            //
            XmlNode constraintNode = node.SelectSingleNode(ConstraintNodeNames.Constraint);
            if (constraintNode != null)
            {
                Constraint c = ConstraintBuilder.Build(constraintNode, tp);
                mpd.Constraint = c; 
            }

            return mpd;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="noe"></param>
        /// <returns></returns>
        static public ModbusParamterDefineCollection BuildParameterDefineCollection(XmlNode node)
        {
            if( node == null )
                throw new ArgumentNullException("node");

            ModbusParamterDefineCollection mpdc = new ModbusParamterDefineCollection();
            XmlNodeList parameterNodeList = node.SelectNodes(ParameterNodeNames.ParameterDefine);
            foreach (XmlNode pn in parameterNodeList)
            {
                ModbusParameterDefine mpd = Build(pn);
                mpdc.Add(mpd);
            }

            return mpdc;
        }
    }
}
