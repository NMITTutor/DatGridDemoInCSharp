using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace DatGridDemoInCSharp
{
    public class DataAccessClass
    {
        private static String connectionString = "Server=localhost;Port=3306;Database=sapodb;Uid=sapo;password=53211;";
        private MySqlConnection mySqlConnection = new MySqlConnection(connectionString);

        public DataSet AddUserName(String pUserName)
        {


            List<MySqlParameter> p = new List<MySqlParameter>();

             MySqlParameter aP = new MySqlParameter("@UserName", MySqlDbType.VarChar, 50);
            aP.Value = pUserName;
            p.Add(aP);

             var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "AddUserName(@UserName)", p.ToArray());

           return aDataSet;
        }




        public List<PlayerInDB> GetAllPlayers()
        {
  
            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "Call GetAllPlayers()");

            List<PlayerInDB> dataList = new List<PlayerInDB>();

            foreach (DataRow row in aDataSet.Tables[0].Rows)
            {
                 PlayerInDB aPlayer = new PlayerInDB();
                aPlayer.UserName = row.Field<string>("Username");
                aPlayer.Strength = row.Field<int>("Strength");
                 dataList.Add(aPlayer);
            }

  
            return dataList;
        }

        public List<Message> UpDatePlayer(String prUserName, Int32 prStrength)
        {


           List<MySqlParameter> p = new List<MySqlParameter>();

            MySqlParameter aPUserName = new MySqlParameter("@UserName", MySqlDbType.VarChar, 50);
            MySqlParameter aPStrength = new MySqlParameter("@Strength", MySqlDbType.Int32);
            aPUserName.Value = prUserName;
            p.Add(aPUserName);

            aPStrength.Value = prStrength;
            p.Add(aPStrength);

            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "call UpdatePlayer(@UserName, @Strength)", p.ToArray());
            List<Message> dataList = new List<Message>();
            foreach (DataRow row in aDataSet.Tables[0].Rows)
            {
                Message aMessage = new Message();
                aMessage.TheMessage = row.Field<string>("Message");
                dataList.Add(aMessage);
            }
           return dataList;
        }
    }
    public class Message
    {
            //Public Class Message
            //    Private _Message As String
            private string _Message;

            public string TheMessage { get => _Message; set => _Message = value; }


    }

    public class PlayerInDB
    {

        //    Private _Username As String
        private string _UserName;
        private Int32 _Strength;

        public string UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                
                _UserName = value;
            }
        }

        public int Strength
        {
            get
            {
                return _Strength;
            }

            set
            {
              
                _Strength = value;
            }
        }


  

   
        private EditAccountForm editForm;
        public void Edit(DemoGVForm pParent)
        {
            if (editForm == null)
            {
                editForm = new EditAccountForm(pParent);
                editForm.lcPlayerINDB = this;
                

            }
            editForm.UserNameTxt.Text = _UserName;
                editForm.Strengthtxt.Text = _Strength.ToString();
            editForm.ShowDialog();
        }
            
       }

    }

