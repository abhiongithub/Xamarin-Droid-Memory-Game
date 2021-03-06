﻿using System;
namespace XamGame.Events
{
	public class ResetBackgroundEvent : AbstractEvent,IEvent
	{
		public override void Fire(IEventObserver eventObserver)
		{
			eventObserver.onEvent(this);
		}

		public string GetEventType()
		{
			return nameof(ResetBackgroundEvent);
		}
	}
}
