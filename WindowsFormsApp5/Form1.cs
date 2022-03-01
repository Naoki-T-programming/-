using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {

        private Dictionary<string, List<Address>> AddressDictionary { get; }
        //アドレスクラスと文字列で辞書を宣言

        public Form1()
        {
            InitializeComponent();
            AddressDictionary = new Dictionary<string, List<Address>>();//アドレス辞書を作る。
            ReadFromFile();

        }

        private void ReadFromFile()　//txtファイルの読み込み
        {
            using (var file = new StreamReader(@"\Users\81906\source\repos\WindowsFormsApp5\WindowsFormsApp5\KEN_ALL.txt", System.Text.Encoding.GetEncoding("shift_jis")))
            {
                while (!file.EndOfStream)
                {
                    var line = file.ReadLine();
                    string[] addressData = line.Split('	');

                    var address = new Address(addressData[2], addressData[6], addressData[7], addressData[8]);
                    if (AddressDictionary.ContainsKey(addressData[2]))
                    {
                        AddressDictionary[addressData[2]].Add(address);//郵便番号が重複していた場合の処理
                    }
                    else
                    {
                        var list = new List<Address>();
                        list.Add(address);

                        AddressDictionary.Add(addressData[2], list);//郵便番号と住所の情報を辞書として登録
                    }
                }
            }

        }

        private void AddButtonClicked(object sender, EventArgs e)
        {
            addressDateSet.addressDataTable.AddaddressDataTableRow(
                    postCodeBox.Text,
                    prefectureBox.Text,
                    municipalityBox.Text,
                    addressBox.Text,
                    nameBox.Text);
            //テキストボックスの中身を住所録へ登録

            postCodeBox.Text = string.Empty;
            prefectureBox.Text = string.Empty;
            municipalityBox.Text = string.Empty;
            addressBox.Text = string.Empty;
            nameBox.Text = string.Empty;
            //登録後にテキストボックスの中身を初期化
        }

        private void DelButtonClicked(object sender, EventArgs e)
        {
            int row = this.addressDataGrid.CurrentRow.Index;
            this.addressDataGrid.Rows.RemoveAt(row);
            //住所録の住所を削除
        }

        private void SearchButtonClicked(object sender, EventArgs e)
        {
            string postcode = this.postCodeBox.Text;
            postcode = postcode.Substring(0, 3) + postcode.Substring(4);
            var addresses = AddressDictionary[postcode];
            var address = addresses.First();
            prefectureBox.Text = address.Prefecture;
            municipalityBox.Text = address.Municipality + address.PlaceName;
            //郵便番号から、住所を検索できるようにする。
        }
    } 
}


