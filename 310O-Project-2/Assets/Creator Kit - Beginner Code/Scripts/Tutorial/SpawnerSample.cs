using UnityEngine;
using CreatorKitCode;

public class SpawnerSample : MonoBehaviour
{
    public GameObject ObjectToSpawn;

    void Start()
    {
        LootAngle angle = new LootAngle(45);
        SpawnPotion(angle.NextAngle());
        SpawnPotion(angle.NextAngle());
        SpawnPotion(angle.NextAngle());
        SpawnPotion(angle.NextAngle());
    }
    void SpawnPotion(int angle)
    {
        int radius = 5;
        Vector3 direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
        Vector3 spawnPosition = transform.position + direction * radius;
        Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);
    }
}
public class LootAngle
{
    int angle;
    int step;
    public LootAngle(int increment)
    {
        angle = 0;
        step = increment;
    }

    public int NextAngle()
    {
        int currentAngle = angle;
        angle = Helpers.WrapAngle(angle + step);

        return currentAngle;
    }
}

