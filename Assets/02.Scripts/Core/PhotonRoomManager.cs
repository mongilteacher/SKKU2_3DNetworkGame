using System;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class PhotonRoomManager : MonoBehaviourPunCallbacks
{
    public static PhotonRoomManager Instance { get; private set; }

    private Room _room;
    public Room Room => _room;

    public event Action OnDataChanged; 
    
    private void Awake()
    {
        Instance = this;
    }
    
    // 방 입장에 성공하면 자동으로 호출되는 콜백 함수
    public override void OnJoinedRoom()
    {
        _room = PhotonNetwork.CurrentRoom;
        
        OnDataChanged?.Invoke();
        
        // 리소스 폴더에서 "Player" 이름을 가진 프리팹을 생성(인스턴스화)하고, 서버에 등록도한다.
        //   ㄴ 리소스 폴더는 나쁜것이다. 그러기 때문에 다른 방법을 찾아보거라..
        // 3줄 이상으로 하드코딩을 했다? 
        PhotonNetwork.Instantiate("Player", Vector3.zero, Quaternion.identity);
    }
}
