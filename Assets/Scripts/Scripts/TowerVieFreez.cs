using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerVieFreez : MonoBehaviour
{
    [SerializeField] private GameObject _dulo;
    private EnemyWalkController _enemy;
    [SerializeField] private PulkaControlerFrezz _pulkas;
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

        if (collision == _enemy)
        {
            _enemy = null;
        }
    }

    private void CreatPulka()
    {
        if (_enemy != null)
        {
            PulkaControlerFrezz pulkaControlerFrezz = Instantiate(_pulkas, transform);
            pulkaControlerFrezz.transform.position = transform.position + new Vector3(0, 0, 0);
            pulkaControlerFrezz.SetUp(_enemy.transform);
            pulkaControlerFrezz.MoveStartCoroutine();
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
