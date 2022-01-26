using System;
namespace Metaverso
{
    public class Sistema
    {

        public string  Comprobacionnumero(int numero){

                String numtexto;
                numtexto = numero.ToString();

                if(numero%3==0 && numero%5!=0){
                return "Meta";
            }
            if(numero%5==0 && numero%3!=0){
                return "Verso";
            }
             if (numero%3==0 && numero%5==0)
            {
                return "MetaVerso";
            }
            return numtexto;    
        }
        public string  Comprobacionarray(int[] valores ){
            String numtexto = null;
            String resultado = null;
            
            for(int inc=0;inc<=valores.Length;inc++){
                numtexto = numtexto+" "+valores[inc].ToString();
                

                if(valores[inc]%3==0 && valores[inc]%5!=0){
                    resultado=" meta ";
                //return "Meta";
            }
            if(valores[inc]%5==0 && valores[inc]%3!=0){
                resultado=" Verso ";
                //return "Verso";
            }
             if (valores[inc]%3==0 && valores[inc]%5==0)
            {
                resultado=" metaVerso ";
                //return "MetaVerso";
            }
                resultado+=resultado;
                return resultado;    
            }

            return numtexto ;    
        }
    }
}