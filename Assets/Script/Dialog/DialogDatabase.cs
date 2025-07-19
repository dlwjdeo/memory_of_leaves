using System.Collections.Generic;

public static class DialogDatabase
{
    public static Dictionary<int, DialogLine[]> PlayerDialogs { get; private set; }
    public static Dictionary<int, DialogLine[]> GirlDialogs { get; private set; }

    public static Dictionary<int, DialogLine[]> JoyPlantDialogs { get; private set; }
    public static Dictionary<int, DialogLine[]> AngryPlantDialogs { get; private set; }

    public static Dictionary<int, DialogLine[]> ObjectDialogs { get; private set; }

    static DialogDatabase()
    {
        InitPlayerDialogs();
        InitGirlDialogs();
        InitJoyPlantDialogs();
        InitAngryPlantDialogs();
        InitObjectDialogs();
    }

    private static void InitPlayerDialogs()
    {
        PlayerDialogs = new Dictionary<int, DialogLine[]>
        {
            { 0, new DialogLine[]
                {
                    new DialogLine(SpeakerType.주인공, "여긴 어디지?"),
                    new DialogLine(SpeakerType.주인공, "기억이 안 나...")
                }
            }
        };
    }

    private static void InitGirlDialogs()
    {
        GirlDialogs = new Dictionary<int, DialogLine[]>
        {
            { 0, new DialogLine[]
                {
                    new DialogLine(SpeakerType.소녀, "드디어 깨어났군요."),
                    new DialogLine(SpeakerType.소녀, "기억을 되찾고 싶다면 날 따라오세요.")
                }
            }
        };
    }

    private static void InitJoyPlantDialogs()
    {
        JoyPlantDialogs = new Dictionary<int, DialogLine[]>
        {
            { 0, new DialogLine[]
                {
                    new DialogLine(SpeakerType.기쁨식물, "햇빛이 좋아요!"),
                    new DialogLine(SpeakerType.기쁨식물, "오늘은 기분이 상쾌해요.")
                }
            },
            { 1, new DialogLine[]
                {
                    new DialogLine(SpeakerType.기쁨식물, "당신을 만나서 행복해요.")
                }
            }
        };
    }

    private static void InitAngryPlantDialogs()
    {
        AngryPlantDialogs = new Dictionary<int, DialogLine[]>
        {
            { 0, new DialogLine[]
                {
                    new DialogLine(SpeakerType.분노식물, "왜 또 왔어?"),
                    new DialogLine(SpeakerType.분노식물, "날 내버려 둬!")
                }
            }
        };
    }

    private static void InitObjectDialogs()
    {
        ObjectDialogs = new Dictionary<int, DialogLine[]>
        {
            { 0, new DialogLine[]
                {
                    new DialogLine(SpeakerType.None, "문이 굳게 잠겨 있다."),
                    new DialogLine(SpeakerType.None, "열쇠가 필요해 보인다.")
                }
            }
        };
    }
}
public class DialogLine
{
    public SpeakerType Speaker;
    public string Text;

    public DialogLine(SpeakerType speaker, string text)
    {
        Speaker = speaker;
        Text = text;
    }
}