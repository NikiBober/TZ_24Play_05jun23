using UnityEngine;

public class GarbageCollector : MonoBehaviour
{
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
