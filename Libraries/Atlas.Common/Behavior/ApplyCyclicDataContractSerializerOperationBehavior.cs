﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel.Description;
using System.Xml;


namespace Atlas.Common.Behaviors
{
	internal class ApplyCyclicDataContractSerializerOperationBehavior : DataContractSerializerOperationBehavior
	{
		private readonly Int32 _maxItemsInObjectGraph;
		private readonly bool _ignoreExtensionDataObject;
		private readonly bool _preserveObjectReferences;

		public ApplyCyclicDataContractSerializerOperationBehavior(OperationDescription operationDescription, Int32 maxItemsInObjectGraph, bool ignoreExtensionDataObject, bool preserveObjectReferences)
			: base(operationDescription)
		{
			_maxItemsInObjectGraph = maxItemsInObjectGraph;
			_ignoreExtensionDataObject = ignoreExtensionDataObject;
			_preserveObjectReferences = preserveObjectReferences;
		}


		public override XmlObjectSerializer CreateSerializer(Type type, String name, String ns, IList<Type> knownTypes)
		{
			return (new DataContractSerializer(type, name, ns, knownTypes, _maxItemsInObjectGraph, _ignoreExtensionDataObject, _preserveObjectReferences, null /*dataContractSurrogate*/));
		}


		public override XmlObjectSerializer CreateSerializer(Type type, XmlDictionaryString name, XmlDictionaryString ns, IList<Type> knownTypes)
		{
			return (new DataContractSerializer(type, name, ns, knownTypes, _maxItemsInObjectGraph, _ignoreExtensionDataObject, _preserveObjectReferences, null /*dataContractSurrogate*/));
		}
	}
}