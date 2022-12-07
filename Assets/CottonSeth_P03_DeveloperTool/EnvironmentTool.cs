using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

[ExecuteInEditMode]
public class EnvironmentTool : MonoBehaviour
{
    [SerializeField] private EnvironmentData _enviromentData;
    private float xS, yS, zS;

    private void Start()
    {
        for (int i = 0; i < _enviromentData.GameObjects.Length; i++)
        {
            for (int j = 0; j < _enviromentData.AmountOfObjects[i]; j++)
            {
                if (_enviromentData.ScaleToggle[i] == false)
                {
                    xS = 1;
                    yS = 1;
                    zS = 1;
                } 
                else
                {
                    xS = Random.Range(1, _enviromentData.xScale[i]);
                    yS = Random.Range(1, _enviromentData.yScale[i]);
                    zS = Random.Range(1, _enviromentData.zScale[i]);
                }

                _enviromentData.GameObjects[i].transform.localScale = new Vector3(xS,yS,zS);
                Instantiate(_enviromentData.GameObjects[i], new Vector3(
                    Random.Range(-_enviromentData.MaxX[i], _enviromentData.MaxX[i]) + this.transform.position.x,
                    Random.Range(-_enviromentData.MaxY[i], _enviromentData.MaxY[i]) + this.transform.position.y,
                    Random.Range(-_enviromentData.MaxZ[i], _enviromentData.MaxZ[i]) + this.transform.position.z),
                    Quaternion.Euler(
                        Random.Range(-_enviromentData.xRot[i], _enviromentData.xRot[i]),
                        Random.Range(-_enviromentData.yRot[i], _enviromentData.yRot[i]),
                        Random.Range(-_enviromentData.zRot[i], _enviromentData.zRot[i])));
            }
        }
    }

    private void OnDrawGizmos()
    {
        for (int i = 0; i < _enviromentData.GameObjects.Length; i++)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawRay(transform.position, transform.right * _enviromentData.MaxX[i]);
            Gizmos.color = Color.green;
            Gizmos.DrawRay(transform.position, transform.up * _enviromentData.MaxY[i]);
            Gizmos.color = Color.blue;
            Gizmos.DrawRay(transform.position, transform.forward * _enviromentData.MaxZ[i]);
        }
    }
}
