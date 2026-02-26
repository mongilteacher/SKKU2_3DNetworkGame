using Photon.Pun;
using UnityEngine;

public class ItemObject : MonoBehaviourPun
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("아이템 충돌!");
            
            other.GetComponent<PlayerController>().Score += 100;
            
            ItemObjectFactory.Instance.RequestDelete(photonView.ViewID);
        }
    }
}
