using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailFollow : MonoBehaviour
{
    [SerializeField] Transform _transformToFollow;


    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(_transformToFollow.position.x, 0.01f, _transformToFollow.position.z); 
    }
}
