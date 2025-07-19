using UnityEngine;
using TMPro;

public class DialogController : MonoBehaviour
{
    public TextMeshProUGUI speakerText;
    public TextMeshProUGUI contentText;

    private DialogLine[] currentDialog;
    private int dialogIndex;

    public void StartDialog(DialogLine[] dialogLines)
    {
        currentDialog = dialogLines;
        dialogIndex = 0;
        ShowDialog();
    }

    public void ShowDialog()
    {
        if (dialogIndex >= currentDialog.Length)
        {
            FindObjectOfType<DialogManager>().EndDialog();
            return;
        }

        var line = currentDialog[dialogIndex];
        speakerText.text = line.Speaker.ToString();
        contentText.text = line.Text;

        dialogIndex++;
    }

    private void Update()
    {
        if (!gameObject.activeSelf) return;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShowDialog();
        }
    }
}