using System.Collections.Generic;
using UnityEngine;

public class DialogDatabase : MonoBehaviour
{
    public static Dictionary<DialogId, DialogBlock> dialogDict = new();

    void Awake()
    {
        LoadDialogs();
    }

    void LoadDialogs()
    {
        dialogDict[DialogId.anger_stage1] = new DialogBlock(new List<DialogLine>
        {
            new DialogLine(SpeakerType.���ΰ�, "���� �����?", PortraitType.Neutral),
            new DialogLine(SpeakerType.�г�Ĺ�, "��ٷȾ�.", PortraitType.Smile)
        });

        dialogDict[DialogId.anger_stage2] = new DialogBlock(new List<DialogLine>
        {
            new DialogLine(SpeakerType.�г�Ĺ�, "���� �� ����̾�.", PortraitType.Mysterious)
        });

        dialogDict[DialogId.dream_ending] = new DialogBlock(new List<DialogLine>
        {
            new DialogLine(SpeakerType.���ΰ�, "...�׳� ���� ���̾�.", PortraitType.None)
        });
    }
}

// ----------------------------------
// 4. �Ĺ� �� ��� ID ���� ����
// ----------------------------------
public static class DialogMap
{
    public static Dictionary<(PlantId, StageKey), DialogId> dialogKeyMap = new()
    {
        { (PlantId.plant_anger, StageKey.stage1), DialogId.anger_stage1 },
        { (PlantId.plant_anger, StageKey.stage2), DialogId.anger_stage2 },
        { (PlantId.plant_joy, StageKey.stage1), DialogId.joy_intro },
        // �߰� ���� ���
    };

    public static DialogId? GetDialogId(PlantId plantId, StageKey stageKey)
    {
        return dialogKeyMap.TryGetValue((plantId, stageKey), out var id) ? id : null;
    }
}