using Photon.Pun;
using UnityEngine;

public class GameScene : MonoBehaviour
{
    private void Start()
    {
        // 리소스 폴더에서 "Player" 이름을 가진 프리팹을 생성(인스턴스화)하고, 서버에 등록도한다.
        //   ㄴ 리소스 폴더는 나쁜것이다. 그러기 때문에 다른 방법을 찾아보거라..
        // 3줄 이상으로 하드코딩을 했다? 
        PhotonNetwork.Instantiate("Player", Vector3.zero, Quaternion.identity);
    }
}
