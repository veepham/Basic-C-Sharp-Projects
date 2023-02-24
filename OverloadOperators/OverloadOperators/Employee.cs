using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperators
{
    public class Employee : Person
    {        
        public int Id { get; set; }

        public static bool operator ==(Employee employee1, Employee employee2)
        {            
            if (employee1.Id == employee2.Id)
            {
                return employee1.Id == employee2.Id;
            }
            else
            {
                return false;
            }           
        }

        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return employee1 != employee2;
                      
        }

        public override bool Equals(Object obj)
        {
            Employee employee = obj as Employee;
            if (employee == null)
            {
                return false;
            }
            return this.Id.Equals(employee.Id);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
