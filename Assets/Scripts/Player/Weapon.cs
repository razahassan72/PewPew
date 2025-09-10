using Cinemachine;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] ParticleSystem muzzleFlash;
    [SerializeField] LayerMask interactionLayers;

    CinemachineImpulseSource impulseSource;

    private void Awake()
    {
        impulseSource = GetComponent<CinemachineImpulseSource>();
    }

    public void Shoot(WeaponSO weaponSO)
    {
        muzzleFlash.Play();
        impulseSource.GenerateImpulse();

        RaycastHit hit;

        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward,out hit, Mathf.Infinity, interactionLayers, QueryTriggerInteraction.Ignore))
        {
            Instantiate(weaponSO.HitVFXprefab, hit.point, Quaternion.identity);
            EnemyHealth enemyHealth = hit.collider.GetComponentInParent<EnemyHealth>();
            if (enemyHealth != null)
            {
                enemyHealth.TakeDamage(weaponSO.Damage);
            }
        }
    }
}
