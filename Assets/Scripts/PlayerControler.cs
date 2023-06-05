using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControler : MonoBehaviour
{
    [SerializeField] private float _forwardSpeed = 10f;
    [SerializeField] private float _horizontalSpeed = 0.03f;
    [SerializeField] private float _xRange = 2f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(_forwardSpeed * Time.deltaTime * Vector3.forward);
    }

    private void OnHorizontalMove(InputValue horizontalInput)
    {
        float newPosition = transform.position.x + horizontalInput.Get<float>() * _horizontalSpeed * Time.deltaTime;
        newPosition = Mathf.Clamp(newPosition, -_xRange, _xRange);
        transform.position = new Vector3(newPosition, transform.position.y, transform.position.z);  
        //transform.Translate(newPosition * _horizontalSpeed * Vector3.right);
    }

}
