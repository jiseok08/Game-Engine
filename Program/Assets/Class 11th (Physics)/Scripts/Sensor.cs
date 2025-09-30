using UnityEngine;

public class Sensor: MonoBehaviour
{
    [SerializeField] Rigidbody rigidBody;
    [SerializeField] float upspeed;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Enter");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Trigger Stay");
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger Exit");
    }


}
