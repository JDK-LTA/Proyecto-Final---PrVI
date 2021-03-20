using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class MeshSwapper : MonoBehaviour
//{
//    [SerializeField] private GameObject humanoidMeshObject;
//    [SerializeField] private GameObject planeMeshObject;
//    [SerializeField] private GameObject boatMeshObject;

//    [SerializeField] private ParticleSystem smokeParticles;

//    private MorphHandler morphHandler;

//    private Rigidbody rb;

//    private void Start()
//    {
//        morphHandler = GetComponent<MorphHandler>();
//        rb = GetComponent<Rigidbody>();
//    }

//    public void ChangeForm()
//    {
//        switch (morphHandler.GetActualForm()) {
//            case 1:
//                smokeParticles.Play();
//                humanoidMeshObject.SetActive(true);
//                planeMeshObject.SetActive(false);
//                boatMeshObject.SetActive(false);
//                break;
//            case 2:
//                smokeParticles.Play();
//                humanoidMeshObject.SetActive(false);
//                planeMeshObject.SetActive(true);
//                boatMeshObject.SetActive(false);
//                break;
//            case 3:
//                smokeParticles.Play();
//                humanoidMeshObject.SetActive(false);
//                planeMeshObject.SetActive(false);
//                boatMeshObject.SetActive(true);
//                break;
//            case 0:
//                humanoidMeshObject.SetActive(false);
//                planeMeshObject.SetActive(false);
//                boatMeshObject.SetActive(false);
//                break;
//        }
//    }
//}
