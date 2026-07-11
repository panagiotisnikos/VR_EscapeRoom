using System.Collections;
using UnityEngine;

public class DoorUnlock : MonoBehaviour
{
    [SerializeField] private Transform door;
    [SerializeField] private float openHeight = 3f;
    [SerializeField] private float openDuration = 1.5f;
    [SerializeField] private AudioSource audioSource;    private bool isOpened;

    private void OnTriggerEnter(Collider other)
    {
        if (isOpened || !other.CompareTag("Key"))
            return;

        isOpened = true;
        if (audioSource != null)
        {
            audioSource.Play();
        }

        Rigidbody keyRigidbody = other.attachedRigidbody;

        if (keyRigidbody != null)
        {
            keyRigidbody.isKinematic = true;
            keyRigidbody.useGravity = false;
        }

        StartCoroutine(OpenDoor());
    }

    private IEnumerator OpenDoor()
    {
        Vector3 startPosition = door.position;
        Vector3 targetPosition = startPosition + Vector3.up * openHeight;

        float elapsedTime = 0f;

        while (elapsedTime < openDuration)
        {
            elapsedTime += Time.deltaTime;

            float progress = Mathf.Clamp01(elapsedTime / openDuration);
            door.position = Vector3.Lerp(startPosition, targetPosition, progress);

            yield return null;
        }

        door.position = targetPosition;
    }
}