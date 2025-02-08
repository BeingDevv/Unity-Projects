using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.Mathematics;
using UnityEngine;

public class Delivery : MonoBehaviour
{
  bool HasPackage;

  void OnCollisionEnter2D(Collision2D other) {
     UnityEngine.Debug.Log("The Car Collided");
   }
   SpriteRenderer spriteRenderer;
    void Start() {
    spriteRenderer = GetComponent<SpriteRenderer>();
   }
    [SerializeField] float delay = 0.2f;
    [SerializeField] Color32 HasPackageColor = new Color32 (1, 1, 1, 1);
    [SerializeField] Color32 NoPackageColor = new Color32 (1, 1, 1, 1);
    
    void OnTriggerEnter2D(Collider2D other) {
        // UnityEngine.Debug.Log("Passed Over");
        if (other.tag == "Package" && !HasPackage) {
         UnityEngine.Debug.Log("Package picked up");
         HasPackage = true;
         spriteRenderer.color = HasPackageColor;
         Destroy (other.gameObject, delay);
        }
        if (other.tag == "Customer" && HasPackage == true) {
        UnityEngine.Debug.Log("Delivered Package");
        HasPackage = false;
        spriteRenderer.color = NoPackageColor;
        }
    }
    
}
