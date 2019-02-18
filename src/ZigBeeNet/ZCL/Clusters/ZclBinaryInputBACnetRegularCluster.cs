﻿// License text here

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ZigBeeNet.DAO;
using ZigBeeNet.ZCL.Protocol;
using ZigBeeNet.ZCL.Field;

/**
 *Binary Input (BACnet Regular)cluster implementation (Cluster ID 0x0608).
 *
 * Code is auto-generated. Modifications may be overwritten!
 */
/* Autogenerated: 18.02.2019 - 16:04 */
namespace ZigBeeNet.ZCL.Clusters
{
   public class ZclBinaryInputBACnetRegularCluster : ZclCluster
   {
       /**
       * The ZigBee Cluster Library Cluster ID
       */
       public static ushort CLUSTER_ID = 0x0608;

       /**
       * The ZigBee Cluster Library Cluster Name
       */
       public static string CLUSTER_NAME = "Binary Input (BACnet Regular)";

       // Attribute initialisation
       protected override Dictionary<ushort, ZclAttribute> InitializeAttributes()
       {
           Dictionary<ushort, ZclAttribute> attributeMap = new Dictionary<ushort, ZclAttribute>(0);

        return attributeMap;
       }

       /**
       * Default constructor to create a Binary Input (BACnet Regular) cluster.
       *
       * @param zigbeeEndpoint the {@link ZigBeeEndpoint}
       */
       public ZclBinaryInputBACnetRegularCluster(ZigBeeEndpoint zigbeeEndpoint)
           : base(zigbeeEndpoint, CLUSTER_ID, CLUSTER_NAME)
       {
       }

   }
}
