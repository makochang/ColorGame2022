using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemyObj;
    bool canSpawnable = true;

    GameObject childEnemy;

    public void Bye()
    {
        if (childEnemy)
        {
            childEnemy = null;
        }
    }

    public bool Spawn()
    {
        Debug.Log(childEnemy);
        if (canSpawnable && childEnemy==null)
        {
            childEnemy = Instantiate(enemyObj, transform.position, transform.rotation);
            return true;
        }
        else
        {
            return false;
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        //Player���͈͓��ɂ���ꍇ�̓X�|�[���ł��Ȃ�
        if (other.tag == "Player")
        {
            canSpawnable = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //Player���͈͊O�ɏo����ĂуX�|�[���ł���
        if (other.tag == "Player")
        {
            canSpawnable = true;
        }

    }



    private void Start()
    {
        GetComponent<MeshRenderer>().enabled = false;
    }
}
