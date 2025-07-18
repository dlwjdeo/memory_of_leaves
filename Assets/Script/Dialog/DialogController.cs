using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogController : MonoBehaviour
{
    public GameObject dialogPanel;
    public TMP_Text speakerNameText;
    public TMP_Text contentText;
    public Image portraitImage;

    public Sprite neutralSprite;
    public Sprite smileSprite;
    public Sprite mysteriousSprite;

    public void ShowDialogPanel(bool show)
    {
        dialogPanel.SetActive(show);
    }

    public void UpdateLine(DialogLine line)
    {
        speakerNameText.text = line.speaker.ToString();
        contentText.text = line.content;
        portraitImage.sprite = GetPortraitSprite(line.portrait);
    }

    private Sprite GetPortraitSprite(PortraitType type)
    {
        return type switch
        {
            PortraitType.Neutral => neutralSprite,
            PortraitType.Smile => smileSprite,
            PortraitType.Mysterious => mysteriousSprite,
            _ => null
        };
    }
}