// A Hello World! program in C#.
using System;
using System.Threading;

namespace Banco
{
    class Cuenta 
    {
        static void Main() 
        {
            CuentaBCO c = new CuentaBCO(100);
            
        Thread deposita = new Thread(() => {
            for (int i = 0; i < 1000; i++)
            {
                
                c.Depositar(10);
                Thread.Sleep(1);
            }
        });

        Thread deposita2 = new Thread(() => {
            for (int i = 0; i < 1000; i++)
            {
                
                c.Depositar(10);
                Thread.Sleep(1);
            }
        });

        
        Thread retira = new Thread(() => {
            for(int i = 0; i<1000;i++ ){
            
                c.Retirar(10);
                Thread.Sleep(1);
            }

        });
        
        Thread retira2 = new Thread(() => {
            for(int i = 0; i<1000;i++ ){
            
                c.Retirar(10);
                Thread.Sleep(1);
            }

        });



        Thread deposita3 = new Thread(() => {
            for (int i = 0; i < 1000; i++)
            {
                
                c.Depositar(10);
                Thread.Sleep(1);
            }
        });

        Thread deposita23 = new Thread(() => {
            for (int i = 0; i < 1000; i++)
            {
                
                c.Depositar(10);
                Thread.Sleep(1);
            }
        });

        
        Thread retira3 = new Thread(() => {
            for(int i = 0; i<1000;i++ ){
            
                c.Retirar(10);
                Thread.Sleep(1);
            }

        });
        
        Thread retira23 = new Thread(() => {
            for(int i = 0; i<1000;i++ ){
            
                c.Retirar(10);
                Thread.Sleep(1);
            }

        });


        
        deposita.Start();
        retira.Start();
        deposita2.Start();
        retira2.Start();
        
        deposita3.Start();
        retira3.Start();
        deposita23.Start();
        retira23.Start();


        try{
            deposita.Join();
            retira.Join();
            deposita2.Join();
            retira2.Join();

            deposita3.Join();
            retira3.Join();
            deposita23.Join();
            retira23.Join();
        }catch(Exception ex){
            Console.WriteLine(ex.Message);
            
        }finally{
            
            Console.WriteLine(c.Saldo);
        }
        
        
            
            
        }
    }
}