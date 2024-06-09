using SLZ.Marrow.Utilities;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace SLZ.Marrow.Interaction
{
	public class ArtCull : MarrowBehaviour
	{
		[SerializeField]
		private LODGroup[] _lodGroups;

		[SerializeField]
		private Renderer[] _renderers;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void CollectRenderers()
		{
			_lodGroups = gameObject.GetComponentsInChildren<LODGroup>(true);
			_renderers = gameObject.GetComponentsInChildren<Renderer>(true);
#if UNITY_EDITOR
			EditorUtility.SetDirty(this);
#endif
		}
	}

#if UNITY_EDITOR
	[CustomEditor(typeof(ArtCull))]
	[DisallowMultipleComponent]
	public class ArtCullEditor : Editor 
	{
	    public override void OnInspectorGUI()
	    {
			ArtCull behaviour = (ArtCull)target;

    	    if(GUILayout.Button("Collect Renderers"))
        	{
				behaviour.CollectRenderers();
        	}
	
        	DrawDefaultInspector();
	    }
	}
#endif

}
