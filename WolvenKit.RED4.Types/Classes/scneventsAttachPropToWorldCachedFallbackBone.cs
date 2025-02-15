using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scneventsAttachPropToWorldCachedFallbackBone : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("boneName")] 
		public CName BoneName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("modelSpaceTransform")] 
		public Transform ModelSpaceTransform
		{
			get => GetPropertyValue<Transform>();
			set => SetPropertyValue<Transform>(value);
		}

		public scneventsAttachPropToWorldCachedFallbackBone()
		{
			ModelSpaceTransform = new() { Position = new(), Orientation = new() { R = 1.000000F } };
		}
	}
}
