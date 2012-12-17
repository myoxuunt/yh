using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Common;
using System.Xml;

namespace Xdgk.Communi.XmlBuilder
{
    /// <summary>
    /// 
    /// </summary>
    public class ConstraintBuilder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="constraintNode"></param>
        /// <param name="type">value type code</param>
        /// <returns></returns>
        static public Constraint Build(XmlNode constraintNode, TypeCode typeCode)
        {
            string name = XmlHelper.GetAttribute(constraintNode, ConstraintNodeNames.Name, false);
            if (StringHelper.Equal(name, ConstraintNodeNames.RangeConstraint))
            {
                XmlNode rangeConstraintNode = constraintNode.SelectSingleNode(ConstraintNodeNames.RangeConstraint);
                if (rangeConstraintNode == null)
                    throw new ConfigException("not find RangeConstraintNode");

                return BuildRangeConstraint(rangeConstraintNode, typeCode);
            }

            // TODO:
            //
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rangeConstraintNode"></param>
        /// <returns></returns>
        static public RangeConstraint BuildRangeConstraint(XmlNode rangeConstraintNode, TypeCode typeCode)
        {
            RangeConstraint rc = null;
            string fromString = rangeConstraintNode.SelectSingleNode(ConstraintNodeNames.From).InnerText ;
            string toString = rangeConstraintNode.SelectSingleNode(ConstraintNodeNames.To).InnerText ;

            IComparable from = (IComparable)Convert.ChangeType(fromString, typeCode);
            IComparable to = (IComparable)Convert.ChangeType(toString, typeCode);

            // TODO: 2010-07-29 change form, to data type
            //
            rc = new RangeConstraint(from, to);
            return rc;
        }
    }
}
