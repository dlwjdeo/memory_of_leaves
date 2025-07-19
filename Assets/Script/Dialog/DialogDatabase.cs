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
                    new DialogLine(SpeakerType.���ΰ�, "���� �����?"),
                    new DialogLine(SpeakerType.���ΰ�, "����� �� ��...")
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
                    new DialogLine(SpeakerType.�ҳ�, "���� �������."),
                    new DialogLine(SpeakerType.�ҳ�, "����� ��ã�� �ʹٸ� �� ���������.")
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
                    new DialogLine(SpeakerType.��ݽĹ�, "�޺��� ���ƿ�!"),
                    new DialogLine(SpeakerType.��ݽĹ�, "������ ����� �����ؿ�.")
                }
            },
            { 1, new DialogLine[]
                {
                    new DialogLine(SpeakerType.��ݽĹ�, "����� ������ �ູ�ؿ�.")
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
                    new DialogLine(SpeakerType.�г�Ĺ�, "�� �� �Ծ�?"),
                    new DialogLine(SpeakerType.�г�Ĺ�, "�� ������ ��!")
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
                    new DialogLine(SpeakerType.None, "���� ���� ��� �ִ�."),
                    new DialogLine(SpeakerType.None, "���谡 �ʿ��� ���δ�.")
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