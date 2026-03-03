using UnityEngine;
using UnityEngine.UI;

public class UI_ScoreItem : MonoBehaviour
{
    public Text NicknameTextUI;
    public Text ScoreTextUI;

    public void Set(string nickname, string score)
    {
        NicknameTextUI.text = nickname;
        ScoreTextUI.text = $"{score:N0}";
    }
}
