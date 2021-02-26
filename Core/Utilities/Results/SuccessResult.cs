using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {
        //Bunu kullanarak yazılımcı dönüşte true döndürüyor ve mesaj döndürüyor
        public SuccessResult(string message):base(true,message)
        {

        }

        //Mesaj döndürmek istemezse sadece bool değer döndürmek için bunu kullanacak
        public SuccessResult():base(true)
        {

        }
    }
}
