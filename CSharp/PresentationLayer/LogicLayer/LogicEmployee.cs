using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace LogicLayer
{
    public class LogicEmployee
    {
        public static List<EntityEmployee> LLListOfStaff()
        {
            return DALEmployee.ListOfStaff();
        }

        public static int LLAddStaff(EntityEmployee e)
        {
            if(e.Name!=""&& e.Surname!="")
            {
                return DALEmployee.AddStaff(e);
            }
            else
            {
                return -1;
            }
        }

        public static bool LLDeleteStaff (int per)
        {
            if(per>=1)
            {
                return DALEmployee.LLDeleteStaff(per);
            }
            else
            {
                return false;
            }
        }

        public static bool LLUpdateStaff(EntityEmployee emp)
        {
            if (emp.Name.Length>=3 && emp.Name!="")
            {
                return DALEmployee.UpdateStaff(emp);
            }
            else
            {
                return false;
            }
        }
        
    }
}
