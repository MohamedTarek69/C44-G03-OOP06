using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06.Abstraction
{
    internal abstract class Shape
    {
        #region Properties
        public decimal Dim01 { get; set; }
        public decimal Dim02 { get; set; }

        public abstract decimal Perimter { get; }

        #endregion

        #region Constructors
        protected Shape(decimal d01 , decimal d02)
        {
            Dim01 = d01;
            Dim02 = d02;
        }

        #endregion

        #region Methods
        public abstract decimal CalcArea();

        #endregion
    }
    // Class : Class => Inhetence
    // Class : Interface => Implement
    // Struct : Interface => Implement
    // Calss : Abstract Calss => Implement, Inhetence
    // Concreate Class

    abstract class RefBase : Shape
    {
        #region Constructors
        protected RefBase(decimal d01, decimal d02) : base(d01, d02)
        {

        } 

        #endregion

        #region Methods
        public override decimal CalcArea()
        {
            return Dim01 * Dim02;
        }

        #endregion
    }

    class Rectangle : RefBase
    {
        #region Properties
        public override decimal Perimter 
        { 
            get 
            { 
                return Dim01 * Dim02 * 2;
            } 
        }

        #endregion

        #region Constructos
        public Rectangle(decimal d01, decimal d02) : base(d01, d02)
        {
            
        }

        #endregion

    }

    class Square : RefBase
    {
        #region Properties
        public override decimal Perimter
        { 
            get 
            {
                return Dim01 * 4; 
            } 
        }

        #endregion

        #region Constructors
        public Square(decimal Side) : base(Side , Side)
        {
            //Dim01 = Dim02 = Side;
        }

        #endregion

    }

    class Circle : Shape
    {
        #region Properties
        public override decimal Perimter 
        {
            get 
            {
                //return 2 * Dim01 * 3.14M;
                return 2 * Dim01 * (decimal)Math.PI;
            } 
        }

        #endregion

        #region Constructors 
        public Circle(decimal Redius) : base(Redius , Redius)
        {
            //Dim01 = Dim02 = Redius;
        }

        #endregion

        #region Methods
        public override decimal CalcArea()
        {
            return (decimal)Math.PI * Dim01 * Dim02;
        }

        #endregion

    }

}
