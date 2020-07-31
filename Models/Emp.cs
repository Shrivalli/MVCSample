using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCSample.Models
{
    public class Emp
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public float Salary { get; set; }

        public Emp(int eid,string ename,float sal)
        {
            Eid = eid;
            Ename = ename;
            Salary = sal;
        }

        public static List<Emp> getEmps()
        {
            List<Emp> employees = new List<Emp>();
            employees.Add(new Emp(1, "Ram", 87000));
            employees.Add(new Emp(2, "Raghav", 54000));
            employees.Add(new Emp(3, "Suresh", 23000));
            employees.Add(new Emp(4, "Ramesh", 98000));
            return employees;
        }
    }
}