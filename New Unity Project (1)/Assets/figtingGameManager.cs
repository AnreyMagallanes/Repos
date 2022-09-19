using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class figtingGameManager : MonoBehaviour
{
    public GameObject p2healthGO; 

    public int p2hp = 100;
    void Start()
    {
        dealDamage(p2hp,7,50);
    }

    // Update is called once per frame
    void Update()
    {
        p2healthGO.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = p2hp + "";
    }
    void dealDamage(int currenthp, int damageAmount, int accuracy)
    {
        int ran = Random.Range(0,101);
        if (ran <= accuracy){
        p2hp = currenthp -= damageAmount;}
    }

public void P1LowKick()
{
    dealDamage(p2hp,7,50);

}
}
