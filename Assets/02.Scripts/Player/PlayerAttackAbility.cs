using UnityEngine;

public class PlayerAttackAbility : MonoBehaviour
{
    private Animator _animator;

    [SerializeField] private EAnimationSequenceType _animationSequenceType;

    private int _prevAnimationNumber = 0;
    private const float ATTACK_COOLTIME = 0.6f;
    private float _attackTimer = 0f;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }
    
    private void Update()
    {
        _attackTimer += Time.deltaTime;

        if (Input.GetMouseButton(0) && _attackTimer >= ATTACK_COOLTIME)
        {
            _attackTimer = 0f;

            int animationNumber = 0;
            switch (_animationSequenceType)
            {
                case EAnimationSequenceType.Sequence:
                {
                    animationNumber = 1 + (_prevAnimationNumber++) % 3;
                    break;
                }
                
                case EAnimationSequenceType.Random:
                {
                    animationNumber = Random.Range(1, 4);
                    break;
                }
            }
            
            _animator.SetTrigger($"Attack{animationNumber}");
        }
    }
}

public enum EAnimationSequenceType
{
    Sequence,
    Random,
}
