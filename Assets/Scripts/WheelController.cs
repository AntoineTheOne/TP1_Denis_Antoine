using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class WheelController : MonoBehaviour
{   
    private CarController controls; // Référence au script généré par l'Input System (CarController.inputactions)
    [SerializeField] WheelCollider frontRight; [SerializeField] WheelCollider frontLeft; // ----- Colliders des roues -----
    [SerializeField] WheelCollider backRight; [SerializeField] WheelCollider backLeft; // ----- Colliders des roues -----
    [SerializeField] float acceleration = 500f; [SerializeField] float breakingForce = 300f; [SerializeField] float maxTurnAngle = 15f; // ----- Réglages physiques de la voiture -----
    [SerializeField] Transform frontRightWheelMesh; [SerializeField] Transform frontLeftWheelMesh; // ----- Références aux meshes visuels -----
    [SerializeField] Transform backRightWheelMesh; [SerializeField] Transform backLeftWheelMesh; // ----- Références aux meshes visuels -----
    float currentAcceleration = 0; float currentBreakForce = 0; float currentTurnAngle = 0; // ----- Variables internes -----
    void Awake()
    {   
        controls = new CarController(); // Crée une nouvelle instance des contrôles définis dans CarController.inputactions
    }
    void OnEnable() // Activation du système d’entrée quand l’objet est actif
    {   controls.Enable();
    }
    void OnDisable() // Désactivation quand l’objet est désactivé
    {   
        controls.Disable();
    }
    void FixedUpdate() // FixedUpdate = utilisé pour la physique (mieux que Update)
    {  
        currentAcceleration = acceleration * controls.MouvementVoiture.Mouvement.ReadValue<Vector2>().y; // Récupère la valeur du joystick/clavier (W/S pour avant/arrière)
        // ----- APPLICATION DE LA FORCE MOTEUR -----
        frontRight.motorTorque = currentAcceleration; frontLeft.motorTorque = currentAcceleration;
        backRight.motorTorque = currentAcceleration; backLeft.motorTorque = currentAcceleration;
        // ----- APPLICATION DES FREINS -----
        frontRight.brakeTorque = currentBreakForce; frontLeft.brakeTorque = currentBreakForce;
        backRight.brakeTorque = currentBreakForce; backLeft.brakeTorque = currentBreakForce;
        // Récupère la valeur horizontale (A/D) et calcule l’angle de braquage
        currentTurnAngle = maxTurnAngle * controls.MouvementVoiture.Mouvement.ReadValue<Vector2>().x;
        frontLeft.steerAngle = currentTurnAngle; frontRight.steerAngle = currentTurnAngle;
        // Met à jour la position et la rotation des meshes pour suivre les colliders
        SetWheel(frontRight, frontRightWheelMesh); SetWheel(frontLeft, frontLeftWheelMesh);
        SetWheel(backRight, backRightWheelMesh); SetWheel(backLeft, backLeftWheelMesh);
    }
    void SetWheel(WheelCollider wheelCol, Transform wheelMesh) // Met à jour la position et la rotation du mesh associé à une roue
    {   
        Vector3 pos; Quaternion rot;
        wheelCol.GetWorldPose(out pos, out rot); // Récupère la position et la rotation actuelles du collider
        wheelMesh.position = pos; wheelMesh.rotation = rot; // Applique ces valeurs au mesh visuel
    }
}
