﻿using System;

namespace temp1
{
    class DatabaseConnection
    {
        //attributes
        private static DatabaseConnection _instance;

        private static string connectionStr;

        private System.Data.SqlClient.SqlConnection connectionToDB;

        private System.Data.SqlClient.SqlDataAdapter dataAdapter;

        //constructors


        //properties
        public static string ConnectionStr
        {
            set
            {
                connectionStr = value;
            }
        }


        //methods
        //return the connection to the database
        public static DatabaseConnection getDBConnectionInstance()
        {
            if (_instance == null)
            {
                _instance = new DatabaseConnection();
            }

            return _instance;
        }


        // Open the connection
        public void openConnection()
        {
            // create the connection to the database as an instance of System.Data.SqlClient.SqlConnection
            connectionToDB = new System.Data.SqlClient.SqlConnection(connectionStr);

            //open the connection
           // connectionToDB.Open();
        }

        public void closeConnection()
        {
            //close the connection to the database
            connectionToDB.Close();

        }

        public System.Data.DataSet getDataSet(String sqlQuery)
        {
            System.Data.DataSet dataSet;

            openConnection();

            // create the dataAdapter object
            dataAdapter = new System.Data.SqlClient.SqlDataAdapter(sqlQuery, connectionToDB);

            //create the dataSet object
            dataSet = new System.Data.DataSet();

            //fill in the dataSet with the data coming from the DB 
            //dataAdapter.Fill(dataSet);

            closeConnection();
            //return the dataset
            return dataSet;
        }
    }
}