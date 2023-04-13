using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public interface IChairFactory
    {
        IChair CreateChair();
    }
    public interface IChair
    {
        void Sit();
    }
    public class WoodenChairFactory : IChairFactory
    {
        public IChair CreateChair()
        {
            return new WoodenChair();
        }
    }

    public class MetalChairFactory : IChairFactory
    {
        public IChair CreateChair()
        {
            return new MetalChair();
        }
    }

    public class PlasticChairFactory : IChairFactory
    {
        public IChair CreateChair()
        {
            return new PlasticChair();
        }
    }

    public class WoodenChair : IChair
    {
        public void Sit()
        {
            MessageBox.Show("You sit on a comfortable wooden chair.");
        }
    }

    public class MetalChair : IChair
    {
        public void Sit()
        {
            MessageBox.Show("You sit on a cold, hard metal chair.");
        }
    }

    public class PlasticChair : IChair
    {
        public void Sit()
        {
            MessageBox.Show("You sit on a flimsy plastic chair.");
        }
    }

}
