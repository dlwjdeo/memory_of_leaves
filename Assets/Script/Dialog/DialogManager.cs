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
            Debug.LogWarning($"��縦 ã�� �� �����ϴ�: {speaker} / ID {id}");
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
            case SpeakerType.���ΰ�:
                return DialogDatabase.PlayerDialogs.TryGetValue(id, out var player) ? player : null;

            case SpeakerType.��ݽĹ�:
                return DialogDatabase.JoyPlantDialogs.TryGetValue(id, out var joy) ? joy : null;

            case SpeakerType.�г�Ĺ�:
                return DialogDatabase.AngryPlantDialogs.TryGetValue(id, out var angry) ? angry : null;

            case SpeakerType.�ҳ�:
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