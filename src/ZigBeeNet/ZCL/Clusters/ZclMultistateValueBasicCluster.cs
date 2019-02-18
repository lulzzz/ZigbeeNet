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
 *Multistate Value (Basic)cluster implementation (Cluster ID 0x0014).
 *
 * The Multistate Value (Basic) cluster provides an interface for setting a multistate * value, typically used as a control system parameter, and accessing characteristics of that value. *
 * Code is auto-generated. Modifications may be overwritten!
 */
/* Autogenerated: 18.02.2019 - 16:04 */
namespace ZigBeeNet.ZCL.Clusters
{
   public class ZclMultistateValueBasicCluster : ZclCluster
   {
       /**
       * The ZigBee Cluster Library Cluster ID
       */
       public static ushort CLUSTER_ID = 0x0014;

       /**
       * The ZigBee Cluster Library Cluster Name
       */
       public static string CLUSTER_NAME = "Multistate Value (Basic)";

       /* Attribute constants */
       /**
        * This  attribute, of type Array of Character strings, holds descriptions of all possible        * states of a multistate PresentValue.  The number of descriptions matches the number of states        * defined in the NumberOfStates property. The PresentValue, interpreted as an integer, serves as        * an index into the array. If the size of this array is changed, the NumberOfStates property SHALL        * also be changed to the same value. The character set used SHALL be ASCII, and the attribute        * SHALL contain a maximum of 16 characters, which SHALL be printable but are otherwise unrestricted.       */
       public static ushort ATTR_STATETEXT = 0x000E;

       /**
        * The Description attribute, of type Character string, MAY be used to hold a description        * of the usage of the input, output or value, as appropriate to the cluster. The character        * set used SHALL be ASCII, and the attribute SHALL contain a maximum of 16 characters,        * which SHALL be printable but are otherwise unrestricted.       */
       public static ushort ATTR_DESCRIPTION = 0x001C;

       /**
        * This attribute, of type Unsigned 16-bit integer, defines the number of states that a multistate        * PresentValue MAY have. The NumberOfStates property SHALL always have a value greater than zero.        * If the value of this property is changed, the size of the StateText array, if present, SHALL also        * be changed to the same value. The states are numbered consecutively, starting with 1.       */
       public static ushort ATTR_NUMBEROFSTATES = 0x004A;

       /**
        * The OutOfService attribute, of type Boolean, indicates whether (TRUE) or not (FALSE) the physical        * input, output or value that the cluster represents is not in service. For an Input cluster, when        * OutOfService is TRUE the PresentValue attribute is decoupled from the physical input and  will        * not track changes to the  physical input. For an Output cluster, when OutOfService is TRUE the        * PresentValue attribute is decoupled from the physical output, so changes to PresentValue will not        * affect the physical output. For a Value cluster, when OutOfService is TRUE the PresentValue attribute        * MAY be written to freely by software local to the device that the cluster resides on.       */
       public static ushort ATTR_OUTOFSERVICE = 0x0051;

       /**
        * The PresentValue attribute indicates the current value of the input, output or        * value, as appropriate for the cluster. For Analog clusters it is of type single precision, for Binary        * clusters it is of type  Boolean, and for multistate clusters it is of type Unsigned 16-bit integer. The        * PresentValue attribute of an input cluster SHALL be writable when OutOfService is TRUE. When the PriorityArray        * attribute is implemented, writing to PresentValue SHALL be equivalent to writing to element 16 of PriorityArray,        * i.e., with a priority of 16.       */
       public static ushort ATTR_PRESENTVALUE = 0x0055;

       /**
        * The Reliability attribute, of type 8-bit enumeration, provides an indication of whether        * the PresentValueor the operation of the physical input, output or value in question (as        * appropriate for the cluster) is “reliable” as far as can be determined and, if not, why        * not. The Reliability attribute MAY have any of the following values:        * <p>        * NO-FAULT-DETECTED (0)        * OVER-RANGE (2)        * UNDER-RANGE (3)        * OPEN-LOOP (4)        * SHORTED-LOOP (5)        * UNRELIABLE-OTHER (7)        * PROCESS-ERROR (8)        * MULTI-STATE-FAULT (9)        * CONFIGURATION-ERROR (10)       */
       public static ushort ATTR_RELIABILITY = 0x0067;

       /**
        * The RelinquishDefault attribute is the default value to be used for the PresentValue        * attribute when all elements of the PriorityArray attribute are marked as invalid.       */
       public static ushort ATTR_RELINQUISHDEFAULT = 0x0068;

       /**
        * This attribute, of type bitmap, represents four Boolean flags that indicate the general “health”        * of the analog sensor. Three of the flags are associated with the values of other optional attributes        * of this cluster. A more detailed status could be determined by reading the optional attributes (if        * supported) that are linked to these flags. The relationship between individual flags is not defined.        * <p>        * The four flags are Bit 0 = IN_ALARM, Bit 1 = FAULT, Bit 2 = OVERRIDDEN, Bit 3 = OUT OF SERVICE        * <p>        * where:        * <p>        * IN_ALARM -Logical FALSE (0) if the EventStateattribute has a value of NORMAL, otherwise logical TRUE (1).        * This bit is always 0 unless the cluster implementing the EventState attribute is implemented on the same        * endpoint.        * <p>        * FAULT -Logical TRUE (1) if the Reliability attribute is present and does not have a value of NO FAULT DETECTED,        * otherwise logical FALSE (0).        * <p>        * OVERRIDDEN -Logical TRUE (1) if the cluster has been overridden by some  mechanism local to the device.        * Otherwise, the value is logical FALSE (0). In this context, for an input cluster, “overridden” is taken        * to mean that the PresentValue and Reliability(optional) attributes are no longer tracking changes to the        * physical input. For an Output cluster, “overridden” is taken to mean that the physical output is no longer        * tracking changes to the PresentValue attribute and the Reliability attribute is no longer a reflection of        * the physical output. For a Value cluster, “overridden” is taken to mean that the PresentValue attribute is        * not writeable.        * <p>        * OUT OF SERVICE -Logical TRUE (1) if the OutOfService attribute has a value of TRUE, otherwise        * logical FALSE (0).       */
       public static ushort ATTR_STATUSFLAGS = 0x006F;

       /**
        * The ApplicationType attribute is an unsigned 32 bit integer that indicates the specific        * application usage for this cluster. (Note: This attribute has no BACnet equivalent).        * ApplicationType is subdivided into Group, Type and an Index number, as follows.        * <p>        * Group = Bits 24 -31 An indication of the cluster this attribute is part of.        * <p>        * Type = Bits 16 -23 For Analog clusters, the physical quantity that the Present Value attribute        * of the cluster represents. For Binary and Multistate clusters, the application usage domain.        * <p>        * Index = Bits 0 -15The specific application usage of the cluster.       */
       public static ushort ATTR_APPLICATIONTYPE = 0x0100;


       // Attribute initialisation
       protected override Dictionary<ushort, ZclAttribute> InitializeAttributes()
       {
           Dictionary<ushort, ZclAttribute> attributeMap = new Dictionary<ushort, ZclAttribute>(9);

           ZclClusterType multistateValueBasic = ZclClusterType.GetValueById(ClusterType.MULTISTATE_VALUE__BASIC);

           attributeMap.Add(ATTR_STATETEXT, new ZclAttribute(multistateValueBasic, ATTR_STATETEXT, "StateText", ZclDataType.Get(DataType.CHARACTER_STRING), false, true, true, false));
           attributeMap.Add(ATTR_DESCRIPTION, new ZclAttribute(multistateValueBasic, ATTR_DESCRIPTION, "Description", ZclDataType.Get(DataType.CHARACTER_STRING), false, true, true, false));
           attributeMap.Add(ATTR_NUMBEROFSTATES, new ZclAttribute(multistateValueBasic, ATTR_NUMBEROFSTATES, "NumberOfStates", ZclDataType.Get(DataType.UNSIGNED_16_BIT_INTEGER), true, true, true, false));
           attributeMap.Add(ATTR_OUTOFSERVICE, new ZclAttribute(multistateValueBasic, ATTR_OUTOFSERVICE, "OutOfService", ZclDataType.Get(DataType.BOOLEAN), true, true, true, false));
           attributeMap.Add(ATTR_PRESENTVALUE, new ZclAttribute(multistateValueBasic, ATTR_PRESENTVALUE, "PresentValue", ZclDataType.Get(DataType.UNSIGNED_16_BIT_INTEGER), true, true, true, false));
           attributeMap.Add(ATTR_RELIABILITY, new ZclAttribute(multistateValueBasic, ATTR_RELIABILITY, "Reliability", ZclDataType.Get(DataType.ENUMERATION_8_BIT), false, true, true, false));
           attributeMap.Add(ATTR_RELINQUISHDEFAULT, new ZclAttribute(multistateValueBasic, ATTR_RELINQUISHDEFAULT, "RelinquishDefault", ZclDataType.Get(DataType.UNSIGNED_16_BIT_INTEGER), false, true, true, false));
           attributeMap.Add(ATTR_STATUSFLAGS, new ZclAttribute(multistateValueBasic, ATTR_STATUSFLAGS, "StatusFlags", ZclDataType.Get(DataType.BITMAP_8_BIT), true, true, false, false));
           attributeMap.Add(ATTR_APPLICATIONTYPE, new ZclAttribute(multistateValueBasic, ATTR_APPLICATIONTYPE, "ApplicationType", ZclDataType.Get(DataType.SIGNED_32_BIT_INTEGER), false, true, false, false));

        return attributeMap;
       }

       /**
       * Default constructor to create a Multistate Value (Basic) cluster.
       *
       * @param zigbeeEndpoint the {@link ZigBeeEndpoint}
       */
       public ZclMultistateValueBasicCluster(ZigBeeEndpoint zigbeeEndpoint)
           : base(zigbeeEndpoint, CLUSTER_ID, CLUSTER_NAME)
       {
       }

       public Task<CommandResult> SetStateText(object value)
       {
           return Write(_attributes[ATTR_STATETEXT], value);
       }

       public Task<CommandResult> GetStateTextAsync()
       {
           return Read(_attributes[ATTR_STATETEXT]);
       }
       public string GetStateText(long refreshPeriod)
       {
           if (_attributes[ATTR_STATETEXT].IsLastValueCurrent(refreshPeriod))
           {
               return (string)_attributes[ATTR_STATETEXT].LastValue;
           }

           return (string)ReadSync(_attributes[ATTR_STATETEXT]);
       }

       public Task<CommandResult> SetDescription(object value)
       {
           return Write(_attributes[ATTR_DESCRIPTION], value);
       }

       public Task<CommandResult> GetDescriptionAsync()
       {
           return Read(_attributes[ATTR_DESCRIPTION]);
       }
       public string GetDescription(long refreshPeriod)
       {
           if (_attributes[ATTR_DESCRIPTION].IsLastValueCurrent(refreshPeriod))
           {
               return (string)_attributes[ATTR_DESCRIPTION].LastValue;
           }

           return (string)ReadSync(_attributes[ATTR_DESCRIPTION]);
       }

       public Task<CommandResult> SetNumberOfStates(object value)
       {
           return Write(_attributes[ATTR_NUMBEROFSTATES], value);
       }

       public Task<CommandResult> GetNumberOfStatesAsync()
       {
           return Read(_attributes[ATTR_NUMBEROFSTATES]);
       }
       public ushort GetNumberOfStates(long refreshPeriod)
       {
           if (_attributes[ATTR_NUMBEROFSTATES].IsLastValueCurrent(refreshPeriod))
           {
               return (ushort)_attributes[ATTR_NUMBEROFSTATES].LastValue;
           }

           return (ushort)ReadSync(_attributes[ATTR_NUMBEROFSTATES]);
       }

       public Task<CommandResult> SetOutOfService(object value)
       {
           return Write(_attributes[ATTR_OUTOFSERVICE], value);
       }

       public Task<CommandResult> GetOutOfServiceAsync()
       {
           return Read(_attributes[ATTR_OUTOFSERVICE]);
       }
       public bool GetOutOfService(long refreshPeriod)
       {
           if (_attributes[ATTR_OUTOFSERVICE].IsLastValueCurrent(refreshPeriod))
           {
               return (bool)_attributes[ATTR_OUTOFSERVICE].LastValue;
           }

           return (bool)ReadSync(_attributes[ATTR_OUTOFSERVICE]);
       }

       public Task<CommandResult> SetPresentValue(object value)
       {
           return Write(_attributes[ATTR_PRESENTVALUE], value);
       }

       public Task<CommandResult> GetPresentValueAsync()
       {
           return Read(_attributes[ATTR_PRESENTVALUE]);
       }
       public ushort GetPresentValue(long refreshPeriod)
       {
           if (_attributes[ATTR_PRESENTVALUE].IsLastValueCurrent(refreshPeriod))
           {
               return (ushort)_attributes[ATTR_PRESENTVALUE].LastValue;
           }

           return (ushort)ReadSync(_attributes[ATTR_PRESENTVALUE]);
       }

       public Task<CommandResult> SetReliability(object value)
       {
           return Write(_attributes[ATTR_RELIABILITY], value);
       }

       public Task<CommandResult> GetReliabilityAsync()
       {
           return Read(_attributes[ATTR_RELIABILITY]);
       }
       public byte GetReliability(long refreshPeriod)
       {
           if (_attributes[ATTR_RELIABILITY].IsLastValueCurrent(refreshPeriod))
           {
               return (byte)_attributes[ATTR_RELIABILITY].LastValue;
           }

           return (byte)ReadSync(_attributes[ATTR_RELIABILITY]);
       }

       public Task<CommandResult> SetRelinquishDefault(object value)
       {
           return Write(_attributes[ATTR_RELINQUISHDEFAULT], value);
       }

       public Task<CommandResult> GetRelinquishDefaultAsync()
       {
           return Read(_attributes[ATTR_RELINQUISHDEFAULT]);
       }
       public ushort GetRelinquishDefault(long refreshPeriod)
       {
           if (_attributes[ATTR_RELINQUISHDEFAULT].IsLastValueCurrent(refreshPeriod))
           {
               return (ushort)_attributes[ATTR_RELINQUISHDEFAULT].LastValue;
           }

           return (ushort)ReadSync(_attributes[ATTR_RELINQUISHDEFAULT]);
       }

       public Task<CommandResult> GetStatusFlagsAsync()
       {
           return Read(_attributes[ATTR_STATUSFLAGS]);
       }
       public byte GetStatusFlags(long refreshPeriod)
       {
           if (_attributes[ATTR_STATUSFLAGS].IsLastValueCurrent(refreshPeriod))
           {
               return (byte)_attributes[ATTR_STATUSFLAGS].LastValue;
           }

           return (byte)ReadSync(_attributes[ATTR_STATUSFLAGS]);
       }

       public Task<CommandResult> GetApplicationTypeAsync()
       {
           return Read(_attributes[ATTR_APPLICATIONTYPE]);
       }
       public int GetApplicationType(long refreshPeriod)
       {
           if (_attributes[ATTR_APPLICATIONTYPE].IsLastValueCurrent(refreshPeriod))
           {
               return (int)_attributes[ATTR_APPLICATIONTYPE].LastValue;
           }

           return (int)ReadSync(_attributes[ATTR_APPLICATIONTYPE]);
       }

   }
}
