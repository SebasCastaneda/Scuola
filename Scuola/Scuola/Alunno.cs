using System;
using System.Collections.Generic;
using System.Text;

namespace Scuola
{
    class Alunno
    {


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
 

