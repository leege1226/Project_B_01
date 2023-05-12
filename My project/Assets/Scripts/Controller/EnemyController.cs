using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public float speed = 5.0f;              //���� �ӵ� ����
    public float rotationSpeed;              //���� ��ž ȸ�� �ӵ�

    public GameObject bulletPrefab;         //�Ѿ� ������
    public GameObject enemyPivot;           //�� ��ž �Ǻ�

    public Transform firePoint;             //�߻� ��ġ
    public float fireRate = 1.0f;           //�߻� �ӵ�
    public float nextFireTime;              //���� �߻� �ð�

    private Rigidbody rb;                   //Rigidbody ����
    private Transform player;               //�÷��̾� ��ġ �������� ���� ����

    void Start()
    {
        rb = GetComponent<Rigidbody>();     //������ �� �ڽ��� Rigidbody�� �޾ƿ´�.
        player = GameObject.FindGameObjectWithTag("Player").transform;      //Scene���� Player Tag�� ���� ������Ʈ�� �����ͼ� Transform�� ����
    }

    void Update()
    {
        if(player != null)
        {
            if (Vector3.Distance(player.position, transform.position) > 1.0f)        //Vector3.Distance < �Ÿ��� �˷��ִ� �Լ�
            {
                Vector3 direction = (player.position - transform.position).normalized;      //�� ���͸� ���� Normlized �ϸ� ���� ���� �˷���
                rb.MovePosition(transform.position + direction * speed * Time.deltaTime);   //�÷��̾ ���ؼ� ������ speed �ӵ��� �̵�
            }

            //��ž ȸ��
            Vector3 targetDirection = (player.position - enemyPivot.transform.position).normalized;         //�� ���͸� ���� Normalized�ϸ� ���� ���� �˷���,
            Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
            enemyPivot.transform.rotation = Quaternion.Lerp(enemyPivot.transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

            if (Time.time > nextFireTime)
            {
                nextFireTime = Time.time + 1.0f / fireRate;
                GameObject temp = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
                temp.GetComponent<ProjectileMove>().IaunchDirection = firePoint.localRotation * Vector3.forward;
                temp.GetComponent<ProjectileMove>().bulletType = ProjectileMove.BULLETTYPE.ENEMY;
            }
        }

        
    }
}
