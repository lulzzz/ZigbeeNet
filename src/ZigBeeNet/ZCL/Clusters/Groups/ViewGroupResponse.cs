﻿// License text here
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZigBeeNet.ZCL.Protocol;
using ZigBeeNet.ZCL.Field;
using ZigBeeNet.ZCL.Clusters.Groups;

/**
 * View Group Response value object class.
 *
 * Cluster: Groups. Command is sentFROM the server.
 * This command is a specific command used for the Groups cluster.
 *
 * Code is auto-generated. Modifications may be overwritten!
 */

/* Autogenerated: 18.02.2019 - 16:10 */
namespace ZigBeeNet.ZCL.Clusters.Groups
{
   public class ViewGroupResponse : ZclCommand
   {
       /**
           * Status command message field.
           */
           public byte Status { get; set; }

       /**
           * Group ID command message field.
           */
           public ushort GroupID { get; set; }

       /**
           * Group Name command message field.
           */
           public string GroupName { get; set; }


           /**
           * Default constructor.
           */
           public ViewGroupResponse()
           {
               GenericCommand = false;
               ClusterId = 4;
               CommandId = 1;
               CommandDirection = ZclCommandDirection.SERVER_TO_CLIENT;
           }

    public override void Serialize(ZclFieldSerializer serializer)
    {
        serializer.Serialize(Status, ZclDataType.Get(DataType.ENUMERATION_8_BIT));
        serializer.Serialize(GroupID, ZclDataType.Get(DataType.UNSIGNED_16_BIT_INTEGER));
        serializer.Serialize(GroupName, ZclDataType.Get(DataType.CHARACTER_STRING));
    }

    public override void Deserialize(ZclFieldDeserializer deserializer)
    {
        Status = deserializer.Deserialize<byte>(ZclDataType.Get(DataType.ENUMERATION_8_BIT));
        GroupID = deserializer.Deserialize<ushort>(ZclDataType.Get(DataType.UNSIGNED_16_BIT_INTEGER));
        GroupName = deserializer.Deserialize<string>(ZclDataType.Get(DataType.CHARACTER_STRING));
    }

       public override string ToString()
       {
           var builder = new StringBuilder();

           builder.Append("ViewGroupResponse [");
           builder.Append(base.ToString());
           builder.Append(", Status=");
           builder.Append(Status);
           builder.Append(", GroupID=");
           builder.Append(GroupID);
           builder.Append(", GroupName=");
           builder.Append(GroupName);
           builder.Append(']');

           return builder.ToString();
       }

   }
}
