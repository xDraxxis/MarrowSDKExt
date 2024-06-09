using System;
using System.ComponentModel;
using UnityEngine;

namespace SLZ.Marrow.Interaction
{
	[Serializable]
	public class TrackerSettings
	{
		[Serializable]
		public enum Type
		{
			Bounds = 0,
			Box = 1,
			Sphere = 2,
			Capsule = 3
		}

		[Serializable]
		public enum Direction
		{
			[Description("X-Axis")]
			XAxis = 0,
			[Description("Y-Axis")]
			YAxis = 1,
			[Description("Z-Axis")]
			ZAxis = 2
		}

		[SerializeField]
		public bool isActive = true;

		[SerializeField]
		public int layer = 1;

		[SerializeField]
		public Type type = Type.Bounds;

		[SerializeField]
		public Vector3 center = new Vector3(0, 0, 0);

		[SerializeField]
		public Vector3 size = new Vector3(0.5f,0.5f,0.5f);

		[SerializeField]
		public float radius = 0.5f;

		[SerializeField]
		public float height = 2.0f;

		[SerializeField]
		public Direction direction = Direction.XAxis;
	}
}
