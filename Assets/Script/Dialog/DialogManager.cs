using System.Collections.Generic;
using UnityEngine;

public class DialogManager : MonoBehaviour
{
    public DialogController uiController;

    private Queue<DialogLine> currentLines;
    private DialogId currentId;
    private bool isDialogPlaying = false;

    public void StartDialog(DialogId id)
    {
        currentId = id;

        if (!DialogDatabase.dialogDict.TryGetValue(id, out DialogBlock block))
        {
            Debug.LogError($"Dialog ID '{id}' not found.");
            return;
        }

        currentLines = new Queue<DialogLine>(block.lines);
        isDialogPlaying = true;
        uiController.ShowDialogPanel(true);
        ShowNextLine();
    }

    public void ShowNextLine()
    {
        if (currentLines.Count > 0)
        {
            var line = currentLines.Dequeue();
            uiController.UpdateLine(line);
        }
        else
        {
            EndDialog();
        }
    }

    private void EndDialog()
    {
        uiController.ShowDialogPanel(false);
        isDialogPlaying = false;
    }

    void Update()
    {
        if (isDialogPlaying && Input.GetMouseButtonDown(0))
        {
            ShowNextLine();
        }
    }
}