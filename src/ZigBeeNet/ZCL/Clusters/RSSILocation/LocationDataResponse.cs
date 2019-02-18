﻿// License text here
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZigBeeNet.ZCL.Protocol;
using ZigBeeNet.ZCL.Field;
using ZigBeeNet.ZCL.Clusters.RSSILocation;

/**
 * Location Data Response value object class.
 *
 * Cluster: RSSI Location. Command is sentFROM the server.
 * This command is a specific command used for the RSSI Location cluster.
 *
 * Code is auto-generated. Modifications may be overwritten!
 */

/* Autogenerated: 18.02.2019 - 16:10 */
namespace ZigBeeNet.ZCL.Clusters.RSSILocation
{
   public class LocationDataResponse : ZclCommand
   {
       /**
           * Status command message field.
           */
           public byte Status { get; set; }

       /**
           * Location Type command message field.
           */
           public byte LocationType { get; set; }

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
           * Location Method command message field.
           */
           public byte LocationMethod { get; set; }

       /**
           * Quality Measure command message field.
           */
           public byte QualityMeasure { get; set; }

       /**
           * Location Age command message field.
           */
           public ushort LocationAge { get; set; }


           /**
           * Default constructor.
           */
           public LocationDataResponse()
           {
               GenericCommand = false;
               ClusterId = 11;
               CommandId = 1;
               CommandDirection = ZclCommandDirection.SERVER_TO_CLIENT;
           }

    public override void Serialize(ZclFieldSerializer serializer)
    {
        serializer.Serialize(Status, ZclDataType.Get(DataType.ENUMERATION_8_BIT));
        serializer.Serialize(LocationType, ZclDataType.Get(DataType.DATA_8_BIT));
        serializer.Serialize(Coordinate1, ZclDataType.Get(DataType.SIGNED_16_BIT_INTEGER));
        serializer.Serialize(Coordinate2, ZclDataType.Get(DataType.SIGNED_16_BIT_INTEGER));
        serializer.Serialize(Coordinate3, ZclDataType.Get(DataType.SIGNED_16_BIT_INTEGER));
        serializer.Serialize(Power, ZclDataType.Get(DataType.SIGNED_16_BIT_INTEGER));
        serializer.Serialize(PathLossExponent, ZclDataType.Get(DataType.UNSIGNED_16_BIT_INTEGER));
        serializer.Serialize(LocationMethod, ZclDataType.Get(DataType.ENUMERATION_8_BIT));
        serializer.Serialize(QualityMeasure, ZclDataType.Get(DataType.UNSIGNED_8_BIT_INTEGER));
        serializer.Serialize(LocationAge, ZclDataType.Get(DataType.UNSIGNED_16_BIT_INTEGER));
    }

    public override void Deserialize(ZclFieldDeserializer deserializer)
    {
        Status = deserializer.Deserialize<byte>(ZclDataType.Get(DataType.ENUMERATION_8_BIT));
        LocationType = deserializer.Deserialize<byte>(ZclDataType.Get(DataType.DATA_8_BIT));
        Coordinate1 = deserializer.Deserialize<short>(ZclDataType.Get(DataType.SIGNED_16_BIT_INTEGER));
        Coordinate2 = deserializer.Deserialize<short>(ZclDataType.Get(DataType.SIGNED_16_BIT_INTEGER));
        Coordinate3 = deserializer.Deserialize<short>(ZclDataType.Get(DataType.SIGNED_16_BIT_INTEGER));
        Power = deserializer.Deserialize<short>(ZclDataType.Get(DataType.SIGNED_16_BIT_INTEGER));
        PathLossExponent = deserializer.Deserialize<ushort>(ZclDataType.Get(DataType.UNSIGNED_16_BIT_INTEGER));
        LocationMethod = deserializer.Deserialize<byte>(ZclDataType.Get(DataType.ENUMERATION_8_BIT));
        QualityMeasure = deserializer.Deserialize<byte>(ZclDataType.Get(DataType.UNSIGNED_8_BIT_INTEGER));
        LocationAge = deserializer.Deserialize<ushort>(ZclDataType.Get(DataType.UNSIGNED_16_BIT_INTEGER));
    }

       public override string ToString()
       {
           var builder = new StringBuilder();

           builder.Append("LocationDataResponse [");
           builder.Append(base.ToString());
           builder.Append(", Status=");
           builder.Append(Status);
           builder.Append(", LocationType=");
           builder.Append(LocationType);
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
           builder.Append(", LocationMethod=");
           builder.Append(LocationMethod);
           builder.Append(", QualityMeasure=");
           builder.Append(QualityMeasure);
           builder.Append(", LocationAge=");
           builder.Append(LocationAge);
           builder.Append(']');

           return builder.ToString();
       }

   }
}
