using UnityEngine;
using UnityEngine.Events;

public class TriggerHandler : MonoBehaviour
{
    [SerializeField] UnityEvent OnEnterEvent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Grabbable")
        {
            OnEnterEvent.Invoke();
            other.gameObject.SetActive(false);
        }
    }
}
