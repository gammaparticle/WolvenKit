using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class rendHairProfileGradientEntry : ISerializable
	{
		[Ordinal(0)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("color")] 
		public CColor Color
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		public rendHairProfileGradientEntry()
		{
			Color = new();
		}
	}
}
