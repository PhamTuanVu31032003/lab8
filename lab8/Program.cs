internal class Program
{
    private static void Main(string[] args)
    {
        List<int> firstlists = new List<int>();
        //Console.WriteLine("do dai cua mang la {0}",firstlist.Count);
        firstlists.Add(1); // chi so 0, phan tu 1
        firstlists.Add(2);
        firstlists.Add(3);
        firstlists.Add(5);
        //Console.WriteLine("do dai cua mang la {0}", firstlist.Count);
        //Console.WriteLine("capacity{0}", firstlist.Capacity);
        firstlists.Add(4);
        firstlists.Add(7);
        //Console.WriteLine("do dai mang la{0}", firstlist.Count); 
        //Console.WriteLine("capacity{0}", firstlist.Capacity);
        firstlists.Add(6);
        firstlists.Add(9);
       // Console.WriteLine("do dai mang la{0}", firstlist.Count);
        //Console.WriteLine("capacity{0}", firstlist.Capacity);
         //Console.WriteLine(firstlist.Contains(8));
         /*firstlists.RemoveAt(5); // remove chi so
         foreach (var item in firstlists){
            Console.WriteLine(item);
         } */
         firstlists.Sort();
         foreach (var item in firstlists){
            Console.WriteLine(item);
         }
       
        /* firstlists.Reverse();
         foreach (var item in firstlists){
            Console.WriteLine(item);
         }*/
         thuong ngu vkl

    }
}