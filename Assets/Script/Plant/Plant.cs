using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Plant : MonoBehaviour
{
    public PlantId plantId = PlantId.plant_anger;
    public StageKey stage = StageKey.stage1;

    private void OnMouseDown()
    {
        OnInteract();
    }

    public void OnInteract()
    {
        DialogId? dialogId = DialogMap.GetDialogId(plantId, stage);
        if (dialogId.HasValue)
        {
            FindObjectOfType<DialogManager>().StartDialog(dialogId.Value);
        }
        else
        {
            Debug.LogWarning("대사 없음");
        }
    }
}