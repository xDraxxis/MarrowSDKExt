using System;
using UnityEngine;

namespace SLZ.Marrow.Interaction
{
	[Serializable]
	public class TrackerSettingsGroup
	{
		[SerializeField]
		public TrackerLayers layers = TrackerLayers.Entity;

		[SerializeField]
		public TrackerSettings[] settings = {
			new TrackerSettings()
		};
	}
}
