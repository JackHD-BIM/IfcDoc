// This file was automatically generated from IFCDOC at www.buildingsmart-tech.org.
// IFC content is copyright (C) 1996-2018 BuildingSMART International Ltd.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

using BuildingSmart.IFC.IfcGeometricConstraintResource;
using BuildingSmart.IFC.IfcGeometryResource;
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcProductExtension;
using BuildingSmart.IFC.IfcRepresentationResource;
using BuildingSmart.IFC.IfcStructuralLoadResource;

namespace BuildingSmart.IFC.IfcStructuralAnalysisDomain
{
	[Guid("dc662673-0379-4276-8c8c-c30feb5e1d70")]
	public enum IfcStructuralCurveMemberTypeEnum
	{
		[Description("A member with capacity to carry transverse and axial loads, i.e. a beam. Its actu" +
	    "al joints may be rigid or pinned. Typically used in rigid frames.")]
		RIGID_JOINED_MEMBER = 1,
	
		[Description("A member with capacity to carry axial loads only, i.e. a link. Typically used in " +
	    "trusses.")]
		PIN_JOINED_MEMBER = 2,
	
		[Description("A tension member which is able to carry transverse loads only under large deflect" +
	    "ion.")]
		CABLE = 3,
	
		[Description("A member without compressional stiffness.")]
		TENSION_MEMBER = 4,
	
		[Description("A member without tensional stiffness.")]
		COMPRESSION_MEMBER = 5,
	
		[Description("A specially defined member.")]
		USERDEFINED = -1,
	
		[Description("A member without further categorization.")]
		NOTDEFINED = 0,
	
	}
}