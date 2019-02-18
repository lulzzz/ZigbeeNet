﻿// License text here
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZigBeeNet.ZCL.Protocol;
using ZigBeeNet.ZCL.Field;
using ZigBeeNet.ZCL.Clusters.RSSILocation;

/**
 * Set Absolute Location Command value object class.
 *
 * Cluster: RSSI Location. Command is sentTO the server.
 * This command is a specific command used for the RSSI Location cluster.
 *
 * Code is auto-generated. Modifications may be overwritten!
 */

/* Autogenerated: 18.02.2019 - 16:04 */
namespace ZigBeeNet.ZCL.Clusters.RSSILocation
{
   public class SetAbsoluteLocationCommand : ZclCommand
   {
       /**
           * Coordinate 1 command message field.
           */
           public short Coordinate1 { get; set; }

       /**
           * Coordinate 2 command message field.
           */
           public short Coordinate2 { get; set; }

       /**
           * Coordinate 3 command message field.
           */
           public short Coordinate3 { get; set; }

       /**
           * Power command message field.
           */
           public short Power { get; set; }

       /**
           * Path Loss Exponent command message field.
           */
           public ushort PathLossExponent { get; set; }


           /**
           * Default constructor.
           */
           public SetAbsoluteLocationCommand()
           {
               GenericCommand = false;
               ClusterId = 11;
               CommandId = 0;
               CommandDirection = ZclCommandDirection.CLIENT_TO_SERVER;
           }

    public override void Serialize(ZclFieldSerializer serializer)
    {
        serializer.Serialize(Coordinate1, ZclDataType.Get(DataType.SIGNED_16_BIT_INTEGER));
        serializer.Serialize(Coordinate2, ZclDataType.Get(DataType.SIGNED_16_BIT_INTEGER));
        serializer.Serialize(Coordinate3, ZclDataType.Get(DataType.SIGNED_16_BIT_INTEGER));
        serializer.Serialize(Power, ZclDataType.Get(DataType.SIGNED_16_BIT_INTEGER));
        serializer.Serialize(PathLossExponent, ZclDataType.Get(DataType.UNSIGNED_16_BIT_INTEGER));
    }

    public override void Deserialize(ZclFieldDeserializer deserializer)
    {
        Coordinate1 = deserializer.Deserialize<short>(ZclDataType.Get(DataType.SIGNED_16_BIT_INTEGER));
        Coordinate2 = deserializer.Deserialize<short>(ZclDataType.Get(DataType.SIGNED_16_BIT_INTEGER));
        Coordinate3 = deserializer.Deserialize<short>(ZclDataType.Get(DataType.SIGNED_16_BIT_INTEGER));
        Power = deserializer.Deserialize<short>(ZclDataType.Get(DataType.SIGNED_16_BIT_INTEGER));
        PathLossExponent = deserializer.Deserialize<ushort>(ZclDataType.Get(DataType.UNSIGNED_16_BIT_INTEGER));
    }

       public override string ToString()
       {
           var builder = new StringBuilder();

           builder.Append("SetAbsoluteLocationCommand [");
           builder.Append(base.ToString());
           builder.Append(", Coordinate1=");
           builder.Append(Coordinate1);
           builder.Append(", Coordinate2=");
           builder.Append(Coordinate2);
           builder.Append(", Coordinate3=");
           builder.Append(Coordinate3);
           builder.Append(", Power=");
           builder.Append(Power);
           builder.Append(", PathLossExponent=");
           builder.Append(PathLossExponent);
           builder.Append(']');

           return builder.ToString();
       }

   }
}
