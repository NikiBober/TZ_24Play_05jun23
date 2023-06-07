using UnityEngine;

public class CubeController : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pickup"))
        {
            StackController.Instance.IncreaseStack(collision.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            transform.SetParent(null);
            GameManager.Instance.CollisionEffects();
        }
    }
}
