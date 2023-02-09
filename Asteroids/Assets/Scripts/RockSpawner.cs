using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject prefabRock;

    [SerializeField]
    public Sprite greenRockSprite;

    [SerializeField]
    public Sprite magentaRockSprite;

    [SerializeField]
    public Sprite redRockSprite;

    float minSpawnX;
    float minSpawnY;

    float maxSpawnX;
    float maxSpawnY;
    // Start is called before the first frame update
    void Start()
    {
        minSpawnX = Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x;
        minSpawnY = Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).y;

        maxSpawnX = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height)).x;
        maxSpawnY = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height)).y;

        SpawnRock();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRock()
    {

        Vector3 spawnLocation = new Vector3(
            Random.Range(minSpawnY, maxSpawnX),
            Random.Range(minSpawnY, maxSpawnY),
            -Camera.main.transform.position.z
        );

        GameObject rock = Instantiate(prefabRock) as GameObject;
        rock.transform.position = spawnLocation;

        SpriteRenderer spriteRenderer = rock.GetComponent<SpriteRenderer>();

        Sprite[] sprites = new Sprite[3]
        {
            greenRockSprite,
            magentaRockSprite,
            redRockSprite,
        };

        Sprite randomRockSprite = sprites[Random.Range(0, sprites.Length)];
        spriteRenderer.sprite = randomRockSprite;


    }
}
