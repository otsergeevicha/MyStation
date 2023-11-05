using Plugins.MonoCache;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraOperator : MonoCache
{
    [HideInInspector] [SerializeField] private Camera _camera;

    private void OnValidate() => 
        _camera = Get<Camera>();

    public Camera GetCamera =>
        _camera;
}