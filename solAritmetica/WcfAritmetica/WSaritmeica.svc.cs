﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfAritmetica
{

    public class WSaritmetica : IWSaritmetica

    {
        public clsAritmetica sumar(int numero1, numero2)


        { 
    
    clsAritmetica obj = new clsAritmetica();
    obj.numeroA = numero1;
           obj.numeroB = numero2;
           obj.resultado = obj.numeroA + obj.numeroB;
           
          
           return obj;
    }
}
}