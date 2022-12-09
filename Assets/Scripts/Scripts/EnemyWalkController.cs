using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWalkController : MonoBehaviour
{
    private Transform[] _movePositions;
    private TowersFactori _towersFactori = new TowersFactori();
    private float speed = 3f;
    private int _nuberPosition = 0;
    [SerializeField] private int _hpEnemy = 100;

    public int HpEnemy { get => _hpEnemy; set => _hpEnemy = value; }

    void Update()
    {
        MoveEnemy();
    }
    public void MoveEnemy()
    {
        if (transform.position == _movePositions[_nuberPosition].position && _nuberPosition < _movePositions.Length - 1)
        {
            _nuberPosition++;
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, _movePositions[_nuberPosition].position, speed * Time.deltaTime);
        }   
    }
    public void GetPoints(Transform[] transforms)
    {
        _movePositions = transforms;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PulkaControler>())
        {
            _hpEnemy -= 10;
            Destroy(other.gameObject);
            if (_hpEnemy <= 0)
            {
                GameDataStorage.Coins += 15;
                Destroy(gameObject);
            }
        }
        if (other.GetComponent<PulkaControlerFrezz>())
        {
            speed /= 1.1f;
            _hpEnemy -= 5;
            Destroy(other.gameObject);
            if (_hpEnemy <= 0)
            {
                GameDataStorage.Coins += 15;
                Destroy(gameObject);
            }
        }
    }
}
