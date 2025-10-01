using JetBrains.Annotations;
using UnityEngine;

public class Sensor: MonoBehaviour
{
    [SerializeField] float upspeed;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Authorize"))
        {
            other.GetComponent<Control>().Soar();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Trigger Stay");
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Authorize"))
        {
            other.GetComponent<Control>().Revert();
        }
    }


}
