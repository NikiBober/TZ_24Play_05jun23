using UnityEngine;

public class StackController : Singleton<StackController>
{
    public void IncreaseStack(GameObject cube)
    {
        transform.Translate(Vector3.up);
        cube.transform.position = new Vector3(transform.position.x, 0.5f, transform.position.z);
        cube.transform.SetParent(transform);
        cube.tag = "InStack";
    }
}
