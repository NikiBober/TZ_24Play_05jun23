using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform _transformToFollow;
    [SerializeField] private float _shakeDuration = 1f;
    [SerializeField] private float _shakeIntensity = 1f;
    private Vector3 _offset;

    float _elapsedTime = 1f;

    private void Start()
    {
        _offset = transform.position - _transformToFollow.position;
    }

    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(0f, _transformToFollow.position.y, _transformToFollow.position.z) + _offset, Time.deltaTime);

        if (_elapsedTime < _shakeDuration)
        {
            transform.position += Random.insideUnitSphere * _shakeIntensity;
            _elapsedTime += Time.deltaTime;
        }
    }

    public void Shake()
    {
        _elapsedTime = 0f;
    }
}
