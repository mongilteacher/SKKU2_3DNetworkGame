using Photon.Pun;
using UnityEngine;

public class ItemObject : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("아이템 충돌!");
            
            collision.gameObject.GetComponent<PlayerController>().Score += 100;
            
            PhotonNetwork.Destroy(gameObject);
        }
    }
}
