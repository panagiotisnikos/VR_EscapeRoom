using UnityEngine;

public class PuzzleButton : MonoBehaviour
{
    [SerializeField] private int buttonNumber;
    [SerializeField] private ButtonPuzzleManager puzzleManager;

    public void Press()
    {
        puzzleManager.PressButton(buttonNumber);
    }
}