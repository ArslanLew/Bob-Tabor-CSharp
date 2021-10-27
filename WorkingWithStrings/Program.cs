using System;
using System.Text;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string MyString = "My \"so-called\" life";
            //string MyString = "What if I need a\nnew line";
            //string MyString = "Go to your C:\\ drive";
            //string MyString = @"Go to your C:\ drive";
            //string MyString = String.Format("{0} = {1}", "First", "Second");

            //string MyString = String.Format("{0:C}", 123.45);
            //string MyString = String.Format("{0:N}", 1234567890.40);
            //string MyString = String.Format("{0:P}", .12345);
            //string MyString = String.Format("Phone Number: +44 {0:##### ######}", 7505541256);

            //string MyString = " This is a cool string ";
            //MyString = MyString.Substring(11, 4);
            //MyString = MyString.ToUpper();
            //MyString = MyString.Replace(" ", "--");
            //MyString = MyString.Remove(11, 5);
            //MyString = String.Format("Length before: {0} -- Length after: {1}", MyString.Length, MyString.Trim().Length);

            //string MyString = "";

            //for (int i = 0; i < 100; i++)
            //{
            //    MyString += "--" + i.ToString();
            //}

            StringBuilder MyString = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                MyString.Append("--");
                MyString.Append(i);
            }

            Console.WriteLine(MyString);
            Console.ReadLine();
        }
    }
}
