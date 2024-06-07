using System.Collections.Generic;
using SLZ.Marrow.Utilities;
using SLZ.Marrow.Data;
using SLZ.Marrow.Warehouse;
using SLZ.Marrow.Pool;
using UnityEngine;

namespace SLZ.Marrow.Interaction
{
    [DisallowMultipleComponent]
    public partial class MarrowBody : MonoBehaviour, ITaggable
    {
        [field: SerializeField]
        public MarrowEntity Entity { get; private set; }

        [SerializeField]
        private TagList _tags;
        public TagList Tags => _tags;

        
		public static ComponentCache<MarrowBody> Cache
		{
			get
			{
				return null;
			}
		}

        [field: SerializeField]
		public bool HasRigidbody { get; private set; }

        [field: SerializeField]
		public bool isCenterOfMassOverride { get; private set; }
        
        [field: SerializeField]
		public Vector3 CenterOfMass { get; private set; }

		public Collider[] Colliders
		{
			get
			{
				return null;
			}
		}

		public Tracker[] Trackers
		{
			get
			{
				return null;
			}
		}

		public Collider[] Triggers
		{
			get
			{
				return null;
			}
		}

		public bool IsHibernating
		{
			get
			{
				return default(bool);
			}
			private set
			{
			}
		}

		public bool IsPacked
		{
			get
			{
				return default(bool);
			}
			private set
			{
			}
		}

		public MarrowBody Host
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

        [field: SerializeField]
		public SimpleTransform InitInEntityTransform { get; private set; }

		public Bounds Bounds
		{
			get
			{
				return default(Bounds);
			}
		}

		public IReadOnlyList<MarrowJoint> InJoints
		{
			get
			{
				return null;
			}
		}

		public IReadOnlyList<MarrowJoint> OutJoints
		{
			get
			{
				return null;
			}
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void DestroyRigidbody()
		{
		}

		private void CreateRigidbody()
		{
		}

		internal void SetFromDefaultConfig()
		{
		}

		public void SetToDefaultConfig()
		{
		}

		public bool TryGetRigidbody(out Rigidbody rigidbody)
		{
            rigidbody = default(Rigidbody);
			return default(bool);
		}

		internal void INTHibernate(bool isHibernating = true)
		{
		}

		internal void INTEnableTrackers(bool isEnabled)
		{
		}

		internal void INTEnableColliders(bool isEnabled)
		{
		}

		internal void INTEnableTriggers(bool isEnabled)
		{
		}

		internal void INTGhost(bool isGhosted)
		{
		}

		internal void INTPack(MarrowBody parasiteBody)
		{
		}

		internal void INTUnpack()
		{
		}

		internal void INTResetMass()
		{
		}

		private float CalculateMass()
		{
			return 0f;
		}

		public void Pack(MarrowBody parasite)
		{
		}

		public void Unpack()
		{
		}

		public void AddForce(Vector3 force, ForceMode mode = ForceMode.Force)
		{
		}

		public void AddTorque(Vector3 torque, ForceMode mode = ForceMode.Force)
		{
		}

		public void IgnoreCollision(MarrowBody bodyToIgnore, bool doIgnore = true)
		{
		}

		public void IgnoreCollision(Collider otherCollider, bool doIgnore = true)
		{
		}

		internal void CleanupIgnoredCollisions()
		{
		}

		internal void ConnectJoint(MarrowJoint joint)
		{
		}

		internal void DisconnectJoint(MarrowJoint joint)
		{
		}

		internal void Validate(Rigidbody rb, MarrowEntity entity)
		{
		}

		private void CopyRigidbodyInfo(Rigidbody rb)
		{
		}

		private void SetEntity(MarrowEntity marrowEntity)
		{
		}

		private void GatherColliders()
		{
		}

		private void CalculateBounds()
		{
		}

		private void GenerateTrackers()
		{
		}

		private List<Tracker> GetTrackers(Transform transform)
		{
			return null;
		}

		private static ComponentCache<MarrowBody> _cache;

		[SerializeField]
		private Rigidbody _rigidbody;

		[SerializeField]
		private RigidbodyInfo _defaultRigidbodyInfo;

		private readonly RigidbodyInfo _cachedRigidbodyInfo;

		[SerializeField]
		private Collider[] _colliders;

		private bool[] _colliderStates;

		[SerializeField]
		private Tracker[] _trackers;

		[SerializeField]
		private Collider[] _triggers;

		private bool[] _triggerStates;

		[SerializeField]
		private MarrowBody[] _bodiesToIgnore;

		[SerializeField]
		private Collider[] _collidersToIgnore;

		private HibernationBodyInfo _hibernationBodyInfo;

		private Transform _lastParent;

		internal readonly List<MarrowBody> INTParasites;

		[SerializeField]
		private Bounds _bounds;

		public TrackerSettingsGroup trackerSettings;

		private HashSet<MarrowJoint> _connectedJoints;

		private List<MarrowJoint> _inJoints;

		private List<MarrowJoint> _outJoints;

		private Dictionary<Collider, int> _ignoredColliders;

		private bool _hasTensorBeenApplied;
    }
}