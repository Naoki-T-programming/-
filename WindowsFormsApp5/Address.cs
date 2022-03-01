using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    class Address
    {
        public string PostCode { get; }
        public string Prefecture { get; }    //都道府県
        public string Municipality { get; }  //市町村
        public string PlaceName { get; }    //地名

        public Address(string postCode, string prefecture, string municipality, string placeName)
        {
            PostCode = postCode;
            Prefecture = prefecture;
            Municipality = municipality;
            PlaceName = placeName;
        }//アドレスクラスに郵便番号、都道府県、市町村、地名の情報をまとめる

       
    }
   
}
