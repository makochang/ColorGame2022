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
        //Playerが範囲内にいる場合はスポーンできない
        if (other.tag == "Player")
        {
            canSpawnable = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //Playerが範囲外に出たら再びスポーンできる
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
