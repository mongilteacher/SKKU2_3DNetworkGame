using Photon.Realtime;
using UnityEngine;
using UnityEngine.UI;

public class UI_RoomLog : MonoBehaviour
{
    [SerializeField] private Text _logText;

    private void Start()
    {
        _logText.text = "방에 입장했습니다.";
        
        PhotonRoomManager.Instance.OnPlayerEnter += OnPlayerEnter;
        PhotonRoomManager.Instance.OnPlayerLeft  += OnPlayerLeft;
    }

    private void OnPlayerEnter(Player newPlayer)
    {
        _logText.text += "\n" + $"{newPlayer.NickName}님이 입장하였습니다.";
    }

    private void OnPlayerLeft(Player player)
    {
        _logText.text += "\n" + $"{player.NickName}님이 퇴장하였습니다.";

    }
}
