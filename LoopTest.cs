class LoopTest
{
    public static void Main()
    {
        string name = "Pratik Kanani";
        bool flag = true;
        int count = 10;
        for(int i = 0; i <= 9; i++)
        {
            System.Console.WriteLine(name + " printing using for-loop");
        }
        while (flag)
        {
            if(count <= 0)
            {
                break;
            }
            System.Console.WriteLine(name + " printing using while-loop");
            count--;
        }
    }
}