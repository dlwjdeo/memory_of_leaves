using UnityEngine;

public class DialogManager : MonoBehaviour
{
    public DialogController dialogController;
    public bool isAction = false;

    public void StartDialog(SpeakerType speaker, int id)
    {
        if (isAction) return;

        DialogLine[] lines = GetDialogLines(speaker, id);
        if (lines == null)
        {
            Debug.LogWarning($"대사를 찾을 수 없습니다: {speaker} / ID {id}");
            return;
        }

        isAction = true;
        GameManager.instance.SetPause(true);

        dialogController.gameObject.SetActive(true);
        dialogController.StartDialog(lines);
    }

    private DialogLine[] GetDialogLines(SpeakerType speaker, int id)
    {
        switch (speaker)
        {
            case SpeakerType.주인공:
                return DialogDatabase.PlayerDialogs.TryGetValue(id, out var player) ? player : null;

            case SpeakerType.기쁨식물:
                return DialogDatabase.JoyPlantDialogs.TryGetValue(id, out var joy) ? joy : null;

            case SpeakerType.분노식물:
                return DialogDatabase.AngryPlantDialogs.TryGetValue(id, out var angry) ? angry : null;

            case SpeakerType.소녀:
                return DialogDatabase.GirlDialogs.TryGetValue(id, out var girl) ? girl : null;

            case SpeakerType.None:
                return DialogDatabase.ObjectDialogs.TryGetValue(id, out var obj) ? obj : null;

            default:
                return null;
        }
    }

    public void EndDialog()
    {
        dialogController.gameObject.SetActive(false);
        GameManager.instance.SetPause(false);
        isAction = false;
    }
}