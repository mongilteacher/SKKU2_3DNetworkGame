using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class ItemObject : MonoBehaviourPun
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        
        PhotonView pv = other.GetComponent<PhotonView>();
        if (!pv.IsMine) return;
        
        ScoreManager.Instance.AddScore(100);
        ItemObjectFactory.Instance.RequestDelete(photonView.ViewID);
    }
}