// This file may be edited manually or auto-generated using IfcKit at www.buildingsmart-tech.org.
// IFC content is copyright (C) 1996-2018 BuildingSMART International Ltd.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

using BuildingSmart.IFC.IfcMeasureResource;

namespace BuildingSmart.IFC.IfcQuantityResource
{
	public partial class IfcQuantityLength : IfcPhysicalSimpleQuantity
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Length measure value of this quantity.")]
		[Required()]
		public IfcLengthMeasure LengthValue { get; set; }
	
	
		public IfcQuantityLength(IfcLabel __Name, IfcText? __Description, IfcNamedUnit __Unit, IfcLengthMeasure __LengthValue)
			: base(__Name, __Description, __Unit)
		{
			this.LengthValue = __LengthValue;
		}
	
	
	}
	
}