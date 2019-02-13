
using UnityEngine;

using System.Collections;

[RequireComponent(typeof(Collider))]
public class TransportPlayer : MonoBehaviour
{
    private Vector3 startingPosition;

    public Material inactiveMaterial;
    public Material gazedAtMaterial;

    void Start()
    {
        startingPosition = transform.localPosition;
        SetGazedAt(false);
    }

    public void SetGazedAt(bool gazedAt)
    {
        if (inactiveMaterial != null && gazedAtMaterial != null)
        {
            GetComponent<Renderer>().material = gazedAt ? gazedAtMaterial : inactiveMaterial;
            return;
        }
        GetComponent<Renderer>().material.color = gazedAt ? Color.green : Color.red;
    }

    public void Reset()
    {
        transform.localPosition = startingPosition;
    }

    public void Recenter()
    {
#if !UNITY_EDITOR
        GvrCardboardHelpers.Recenter();
#else
    GvrEditorEmulator emulator = FindObjectOfType<GvrEditorEmulator>();
    if (emulator == null) {
      return;
    }
    emulator.Recenter();
#endif  // !UNITY_EDITOR
    }

    public void TeleportRandomly()
    {
        GlobalVariables.activate = true;
    }
}
