using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public KeyCode interactionKey = KeyCode.E;


    private void OnTriggerEnter(Collider other)
    {
        var triggerable = other.GetComponent<ITriggerableMonoBehaviour>();
        if (triggerable != null) triggerable.Trigger(transform);
        
        if (other.GetComponent<Thorns>() != null)
        {
            gameObject.GetComponent<PlayerRespawnBehaviour>().Die();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        var interactable = other.GetComponent<IInteractableMonoBehaviour>();
        if (interactable != null) interactable.Interact(transform);
    }
}
