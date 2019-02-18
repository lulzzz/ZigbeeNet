﻿// License text here
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZigBeeNet.ZCL.Protocol;
using ZigBeeNet.ZCL.Field;
using ZigBeeNet.ZCL.Clusters.Scenes;

/**
 * Get Scene Membership Response value object class.
 *
 * Cluster: Scenes. Command is sentFROM the server.
 * This command is a specific command used for the Scenes cluster.
 *
 * Code is auto-generated. Modifications may be overwritten!
 */

/* Autogenerated: 18.02.2019 - 16:04 */
namespace ZigBeeNet.ZCL.Clusters.Scenes
{
   public class GetSceneMembershipResponse : ZclCommand
   {
       /**
           * Status command message field.
           */
           public byte Status { get; set; }

       /**
           * Capacity command message field.
           */
           public byte Capacity { get; set; }

       /**
           * Group ID command message field.
           */
           public ushort GroupID { get; set; }

       /**
           * Scene count command message field.
           */
           public byte SceneCount { get; set; }

       /**
           * Scene list command message field.
           */
           public List<byte> SceneList { get; set; }


           /**
           * Default constructor.
           */
           public GetSceneMembershipResponse()
           {
               GenericCommand = false;
               ClusterId = 5;
               CommandId = 5;
               CommandDirection = ZclCommandDirection.SERVER_TO_CLIENT;
           }

    public override void Serialize(ZclFieldSerializer serializer)
    {
        serializer.Serialize(Status, ZclDataType.Get(DataType.ENUMERATION_8_BIT));
        serializer.Serialize(Capacity, ZclDataType.Get(DataType.UNSIGNED_8_BIT_INTEGER));
        serializer.Serialize(GroupID, ZclDataType.Get(DataType.UNSIGNED_16_BIT_INTEGER));
        serializer.Serialize(SceneCount, ZclDataType.Get(DataType.UNSIGNED_8_BIT_INTEGER));
        serializer.Serialize(SceneList, ZclDataType.Get(DataType.N_X_UNSIGNED_8_BIT_INTEGER));
    }

    public override void Deserialize(ZclFieldDeserializer deserializer)
    {
        Status = deserializer.Deserialize<byte>(ZclDataType.Get(DataType.ENUMERATION_8_BIT));
        Capacity = deserializer.Deserialize<byte>(ZclDataType.Get(DataType.UNSIGNED_8_BIT_INTEGER));
        GroupID = deserializer.Deserialize<ushort>(ZclDataType.Get(DataType.UNSIGNED_16_BIT_INTEGER));
        SceneCount = deserializer.Deserialize<byte>(ZclDataType.Get(DataType.UNSIGNED_8_BIT_INTEGER));
        SceneList = deserializer.Deserialize<List<byte>>(ZclDataType.Get(DataType.N_X_UNSIGNED_8_BIT_INTEGER));
    }

       public override string ToString()
       {
           var builder = new StringBuilder();

           builder.Append("GetSceneMembershipResponse [");
           builder.Append(base.ToString());
           builder.Append(", Status=");
           builder.Append(Status);
           builder.Append(", Capacity=");
           builder.Append(Capacity);
           builder.Append(", GroupID=");
           builder.Append(GroupID);
           builder.Append(", SceneCount=");
           builder.Append(SceneCount);
           builder.Append(", SceneList=");
           builder.Append(SceneList);
           builder.Append(']');

           return builder.ToString();
       }

   }
}
