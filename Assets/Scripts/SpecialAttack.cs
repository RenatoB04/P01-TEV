using UnityEngine;
using UnityEngine.VFX;

public class SpecialAttack : MonoBehaviour
{
    public VisualEffect vfxPrefab;
    public Transform spawnPoint;
    public float cooldown = 3f;

    private float nextAttackTime = 0f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && Time.time >= nextAttackTime)
        {
            Instantiate(vfxPrefab, spawnPoint.position, Quaternion.identity);
            
            nextAttackTime = Time.time + cooldown;
        }
    }
}
