using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform _transformToFollow;
    private Vector3 _offset;

    void Start()
    {
        _offset = transform.position - _transformToFollow.position;
    }

    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(0f, _transformToFollow.position.y, _transformToFollow.position.z) + _offset, Time.deltaTime);
    }
}
