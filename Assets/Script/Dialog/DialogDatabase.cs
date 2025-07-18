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
            new DialogLine(SpeakerType.주인공, "여긴 어디지?", PortraitType.Neutral),
            new DialogLine(SpeakerType.분노식물, "기다렸어.", PortraitType.Smile)
        });

        dialogDict[DialogId.anger_stage2] = new DialogBlock(new List<DialogLine>
        {
            new DialogLine(SpeakerType.분노식물, "나는 네 기억이야.", PortraitType.Mysterious)
        });

        dialogDict[DialogId.dream_ending] = new DialogBlock(new List<DialogLine>
        {
            new DialogLine(SpeakerType.주인공, "...그냥 꿈일 뿐이야.", PortraitType.None)
        });
    }
}

// ----------------------------------
// 4. 식물 → 대사 ID 연결 매핑
// ----------------------------------
public static class DialogMap
{
    public static Dictionary<(PlantId, StageKey), DialogId> dialogKeyMap = new()
    {
        { (PlantId.plant_anger, StageKey.stage1), DialogId.anger_stage1 },
        { (PlantId.plant_anger, StageKey.stage2), DialogId.anger_stage2 },
        { (PlantId.plant_joy, StageKey.stage1), DialogId.joy_intro },
        // 추가 매핑 계속
    };

    public static DialogId? GetDialogId(PlantId plantId, StageKey stageKey)
    {
        return dialogKeyMap.TryGetValue((plantId, stageKey), out var id) ? id : null;
    }
}