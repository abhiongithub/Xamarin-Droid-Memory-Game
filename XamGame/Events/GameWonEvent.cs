﻿using System;
namespace XamGame.Events
{
	public class GameWonEvent : AbstractEvent
	{
		public override void Fire(IEventObserver eventObserver)
		{
			eventObserver.onEvent(this);
		}
	}
}