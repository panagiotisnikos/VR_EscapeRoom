using System.Collections;
using UnityEngine;

public class ButtonPuzzleManager : MonoBehaviour
{
    [SerializeField] private Transform finalDoor;
    [SerializeField] private float openHeight = 3f;
    [SerializeField] private float openDuration = 1.5f;
    [SerializeField] private AudioSource audioSource;
    private int expectedButton = 1;
    private bool puzzleCompleted;

    public void PressButton(int buttonNumber)
    {
        if (puzzleCompleted)
            return;

        if (buttonNumber == expectedButton)
        {
            Debug.Log("Correct button: " + buttonNumber);
            expectedButton++;

            if (expectedButton > 3)
            {
                puzzleCompleted = true;
                Debug.Log("Puzzle completed!");
                if (audioSource != null)
                {
                    audioSource.Play();
                }
                StartCoroutine(OpenFinalDoor());
                
            }
        }
        else
        {
            Debug.Log("Wrong sequence. Start again.");
            expectedButton = 1;
        }
    }

    private IEnumerator OpenFinalDoor()
    {
        Vector3 startPosition = finalDoor.position;
        Vector3 targetPosition = startPosition + Vector3.up * openHeight;

        float elapsedTime = 0f;

        while (elapsedTime < openDuration)
        {
            elapsedTime += Time.deltaTime;

            float progress = Mathf.Clamp01(elapsedTime / openDuration);
            finalDoor.position =
                Vector3.Lerp(startPosition, targetPosition, progress);

            yield return null;
        }

        finalDoor.position = targetPosition;
    }
}
