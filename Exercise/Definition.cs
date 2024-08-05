using System;
using System.Collections;
using System.Net.Http.Headers;

public class CollectionDefinition
{
    //URL: https://www.scholarhat.com/tutorial/csharp/difference-between-generics-and-collections-with-example
    //URL: https://enterprisecraftsmanship.com/posts/read-only-collections-and-lsp/
    //URL: https://sikilinda.com/posts/dot-net-collections-mind-map/
    //URL: https://cheatography.com/masterofcode/cheat-sheets/c-collection/


    //Definition
    //C# collection are designed to store, manage and manipulate similar data more efficiently.
    //Data manipulation meaning adding, removing, finding and inserting data in the collection.
    //Type of collections: Generic collections and Non-Generic collections

    public void Definition()
    {
        // Classes
        int[] array = new int[10];
        List<int> list = new List<int>();
        LinkedList<int> linkedList = new LinkedList<int>();
        Queue<int> queue = new Queue<int>();
        Stack<int> stack = new Stack<int>();
        HashSet<int> set = new HashSet<int>();
        Dictionary<int, string> dictionary = new Dictionary<int, string>();

        // Interfaces
        ICollection<int> collection = list;
        IEnumerable<int> enumerable = list;
        IEnumerator<int> enumerator = enumerable.GetEnumerator();
        IList<int> iList = list;
        IDictionary<int, string> iDictionary = dictionary;
    }
}
