using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAwareness : MonoBehaviour
{
    public bool AwareOfPlayer {get; private set;}

    public Vector2 DirectionToPlayer { get; private set;}

    [SerializeField]
    private float _playerAwarenessDistance;

    public Transform _player;

    private void Awake()
    {
      //  _player + FindObjectofType < PlayerMovement.().transform;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 enemyToPlayerVector = _player.position - transform.position;
        DirectionToPlayer = enemyToPlayerVector.normalized;

        if (enemyToPlayerVector.magnitude <= _playerAwarenessDistance)
        {
            AwareOfPlayer = true;
        }
        else
        {
            AwareOfPlayer= false;
        }

    }

}
