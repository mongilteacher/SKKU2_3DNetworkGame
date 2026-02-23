using UnityEngine;

public class PlayerMoveAbility : MonoBehaviour
{
    public float MoveSpeed = 7f;
    
    public float JumpForce = 2.5f;
    
    private const float GRAVITY = 9.8f;
    private float _yVeocity = 0f;

    private CharacterController _characterController;
    
    // 1. 중력을 적용하세요.
    // 2. 스페이스바를 누르면 점프하게 해주세요.

    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        
        Vector3 direction = new Vector3(h, 0, v);
        direction.Normalize();
        
        _characterController.Move(direction * Time.deltaTime * MoveSpeed);
    }
}
