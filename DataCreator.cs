using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCheckedListBox
{
    public static class DataCreator
    {
        public static List<MyData> CreateData()
        {
            var list = new List<MyData>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(new MyData
                {
                    Student = $"AX{i}",
                    Age = i + 10
                });
            }
            return list;
        }

    }

    public class MyData
    {
        public string Student { get; set; }

        public int Age { get; set; }
    }
}
