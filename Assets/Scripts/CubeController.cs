using UnityEngine;

public class CubeController : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pickup"))
        {
            PlayerControler.Instance.IncreaseStack(collision.gameObject);
        }
    }
}
