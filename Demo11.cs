using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeDemos
{
    // ISP - Interface Segregartion Principle

    //public interface ILead
    //{
    //    void CreateSubTask();
    //    void AssignTask();
    //    void WorkOnTask();
    //}
    //public class TeamLead : ILead
    //{
    //    public void AssignTask()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void CreateSubTask()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void WorkOnTask()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //public class Manager : ILead
    //{
    //    public void AssignTask()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void CreateSubTask()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void WorkOnTask()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    public interface IProgrammer
    {
        void WorkOnTask();
    }

    public interface ILead 
    {
        void AssignTask();
        void CreateSubTask();
    }

    public class Programmer : IProgrammer
    {
        public void WorkOnTask()
        {
            throw new NotImplementedException();
        }
    }

    public class Manager : ILead
    {
        public void AssignTask()
        {
            throw new NotImplementedException();
        }

        public void CreateSubTask()
        {
            throw new NotImplementedException();
        }
    }

    public class TeamLead : IProgrammer, ILead
    {
        public void AssignTask()
        {
            throw new NotImplementedException();
        }

        public void CreateSubTask()
        {
            throw new NotImplementedException();
        }

        public void WorkOnTask()
        {
            throw new NotImplementedException();
        }
    }



    class Demo11
    {
    }
}
