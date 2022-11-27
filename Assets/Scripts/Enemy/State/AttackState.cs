using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AttackState : State
{
    [SerializeField] private int _damage;
    [SerializeField] private int _delay;

    private float _lastAttackTime;
    private Animator _animator;
    private int _attackAnimation = Animator.StringToHash("Attack");

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if(_lastAttackTime <= 0)
        {
            Attack(Target);
            _lastAttackTime = _delay;
        }

        _lastAttackTime -= Time.deltaTime;
    }

    private void Attack(Player target)
    {
        _animator.Play(_attackAnimation);
        target.ApplyDamage(_damage);
    }
}