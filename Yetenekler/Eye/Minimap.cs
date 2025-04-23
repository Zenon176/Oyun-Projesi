using UnityEngine;
using System.Collections.Generic;

public class MinimapSystem : MonoBehaviour
{
    //2 seviyeli yetenek 1. seviyede sadece haritayı gösteriyor, 2. seviyede düşman ve gizli öğeleri gösteriyor.
    [Header("Level Ayarları")]
    [Range(1, 2)]
    public int minimapLevel = 1;

    [Header("Referanslar")]
    public Camera minimapCamera;
    public GameObject enemyIconPrefab;
    public GameObject treasureIconPrefab;

    private List<GameObject> enemyIcons = new List<GameObject>();
    private List<GameObject> treasureIcons = new List<GameObject>();
    private GameObject[] enemies;
    private GameObject[] treasures;

    void Start()
    {
        if (minimapLevel == 2){
            
            enemies = GameObject.FindGameObjectsWithTag("Enemy");
            treasures = GameObject.FindGameObjectsWithTag("Treasure");

            
            foreach (GameObject enemy in enemies){
                GameObject icon = Instantiate(enemyIconPrefab);
                enemyIcons.Add(icon);
            }

            foreach (GameObject treasure in treasures){
                GameObject icon = Instantiate(treasureIconPrefab);
                treasureIcons.Add(icon);
            }
        }
    }

    void LateUpdate()
    {
        if (minimapLevel == 1){
            Vector3 newPos = player.position;
            newPos.y = transform.position.y;
            transform.position = newPos;
        } 
            
        if (minimapLevel == 2){
        
            for (int i = 0; i < enemies.Length; i++){

                if (enemies[i] != null && enemyIcons[i] != null){

                    Vector3 pos = enemies[i].transform.position;
                    enemyIcons[i].transform.position = new Vector3(pos.x, pos.y + 20f, pos.z);
                }
            }

            
            for (int i = 0; i < treasures.Length; i++){

                if (treasures[i] != null && treasureIcons[i] != null){

                    Vector3 pos = treasures[i].transform.position;
                    treasureIcons[i].transform.position = new Vector3(pos.x, pos.y + 20f, pos.z);
                }
            }
        }

    }
}
