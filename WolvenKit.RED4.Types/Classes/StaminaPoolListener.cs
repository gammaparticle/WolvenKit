using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StaminaPoolListener : gameScriptStatPoolsListener
	{
		[Ordinal(0)] 
		[RED("staminaBar")] 
		public CWeakHandle<StaminabarWidgetGameController> StaminaBar
		{
			get => GetPropertyValue<CWeakHandle<StaminabarWidgetGameController>>();
			set => SetPropertyValue<CWeakHandle<StaminabarWidgetGameController>>(value);
		}
	}
}
