using UnityEngine;
using UnityEngine.Serialization;

public class ShroudTile : MonoBehaviour
{
	[FormerlySerializedAs("renderer")] public Renderer shroudRenderer;

	private void OnEnable()
	{
		shroudRenderer.enabled = true;
	}

	public void SetShroudStatus(bool enabled)
	{
		shroudRenderer.enabled = enabled;
	}
}