﻿// License text here
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZigBeeNet.ZCL.Protocol;
using ZigBeeNet.ZCL.Field;
using ZigBeeNet.ZCL.Clusters.RSSILocation;

/**
 * Send Pings Command value object class.
 *
 * Cluster: RSSI Location. Command is sentTO the server.
 * This command is a specific command used for the RSSI Location cluster.
 *
 * Code is auto-generated. Modifications may be overwritten!
 */

/* Autogenerated: 18.02.2019 - 16:10 */
namespace ZigBeeNet.ZCL.Clusters.RSSILocation
{
   public class SendPingsCommand : ZclCommand
   {
       /**
           * Target Address command message field.
           */
           public IeeeAddress TargetAddress { get; set; }

       /**
           * Number RSSI Measurements command message field.
           */
           public byte NumberRSSIMeasurements { get; set; }

       /**
           * Calculation Period command message field.
           */
           public ushort CalculationPeriod { get; set; }


           /**
           * Default constructor.
           */
           public SendPingsCommand()
           {
               GenericCommand = false;
               ClusterId = 11;
               CommandId = 5;
               CommandDirection = ZclCommandDirection.CLIENT_TO_SERVER;
           }

    public override void Serialize(ZclFieldSerializer serializer)
    {
        serializer.Serialize(TargetAddress, ZclDataType.Get(DataType.IEEE_ADDRESS));
        serializer.Serialize(NumberRSSIMeasurements, ZclDataType.Get(DataType.UNSIGNED_8_BIT_INTEGER));
        serializer.Serialize(CalculationPeriod, ZclDataType.Get(DataType.UNSIGNED_16_BIT_INTEGER));
    }

    public override void Deserialize(ZclFieldDeserializer deserializer)
    {
        TargetAddress = deserializer.Deserialize<IeeeAddress>(ZclDataType.Get(DataType.IEEE_ADDRESS));
        NumberRSSIMeasurements = deserializer.Deserialize<byte>(ZclDataType.Get(DataType.UNSIGNED_8_BIT_INTEGER));
        CalculationPeriod = deserializer.Deserialize<ushort>(ZclDataType.Get(DataType.UNSIGNED_16_BIT_INTEGER));
    }

       public override string ToString()
       {
           var builder = new StringBuilder();

           builder.Append("SendPingsCommand [");
           builder.Append(base.ToString());
           builder.Append(", TargetAddress=");
           builder.Append(TargetAddress);
           builder.Append(", NumberRSSIMeasurements=");
           builder.Append(NumberRSSIMeasurements);
           builder.Append(", CalculationPeriod=");
           builder.Append(CalculationPeriod);
           builder.Append(']');

           return builder.ToString();
       }

   }
}
