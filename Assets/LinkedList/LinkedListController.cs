using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkedListController : MonoBehaviour
{
    public LinkedList<GameObject> breadCrumbs = new LinkedList<GameObject>();
    public GameObject breadCrumbPrefab; // Örnek: Ekmek kırıntısı nesnesi prefabı


    void Update()
    {
        // Oyuncu hareket kontrolleri burada olabilir

        // Oyuncu bir ekmek kırıntısı bıraktığında
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DropBreadCrumb();
        }

        // Oyuncu bir tuşa basarak geri dönmek istediğinde
        if (Input.GetKeyDown(KeyCode.R))
        {
            ReturnToBreadCrumb();
        }
    }

    void DropBreadCrumb()
    {
        // Yerine ekmek kırıntısı nesnesi bırak
        GameObject breadCrumb = Instantiate(breadCrumbPrefab, transform.position, Quaternion.identity);
        breadCrumbs.AddLast(breadCrumb);
    }

    public void RemoveFirstBreadCrumb()
    {
        if (breadCrumbs.Count > 0)
        {
            GameObject firstCrumb = breadCrumbs.First.Value;
            breadCrumbs.RemoveFirst();
            Destroy(firstCrumb);
        }
    }

    void ReturnToBreadCrumb()
    {
        // Geri dönmek istediğimizde son ekmek kırıntısına git
        if (breadCrumbs.Count > 0)
        {
            GameObject lastCrumb = breadCrumbs.Last.Value;
            transform.position = lastCrumb.transform.position;

            // Ekmek kırıntısını kaldır
            Destroy(lastCrumb);
            breadCrumbs.RemoveLast();
        }
    }

    public void RemoveBreadCrumbFromList(GameObject crumb)
    {
        if (breadCrumbs.Contains(crumb))
        {
            breadCrumbs.Remove(crumb);
            Destroy(crumb);
        }
    }

    public void RemoveRandomBreadCrumbs(int count)
    {
        if (count <= 0 || count > breadCrumbs.Count)
        {
            return; // Silinecek ekmek kırıntısı sayısı uygun değilse işlemi iptal et
        }

        List<int> indicesToRemove = new List<int>();

        // Rastgele indeksleri seç
        while (indicesToRemove.Count < count)
        {
            int randomIndex = Random.Range(0, breadCrumbs.Count);
            if (!indicesToRemove.Contains(randomIndex))
            {
                indicesToRemove.Add(randomIndex);
            }
        }

        // Seçilen indekslere sahip ekmek kırıntılarını sil
        foreach (int index in indicesToRemove)
        {
            RemoveBreadCrumbAtIndex(index);
        }
    }

    public void RemoveBreadCrumbAtIndex(int index)
    {
        if (index >= 0 && index < breadCrumbs.Count)
        {
            LinkedListNode<GameObject> nodeToRemove = breadCrumbs.First;
            for (int i = 0; i < index; i++)
            {
                nodeToRemove = nodeToRemove.Next;
            }
            GameObject crumbToRemove = nodeToRemove.Value;

            // Bellekten kaldırma işlemi öncesi null kontrolü yapın
            if (crumbToRemove != null)
            {
                // Eğer oyun nesnesi hala sahnede ise sahneden kaldırın
                if (Application.isPlaying)
                {
                    Destroy(crumbToRemove);
                }
                else
                {
                    // Düzenleme modundayken sahneden kaldırmayın
                    DestroyImmediate(crumbToRemove);
                }
            }

            // LinkedList'den düğümü kaldırın
            breadCrumbs.Remove(nodeToRemove);
        }
    }


    public void InsertBreadCrumbAtIndex(int index)
    {
        if (index >= 0 && index <= breadCrumbs.Count)
        {
            GameObject breadCrumb = Instantiate(breadCrumbPrefab, transform.position, Quaternion.identity);
            LinkedListNode<GameObject> newNode = new LinkedListNode<GameObject>(breadCrumb);

            // İlgili konuma yeni ekmek kırıntısını ekleyin
            LinkedListNode<GameObject> nodeToInsertAfter = breadCrumbs.First;
            for (int i = 0; i < index; i++)
            {
                nodeToInsertAfter = nodeToInsertAfter.Next;
            }

            breadCrumbs.AddAfter(nodeToInsertAfter, newNode);
        }
    }


}
