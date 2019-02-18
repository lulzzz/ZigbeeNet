﻿// License text here

using System;
using System.Collections.Generic;
using System.Text;

/**
 * Enumeration of IASACE attribute Bypass Result options.
 *
 * Code is auto-generated. Modifications may be overwritten!
 *
 */

/* Autogenerated: 18.02.2019 - 16:04 */
namespace ZigBeeNet.ZCL.Clusters.IASACE
{
   public enum BypassResult
   {
       ZONE_BYPASSED = 0x0000,
       ZONE_NOT_BYPASSED = 0x0001,
       NOT_ALLOWED = 0x0002,
       INVALID_ZONE_ID = 0x0003,
       UNKNOWN_ZONE_ID = 0x0004,
       INVALID_ARM_CODE = 0x0005
   }
}
