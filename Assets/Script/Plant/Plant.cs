using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Plant : MonoBehaviour
{
    [SerializeField] private SpeakerType type = SpeakerType.±â»Ý½Ä¹°;
    [SerializeField] private int dialogId = 0;

    private void OnMouseDown()
    {
        var manager = FindObjectOfType<DialogManager>();
        if (manager != null)
        {
            manager.StartDialog(type, dialogId);
        }
    }
}