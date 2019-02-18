﻿// License text here
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZigBeeNet.ZCL.Protocol;
using ZigBeeNet.ZCL.Field;
using ZigBeeNet.ZCL.Clusters.General;

/**
 * Write Attributes Response value object class.
 *
 * Cluster: General. Command is sentTO the server.
 * This command is a generic command used across the profile.
 *
 * The write attributes response command is generated in response to a write * attributes command. *
 * Code is auto-generated. Modifications may be overwritten!
 */

/* Autogenerated: 18.02.2019 - 16:10 */
namespace ZigBeeNet.ZCL.Clusters.General
{
   public class WriteAttributesResponse : ZclCommand
   {
       /**
           * Records command message field.
           */
           public List<WriteAttributeStatusRecord> Records { get; set; }


           /**
           * Default constructor.
           */
           public WriteAttributesResponse()
           {
               GenericCommand = true;
               CommandId = 4;
               CommandDirection = ZclCommandDirection.CLIENT_TO_SERVER;
           }

    public override void Serialize(ZclFieldSerializer serializer)
    {
        serializer.Serialize(Records, ZclDataType.Get(DataType.N_X_WRITE_ATTRIBUTE_STATUS_RECORD));
    }

    public override void Deserialize(ZclFieldDeserializer deserializer)
    {
        Records = deserializer.Deserialize<List<WriteAttributeStatusRecord>>(ZclDataType.Get(DataType.N_X_WRITE_ATTRIBUTE_STATUS_RECORD));
    }

       public override string ToString()
       {
           var builder = new StringBuilder();

           builder.Append("WriteAttributesResponse [");
           builder.Append(base.ToString());
           builder.Append(", Records=");
           builder.Append(Records);
           builder.Append(']');

           return builder.ToString();
       }

   }
}
