﻿// License text here
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZigBeeNet.ZCL.Protocol;
using ZigBeeNet.ZCL.Field;
using ZigBeeNet.ZCL.Clusters.Thermostat;

/**
 * Get Weekly Schedule value object class.
 *
 * Cluster: Thermostat. Command is sentTO the server.
 * This command is a specific command used for the Thermostat cluster.
 *
 * Code is auto-generated. Modifications may be overwritten!
 */

/* Autogenerated: 18.02.2019 - 16:10 */
namespace ZigBeeNet.ZCL.Clusters.Thermostat
{
   public class GetWeeklySchedule : ZclCommand
   {
       /**
           * Days To Return command message field.
           */
           public byte DaysToReturn { get; set; }

       /**
           * Mode To Return command message field.
           */
           public byte ModeToReturn { get; set; }


           /**
           * Default constructor.
           */
           public GetWeeklySchedule()
           {
               GenericCommand = false;
               ClusterId = 513;
               CommandId = 2;
               CommandDirection = ZclCommandDirection.CLIENT_TO_SERVER;
           }

    public override void Serialize(ZclFieldSerializer serializer)
    {
        serializer.Serialize(DaysToReturn, ZclDataType.Get(DataType.BITMAP_8_BIT));
        serializer.Serialize(ModeToReturn, ZclDataType.Get(DataType.BITMAP_8_BIT));
    }

    public override void Deserialize(ZclFieldDeserializer deserializer)
    {
        DaysToReturn = deserializer.Deserialize<byte>(ZclDataType.Get(DataType.BITMAP_8_BIT));
        ModeToReturn = deserializer.Deserialize<byte>(ZclDataType.Get(DataType.BITMAP_8_BIT));
    }

       public override string ToString()
       {
           var builder = new StringBuilder();

           builder.Append("GetWeeklySchedule [");
           builder.Append(base.ToString());
           builder.Append(", DaysToReturn=");
           builder.Append(DaysToReturn);
           builder.Append(", ModeToReturn=");
           builder.Append(ModeToReturn);
           builder.Append(']');

           return builder.ToString();
       }

   }
}
