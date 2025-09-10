using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
[CreateAssetMenu(fileName = "WeaponSO" , menuName = "Scriptable Objects/WeaponSo")]
public class WeaponSO : ScriptableObject
{
    public GameObject weaponPrefab;
    public int Damage = 1;
    public float FireRate = .5f;
    public GameObject HitVFXprefab;
    public bool IsAutomatic = false;
    public bool CanZoom = false;
    public float ZoomAmount = 10;
    public float ZoomRotationSpeed = .3f;
    public int MagazineSize = 12;

}
