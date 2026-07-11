using UnityEngine;

public class EscapeTrigger : MonoBehaviour
{
    [SerializeField] private GameObject winCanvas;
    [SerializeField] private EscapeTimer escapeTimer;

    private bool hasEscaped;

    private void OnTriggerEnter(Collider other)
    {
        if (hasEscaped)
            return;

        if (other.GetComponentInParent<CharacterController>() == null)
            return;

        hasEscaped = true;

        winCanvas.SetActive(true);
        escapeTimer.StopTimer();

        Debug.Log("You Escaped!");
    }
}