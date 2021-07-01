using System;
using System.Data.Entity.Core.Objects;
using System.Linq;

namespace HRSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            LINQAssignmentEntities db = new LINQAssignmentEntities();
            //            1.LIST ALL THE DATA FROM THE EMPLOYEE TABLE
            //var qry = from e in db.EMPs select e;
            //foreach(var item in qry)
            //{
            //    //Console.WriteLine(item.EMPNO+"\t"+item.ENAME + "\t" + item.DEPTNO);
            //    Console.WriteLine(item.ENAME);
            //}

            //2.LIST ALL THE DATA FROM THE EMPLOYEE TABLE ORDER BY JOB
            //var qry = from e in db.EMPs orderby e.JOB select e;
            //foreach (var item in qry)
            //{
            //    Console.WriteLine(item.ENAME + "\t" + item.JOB);
            //}

            //3.LIST ALL THE DATA FROM THE EMPLOYEE TABLE WHOSE NAME START WITH S
            //var qry = from e in db.EMPs where e.ENAME.StartsWith("S") select e;
            //foreach (var item in qry)
            //{
            //    Console.WriteLine(item.ENAME);
            //}
            //4.LIST DISTINCT JOB
            //var qry = (from e in db.EMPs select e.JOB).Distinct();
            //foreach (var job in qry)
            //{
            //    Console.WriteLine(job);
            //}
            //5.FIND THE DETAILS OF ALL MANAGER(IN ANY DEPT) AND ALL CLERKS IN DEPT 10
            //var qry = from e in db.EMPs where (e.JOB=="MANAGER"||(e.JOB=="CLERK" && e.DEPTNO==10))  select e;
            //foreach (var item in qry)
            //{
            //    Console.WriteLine(item.ENAME+"\t"+item.JOB+"\t"+item.DEPTNO);
            //}
            //6.FIND THE EMPLOYEES WHO DO NOT RECEIVE A COMMISSION
            //var qry = from e in db.EMPs where e.COMM==null select e;
            //foreach (var item in qry)
            //{
            //    Console.WriteLine(item.ENAME);
            //}

            //7.FIND ALL EMPLOYEES WHOSE NET EARNINGS(SAL + COMM) IS GREATER THAN RS. 2000
            //var qry = from e in db.EMPs where (e.SAL + e.COMM) > 2000 select e;
            //foreach (var item in qry)
            //{
            //    Console.WriteLine(item.ENAME + "\t" + item.SAL + "\t" + item.COMM + "\t" + (item.SAL + item.COMM));
            //}

            //8.FIND ALL EMPLOYEE HIRED IN MONTH OF FEBUARY(OF ANY YEAR)
            //var qry = from e in db.EMPs where e.HIREDATE.Value.Month==2 select e;
            //foreach (var item in qry)
            //{
            //    Console.WriteLine(item.ENAME);
            //}

            //9.LIST TOTAL SALARY FOR THE ORGANIZATION
            //var qry = (from e in db.EMPs select e.SAL).Sum();
            //Console.WriteLine(qry);
            //Sum of Salary = 29025.00

            //10.LIST TOTAL EMPLOYEES WORKS IN EACH DEPARTMENT
            //var qry = from e in db.EMPs group e by e.DEPTNO into empg
            //           select new
            //           {
            //               Name = empg.Key,
            //               Count = empg.Count()  //x=>x.EMPNO!=null
            //           };
            //foreach (var item in qry)
            //{
            //    Console.WriteLine(item.Name+"\t"+item.Count);
            //}

            //11.LIST FIRST THREE HIGHEST PAID EMPLOYEES
            //var qry1 = from e in db.EMPs select e;
            //var qry=qry1.OrderByDescending(e => e.SAL).Take(3);
            //foreach (var item in qry)
            //{
            //    Console.WriteLine(item.ENAME+"\t"+item.SAL);
            //}

            //12.DISPLAY THE NAMES, JOB AND SALARY OF ALL EMPLOYEES, SORTED ON  DESCENDING ORDER OF JOB AND WITHIN JOB, SORTED ON THE DESCENDING ORDER OF SALARY
            //var qry = (from e in db.EMPs select e).OrderByDescending(e=>e.JOB).ThenByDescending(e=>e.SAL);
            //foreach (var item in qry)
            //{
            //    Console.WriteLine(item.ENAME+"\t"+item.JOB + "\t" +item.SAL);
            //}
            //13.LIST DEPARTMENT NAME, EMPLOYEE NAME AND JOB
            //var qry = from e in db.EMPs join d in db.DEPTs on e.DEPTNO equals d.DEPTNO select new { d.DNAME, e.ENAME, e.JOB};
            //foreach (var item in qry)
            //{
            //    Console.WriteLine(item.DNAME+"\t"+item.ENAME + "\t" +item.JOB);
            //}
            //14.LIST DEPARTMENT NAME AND MAX SALARY FOR EACH DEPARTMENT
            //var qry = from e in db.EMPs join d in db.DEPTs on e.DEPTNO equals d.DEPTNO
            //          group e by d.DNAME into empg
            //            select new
            //            {
            //                dName = empg.Key,
            //                maxSal = empg.Max(x=>x.SAL)  
            //            };
            //foreach (var item in qry)
            //{
            //    Console.WriteLine(item.dName + "\t" + item.maxSal);
            //}

            //15.LIST DEPARTMENT NAME AND TOTAL EMPLOYEE WORKING IN EACH DEPARTMENT ALSO INCLUDE DEPARTMENT WHERE NO EMPLOYEES ARE WORKING
            //var qry = from d in db.DEPTs 
            //          join e in db.EMPs on e.DEPTNO equals d.DEPTNO
            //            group e by d.DNAME
            //           into grp
            //          from data in productdata.DefaultIfEmpty()
            //          select new { c.CategoryName, data.ProductName, data.UnitPrice };
            //          select new
            //          {
            //              dName = empg.Key,
            //              total = empg.Count()  
            //          };
            //foreach (var item in qry)
            //{
            //    Console.WriteLine(item.dName + "\t" + item.total);
            //}

            //ACCOUNTING      CLARK MANAGER 2450.00
            //ACCOUNTING MILLER  CLERK   1300.00
            //RESEARCH SMITH   CLERK   800.00
            //RESEARCH JONES   MANAGER 2975.00
            //RESEARCH SCOTT   ANALYST 3000.00
            //RESEARCH ADAMS   CLERK   1100.00
            //RESEARCH FORD    ANALYST 3000.00
            //SALES ALLEN   SALESMAN        1600.00
            //SALES WARD    SALESMAN        1250.00
            //SALES MARTIN  SALESMAN        1250.00
            //SALES BLAKE   MANAGER 2850.00
            //SALES TURNER  SALESMAN        1500.00
            //SALES JAMES   CLERK   950.00
            //OPERATIONS

            //16.SELECT Dept Name FROM Department TABLE
            //WHILE DISPLAYING DATA ALSO DISPLAY Emp Name BASED ON Department
            //var qry = from d in db.DEPTs join e in db.EMPs on d.DEPTNO equals e.DEPTNO select new { dname=d.DNAME, elist=e};
            //foreach (var item in qry)
            //{
            //    Console.WriteLine($"{item.dname}");
            //    Console.WriteLine();
            //    //foreach(var i in item.elist)
            //    Console.WriteLine($"{item.elist}");
            //}
            //ACCOUNTING
            //        CLARK
            //        MILLER
            //RESEARCH
            //        SMITH
            //        JONES
            //        SCOTT
            //        ADAMS
            //        FORD
            //SALES
            //        ALLEN
            //        WARD
            //        MARTIN
            //        BLAKE
            //        TURNER
            //        JAMES
            //OPERATIONS

            //17.INSERT NEW DEPARTMENT AND EMPLOYEE FOR THAT DEPARTMENT
            //DEPT newDEPT = new DEPT()
            //{
            //    DEPTNO = 50,
            //    DNAME = "IT"
            //};
            //db.DEPTs.Add(newDEPT);
            //EMP newEMP = new EMP()
            //{
            //    EMPNO = 1001,
            //    ENAME = "RAHUL"
            //};
            //db.EMPs.Add(newEMP);
            //db.SaveChanges();
            //DEPTNO = 50, DEPTNAME = IT
            //EMPNO = 1001, EMPNAME = RAHUL

            //18.UPDATE Rahul RECORD WITH SAL = 20000
            //EMP updEMP = new EMP()
            //{
            //    EMPNO=1001,
            //    ENAME="RAHUL",
            //    SAL = 20000
            //};
            //db.Entry(updEMP).State = System.Data.Entity.EntityState.Modified;
            //db.SaveChanges();
            //19.Delete Record of Rahul
            //EMP e = db.EMPs.SingleOrDefault(x => x.EMPNO == 1001);
            //if (e != null)
            //{
            //    db.EMPs.Remove(e);
            //    db.SaveChanges();
            //}
            //20.Write a stored procedure in SQL Server name it as JobWiseDetails which takes Job as in parameter and return Total Employee, Max Salary and Min Salary for the Job
            //var returnData = db.JobWiseDetails("MANAGER");
            //Console.WriteLine(returnData[0]);
            ObjectParameter cnt = new ObjectParameter("count", typeof(int));
            ObjectParameter mxsal = new ObjectParameter("mxSal", typeof(decimal));
            ObjectParameter mnsal = new ObjectParameter("mnSal", typeof(decimal));
            db.JobWiseDetails("MANAGER", cnt,mxsal,mnsal);
            Console.WriteLine(cnt.Value);

            //For Job = Manager
            //Total emp = 3
            //Max Salary = 2975
            //Min Salary = 2450



            Console.ReadKey();
        }
    }
}
