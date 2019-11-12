﻿using System;

namespace RogueLike
{
	public class PickUpAction : Action
	{
		ItemInterface Item;
		Actor Actor;
		Level Level;

		public PickUpAction (Level aLevel,Actor aActor, ItemInterface aItem)
		{
			this.Level = aLevel;
			this.Actor = aActor;
			this.Item = aItem;
		}

		public override ActionResult Perform (){
			ActionResult lResult = new ActionResult(true);
			this.Actor.Inventory.Add (this.Item);
			this.Level.ItemGrid.SetItem (null, this.Item.GetPosition ());
			return lResult;
		}
	}
}
