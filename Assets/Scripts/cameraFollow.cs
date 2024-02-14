using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform presentSelf;
    [SerializeField] Transform shadowOfSelf;
    private float averageX;
    
    // Update is called once per frame
    void Update()
    {
        averageX = (presentSelf.position.x + shadowOfSelf.position.x)/2;
        gameObject.transform.position = new Vector3(averageX, presentSelf.position.y, gameObject.transform.position.z);
    }
}
