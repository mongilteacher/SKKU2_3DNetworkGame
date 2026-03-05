using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.UI;

public class UI_RoomItem : MonoBehaviour
{
    public Text RoomNameTextUI;
    public Text MasterNicknameTextUI;
    public Text PlayerCoutTextUI;
    public Button RoomEnterButton;
    
    private RoomInfo _roomInfo;

    private void Start()
    {
        RoomEnterButton.onClick.AddListener(EnterRoom);
    }
    
    public void Init(RoomInfo roomInfo)
    {
        _roomInfo = roomInfo;
        
        RoomNameTextUI.text = roomInfo.Name;
        MasterNicknameTextUI.text = "방장 이름";
        PlayerCoutTextUI.text = $"{roomInfo.PlayerCount}/{roomInfo.MaxPlayers}";
    }

    private void EnterRoom()
    {
        if (_roomInfo == null) return;

        PhotonNetwork.JoinRoom(_roomInfo.Name);
    }
}
