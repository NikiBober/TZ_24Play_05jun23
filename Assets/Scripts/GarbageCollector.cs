using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageCollector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Track"))
        {
            LevelGenerator.Instance.GenerateNewTrack();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }

}
