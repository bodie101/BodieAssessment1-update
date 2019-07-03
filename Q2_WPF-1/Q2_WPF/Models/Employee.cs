using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Q2_WPF.Models
{
    
        public class Employee 
        {
            public string Name { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }

            public string Display_Employee(List<Employee> Data)
            {
                string output = "";
                foreach (Employee i in Data)
                {
                    output += $"Name: {i.Name} \nPhone Number: {i.Phone} \nEmail: {i.Email} \n\n";
                }
                return output;
            }
        }


    }
}
