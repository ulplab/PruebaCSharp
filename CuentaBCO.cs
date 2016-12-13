// A Hello World! program in C#.
using System;


namespace Banco
{
    class CuentaBCO 
    {
        object _lock = new object();
        
        int saldo;
        public CuentaBCO(int saldo){
            this.saldo=saldo;
        }
        
        public int Depositar(int cant){
            //lock(_lock){
                saldo  = saldo + cant;
            //}
            return saldo;
        }
        
         public int Retirar(int cant){
            //lock(_lock){            
                saldo = saldo - cant;
            //}
            return saldo;
        }
        
        public int Saldo{get{return saldo;} set{saldo=value;}}
    }
}