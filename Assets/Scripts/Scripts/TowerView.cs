using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerView : MonoBehaviour
{
    [SerializeField] private GameObject _dulo;
    private EnemyWalkController _enemy;
    [SerializeField] private PulkaControler _pulka;
    public float chetotam = 1;


    private void Awake()
    {
        StartCoroutine(SpawnPulka());
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<EnemyWalkController>())
        {
            _enemy = other.GetComponent<EnemyWalkController>();
        }
    }
    private void OnTriggerExit(Collider collision)
    {
        
        if(collision == _enemy)
        {
            _enemy = null;
        }
    }

    private void CreatPulka()
    {
        if (_enemy != null)
        {
            PulkaControler pulkaControler = Instantiate(_pulka, transform);
            pulkaControler.transform.position = transform.position + new Vector3(0, 0, 0);
            pulkaControler.SetUp(_enemy.transform);
            pulkaControler.MoveStartCoroutine();
        }
    }
    private IEnumerator SpawnPulka()
    {
        while (true)
        {
            CreatPulka();
            yield return new WaitForSeconds(chetotam);
        }

    }


}
