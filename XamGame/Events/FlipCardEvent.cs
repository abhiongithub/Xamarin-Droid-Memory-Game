﻿using System;
namespace XamGame.Events
{
	public class FlipCardEvent : AbstractEvent,IEvent
	{
		public int id;

		public FlipCardEvent(int id)
		{
			this.id = id;
		}

		public override void Fire(IEventObserver eventObserver)
		{
			eventObserver.onEvent(this);
		}

		public string GetEventType()
		{
			return nameof(FlipCardEvent);
		}
	}
}
