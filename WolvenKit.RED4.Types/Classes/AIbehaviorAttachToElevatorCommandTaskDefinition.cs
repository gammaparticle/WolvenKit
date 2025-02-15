using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorAttachToElevatorCommandTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] 
		[RED("command")] 
		public CHandle<AIArgumentMapping> Command
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}
	}
}
