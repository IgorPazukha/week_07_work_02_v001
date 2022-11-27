using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class IdleState : State
{
    private Animator _animator;
    private int _idleAnimation = Animator.StringToHash("Idle");
    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        _animator.Play(_idleAnimation);
    }

    private void OnDisable()
    {
        _animator.StopPlayback();
    }
}