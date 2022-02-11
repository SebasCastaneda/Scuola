using System;
using System.Collections.Generic;
using System.Text;

namespace Scuola
{
    class Alunno
    {
        //con questo metodo puo calcolare in che classe appartien un alunno.
        //ciao

        public string ANNO (int eta)
            {
              string classe = "";
                if(eta>=17)
                {
                classe="trienio";

                 }
             else
            {

                classe="biennio";
             }
        }


    }
       

}
 

