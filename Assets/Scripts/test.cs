using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.Gaming;
 
[RequireComponent(typeof(GazeAware))]
public class VisibleOnGaze : MonoBehaviour
{
    private GazeAware _gazeAware;
    [SerializeField] GameObject obj;
 
    void Start()
    {
        _gazeAware = GetComponent<GazeAware>();
    }
 
    void Update()
    {
        if (_gazeAware.HasGazeFocus)
        {
            obj.SetActive(true);
        }
        else
        {
            obj.SetActive(false);
        }
    }
}
