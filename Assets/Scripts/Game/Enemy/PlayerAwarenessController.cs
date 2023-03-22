using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAwarenessController : MonoBehaviour
{
    public bool AwareOfPlayer { get; private set; }

    public Vector2 DirectionToPlayer { get; private set; }
    public Vector2 DirectionToOven { get; private set; }

    [SerializeField] 
    private float _playerAwarenessDistance;

    private Transform _player;
    private Transform _oven;


    private void Awake()
    {
        _player = FindObjectOfType<PlayerMovement>().transform;
        _oven = FindObjectOfType<OvenStatus>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 enemyToPlayerVector = _player.position - transform.position;
        Vector2 enemyToOvenVector = _oven.position - transform.position;
        DirectionToPlayer = enemyToPlayerVector.normalized;
        DirectionToOven = enemyToOvenVector.normalized;

        if (enemyToPlayerVector.magnitude <= _playerAwarenessDistance)
        {
            AwareOfPlayer = true;
         //   Debug.Log("Aware of player " + _player.position);
        }
        else
        {
            AwareOfPlayer = false;
           // Debug.Log("Not Aware of player " + _oven.position);
        }
    }
}
