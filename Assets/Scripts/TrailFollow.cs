using UnityEngine;

public class TrailFollow : MonoBehaviour
{
    [SerializeField] private Transform _transformToFollow;
    [SerializeField] private float _elevation = 0.01f;

    private void LateUpdate()
    {
        transform.position = new Vector3(_transformToFollow.position.x, _elevation, _transformToFollow.position.z); 
    }
}
