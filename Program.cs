namespace BinarySearchTreeProblems
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Bianry search Tree Problems");

            Console.WriteLine("\nCreate Binary Search Tree by adding 56 and then adding 30 & 70\n");
            BinarySearchTree<int> bst = new BinarySearchTree<int>(56);
            bst.Insert(30);
            bst.Insert(70);
            bst.Display();
            
        }
    }
}
